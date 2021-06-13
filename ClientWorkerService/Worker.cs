using ClientGrpcService.Protos;
using DocumentGrpcService.Protos;
using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ClientWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _config;
        private readonly ClientProtoService.ClientProtoServiceClient _clientProtoService;
        private readonly DocumentProtoService.DocumentProtoServiceClient _documentProtoService;

        public Worker(ILogger<Worker> logger, IConfiguration config, ClientProtoService.ClientProtoServiceClient clientProtoService, DocumentProtoService.DocumentProtoServiceClient documentProtoService)
        {
            _logger = logger;
            this._config = config;
            this._clientProtoService = clientProtoService;
            this._documentProtoService = documentProtoService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {


            while (!stoppingToken.IsCancellationRequested)
            {
                var request = new GetClientRequest() { ClientId = 1 };

                this._logger.LogDebug($"List client Id ${request.ClientId}");

                try
                {
                    GetClients(request);

                    GetDocumentForClient();

                    await GetDocumentStream();

                    await CreateDocumentsStream();

                }
                catch (RpcException ex) when (ex.StatusCode == StatusCode.NotFound)
                {
                    Console.WriteLine($"ClientId '{request.ClientId} was not found!");

                    this._logger.LogError("Failed to find ClientId {ClientId}", request.ClientId);
                }
                catch (RpcException ex)
                {
                    this._logger.LogError(ex.Message + ex?.InnerException?.Message + ex?.InnerException?.InnerException?.Message + ex.StackTrace, request.ClientId);
                }



                await Task.Delay(5000, stoppingToken);
            }

        }

        private async Task CreateDocumentsStream()
        {
            this._logger.LogInformation("Stream is open to send documents");

            //open stream
            using (var documentStream = this._documentProtoService.CreateDocumentStream())
            {

                try
                {
                    var document = new CreateDocumentModelRequest()
                    {
                        ClientId = 1,
                        DocumentType = "pdf",
                        Name = $"Document_{DateTime.Now}"
                    };

                    await documentStream.RequestStream.WriteAsync(document);
                }
                finally
                {
                    await documentStream.RequestStream.CompleteAsync();

                }

                CreateDocumentResponse createDocumentRespond = await documentStream;

                this._logger.LogInformation("Document added to stream {documentInsetedCount}", createDocumentRespond.InsertCount);
            }
        }

        private async Task GetDocumentStream()
        {
            this._logger.LogInformation("Starting to get stream");
            try
            {
                using (var documentData = this._documentProtoService.GetDocumentsStream(new GetAllDocumentsRequest() { ClientId = 1 }))
                {
                    await foreach (var respondData in documentData.ResponseStream.ReadAllAsync())
                    {
                        //Each document
                        Console.WriteLine(respondData.ToString());
                    }
                }
            }
            catch (RpcException exception)
            {
                Console.WriteLine(exception.Message);
                this._logger.LogError(exception.Message);
            }
        }

        private void GetClients(GetClientRequest request)
        {
            ClientModel clientModel = _clientProtoService.GetClient(request);

            Console.WriteLine(clientModel.ToString());
        }

        private void GetDocumentForClient()
        {
            this._logger.LogInformation("Getting documents for client {clientId}", 1);

            DocumentModels documents = this._documentProtoService.GetDocuments(new GetAllDocumentsRequest());

            foreach (var model in documents.DocumentModel)
            {
                Console.WriteLine(model.ToString());
            }
        }
    }
}

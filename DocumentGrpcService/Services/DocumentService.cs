using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DocumentGrpcService.Data;
using DocumentGrpcService.Model.Entities;
using DocumentGrpcService.Protos;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;

namespace DocumentGrpcService.Services
{
    public class DocumentService : DocumentProtoService.DocumentProtoServiceBase
    {
        private readonly DocumentContext _documentContext;
        private readonly IMapper _mapper;
        public DocumentService(DocumentContext documentContext, IMapper mapper)
        {
            this._documentContext = documentContext;
            this._mapper = mapper;
        }
        public override Task<DocumentModels> GetDocuments(GetAllDocumentsRequest request, ServerCallContext context)
        {
            //   return base.GetDocuments(request, context);

            Console.WriteLine(request.ClientId);

            var doc1 = new DocumentModel { Name = "Fakuta", DocumentType = "pdf" };
            var doc2 = new DocumentModel { Name = "Fakuta2", DocumentType = "pdf" };

            var documentModels = new DocumentModels();
            documentModels.DocumentModel.Add(doc1);
            documentModels.DocumentModel.Add(doc2);

            return Task.FromResult(documentModels);

        }
        public override async Task GetDocumentsStream(GetAllDocumentsRequest request, IServerStreamWriter<DocumentModel> responseStream, ServerCallContext context)
        {
            List<Document> documents =await this._documentContext
                .Documents
                .Where(d => d.ClientId == request.ClientId)
                .ToListAsync();

            foreach (var document in documents)
            {
                var productModel = _mapper.Map<DocumentModel>(document);

                await responseStream.WriteAsync(productModel);
            }
        }

        public override async Task<CreateDocumentResponse> CreateDocumentStream(IAsyncStreamReader<CreateDocumentModelRequest> requestStream, ServerCallContext context)
        {
            while(await requestStream.MoveNext())
            {
                Document document = this._mapper.Map<Document>(requestStream.Current);

                this._documentContext.Documents.Add(document);
            }

            int insertedCount =await  this._documentContext.SaveChangesAsync();

            var response = new CreateDocumentResponse()
            {
                InsertCount = insertedCount,
                Success = insertedCount > 0
            };

            return response;
        }
    }
}

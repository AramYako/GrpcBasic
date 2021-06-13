using AutoMapper;
using ClientGrpcService.Data;
using ClientGrpcService.Model.Entities;
using ClientGrpcService.Protos;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientGrpcService.Services
{
    public class ClientService : ClientProtoService.ClientProtoServiceBase
    {
        private readonly ClientContext _clientContext;
        private readonly ILogger<ClientService> _logger;
        private readonly IMapper _mapper;

        public ClientService(ClientContext clientContext, ILogger<ClientService> logger, IMapper mapper)
        {
            this._clientContext = clientContext;
            this._logger = logger;
            this._mapper = mapper;
        }
        public override async Task<ClientModel> GetClient(GetClientRequest request, ServerCallContext context)
        {
            Client client = await this._clientContext.Clients.FindAsync(request.ClientId);

            if (client == null)
                throw new RpcException(new Status(StatusCode.NotFound, $"Client with clientId {request.ClientId} was not found"));

            return this._mapper.Map<ClientModel>(client);
        }
        public override async Task<ClientModel> CreateClient(CreateClientRequest request, ServerCallContext context)
        {
            if (string.IsNullOrEmpty(request?.ClientName))
                throw new RpcException(new Status(StatusCode.InvalidArgument, $"Client name: {request?.ClientName} is missing"));

            Client client = this._mapper.Map<Client>(request);

            if (await this._clientContext.Clients.AnyAsync(c => c.ClientName == client.ClientName))
                throw new RpcException(new Status(StatusCode.AlreadyExists, $"Client name: {request?.ClientName} already exists!"));

            await this._clientContext.Clients.AddAsync(client);

            await this._clientContext.SaveChangesAsync();

            this._logger.LogInformation("Client {ClientName} was created", client.ClientName);

            return this._mapper.Map<ClientModel>(client);

        }

        public override async Task<ClientDeleteResponse> DeleteClient(DeleteClientRequest request, ServerCallContext context)
        {
            Client client = await this._clientContext.Clients.FindAsync(request.ClientId);

            if (client == null)
                throw new RpcException(new Status(StatusCode.NotFound, $"Client with clientId {request.ClientId} was not found"));

            this._clientContext.Clients.Remove(client);

            int deletedCount = await this._clientContext.SaveChangesAsync();

            if(deletedCount>0)
                this._logger.LogInformation("Deleted clientId {ClientId}", request.ClientId);
            else
                this._logger.LogError("Failed to delete clientId {ClientId}", request.ClientId);

            return new ClientDeleteResponse
            {
                DeletedCount = deletedCount,
                Succes = deletedCount > 0
            };

        }
    }
}


// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Client.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ClientGrpcService.Protos {
  public static partial class ClientProtoService
  {
    static readonly string __ServiceName = "ClientProtoService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::ClientGrpcService.Protos.GetClientRequest> __Marshaller_GetClientRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ClientGrpcService.Protos.GetClientRequest.Parser));
    static readonly grpc::Marshaller<global::ClientGrpcService.Protos.ClientModel> __Marshaller_ClientModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ClientGrpcService.Protos.ClientModel.Parser));
    static readonly grpc::Marshaller<global::ClientGrpcService.Protos.CreateClientRequest> __Marshaller_CreateClientRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ClientGrpcService.Protos.CreateClientRequest.Parser));
    static readonly grpc::Marshaller<global::ClientGrpcService.Protos.DeleteClientRequest> __Marshaller_DeleteClientRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ClientGrpcService.Protos.DeleteClientRequest.Parser));
    static readonly grpc::Marshaller<global::ClientGrpcService.Protos.ClientDeleteResponse> __Marshaller_ClientDeleteResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ClientGrpcService.Protos.ClientDeleteResponse.Parser));

    static readonly grpc::Method<global::ClientGrpcService.Protos.GetClientRequest, global::ClientGrpcService.Protos.ClientModel> __Method_GetClient = new grpc::Method<global::ClientGrpcService.Protos.GetClientRequest, global::ClientGrpcService.Protos.ClientModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetClient",
        __Marshaller_GetClientRequest,
        __Marshaller_ClientModel);

    static readonly grpc::Method<global::ClientGrpcService.Protos.CreateClientRequest, global::ClientGrpcService.Protos.ClientModel> __Method_CreateClient = new grpc::Method<global::ClientGrpcService.Protos.CreateClientRequest, global::ClientGrpcService.Protos.ClientModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateClient",
        __Marshaller_CreateClientRequest,
        __Marshaller_ClientModel);

    static readonly grpc::Method<global::ClientGrpcService.Protos.DeleteClientRequest, global::ClientGrpcService.Protos.ClientDeleteResponse> __Method_DeleteClient = new grpc::Method<global::ClientGrpcService.Protos.DeleteClientRequest, global::ClientGrpcService.Protos.ClientDeleteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteClient",
        __Marshaller_DeleteClientRequest,
        __Marshaller_ClientDeleteResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ClientGrpcService.Protos.ClientReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ClientProtoService</summary>
    public partial class ClientProtoServiceClient : grpc::ClientBase<ClientProtoServiceClient>
    {
      /// <summary>Creates a new client for ClientProtoService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ClientProtoServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ClientProtoService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ClientProtoServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ClientProtoServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ClientProtoServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ClientGrpcService.Protos.ClientModel GetClient(global::ClientGrpcService.Protos.GetClientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetClient(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ClientGrpcService.Protos.ClientModel GetClient(global::ClientGrpcService.Protos.GetClientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetClient, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ClientGrpcService.Protos.ClientModel> GetClientAsync(global::ClientGrpcService.Protos.GetClientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetClientAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ClientGrpcService.Protos.ClientModel> GetClientAsync(global::ClientGrpcService.Protos.GetClientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetClient, null, options, request);
      }
      public virtual global::ClientGrpcService.Protos.ClientModel CreateClient(global::ClientGrpcService.Protos.CreateClientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateClient(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ClientGrpcService.Protos.ClientModel CreateClient(global::ClientGrpcService.Protos.CreateClientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateClient, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ClientGrpcService.Protos.ClientModel> CreateClientAsync(global::ClientGrpcService.Protos.CreateClientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateClientAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ClientGrpcService.Protos.ClientModel> CreateClientAsync(global::ClientGrpcService.Protos.CreateClientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateClient, null, options, request);
      }
      public virtual global::ClientGrpcService.Protos.ClientDeleteResponse DeleteClient(global::ClientGrpcService.Protos.DeleteClientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteClient(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ClientGrpcService.Protos.ClientDeleteResponse DeleteClient(global::ClientGrpcService.Protos.DeleteClientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteClient, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ClientGrpcService.Protos.ClientDeleteResponse> DeleteClientAsync(global::ClientGrpcService.Protos.DeleteClientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteClientAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ClientGrpcService.Protos.ClientDeleteResponse> DeleteClientAsync(global::ClientGrpcService.Protos.DeleteClientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteClient, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ClientProtoServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ClientProtoServiceClient(configuration);
      }
    }

  }
}
#endregion
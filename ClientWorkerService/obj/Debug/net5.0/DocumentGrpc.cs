// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Document.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace DocumentGrpcService.Protos {
  public static partial class DocumentProtoService
  {
    static readonly string __ServiceName = "DocumentProtoService";

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

    static readonly grpc::Marshaller<global::DocumentGrpcService.Protos.GetAllDocumentsRequest> __Marshaller_GetAllDocumentsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DocumentGrpcService.Protos.GetAllDocumentsRequest.Parser));
    static readonly grpc::Marshaller<global::DocumentGrpcService.Protos.DocumentModels> __Marshaller_DocumentModels = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DocumentGrpcService.Protos.DocumentModels.Parser));
    static readonly grpc::Marshaller<global::DocumentGrpcService.Protos.DocumentModel> __Marshaller_DocumentModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DocumentGrpcService.Protos.DocumentModel.Parser));
    static readonly grpc::Marshaller<global::DocumentGrpcService.Protos.CreateDocumentModelRequest> __Marshaller_CreateDocumentModelRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DocumentGrpcService.Protos.CreateDocumentModelRequest.Parser));
    static readonly grpc::Marshaller<global::DocumentGrpcService.Protos.CreateDocumentResponse> __Marshaller_CreateDocumentResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DocumentGrpcService.Protos.CreateDocumentResponse.Parser));

    static readonly grpc::Method<global::DocumentGrpcService.Protos.GetAllDocumentsRequest, global::DocumentGrpcService.Protos.DocumentModels> __Method_GetDocuments = new grpc::Method<global::DocumentGrpcService.Protos.GetAllDocumentsRequest, global::DocumentGrpcService.Protos.DocumentModels>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetDocuments",
        __Marshaller_GetAllDocumentsRequest,
        __Marshaller_DocumentModels);

    static readonly grpc::Method<global::DocumentGrpcService.Protos.GetAllDocumentsRequest, global::DocumentGrpcService.Protos.DocumentModel> __Method_GetDocumentsStream = new grpc::Method<global::DocumentGrpcService.Protos.GetAllDocumentsRequest, global::DocumentGrpcService.Protos.DocumentModel>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetDocumentsStream",
        __Marshaller_GetAllDocumentsRequest,
        __Marshaller_DocumentModel);

    static readonly grpc::Method<global::DocumentGrpcService.Protos.CreateDocumentModelRequest, global::DocumentGrpcService.Protos.CreateDocumentResponse> __Method_CreateDocumentStream = new grpc::Method<global::DocumentGrpcService.Protos.CreateDocumentModelRequest, global::DocumentGrpcService.Protos.CreateDocumentResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "CreateDocumentStream",
        __Marshaller_CreateDocumentModelRequest,
        __Marshaller_CreateDocumentResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::DocumentGrpcService.Protos.DocumentReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for DocumentProtoService</summary>
    public partial class DocumentProtoServiceClient : grpc::ClientBase<DocumentProtoServiceClient>
    {
      /// <summary>Creates a new client for DocumentProtoService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DocumentProtoServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DocumentProtoService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DocumentProtoServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DocumentProtoServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DocumentProtoServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::DocumentGrpcService.Protos.DocumentModels GetDocuments(global::DocumentGrpcService.Protos.GetAllDocumentsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDocuments(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DocumentGrpcService.Protos.DocumentModels GetDocuments(global::DocumentGrpcService.Protos.GetAllDocumentsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetDocuments, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::DocumentGrpcService.Protos.DocumentModels> GetDocumentsAsync(global::DocumentGrpcService.Protos.GetAllDocumentsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDocumentsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::DocumentGrpcService.Protos.DocumentModels> GetDocumentsAsync(global::DocumentGrpcService.Protos.GetAllDocumentsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetDocuments, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::DocumentGrpcService.Protos.DocumentModel> GetDocumentsStream(global::DocumentGrpcService.Protos.GetAllDocumentsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDocumentsStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::DocumentGrpcService.Protos.DocumentModel> GetDocumentsStream(global::DocumentGrpcService.Protos.GetAllDocumentsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetDocumentsStream, null, options, request);
      }
      public virtual grpc::AsyncClientStreamingCall<global::DocumentGrpcService.Protos.CreateDocumentModelRequest, global::DocumentGrpcService.Protos.CreateDocumentResponse> CreateDocumentStream(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateDocumentStream(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::DocumentGrpcService.Protos.CreateDocumentModelRequest, global::DocumentGrpcService.Protos.CreateDocumentResponse> CreateDocumentStream(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_CreateDocumentStream, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DocumentProtoServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DocumentProtoServiceClient(configuration);
      }
    }

  }
}
#endregion
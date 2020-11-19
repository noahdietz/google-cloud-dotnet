// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/v2/context.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Dialogflow.V2 {
  /// <summary>
  /// Service for managing [Contexts][google.cloud.dialogflow.v2.Context].
  /// </summary>
  public static partial class Contexts
  {
    static readonly string __ServiceName = "google.cloud.dialogflow.v2.Contexts";

    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.ListContextsRequest> __Marshaller_google_cloud_dialogflow_v2_ListContextsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.V2.ListContextsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.ListContextsResponse> __Marshaller_google_cloud_dialogflow_v2_ListContextsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.V2.ListContextsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.GetContextRequest> __Marshaller_google_cloud_dialogflow_v2_GetContextRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.V2.GetContextRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.Context> __Marshaller_google_cloud_dialogflow_v2_Context = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.V2.Context.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.CreateContextRequest> __Marshaller_google_cloud_dialogflow_v2_CreateContextRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.V2.CreateContextRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.UpdateContextRequest> __Marshaller_google_cloud_dialogflow_v2_UpdateContextRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.V2.UpdateContextRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.DeleteContextRequest> __Marshaller_google_cloud_dialogflow_v2_DeleteContextRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.V2.DeleteContextRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.DeleteAllContextsRequest> __Marshaller_google_cloud_dialogflow_v2_DeleteAllContextsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.V2.DeleteAllContextsRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2.ListContextsRequest, global::Google.Cloud.Dialogflow.V2.ListContextsResponse> __Method_ListContexts = new grpc::Method<global::Google.Cloud.Dialogflow.V2.ListContextsRequest, global::Google.Cloud.Dialogflow.V2.ListContextsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListContexts",
        __Marshaller_google_cloud_dialogflow_v2_ListContextsRequest,
        __Marshaller_google_cloud_dialogflow_v2_ListContextsResponse);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2.GetContextRequest, global::Google.Cloud.Dialogflow.V2.Context> __Method_GetContext = new grpc::Method<global::Google.Cloud.Dialogflow.V2.GetContextRequest, global::Google.Cloud.Dialogflow.V2.Context>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetContext",
        __Marshaller_google_cloud_dialogflow_v2_GetContextRequest,
        __Marshaller_google_cloud_dialogflow_v2_Context);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2.CreateContextRequest, global::Google.Cloud.Dialogflow.V2.Context> __Method_CreateContext = new grpc::Method<global::Google.Cloud.Dialogflow.V2.CreateContextRequest, global::Google.Cloud.Dialogflow.V2.Context>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateContext",
        __Marshaller_google_cloud_dialogflow_v2_CreateContextRequest,
        __Marshaller_google_cloud_dialogflow_v2_Context);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2.UpdateContextRequest, global::Google.Cloud.Dialogflow.V2.Context> __Method_UpdateContext = new grpc::Method<global::Google.Cloud.Dialogflow.V2.UpdateContextRequest, global::Google.Cloud.Dialogflow.V2.Context>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateContext",
        __Marshaller_google_cloud_dialogflow_v2_UpdateContextRequest,
        __Marshaller_google_cloud_dialogflow_v2_Context);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2.DeleteContextRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteContext = new grpc::Method<global::Google.Cloud.Dialogflow.V2.DeleteContextRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteContext",
        __Marshaller_google_cloud_dialogflow_v2_DeleteContextRequest,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2.DeleteAllContextsRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteAllContexts = new grpc::Method<global::Google.Cloud.Dialogflow.V2.DeleteAllContextsRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteAllContexts",
        __Marshaller_google_cloud_dialogflow_v2_DeleteAllContextsRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dialogflow.V2.ContextReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Contexts</summary>
    [grpc::BindServiceMethod(typeof(Contexts), "BindService")]
    public abstract partial class ContextsBase
    {
      /// <summary>
      /// Returns the list of all contexts in the specified session.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.V2.ListContextsResponse> ListContexts(global::Google.Cloud.Dialogflow.V2.ListContextsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves the specified context.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.V2.Context> GetContext(global::Google.Cloud.Dialogflow.V2.GetContextRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a context.
      ///
      /// If the specified context already exists, overrides the context.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.V2.Context> CreateContext(global::Google.Cloud.Dialogflow.V2.CreateContextRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates the specified context.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.V2.Context> UpdateContext(global::Google.Cloud.Dialogflow.V2.UpdateContextRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes the specified context.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteContext(global::Google.Cloud.Dialogflow.V2.DeleteContextRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes all active contexts in the specified session.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAllContexts(global::Google.Cloud.Dialogflow.V2.DeleteAllContextsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Contexts</summary>
    public partial class ContextsClient : grpc::ClientBase<ContextsClient>
    {
      /// <summary>Creates a new client for Contexts</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ContextsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Contexts that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ContextsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ContextsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ContextsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the list of all contexts in the specified session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.V2.ListContextsResponse ListContexts(global::Google.Cloud.Dialogflow.V2.ListContextsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListContexts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all contexts in the specified session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.V2.ListContextsResponse ListContexts(global::Google.Cloud.Dialogflow.V2.ListContextsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListContexts, null, options, request);
      }
      /// <summary>
      /// Returns the list of all contexts in the specified session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.ListContextsResponse> ListContextsAsync(global::Google.Cloud.Dialogflow.V2.ListContextsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListContextsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all contexts in the specified session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.ListContextsResponse> ListContextsAsync(global::Google.Cloud.Dialogflow.V2.ListContextsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListContexts, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.V2.Context GetContext(global::Google.Cloud.Dialogflow.V2.GetContextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetContext(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.V2.Context GetContext(global::Google.Cloud.Dialogflow.V2.GetContextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetContext, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.Context> GetContextAsync(global::Google.Cloud.Dialogflow.V2.GetContextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetContextAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.Context> GetContextAsync(global::Google.Cloud.Dialogflow.V2.GetContextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetContext, null, options, request);
      }
      /// <summary>
      /// Creates a context.
      ///
      /// If the specified context already exists, overrides the context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.V2.Context CreateContext(global::Google.Cloud.Dialogflow.V2.CreateContextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateContext(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a context.
      ///
      /// If the specified context already exists, overrides the context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.V2.Context CreateContext(global::Google.Cloud.Dialogflow.V2.CreateContextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateContext, null, options, request);
      }
      /// <summary>
      /// Creates a context.
      ///
      /// If the specified context already exists, overrides the context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.Context> CreateContextAsync(global::Google.Cloud.Dialogflow.V2.CreateContextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateContextAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a context.
      ///
      /// If the specified context already exists, overrides the context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.Context> CreateContextAsync(global::Google.Cloud.Dialogflow.V2.CreateContextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateContext, null, options, request);
      }
      /// <summary>
      /// Updates the specified context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.V2.Context UpdateContext(global::Google.Cloud.Dialogflow.V2.UpdateContextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateContext(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.V2.Context UpdateContext(global::Google.Cloud.Dialogflow.V2.UpdateContextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateContext, null, options, request);
      }
      /// <summary>
      /// Updates the specified context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.Context> UpdateContextAsync(global::Google.Cloud.Dialogflow.V2.UpdateContextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateContextAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.Context> UpdateContextAsync(global::Google.Cloud.Dialogflow.V2.UpdateContextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateContext, null, options, request);
      }
      /// <summary>
      /// Deletes the specified context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteContext(global::Google.Cloud.Dialogflow.V2.DeleteContextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteContext(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteContext(global::Google.Cloud.Dialogflow.V2.DeleteContextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteContext, null, options, request);
      }
      /// <summary>
      /// Deletes the specified context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteContextAsync(global::Google.Cloud.Dialogflow.V2.DeleteContextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteContextAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteContextAsync(global::Google.Cloud.Dialogflow.V2.DeleteContextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteContext, null, options, request);
      }
      /// <summary>
      /// Deletes all active contexts in the specified session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteAllContexts(global::Google.Cloud.Dialogflow.V2.DeleteAllContextsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAllContexts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes all active contexts in the specified session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteAllContexts(global::Google.Cloud.Dialogflow.V2.DeleteAllContextsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteAllContexts, null, options, request);
      }
      /// <summary>
      /// Deletes all active contexts in the specified session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAllContextsAsync(global::Google.Cloud.Dialogflow.V2.DeleteAllContextsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAllContextsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes all active contexts in the specified session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAllContextsAsync(global::Google.Cloud.Dialogflow.V2.DeleteAllContextsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteAllContexts, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ContextsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ContextsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ContextsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListContexts, serviceImpl.ListContexts)
          .AddMethod(__Method_GetContext, serviceImpl.GetContext)
          .AddMethod(__Method_CreateContext, serviceImpl.CreateContext)
          .AddMethod(__Method_UpdateContext, serviceImpl.UpdateContext)
          .AddMethod(__Method_DeleteContext, serviceImpl.DeleteContext)
          .AddMethod(__Method_DeleteAllContexts, serviceImpl.DeleteAllContexts).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ContextsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListContexts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2.ListContextsRequest, global::Google.Cloud.Dialogflow.V2.ListContextsResponse>(serviceImpl.ListContexts));
      serviceBinder.AddMethod(__Method_GetContext, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2.GetContextRequest, global::Google.Cloud.Dialogflow.V2.Context>(serviceImpl.GetContext));
      serviceBinder.AddMethod(__Method_CreateContext, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2.CreateContextRequest, global::Google.Cloud.Dialogflow.V2.Context>(serviceImpl.CreateContext));
      serviceBinder.AddMethod(__Method_UpdateContext, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2.UpdateContextRequest, global::Google.Cloud.Dialogflow.V2.Context>(serviceImpl.UpdateContext));
      serviceBinder.AddMethod(__Method_DeleteContext, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2.DeleteContextRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteContext));
      serviceBinder.AddMethod(__Method_DeleteAllContexts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2.DeleteAllContextsRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteAllContexts));
    }

  }
}
#endregion
// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/deployed_index_ref.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/deployed_index_ref.proto</summary>
  public static partial class DeployedIndexRefReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/deployed_index_ref.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeployedIndexRefReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9kZXBsb3llZF9pbmRleF9y",
            "ZWYucHJvdG8SGmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxGh9nb29nbGUv",
            "YXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNl",
            "LnByb3RvInsKEERlcGxveWVkSW5kZXhSZWYSRwoOaW5kZXhfZW5kcG9pbnQY",
            "ASABKAlCL+BBBfpBKQonYWlwbGF0Zm9ybS5nb29nbGVhcGlzLmNvbS9JbmRl",
            "eEVuZHBvaW50Eh4KEWRlcGxveWVkX2luZGV4X2lkGAIgASgJQgPgQQVC2QEK",
            "HmNvbS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MUIVRGVwbG95ZWRJbmRl",
            "eFJlZlByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvY2xvdWQvYWlwbGF0Zm9ybS92MTthaXBsYXRmb3JtqgIaR29vZ2xl",
            "LkNsb3VkLkFJUGxhdGZvcm0uVjHKAhpHb29nbGVcQ2xvdWRcQUlQbGF0Zm9y",
            "bVxWMeoCHUdvb2dsZTo6Q2xvdWQ6OkFJUGxhdGZvcm06OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.DeployedIndexRef), global::Google.Cloud.AIPlatform.V1.DeployedIndexRef.Parser, new[]{ "IndexEndpoint", "DeployedIndexId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Points to a DeployedIndex.
  /// </summary>
  public sealed partial class DeployedIndexRef : pb::IMessage<DeployedIndexRef>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DeployedIndexRef> _parser = new pb::MessageParser<DeployedIndexRef>(() => new DeployedIndexRef());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DeployedIndexRef> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.DeployedIndexRefReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeployedIndexRef() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeployedIndexRef(DeployedIndexRef other) : this() {
      indexEndpoint_ = other.indexEndpoint_;
      deployedIndexId_ = other.deployedIndexId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeployedIndexRef Clone() {
      return new DeployedIndexRef(this);
    }

    /// <summary>Field number for the "index_endpoint" field.</summary>
    public const int IndexEndpointFieldNumber = 1;
    private string indexEndpoint_ = "";
    /// <summary>
    /// Immutable. A resource name of the IndexEndpoint.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string IndexEndpoint {
      get { return indexEndpoint_; }
      set {
        indexEndpoint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "deployed_index_id" field.</summary>
    public const int DeployedIndexIdFieldNumber = 2;
    private string deployedIndexId_ = "";
    /// <summary>
    /// Immutable. The ID of the DeployedIndex in the above IndexEndpoint.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DeployedIndexId {
      get { return deployedIndexId_; }
      set {
        deployedIndexId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DeployedIndexRef);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DeployedIndexRef other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IndexEndpoint != other.IndexEndpoint) return false;
      if (DeployedIndexId != other.DeployedIndexId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IndexEndpoint.Length != 0) hash ^= IndexEndpoint.GetHashCode();
      if (DeployedIndexId.Length != 0) hash ^= DeployedIndexId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (IndexEndpoint.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(IndexEndpoint);
      }
      if (DeployedIndexId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeployedIndexId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IndexEndpoint.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(IndexEndpoint);
      }
      if (DeployedIndexId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeployedIndexId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IndexEndpoint.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IndexEndpoint);
      }
      if (DeployedIndexId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeployedIndexId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DeployedIndexRef other) {
      if (other == null) {
        return;
      }
      if (other.IndexEndpoint.Length != 0) {
        IndexEndpoint = other.IndexEndpoint;
      }
      if (other.DeployedIndexId.Length != 0) {
        DeployedIndexId = other.DeployedIndexId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            IndexEndpoint = input.ReadString();
            break;
          }
          case 18: {
            DeployedIndexId = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            IndexEndpoint = input.ReadString();
            break;
          }
          case 18: {
            DeployedIndexId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code

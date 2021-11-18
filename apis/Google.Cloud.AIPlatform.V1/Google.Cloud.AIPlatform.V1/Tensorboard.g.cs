// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/tensorboard.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/tensorboard.proto</summary>
  public static partial class TensorboardReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/tensorboard.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TensorboardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS90ZW5zb3Jib2FyZC5wcm90",
            "bxIaZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEaH2dvb2dsZS9hcGkvZmll",
            "bGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8a",
            "MGdvb2dsZS9jbG91ZC9haXBsYXRmb3JtL3YxL2VuY3J5cHRpb25fc3BlYy5w",
            "cm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxocZ29vZ2xl",
            "L2FwaS9hbm5vdGF0aW9ucy5wcm90byKyBAoLVGVuc29yYm9hcmQSEQoEbmFt",
            "ZRgBIAEoCUID4EEDEhkKDGRpc3BsYXlfbmFtZRgCIAEoCUID4EECEhMKC2Rl",
            "c2NyaXB0aW9uGAMgASgJEkMKD2VuY3J5cHRpb25fc3BlYxgLIAEoCzIqLmdv",
            "b2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxLkVuY3J5cHRpb25TcGVjEiUKGGJs",
            "b2Jfc3RvcmFnZV9wYXRoX3ByZWZpeBgKIAEoCUID4EEDEhYKCXJ1bl9jb3Vu",
            "dBgFIAEoBUID4EEDEjQKC2NyZWF0ZV90aW1lGAYgASgLMhouZ29vZ2xlLnBy",
            "b3RvYnVmLlRpbWVzdGFtcEID4EEDEjQKC3VwZGF0ZV90aW1lGAcgASgLMhou",
            "Z29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEID4EEDEkMKBmxhYmVscxgIIAMo",
            "CzIzLmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxLlRlbnNvcmJvYXJkLkxh",
            "YmVsc0VudHJ5EgwKBGV0YWcYCSABKAkaLQoLTGFiZWxzRW50cnkSCwoDa2V5",
            "GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ATpu6kFrCiVhaXBsYXRmb3JtLmdv",
            "b2dsZWFwaXMuY29tL1RlbnNvcmJvYXJkEkJwcm9qZWN0cy97cHJvamVjdH0v",
            "bG9jYXRpb25zL3tsb2NhdGlvbn0vdGVuc29yYm9hcmRzL3t0ZW5zb3Jib2Fy",
            "ZH1C1AEKHmNvbS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MUIQVGVuc29y",
            "Ym9hcmRQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29n",
            "bGVhcGlzL2Nsb3VkL2FpcGxhdGZvcm0vdjE7YWlwbGF0Zm9ybaoCGkdvb2ds",
            "ZS5DbG91ZC5BSVBsYXRmb3JtLlYxygIaR29vZ2xlXENsb3VkXEFJUGxhdGZv",
            "cm1cVjHqAh1Hb29nbGU6OkNsb3VkOjpBSVBsYXRmb3JtOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.EncryptionSpecReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Tensorboard), global::Google.Cloud.AIPlatform.V1.Tensorboard.Parser, new[]{ "Name", "DisplayName", "Description", "EncryptionSpec", "BlobStoragePathPrefix", "RunCount", "CreateTime", "UpdateTime", "Labels", "Etag" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Tensorboard is a physical database that stores users' training metrics.
  /// A default Tensorboard is provided in each region of a GCP project.
  /// If needed users can also create extra Tensorboards in their projects.
  /// </summary>
  public sealed partial class Tensorboard : pb::IMessage<Tensorboard>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Tensorboard> _parser = new pb::MessageParser<Tensorboard>(() => new Tensorboard());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Tensorboard> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.TensorboardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Tensorboard() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Tensorboard(Tensorboard other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      description_ = other.description_;
      encryptionSpec_ = other.encryptionSpec_ != null ? other.encryptionSpec_.Clone() : null;
      blobStoragePathPrefix_ = other.blobStoragePathPrefix_;
      runCount_ = other.runCount_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      labels_ = other.labels_.Clone();
      etag_ = other.etag_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Tensorboard Clone() {
      return new Tensorboard(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Name of the Tensorboard.
    /// Format:
    /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Required. User provided name of this Tensorboard.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    /// <summary>
    /// Description of this Tensorboard.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "encryption_spec" field.</summary>
    public const int EncryptionSpecFieldNumber = 11;
    private global::Google.Cloud.AIPlatform.V1.EncryptionSpec encryptionSpec_;
    /// <summary>
    /// Customer-managed encryption key spec for a Tensorboard. If set, this
    /// Tensorboard and all sub-resources of this Tensorboard will be secured by
    /// this key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.EncryptionSpec EncryptionSpec {
      get { return encryptionSpec_; }
      set {
        encryptionSpec_ = value;
      }
    }

    /// <summary>Field number for the "blob_storage_path_prefix" field.</summary>
    public const int BlobStoragePathPrefixFieldNumber = 10;
    private string blobStoragePathPrefix_ = "";
    /// <summary>
    /// Output only. Consumer project Cloud Storage path prefix used to store blob data, which
    /// can either be a bucket or directory. Does not end with a '/'.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BlobStoragePathPrefix {
      get { return blobStoragePathPrefix_; }
      set {
        blobStoragePathPrefix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "run_count" field.</summary>
    public const int RunCountFieldNumber = 5;
    private int runCount_;
    /// <summary>
    /// Output only. The number of Runs stored in this Tensorboard.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int RunCount {
      get { return runCount_; }
      set {
        runCount_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this Tensorboard was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Timestamp when this Tensorboard was last updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 8;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 66);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// The labels with user-defined metadata to organize your Tensorboards.
    ///
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    /// No more than 64 user labels can be associated with one Tensorboard
    /// (System labels are excluded).
    ///
    /// See https://goo.gl/xmQnxf for more information and examples of labels.
    /// System reserved label keys are prefixed with "aiplatform.googleapis.com/"
    /// and are immutable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 9;
    private string etag_ = "";
    /// <summary>
    /// Used to perform a consistent read-modify-write updates. If not set, a blind
    /// "overwrite" update happens.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Tensorboard);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Tensorboard other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Description != other.Description) return false;
      if (!object.Equals(EncryptionSpec, other.EncryptionSpec)) return false;
      if (BlobStoragePathPrefix != other.BlobStoragePathPrefix) return false;
      if (RunCount != other.RunCount) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (Etag != other.Etag) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (encryptionSpec_ != null) hash ^= EncryptionSpec.GetHashCode();
      if (BlobStoragePathPrefix.Length != 0) hash ^= BlobStoragePathPrefix.GetHashCode();
      if (RunCount != 0) hash ^= RunCount.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (RunCount != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(RunCount);
      }
      if (createTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(UpdateTime);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Etag);
      }
      if (BlobStoragePathPrefix.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(BlobStoragePathPrefix);
      }
      if (encryptionSpec_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(EncryptionSpec);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (RunCount != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(RunCount);
      }
      if (createTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(UpdateTime);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Etag);
      }
      if (BlobStoragePathPrefix.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(BlobStoragePathPrefix);
      }
      if (encryptionSpec_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(EncryptionSpec);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (encryptionSpec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EncryptionSpec);
      }
      if (BlobStoragePathPrefix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BlobStoragePathPrefix);
      }
      if (RunCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RunCount);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Tensorboard other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.encryptionSpec_ != null) {
        if (encryptionSpec_ == null) {
          EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
        }
        EncryptionSpec.MergeFrom(other.EncryptionSpec);
      }
      if (other.BlobStoragePathPrefix.Length != 0) {
        BlobStoragePathPrefix = other.BlobStoragePathPrefix;
      }
      if (other.RunCount != 0) {
        RunCount = other.RunCount;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      labels_.Add(other.labels_);
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 40: {
            RunCount = input.ReadInt32();
            break;
          }
          case 50: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 58: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 66: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 74: {
            Etag = input.ReadString();
            break;
          }
          case 82: {
            BlobStoragePathPrefix = input.ReadString();
            break;
          }
          case 90: {
            if (encryptionSpec_ == null) {
              EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
            }
            input.ReadMessage(EncryptionSpec);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 40: {
            RunCount = input.ReadInt32();
            break;
          }
          case 50: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 58: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 66: {
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
            break;
          }
          case 74: {
            Etag = input.ReadString();
            break;
          }
          case 82: {
            BlobStoragePathPrefix = input.ReadString();
            break;
          }
          case 90: {
            if (encryptionSpec_ == null) {
              EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
            }
            input.ReadMessage(EncryptionSpec);
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
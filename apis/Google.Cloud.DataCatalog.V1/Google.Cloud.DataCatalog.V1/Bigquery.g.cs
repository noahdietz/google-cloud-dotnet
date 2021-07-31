// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/datacatalog/v1/bigquery.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DataCatalog.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/datacatalog/v1/bigquery.proto</summary>
  public static partial class BigqueryReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/datacatalog/v1/bigquery.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BigqueryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipnb29nbGUvY2xvdWQvZGF0YWNhdGFsb2cvdjEvYmlncXVlcnkucHJvdG8S",
            "G2dvb2dsZS5jbG91ZC5kYXRhY2F0YWxvZy52MRofZ29vZ2xlL2FwaS9maWVs",
            "ZF9iZWhhdmlvci5wcm90byK0AgoWQmlnUXVlcnlDb25uZWN0aW9uU3BlYxJb",
            "Cg9jb25uZWN0aW9uX3R5cGUYASABKA4yQi5nb29nbGUuY2xvdWQuZGF0YWNh",
            "dGFsb2cudjEuQmlnUXVlcnlDb25uZWN0aW9uU3BlYy5Db25uZWN0aW9uVHlw",
            "ZRJQCgljbG91ZF9zcWwYAiABKAsyOy5nb29nbGUuY2xvdWQuZGF0YWNhdGFs",
            "b2cudjEuQ2xvdWRTcWxCaWdRdWVyeUNvbm5lY3Rpb25TcGVjSAASFgoOaGFz",
            "X2NyZWRlbnRpYWwYAyABKAgiQAoOQ29ubmVjdGlvblR5cGUSHwobQ09OTkVD",
            "VElPTl9UWVBFX1VOU1BFQ0lGSUVEEAASDQoJQ0xPVURfU1FMEAFCEQoPY29u",
            "bmVjdGlvbl9zcGVjIucBCh5DbG91ZFNxbEJpZ1F1ZXJ5Q29ubmVjdGlvblNw",
            "ZWMSEwoLaW5zdGFuY2VfaWQYASABKAkSEAoIZGF0YWJhc2UYAiABKAkSVgoE",
            "dHlwZRgDIAEoDjJILmdvb2dsZS5jbG91ZC5kYXRhY2F0YWxvZy52MS5DbG91",
            "ZFNxbEJpZ1F1ZXJ5Q29ubmVjdGlvblNwZWMuRGF0YWJhc2VUeXBlIkYKDERh",
            "dGFiYXNlVHlwZRIdChlEQVRBQkFTRV9UWVBFX1VOU1BFQ0lGSUVEEAASDAoI",
            "UE9TVEdSRVMQARIJCgVNWVNRTBACIjEKE0JpZ1F1ZXJ5Um91dGluZVNwZWMS",
            "GgoSaW1wb3J0ZWRfbGlicmFyaWVzGAEgAygJQtoBCh9jb20uZ29vZ2xlLmNs",
            "b3VkLmRhdGFjYXRhbG9nLnYxQg1CaWdRdWVyeVByb3RvUAFaRmdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvZGF0YWNhdGFs",
            "b2cvdjE7ZGF0YWNhdGFsb2f4AQGqAhtHb29nbGUuQ2xvdWQuRGF0YUNhdGFs",
            "b2cuVjHKAhtHb29nbGVcQ2xvdWRcRGF0YUNhdGFsb2dcVjHqAh5Hb29nbGU6",
            "OkNsb3VkOjpEYXRhQ2F0YWxvZzo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.BigQueryConnectionSpec), global::Google.Cloud.DataCatalog.V1.BigQueryConnectionSpec.Parser, new[]{ "ConnectionType", "CloudSql", "HasCredential" }, new[]{ "ConnectionSpec" }, new[]{ typeof(global::Google.Cloud.DataCatalog.V1.BigQueryConnectionSpec.Types.ConnectionType) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec), global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec.Parser, new[]{ "InstanceId", "Database", "Type" }, null, new[]{ typeof(global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec.Types.DatabaseType) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.BigQueryRoutineSpec), global::Google.Cloud.DataCatalog.V1.BigQueryRoutineSpec.Parser, new[]{ "ImportedLibraries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Specification for the BigQuery connection.
  /// </summary>
  public sealed partial class BigQueryConnectionSpec : pb::IMessage<BigQueryConnectionSpec>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BigQueryConnectionSpec> _parser = new pb::MessageParser<BigQueryConnectionSpec>(() => new BigQueryConnectionSpec());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BigQueryConnectionSpec> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.BigqueryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BigQueryConnectionSpec() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BigQueryConnectionSpec(BigQueryConnectionSpec other) : this() {
      connectionType_ = other.connectionType_;
      hasCredential_ = other.hasCredential_;
      switch (other.ConnectionSpecCase) {
        case ConnectionSpecOneofCase.CloudSql:
          CloudSql = other.CloudSql.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BigQueryConnectionSpec Clone() {
      return new BigQueryConnectionSpec(this);
    }

    /// <summary>Field number for the "connection_type" field.</summary>
    public const int ConnectionTypeFieldNumber = 1;
    private global::Google.Cloud.DataCatalog.V1.BigQueryConnectionSpec.Types.ConnectionType connectionType_ = global::Google.Cloud.DataCatalog.V1.BigQueryConnectionSpec.Types.ConnectionType.Unspecified;
    /// <summary>
    /// The type of the BigQuery connection.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.DataCatalog.V1.BigQueryConnectionSpec.Types.ConnectionType ConnectionType {
      get { return connectionType_; }
      set {
        connectionType_ = value;
      }
    }

    /// <summary>Field number for the "cloud_sql" field.</summary>
    public const int CloudSqlFieldNumber = 2;
    /// <summary>
    /// Specification for the BigQuery connection to a Cloud SQL instance.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec CloudSql {
      get { return connectionSpecCase_ == ConnectionSpecOneofCase.CloudSql ? (global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec) connectionSpec_ : null; }
      set {
        connectionSpec_ = value;
        connectionSpecCase_ = value == null ? ConnectionSpecOneofCase.None : ConnectionSpecOneofCase.CloudSql;
      }
    }

    /// <summary>Field number for the "has_credential" field.</summary>
    public const int HasCredentialFieldNumber = 3;
    private bool hasCredential_;
    /// <summary>
    /// True if there are credentials attached to the BigQuery connection; false
    /// otherwise.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasCredential {
      get { return hasCredential_; }
      set {
        hasCredential_ = value;
      }
    }

    private object connectionSpec_;
    /// <summary>Enum of possible cases for the "connection_spec" oneof.</summary>
    public enum ConnectionSpecOneofCase {
      None = 0,
      CloudSql = 2,
    }
    private ConnectionSpecOneofCase connectionSpecCase_ = ConnectionSpecOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectionSpecOneofCase ConnectionSpecCase {
      get { return connectionSpecCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearConnectionSpec() {
      connectionSpecCase_ = ConnectionSpecOneofCase.None;
      connectionSpec_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BigQueryConnectionSpec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BigQueryConnectionSpec other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConnectionType != other.ConnectionType) return false;
      if (!object.Equals(CloudSql, other.CloudSql)) return false;
      if (HasCredential != other.HasCredential) return false;
      if (ConnectionSpecCase != other.ConnectionSpecCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ConnectionType != global::Google.Cloud.DataCatalog.V1.BigQueryConnectionSpec.Types.ConnectionType.Unspecified) hash ^= ConnectionType.GetHashCode();
      if (connectionSpecCase_ == ConnectionSpecOneofCase.CloudSql) hash ^= CloudSql.GetHashCode();
      if (HasCredential != false) hash ^= HasCredential.GetHashCode();
      hash ^= (int) connectionSpecCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ConnectionType != global::Google.Cloud.DataCatalog.V1.BigQueryConnectionSpec.Types.ConnectionType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ConnectionType);
      }
      if (connectionSpecCase_ == ConnectionSpecOneofCase.CloudSql) {
        output.WriteRawTag(18);
        output.WriteMessage(CloudSql);
      }
      if (HasCredential != false) {
        output.WriteRawTag(24);
        output.WriteBool(HasCredential);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ConnectionType != global::Google.Cloud.DataCatalog.V1.BigQueryConnectionSpec.Types.ConnectionType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ConnectionType);
      }
      if (connectionSpecCase_ == ConnectionSpecOneofCase.CloudSql) {
        output.WriteRawTag(18);
        output.WriteMessage(CloudSql);
      }
      if (HasCredential != false) {
        output.WriteRawTag(24);
        output.WriteBool(HasCredential);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ConnectionType != global::Google.Cloud.DataCatalog.V1.BigQueryConnectionSpec.Types.ConnectionType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ConnectionType);
      }
      if (connectionSpecCase_ == ConnectionSpecOneofCase.CloudSql) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CloudSql);
      }
      if (HasCredential != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BigQueryConnectionSpec other) {
      if (other == null) {
        return;
      }
      if (other.ConnectionType != global::Google.Cloud.DataCatalog.V1.BigQueryConnectionSpec.Types.ConnectionType.Unspecified) {
        ConnectionType = other.ConnectionType;
      }
      if (other.HasCredential != false) {
        HasCredential = other.HasCredential;
      }
      switch (other.ConnectionSpecCase) {
        case ConnectionSpecOneofCase.CloudSql:
          if (CloudSql == null) {
            CloudSql = new global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec();
          }
          CloudSql.MergeFrom(other.CloudSql);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 8: {
            ConnectionType = (global::Google.Cloud.DataCatalog.V1.BigQueryConnectionSpec.Types.ConnectionType) input.ReadEnum();
            break;
          }
          case 18: {
            global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec subBuilder = new global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec();
            if (connectionSpecCase_ == ConnectionSpecOneofCase.CloudSql) {
              subBuilder.MergeFrom(CloudSql);
            }
            input.ReadMessage(subBuilder);
            CloudSql = subBuilder;
            break;
          }
          case 24: {
            HasCredential = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ConnectionType = (global::Google.Cloud.DataCatalog.V1.BigQueryConnectionSpec.Types.ConnectionType) input.ReadEnum();
            break;
          }
          case 18: {
            global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec subBuilder = new global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec();
            if (connectionSpecCase_ == ConnectionSpecOneofCase.CloudSql) {
              subBuilder.MergeFrom(CloudSql);
            }
            input.ReadMessage(subBuilder);
            CloudSql = subBuilder;
            break;
          }
          case 24: {
            HasCredential = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the BigQueryConnectionSpec message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The type of the BigQuery connection.
      /// </summary>
      public enum ConnectionType {
        /// <summary>
        /// Unspecified type.
        /// </summary>
        [pbr::OriginalName("CONNECTION_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Cloud SQL connection.
        /// </summary>
        [pbr::OriginalName("CLOUD_SQL")] CloudSql = 1,
      }

    }
    #endregion

  }

  /// <summary>
  /// Specification for the BigQuery connection to a Cloud SQL instance.
  /// </summary>
  public sealed partial class CloudSqlBigQueryConnectionSpec : pb::IMessage<CloudSqlBigQueryConnectionSpec>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CloudSqlBigQueryConnectionSpec> _parser = new pb::MessageParser<CloudSqlBigQueryConnectionSpec>(() => new CloudSqlBigQueryConnectionSpec());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CloudSqlBigQueryConnectionSpec> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.BigqueryReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CloudSqlBigQueryConnectionSpec() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CloudSqlBigQueryConnectionSpec(CloudSqlBigQueryConnectionSpec other) : this() {
      instanceId_ = other.instanceId_;
      database_ = other.database_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CloudSqlBigQueryConnectionSpec Clone() {
      return new CloudSqlBigQueryConnectionSpec(this);
    }

    /// <summary>Field number for the "instance_id" field.</summary>
    public const int InstanceIdFieldNumber = 1;
    private string instanceId_ = "";
    /// <summary>
    /// Cloud SQL instance ID in the format of `project:location:instance`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InstanceId {
      get { return instanceId_; }
      set {
        instanceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "database" field.</summary>
    public const int DatabaseFieldNumber = 2;
    private string database_ = "";
    /// <summary>
    /// Database name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Database {
      get { return database_; }
      set {
        database_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec.Types.DatabaseType type_ = global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec.Types.DatabaseType.Unspecified;
    /// <summary>
    /// Type of the Cloud SQL database.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec.Types.DatabaseType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CloudSqlBigQueryConnectionSpec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CloudSqlBigQueryConnectionSpec other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (InstanceId != other.InstanceId) return false;
      if (Database != other.Database) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (InstanceId.Length != 0) hash ^= InstanceId.GetHashCode();
      if (Database.Length != 0) hash ^= Database.GetHashCode();
      if (Type != global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec.Types.DatabaseType.Unspecified) hash ^= Type.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (InstanceId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(InstanceId);
      }
      if (Database.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Database);
      }
      if (Type != global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec.Types.DatabaseType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (InstanceId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(InstanceId);
      }
      if (Database.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Database);
      }
      if (Type != global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec.Types.DatabaseType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (InstanceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InstanceId);
      }
      if (Database.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Database);
      }
      if (Type != global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec.Types.DatabaseType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CloudSqlBigQueryConnectionSpec other) {
      if (other == null) {
        return;
      }
      if (other.InstanceId.Length != 0) {
        InstanceId = other.InstanceId;
      }
      if (other.Database.Length != 0) {
        Database = other.Database;
      }
      if (other.Type != global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec.Types.DatabaseType.Unspecified) {
        Type = other.Type;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            InstanceId = input.ReadString();
            break;
          }
          case 18: {
            Database = input.ReadString();
            break;
          }
          case 24: {
            Type = (global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec.Types.DatabaseType) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            InstanceId = input.ReadString();
            break;
          }
          case 18: {
            Database = input.ReadString();
            break;
          }
          case 24: {
            Type = (global::Google.Cloud.DataCatalog.V1.CloudSqlBigQueryConnectionSpec.Types.DatabaseType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CloudSqlBigQueryConnectionSpec message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Supported Cloud SQL database types.
      /// </summary>
      public enum DatabaseType {
        /// <summary>
        /// Unspecified database type.
        /// </summary>
        [pbr::OriginalName("DATABASE_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Cloud SQL for PostgreSQL.
        /// </summary>
        [pbr::OriginalName("POSTGRES")] Postgres = 1,
        /// <summary>
        /// Cloud SQL for MySQL.
        /// </summary>
        [pbr::OriginalName("MYSQL")] Mysql = 2,
      }

    }
    #endregion

  }

  /// <summary>
  /// Fields specific for BigQuery routines.
  /// </summary>
  public sealed partial class BigQueryRoutineSpec : pb::IMessage<BigQueryRoutineSpec>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BigQueryRoutineSpec> _parser = new pb::MessageParser<BigQueryRoutineSpec>(() => new BigQueryRoutineSpec());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BigQueryRoutineSpec> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.BigqueryReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BigQueryRoutineSpec() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BigQueryRoutineSpec(BigQueryRoutineSpec other) : this() {
      importedLibraries_ = other.importedLibraries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BigQueryRoutineSpec Clone() {
      return new BigQueryRoutineSpec(this);
    }

    /// <summary>Field number for the "imported_libraries" field.</summary>
    public const int ImportedLibrariesFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_importedLibraries_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> importedLibraries_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Paths of the imported libraries.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ImportedLibraries {
      get { return importedLibraries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BigQueryRoutineSpec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BigQueryRoutineSpec other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!importedLibraries_.Equals(other.importedLibraries_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= importedLibraries_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      importedLibraries_.WriteTo(output, _repeated_importedLibraries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      importedLibraries_.WriteTo(ref output, _repeated_importedLibraries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += importedLibraries_.CalculateSize(_repeated_importedLibraries_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BigQueryRoutineSpec other) {
      if (other == null) {
        return;
      }
      importedLibraries_.Add(other.importedLibraries_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            importedLibraries_.AddEntriesFrom(input, _repeated_importedLibraries_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            importedLibraries_.AddEntriesFrom(ref input, _repeated_importedLibraries_codec);
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
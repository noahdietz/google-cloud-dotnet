// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/feature_monitoring_stats.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/feature_monitoring_stats.proto</summary>
  public static partial class FeatureMonitoringStatsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/feature_monitoring_stats.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeatureMonitoringStatsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9mZWF0dXJlX21vbml0b3Jp",
            "bmdfc3RhdHMucHJvdG8SGmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxGh9n",
            "b29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvIu8BChNGZWF0dXJlU3Rh",
            "dHNBbm9tYWx5Eg0KBXNjb3JlGAEgASgBEhEKCXN0YXRzX3VyaRgDIAEoCRIT",
            "Cgthbm9tYWx5X3VyaRgEIAEoCRIeChZkaXN0cmlidXRpb25fZGV2aWF0aW9u",
            "GAUgASgBEiMKG2Fub21hbHlfZGV0ZWN0aW9uX3RocmVzaG9sZBgJIAEoARIu",
            "CgpzdGFydF90aW1lGAcgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFt",
            "cBIsCghlbmRfdGltZRgIIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3Rh",
            "bXBC3wEKHmNvbS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MUIbRmVhdHVy",
            "ZU1vbml0b3JpbmdTdGF0c1Byb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvYWlwbGF0Zm9ybS92MTthaXBsYXRm",
            "b3JtqgIaR29vZ2xlLkNsb3VkLkFJUGxhdGZvcm0uVjHKAhpHb29nbGVcQ2xv",
            "dWRcQUlQbGF0Zm9ybVxWMeoCHUdvb2dsZTo6Q2xvdWQ6OkFJUGxhdGZvcm06",
            "OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.FeatureStatsAnomaly), global::Google.Cloud.AIPlatform.V1.FeatureStatsAnomaly.Parser, new[]{ "Score", "StatsUri", "AnomalyUri", "DistributionDeviation", "AnomalyDetectionThreshold", "StartTime", "EndTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Stats and Anomaly generated at specific timestamp for specific Feature.
  /// The start_time and end_time are used to define the time range of the dataset
  /// that current stats belongs to, e.g. prediction traffic is bucketed into
  /// prediction datasets by time window. If the Dataset is not defined by time
  /// window, start_time = end_time. Timestamp of the stats and anomalies always
  /// refers to end_time. Raw stats and anomalies are stored in stats_uri or
  /// anomaly_uri in the tensorflow defined protos. Field data_stats contains
  /// almost identical information with the raw stats in Vertex AI
  /// defined proto, for UI to display.
  /// </summary>
  public sealed partial class FeatureStatsAnomaly : pb::IMessage<FeatureStatsAnomaly>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeatureStatsAnomaly> _parser = new pb::MessageParser<FeatureStatsAnomaly>(() => new FeatureStatsAnomaly());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeatureStatsAnomaly> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.FeatureMonitoringStatsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureStatsAnomaly() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureStatsAnomaly(FeatureStatsAnomaly other) : this() {
      score_ = other.score_;
      statsUri_ = other.statsUri_;
      anomalyUri_ = other.anomalyUri_;
      distributionDeviation_ = other.distributionDeviation_;
      anomalyDetectionThreshold_ = other.anomalyDetectionThreshold_;
      startTime_ = other.startTime_ != null ? other.startTime_.Clone() : null;
      endTime_ = other.endTime_ != null ? other.endTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureStatsAnomaly Clone() {
      return new FeatureStatsAnomaly(this);
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 1;
    private double score_;
    /// <summary>
    /// Feature importance score, only populated when cross-feature monitoring is
    /// enabled. For now only used to represent feature attribution score within
    /// range [0, 1] for
    /// [ModelDeploymentMonitoringObjectiveType.FEATURE_ATTRIBUTION_SKEW][google.cloud.aiplatform.v1.ModelDeploymentMonitoringObjectiveType.FEATURE_ATTRIBUTION_SKEW] and
    /// [ModelDeploymentMonitoringObjectiveType.FEATURE_ATTRIBUTION_DRIFT][google.cloud.aiplatform.v1.ModelDeploymentMonitoringObjectiveType.FEATURE_ATTRIBUTION_DRIFT].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "stats_uri" field.</summary>
    public const int StatsUriFieldNumber = 3;
    private string statsUri_ = "";
    /// <summary>
    /// Path of the stats file for current feature values in Cloud Storage bucket.
    /// Format: gs://&lt;bucket_name>/&lt;object_name>/stats.
    /// Example: gs://monitoring_bucket/feature_name/stats.
    /// Stats are stored as binary format with Protobuf message
    /// [tensorflow.metadata.v0.FeatureNameStatistics](https://github.com/tensorflow/metadata/blob/master/tensorflow_metadata/proto/v0/statistics.proto).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StatsUri {
      get { return statsUri_; }
      set {
        statsUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "anomaly_uri" field.</summary>
    public const int AnomalyUriFieldNumber = 4;
    private string anomalyUri_ = "";
    /// <summary>
    /// Path of the anomaly file for current feature values in Cloud Storage
    /// bucket.
    /// Format: gs://&lt;bucket_name>/&lt;object_name>/anomalies.
    /// Example: gs://monitoring_bucket/feature_name/anomalies.
    /// Stats are stored as binary format with Protobuf message
    /// Anoamlies are stored as binary format with Protobuf message
    /// [tensorflow.metadata.v0.AnomalyInfo]
    /// (https://github.com/tensorflow/metadata/blob/master/tensorflow_metadata/proto/v0/anomalies.proto).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AnomalyUri {
      get { return anomalyUri_; }
      set {
        anomalyUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "distribution_deviation" field.</summary>
    public const int DistributionDeviationFieldNumber = 5;
    private double distributionDeviation_;
    /// <summary>
    /// Deviation from the current stats to baseline stats.
    ///   1. For categorical feature, the distribution distance is calculated by
    ///      L-inifinity norm.
    ///   2. For numerical feature, the distribution distance is calculated by
    ///      Jensen–Shannon divergence.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double DistributionDeviation {
      get { return distributionDeviation_; }
      set {
        distributionDeviation_ = value;
      }
    }

    /// <summary>Field number for the "anomaly_detection_threshold" field.</summary>
    public const int AnomalyDetectionThresholdFieldNumber = 9;
    private double anomalyDetectionThreshold_;
    /// <summary>
    /// This is the threshold used when detecting anomalies.
    /// The threshold can be changed by user, so this one might be different from
    /// [ThresholdConfig.value][google.cloud.aiplatform.v1.ThresholdConfig.value].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double AnomalyDetectionThreshold {
      get { return anomalyDetectionThreshold_; }
      set {
        anomalyDetectionThreshold_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp startTime_;
    /// <summary>
    /// The start timestamp of window where stats were generated.
    /// For objectives where time window doesn't make sense (e.g. Featurestore
    /// Snapshot Monitoring), start_time is only used to indicate the monitoring
    /// intervals, so it always equals to (end_time - monitoring_interval).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 8;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endTime_;
    /// <summary>
    /// The end timestamp of window where stats were generated.
    /// For objectives where time window doesn't make sense (e.g. Featurestore
    /// Snapshot Monitoring), end_time indicates the timestamp of the data used to
    /// generate stats (e.g. timestamp we take snapshots for feature values).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeatureStatsAnomaly);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeatureStatsAnomaly other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Score, other.Score)) return false;
      if (StatsUri != other.StatsUri) return false;
      if (AnomalyUri != other.AnomalyUri) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DistributionDeviation, other.DistributionDeviation)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AnomalyDetectionThreshold, other.AnomalyDetectionThreshold)) return false;
      if (!object.Equals(StartTime, other.StartTime)) return false;
      if (!object.Equals(EndTime, other.EndTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Score != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Score);
      if (StatsUri.Length != 0) hash ^= StatsUri.GetHashCode();
      if (AnomalyUri.Length != 0) hash ^= AnomalyUri.GetHashCode();
      if (DistributionDeviation != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DistributionDeviation);
      if (AnomalyDetectionThreshold != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AnomalyDetectionThreshold);
      if (startTime_ != null) hash ^= StartTime.GetHashCode();
      if (endTime_ != null) hash ^= EndTime.GetHashCode();
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
      if (Score != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Score);
      }
      if (StatsUri.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(StatsUri);
      }
      if (AnomalyUri.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AnomalyUri);
      }
      if (DistributionDeviation != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(DistributionDeviation);
      }
      if (startTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(EndTime);
      }
      if (AnomalyDetectionThreshold != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(AnomalyDetectionThreshold);
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
      if (Score != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Score);
      }
      if (StatsUri.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(StatsUri);
      }
      if (AnomalyUri.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AnomalyUri);
      }
      if (DistributionDeviation != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(DistributionDeviation);
      }
      if (startTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(EndTime);
      }
      if (AnomalyDetectionThreshold != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(AnomalyDetectionThreshold);
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
      if (Score != 0D) {
        size += 1 + 8;
      }
      if (StatsUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StatsUri);
      }
      if (AnomalyUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AnomalyUri);
      }
      if (DistributionDeviation != 0D) {
        size += 1 + 8;
      }
      if (AnomalyDetectionThreshold != 0D) {
        size += 1 + 8;
      }
      if (startTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartTime);
      }
      if (endTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeatureStatsAnomaly other) {
      if (other == null) {
        return;
      }
      if (other.Score != 0D) {
        Score = other.Score;
      }
      if (other.StatsUri.Length != 0) {
        StatsUri = other.StatsUri;
      }
      if (other.AnomalyUri.Length != 0) {
        AnomalyUri = other.AnomalyUri;
      }
      if (other.DistributionDeviation != 0D) {
        DistributionDeviation = other.DistributionDeviation;
      }
      if (other.AnomalyDetectionThreshold != 0D) {
        AnomalyDetectionThreshold = other.AnomalyDetectionThreshold;
      }
      if (other.startTime_ != null) {
        if (startTime_ == null) {
          StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StartTime.MergeFrom(other.StartTime);
      }
      if (other.endTime_ != null) {
        if (endTime_ == null) {
          EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EndTime.MergeFrom(other.EndTime);
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
          case 9: {
            Score = input.ReadDouble();
            break;
          }
          case 26: {
            StatsUri = input.ReadString();
            break;
          }
          case 34: {
            AnomalyUri = input.ReadString();
            break;
          }
          case 41: {
            DistributionDeviation = input.ReadDouble();
            break;
          }
          case 58: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 66: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 73: {
            AnomalyDetectionThreshold = input.ReadDouble();
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
          case 9: {
            Score = input.ReadDouble();
            break;
          }
          case 26: {
            StatsUri = input.ReadString();
            break;
          }
          case 34: {
            AnomalyUri = input.ReadString();
            break;
          }
          case 41: {
            DistributionDeviation = input.ReadDouble();
            break;
          }
          case 58: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 66: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 73: {
            AnomalyDetectionThreshold = input.ReadDouble();
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

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/assuredworkloads/v1beta1/assuredworkloads_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AssuredWorkloads.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/assuredworkloads/v1beta1/assuredworkloads_service.proto</summary>
  public static partial class AssuredworkloadsServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/assuredworkloads/v1beta1/assuredworkloads_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssuredworkloadsServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRnb29nbGUvY2xvdWQvYXNzdXJlZHdvcmtsb2Fkcy92MWJldGExL2Fzc3Vy",
            "ZWR3b3JrbG9hZHNfc2VydmljZS5wcm90bxIlZ29vZ2xlLmNsb3VkLmFzc3Vy",
            "ZWR3b3JrbG9hZHMudjFiZXRhMRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5w",
            "cm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8aPGdvb2dsZS9jbG91ZC9h",
            "c3N1cmVkd29ya2xvYWRzL3YxYmV0YTEvYXNzdXJlZHdvcmtsb2Fkcy5wcm90",
            "bxojZ29vZ2xlL2xvbmdydW5uaW5nL29wZXJhdGlvbnMucHJvdG8aG2dvb2ds",
            "ZS9wcm90b2J1Zi9lbXB0eS5wcm90bzKPDQoXQXNzdXJlZFdvcmtsb2Fkc1Nl",
            "cnZpY2US+QEKDkNyZWF0ZVdvcmtsb2FkEjwuZ29vZ2xlLmNsb3VkLmFzc3Vy",
            "ZWR3b3JrbG9hZHMudjFiZXRhMS5DcmVhdGVXb3JrbG9hZFJlcXVlc3QaHS5n",
            "b29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIokBgtPkkwJDIjcvdjFiZXRh",
            "MS97cGFyZW50PW9yZ2FuaXphdGlvbnMvKi9sb2NhdGlvbnMvKn0vd29ya2xv",
            "YWRzOgh3b3JrbG9hZNpBD3BhcmVudCx3b3JrbG9hZMpBKwoIV29ya2xvYWQS",
            "H0NyZWF0ZVdvcmtsb2FkT3BlcmF0aW9uTWV0YWRhdGES6gEKDlVwZGF0ZVdv",
            "cmtsb2FkEjwuZ29vZ2xlLmNsb3VkLmFzc3VyZWR3b3JrbG9hZHMudjFiZXRh",
            "MS5VcGRhdGVXb3JrbG9hZFJlcXVlc3QaLy5nb29nbGUuY2xvdWQuYXNzdXJl",
            "ZHdvcmtsb2Fkcy52MWJldGExLldvcmtsb2FkImmC0+STAkwyQC92MWJldGEx",
            "L3t3b3JrbG9hZC5uYW1lPW9yZ2FuaXphdGlvbnMvKi9sb2NhdGlvbnMvKi93",
            "b3JrbG9hZHMvKn06CHdvcmtsb2Fk2kEUd29ya2xvYWQsdXBkYXRlX21hc2sS",
            "qgEKF1Jlc3RyaWN0QWxsb3dlZFNlcnZpY2VzEkUuZ29vZ2xlLmNsb3VkLmFz",
            "c3VyZWR3b3JrbG9hZHMudjFiZXRhMS5SZXN0cmljdEFsbG93ZWRTZXJ2aWNl",
            "c1JlcXVlc3QaRi5nb29nbGUuY2xvdWQuYXNzdXJlZHdvcmtsb2Fkcy52MWJl",
            "dGExLlJlc3RyaWN0QWxsb3dlZFNlcnZpY2VzUmVzcG9uc2UiABKIAgoYUmVz",
            "dHJpY3RBbGxvd2VkUmVzb3VyY2VzEkYuZ29vZ2xlLmNsb3VkLmFzc3VyZWR3",
            "b3JrbG9hZHMudjFiZXRhMS5SZXN0cmljdEFsbG93ZWRSZXNvdXJjZXNSZXF1",
            "ZXN0GkcuZ29vZ2xlLmNsb3VkLmFzc3VyZWR3b3JrbG9hZHMudjFiZXRhMS5S",
            "ZXN0cmljdEFsbG93ZWRSZXNvdXJjZXNSZXNwb25zZSJbgtPkkwJVIlAvdjFi",
            "ZXRhMS97bmFtZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyovd29ya2xv",
            "YWRzLyp9OnJlc3RyaWN0QWxsb3dlZFJlc291cmNlczoBKhKuAQoORGVsZXRl",
            "V29ya2xvYWQSPC5nb29nbGUuY2xvdWQuYXNzdXJlZHdvcmtsb2Fkcy52MWJl",
            "dGExLkRlbGV0ZVdvcmtsb2FkUmVxdWVzdBoWLmdvb2dsZS5wcm90b2J1Zi5F",
            "bXB0eSJGgtPkkwI5KjcvdjFiZXRhMS97bmFtZT1vcmdhbml6YXRpb25zLyov",
            "bG9jYXRpb25zLyovd29ya2xvYWRzLyp92kEEbmFtZRKCAQoLR2V0V29ya2xv",
            "YWQSOS5nb29nbGUuY2xvdWQuYXNzdXJlZHdvcmtsb2Fkcy52MWJldGExLkdl",
            "dFdvcmtsb2FkUmVxdWVzdBovLmdvb2dsZS5jbG91ZC5hc3N1cmVkd29ya2xv",
            "YWRzLnYxYmV0YTEuV29ya2xvYWQiB9pBBG5hbWUSrwEKE0FuYWx5emVXb3Jr",
            "bG9hZE1vdmUSQS5nb29nbGUuY2xvdWQuYXNzdXJlZHdvcmtsb2Fkcy52MWJl",
            "dGExLkFuYWx5emVXb3JrbG9hZE1vdmVSZXF1ZXN0GkIuZ29vZ2xlLmNsb3Vk",
            "LmFzc3VyZWR3b3JrbG9hZHMudjFiZXRhMS5BbmFseXplV29ya2xvYWRNb3Zl",
            "UmVzcG9uc2UiEdpBDnByb2plY3QsdGFyZ2V0EpUBCg1MaXN0V29ya2xvYWRz",
            "EjsuZ29vZ2xlLmNsb3VkLmFzc3VyZWR3b3JrbG9hZHMudjFiZXRhMS5MaXN0",
            "V29ya2xvYWRzUmVxdWVzdBo8Lmdvb2dsZS5jbG91ZC5hc3N1cmVkd29ya2xv",
            "YWRzLnYxYmV0YTEuTGlzdFdvcmtsb2Fkc1Jlc3BvbnNlIgnaQQZwYXJlbnQa",
            "U8pBH2Fzc3VyZWR3b3JrbG9hZHMuZ29vZ2xlYXBpcy5jb23SQS5odHRwczov",
            "L3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2Nsb3VkLXBsYXRmb3JtQp0CCilj",
            "b20uZ29vZ2xlLmNsb3VkLmFzc3VyZWR3b3JrbG9hZHMudjFiZXRhMUIcQXNz",
            "dXJlZHdvcmtsb2Fkc1NlcnZpY2VQcm90b1ABWlVnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3VkL2Fzc3VyZWR3b3JrbG9hZHMv",
            "djFiZXRhMTthc3N1cmVkd29ya2xvYWRzqgIlR29vZ2xlLkNsb3VkLkFzc3Vy",
            "ZWRXb3JrbG9hZHMuVjFCZXRhMcoCJUdvb2dsZVxDbG91ZFxBc3N1cmVkV29y",
            "a2xvYWRzXFYxYmV0YTHqAihHb29nbGU6OkNsb3VkOjpBc3N1cmVkV29ya2xv",
            "YWRzOjpWMWJldGExYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Cloud.AssuredWorkloads.V1Beta1.AssuredworkloadsReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code

// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AIPlatform.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPipelineServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateTrainingPipelineRequestObject()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                ParentModel = "parent_model26d003ff",
                ModelId = "model_id8abf7c47",
            };
            mockGrpcClient.Setup(x => x.CreateTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            TrainingPipeline response = client.CreateTrainingPipeline(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTrainingPipelineRequestObjectAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                ParentModel = "parent_model26d003ff",
                ModelId = "model_id8abf7c47",
            };
            mockGrpcClient.Setup(x => x.CreateTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TrainingPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            TrainingPipeline responseCallSettings = await client.CreateTrainingPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TrainingPipeline responseCancellationToken = await client.CreateTrainingPipelineAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTrainingPipeline()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                ParentModel = "parent_model26d003ff",
                ModelId = "model_id8abf7c47",
            };
            mockGrpcClient.Setup(x => x.CreateTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            TrainingPipeline response = client.CreateTrainingPipeline(request.Parent, request.TrainingPipeline);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTrainingPipelineAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                ParentModel = "parent_model26d003ff",
                ModelId = "model_id8abf7c47",
            };
            mockGrpcClient.Setup(x => x.CreateTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TrainingPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            TrainingPipeline responseCallSettings = await client.CreateTrainingPipelineAsync(request.Parent, request.TrainingPipeline, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TrainingPipeline responseCancellationToken = await client.CreateTrainingPipelineAsync(request.Parent, request.TrainingPipeline, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTrainingPipelineResourceNames()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                ParentModel = "parent_model26d003ff",
                ModelId = "model_id8abf7c47",
            };
            mockGrpcClient.Setup(x => x.CreateTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            TrainingPipeline response = client.CreateTrainingPipeline(request.ParentAsLocationName, request.TrainingPipeline);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTrainingPipelineResourceNamesAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                ParentModel = "parent_model26d003ff",
                ModelId = "model_id8abf7c47",
            };
            mockGrpcClient.Setup(x => x.CreateTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TrainingPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            TrainingPipeline responseCallSettings = await client.CreateTrainingPipelineAsync(request.ParentAsLocationName, request.TrainingPipeline, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TrainingPipeline responseCancellationToken = await client.CreateTrainingPipelineAsync(request.ParentAsLocationName, request.TrainingPipeline, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTrainingPipelineRequestObject()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                ParentModel = "parent_model26d003ff",
                ModelId = "model_id8abf7c47",
            };
            mockGrpcClient.Setup(x => x.GetTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            TrainingPipeline response = client.GetTrainingPipeline(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTrainingPipelineRequestObjectAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                ParentModel = "parent_model26d003ff",
                ModelId = "model_id8abf7c47",
            };
            mockGrpcClient.Setup(x => x.GetTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TrainingPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            TrainingPipeline responseCallSettings = await client.GetTrainingPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TrainingPipeline responseCancellationToken = await client.GetTrainingPipelineAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTrainingPipeline()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                ParentModel = "parent_model26d003ff",
                ModelId = "model_id8abf7c47",
            };
            mockGrpcClient.Setup(x => x.GetTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            TrainingPipeline response = client.GetTrainingPipeline(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTrainingPipelineAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                ParentModel = "parent_model26d003ff",
                ModelId = "model_id8abf7c47",
            };
            mockGrpcClient.Setup(x => x.GetTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TrainingPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            TrainingPipeline responseCallSettings = await client.GetTrainingPipelineAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TrainingPipeline responseCancellationToken = await client.GetTrainingPipelineAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTrainingPipelineResourceNames()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                ParentModel = "parent_model26d003ff",
                ModelId = "model_id8abf7c47",
            };
            mockGrpcClient.Setup(x => x.GetTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            TrainingPipeline response = client.GetTrainingPipeline(request.TrainingPipelineName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTrainingPipelineResourceNamesAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            TrainingPipeline expectedResponse = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "display_name137f65c2",
                InputDataConfig = new InputDataConfig(),
                TrainingTaskDefinition = "training_task_definition3e3456be",
                TrainingTaskInputs = new wkt::Value(),
                TrainingTaskMetadata = new wkt::Value(),
                ModelToUpload = new Model(),
                State = PipelineState.Running,
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EncryptionSpec = new EncryptionSpec(),
                ParentModel = "parent_model26d003ff",
                ModelId = "model_id8abf7c47",
            };
            mockGrpcClient.Setup(x => x.GetTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TrainingPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            TrainingPipeline responseCallSettings = await client.GetTrainingPipelineAsync(request.TrainingPipelineName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TrainingPipeline responseCancellationToken = await client.GetTrainingPipelineAsync(request.TrainingPipelineName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelTrainingPipelineRequestObject()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            client.CancelTrainingPipeline(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelTrainingPipelineRequestObjectAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelTrainingPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelTrainingPipelineAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelTrainingPipeline()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            client.CancelTrainingPipeline(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelTrainingPipelineAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelTrainingPipelineAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelTrainingPipelineAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelTrainingPipelineResourceNames()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelTrainingPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            client.CancelTrainingPipeline(request.TrainingPipelineName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelTrainingPipelineResourceNamesAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelTrainingPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelTrainingPipelineAsync(request.TrainingPipelineName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelTrainingPipelineAsync(request.TrainingPipelineName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePipelineJobRequestObject()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreatePipelineJobRequest request = new CreatePipelineJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PipelineJob = new PipelineJob(),
                PipelineJobId = "pipeline_job_id54c2a3dd",
            };
            PipelineJob expectedResponse = new PipelineJob
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PipelineSpec = new wkt::Struct(),
                State = PipelineState.Running,
                JobDetail = new PipelineJobDetail(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new PipelineJob.Types.RuntimeConfig(),
                EncryptionSpec = new EncryptionSpec(),
                ServiceAccount = "service_accounta3c1b923",
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                TemplateUri = "template_uriec49b2a8",
                TemplateMetadata = new PipelineTemplateMetadata(),
            };
            mockGrpcClient.Setup(x => x.CreatePipelineJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            PipelineJob response = client.CreatePipelineJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePipelineJobRequestObjectAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreatePipelineJobRequest request = new CreatePipelineJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PipelineJob = new PipelineJob(),
                PipelineJobId = "pipeline_job_id54c2a3dd",
            };
            PipelineJob expectedResponse = new PipelineJob
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PipelineSpec = new wkt::Struct(),
                State = PipelineState.Running,
                JobDetail = new PipelineJobDetail(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new PipelineJob.Types.RuntimeConfig(),
                EncryptionSpec = new EncryptionSpec(),
                ServiceAccount = "service_accounta3c1b923",
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                TemplateUri = "template_uriec49b2a8",
                TemplateMetadata = new PipelineTemplateMetadata(),
            };
            mockGrpcClient.Setup(x => x.CreatePipelineJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PipelineJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            PipelineJob responseCallSettings = await client.CreatePipelineJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PipelineJob responseCancellationToken = await client.CreatePipelineJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePipelineJob()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreatePipelineJobRequest request = new CreatePipelineJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PipelineJob = new PipelineJob(),
                PipelineJobId = "pipeline_job_id54c2a3dd",
            };
            PipelineJob expectedResponse = new PipelineJob
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PipelineSpec = new wkt::Struct(),
                State = PipelineState.Running,
                JobDetail = new PipelineJobDetail(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new PipelineJob.Types.RuntimeConfig(),
                EncryptionSpec = new EncryptionSpec(),
                ServiceAccount = "service_accounta3c1b923",
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                TemplateUri = "template_uriec49b2a8",
                TemplateMetadata = new PipelineTemplateMetadata(),
            };
            mockGrpcClient.Setup(x => x.CreatePipelineJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            PipelineJob response = client.CreatePipelineJob(request.Parent, request.PipelineJob, request.PipelineJobId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePipelineJobAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreatePipelineJobRequest request = new CreatePipelineJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PipelineJob = new PipelineJob(),
                PipelineJobId = "pipeline_job_id54c2a3dd",
            };
            PipelineJob expectedResponse = new PipelineJob
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PipelineSpec = new wkt::Struct(),
                State = PipelineState.Running,
                JobDetail = new PipelineJobDetail(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new PipelineJob.Types.RuntimeConfig(),
                EncryptionSpec = new EncryptionSpec(),
                ServiceAccount = "service_accounta3c1b923",
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                TemplateUri = "template_uriec49b2a8",
                TemplateMetadata = new PipelineTemplateMetadata(),
            };
            mockGrpcClient.Setup(x => x.CreatePipelineJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PipelineJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            PipelineJob responseCallSettings = await client.CreatePipelineJobAsync(request.Parent, request.PipelineJob, request.PipelineJobId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PipelineJob responseCancellationToken = await client.CreatePipelineJobAsync(request.Parent, request.PipelineJob, request.PipelineJobId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePipelineJobResourceNames()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreatePipelineJobRequest request = new CreatePipelineJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PipelineJob = new PipelineJob(),
                PipelineJobId = "pipeline_job_id54c2a3dd",
            };
            PipelineJob expectedResponse = new PipelineJob
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PipelineSpec = new wkt::Struct(),
                State = PipelineState.Running,
                JobDetail = new PipelineJobDetail(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new PipelineJob.Types.RuntimeConfig(),
                EncryptionSpec = new EncryptionSpec(),
                ServiceAccount = "service_accounta3c1b923",
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                TemplateUri = "template_uriec49b2a8",
                TemplateMetadata = new PipelineTemplateMetadata(),
            };
            mockGrpcClient.Setup(x => x.CreatePipelineJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            PipelineJob response = client.CreatePipelineJob(request.ParentAsLocationName, request.PipelineJob, request.PipelineJobId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePipelineJobResourceNamesAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreatePipelineJobRequest request = new CreatePipelineJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PipelineJob = new PipelineJob(),
                PipelineJobId = "pipeline_job_id54c2a3dd",
            };
            PipelineJob expectedResponse = new PipelineJob
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PipelineSpec = new wkt::Struct(),
                State = PipelineState.Running,
                JobDetail = new PipelineJobDetail(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new PipelineJob.Types.RuntimeConfig(),
                EncryptionSpec = new EncryptionSpec(),
                ServiceAccount = "service_accounta3c1b923",
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                TemplateUri = "template_uriec49b2a8",
                TemplateMetadata = new PipelineTemplateMetadata(),
            };
            mockGrpcClient.Setup(x => x.CreatePipelineJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PipelineJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            PipelineJob responseCallSettings = await client.CreatePipelineJobAsync(request.ParentAsLocationName, request.PipelineJob, request.PipelineJobId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PipelineJob responseCancellationToken = await client.CreatePipelineJobAsync(request.ParentAsLocationName, request.PipelineJob, request.PipelineJobId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPipelineJobRequestObject()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetPipelineJobRequest request = new GetPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            PipelineJob expectedResponse = new PipelineJob
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PipelineSpec = new wkt::Struct(),
                State = PipelineState.Running,
                JobDetail = new PipelineJobDetail(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new PipelineJob.Types.RuntimeConfig(),
                EncryptionSpec = new EncryptionSpec(),
                ServiceAccount = "service_accounta3c1b923",
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                TemplateUri = "template_uriec49b2a8",
                TemplateMetadata = new PipelineTemplateMetadata(),
            };
            mockGrpcClient.Setup(x => x.GetPipelineJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            PipelineJob response = client.GetPipelineJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPipelineJobRequestObjectAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetPipelineJobRequest request = new GetPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            PipelineJob expectedResponse = new PipelineJob
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PipelineSpec = new wkt::Struct(),
                State = PipelineState.Running,
                JobDetail = new PipelineJobDetail(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new PipelineJob.Types.RuntimeConfig(),
                EncryptionSpec = new EncryptionSpec(),
                ServiceAccount = "service_accounta3c1b923",
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                TemplateUri = "template_uriec49b2a8",
                TemplateMetadata = new PipelineTemplateMetadata(),
            };
            mockGrpcClient.Setup(x => x.GetPipelineJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PipelineJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            PipelineJob responseCallSettings = await client.GetPipelineJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PipelineJob responseCancellationToken = await client.GetPipelineJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPipelineJob()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetPipelineJobRequest request = new GetPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            PipelineJob expectedResponse = new PipelineJob
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PipelineSpec = new wkt::Struct(),
                State = PipelineState.Running,
                JobDetail = new PipelineJobDetail(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new PipelineJob.Types.RuntimeConfig(),
                EncryptionSpec = new EncryptionSpec(),
                ServiceAccount = "service_accounta3c1b923",
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                TemplateUri = "template_uriec49b2a8",
                TemplateMetadata = new PipelineTemplateMetadata(),
            };
            mockGrpcClient.Setup(x => x.GetPipelineJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            PipelineJob response = client.GetPipelineJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPipelineJobAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetPipelineJobRequest request = new GetPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            PipelineJob expectedResponse = new PipelineJob
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PipelineSpec = new wkt::Struct(),
                State = PipelineState.Running,
                JobDetail = new PipelineJobDetail(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new PipelineJob.Types.RuntimeConfig(),
                EncryptionSpec = new EncryptionSpec(),
                ServiceAccount = "service_accounta3c1b923",
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                TemplateUri = "template_uriec49b2a8",
                TemplateMetadata = new PipelineTemplateMetadata(),
            };
            mockGrpcClient.Setup(x => x.GetPipelineJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PipelineJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            PipelineJob responseCallSettings = await client.GetPipelineJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PipelineJob responseCancellationToken = await client.GetPipelineJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPipelineJobResourceNames()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetPipelineJobRequest request = new GetPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            PipelineJob expectedResponse = new PipelineJob
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PipelineSpec = new wkt::Struct(),
                State = PipelineState.Running,
                JobDetail = new PipelineJobDetail(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new PipelineJob.Types.RuntimeConfig(),
                EncryptionSpec = new EncryptionSpec(),
                ServiceAccount = "service_accounta3c1b923",
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                TemplateUri = "template_uriec49b2a8",
                TemplateMetadata = new PipelineTemplateMetadata(),
            };
            mockGrpcClient.Setup(x => x.GetPipelineJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            PipelineJob response = client.GetPipelineJob(request.PipelineJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPipelineJobResourceNamesAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetPipelineJobRequest request = new GetPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            PipelineJob expectedResponse = new PipelineJob
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PipelineSpec = new wkt::Struct(),
                State = PipelineState.Running,
                JobDetail = new PipelineJobDetail(),
                Error = new gr::Status(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new PipelineJob.Types.RuntimeConfig(),
                EncryptionSpec = new EncryptionSpec(),
                ServiceAccount = "service_accounta3c1b923",
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                TemplateUri = "template_uriec49b2a8",
                TemplateMetadata = new PipelineTemplateMetadata(),
            };
            mockGrpcClient.Setup(x => x.GetPipelineJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PipelineJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            PipelineJob responseCallSettings = await client.GetPipelineJobAsync(request.PipelineJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PipelineJob responseCancellationToken = await client.GetPipelineJobAsync(request.PipelineJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelPipelineJobRequestObject()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelPipelineJobRequest request = new CancelPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelPipelineJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            client.CancelPipelineJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelPipelineJobRequestObjectAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelPipelineJobRequest request = new CancelPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelPipelineJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelPipelineJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelPipelineJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelPipelineJob()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelPipelineJobRequest request = new CancelPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelPipelineJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            client.CancelPipelineJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelPipelineJobAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelPipelineJobRequest request = new CancelPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelPipelineJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelPipelineJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelPipelineJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelPipelineJobResourceNames()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelPipelineJobRequest request = new CancelPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelPipelineJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            client.CancelPipelineJob(request.PipelineJobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelPipelineJobResourceNamesAsync()
        {
            moq::Mock<PipelineService.PipelineServiceClient> mockGrpcClient = new moq::Mock<PipelineService.PipelineServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CancelPipelineJobRequest request = new CancelPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelPipelineJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PipelineServiceClient client = new PipelineServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelPipelineJobAsync(request.PipelineJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelPipelineJobAsync(request.PipelineJobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}

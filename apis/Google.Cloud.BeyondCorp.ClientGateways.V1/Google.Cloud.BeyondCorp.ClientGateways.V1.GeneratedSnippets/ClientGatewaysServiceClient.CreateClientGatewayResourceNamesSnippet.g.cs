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

namespace Google.Cloud.BeyondCorp.ClientGateways.V1.Snippets
{
    // [START beyondcorp_v1_generated_ClientGatewaysService_CreateClientGateway_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.BeyondCorp.ClientGateways.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedClientGatewaysServiceClientSnippets
    {
        /// <summary>Snippet for CreateClientGateway</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateClientGatewayResourceNames()
        {
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ClientGateway clientGateway = new ClientGateway();
            string clientGatewayId = "";
            // Make the request
            Operation<ClientGateway, ClientGatewayOperationMetadata> response = clientGatewaysServiceClient.CreateClientGateway(parent, clientGateway, clientGatewayId);

            // Poll until the returned long-running operation is complete
            Operation<ClientGateway, ClientGatewayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientGateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientGateway, ClientGatewayOperationMetadata> retrievedResponse = clientGatewaysServiceClient.PollOnceCreateClientGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientGateway retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END beyondcorp_v1_generated_ClientGatewaysService_CreateClientGateway_sync_flattened_resourceNames]
}
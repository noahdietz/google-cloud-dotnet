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

namespace Google.Cloud.NetworkConnectivity.V1Alpha1.Snippets
{
    // [START networkconnectivity_v1alpha1_generated_HubService_CreateHub_sync_flattened]
    using Google.Cloud.NetworkConnectivity.V1Alpha1;
    using Google.LongRunning;

    public sealed partial class GeneratedHubServiceClientSnippets
    {
        /// <summary>Snippet for CreateHub</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateHub()
        {
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Hub hub = new Hub();
            string hubId = "";
            // Make the request
            Operation<Hub, OperationMetadata> response = hubServiceClient.CreateHub(parent, hub, hubId);

            // Poll until the returned long-running operation is complete
            Operation<Hub, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hub result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hub, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceCreateHub(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hub retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END networkconnectivity_v1alpha1_generated_HubService_CreateHub_sync_flattened]
}
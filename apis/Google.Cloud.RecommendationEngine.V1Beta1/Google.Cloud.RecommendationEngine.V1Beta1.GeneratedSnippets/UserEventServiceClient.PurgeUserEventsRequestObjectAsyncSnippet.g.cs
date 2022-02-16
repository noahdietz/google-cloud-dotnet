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

namespace Google.Cloud.RecommendationEngine.V1Beta1.Snippets
{
    // [START recommendationengine_v1beta1_generated_UserEventService_PurgeUserEvents_async]
    using Google.Cloud.RecommendationEngine.V1Beta1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedUserEventServiceClientSnippets
    {
        /// <summary>Snippet for PurgeUserEventsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task PurgeUserEventsRequestObjectAsync()
        {
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            PurgeUserEventsRequest request = new PurgeUserEventsRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> response = await userEventServiceClient.PurgeUserEventsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> retrievedResponse = await userEventServiceClient.PollOncePurgeUserEventsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END recommendationengine_v1beta1_generated_UserEventService_PurgeUserEvents_async]
}
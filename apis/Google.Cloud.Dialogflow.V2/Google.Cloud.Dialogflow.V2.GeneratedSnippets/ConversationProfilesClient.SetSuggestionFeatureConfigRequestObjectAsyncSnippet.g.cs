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

namespace Google.Cloud.Dialogflow.V2.Snippets
{
    // [START dialogflow_v2_generated_ConversationProfiles_SetSuggestionFeatureConfig_async]
    using Google.Cloud.Dialogflow.V2;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedConversationProfilesClientSnippets
    {
        /// <summary>Snippet for SetSuggestionFeatureConfigAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task SetSuggestionFeatureConfigRequestObjectAsync()
        {
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            SetSuggestionFeatureConfigRequest request = new SetSuggestionFeatureConfigRequest
            {
                ConversationProfile = "",
                ParticipantRole = Participant.Types.Role.Unspecified,
                SuggestionFeatureConfig = new HumanAgentAssistantConfig.Types.SuggestionFeatureConfig(),
            };
            // Make the request
            Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata> response = await conversationProfilesClient.SetSuggestionFeatureConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversationProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata> retrievedResponse = await conversationProfilesClient.PollOnceSetSuggestionFeatureConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationProfile retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dialogflow_v2_generated_ConversationProfiles_SetSuggestionFeatureConfig_async]
}
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

namespace Google.Cloud.GkeMultiCloud.V1.Snippets
{
    // [START gkemulticloud_v1_generated_AzureClusters_GetAzureServerConfig_sync]
    using Google.Cloud.GkeMultiCloud.V1;

    public sealed partial class GeneratedAzureClustersClientSnippets
    {
        /// <summary>Snippet for GetAzureServerConfig</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetAzureServerConfigRequestObject()
        {
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            GetAzureServerConfigRequest request = new GetAzureServerConfigRequest
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            AzureServerConfig response = azureClustersClient.GetAzureServerConfig(request);
        }
    }
    // [END gkemulticloud_v1_generated_AzureClusters_GetAzureServerConfig_sync]
}

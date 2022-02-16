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

namespace Google.Cloud.OsConfig.V1Alpha.Snippets
{
    // [START osconfig_v1alpha_generated_OsConfigZonalService_GetInventory_sync]
    using Google.Cloud.OsConfig.V1Alpha;

    public sealed partial class GeneratedOsConfigZonalServiceClientSnippets
    {
        /// <summary>Snippet for GetInventory</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetInventoryRequestObject()
        {
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            GetInventoryRequest request = new GetInventoryRequest
            {
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = InventoryView.Unspecified,
            };
            // Make the request
            Inventory response = osConfigZonalServiceClient.GetInventory(request);
        }
    }
    // [END osconfig_v1alpha_generated_OsConfigZonalService_GetInventory_sync]
}
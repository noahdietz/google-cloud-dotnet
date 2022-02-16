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

namespace Google.Cloud.Retail.V2.Snippets
{
    // [START retail_v2_generated_ProductService_ImportProducts_async]
    using Google.Cloud.Retail.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedProductServiceClientSnippets
    {
        /// <summary>Snippet for ImportProductsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ImportProductsRequestObjectAsync()
        {
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportProductsRequest request = new ImportProductsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                InputConfig = new ProductInputConfig(),
                ErrorsConfig = new ImportErrorsConfig(),
                UpdateMask = new FieldMask(),
                ReconciliationMode = ImportProductsRequest.Types.ReconciliationMode.Unspecified,
                RequestId = "",
                NotificationPubsubTopic = "",
            };
            // Make the request
            Operation<ImportProductsResponse, ImportMetadata> response = await productServiceClient.ImportProductsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportProductsResponse, ImportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportProductsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportProductsResponse, ImportMetadata> retrievedResponse = await productServiceClient.PollOnceImportProductsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportProductsResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END retail_v2_generated_ProductService_ImportProducts_async]
}
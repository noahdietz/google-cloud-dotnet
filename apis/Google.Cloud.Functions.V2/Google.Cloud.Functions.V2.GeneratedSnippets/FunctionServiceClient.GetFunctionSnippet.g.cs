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

namespace Google.Cloud.Functions.V2.Snippets
{
    // [START cloudfunctions_v2_generated_FunctionService_GetFunction_sync_flattened]
    using Google.Cloud.Functions.V2;

    public sealed partial class GeneratedFunctionServiceClientSnippets
    {
        /// <summary>Snippet for GetFunction</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetFunction()
        {
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/functions/[FUNCTION]";
            // Make the request
            Function response = functionServiceClient.GetFunction(name);
        }
    }
    // [END cloudfunctions_v2_generated_FunctionService_GetFunction_sync_flattened]
}

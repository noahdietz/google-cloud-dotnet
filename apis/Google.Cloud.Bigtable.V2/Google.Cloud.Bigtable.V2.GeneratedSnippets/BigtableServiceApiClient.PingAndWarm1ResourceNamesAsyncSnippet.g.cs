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

namespace Google.Cloud.Bigtable.V2.Snippets
{
    // [START bigtable_v2_generated_BigtableServiceApi_PingAndWarm_async_flattened1_resourceNames]
    using Google.Cloud.Bigtable.V2;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBigtableServiceApiClientSnippets
    {
        /// <summary>Snippet for PingAndWarmAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task PingAndWarm1ResourceNamesAsync()
        {
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PingAndWarmResponse response = await bigtableServiceApiClient.PingAndWarmAsync(name);
        }
    }
    // [END bigtable_v2_generated_BigtableServiceApi_PingAndWarm_async_flattened1_resourceNames]
}
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

namespace Google.Cloud.PhishingProtection.V1Beta1.Snippets
{
    // [START phishingprotection_v1beta1_generated_PhishingProtectionServiceV1Beta1_ReportPhishing_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.PhishingProtection.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedPhishingProtectionServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for ReportPhishingAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ReportPhishingRequestObjectAsync()
        {
            // Create client
            PhishingProtectionServiceV1Beta1Client phishingProtectionServiceV1Beta1Client = await PhishingProtectionServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ReportPhishingRequest request = new ReportPhishingRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Uri = "",
            };
            // Make the request
            ReportPhishingResponse response = await phishingProtectionServiceV1Beta1Client.ReportPhishingAsync(request);
        }
    }
    // [END phishingprotection_v1beta1_generated_PhishingProtectionServiceV1Beta1_ReportPhishing_async]
}

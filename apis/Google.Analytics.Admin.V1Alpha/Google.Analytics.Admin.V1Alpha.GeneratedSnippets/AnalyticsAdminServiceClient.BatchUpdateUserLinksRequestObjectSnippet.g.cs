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

namespace Google.Analytics.Admin.V1Alpha.Snippets
{
    // [START analyticsadmin_v1alpha_generated_AnalyticsAdminService_BatchUpdateUserLinks_sync]
    using Google.Analytics.Admin.V1Alpha;

    public sealed partial class GeneratedAnalyticsAdminServiceClientSnippets
    {
        /// <summary>Snippet for BatchUpdateUserLinks</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void BatchUpdateUserLinksRequestObject()
        {
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateUserLinksRequest request = new BatchUpdateUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new UpdateUserLinkRequest(),
                },
            };
            // Make the request
            BatchUpdateUserLinksResponse response = analyticsAdminServiceClient.BatchUpdateUserLinks(request);
        }
    }
    // [END analyticsadmin_v1alpha_generated_AnalyticsAdminService_BatchUpdateUserLinks_sync]
}

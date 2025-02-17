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

namespace Google.Cloud.GkeBackup.V1.Snippets
{
    // [START gkebackup_v1_generated_BackupForGKE_GetBackup_async]
    using Google.Cloud.GkeBackup.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBackupForGKEClientSnippets
    {
        /// <summary>Snippet for GetBackupAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetBackupRequestObjectAsync()
        {
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
            };
            // Make the request
            Backup response = await backupForGKEClient.GetBackupAsync(request);
        }
    }
    // [END gkebackup_v1_generated_BackupForGKE_GetBackup_async]
}

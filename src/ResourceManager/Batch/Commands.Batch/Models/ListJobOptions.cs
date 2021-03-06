﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Batch;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Batch.Models
{
    public class ListJobOptions
    {
        /// <summary>
        /// The account details
        /// </summary>
        public BatchAccountContext Context { get; set; }

        /// <summary>
        /// The name of the WorkItem to query for Jobs
        /// </summary>
        public string WorkItemName { get; set; }

        /// <summary>
        /// If specified, the single Job with this name will be returned
        /// </summary>
        public string JobName { get; set; }

        /// <summary>
        /// The WorkItem to query for Jobs
        /// </summary>
        public PSCloudWorkItem WorkItem { get; set; }

        /// <summary>
        /// The OData filter to use when querying for Jobs
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// The maximum number of Jobs to return
        /// </summary>
        public int MaxCount { get; set; }

        /// <summary>
        /// Additional client behaviors to perform
        /// </summary>
        public IEnumerable<BatchClientBehavior> AdditionalBehaviors { get; set; }
    }
}

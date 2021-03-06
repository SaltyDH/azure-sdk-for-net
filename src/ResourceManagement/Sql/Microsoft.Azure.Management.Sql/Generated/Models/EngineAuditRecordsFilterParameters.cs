// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// The OData query parameters that are supported when retrieving Engine
    /// Auditing records
    /// </summary>
    public partial class EngineAuditRecordsFilterParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EngineAuditRecordsFilterParameters class.
        /// </summary>
        public EngineAuditRecordsFilterParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// EngineAuditRecordsFilterParameters class.
        /// </summary>
        public EngineAuditRecordsFilterParameters(System.DateTime? eventTime = default(System.DateTime?), bool? showSystemLogs = default(bool?), bool? showServerRecords = default(bool?))
        {
            EventTime = eventTime;
            ShowSystemLogs = showSystemLogs;
            ShowServerRecords = showServerRecords;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "eventTime")]
        public System.DateTime? EventTime { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "showSystemLogs")]
        public bool? ShowSystemLogs { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "showServerRecords")]
        public bool? ShowServerRecords { get; set; }

    }
}

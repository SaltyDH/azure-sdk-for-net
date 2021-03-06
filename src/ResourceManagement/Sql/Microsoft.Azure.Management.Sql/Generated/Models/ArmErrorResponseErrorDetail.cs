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
    /// Details about a specific error
    /// </summary>
    public partial class ArmErrorResponseErrorDetail
    {
        /// <summary>
        /// Initializes a new instance of the ArmErrorResponseErrorDetail
        /// class.
        /// </summary>
        public ArmErrorResponseErrorDetail() { }

        /// <summary>
        /// Initializes a new instance of the ArmErrorResponseErrorDetail
        /// class.
        /// </summary>
        public ArmErrorResponseErrorDetail(string code = default(string), string message = default(string), string target = default(string))
        {
            Code = code;
            Message = message;
            Target = target;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "target")]
        public string Target { get; private set; }

    }
}

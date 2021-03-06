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
    /// Represents an Azure SQL Database secure connection policy.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class DatabaseSecureConnectionPolicy : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseSecureConnectionPolicy
        /// class.
        /// </summary>
        public DatabaseSecureConnectionPolicy() { }

        /// <summary>
        /// Initializes a new instance of the DatabaseSecureConnectionPolicy
        /// class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource Id</param>
        /// <param name="proxyDnsName">Gets the Data Security Proxy DNS
        /// name.</param>
        /// <param name="proxyPort">Gets the Data Security Proxy port
        /// number.</param>
        /// <param name="securityEnabledAccess">Gets whether block direct
        /// access is applied.</param>
        public DatabaseSecureConnectionPolicy(string name = default(string), string id = default(string), string proxyDnsName = default(string), string proxyPort = default(string), string securityEnabledAccess = default(string))
            : base(name, id)
        {
            ProxyDnsName = proxyDnsName;
            ProxyPort = proxyPort;
            SecurityEnabledAccess = securityEnabledAccess;
        }

        /// <summary>
        /// Gets the Data Security Proxy DNS name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.proxyDnsName")]
        public string ProxyDnsName { get; private set; }

        /// <summary>
        /// Gets the Data Security Proxy port number.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.proxyPort")]
        public string ProxyPort { get; private set; }

        /// <summary>
        /// Gets whether block direct access is applied.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.securityEnabledAccess")]
        public string SecurityEnabledAccess { get; set; }

    }
}

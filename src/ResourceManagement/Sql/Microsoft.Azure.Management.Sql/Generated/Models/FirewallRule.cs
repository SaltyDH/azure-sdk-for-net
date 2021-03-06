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
    /// Represents an Azure SQL Server Firewall Rule.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class FirewallRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the FirewallRule class.
        /// </summary>
        public FirewallRule() { }

        /// <summary>
        /// Initializes a new instance of the FirewallRule class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource Id</param>
        /// <param name="startIpAddress">Gets the start IP address of the
        /// Azure SQL Database Firewall Rule.</param>
        /// <param name="endIpAddress">Gets the end IP address of the Azure
        /// SQL Database Firewall Rule.</param>
        public FirewallRule(string name = default(string), string id = default(string), string startIpAddress = default(string), string endIpAddress = default(string))
            : base(name, id)
        {
            StartIpAddress = startIpAddress;
            EndIpAddress = endIpAddress;
        }

        /// <summary>
        /// Gets the start IP address of the Azure SQL Database Firewall Rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.startIpAddress")]
        public string StartIpAddress { get; set; }

        /// <summary>
        /// Gets the end IP address of the Azure SQL Database Firewall Rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.endIpAddress")]
        public string EndIpAddress { get; set; }

    }
}

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
    /// Start Azure SQL Server Upgrade parameters.
    /// </summary>
    public partial class ServerUpgradeStartParameters
    {
        /// <summary>
        /// Initializes a new instance of the ServerUpgradeStartParameters
        /// class.
        /// </summary>
        public ServerUpgradeStartParameters() { }

        /// <summary>
        /// Initializes a new instance of the ServerUpgradeStartParameters
        /// class.
        /// </summary>
        /// <param name="serverUpgradeProperties">Gets or sets the properties
        /// of the Azure SQL Server Upgrade.</param>
        public ServerUpgradeStartParameters(ServerUpgradeProperties serverUpgradeProperties)
        {
            ServerUpgradeProperties = serverUpgradeProperties;
        }

        /// <summary>
        /// Gets or sets the properties of the Azure SQL Server Upgrade.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serverUpgradeProperties")]
        public ServerUpgradeProperties ServerUpgradeProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ServerUpgradeProperties == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ServerUpgradeProperties");
            }
            if (this.ServerUpgradeProperties != null)
            {
                this.ServerUpgradeProperties.Validate();
            }
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// AuditingPolicyOperations operations.
    /// </summary>
    public partial interface IAuditingPolicyOperations
    {
        /// <summary>
        /// Creates or updates an Azure SQL Database auditing policy.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the resource belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database for which the auditing policy
        /// applies.
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for createing or updating a Azure SQL
        /// Database auditing policy.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<DatabaseAuditingPolicy>> CreateOrUpdateDatebasePolicyWithHttpMessagesAsync(string resourceGroupName, string serverName, string databaseName, DatabaseAuditingPolicy parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns an Azure SQL Database auditing policy.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the resource belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database for which the auditing policy
        /// applies.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<DatabaseAuditingPolicy>> GetDatabasePolicyWithHttpMessagesAsync(string resourceGroupName, string serverName, string databaseName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Creates or updates an Azure SQL Server auditing policy.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the resource belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for createing or updating a Azure SQL
        /// Server auditing policy.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ServerAuditingPolicy>> CreateOrUpdateServerPolicyWithHttpMessagesAsync(string resourceGroupName, string serverName, ServerAuditingPolicy parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns an Azure SQL Server auditing policy.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the resource belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ServerAuditingPolicy>> GetServerPolicyWithHttpMessagesAsync(string resourceGroupName, string serverName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}

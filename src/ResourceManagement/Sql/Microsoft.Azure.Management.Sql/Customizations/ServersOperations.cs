using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Sql.Models;
using Microsoft.Rest.Azure;

namespace Microsoft.Azure.Management.Sql
{
    internal partial class ServersOperations
    {
        public Task<AzureOperationResponse<ImportExportOperationStatusResponse>> GetImportStatusWithHttpMessagesAsync(string resourceGroupName, string serverName, Guid operationId,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }
    }
}
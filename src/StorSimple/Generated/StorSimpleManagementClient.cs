// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.StorSimple;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple
{
    /// <summary>
    /// This is an RESTFul API to manage you StorSimple Objects
    /// </summary>
    public partial class StorSimpleManagementClient : ServiceClient<StorSimpleManagementClient>, IStorSimpleManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private string _cisStampId;
        
        public string CisStampId
        {
            get { return this._cisStampId; }
            set { this._cisStampId = value; }
        }
        
        private string _cloudServiceName;
        
        public string CloudServiceName
        {
            get { return this._cloudServiceName; }
            set { this._cloudServiceName = value; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private string _resourceId;
        
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }
        
        private string _resourceName;
        
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }
        
        private string _resourceNamespace;
        
        public string ResourceNamespace
        {
            get { return this._resourceNamespace; }
            set { this._resourceNamespace = value; }
        }
        
        private IBackupOperations _backup;
        
        /// <summary>
        /// All Operations related to Backup
        /// </summary>
        public virtual IBackupOperations Backup
        {
            get { return this._backup; }
        }
        
        private IBackupPolicyOperations _backupPolicy;
        
        /// <summary>
        /// All Operations related to Backup policies
        /// </summary>
        public virtual IBackupPolicyOperations BackupPolicy
        {
            get { return this._backupPolicy; }
        }
        
        private IDataContainerOperations _dataContainer;
        
        /// <summary>
        /// All Operations related to Volume Containers
        /// </summary>
        public virtual IDataContainerOperations DataContainer
        {
            get { return this._dataContainer; }
        }
        
        private IDeviceDetailsOperations _deviceDetails;
        
        /// <summary>
        /// All Operations related to Device Details
        /// </summary>
        public virtual IDeviceDetailsOperations DeviceDetails
        {
            get { return this._deviceDetails; }
        }
        
        private IDeviceOperations _devices;
        
        /// <summary>
        /// All Operations related to Devices
        /// </summary>
        public virtual IDeviceOperations Devices
        {
            get { return this._devices; }
        }
        
        private IIscsiConnectionDetailsOperations _iscsiConnection;
        
        /// <summary>
        /// All Operations related to iscsi connection
        /// </summary>
        public virtual IIscsiConnectionDetailsOperations IscsiConnection
        {
            get { return this._iscsiConnection; }
        }
        
        private IResourceEncryptionKeyOperations _resourceEncryptionKeys;
        
        /// <summary>
        /// All Operations related to Crypto keys
        /// </summary>
        public virtual IResourceEncryptionKeyOperations ResourceEncryptionKeys
        {
            get { return this._resourceEncryptionKeys; }
        }
        
        private IServiceConfigurationOperations _serviceConfig;
        
        /// <summary>
        /// All Operations related to Service configurations
        /// </summary>
        public virtual IServiceConfigurationOperations ServiceConfig
        {
            get { return this._serviceConfig; }
        }
        
        private IVirtualDiskOperations _virtualDisk;
        
        /// <summary>
        /// All Operations related to virtual disk
        /// </summary>
        public virtual IVirtualDiskOperations VirtualDisk
        {
            get { return this._virtualDisk; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StorSimpleManagementClient class.
        /// </summary>
        public StorSimpleManagementClient()
            : base()
        {
            this._backup = new BackupOperations(this);
            this._backupPolicy = new BackupPolicyOperations(this);
            this._dataContainer = new DataContainerOperations(this);
            this._deviceDetails = new DeviceDetailsOperations(this);
            this._devices = new DeviceOperations(this);
            this._iscsiConnection = new IscsiConnectionDetailsOperations(this);
            this._resourceEncryptionKeys = new ResourceEncryptionKeyOperations(this);
            this._serviceConfig = new ServiceConfigurationOperations(this);
            this._virtualDisk = new VirtualDiskOperations(this);
            this._apiVersion = "2014-01-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the StorSimpleManagementClient class.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='resourceId'>
        /// Required.
        /// </param>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='cisStampId'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public StorSimpleManagementClient(string cloudServiceName, string resourceName, string resourceId, string resourceNamespace, string cisStampId, SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException("cloudServiceName");
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException("resourceId");
            }
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (cisStampId == null)
            {
                throw new ArgumentNullException("cisStampId");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._cloudServiceName = cloudServiceName;
            this._resourceName = resourceName;
            this._resourceId = resourceId;
            this._resourceNamespace = resourceNamespace;
            this._cisStampId = cisStampId;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the StorSimpleManagementClient class.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='resourceId'>
        /// Required.
        /// </param>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='cisStampId'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public StorSimpleManagementClient(string cloudServiceName, string resourceName, string resourceId, string resourceNamespace, string cisStampId, SubscriptionCloudCredentials credentials)
            : this()
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException("cloudServiceName");
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException("resourceId");
            }
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (cisStampId == null)
            {
                throw new ArgumentNullException("cisStampId");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._cloudServiceName = cloudServiceName;
            this._resourceName = resourceName;
            this._resourceId = resourceId;
            this._resourceNamespace = resourceNamespace;
            this._cisStampId = cisStampId;
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the StorSimpleManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public StorSimpleManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._backup = new BackupOperations(this);
            this._backupPolicy = new BackupPolicyOperations(this);
            this._dataContainer = new DataContainerOperations(this);
            this._deviceDetails = new DeviceDetailsOperations(this);
            this._devices = new DeviceOperations(this);
            this._iscsiConnection = new IscsiConnectionDetailsOperations(this);
            this._resourceEncryptionKeys = new ResourceEncryptionKeyOperations(this);
            this._serviceConfig = new ServiceConfigurationOperations(this);
            this._virtualDisk = new VirtualDiskOperations(this);
            this._apiVersion = "2014-01-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the StorSimpleManagementClient class.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='resourceId'>
        /// Required.
        /// </param>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='cisStampId'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public StorSimpleManagementClient(string cloudServiceName, string resourceName, string resourceId, string resourceNamespace, string cisStampId, SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException("cloudServiceName");
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException("resourceId");
            }
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (cisStampId == null)
            {
                throw new ArgumentNullException("cisStampId");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._cloudServiceName = cloudServiceName;
            this._resourceName = resourceName;
            this._resourceId = resourceId;
            this._resourceNamespace = resourceNamespace;
            this._cisStampId = cisStampId;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the StorSimpleManagementClient class.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='resourceId'>
        /// Required.
        /// </param>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='cisStampId'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public StorSimpleManagementClient(string cloudServiceName, string resourceName, string resourceId, string resourceNamespace, string cisStampId, SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException("cloudServiceName");
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException("resourceId");
            }
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (cisStampId == null)
            {
                throw new ArgumentNullException("cisStampId");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._cloudServiceName = cloudServiceName;
            this._resourceName = resourceName;
            this._resourceId = resourceId;
            this._resourceNamespace = resourceNamespace;
            this._cisStampId = cisStampId;
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// StorSimpleManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of StorSimpleManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<StorSimpleManagementClient> client)
        {
            base.Clone(client);
            
            if (client is StorSimpleManagementClient)
            {
                StorSimpleManagementClient clonedClient = ((StorSimpleManagementClient)client);
                
                clonedClient._cloudServiceName = this._cloudServiceName;
                clonedClient._resourceName = this._resourceName;
                clonedClient._resourceId = this._resourceId;
                clonedClient._resourceNamespace = this._resourceNamespace;
                clonedClient._cisStampId = this._cisStampId;
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
        
        /// <summary>
        /// The Get Task Status returns the status of the specified task id.
        /// After calling an asynchronous task, you can call Get Task Status
        /// to determine whether the task has succeeded, failed, or is still
        /// in progress.
        /// </summary>
        /// <param name='taskId'>
        /// Required. The task Id for the request you wish to track.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public async Task<TaskStatusInfo> GetOperationStatusAsync(string taskId, CancellationToken cancellationToken)
        {
            // Validate
            if (taskId == null)
            {
                throw new ArgumentNullException("taskId");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("taskId", taskId);
                TracingAdapter.Enter(invocationId, this, "GetOperationStatusAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/" + (this.Credentials.SubscriptionId == null ? "" : Uri.EscapeDataString(this.Credentials.SubscriptionId)) + "/cloudservices/" + Uri.EscapeDataString(this.CloudServiceName) + "/resources/" + Uri.EscapeDataString(this.ResourceNamespace) + "/~/CiSVault/" + Uri.EscapeDataString(this.ResourceName) + "/api/jobs/" + Uri.EscapeDataString(taskId) + "?";
            url = url + "api-version=2014-01-01.1.0";
            string baseUrl = this.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/xml");
                httpRequest.Headers.Add("x-ms-version", "2014-01-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    TaskStatusInfo result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new TaskStatusInfo();
                        XDocument responseDoc = XDocument.Parse(responseContent);
                        
                        XElement jobStatusInfoElement = responseDoc.Element(XName.Get("JobStatusInfo", "http://windowscloudbackup.com/CiS/V2013_03"));
                        if (jobStatusInfoElement != null)
                        {
                            XElement jobIdElement = jobStatusInfoElement.Element(XName.Get("JobId", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (jobIdElement != null)
                            {
                                string jobIdInstance = jobIdElement.Value;
                                result.TaskId = jobIdInstance;
                            }
                            
                            XElement statusElement = jobStatusInfoElement.Element(XName.Get("Status", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (statusElement != null)
                            {
                                AsyncTaskStatus statusInstance = ((AsyncTaskStatus)Enum.Parse(typeof(AsyncTaskStatus), statusElement.Value, true));
                                result.Status = statusInstance;
                            }
                            
                            XElement resultElement = jobStatusInfoElement.Element(XName.Get("Result", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (resultElement != null)
                            {
                                AsyncTaskResult resultInstance = ((AsyncTaskResult)Enum.Parse(typeof(AsyncTaskResult), resultElement.Value, true));
                                result.Result = resultInstance;
                            }
                            
                            XElement errorElement = jobStatusInfoElement.Element(XName.Get("Error", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (errorElement != null)
                            {
                                ErrorDetails errorInstance = new ErrorDetails();
                                result.Error = errorInstance;
                                
                                XElement codeElement = errorElement.Element(XName.Get("Code", "http://schemas.microsoft.com/wars"));
                                if (codeElement != null)
                                {
                                    string codeInstance = codeElement.Value;
                                    errorInstance.Code = codeInstance;
                                }
                                
                                XElement messageElement = errorElement.Element(XName.Get("Message", "http://schemas.microsoft.com/wars"));
                                if (messageElement != null)
                                {
                                    string messageInstance = messageElement.Value;
                                    errorInstance.Message = messageInstance;
                                }
                            }
                            
                            XElement taskResultElement = jobStatusInfoElement.Element(XName.Get("TaskResult", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (taskResultElement != null)
                            {
                                AsyncTaskAggregatedResult taskResultInstance = ((AsyncTaskAggregatedResult)Enum.Parse(typeof(AsyncTaskAggregatedResult), taskResultElement.Value, true));
                                result.AsyncTaskAggregatedResult = taskResultInstance;
                            }
                            
                            XElement jobStepsSequenceElement = jobStatusInfoElement.Element(XName.Get("JobSteps", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (jobStepsSequenceElement != null)
                            {
                                foreach (XElement jobStepsElement in jobStepsSequenceElement.Elements(XName.Get("JobStep", "http://windowscloudbackup.com/CiS/V2013_03")))
                                {
                                    TaskStep jobStepInstance = new TaskStep();
                                    result.TaskSteps.Add(jobStepInstance);
                                    
                                    XElement messageElement2 = jobStepsElement.Element(XName.Get("Message", "http://windowscloudbackup.com/CiS/V2013_03"));
                                    if (messageElement2 != null)
                                    {
                                        string messageInstance2 = messageElement2.Value;
                                        jobStepInstance.Message = messageInstance2;
                                    }
                                    
                                    XElement statusElement2 = jobStepsElement.Element(XName.Get("Status", "http://windowscloudbackup.com/CiS/V2013_03"));
                                    if (statusElement2 != null)
                                    {
                                        AsyncTaskStatus statusInstance2 = ((AsyncTaskStatus)Enum.Parse(typeof(AsyncTaskStatus), statusElement2.Value, true));
                                        jobStepInstance.Status = statusInstance2;
                                    }
                                    
                                    XElement resultElement2 = jobStepsElement.Element(XName.Get("Result", "http://windowscloudbackup.com/CiS/V2013_03"));
                                    if (resultElement2 != null)
                                    {
                                        AsyncTaskResult resultInstance2 = ((AsyncTaskResult)Enum.Parse(typeof(AsyncTaskResult), resultElement2.Value, true));
                                        jobStepInstance.Result = resultInstance2;
                                    }
                                    
                                    XElement detailElement = jobStepsElement.Element(XName.Get("Detail", "http://windowscloudbackup.com/CiS/V2013_03"));
                                    if (detailElement != null)
                                    {
                                        string detailInstance = detailElement.Value;
                                        jobStepInstance.Detail = detailInstance;
                                    }
                                    
                                    XElement errorCodeElement = jobStepsElement.Element(XName.Get("ErrorCode", "http://windowscloudbackup.com/CiS/V2013_03"));
                                    if (errorCodeElement != null)
                                    {
                                        string errorCodeInstance = errorCodeElement.Value;
                                        jobStepInstance.ErrorCode = errorCodeInstance;
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
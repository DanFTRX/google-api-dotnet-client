// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Genomics.v1alpha2
{
    /// <summary>The Genomics Service.</summary>
    public class GenomicsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GenomicsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GenomicsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Operations = new OperationsResource(this);
            Pipelines = new PipelinesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "genomics";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://genomics.googleapis.com/";
        #else
            "https://genomics.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://genomics.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Genomics API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your Google Compute Engine resources</summary>
            public static string Compute = "https://www.googleapis.com/auth/compute";

            /// <summary>View and manage Genomics data</summary>
            public static string Genomics = "https://www.googleapis.com/auth/genomics";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Genomics API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your Google Compute Engine resources</summary>
            public const string Compute = "https://www.googleapis.com/auth/compute";

            /// <summary>View and manage Genomics data</summary>
            public const string Genomics = "https://www.googleapis.com/auth/genomics";

        }



        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Pipelines resource.</summary>
        public virtual PipelinesResource Pipelines { get; }
    }

    /// <summary>A base abstract class for Genomics requests.</summary>
    public abstract class GenomicsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GenomicsBaseServiceRequest instance.</summary>
        protected GenomicsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes Genomics parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "operations" collection of methods.</summary>
    public class OperationsResource
    {
        private const string Resource = "operations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OperationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
        /// cancel the operation, but success is not guaranteed. Clients may use Operations.GetOperation or
        /// Operations.ListOperations to check whether the cancellation succeeded or the operation completed despite
        /// cancellation. Authorization requires the following [Google IAM](https://cloud.google.com/iam) permission: *
        /// `genomics.operations.cancel`</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        public virtual CancelRequest Cancel(Google.Apis.Genomics.v1alpha2.Data.CancelOperationRequest body, string name)
        {
            return new CancelRequest(service, body, name);
        }

        /// <summary>Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
        /// cancel the operation, but success is not guaranteed. Clients may use Operations.GetOperation or
        /// Operations.ListOperations to check whether the cancellation succeeded or the operation completed despite
        /// cancellation. Authorization requires the following [Google IAM](https://cloud.google.com/iam) permission: *
        /// `genomics.operations.cancel`</summary>
        public class CancelRequest : GenomicsBaseServiceRequest<Google.Apis.Genomics.v1alpha2.Data.Empty>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Genomics.v1alpha2.Data.CancelOperationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }


            /// <summary>The name of the operation resource to be cancelled.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Genomics.v1alpha2.Data.CancelOperationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancel";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha2/{+name}:cancel";

            /// <summary>Initializes Cancel parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^operations/.*$",
                });
            }

        }

        /// <summary>Gets the latest state of a long-running operation. Clients can use this method to poll the
        /// operation result at intervals as recommended by the API service. Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission: * `genomics.operations.get`</summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets the latest state of a long-running operation. Clients can use this method to poll the
        /// operation result at intervals as recommended by the API service. Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission: * `genomics.operations.get`</summary>
        public class GetRequest : GenomicsBaseServiceRequest<Google.Apis.Genomics.v1alpha2.Data.Operation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>The name of the operation resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha2/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^operations/.*$",
                });
            }

        }

        /// <summary>Lists operations that match the specified filter in the request. Authorization requires the
        /// following [Google IAM](https://cloud.google.com/iam) permission: * `genomics.operations.list`</summary>
        /// <param name="name">The name of the operation's parent resource.</param>
        public virtual ListRequest List(string name)
        {
            return new ListRequest(service, name);
        }

        /// <summary>Lists operations that match the specified filter in the request. Authorization requires the
        /// following [Google IAM](https://cloud.google.com/iam) permission: * `genomics.operations.list`</summary>
        public class ListRequest : GenomicsBaseServiceRequest<Google.Apis.Genomics.v1alpha2.Data.ListOperationsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>The name of the operation's parent resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>A string for filtering Operations. In v2alpha1, the following filter fields are supported: *
            /// createTime: The time this job was created * events: The set of event (names) that have occurred while
            /// running the pipeline. The : operator can be used to determine if a particular event has occurred. *
            /// error: If the pipeline is running, this value is NULL. Once the pipeline finishes, the value is the
            /// standard Google error code. * labels.key or labels."key with space" where key is a label key. * done: If
            /// the pipeline is running, this value is false. Once the pipeline finishes, the value is true. In v1 and
            /// v1alpha2, the following filter fields are supported: * projectId: Required. Corresponds to
            /// OperationMetadata.projectId. * createTime: The time this job was created, in seconds from the
            /// [epoch](http://en.wikipedia.org/wiki/Unix_time). Can use `>=` and/or `<=` operators. * status: Can be
            /// `RUNNING`, `SUCCESS`, `FAILURE`, or `CANCELED`. Only one status may be specified. * labels.key where key
            /// is a label key. Examples: * `projectId = my-project AND createTime >= 1432140000` * `projectId = my-
            /// project AND createTime >= 1432140000 AND createTime <= 1432150000 AND status = RUNNING` * `projectId =
            /// my-project AND labels.color = *` * `projectId = my-project AND labels.color = red`</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results to return. The maximum value is 256.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The standard list page token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha2/{+name}";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^operations$",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "pipelines" collection of methods.</summary>
    public class PipelinesResource
    {
        private const string Resource = "pipelines";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PipelinesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Creates a pipeline that can be run later. Create takes a Pipeline that has all fields other than
        /// `pipelineId` populated, and then returns the same pipeline with `pipelineId` populated. This id can be used
        /// to run the pipeline. Caller must have WRITE permission to the project.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Genomics.v1alpha2.Data.Pipeline body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a pipeline that can be run later. Create takes a Pipeline that has all fields other than
        /// `pipelineId` populated, and then returns the same pipeline with `pipelineId` populated. This id can be used
        /// to run the pipeline. Caller must have WRITE permission to the project.</summary>
        public class CreateRequest : GenomicsBaseServiceRequest<Google.Apis.Genomics.v1alpha2.Data.Pipeline>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Genomics.v1alpha2.Data.Pipeline body) : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Genomics.v1alpha2.Data.Pipeline Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha2/pipelines";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Deletes a pipeline based on ID. Caller must have WRITE permission to the project.</summary>
        /// <param name="pipelineId">Caller must have WRITE access to the project in which this pipeline is
        /// defined.</param>
        public virtual DeleteRequest Delete(string pipelineId)
        {
            return new DeleteRequest(service, pipelineId);
        }

        /// <summary>Deletes a pipeline based on ID. Caller must have WRITE permission to the project.</summary>
        public class DeleteRequest : GenomicsBaseServiceRequest<Google.Apis.Genomics.v1alpha2.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string pipelineId) : base(service)
            {
                PipelineId = pipelineId;
                InitParameters();
            }


            /// <summary>Caller must have WRITE access to the project in which this pipeline is defined.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pipelineId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PipelineId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha2/pipelines/{pipelineId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("pipelineId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pipelineId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Retrieves a pipeline based on ID. Caller must have READ permission to the project.</summary>
        /// <param name="pipelineId">Caller must have READ access to the project in which this pipeline is defined.</param>
        public virtual GetRequest Get(string pipelineId)
        {
            return new GetRequest(service, pipelineId);
        }

        /// <summary>Retrieves a pipeline based on ID. Caller must have READ permission to the project.</summary>
        public class GetRequest : GenomicsBaseServiceRequest<Google.Apis.Genomics.v1alpha2.Data.Pipeline>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string pipelineId) : base(service)
            {
                PipelineId = pipelineId;
                InitParameters();
            }


            /// <summary>Caller must have READ access to the project in which this pipeline is defined.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pipelineId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PipelineId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha2/pipelines/{pipelineId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("pipelineId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pipelineId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Gets controller configuration information. Should only be called by VMs created by the Pipelines
        /// Service and not by end users.</summary>
        public virtual GetControllerConfigRequest GetControllerConfig()
        {
            return new GetControllerConfigRequest(service);
        }

        /// <summary>Gets controller configuration information. Should only be called by VMs created by the Pipelines
        /// Service and not by end users.</summary>
        public class GetControllerConfigRequest : GenomicsBaseServiceRequest<Google.Apis.Genomics.v1alpha2.Data.ControllerConfig>
        {
            /// <summary>Constructs a new GetControllerConfig request.</summary>
            public GetControllerConfigRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>The operation to retrieve controller configuration for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("operationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OperationId { get; set; }


            [Google.Apis.Util.RequestParameterAttribute("validationToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ulong> ValidationToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getControllerConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha2/pipelines:getControllerConfig";

            /// <summary>Initializes GetControllerConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("operationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "operationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("validationToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "validationToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists pipelines. Caller must have READ permission to the project.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists pipelines. Caller must have READ permission to the project.</summary>
        public class ListRequest : GenomicsBaseServiceRequest<Google.Apis.Genomics.v1alpha2.Data.ListPipelinesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>Pipelines with names that match this prefix should be returned. If unspecified, all pipelines
            /// in the project, up to `pageSize`, will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("namePrefix", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string NamePrefix { get; set; }

            /// <summary>Number of pipelines to return at once. Defaults to 256, and max is 2048.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Token to use to indicate where to start getting results. If unspecified, returns the first page
            /// of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Required. The name of the project to search for pipelines. Caller must have READ access to this
            /// project.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ProjectId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha2/pipelines";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("namePrefix", new Google.Apis.Discovery.Parameter
                {
                    Name = "namePrefix",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Runs a pipeline. If `pipelineId` is specified in the request, then run a saved pipeline. If
        /// `ephemeralPipeline` is specified, then run that pipeline once without saving a copy. The caller must have
        /// READ permission to the project where the pipeline is stored and WRITE permission to the project where the
        /// pipeline will be run, as VMs will be created and storage will be used. If a pipeline operation is still
        /// running after 6 days, it will be canceled.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual RunRequest Run(Google.Apis.Genomics.v1alpha2.Data.RunPipelineRequest body)
        {
            return new RunRequest(service, body);
        }

        /// <summary>Runs a pipeline. If `pipelineId` is specified in the request, then run a saved pipeline. If
        /// `ephemeralPipeline` is specified, then run that pipeline once without saving a copy. The caller must have
        /// READ permission to the project where the pipeline is stored and WRITE permission to the project where the
        /// pipeline will be run, as VMs will be created and storage will be used. If a pipeline operation is still
        /// running after 6 days, it will be canceled.</summary>
        public class RunRequest : GenomicsBaseServiceRequest<Google.Apis.Genomics.v1alpha2.Data.Operation>
        {
            /// <summary>Constructs a new Run request.</summary>
            public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.Genomics.v1alpha2.Data.RunPipelineRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Genomics.v1alpha2.Data.RunPipelineRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "run";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha2/pipelines:run";

            /// <summary>Initializes Run parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Sets status of a given operation. Any new timestamps (as determined by description) are appended to
        /// TimestampEvents. Should only be called by VMs created by the Pipelines Service and not by end
        /// users.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual SetOperationStatusRequest SetOperationStatus(Google.Apis.Genomics.v1alpha2.Data.SetOperationStatusRequest body)
        {
            return new SetOperationStatusRequest(service, body);
        }

        /// <summary>Sets status of a given operation. Any new timestamps (as determined by description) are appended to
        /// TimestampEvents. Should only be called by VMs created by the Pipelines Service and not by end
        /// users.</summary>
        public class SetOperationStatusRequest : GenomicsBaseServiceRequest<Google.Apis.Genomics.v1alpha2.Data.Empty>
        {
            /// <summary>Constructs a new SetOperationStatus request.</summary>
            public SetOperationStatusRequest(Google.Apis.Services.IClientService service, Google.Apis.Genomics.v1alpha2.Data.SetOperationStatusRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Genomics.v1alpha2.Data.SetOperationStatusRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setOperationStatus";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha2/pipelines:setOperationStatus";

            /// <summary>Initializes SetOperationStatus parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }
}

namespace Google.Apis.Genomics.v1alpha2.Data
{    

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Describes a Compute Engine resource that is being managed by a running pipeline.</summary>
    public class ComputeEngine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The names of the disks that were created for this pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskNames")]
        public virtual System.Collections.Generic.IList<string> DiskNames { get; set; } 

        /// <summary>The instance on which the operation is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceName")]
        public virtual string InstanceName { get; set; } 

        /// <summary>The machine type of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; } 

        /// <summary>The availability zone in which the instance resides.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event generated when a container is forcibly terminated by the worker. Currently, this only occurs
    /// when the container outlives the timeout specified by the user.</summary>
    public class ContainerKilledEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event generated when a container starts.</summary>
    public class ContainerStartedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started this container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; } 

        /// <summary>The public IP address that can be used to connect to the container. This field is only populated
        /// when at least one port mapping is present. If the instance was created with a private address, this field
        /// will be empty even if port mappings exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; } 

        /// <summary>The container-to-host port mappings installed for this container. This set will contain any ports
        /// exposed using the `PUBLISH_EXPOSED_PORTS` flag as well as any specified in the `Action`
        /// definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portMappings")]
        public virtual System.Collections.Generic.IDictionary<string,System.Nullable<int>> PortMappings { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event generated when a container exits.</summary>
    public class ContainerStoppedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started this container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; } 

        /// <summary>The exit status of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitStatus")]
        public virtual System.Nullable<int> ExitStatus { get; set; } 

        /// <summary>The tail end of any content written to standard error by the container. If the content emits large
        /// amounts of debugging noise or contains sensitive information, you can prevent the content from being printed
        /// by setting the `DISABLE_STANDARD_ERROR_CAPTURE` flag. Note that only a small amount of the end of the stream
        /// is captured here. The entire stream is stored in the `/google/logs` directory mounted into each action, and
        /// can be copied off the machine as described elsewhere.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stderr")]
        public virtual string Stderr { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Stores the information that the controller will fetch from the server in order to run. Should only be
    /// used by VMs created by the Pipelines Service and not by end users.</summary>
    public class ControllerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cmd")]
        public virtual string Cmd { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual System.Collections.Generic.IDictionary<string,string> Disks { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("gcsLogPath")]
        public virtual string GcsLogPath { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("gcsSinks")]
        public virtual System.Collections.Generic.IDictionary<string,RepeatedString> GcsSinks { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("gcsSources")]
        public virtual System.Collections.Generic.IDictionary<string,RepeatedString> GcsSources { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("vars")]
        public virtual System.Collections.Generic.IDictionary<string,string> Vars { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event generated whenever a resource limitation or transient error delays execution of a pipeline
    /// that was otherwise ready to run.</summary>
    public class DelayedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A textual description of the cause of the delay. The string can change without notice because it is
        /// often generated by another service (such as Compute Engine).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; } 

        /// <summary>If the delay was caused by a resource shortage, this field lists the Compute Engine metrics that
        /// are preventing this operation from running (for example, `CPUS` or `INSTANCES`). If the particular metric is
        /// not known, a single `UNKNOWN` metric will be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A Google Compute Engine disk resource specification.</summary>
    public class Disk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated. Disks created by the Pipelines API will be deleted at the end of the pipeline run,
        /// regardless of what this field is set to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoDelete")]
        public virtual System.Nullable<bool> AutoDelete { get; set; } 

        /// <summary>Required at create time and cannot be overridden at run time. Specifies the path in the docker
        /// container where files on this disk should be located. For example, if `mountPoint` is `/mnt/disk`, and the
        /// parameter has `localPath` `inputs/file.txt`, the docker container can access the data at
        /// `/mnt/disk/inputs/file.txt`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPoint")]
        public virtual string MountPoint { get; set; } 

        /// <summary>Required. The name of the disk that can be used in the pipeline parameters. Must be 1 - 63
        /// characters. The name "boot" is reserved for system use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Specifies how a sourced-base persistent disk will be mounted. See
        /// https://cloud.google.com/compute/docs/disks/persistent-disks#use_multi_instances for more details. Can only
        /// be set at create time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; } 

        /// <summary>The size of the disk. Defaults to 500 (GB). This field is not applicable for local SSD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; } 

        /// <summary>The full or partial URL of the persistent disk to attach. See
        /// https://cloud.google.com/compute/docs/reference/latest/instances#resource and
        /// https://cloud.google.com/compute/docs/disks/persistent-disks#snapshots for more details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; } 

        /// <summary>Required. The type of the disk to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The Docker execuctor specification.</summary>
    public class DockerExecutor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The command or newline delimited script to run. The command string will be executed
        /// within a bash shell. If the command exits with a non-zero exit code, output parameter de-localization will
        /// be skipped and the pipeline operation's `error` field will be populated. Maximum command string length is
        /// 16384.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmd")]
        public virtual string Cmd { get; set; } 

        /// <summary>Required. Image name from either Docker Hub or Google Container Registry. Users that run pipelines
        /// must have READ access to the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageName")]
        public virtual string ImageName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance: service Foo {
    /// rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty
    /// JSON object `{}`.</summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Carries information about events that occur during pipeline execution.</summary>
    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A human-readable description of the event. Note that these strings can change at any time without
        /// notice. Any application logic must use the information in the `details` field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Machine-readable details about the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string,object> Details { get; set; } 

        /// <summary>The time at which the event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event generated when the execution of a pipeline has failed. Note that other events can continue to
    /// occur after this event.</summary>
    public class FailedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable description of the cause of the failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; } 

        /// <summary>The Google standard error code that best describes this failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class ListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response of ListPipelines. Contains at most `pageSize` pipelines. If it contains `pageSize`
    /// pipelines, and more pipelines exist, then `nextPageToken` will be populated and should be used as the
    /// `pageToken` argument to a subsequent ListPipelines request.</summary>
    public class ListPipelinesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The token to use to get the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The matched pipelines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelines")]
        public virtual System.Collections.Generic.IList<Pipeline> Pipelines { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>LocalCopy defines how a remote file should be copied to and from the VM.</summary>
    public class LocalCopy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the disk where this parameter is located. Can be the name of one of the disks
        /// specified in the Resources field, or "boot", which represents the Docker instance's boot disk and has a
        /// mount point of `/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disk")]
        public virtual string Disk { get; set; } 

        /// <summary>Required. The path within the user's docker container where this input should be localized to and
        /// from, relative to the specified disk's mount point. For example: file.txt,</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The logging options for the pipeline run.</summary>
    public class LoggingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The location in Google Cloud Storage to which the pipeline logs will be copied. Can be specified as
        /// a fully qualified directory path, in which case logs will be output with a unique identifier as the filename
        /// in that directory, or as a fully specified path, which must end in `.log`, in which case that path will be
        /// used, and the user must ensure that logs are not overwritten. Stdout and stderr logs from the run are also
        /// generated and output as `-stdout.log` and `-stderr.log`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPath")]
        public virtual string GcsPath { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the value is `false`, it means the operation is still in progress. If `true`, the operation is
        /// completed, and either `error` or `response` is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; } 

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; } 

        /// <summary>An OperationMetadata or Metadata object. This will always be returned with the Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string,object> Metadata { get; set; } 

        /// <summary>The server-assigned name, which is only unique within the same service that originally returns it.
        /// For example: `operations/CJHU7Oi_ChDrveSpBRjfuL-qzoWAgEw`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>An Empty object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string,object> Response { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event that occurred during an Operation.</summary>
    public class OperationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required description of event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Optional time of when event finished. An event can have a start time and no finish time. If an
        /// event has a finish time, there must be a start time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; } 

        /// <summary>Optional time of when event started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata describing an Operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This field is deprecated. Use `labels` instead. Optionally provided by the caller when submitting
        /// the request that creates the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; } 

        /// <summary>The time at which the job was submitted to the Genomics service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>The time at which the job stopped running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; } 

        /// <summary>Optional event messages that were generated during the job's execution. This also contains any
        /// warnings that were generated during import or export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<OperationEvent> Events { get; set; } 

        /// <summary>Optionally provided by the caller when submitting the request that creates the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>The Google Cloud Project in which the job is scoped.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; } 

        /// <summary>The original request that started the operation. Note that this will be in current version of the
        /// API. If the operation was started with v1beta2 API and a GetOperation is performed on v1 API, a v1 request
        /// will be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual System.Collections.Generic.IDictionary<string,object> Request { get; set; } 

        /// <summary>Runtime metadata on this Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeMetadata")]
        public virtual System.Collections.Generic.IDictionary<string,object> RuntimeMetadata { get; set; } 

        /// <summary>The time at which the job began to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The pipeline object. Represents a transformation from a set of input parameters to a set of output
    /// parameters. The transformation is defined as a docker image and command to run within that image. Each pipeline
    /// is run on a Google Compute Engine VM. A pipeline can be created with the `create` method and then later run with
    /// the `run` method, or a pipeline can be defined and run all at once with the `run` method.</summary>
    public class Pipeline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User-specified description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Specifies the docker run information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("docker")]
        public virtual DockerExecutor Docker { get; set; } 

        /// <summary>Input parameters of the pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputParameters")]
        public virtual System.Collections.Generic.IList<PipelineParameter> InputParameters { get; set; } 

        /// <summary>Required. A user specified pipeline name that does not have to be unique. This name can be used for
        /// filtering Pipelines in ListPipelines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output parameters of the pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputParameters")]
        public virtual System.Collections.Generic.IList<PipelineParameter> OutputParameters { get; set; } 

        /// <summary>Unique pipeline id that is generated by the service when CreatePipeline is called. Cannot be
        /// specified in the Pipeline used in the CreatePipelineRequest, and will be populated in the response to
        /// CreatePipeline and all subsequent Get and List calls. Indicates that the service has registered this
        /// pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineId")]
        public virtual string PipelineId { get; set; } 

        /// <summary>Required. The project in which to create the pipeline. The caller must have WRITE access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; } 

        /// <summary>Required. Specifies resource requirements for the pipeline run. Required fields: * minimumCpuCores
        /// * minimumRamGb</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual PipelineResources Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Parameters facilitate setting and delivering data into the pipeline's execution environment. They are
    /// defined at create time, with optional defaults, and can be overridden at run time. If `localCopy` is unset, then
    /// the parameter specifies a string that is passed as-is into the pipeline, as the value of the environment
    /// variable with the given name. A default value can be optionally specified at create time. The default can be
    /// overridden at run time using the inputs map. If no default is given, a value must be supplied at runtime. If
    /// `localCopy` is defined, then the parameter specifies a data source or sink, both in Google Cloud Storage and on
    /// the Docker container where the pipeline computation is run. The service account associated with the Pipeline (by
    /// default the project's Compute Engine service account) must have access to the Google Cloud Storage paths. At run
    /// time, the Google Cloud Storage paths can be overridden if a default was provided at create time, or must be set
    /// otherwise. The pipeline runner should add a key/value pair to either the inputs or outputs map. The indicated
    /// data copies will be carried out before/after pipeline execution, just as if the corresponding arguments were
    /// provided to `gsutil cp`. For example: Given the following `PipelineParameter`, specified in the
    /// `inputParameters` list: ``` {name: "input_file", localCopy: {path: "file.txt", disk: "pd1"}} ``` where `disk` is
    /// defined in the `PipelineResources` object as: ``` {name: "pd1", mountPoint: "/mnt/disk/"} ``` We create a disk
    /// named `pd1`, mount it on the host VM, and map `/mnt/pd1` to `/mnt/disk` in the docker container. At runtime, an
    /// entry for `input_file` would be required in the inputs map, such as: ``` inputs["input_file"] = "gs://my-
    /// bucket/bar.txt" ``` This would generate the following gsutil call: ``` gsutil cp gs://my-bucket/bar.txt
    /// /mnt/pd1/file.txt ``` The file `/mnt/pd1/file.txt` maps to `/mnt/disk/file.txt` in the Docker container.
    /// Acceptable paths are: Google Cloud storage pathLocal path file file glob directory For outputs, the direction of
    /// the copy is reversed: ``` gsutil cp /mnt/disk/file.txt gs://my-bucket/bar.txt ``` Acceptable paths are: Local
    /// pathGoogle Cloud Storage path file file file directory - directory must already exist glob directory - directory
    /// will be created if it doesn't exist One restriction due to docker limitations, is that for outputs that are
    /// found on the boot disk, the local path cannot be a glob and must be a file.</summary>
    public class PipelineParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The default value for this parameter. Can be overridden at runtime. If `localCopy` is present, then
        /// this must be a Google Cloud Storage path beginning with `gs://`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual string DefaultValue { get; set; } 

        /// <summary>Human-readable description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>If present, this parameter is marked for copying to and from the VM. `LocalCopy` indicates where on
        /// the VM the file should be. The value given to this parameter (either at runtime or using `defaultValue`)
        /// must be the remote path where the file should be.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localCopy")]
        public virtual LocalCopy LocalCopy { get; set; } 

        /// <summary>Required. Name of the parameter - the pipeline runner uses this string as the key to the input and
        /// output maps in RunPipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The system resources for the pipeline run.</summary>
    public class PipelineResources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The number of accelerators of the specified type to attach. By specifying this parameter,
        /// you will download and install the following third-party software onto your managed Compute Engine instances:
        /// NVIDIA® Tesla® drivers and NVIDIA® CUDA toolkit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorCount")]
        public virtual System.Nullable<long> AcceleratorCount { get; set; } 

        /// <summary>Optional. The Compute Engine defined accelerator type. By specifying this parameter, you will
        /// download and install the following third-party software onto your managed Compute Engine instances: NVIDIA®
        /// Tesla® drivers and NVIDIA® CUDA toolkit. Please see https://cloud.google.com/compute/docs/gpus/ for a list
        /// of available accelerator types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorType")]
        public virtual string AcceleratorType { get; set; } 

        /// <summary>The size of the boot disk. Defaults to 10 (GB).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskSizeGb")]
        public virtual System.Nullable<int> BootDiskSizeGb { get; set; } 

        /// <summary>Disks to attach.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual System.Collections.Generic.IList<Disk> Disks { get; set; } 

        /// <summary>The minimum number of cores to use. Defaults to 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumCpuCores")]
        public virtual System.Nullable<int> MinimumCpuCores { get; set; } 

        /// <summary>The minimum amount of RAM to use. Defaults to 3.75 (GB)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumRamGb")]
        public virtual System.Nullable<double> MinimumRamGb { get; set; } 

        /// <summary>Whether to assign an external IP to the instance. This is an experimental feature that may go away.
        /// Defaults to false. Corresponds to `--no_address` flag for [gcloud compute instances create]
        /// (https://cloud.google.com/sdk/gcloud/reference/compute/instances/create). In order to use this, must be true
        /// for both create time and run time. Cannot be true at run time if false at create time. If you need to ssh
        /// into a private IP VM for debugging, you can ssh to a public VM and then ssh into the private VM's Internal
        /// IP. If noAddress is set, this pipeline run may only load docker images from Google Container Registry and
        /// not Docker Hub. Before using this, you must [configure access to Google services from internal
        /// IPs](https://cloud.google.com/compute/docs/configure-private-google-
        /// access#configuring_access_to_google_services_from_internal_ips).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noAddress")]
        public virtual System.Nullable<bool> NoAddress { get; set; } 

        /// <summary>Whether to use preemptible VMs. Defaults to `false`. In order to use this, must be true for both
        /// create time and run time. Cannot be true at run time if false at create time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preemptible")]
        public virtual System.Nullable<bool> Preemptible { get; set; } 

        /// <summary>List of Google Compute Engine availability zones to which resource creation will restricted. If
        /// empty, any zone may be chosen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zones")]
        public virtual System.Collections.Generic.IList<string> Zones { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event generated when the worker starts pulling an image.</summary>
    public class PullStartedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI of the image that was pulled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event generated when the worker stops pulling an image.</summary>
    public class PullStoppedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI of the image that was pulled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class RepeatedString : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The pipeline run arguments.</summary>
    public class RunPipelineArgs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This field is deprecated. Use `labels` instead. Client-specified pipeline operation
        /// identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; } 

        /// <summary>Pipeline input arguments; keys are defined in the pipeline documentation. All input parameters that
        /// do not have default values must be specified. If parameters with defaults are specified here, the defaults
        /// will be overridden.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputs")]
        public virtual System.Collections.Generic.IDictionary<string,string> Inputs { get; set; } 

        /// <summary>How long to keep the VM up after a failure (for example docker command failed, copying input or
        /// output files failed, etc). While the VM is up, one can ssh into the VM to debug. Default is 0; maximum
        /// allowed value is 1 day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keepVmAliveOnFailureDuration")]
        public virtual object KeepVmAliveOnFailureDuration { get; set; } 

        /// <summary>Labels to apply to this pipeline run. Labels will also be applied to compute resources (VM, disks)
        /// created by this pipeline run. When listing operations, operations can filtered by labels. Label keys may not
        /// be empty; label values may be empty. Non-empty labels must be 1-63 characters long, and comply with
        /// [RFC1035] (https://www.ietf.org/rfc/rfc1035.txt). Specifically, the name must be 1-63 characters long and
        /// match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a
        /// lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last
        /// character, which cannot be a dash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>Required. Logging options. Used by the service to communicate results to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logging")]
        public virtual LoggingOptions Logging { get; set; } 

        /// <summary>Pipeline output arguments; keys are defined in the pipeline documentation. All output parameters of
        /// without default values must be specified. If parameters with defaults are specified here, the defaults will
        /// be overridden.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputs")]
        public virtual System.Collections.Generic.IDictionary<string,string> Outputs { get; set; } 

        /// <summary>Required. The project in which to run the pipeline. The caller must have WRITER access to all
        /// Google Cloud services and resources (e.g. Google Compute Engine) will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; } 

        /// <summary>Specifies resource requirements/overrides for the pipeline run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual PipelineResources Resources { get; set; } 

        /// <summary>The Google Cloud Service Account that will be used to access data and services. By default, the
        /// compute service account associated with `projectId` is used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual ServiceAccount ServiceAccount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The request to run a pipeline. If `pipelineId` is specified, it refers to a saved pipeline created with
    /// CreatePipeline and set as the `pipelineId` of the returned Pipeline object. If `ephemeralPipeline` is specified,
    /// that pipeline is run once with the given args and not saved. It is an error to specify both `pipelineId` and
    /// `ephemeralPipeline`. `pipelineArgs` must be specified.</summary>
    public class RunPipelineRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A new pipeline object to run once and then delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ephemeralPipeline")]
        public virtual Pipeline EphemeralPipeline { get; set; } 

        /// <summary>The arguments to use when running this pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineArgs")]
        public virtual RunPipelineArgs PipelineArgs { get; set; } 

        /// <summary>The already created pipeline to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineId")]
        public virtual string PipelineId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response to the RunPipeline method, returned in the operation's result field on success.</summary>
    public class RunPipelineResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Runtime metadata that will be populated in the runtimeMetadata field of the Operation associated with a
    /// RunPipeline execution.</summary>
    public class RuntimeMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Execution information specific to Google Compute Engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeEngine")]
        public virtual ComputeEngine ComputeEngine { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A Google Cloud Service Account.</summary>
    public class ServiceAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Email address of the service account. Defaults to `default`, which uses the compute service account
        /// associated with the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; } 

        /// <summary>List of scopes to be enabled for this service account on the VM. The following scopes are
        /// automatically included: * https://www.googleapis.com/auth/compute *
        /// https://www.googleapis.com/auth/devstorage.full_control * https://www.googleapis.com/auth/genomics *
        /// https://www.googleapis.com/auth/logging.write * https://www.googleapis.com/auth/monitoring.write</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request to set operation status. Should only be used by VMs created by the Pipelines Service and not by
    /// end users.</summary>
    public class SetOperationStatusRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("timestampEvents")]
        public virtual System.Collections.Generic.IList<TimestampEvent> TimestampEvents { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("validationToken")]
        public virtual System.Nullable<ulong> ValidationToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The `Status` type defines a logical error model that is suitable for different programming
    /// environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status`
    /// message contains three pieces of data: error code, error message, and error details. You can find out more about
    /// this error model and how to work with it in the [API Design
    /// Guide](https://cloud.google.com/apis/design/errors).</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; } 

        /// <summary>A list of messages that carry the error details. There is a common set of message types for APIs to
        /// use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string,object>> Details { get; set; } 

        /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should
        /// be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Stores the list of events and times they occured for major events in job execution.</summary>
    public class TimestampEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>String indicating the type of event</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The time this event occured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event generated when the execution of a container results in a non-zero exit status that was not
    /// otherwise ignored. Execution will continue, but only actions that are flagged as `ALWAYS_RUN` will be executed.
    /// Other actions will be skipped.</summary>
    public class UnexpectedExitStatusEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; } 

        /// <summary>The exit status of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitStatus")]
        public virtual System.Nullable<int> ExitStatus { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event generated after a worker VM has been assigned to run the pipeline.</summary>
    public class WorkerAssignedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The worker's instance name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; } 

        /// <summary>The machine type that was assigned for the worker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; } 

        /// <summary>The zone the worker is running in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event generated when the worker VM that was assigned to the pipeline has been released
    /// (deleted).</summary>
    public class WorkerReleasedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The worker's instance name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; } 

        /// <summary>The zone the worker was running in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}

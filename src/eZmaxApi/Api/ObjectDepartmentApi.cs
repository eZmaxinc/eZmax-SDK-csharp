/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.2.1
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace eZmaxApi.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectDepartmentApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve Departments and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Department to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Departments to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DepartmentGetAutocompleteV2Response</returns>
        DepartmentGetAutocompleteV2Response DepartmentGetAutocompleteV2(string sSelector, string? eFilterActive = default(string?), string? sQuery = default(string?), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?), int operationIndex = 0);

        /// <summary>
        /// Retrieve Departments and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Department to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Departments to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DepartmentGetAutocompleteV2Response</returns>
        ApiResponse<DepartmentGetAutocompleteV2Response> DepartmentGetAutocompleteV2WithHttpInfo(string sSelector, string? eFilterActive = default(string?), string? sQuery = default(string?), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectDepartmentApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve Departments and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Department to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Departments to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DepartmentGetAutocompleteV2Response</returns>
        System.Threading.Tasks.Task<DepartmentGetAutocompleteV2Response> DepartmentGetAutocompleteV2Async(string sSelector, string? eFilterActive = default(string?), string? sQuery = default(string?), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve Departments and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Department to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Departments to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DepartmentGetAutocompleteV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<DepartmentGetAutocompleteV2Response>> DepartmentGetAutocompleteV2WithHttpInfoAsync(string sSelector, string? eFilterActive = default(string?), string? sQuery = default(string?), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectDepartmentApi : IObjectDepartmentApiSync, IObjectDepartmentApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ObjectDepartmentApi : IObjectDepartmentApi
    {
        private eZmaxApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectDepartmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectDepartmentApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectDepartmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectDepartmentApi(string basePath)
        {
            this.Configuration = eZmaxApi.Client.Configuration.MergeConfigurations(
                eZmaxApi.Client.GlobalConfiguration.Instance,
                new eZmaxApi.Client.Configuration { BasePath = basePath }
            );
            this.Client = new eZmaxApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new eZmaxApi.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = eZmaxApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectDepartmentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ObjectDepartmentApi(eZmaxApi.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = eZmaxApi.Client.Configuration.MergeConfigurations(
                eZmaxApi.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new eZmaxApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new eZmaxApi.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = eZmaxApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectDepartmentApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ObjectDepartmentApi(eZmaxApi.Client.ISynchronousClient client, eZmaxApi.Client.IAsynchronousClient asyncClient, eZmaxApi.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = eZmaxApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public eZmaxApi.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public eZmaxApi.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public eZmaxApi.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public eZmaxApi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Retrieve Departments and IDs Get the list of Department to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Departments to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DepartmentGetAutocompleteV2Response</returns>
        public DepartmentGetAutocompleteV2Response DepartmentGetAutocompleteV2(string sSelector, string? eFilterActive = default(string?), string? sQuery = default(string?), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?), int operationIndex = 0)
        {
            eZmaxApi.Client.ApiResponse<DepartmentGetAutocompleteV2Response> localVarResponse = DepartmentGetAutocompleteV2WithHttpInfo(sSelector, eFilterActive, sQuery, acceptLanguage);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve Departments and IDs Get the list of Department to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Departments to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DepartmentGetAutocompleteV2Response</returns>
        public eZmaxApi.Client.ApiResponse<DepartmentGetAutocompleteV2Response> DepartmentGetAutocompleteV2WithHttpInfo(string sSelector, string? eFilterActive = default(string?), string? sQuery = default(string?), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?), int operationIndex = 0)
        {
            // verify the required parameter 'sSelector' is set
            if (sSelector == null)
            {
                throw new eZmaxApi.Client.ApiException(400, "Missing required parameter 'sSelector' when calling ObjectDepartmentApi->DepartmentGetAutocompleteV2");
            }

            eZmaxApi.Client.RequestOptions localVarRequestOptions = new eZmaxApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = eZmaxApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = eZmaxApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("sSelector", eZmaxApi.Client.ClientUtils.ParameterToString(sSelector)); // path parameter
            if (eFilterActive != null)
            {
                localVarRequestOptions.QueryParameters.Add(eZmaxApi.Client.ClientUtils.ParameterToMultiMap("", "eFilterActive", eFilterActive));
            }
            if (sQuery != null)
            {
                localVarRequestOptions.QueryParameters.Add(eZmaxApi.Client.ClientUtils.ParameterToMultiMap("", "sQuery", sQuery));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", eZmaxApi.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "ObjectDepartmentApi.DepartmentGetAutocompleteV2";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Authorization) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DepartmentGetAutocompleteV2Response>("/2/object/department/getAutocomplete/{sSelector}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DepartmentGetAutocompleteV2", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve Departments and IDs Get the list of Department to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Departments to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DepartmentGetAutocompleteV2Response</returns>
        public async System.Threading.Tasks.Task<DepartmentGetAutocompleteV2Response> DepartmentGetAutocompleteV2Async(string sSelector, string? eFilterActive = default(string?), string? sQuery = default(string?), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            eZmaxApi.Client.ApiResponse<DepartmentGetAutocompleteV2Response> localVarResponse = await DepartmentGetAutocompleteV2WithHttpInfoAsync(sSelector, eFilterActive, sQuery, acceptLanguage, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve Departments and IDs Get the list of Department to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Departments to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DepartmentGetAutocompleteV2Response)</returns>
        public async System.Threading.Tasks.Task<eZmaxApi.Client.ApiResponse<DepartmentGetAutocompleteV2Response>> DepartmentGetAutocompleteV2WithHttpInfoAsync(string sSelector, string? eFilterActive = default(string?), string? sQuery = default(string?), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'sSelector' is set
            if (sSelector == null)
            {
                throw new eZmaxApi.Client.ApiException(400, "Missing required parameter 'sSelector' when calling ObjectDepartmentApi->DepartmentGetAutocompleteV2");
            }


            eZmaxApi.Client.RequestOptions localVarRequestOptions = new eZmaxApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = eZmaxApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = eZmaxApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("sSelector", eZmaxApi.Client.ClientUtils.ParameterToString(sSelector)); // path parameter
            if (eFilterActive != null)
            {
                localVarRequestOptions.QueryParameters.Add(eZmaxApi.Client.ClientUtils.ParameterToMultiMap("", "eFilterActive", eFilterActive));
            }
            if (sQuery != null)
            {
                localVarRequestOptions.QueryParameters.Add(eZmaxApi.Client.ClientUtils.ParameterToMultiMap("", "sQuery", sQuery));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", eZmaxApi.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "ObjectDepartmentApi.DepartmentGetAutocompleteV2";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Authorization) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DepartmentGetAutocompleteV2Response>("/2/object/department/getAutocomplete/{sSelector}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DepartmentGetAutocompleteV2", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}

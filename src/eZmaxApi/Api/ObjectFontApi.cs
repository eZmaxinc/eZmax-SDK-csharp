/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.17
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace eZmaxApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectFontApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve Fonts and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Font to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Fonts to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <returns>FontGetAutocompleteV2Response</returns>
        FontGetAutocompleteV2Response FontGetAutocompleteV2 (string sSelector, string eFilterActive = default(string), string sQuery = default(string), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?));

        /// <summary>
        /// Retrieve Fonts and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Font to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Fonts to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <returns>ApiResponse of FontGetAutocompleteV2Response</returns>
        ApiResponse<FontGetAutocompleteV2Response> FontGetAutocompleteV2WithHttpInfo (string sSelector, string eFilterActive = default(string), string sQuery = default(string), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve Fonts and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Font to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Fonts to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FontGetAutocompleteV2Response</returns>
        System.Threading.Tasks.Task<FontGetAutocompleteV2Response> FontGetAutocompleteV2Async (string sSelector, string eFilterActive = default(string), string sQuery = default(string), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieve Fonts and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Font to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Fonts to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FontGetAutocompleteV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<FontGetAutocompleteV2Response>> FontGetAutocompleteV2WithHttpInfoAsync (string sSelector, string eFilterActive = default(string), string sQuery = default(string), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ObjectFontApi : IObjectFontApi
    {
        private eZmaxApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFontApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectFontApi(String basePath)
        {
            this.Configuration = new eZmaxApi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = eZmaxApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFontApi"/> class
        /// </summary>
        /// <returns></returns>
        public ObjectFontApi()
        {
            this.Configuration = eZmaxApi.Client.Configuration.Default;

            ExceptionFactory = eZmaxApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFontApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ObjectFontApi(eZmaxApi.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = eZmaxApi.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = eZmaxApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public eZmaxApi.Client.Configuration Configuration {get; set;}

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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieve Fonts and IDs Get the list of Font to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Fonts to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <returns>FontGetAutocompleteV2Response</returns>
        public FontGetAutocompleteV2Response FontGetAutocompleteV2 (string sSelector, string eFilterActive = default(string), string sQuery = default(string), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?))
        {
             ApiResponse<FontGetAutocompleteV2Response> localVarResponse = FontGetAutocompleteV2WithHttpInfo(sSelector, eFilterActive, sQuery, acceptLanguage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve Fonts and IDs Get the list of Font to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Fonts to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <returns>ApiResponse of FontGetAutocompleteV2Response</returns>
        public ApiResponse<FontGetAutocompleteV2Response> FontGetAutocompleteV2WithHttpInfo (string sSelector, string eFilterActive = default(string), string sQuery = default(string), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?))
        {
            // verify the required parameter 'sSelector' is set
            if (sSelector == null)
                throw new ApiException(400, "Missing required parameter 'sSelector' when calling ObjectFontApi->FontGetAutocompleteV2");

            var localVarPath = "/2/object/font/getAutocomplete/{sSelector}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (sSelector != null) localVarPathParams.Add("sSelector", this.Configuration.ApiClient.ParameterToString(sSelector)); // path parameter
            if (eFilterActive != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "eFilterActive", eFilterActive)); // query parameter
            if (sQuery != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sQuery", sQuery)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", this.Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FontGetAutocompleteV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FontGetAutocompleteV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FontGetAutocompleteV2Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FontGetAutocompleteV2Response)));
        }

        /// <summary>
        /// Retrieve Fonts and IDs Get the list of Font to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Fonts to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FontGetAutocompleteV2Response</returns>
        public async System.Threading.Tasks.Task<FontGetAutocompleteV2Response> FontGetAutocompleteV2Async (string sSelector, string eFilterActive = default(string), string sQuery = default(string), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<FontGetAutocompleteV2Response> localVarResponse = await FontGetAutocompleteV2WithHttpInfoAsync(sSelector, eFilterActive, sQuery, acceptLanguage, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve Fonts and IDs Get the list of Font to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Fonts to return</param>
        /// <param name="eFilterActive">Specify which results we want to display. (optional, default to Active)</param>
        /// <param name="sQuery">Allow to filter the returned results (optional)</param>
        /// <param name="acceptLanguage"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FontGetAutocompleteV2Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FontGetAutocompleteV2Response>> FontGetAutocompleteV2WithHttpInfoAsync (string sSelector, string eFilterActive = default(string), string sQuery = default(string), HeaderAcceptLanguage? acceptLanguage = default(HeaderAcceptLanguage?), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'sSelector' is set
            if (sSelector == null)
                throw new ApiException(400, "Missing required parameter 'sSelector' when calling ObjectFontApi->FontGetAutocompleteV2");

            var localVarPath = "/2/object/font/getAutocomplete/{sSelector}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (sSelector != null) localVarPathParams.Add("sSelector", this.Configuration.ApiClient.ParameterToString(sSelector)); // path parameter
            if (eFilterActive != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "eFilterActive", eFilterActive)); // query parameter
            if (sQuery != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sQuery", sQuery)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", this.Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FontGetAutocompleteV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FontGetAutocompleteV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FontGetAutocompleteV2Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FontGetAutocompleteV2Response)));
        }

    }
}
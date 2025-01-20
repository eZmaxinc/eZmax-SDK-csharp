# eZmaxApi.Api.ObjectEzsignsigningreasonApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignsigningreasonCreateObjectV1**](ObjectEzsignsigningreasonApi.md#ezsignsigningreasoncreateobjectv1) | **POST** /1/object/ezsignsigningreason | Create a new Ezsignsigningreason |
| [**EzsignsigningreasonEditObjectV1**](ObjectEzsignsigningreasonApi.md#ezsignsigningreasoneditobjectv1) | **PUT** /1/object/ezsignsigningreason/{pkiEzsignsigningreasonID} | Edit an existing Ezsignsigningreason |
| [**EzsignsigningreasonGetAutocompleteV2**](ObjectEzsignsigningreasonApi.md#ezsignsigningreasongetautocompletev2) | **GET** /2/object/ezsignsigningreason/getAutocomplete/{sSelector} | Retrieve Ezsignsigningreasons and IDs |
| [**EzsignsigningreasonGetListV1**](ObjectEzsignsigningreasonApi.md#ezsignsigningreasongetlistv1) | **GET** /1/object/ezsignsigningreason/getList | Retrieve Ezsignsigningreason list |
| [**EzsignsigningreasonGetObjectV2**](ObjectEzsignsigningreasonApi.md#ezsignsigningreasongetobjectv2) | **GET** /2/object/ezsignsigningreason/{pkiEzsignsigningreasonID} | Retrieve an existing Ezsignsigningreason |

<a id="ezsignsigningreasoncreateobjectv1"></a>
# **EzsignsigningreasonCreateObjectV1**
> EzsignsigningreasonCreateObjectV1Response EzsignsigningreasonCreateObjectV1 (EzsignsigningreasonCreateObjectV1Request ezsignsigningreasonCreateObjectV1Request)

Create a new Ezsignsigningreason

The endpoint allows to create one or many elements at once.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignsigningreasonCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsigningreasonApi(config);
            var ezsignsigningreasonCreateObjectV1Request = new EzsignsigningreasonCreateObjectV1Request(); // EzsignsigningreasonCreateObjectV1Request | 

            try
            {
                // Create a new Ezsignsigningreason
                EzsignsigningreasonCreateObjectV1Response result = apiInstance.EzsignsigningreasonCreateObjectV1(ezsignsigningreasonCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignsigningreasonApi.EzsignsigningreasonCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignsigningreasonCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsignsigningreason
    ApiResponse<EzsignsigningreasonCreateObjectV1Response> response = apiInstance.EzsignsigningreasonCreateObjectV1WithHttpInfo(ezsignsigningreasonCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignsigningreasonApi.EzsignsigningreasonCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignsigningreasonCreateObjectV1Request** | [**EzsignsigningreasonCreateObjectV1Request**](EzsignsigningreasonCreateObjectV1Request.md) |  |  |

### Return type

[**EzsignsigningreasonCreateObjectV1Response**](EzsignsigningreasonCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignsigningreasoneditobjectv1"></a>
# **EzsignsigningreasonEditObjectV1**
> CommonResponse EzsignsigningreasonEditObjectV1 (int pkiEzsignsigningreasonID, EzsignsigningreasonEditObjectV1Request ezsignsigningreasonEditObjectV1Request)

Edit an existing Ezsignsigningreason

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignsigningreasonEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsigningreasonApi(config);
            var pkiEzsignsigningreasonID = 56;  // int | The unique ID of the Ezsignsigningreason
            var ezsignsigningreasonEditObjectV1Request = new EzsignsigningreasonEditObjectV1Request(); // EzsignsigningreasonEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsignsigningreason
                CommonResponse result = apiInstance.EzsignsigningreasonEditObjectV1(pkiEzsignsigningreasonID, ezsignsigningreasonEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignsigningreasonApi.EzsignsigningreasonEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignsigningreasonEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsignsigningreason
    ApiResponse<CommonResponse> response = apiInstance.EzsignsigningreasonEditObjectV1WithHttpInfo(pkiEzsignsigningreasonID, ezsignsigningreasonEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignsigningreasonApi.EzsignsigningreasonEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignsigningreasonID** | **int** | The unique ID of the Ezsignsigningreason |  |
| **ezsignsigningreasonEditObjectV1Request** | [**EzsignsigningreasonEditObjectV1Request**](EzsignsigningreasonEditObjectV1Request.md) |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignsigningreasongetautocompletev2"></a>
# **EzsignsigningreasonGetAutocompleteV2**
> EzsignsigningreasonGetAutocompleteV2Response EzsignsigningreasonGetAutocompleteV2 (string sSelector, string? eFilterActive = null, string? sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Ezsignsigningreasons and IDs

Get the list of Ezsignsigningreason to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignsigningreasonGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsigningreasonApi(config);
            var sSelector = "All";  // string | The type of Ezsignsigningreasons to return
            var eFilterActive = "All";  // string? | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string? | Allow to filter the returned results (optional) 
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Ezsignsigningreasons and IDs
                EzsignsigningreasonGetAutocompleteV2Response result = apiInstance.EzsignsigningreasonGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignsigningreasonApi.EzsignsigningreasonGetAutocompleteV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignsigningreasonGetAutocompleteV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsignsigningreasons and IDs
    ApiResponse<EzsignsigningreasonGetAutocompleteV2Response> response = apiInstance.EzsignsigningreasonGetAutocompleteV2WithHttpInfo(sSelector, eFilterActive, sQuery, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignsigningreasonApi.EzsignsigningreasonGetAutocompleteV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Ezsignsigningreasons to return |  |
| **eFilterActive** | **string?** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string?** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |

### Return type

[**EzsignsigningreasonGetAutocompleteV2Response**](EzsignsigningreasonGetAutocompleteV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignsigningreasongetlistv1"></a>
# **EzsignsigningreasonGetListV1**
> EzsignsigningreasonGetListV1Response EzsignsigningreasonGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Ezsignsigningreason list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignsigningreasonGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsigningreasonApi(config);
            var eOrderBy = "pkiEzsignsigningreasonID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Ezsignsigningreason list
                EzsignsigningreasonGetListV1Response result = apiInstance.EzsignsigningreasonGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignsigningreasonApi.EzsignsigningreasonGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignsigningreasonGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsignsigningreason list
    ApiResponse<EzsignsigningreasonGetListV1Response> response = apiInstance.EzsignsigningreasonGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignsigningreasonApi.EzsignsigningreasonGetListV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string?** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int?** |  | [optional]  |
| **iRowOffset** | **int?** |  | [optional] [default to 0] |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |
| **sFilter** | **string?** |  | [optional]  |

### Return type

[**EzsignsigningreasonGetListV1Response**](EzsignsigningreasonGetListV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignsigningreasongetobjectv2"></a>
# **EzsignsigningreasonGetObjectV2**
> EzsignsigningreasonGetObjectV2Response EzsignsigningreasonGetObjectV2 (int pkiEzsignsigningreasonID)

Retrieve an existing Ezsignsigningreason

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignsigningreasonGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsigningreasonApi(config);
            var pkiEzsignsigningreasonID = 56;  // int | The unique ID of the Ezsignsigningreason

            try
            {
                // Retrieve an existing Ezsignsigningreason
                EzsignsigningreasonGetObjectV2Response result = apiInstance.EzsignsigningreasonGetObjectV2(pkiEzsignsigningreasonID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignsigningreasonApi.EzsignsigningreasonGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignsigningreasonGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignsigningreason
    ApiResponse<EzsignsigningreasonGetObjectV2Response> response = apiInstance.EzsignsigningreasonGetObjectV2WithHttpInfo(pkiEzsignsigningreasonID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignsigningreasonApi.EzsignsigningreasonGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignsigningreasonID** | **int** | The unique ID of the Ezsignsigningreason |  |

### Return type

[**EzsignsigningreasonGetObjectV2Response**](EzsignsigningreasonGetObjectV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


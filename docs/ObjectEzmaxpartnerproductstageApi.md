# eZmaxApi.Api.ObjectEzmaxpartnerproductstageApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1**](ObjectEzmaxpartnerproductstageApi.md#ezmaxpartnerproductstagegetezmaxpartnerproductstagepermissionsv1) | **GET** /1/object/ezmaxpartnerproductstage/{pkiEzmaxpartnerproductstageID}/getEzmaxpartnerproductstagepermissions | Retrieve an existing Ezmaxpartnerproductstage&#39;s Ezmaxpartnerproductstagepermissions |
| [**EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1**](ObjectEzmaxpartnerproductstageApi.md#ezmaxpartnerproductstagegetezmaxpartnerproductstagewebhooksv1) | **GET** /1/object/ezmaxpartnerproductstage/{pkiEzmaxpartnerproductstageID}/getEzmaxpartnerproductstagewebhooks | Retrieve an existing Ezmaxpartnerproductstage&#39;s Ezmaxpartnerproductstagewebhooks |
| [**EzmaxpartnerproductstageGetListV1**](ObjectEzmaxpartnerproductstageApi.md#ezmaxpartnerproductstagegetlistv1) | **GET** /1/object/ezmaxpartnerproductstage/getList | Retrieve Ezmaxpartnerproductstage list |
| [**EzmaxpartnerproductstageGetObjectV2**](ObjectEzmaxpartnerproductstageApi.md#ezmaxpartnerproductstagegetobjectv2) | **GET** /2/object/ezmaxpartnerproductstage/{pkiEzmaxpartnerproductstageID} | Retrieve an existing Ezmaxpartnerproductstage |
| [**EzmaxpartnerproductstageSubscribeV1**](ObjectEzmaxpartnerproductstageApi.md#ezmaxpartnerproductstagesubscribev1) | **POST** /1/object/ezmaxpartnerproductstage/{pkiEzmaxpartnerproductstageID}/subscribe | Subscribe to the Ezmaxpartnerproductstage |
| [**EzmaxpartnerproductstageUnsubscribeV1**](ObjectEzmaxpartnerproductstageApi.md#ezmaxpartnerproductstageunsubscribev1) | **POST** /1/object/ezmaxpartnerproductstage/{pkiEzmaxpartnerproductstageID}/unsubscribe | Unsubscribe to the Ezmaxpartnerproductstage |

<a id="ezmaxpartnerproductstagegetezmaxpartnerproductstagepermissionsv1"></a>
# **EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1**
> EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1Response EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1 (int pkiEzmaxpartnerproductstageID)

Retrieve an existing Ezmaxpartnerproductstage's Ezmaxpartnerproductstagepermissions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxpartnerproductstageApi(config);
            var pkiEzmaxpartnerproductstageID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezmaxpartnerproductstage's Ezmaxpartnerproductstagepermissions
                EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1Response result = apiInstance.EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1(pkiEzmaxpartnerproductstageID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxpartnerproductstageApi.EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezmaxpartnerproductstage's Ezmaxpartnerproductstagepermissions
    ApiResponse<EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1Response> response = apiInstance.EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1WithHttpInfo(pkiEzmaxpartnerproductstageID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxpartnerproductstageApi.EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzmaxpartnerproductstageID** | **int** |  |  |

### Return type

[**EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1Response**](EzmaxpartnerproductstageGetEzmaxpartnerproductstagepermissionsV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezmaxpartnerproductstagegetezmaxpartnerproductstagewebhooksv1"></a>
# **EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1**
> EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1Response EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1 (int pkiEzmaxpartnerproductstageID)

Retrieve an existing Ezmaxpartnerproductstage's Ezmaxpartnerproductstagewebhooks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxpartnerproductstageApi(config);
            var pkiEzmaxpartnerproductstageID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezmaxpartnerproductstage's Ezmaxpartnerproductstagewebhooks
                EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1Response result = apiInstance.EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1(pkiEzmaxpartnerproductstageID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxpartnerproductstageApi.EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezmaxpartnerproductstage's Ezmaxpartnerproductstagewebhooks
    ApiResponse<EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1Response> response = apiInstance.EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1WithHttpInfo(pkiEzmaxpartnerproductstageID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxpartnerproductstageApi.EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzmaxpartnerproductstageID** | **int** |  |  |

### Return type

[**EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1Response**](EzmaxpartnerproductstageGetEzmaxpartnerproductstagewebhooksV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezmaxpartnerproductstagegetlistv1"></a>
# **EzmaxpartnerproductstageGetListV1**
> EzmaxpartnerproductstageGetListV1Response EzmaxpartnerproductstageGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Ezmaxpartnerproductstage list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxpartnerproductstageGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxpartnerproductstageApi(config);
            var eOrderBy = "pkiEzmaxpartnerproductstageID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Ezmaxpartnerproductstage list
                EzmaxpartnerproductstageGetListV1Response result = apiInstance.EzmaxpartnerproductstageGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxpartnerproductstageApi.EzmaxpartnerproductstageGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxpartnerproductstageGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezmaxpartnerproductstage list
    ApiResponse<EzmaxpartnerproductstageGetListV1Response> response = apiInstance.EzmaxpartnerproductstageGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxpartnerproductstageApi.EzmaxpartnerproductstageGetListV1WithHttpInfo: " + e.Message);
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

[**EzmaxpartnerproductstageGetListV1Response**](EzmaxpartnerproductstageGetListV1Response.md)

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

<a id="ezmaxpartnerproductstagegetobjectv2"></a>
# **EzmaxpartnerproductstageGetObjectV2**
> EzmaxpartnerproductstageGetObjectV2Response EzmaxpartnerproductstageGetObjectV2 (int pkiEzmaxpartnerproductstageID)

Retrieve an existing Ezmaxpartnerproductstage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxpartnerproductstageGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxpartnerproductstageApi(config);
            var pkiEzmaxpartnerproductstageID = 56;  // int | The unique ID of the Ezmaxpartnerproductstage

            try
            {
                // Retrieve an existing Ezmaxpartnerproductstage
                EzmaxpartnerproductstageGetObjectV2Response result = apiInstance.EzmaxpartnerproductstageGetObjectV2(pkiEzmaxpartnerproductstageID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxpartnerproductstageApi.EzmaxpartnerproductstageGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxpartnerproductstageGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezmaxpartnerproductstage
    ApiResponse<EzmaxpartnerproductstageGetObjectV2Response> response = apiInstance.EzmaxpartnerproductstageGetObjectV2WithHttpInfo(pkiEzmaxpartnerproductstageID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxpartnerproductstageApi.EzmaxpartnerproductstageGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzmaxpartnerproductstageID** | **int** | The unique ID of the Ezmaxpartnerproductstage |  |

### Return type

[**EzmaxpartnerproductstageGetObjectV2Response**](EzmaxpartnerproductstageGetObjectV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezmaxpartnerproductstagesubscribev1"></a>
# **EzmaxpartnerproductstageSubscribeV1**
> EzmaxpartnerproductstageSubscribeV1Response EzmaxpartnerproductstageSubscribeV1 (int pkiEzmaxpartnerproductstageID, Object body)

Subscribe to the Ezmaxpartnerproductstage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxpartnerproductstageSubscribeV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxpartnerproductstageApi(config);
            var pkiEzmaxpartnerproductstageID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Subscribe to the Ezmaxpartnerproductstage
                EzmaxpartnerproductstageSubscribeV1Response result = apiInstance.EzmaxpartnerproductstageSubscribeV1(pkiEzmaxpartnerproductstageID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxpartnerproductstageApi.EzmaxpartnerproductstageSubscribeV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxpartnerproductstageSubscribeV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Subscribe to the Ezmaxpartnerproductstage
    ApiResponse<EzmaxpartnerproductstageSubscribeV1Response> response = apiInstance.EzmaxpartnerproductstageSubscribeV1WithHttpInfo(pkiEzmaxpartnerproductstageID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxpartnerproductstageApi.EzmaxpartnerproductstageSubscribeV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzmaxpartnerproductstageID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzmaxpartnerproductstageSubscribeV1Response**](EzmaxpartnerproductstageSubscribeV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezmaxpartnerproductstageunsubscribev1"></a>
# **EzmaxpartnerproductstageUnsubscribeV1**
> EzmaxpartnerproductstageUnsubscribeV1Response EzmaxpartnerproductstageUnsubscribeV1 (int pkiEzmaxpartnerproductstageID, Object body)

Unsubscribe to the Ezmaxpartnerproductstage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxpartnerproductstageUnsubscribeV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxpartnerproductstageApi(config);
            var pkiEzmaxpartnerproductstageID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Unsubscribe to the Ezmaxpartnerproductstage
                EzmaxpartnerproductstageUnsubscribeV1Response result = apiInstance.EzmaxpartnerproductstageUnsubscribeV1(pkiEzmaxpartnerproductstageID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxpartnerproductstageApi.EzmaxpartnerproductstageUnsubscribeV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxpartnerproductstageUnsubscribeV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unsubscribe to the Ezmaxpartnerproductstage
    ApiResponse<EzmaxpartnerproductstageUnsubscribeV1Response> response = apiInstance.EzmaxpartnerproductstageUnsubscribeV1WithHttpInfo(pkiEzmaxpartnerproductstageID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxpartnerproductstageApi.EzmaxpartnerproductstageUnsubscribeV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzmaxpartnerproductstageID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzmaxpartnerproductstageUnsubscribeV1Response**](EzmaxpartnerproductstageUnsubscribeV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


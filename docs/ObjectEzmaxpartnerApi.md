# eZmaxApi.Api.ObjectEzmaxpartnerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzmaxpartnerGetCustomDeveloppersV1**](ObjectEzmaxpartnerApi.md#ezmaxpartnergetcustomdeveloppersv1) | **GET** /1/object/ezmaxpartner/getCustomDeveloppers | Retrieve Ezmaxpartner custom developpers list |
| [**EzmaxpartnerGetObjectV2**](ObjectEzmaxpartnerApi.md#ezmaxpartnergetobjectv2) | **GET** /2/object/ezmaxpartner/{pkiEzmaxpartnerID} | Retrieve an existing Ezmaxpartner |

<a id="ezmaxpartnergetcustomdeveloppersv1"></a>
# **EzmaxpartnerGetCustomDeveloppersV1**
> EzmaxpartnerGetCustomDeveloppersV1Response EzmaxpartnerGetCustomDeveloppersV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Ezmaxpartner custom developpers list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxpartnerGetCustomDeveloppersV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxpartnerApi(config);
            var eOrderBy = "pkiEzmaxpartnerID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Ezmaxpartner custom developpers list
                EzmaxpartnerGetCustomDeveloppersV1Response result = apiInstance.EzmaxpartnerGetCustomDeveloppersV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxpartnerApi.EzmaxpartnerGetCustomDeveloppersV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxpartnerGetCustomDeveloppersV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezmaxpartner custom developpers list
    ApiResponse<EzmaxpartnerGetCustomDeveloppersV1Response> response = apiInstance.EzmaxpartnerGetCustomDeveloppersV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxpartnerApi.EzmaxpartnerGetCustomDeveloppersV1WithHttpInfo: " + e.Message);
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

[**EzmaxpartnerGetCustomDeveloppersV1Response**](EzmaxpartnerGetCustomDeveloppersV1Response.md)

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

<a id="ezmaxpartnergetobjectv2"></a>
# **EzmaxpartnerGetObjectV2**
> EzmaxpartnerGetObjectV2Response EzmaxpartnerGetObjectV2 (int pkiEzmaxpartnerID)

Retrieve an existing Ezmaxpartner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxpartnerGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxpartnerApi(config);
            var pkiEzmaxpartnerID = 56;  // int | The unique ID of the Ezmaxpartner

            try
            {
                // Retrieve an existing Ezmaxpartner
                EzmaxpartnerGetObjectV2Response result = apiInstance.EzmaxpartnerGetObjectV2(pkiEzmaxpartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxpartnerApi.EzmaxpartnerGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxpartnerGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezmaxpartner
    ApiResponse<EzmaxpartnerGetObjectV2Response> response = apiInstance.EzmaxpartnerGetObjectV2WithHttpInfo(pkiEzmaxpartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxpartnerApi.EzmaxpartnerGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzmaxpartnerID** | **int** | The unique ID of the Ezmaxpartner |  |

### Return type

[**EzmaxpartnerGetObjectV2Response**](EzmaxpartnerGetObjectV2Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


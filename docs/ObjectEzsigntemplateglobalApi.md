# eZmaxApi.Api.ObjectEzsigntemplateglobalApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplateglobalGetAutocompleteV2**](ObjectEzsigntemplateglobalApi.md#ezsigntemplateglobalgetautocompletev2) | **GET** /2/object/ezsigntemplateglobal/getAutocomplete/{sSelector} | Retrieve Ezsigntemplateglobals and IDs |
| [**EzsigntemplateglobalGetObjectV2**](ObjectEzsigntemplateglobalApi.md#ezsigntemplateglobalgetobjectv2) | **GET** /2/object/ezsigntemplateglobal/{pkiEzsigntemplateglobalID} | Retrieve an existing Ezsigntemplateglobal |

<a id="ezsigntemplateglobalgetautocompletev2"></a>
# **EzsigntemplateglobalGetAutocompleteV2**
> EzsigntemplateglobalGetAutocompleteV2Response EzsigntemplateglobalGetAutocompleteV2 (string sSelector, string? eFilterActive = null, string? sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Ezsigntemplateglobals and IDs

Get the list of Ezsigntemplateglobal to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplateglobalGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplateglobalApi(config);
            var sSelector = "All";  // string | The type of Ezsigntemplateglobals to return
            var eFilterActive = "All";  // string? | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string? | Allow to filter the returned results (optional) 
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Ezsigntemplateglobals and IDs
                EzsigntemplateglobalGetAutocompleteV2Response result = apiInstance.EzsigntemplateglobalGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplateglobalApi.EzsigntemplateglobalGetAutocompleteV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplateglobalGetAutocompleteV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsigntemplateglobals and IDs
    ApiResponse<EzsigntemplateglobalGetAutocompleteV2Response> response = apiInstance.EzsigntemplateglobalGetAutocompleteV2WithHttpInfo(sSelector, eFilterActive, sQuery, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplateglobalApi.EzsigntemplateglobalGetAutocompleteV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Ezsigntemplateglobals to return |  |
| **eFilterActive** | **string?** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string?** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |

### Return type

[**EzsigntemplateglobalGetAutocompleteV2Response**](EzsigntemplateglobalGetAutocompleteV2Response.md)

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

<a id="ezsigntemplateglobalgetobjectv2"></a>
# **EzsigntemplateglobalGetObjectV2**
> EzsigntemplateglobalGetObjectV2Response EzsigntemplateglobalGetObjectV2 (int pkiEzsigntemplateglobalID)

Retrieve an existing Ezsigntemplateglobal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplateglobalGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplateglobalApi(config);
            var pkiEzsigntemplateglobalID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplateglobal
                EzsigntemplateglobalGetObjectV2Response result = apiInstance.EzsigntemplateglobalGetObjectV2(pkiEzsigntemplateglobalID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplateglobalApi.EzsigntemplateglobalGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplateglobalGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplateglobal
    ApiResponse<EzsigntemplateglobalGetObjectV2Response> response = apiInstance.EzsigntemplateglobalGetObjectV2WithHttpInfo(pkiEzsigntemplateglobalID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplateglobalApi.EzsigntemplateglobalGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateglobalID** | **int** |  |  |

### Return type

[**EzsigntemplateglobalGetObjectV2Response**](EzsigntemplateglobalGetObjectV2Response.md)

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


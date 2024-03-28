# eZmaxApi.Api.ObjectEzmaxinvoicingApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzmaxinvoicingGetAutocompleteV2**](ObjectEzmaxinvoicingApi.md#ezmaxinvoicinggetautocompletev2) | **GET** /2/object/ezmaxinvoicing/getAutocomplete/{sSelector} | Retrieve Ezmaxinvoicings and IDs |
| [**EzmaxinvoicingGetObjectV2**](ObjectEzmaxinvoicingApi.md#ezmaxinvoicinggetobjectv2) | **GET** /2/object/ezmaxinvoicing/{pkiEzmaxinvoicingID} | Retrieve an existing Ezmaxinvoicing |
| [**EzmaxinvoicingGetProvisionalV1**](ObjectEzmaxinvoicingApi.md#ezmaxinvoicinggetprovisionalv1) | **GET** /1/object/ezmaxinvoicing/getProvisional | Retrieve provisional Ezmaxinvoicing |

<a id="ezmaxinvoicinggetautocompletev2"></a>
# **EzmaxinvoicingGetAutocompleteV2**
> EzmaxinvoicingGetAutocompleteV2Response EzmaxinvoicingGetAutocompleteV2 (string sSelector, string? eFilterActive = null, string? sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Ezmaxinvoicings and IDs

Get the list of Ezmaxinvoicing to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxinvoicingGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxinvoicingApi(config);
            var sSelector = "All";  // string | The type of Ezmaxinvoicings to return
            var eFilterActive = "All";  // string? | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string? | Allow to filter the returned results (optional) 
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Ezmaxinvoicings and IDs
                EzmaxinvoicingGetAutocompleteV2Response result = apiInstance.EzmaxinvoicingGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxinvoicingApi.EzmaxinvoicingGetAutocompleteV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxinvoicingGetAutocompleteV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezmaxinvoicings and IDs
    ApiResponse<EzmaxinvoicingGetAutocompleteV2Response> response = apiInstance.EzmaxinvoicingGetAutocompleteV2WithHttpInfo(sSelector, eFilterActive, sQuery, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxinvoicingApi.EzmaxinvoicingGetAutocompleteV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Ezmaxinvoicings to return |  |
| **eFilterActive** | **string?** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string?** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |

### Return type

[**EzmaxinvoicingGetAutocompleteV2Response**](EzmaxinvoicingGetAutocompleteV2Response.md)

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

<a id="ezmaxinvoicinggetobjectv2"></a>
# **EzmaxinvoicingGetObjectV2**
> EzmaxinvoicingGetObjectV2Response EzmaxinvoicingGetObjectV2 (int pkiEzmaxinvoicingID)

Retrieve an existing Ezmaxinvoicing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxinvoicingGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxinvoicingApi(config);
            var pkiEzmaxinvoicingID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezmaxinvoicing
                EzmaxinvoicingGetObjectV2Response result = apiInstance.EzmaxinvoicingGetObjectV2(pkiEzmaxinvoicingID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxinvoicingApi.EzmaxinvoicingGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxinvoicingGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezmaxinvoicing
    ApiResponse<EzmaxinvoicingGetObjectV2Response> response = apiInstance.EzmaxinvoicingGetObjectV2WithHttpInfo(pkiEzmaxinvoicingID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxinvoicingApi.EzmaxinvoicingGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzmaxinvoicingID** | **int** |  |  |

### Return type

[**EzmaxinvoicingGetObjectV2Response**](EzmaxinvoicingGetObjectV2Response.md)

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

<a id="ezmaxinvoicinggetprovisionalv1"></a>
# **EzmaxinvoicingGetProvisionalV1**
> EzmaxinvoicingGetProvisionalV1Response EzmaxinvoicingGetProvisionalV1 ()

Retrieve provisional Ezmaxinvoicing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxinvoicingGetProvisionalV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxinvoicingApi(config);

            try
            {
                // Retrieve provisional Ezmaxinvoicing
                EzmaxinvoicingGetProvisionalV1Response result = apiInstance.EzmaxinvoicingGetProvisionalV1();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxinvoicingApi.EzmaxinvoicingGetProvisionalV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxinvoicingGetProvisionalV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve provisional Ezmaxinvoicing
    ApiResponse<EzmaxinvoicingGetProvisionalV1Response> response = apiInstance.EzmaxinvoicingGetProvisionalV1WithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxinvoicingApi.EzmaxinvoicingGetProvisionalV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EzmaxinvoicingGetProvisionalV1Response**](EzmaxinvoicingGetProvisionalV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


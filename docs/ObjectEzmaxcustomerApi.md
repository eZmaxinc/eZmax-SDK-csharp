# eZmaxApi.Api.ObjectEzmaxcustomerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzmaxcustomerPatchObjectV1**](ObjectEzmaxcustomerApi.md#ezmaxcustomerpatchobjectv1) | **PATCH** /1/object/ezmaxcustomer/{pkiEzmaxcustomerID} | Patch an existing Ezmaxcustomer |

<a id="ezmaxcustomerpatchobjectv1"></a>
# **EzmaxcustomerPatchObjectV1**
> EzmaxcustomerPatchObjectV1Response EzmaxcustomerPatchObjectV1 (int pkiEzmaxcustomerID, EzmaxcustomerPatchObjectV1Request ezmaxcustomerPatchObjectV1Request)

Patch an existing Ezmaxcustomer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxcustomerPatchObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxcustomerApi(config);
            var pkiEzmaxcustomerID = 56;  // int | The unique ID of the Ezmaxcustomer
            var ezmaxcustomerPatchObjectV1Request = new EzmaxcustomerPatchObjectV1Request(); // EzmaxcustomerPatchObjectV1Request | 

            try
            {
                // Patch an existing Ezmaxcustomer
                EzmaxcustomerPatchObjectV1Response result = apiInstance.EzmaxcustomerPatchObjectV1(pkiEzmaxcustomerID, ezmaxcustomerPatchObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxcustomerApi.EzmaxcustomerPatchObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxcustomerPatchObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patch an existing Ezmaxcustomer
    ApiResponse<EzmaxcustomerPatchObjectV1Response> response = apiInstance.EzmaxcustomerPatchObjectV1WithHttpInfo(pkiEzmaxcustomerID, ezmaxcustomerPatchObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxcustomerApi.EzmaxcustomerPatchObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzmaxcustomerID** | **int** | The unique ID of the Ezmaxcustomer |  |
| **ezmaxcustomerPatchObjectV1Request** | [**EzmaxcustomerPatchObjectV1Request**](EzmaxcustomerPatchObjectV1Request.md) |  |  |

### Return type

[**EzmaxcustomerPatchObjectV1Response**](EzmaxcustomerPatchObjectV1Response.md)

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


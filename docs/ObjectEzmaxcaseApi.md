# eZmaxApi.Api.ObjectEzmaxcaseApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzmaxcasePatchObjectV1**](ObjectEzmaxcaseApi.md#ezmaxcasepatchobjectv1) | **PATCH** /1/object/ezmaxcase/{pkiEzmaxcaseID} | Patch an existing Ezmaxcase |

<a id="ezmaxcasepatchobjectv1"></a>
# **EzmaxcasePatchObjectV1**
> EzmaxcasePatchObjectV1Response EzmaxcasePatchObjectV1 (int pkiEzmaxcaseID, EzmaxcasePatchObjectV1Request ezmaxcasePatchObjectV1Request)

Patch an existing Ezmaxcase

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxcasePatchObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxcaseApi(config);
            var pkiEzmaxcaseID = 56;  // int | The unique ID of the Ezmaxcase
            var ezmaxcasePatchObjectV1Request = new EzmaxcasePatchObjectV1Request(); // EzmaxcasePatchObjectV1Request | 

            try
            {
                // Patch an existing Ezmaxcase
                EzmaxcasePatchObjectV1Response result = apiInstance.EzmaxcasePatchObjectV1(pkiEzmaxcaseID, ezmaxcasePatchObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxcaseApi.EzmaxcasePatchObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxcasePatchObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patch an existing Ezmaxcase
    ApiResponse<EzmaxcasePatchObjectV1Response> response = apiInstance.EzmaxcasePatchObjectV1WithHttpInfo(pkiEzmaxcaseID, ezmaxcasePatchObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxcaseApi.EzmaxcasePatchObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzmaxcaseID** | **int** | The unique ID of the Ezmaxcase |  |
| **ezmaxcasePatchObjectV1Request** | [**EzmaxcasePatchObjectV1Request**](EzmaxcasePatchObjectV1Request.md) |  |  |

### Return type

[**EzmaxcasePatchObjectV1Response**](EzmaxcasePatchObjectV1Response.md)

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


# eZmaxApi.Api.ObjectEzmaxcustomeruserApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzmaxcustomeruserPatchObjectV1**](ObjectEzmaxcustomeruserApi.md#ezmaxcustomeruserpatchobjectv1) | **PATCH** /1/object/ezmaxcustomeruser/{pkiEzmaxcustomeruserID} | Patch an existing Ezmaxcustomeruser |

<a id="ezmaxcustomeruserpatchobjectv1"></a>
# **EzmaxcustomeruserPatchObjectV1**
> EzmaxcustomeruserPatchObjectV1Response EzmaxcustomeruserPatchObjectV1 (int pkiEzmaxcustomeruserID, EzmaxcustomeruserPatchObjectV1Request ezmaxcustomeruserPatchObjectV1Request)

Patch an existing Ezmaxcustomeruser

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxcustomeruserPatchObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzmaxcustomeruserApi(config);
            var pkiEzmaxcustomeruserID = 56;  // int | The unique ID of the Ezmaxcustomeruser
            var ezmaxcustomeruserPatchObjectV1Request = new EzmaxcustomeruserPatchObjectV1Request(); // EzmaxcustomeruserPatchObjectV1Request | 

            try
            {
                // Patch an existing Ezmaxcustomeruser
                EzmaxcustomeruserPatchObjectV1Response result = apiInstance.EzmaxcustomeruserPatchObjectV1(pkiEzmaxcustomeruserID, ezmaxcustomeruserPatchObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzmaxcustomeruserApi.EzmaxcustomeruserPatchObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxcustomeruserPatchObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patch an existing Ezmaxcustomeruser
    ApiResponse<EzmaxcustomeruserPatchObjectV1Response> response = apiInstance.EzmaxcustomeruserPatchObjectV1WithHttpInfo(pkiEzmaxcustomeruserID, ezmaxcustomeruserPatchObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzmaxcustomeruserApi.EzmaxcustomeruserPatchObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzmaxcustomeruserID** | **int** | The unique ID of the Ezmaxcustomeruser |  |
| **ezmaxcustomeruserPatchObjectV1Request** | [**EzmaxcustomeruserPatchObjectV1Request**](EzmaxcustomeruserPatchObjectV1Request.md) |  |  |

### Return type

[**EzmaxcustomeruserPatchObjectV1Response**](EzmaxcustomeruserPatchObjectV1Response.md)

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


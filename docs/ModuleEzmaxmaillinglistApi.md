# eZmaxApi.Api.ModuleEzmaxmaillinglistApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzmaxmaillinglistSubscribeV1**](ModuleEzmaxmaillinglistApi.md#ezmaxmaillinglistsubscribev1) | **POST** /1/module/ezmaxmaillinglist/subscribe | Subscribe to specific Ezmaxmaillinglist |

<a id="ezmaxmaillinglistsubscribev1"></a>
# **EzmaxmaillinglistSubscribeV1**
> EzmaxmaillinglistSubscribeV1Response EzmaxmaillinglistSubscribeV1 (EzmaxmaillinglistSubscribeV1Request ezmaxmaillinglistSubscribeV1Request)

Subscribe to specific Ezmaxmaillinglist

Users can subscribe to specific Ezmaxmaillinglist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxmaillinglistSubscribeV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleEzmaxmaillinglistApi(config);
            var ezmaxmaillinglistSubscribeV1Request = new EzmaxmaillinglistSubscribeV1Request(); // EzmaxmaillinglistSubscribeV1Request | 

            try
            {
                // Subscribe to specific Ezmaxmaillinglist
                EzmaxmaillinglistSubscribeV1Response result = apiInstance.EzmaxmaillinglistSubscribeV1(ezmaxmaillinglistSubscribeV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModuleEzmaxmaillinglistApi.EzmaxmaillinglistSubscribeV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxmaillinglistSubscribeV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Subscribe to specific Ezmaxmaillinglist
    ApiResponse<EzmaxmaillinglistSubscribeV1Response> response = apiInstance.EzmaxmaillinglistSubscribeV1WithHttpInfo(ezmaxmaillinglistSubscribeV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModuleEzmaxmaillinglistApi.EzmaxmaillinglistSubscribeV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezmaxmaillinglistSubscribeV1Request** | [**EzmaxmaillinglistSubscribeV1Request**](EzmaxmaillinglistSubscribeV1Request.md) |  |  |

### Return type

[**EzmaxmaillinglistSubscribeV1Response**](EzmaxmaillinglistSubscribeV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


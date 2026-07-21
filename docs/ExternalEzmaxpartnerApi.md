# eZmaxApi.Api.ExternalEzmaxpartnerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzmaxpartnerSubscribeV1**](ExternalEzmaxpartnerApi.md#ezmaxpartnersubscribev1) | **POST** /1/external/ezmaxpartner/subscribe | Subscribe to an Ezmaxparnerproductstage |

<a id="ezmaxpartnersubscribev1"></a>
# **EzmaxpartnerSubscribeV1**
> EzmaxpartnerSubscribeV1Response EzmaxpartnerSubscribeV1 (EzmaxpartnerSubscribeV1Request ezmaxpartnerSubscribeV1Request)

Subscribe to an Ezmaxparnerproductstage

Subscribe to an Ezmaxparnerproductstage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzmaxpartnerSubscribeV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalEzmaxpartnerApi(config);
            var ezmaxpartnerSubscribeV1Request = new EzmaxpartnerSubscribeV1Request(); // EzmaxpartnerSubscribeV1Request | 

            try
            {
                // Subscribe to an Ezmaxparnerproductstage
                EzmaxpartnerSubscribeV1Response result = apiInstance.EzmaxpartnerSubscribeV1(ezmaxpartnerSubscribeV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalEzmaxpartnerApi.EzmaxpartnerSubscribeV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzmaxpartnerSubscribeV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Subscribe to an Ezmaxparnerproductstage
    ApiResponse<EzmaxpartnerSubscribeV1Response> response = apiInstance.EzmaxpartnerSubscribeV1WithHttpInfo(ezmaxpartnerSubscribeV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalEzmaxpartnerApi.EzmaxpartnerSubscribeV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezmaxpartnerSubscribeV1Request** | [**EzmaxpartnerSubscribeV1Request**](EzmaxpartnerSubscribeV1Request.md) |  |  |

### Return type

[**EzmaxpartnerSubscribeV1Response**](EzmaxpartnerSubscribeV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


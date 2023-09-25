# eZmaxApi.Api.GlobalEzmaxclientApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GlobalEzmaxclientVersionV1**](GlobalEzmaxclientApi.md#globalezmaxclientversionv1) | **GET** /1/ezmaxclient/{pksEzmaxclientOs}/version | Retrieve the latest version of the Ezmaxclient |

<a id="globalezmaxclientversionv1"></a>
# **GlobalEzmaxclientVersionV1**
> GlobalEzmaxclientVersionV1Response GlobalEzmaxclientVersionV1 (FieldPksEzmaxclientOs pksEzmaxclientOs)

Retrieve the latest version of the Ezmaxclient

Retrieve the latest version of the Ezmaxclient that is available on the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class GlobalEzmaxclientVersionV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            var apiInstance = new GlobalEzmaxclientApi(config);
            var pksEzmaxclientOs = new FieldPksEzmaxclientOs(); // FieldPksEzmaxclientOs | 

            try
            {
                // Retrieve the latest version of the Ezmaxclient
                GlobalEzmaxclientVersionV1Response result = apiInstance.GlobalEzmaxclientVersionV1(pksEzmaxclientOs);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalEzmaxclientApi.GlobalEzmaxclientVersionV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlobalEzmaxclientVersionV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the latest version of the Ezmaxclient
    ApiResponse<GlobalEzmaxclientVersionV1Response> response = apiInstance.GlobalEzmaxclientVersionV1WithHttpInfo(pksEzmaxclientOs);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalEzmaxclientApi.GlobalEzmaxclientVersionV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pksEzmaxclientOs** | [**FieldPksEzmaxclientOs**](FieldPksEzmaxclientOs.md) |  |  |

### Return type

[**GlobalEzmaxclientVersionV1Response**](GlobalEzmaxclientVersionV1Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# eZmaxApi.Api.ObjectModulegroupApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ModulegroupGetAllV1**](ObjectModulegroupApi.md#modulegroupgetallv1) | **GET** /1/object/modulegroup/getAll/{eContext} | Retrieve all Modulegroups |

<a id="modulegroupgetallv1"></a>
# **ModulegroupGetAllV1**
> ModulegroupGetAllV1Response ModulegroupGetAllV1 (string eContext)

Retrieve all Modulegroups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ModulegroupGetAllV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectModulegroupApi(config);
            var eContext = "Api";  // string | The context of the Modulegroup

            try
            {
                // Retrieve all Modulegroups
                ModulegroupGetAllV1Response result = apiInstance.ModulegroupGetAllV1(eContext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectModulegroupApi.ModulegroupGetAllV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModulegroupGetAllV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve all Modulegroups
    ApiResponse<ModulegroupGetAllV1Response> response = apiInstance.ModulegroupGetAllV1WithHttpInfo(eContext);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectModulegroupApi.ModulegroupGetAllV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eContext** | **string** | The context of the Modulegroup |  |

### Return type

[**ModulegroupGetAllV1Response**](ModulegroupGetAllV1Response.md)

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


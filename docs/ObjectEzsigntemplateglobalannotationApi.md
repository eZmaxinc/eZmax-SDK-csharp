# eZmaxApi.Api.ObjectEzsigntemplateglobalannotationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplateglobalannotationGetObjectV2**](ObjectEzsigntemplateglobalannotationApi.md#ezsigntemplateglobalannotationgetobjectv2) | **GET** /2/object/ezsigntemplateglobalannotation/{pkiEzsigntemplateglobalannotationID} | Retrieve an existing Ezsigntemplateglobalannotation |

<a id="ezsigntemplateglobalannotationgetobjectv2"></a>
# **EzsigntemplateglobalannotationGetObjectV2**
> EzsigntemplateglobalannotationGetObjectV2Response EzsigntemplateglobalannotationGetObjectV2 (int pkiEzsigntemplateglobalannotationID)

Retrieve an existing Ezsigntemplateglobalannotation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplateglobalannotationGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplateglobalannotationApi(config);
            var pkiEzsigntemplateglobalannotationID = 56;  // int | The unique ID of the Ezsigntemplateglobalannotation

            try
            {
                // Retrieve an existing Ezsigntemplateglobalannotation
                EzsigntemplateglobalannotationGetObjectV2Response result = apiInstance.EzsigntemplateglobalannotationGetObjectV2(pkiEzsigntemplateglobalannotationID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplateglobalannotationApi.EzsigntemplateglobalannotationGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplateglobalannotationGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplateglobalannotation
    ApiResponse<EzsigntemplateglobalannotationGetObjectV2Response> response = apiInstance.EzsigntemplateglobalannotationGetObjectV2WithHttpInfo(pkiEzsigntemplateglobalannotationID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplateglobalannotationApi.EzsigntemplateglobalannotationGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateglobalannotationID** | **int** | The unique ID of the Ezsigntemplateglobalannotation |  |

### Return type

[**EzsigntemplateglobalannotationGetObjectV2Response**](EzsigntemplateglobalannotationGetObjectV2Response.md)

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


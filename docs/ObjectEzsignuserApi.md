# eZmaxApi.Api.ObjectEzsignuserApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignuserEditObjectV1**](ObjectEzsignuserApi.md#ezsignusereditobjectv1) | **PUT** /1/object/ezsignuser/{pkiEzsignuserID} | Edit an existing Ezsignuser |
| [**EzsignuserGetObjectV2**](ObjectEzsignuserApi.md#ezsignusergetobjectv2) | **GET** /2/object/ezsignuser/{pkiEzsignuserID} | Retrieve an existing Ezsignuser |

<a id="ezsignusereditobjectv1"></a>
# **EzsignuserEditObjectV1**
> EzsignuserEditObjectV1Response EzsignuserEditObjectV1 (int pkiEzsignuserID, EzsignuserEditObjectV1Request ezsignuserEditObjectV1Request)

Edit an existing Ezsignuser

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignuserEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignuserApi(config);
            var pkiEzsignuserID = 56;  // int | The unique ID of the Ezsignuser
            var ezsignuserEditObjectV1Request = new EzsignuserEditObjectV1Request(); // EzsignuserEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsignuser
                EzsignuserEditObjectV1Response result = apiInstance.EzsignuserEditObjectV1(pkiEzsignuserID, ezsignuserEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignuserApi.EzsignuserEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignuserEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsignuser
    ApiResponse<EzsignuserEditObjectV1Response> response = apiInstance.EzsignuserEditObjectV1WithHttpInfo(pkiEzsignuserID, ezsignuserEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignuserApi.EzsignuserEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignuserID** | **int** | The unique ID of the Ezsignuser |  |
| **ezsignuserEditObjectV1Request** | [**EzsignuserEditObjectV1Request**](EzsignuserEditObjectV1Request.md) |  |  |

### Return type

[**EzsignuserEditObjectV1Response**](EzsignuserEditObjectV1Response.md)

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

<a id="ezsignusergetobjectv2"></a>
# **EzsignuserGetObjectV2**
> EzsignuserGetObjectV2Response EzsignuserGetObjectV2 (int pkiEzsignuserID)

Retrieve an existing Ezsignuser

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignuserGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignuserApi(config);
            var pkiEzsignuserID = 56;  // int | The unique ID of the Ezsignuser

            try
            {
                // Retrieve an existing Ezsignuser
                EzsignuserGetObjectV2Response result = apiInstance.EzsignuserGetObjectV2(pkiEzsignuserID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignuserApi.EzsignuserGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignuserGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignuser
    ApiResponse<EzsignuserGetObjectV2Response> response = apiInstance.EzsignuserGetObjectV2WithHttpInfo(pkiEzsignuserID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignuserApi.EzsignuserGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignuserID** | **int** | The unique ID of the Ezsignuser |  |

### Return type

[**EzsignuserGetObjectV2Response**](EzsignuserGetObjectV2Response.md)

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


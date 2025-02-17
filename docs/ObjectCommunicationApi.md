# eZmaxApi.Api.ObjectCommunicationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CommunicationGetCommunicationBodyV1**](ObjectCommunicationApi.md#communicationgetcommunicationbodyv1) | **GET** /1/object/communication/{pkiCommunicationID}/getCommunicationBody | Retrieve the communication body. |
| [**CommunicationSendV1**](ObjectCommunicationApi.md#communicationsendv1) | **POST** /1/object/communication/send | Send a new Communication |

<a id="communicationgetcommunicationbodyv1"></a>
# **CommunicationGetCommunicationBodyV1**
> void CommunicationGetCommunicationBodyV1 (int pkiCommunicationID)

Retrieve the communication body.

This endpoint returns the communication body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class CommunicationGetCommunicationBodyV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectCommunicationApi(config);
            var pkiCommunicationID = 56;  // int | 

            try
            {
                // Retrieve the communication body.
                apiInstance.CommunicationGetCommunicationBodyV1(pkiCommunicationID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectCommunicationApi.CommunicationGetCommunicationBodyV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommunicationGetCommunicationBodyV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the communication body.
    apiInstance.CommunicationGetCommunicationBodyV1WithHttpInfo(pkiCommunicationID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectCommunicationApi.CommunicationGetCommunicationBodyV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCommunicationID** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | The user has been redirected |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="communicationsendv1"></a>
# **CommunicationSendV1**
> CommunicationSendV1Response CommunicationSendV1 (CommunicationSendV1Request communicationSendV1Request)

Send a new Communication

The endpoint allows to send one or many elements at once.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class CommunicationSendV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectCommunicationApi(config);
            var communicationSendV1Request = new CommunicationSendV1Request(); // CommunicationSendV1Request | 

            try
            {
                // Send a new Communication
                CommunicationSendV1Response result = apiInstance.CommunicationSendV1(communicationSendV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectCommunicationApi.CommunicationSendV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommunicationSendV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a new Communication
    ApiResponse<CommunicationSendV1Response> response = apiInstance.CommunicationSendV1WithHttpInfo(communicationSendV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectCommunicationApi.CommunicationSendV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **communicationSendV1Request** | [**CommunicationSendV1Request**](CommunicationSendV1Request.md) |  |  |

### Return type

[**CommunicationSendV1Response**](CommunicationSendV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


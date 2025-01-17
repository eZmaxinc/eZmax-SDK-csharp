# eZmaxApi.Api.ObjectEzsigndiscussionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigndiscussionCreateObjectV1**](ObjectEzsigndiscussionApi.md#ezsigndiscussioncreateobjectv1) | **POST** /1/object/ezsigndiscussion | Create a new Ezsigndiscussion |
| [**EzsigndiscussionDeleteObjectV1**](ObjectEzsigndiscussionApi.md#ezsigndiscussiondeleteobjectv1) | **DELETE** /1/object/ezsigndiscussion/{pkiEzsigndiscussionID} | Delete an existing Ezsigndiscussion |
| [**EzsigndiscussionGetObjectV2**](ObjectEzsigndiscussionApi.md#ezsigndiscussiongetobjectv2) | **GET** /2/object/ezsigndiscussion/{pkiEzsigndiscussionID} | Retrieve an existing Ezsigndiscussion |

<a id="ezsigndiscussioncreateobjectv1"></a>
# **EzsigndiscussionCreateObjectV1**
> EzsigndiscussionCreateObjectV1Response EzsigndiscussionCreateObjectV1 (EzsigndiscussionCreateObjectV1Request ezsigndiscussionCreateObjectV1Request)

Create a new Ezsigndiscussion

The endpoint allows to create one or many elements at once.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndiscussionCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndiscussionApi(config);
            var ezsigndiscussionCreateObjectV1Request = new EzsigndiscussionCreateObjectV1Request(); // EzsigndiscussionCreateObjectV1Request | 

            try
            {
                // Create a new Ezsigndiscussion
                EzsigndiscussionCreateObjectV1Response result = apiInstance.EzsigndiscussionCreateObjectV1(ezsigndiscussionCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndiscussionApi.EzsigndiscussionCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndiscussionCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsigndiscussion
    ApiResponse<EzsigndiscussionCreateObjectV1Response> response = apiInstance.EzsigndiscussionCreateObjectV1WithHttpInfo(ezsigndiscussionCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndiscussionApi.EzsigndiscussionCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigndiscussionCreateObjectV1Request** | [**EzsigndiscussionCreateObjectV1Request**](EzsigndiscussionCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigndiscussionCreateObjectV1Response**](EzsigndiscussionCreateObjectV1Response.md)

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

<a id="ezsigndiscussiondeleteobjectv1"></a>
# **EzsigndiscussionDeleteObjectV1**
> EzsigndiscussionDeleteObjectV1Response EzsigndiscussionDeleteObjectV1 (int pkiEzsigndiscussionID)

Delete an existing Ezsigndiscussion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndiscussionDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndiscussionApi(config);
            var pkiEzsigndiscussionID = 56;  // int | The unique ID of the Ezsigndiscussion

            try
            {
                // Delete an existing Ezsigndiscussion
                EzsigndiscussionDeleteObjectV1Response result = apiInstance.EzsigndiscussionDeleteObjectV1(pkiEzsigndiscussionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndiscussionApi.EzsigndiscussionDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndiscussionDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Ezsigndiscussion
    ApiResponse<EzsigndiscussionDeleteObjectV1Response> response = apiInstance.EzsigndiscussionDeleteObjectV1WithHttpInfo(pkiEzsigndiscussionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndiscussionApi.EzsigndiscussionDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndiscussionID** | **int** | The unique ID of the Ezsigndiscussion |  |

### Return type

[**EzsigndiscussionDeleteObjectV1Response**](EzsigndiscussionDeleteObjectV1Response.md)

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

<a id="ezsigndiscussiongetobjectv2"></a>
# **EzsigndiscussionGetObjectV2**
> EzsigndiscussionGetObjectV2Response EzsigndiscussionGetObjectV2 (int pkiEzsigndiscussionID)

Retrieve an existing Ezsigndiscussion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndiscussionGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndiscussionApi(config);
            var pkiEzsigndiscussionID = 56;  // int | The unique ID of the Ezsigndiscussion

            try
            {
                // Retrieve an existing Ezsigndiscussion
                EzsigndiscussionGetObjectV2Response result = apiInstance.EzsigndiscussionGetObjectV2(pkiEzsigndiscussionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndiscussionApi.EzsigndiscussionGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndiscussionGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigndiscussion
    ApiResponse<EzsigndiscussionGetObjectV2Response> response = apiInstance.EzsigndiscussionGetObjectV2WithHttpInfo(pkiEzsigndiscussionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndiscussionApi.EzsigndiscussionGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndiscussionID** | **int** | The unique ID of the Ezsigndiscussion |  |

### Return type

[**EzsigndiscussionGetObjectV2Response**](EzsigndiscussionGetObjectV2Response.md)

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


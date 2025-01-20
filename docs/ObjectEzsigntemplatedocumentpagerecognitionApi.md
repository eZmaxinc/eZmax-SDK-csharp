# eZmaxApi.Api.ObjectEzsigntemplatedocumentpagerecognitionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplatedocumentpagerecognitionCreateObjectV1**](ObjectEzsigntemplatedocumentpagerecognitionApi.md#ezsigntemplatedocumentpagerecognitioncreateobjectv1) | **POST** /1/object/ezsigntemplatedocumentpagerecognition | Create a new Ezsigntemplatedocumentpagerecognition |
| [**EzsigntemplatedocumentpagerecognitionDeleteObjectV1**](ObjectEzsigntemplatedocumentpagerecognitionApi.md#ezsigntemplatedocumentpagerecognitiondeleteobjectv1) | **DELETE** /1/object/ezsigntemplatedocumentpagerecognition/{pkiEzsigntemplatedocumentpagerecognitionID} | Delete an existing Ezsigntemplatedocumentpagerecognition |
| [**EzsigntemplatedocumentpagerecognitionEditObjectV1**](ObjectEzsigntemplatedocumentpagerecognitionApi.md#ezsigntemplatedocumentpagerecognitioneditobjectv1) | **PUT** /1/object/ezsigntemplatedocumentpagerecognition/{pkiEzsigntemplatedocumentpagerecognitionID} | Edit an existing Ezsigntemplatedocumentpagerecognition |
| [**EzsigntemplatedocumentpagerecognitionGetObjectV2**](ObjectEzsigntemplatedocumentpagerecognitionApi.md#ezsigntemplatedocumentpagerecognitiongetobjectv2) | **GET** /2/object/ezsigntemplatedocumentpagerecognition/{pkiEzsigntemplatedocumentpagerecognitionID} | Retrieve an existing Ezsigntemplatedocumentpagerecognition |

<a id="ezsigntemplatedocumentpagerecognitioncreateobjectv1"></a>
# **EzsigntemplatedocumentpagerecognitionCreateObjectV1**
> EzsigntemplatedocumentpagerecognitionCreateObjectV1Response EzsigntemplatedocumentpagerecognitionCreateObjectV1 (EzsigntemplatedocumentpagerecognitionCreateObjectV1Request ezsigntemplatedocumentpagerecognitionCreateObjectV1Request)

Create a new Ezsigntemplatedocumentpagerecognition

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
    public class EzsigntemplatedocumentpagerecognitionCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentpagerecognitionApi(config);
            var ezsigntemplatedocumentpagerecognitionCreateObjectV1Request = new EzsigntemplatedocumentpagerecognitionCreateObjectV1Request(); // EzsigntemplatedocumentpagerecognitionCreateObjectV1Request | 

            try
            {
                // Create a new Ezsigntemplatedocumentpagerecognition
                EzsigntemplatedocumentpagerecognitionCreateObjectV1Response result = apiInstance.EzsigntemplatedocumentpagerecognitionCreateObjectV1(ezsigntemplatedocumentpagerecognitionCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentpagerecognitionApi.EzsigntemplatedocumentpagerecognitionCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentpagerecognitionCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsigntemplatedocumentpagerecognition
    ApiResponse<EzsigntemplatedocumentpagerecognitionCreateObjectV1Response> response = apiInstance.EzsigntemplatedocumentpagerecognitionCreateObjectV1WithHttpInfo(ezsigntemplatedocumentpagerecognitionCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentpagerecognitionApi.EzsigntemplatedocumentpagerecognitionCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatedocumentpagerecognitionCreateObjectV1Request** | [**EzsigntemplatedocumentpagerecognitionCreateObjectV1Request**](EzsigntemplatedocumentpagerecognitionCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatedocumentpagerecognitionCreateObjectV1Response**](EzsigntemplatedocumentpagerecognitionCreateObjectV1Response.md)

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

<a id="ezsigntemplatedocumentpagerecognitiondeleteobjectv1"></a>
# **EzsigntemplatedocumentpagerecognitionDeleteObjectV1**
> CommonResponse EzsigntemplatedocumentpagerecognitionDeleteObjectV1 (int pkiEzsigntemplatedocumentpagerecognitionID)

Delete an existing Ezsigntemplatedocumentpagerecognition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentpagerecognitionDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentpagerecognitionApi(config);
            var pkiEzsigntemplatedocumentpagerecognitionID = 56;  // int | The unique ID of the Ezsigntemplatedocumentpagerecognition

            try
            {
                // Delete an existing Ezsigntemplatedocumentpagerecognition
                CommonResponse result = apiInstance.EzsigntemplatedocumentpagerecognitionDeleteObjectV1(pkiEzsigntemplatedocumentpagerecognitionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentpagerecognitionApi.EzsigntemplatedocumentpagerecognitionDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentpagerecognitionDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Ezsigntemplatedocumentpagerecognition
    ApiResponse<CommonResponse> response = apiInstance.EzsigntemplatedocumentpagerecognitionDeleteObjectV1WithHttpInfo(pkiEzsigntemplatedocumentpagerecognitionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentpagerecognitionApi.EzsigntemplatedocumentpagerecognitionDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentpagerecognitionID** | **int** | The unique ID of the Ezsigntemplatedocumentpagerecognition |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

<a id="ezsigntemplatedocumentpagerecognitioneditobjectv1"></a>
# **EzsigntemplatedocumentpagerecognitionEditObjectV1**
> CommonResponse EzsigntemplatedocumentpagerecognitionEditObjectV1 (int pkiEzsigntemplatedocumentpagerecognitionID, EzsigntemplatedocumentpagerecognitionEditObjectV1Request ezsigntemplatedocumentpagerecognitionEditObjectV1Request)

Edit an existing Ezsigntemplatedocumentpagerecognition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentpagerecognitionEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentpagerecognitionApi(config);
            var pkiEzsigntemplatedocumentpagerecognitionID = 56;  // int | The unique ID of the Ezsigntemplatedocumentpagerecognition
            var ezsigntemplatedocumentpagerecognitionEditObjectV1Request = new EzsigntemplatedocumentpagerecognitionEditObjectV1Request(); // EzsigntemplatedocumentpagerecognitionEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsigntemplatedocumentpagerecognition
                CommonResponse result = apiInstance.EzsigntemplatedocumentpagerecognitionEditObjectV1(pkiEzsigntemplatedocumentpagerecognitionID, ezsigntemplatedocumentpagerecognitionEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentpagerecognitionApi.EzsigntemplatedocumentpagerecognitionEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentpagerecognitionEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsigntemplatedocumentpagerecognition
    ApiResponse<CommonResponse> response = apiInstance.EzsigntemplatedocumentpagerecognitionEditObjectV1WithHttpInfo(pkiEzsigntemplatedocumentpagerecognitionID, ezsigntemplatedocumentpagerecognitionEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentpagerecognitionApi.EzsigntemplatedocumentpagerecognitionEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentpagerecognitionID** | **int** | The unique ID of the Ezsigntemplatedocumentpagerecognition |  |
| **ezsigntemplatedocumentpagerecognitionEditObjectV1Request** | [**EzsigntemplatedocumentpagerecognitionEditObjectV1Request**](EzsigntemplatedocumentpagerecognitionEditObjectV1Request.md) |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

<a id="ezsigntemplatedocumentpagerecognitiongetobjectv2"></a>
# **EzsigntemplatedocumentpagerecognitionGetObjectV2**
> EzsigntemplatedocumentpagerecognitionGetObjectV2Response EzsigntemplatedocumentpagerecognitionGetObjectV2 (int pkiEzsigntemplatedocumentpagerecognitionID)

Retrieve an existing Ezsigntemplatedocumentpagerecognition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentpagerecognitionGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentpagerecognitionApi(config);
            var pkiEzsigntemplatedocumentpagerecognitionID = 56;  // int | The unique ID of the Ezsigntemplatedocumentpagerecognition

            try
            {
                // Retrieve an existing Ezsigntemplatedocumentpagerecognition
                EzsigntemplatedocumentpagerecognitionGetObjectV2Response result = apiInstance.EzsigntemplatedocumentpagerecognitionGetObjectV2(pkiEzsigntemplatedocumentpagerecognitionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentpagerecognitionApi.EzsigntemplatedocumentpagerecognitionGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentpagerecognitionGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatedocumentpagerecognition
    ApiResponse<EzsigntemplatedocumentpagerecognitionGetObjectV2Response> response = apiInstance.EzsigntemplatedocumentpagerecognitionGetObjectV2WithHttpInfo(pkiEzsigntemplatedocumentpagerecognitionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentpagerecognitionApi.EzsigntemplatedocumentpagerecognitionGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentpagerecognitionID** | **int** | The unique ID of the Ezsigntemplatedocumentpagerecognition |  |

### Return type

[**EzsigntemplatedocumentpagerecognitionGetObjectV2Response**](EzsigntemplatedocumentpagerecognitionGetObjectV2Response.md)

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


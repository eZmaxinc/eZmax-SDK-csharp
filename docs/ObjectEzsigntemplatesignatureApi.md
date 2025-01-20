# eZmaxApi.Api.ObjectEzsigntemplatesignatureApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplatesignatureCreateObjectV2**](ObjectEzsigntemplatesignatureApi.md#ezsigntemplatesignaturecreateobjectv2) | **POST** /2/object/ezsigntemplatesignature | Create a new Ezsigntemplatesignature |
| [**EzsigntemplatesignatureDeleteObjectV1**](ObjectEzsigntemplatesignatureApi.md#ezsigntemplatesignaturedeleteobjectv1) | **DELETE** /1/object/ezsigntemplatesignature/{pkiEzsigntemplatesignatureID} | Delete an existing Ezsigntemplatesignature |
| [**EzsigntemplatesignatureEditObjectV2**](ObjectEzsigntemplatesignatureApi.md#ezsigntemplatesignatureeditobjectv2) | **PUT** /2/object/ezsigntemplatesignature/{pkiEzsigntemplatesignatureID} | Edit an existing Ezsigntemplatesignature |
| [**EzsigntemplatesignatureGetObjectV3**](ObjectEzsigntemplatesignatureApi.md#ezsigntemplatesignaturegetobjectv3) | **GET** /3/object/ezsigntemplatesignature/{pkiEzsigntemplatesignatureID} | Retrieve an existing Ezsigntemplatesignature |

<a id="ezsigntemplatesignaturecreateobjectv2"></a>
# **EzsigntemplatesignatureCreateObjectV2**
> EzsigntemplatesignatureCreateObjectV2Response EzsigntemplatesignatureCreateObjectV2 (EzsigntemplatesignatureCreateObjectV2Request ezsigntemplatesignatureCreateObjectV2Request)

Create a new Ezsigntemplatesignature

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
    public class EzsigntemplatesignatureCreateObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatesignatureApi(config);
            var ezsigntemplatesignatureCreateObjectV2Request = new EzsigntemplatesignatureCreateObjectV2Request(); // EzsigntemplatesignatureCreateObjectV2Request | 

            try
            {
                // Create a new Ezsigntemplatesignature
                EzsigntemplatesignatureCreateObjectV2Response result = apiInstance.EzsigntemplatesignatureCreateObjectV2(ezsigntemplatesignatureCreateObjectV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureCreateObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignatureCreateObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsigntemplatesignature
    ApiResponse<EzsigntemplatesignatureCreateObjectV2Response> response = apiInstance.EzsigntemplatesignatureCreateObjectV2WithHttpInfo(ezsigntemplatesignatureCreateObjectV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureCreateObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatesignatureCreateObjectV2Request** | [**EzsigntemplatesignatureCreateObjectV2Request**](EzsigntemplatesignatureCreateObjectV2Request.md) |  |  |

### Return type

[**EzsigntemplatesignatureCreateObjectV2Response**](EzsigntemplatesignatureCreateObjectV2Response.md)

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

<a id="ezsigntemplatesignaturedeleteobjectv1"></a>
# **EzsigntemplatesignatureDeleteObjectV1**
> CommonResponse EzsigntemplatesignatureDeleteObjectV1 (int pkiEzsigntemplatesignatureID)

Delete an existing Ezsigntemplatesignature

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatesignatureDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatesignatureApi(config);
            var pkiEzsigntemplatesignatureID = 56;  // int | 

            try
            {
                // Delete an existing Ezsigntemplatesignature
                CommonResponse result = apiInstance.EzsigntemplatesignatureDeleteObjectV1(pkiEzsigntemplatesignatureID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignatureDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Ezsigntemplatesignature
    ApiResponse<CommonResponse> response = apiInstance.EzsigntemplatesignatureDeleteObjectV1WithHttpInfo(pkiEzsigntemplatesignatureID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatesignatureID** | **int** |  |  |

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

<a id="ezsigntemplatesignatureeditobjectv2"></a>
# **EzsigntemplatesignatureEditObjectV2**
> CommonResponse EzsigntemplatesignatureEditObjectV2 (int pkiEzsigntemplatesignatureID, EzsigntemplatesignatureEditObjectV2Request ezsigntemplatesignatureEditObjectV2Request)

Edit an existing Ezsigntemplatesignature

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatesignatureEditObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatesignatureApi(config);
            var pkiEzsigntemplatesignatureID = 56;  // int | 
            var ezsigntemplatesignatureEditObjectV2Request = new EzsigntemplatesignatureEditObjectV2Request(); // EzsigntemplatesignatureEditObjectV2Request | 

            try
            {
                // Edit an existing Ezsigntemplatesignature
                CommonResponse result = apiInstance.EzsigntemplatesignatureEditObjectV2(pkiEzsigntemplatesignatureID, ezsigntemplatesignatureEditObjectV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureEditObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignatureEditObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsigntemplatesignature
    ApiResponse<CommonResponse> response = apiInstance.EzsigntemplatesignatureEditObjectV2WithHttpInfo(pkiEzsigntemplatesignatureID, ezsigntemplatesignatureEditObjectV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureEditObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatesignatureID** | **int** |  |  |
| **ezsigntemplatesignatureEditObjectV2Request** | [**EzsigntemplatesignatureEditObjectV2Request**](EzsigntemplatesignatureEditObjectV2Request.md) |  |  |

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

<a id="ezsigntemplatesignaturegetobjectv3"></a>
# **EzsigntemplatesignatureGetObjectV3**
> EzsigntemplatesignatureGetObjectV3Response EzsigntemplatesignatureGetObjectV3 (int pkiEzsigntemplatesignatureID)

Retrieve an existing Ezsigntemplatesignature

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatesignatureGetObjectV3Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatesignatureApi(config);
            var pkiEzsigntemplatesignatureID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplatesignature
                EzsigntemplatesignatureGetObjectV3Response result = apiInstance.EzsigntemplatesignatureGetObjectV3(pkiEzsigntemplatesignatureID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureGetObjectV3: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignatureGetObjectV3WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatesignature
    ApiResponse<EzsigntemplatesignatureGetObjectV3Response> response = apiInstance.EzsigntemplatesignatureGetObjectV3WithHttpInfo(pkiEzsigntemplatesignatureID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureGetObjectV3WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatesignatureID** | **int** |  |  |

### Return type

[**EzsigntemplatesignatureGetObjectV3Response**](EzsigntemplatesignatureGetObjectV3Response.md)

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


# eZmaxApi.Api.ObjectEzsigntemplatesignatureApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplatesignatureCreateObjectV1**](ObjectEzsigntemplatesignatureApi.md#ezsigntemplatesignaturecreateobjectv1) | **POST** /1/object/ezsigntemplatesignature | Create a new Ezsigntemplatesignature |
| [**EzsigntemplatesignatureDeleteObjectV1**](ObjectEzsigntemplatesignatureApi.md#ezsigntemplatesignaturedeleteobjectv1) | **DELETE** /1/object/ezsigntemplatesignature/{pkiEzsigntemplatesignatureID} | Delete an existing Ezsigntemplatesignature |
| [**EzsigntemplatesignatureEditObjectV1**](ObjectEzsigntemplatesignatureApi.md#ezsigntemplatesignatureeditobjectv1) | **PUT** /1/object/ezsigntemplatesignature/{pkiEzsigntemplatesignatureID} | Edit an existing Ezsigntemplatesignature |
| [**EzsigntemplatesignatureGetObjectV2**](ObjectEzsigntemplatesignatureApi.md#ezsigntemplatesignaturegetobjectv2) | **GET** /2/object/ezsigntemplatesignature/{pkiEzsigntemplatesignatureID} | Retrieve an existing Ezsigntemplatesignature |

<a id="ezsigntemplatesignaturecreateobjectv1"></a>
# **EzsigntemplatesignatureCreateObjectV1**
> EzsigntemplatesignatureCreateObjectV1Response EzsigntemplatesignatureCreateObjectV1 (EzsigntemplatesignatureCreateObjectV1Request ezsigntemplatesignatureCreateObjectV1Request)

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
    public class EzsigntemplatesignatureCreateObjectV1Example
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
            var ezsigntemplatesignatureCreateObjectV1Request = new EzsigntemplatesignatureCreateObjectV1Request(); // EzsigntemplatesignatureCreateObjectV1Request | 

            try
            {
                // Create a new Ezsigntemplatesignature
                EzsigntemplatesignatureCreateObjectV1Response result = apiInstance.EzsigntemplatesignatureCreateObjectV1(ezsigntemplatesignatureCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignatureCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsigntemplatesignature
    ApiResponse<EzsigntemplatesignatureCreateObjectV1Response> response = apiInstance.EzsigntemplatesignatureCreateObjectV1WithHttpInfo(ezsigntemplatesignatureCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatesignatureCreateObjectV1Request** | [**EzsigntemplatesignatureCreateObjectV1Request**](EzsigntemplatesignatureCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatesignatureCreateObjectV1Response**](EzsigntemplatesignatureCreateObjectV1Response.md)

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
> EzsigntemplatesignatureDeleteObjectV1Response EzsigntemplatesignatureDeleteObjectV1 (int pkiEzsigntemplatesignatureID)

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
                EzsigntemplatesignatureDeleteObjectV1Response result = apiInstance.EzsigntemplatesignatureDeleteObjectV1(pkiEzsigntemplatesignatureID);
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
    ApiResponse<EzsigntemplatesignatureDeleteObjectV1Response> response = apiInstance.EzsigntemplatesignatureDeleteObjectV1WithHttpInfo(pkiEzsigntemplatesignatureID);
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

[**EzsigntemplatesignatureDeleteObjectV1Response**](EzsigntemplatesignatureDeleteObjectV1Response.md)

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

<a id="ezsigntemplatesignatureeditobjectv1"></a>
# **EzsigntemplatesignatureEditObjectV1**
> EzsigntemplatesignatureEditObjectV1Response EzsigntemplatesignatureEditObjectV1 (int pkiEzsigntemplatesignatureID, EzsigntemplatesignatureEditObjectV1Request ezsigntemplatesignatureEditObjectV1Request)

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
    public class EzsigntemplatesignatureEditObjectV1Example
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
            var ezsigntemplatesignatureEditObjectV1Request = new EzsigntemplatesignatureEditObjectV1Request(); // EzsigntemplatesignatureEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsigntemplatesignature
                EzsigntemplatesignatureEditObjectV1Response result = apiInstance.EzsigntemplatesignatureEditObjectV1(pkiEzsigntemplatesignatureID, ezsigntemplatesignatureEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignatureEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsigntemplatesignature
    ApiResponse<EzsigntemplatesignatureEditObjectV1Response> response = apiInstance.EzsigntemplatesignatureEditObjectV1WithHttpInfo(pkiEzsigntemplatesignatureID, ezsigntemplatesignatureEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatesignatureID** | **int** |  |  |
| **ezsigntemplatesignatureEditObjectV1Request** | [**EzsigntemplatesignatureEditObjectV1Request**](EzsigntemplatesignatureEditObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatesignatureEditObjectV1Response**](EzsigntemplatesignatureEditObjectV1Response.md)

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

<a id="ezsigntemplatesignaturegetobjectv2"></a>
# **EzsigntemplatesignatureGetObjectV2**
> EzsigntemplatesignatureGetObjectV2Response EzsigntemplatesignatureGetObjectV2 (int pkiEzsigntemplatesignatureID)

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
    public class EzsigntemplatesignatureGetObjectV2Example
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
                EzsigntemplatesignatureGetObjectV2Response result = apiInstance.EzsigntemplatesignatureGetObjectV2(pkiEzsigntemplatesignatureID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignatureGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatesignature
    ApiResponse<EzsigntemplatesignatureGetObjectV2Response> response = apiInstance.EzsigntemplatesignatureGetObjectV2WithHttpInfo(pkiEzsigntemplatesignatureID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignatureApi.EzsigntemplatesignatureGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatesignatureID** | **int** |  |  |

### Return type

[**EzsigntemplatesignatureGetObjectV2Response**](EzsigntemplatesignatureGetObjectV2Response.md)

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


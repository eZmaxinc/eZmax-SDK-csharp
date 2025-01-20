# eZmaxApi.Api.ObjectEzsignbulksendsignermappingApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignbulksendsignermappingCreateObjectV1**](ObjectEzsignbulksendsignermappingApi.md#ezsignbulksendsignermappingcreateobjectv1) | **POST** /1/object/ezsignbulksendsignermapping | Create a new Ezsignbulksendsignermapping |
| [**EzsignbulksendsignermappingDeleteObjectV1**](ObjectEzsignbulksendsignermappingApi.md#ezsignbulksendsignermappingdeleteobjectv1) | **DELETE** /1/object/ezsignbulksendsignermapping/{pkiEzsignbulksendsignermappingID} | Delete an existing Ezsignbulksendsignermapping |
| [**EzsignbulksendsignermappingGetObjectV2**](ObjectEzsignbulksendsignermappingApi.md#ezsignbulksendsignermappinggetobjectv2) | **GET** /2/object/ezsignbulksendsignermapping/{pkiEzsignbulksendsignermappingID} | Retrieve an existing Ezsignbulksendsignermapping |

<a id="ezsignbulksendsignermappingcreateobjectv1"></a>
# **EzsignbulksendsignermappingCreateObjectV1**
> EzsignbulksendsignermappingCreateObjectV1Response EzsignbulksendsignermappingCreateObjectV1 (EzsignbulksendsignermappingCreateObjectV1Request ezsignbulksendsignermappingCreateObjectV1Request)

Create a new Ezsignbulksendsignermapping

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
    public class EzsignbulksendsignermappingCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendsignermappingApi(config);
            var ezsignbulksendsignermappingCreateObjectV1Request = new EzsignbulksendsignermappingCreateObjectV1Request(); // EzsignbulksendsignermappingCreateObjectV1Request | 

            try
            {
                // Create a new Ezsignbulksendsignermapping
                EzsignbulksendsignermappingCreateObjectV1Response result = apiInstance.EzsignbulksendsignermappingCreateObjectV1(ezsignbulksendsignermappingCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendsignermappingApi.EzsignbulksendsignermappingCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendsignermappingCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsignbulksendsignermapping
    ApiResponse<EzsignbulksendsignermappingCreateObjectV1Response> response = apiInstance.EzsignbulksendsignermappingCreateObjectV1WithHttpInfo(ezsignbulksendsignermappingCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendsignermappingApi.EzsignbulksendsignermappingCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignbulksendsignermappingCreateObjectV1Request** | [**EzsignbulksendsignermappingCreateObjectV1Request**](EzsignbulksendsignermappingCreateObjectV1Request.md) |  |  |

### Return type

[**EzsignbulksendsignermappingCreateObjectV1Response**](EzsignbulksendsignermappingCreateObjectV1Response.md)

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

<a id="ezsignbulksendsignermappingdeleteobjectv1"></a>
# **EzsignbulksendsignermappingDeleteObjectV1**
> CommonResponse EzsignbulksendsignermappingDeleteObjectV1 (int pkiEzsignbulksendsignermappingID)

Delete an existing Ezsignbulksendsignermapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendsignermappingDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendsignermappingApi(config);
            var pkiEzsignbulksendsignermappingID = 56;  // int | 

            try
            {
                // Delete an existing Ezsignbulksendsignermapping
                CommonResponse result = apiInstance.EzsignbulksendsignermappingDeleteObjectV1(pkiEzsignbulksendsignermappingID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendsignermappingApi.EzsignbulksendsignermappingDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendsignermappingDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Ezsignbulksendsignermapping
    ApiResponse<CommonResponse> response = apiInstance.EzsignbulksendsignermappingDeleteObjectV1WithHttpInfo(pkiEzsignbulksendsignermappingID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendsignermappingApi.EzsignbulksendsignermappingDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendsignermappingID** | **int** |  |  |

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

<a id="ezsignbulksendsignermappinggetobjectv2"></a>
# **EzsignbulksendsignermappingGetObjectV2**
> EzsignbulksendsignermappingGetObjectV2Response EzsignbulksendsignermappingGetObjectV2 (int pkiEzsignbulksendsignermappingID)

Retrieve an existing Ezsignbulksendsignermapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendsignermappingGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendsignermappingApi(config);
            var pkiEzsignbulksendsignermappingID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignbulksendsignermapping
                EzsignbulksendsignermappingGetObjectV2Response result = apiInstance.EzsignbulksendsignermappingGetObjectV2(pkiEzsignbulksendsignermappingID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendsignermappingApi.EzsignbulksendsignermappingGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendsignermappingGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignbulksendsignermapping
    ApiResponse<EzsignbulksendsignermappingGetObjectV2Response> response = apiInstance.EzsignbulksendsignermappingGetObjectV2WithHttpInfo(pkiEzsignbulksendsignermappingID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendsignermappingApi.EzsignbulksendsignermappingGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendsignermappingID** | **int** |  |  |

### Return type

[**EzsignbulksendsignermappingGetObjectV2Response**](EzsignbulksendsignermappingGetObjectV2Response.md)

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


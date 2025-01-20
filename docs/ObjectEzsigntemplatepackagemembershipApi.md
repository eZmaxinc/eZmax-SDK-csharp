# eZmaxApi.Api.ObjectEzsigntemplatepackagemembershipApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplatepackagemembershipCreateObjectV1**](ObjectEzsigntemplatepackagemembershipApi.md#ezsigntemplatepackagemembershipcreateobjectv1) | **POST** /1/object/ezsigntemplatepackagemembership | Create a new Ezsigntemplatepackagemembership |
| [**EzsigntemplatepackagemembershipDeleteObjectV1**](ObjectEzsigntemplatepackagemembershipApi.md#ezsigntemplatepackagemembershipdeleteobjectv1) | **DELETE** /1/object/ezsigntemplatepackagemembership/{pkiEzsigntemplatepackagemembershipID} | Delete an existing Ezsigntemplatepackagemembership |
| [**EzsigntemplatepackagemembershipGetObjectV2**](ObjectEzsigntemplatepackagemembershipApi.md#ezsigntemplatepackagemembershipgetobjectv2) | **GET** /2/object/ezsigntemplatepackagemembership/{pkiEzsigntemplatepackagemembershipID} | Retrieve an existing Ezsigntemplatepackagemembership |

<a id="ezsigntemplatepackagemembershipcreateobjectv1"></a>
# **EzsigntemplatepackagemembershipCreateObjectV1**
> EzsigntemplatepackagemembershipCreateObjectV1Response EzsigntemplatepackagemembershipCreateObjectV1 (EzsigntemplatepackagemembershipCreateObjectV1Request ezsigntemplatepackagemembershipCreateObjectV1Request)

Create a new Ezsigntemplatepackagemembership

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
    public class EzsigntemplatepackagemembershipCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepackagemembershipApi(config);
            var ezsigntemplatepackagemembershipCreateObjectV1Request = new EzsigntemplatepackagemembershipCreateObjectV1Request(); // EzsigntemplatepackagemembershipCreateObjectV1Request | 

            try
            {
                // Create a new Ezsigntemplatepackagemembership
                EzsigntemplatepackagemembershipCreateObjectV1Response result = apiInstance.EzsigntemplatepackagemembershipCreateObjectV1(ezsigntemplatepackagemembershipCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepackagemembershipApi.EzsigntemplatepackagemembershipCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatepackagemembershipCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsigntemplatepackagemembership
    ApiResponse<EzsigntemplatepackagemembershipCreateObjectV1Response> response = apiInstance.EzsigntemplatepackagemembershipCreateObjectV1WithHttpInfo(ezsigntemplatepackagemembershipCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatepackagemembershipApi.EzsigntemplatepackagemembershipCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatepackagemembershipCreateObjectV1Request** | [**EzsigntemplatepackagemembershipCreateObjectV1Request**](EzsigntemplatepackagemembershipCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatepackagemembershipCreateObjectV1Response**](EzsigntemplatepackagemembershipCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigntemplatepackagemembershipdeleteobjectv1"></a>
# **EzsigntemplatepackagemembershipDeleteObjectV1**
> CommonResponse EzsigntemplatepackagemembershipDeleteObjectV1 (int pkiEzsigntemplatepackagemembershipID)

Delete an existing Ezsigntemplatepackagemembership

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepackagemembershipDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepackagemembershipApi(config);
            var pkiEzsigntemplatepackagemembershipID = 56;  // int | 

            try
            {
                // Delete an existing Ezsigntemplatepackagemembership
                CommonResponse result = apiInstance.EzsigntemplatepackagemembershipDeleteObjectV1(pkiEzsigntemplatepackagemembershipID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepackagemembershipApi.EzsigntemplatepackagemembershipDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatepackagemembershipDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Ezsigntemplatepackagemembership
    ApiResponse<CommonResponse> response = apiInstance.EzsigntemplatepackagemembershipDeleteObjectV1WithHttpInfo(pkiEzsigntemplatepackagemembershipID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatepackagemembershipApi.EzsigntemplatepackagemembershipDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepackagemembershipID** | **int** |  |  |

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

<a id="ezsigntemplatepackagemembershipgetobjectv2"></a>
# **EzsigntemplatepackagemembershipGetObjectV2**
> EzsigntemplatepackagemembershipGetObjectV2Response EzsigntemplatepackagemembershipGetObjectV2 (int pkiEzsigntemplatepackagemembershipID)

Retrieve an existing Ezsigntemplatepackagemembership

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepackagemembershipGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepackagemembershipApi(config);
            var pkiEzsigntemplatepackagemembershipID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplatepackagemembership
                EzsigntemplatepackagemembershipGetObjectV2Response result = apiInstance.EzsigntemplatepackagemembershipGetObjectV2(pkiEzsigntemplatepackagemembershipID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepackagemembershipApi.EzsigntemplatepackagemembershipGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatepackagemembershipGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatepackagemembership
    ApiResponse<EzsigntemplatepackagemembershipGetObjectV2Response> response = apiInstance.EzsigntemplatepackagemembershipGetObjectV2WithHttpInfo(pkiEzsigntemplatepackagemembershipID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatepackagemembershipApi.EzsigntemplatepackagemembershipGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepackagemembershipID** | **int** |  |  |

### Return type

[**EzsigntemplatepackagemembershipGetObjectV2Response**](EzsigntemplatepackagemembershipGetObjectV2Response.md)

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


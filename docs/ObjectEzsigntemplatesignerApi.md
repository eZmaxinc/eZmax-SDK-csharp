# eZmaxApi.Api.ObjectEzsigntemplatesignerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplatesignerCreateObjectV1**](ObjectEzsigntemplatesignerApi.md#ezsigntemplatesignercreateobjectv1) | **POST** /1/object/ezsigntemplatesigner | Create a new Ezsigntemplatesigner |
| [**EzsigntemplatesignerCreateObjectV2**](ObjectEzsigntemplatesignerApi.md#ezsigntemplatesignercreateobjectv2) | **POST** /2/object/ezsigntemplatesigner | Create a new Ezsigntemplatesigner |
| [**EzsigntemplatesignerDeleteObjectV1**](ObjectEzsigntemplatesignerApi.md#ezsigntemplatesignerdeleteobjectv1) | **DELETE** /1/object/ezsigntemplatesigner/{pkiEzsigntemplatesignerID} | Delete an existing Ezsigntemplatesigner |
| [**EzsigntemplatesignerEditObjectV1**](ObjectEzsigntemplatesignerApi.md#ezsigntemplatesignereditobjectv1) | **PUT** /1/object/ezsigntemplatesigner/{pkiEzsigntemplatesignerID} | Edit an existing Ezsigntemplatesigner |
| [**EzsigntemplatesignerEditObjectV2**](ObjectEzsigntemplatesignerApi.md#ezsigntemplatesignereditobjectv2) | **PUT** /2/object/ezsigntemplatesigner/{pkiEzsigntemplatesignerID} | Edit an existing Ezsigntemplatesigner |
| [**EzsigntemplatesignerGetObjectV2**](ObjectEzsigntemplatesignerApi.md#ezsigntemplatesignergetobjectv2) | **GET** /2/object/ezsigntemplatesigner/{pkiEzsigntemplatesignerID} | Retrieve an existing Ezsigntemplatesigner |
| [**EzsigntemplatesignerGetObjectV3**](ObjectEzsigntemplatesignerApi.md#ezsigntemplatesignergetobjectv3) | **GET** /3/object/ezsigntemplatesigner/{pkiEzsigntemplatesignerID} | Retrieve an existing Ezsigntemplatesigner |

<a id="ezsigntemplatesignercreateobjectv1"></a>
# **EzsigntemplatesignerCreateObjectV1**
> EzsigntemplatesignerCreateObjectV1Response EzsigntemplatesignerCreateObjectV1 (EzsigntemplatesignerCreateObjectV1Request ezsigntemplatesignerCreateObjectV1Request)

Create a new Ezsigntemplatesigner

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
    public class EzsigntemplatesignerCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatesignerApi(config);
            var ezsigntemplatesignerCreateObjectV1Request = new EzsigntemplatesignerCreateObjectV1Request(); // EzsigntemplatesignerCreateObjectV1Request | 

            try
            {
                // Create a new Ezsigntemplatesigner
                EzsigntemplatesignerCreateObjectV1Response result = apiInstance.EzsigntemplatesignerCreateObjectV1(ezsigntemplatesignerCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignerCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsigntemplatesigner
    ApiResponse<EzsigntemplatesignerCreateObjectV1Response> response = apiInstance.EzsigntemplatesignerCreateObjectV1WithHttpInfo(ezsigntemplatesignerCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatesignerCreateObjectV1Request** | [**EzsigntemplatesignerCreateObjectV1Request**](EzsigntemplatesignerCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatesignerCreateObjectV1Response**](EzsigntemplatesignerCreateObjectV1Response.md)

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

<a id="ezsigntemplatesignercreateobjectv2"></a>
# **EzsigntemplatesignerCreateObjectV2**
> EzsigntemplatesignerCreateObjectV2Response EzsigntemplatesignerCreateObjectV2 (EzsigntemplatesignerCreateObjectV2Request ezsigntemplatesignerCreateObjectV2Request)

Create a new Ezsigntemplatesigner

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
    public class EzsigntemplatesignerCreateObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatesignerApi(config);
            var ezsigntemplatesignerCreateObjectV2Request = new EzsigntemplatesignerCreateObjectV2Request(); // EzsigntemplatesignerCreateObjectV2Request | 

            try
            {
                // Create a new Ezsigntemplatesigner
                EzsigntemplatesignerCreateObjectV2Response result = apiInstance.EzsigntemplatesignerCreateObjectV2(ezsigntemplatesignerCreateObjectV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerCreateObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignerCreateObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsigntemplatesigner
    ApiResponse<EzsigntemplatesignerCreateObjectV2Response> response = apiInstance.EzsigntemplatesignerCreateObjectV2WithHttpInfo(ezsigntemplatesignerCreateObjectV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerCreateObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatesignerCreateObjectV2Request** | [**EzsigntemplatesignerCreateObjectV2Request**](EzsigntemplatesignerCreateObjectV2Request.md) |  |  |

### Return type

[**EzsigntemplatesignerCreateObjectV2Response**](EzsigntemplatesignerCreateObjectV2Response.md)

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

<a id="ezsigntemplatesignerdeleteobjectv1"></a>
# **EzsigntemplatesignerDeleteObjectV1**
> EzsigntemplatesignerDeleteObjectV1Response EzsigntemplatesignerDeleteObjectV1 (int pkiEzsigntemplatesignerID)

Delete an existing Ezsigntemplatesigner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatesignerDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatesignerApi(config);
            var pkiEzsigntemplatesignerID = 56;  // int | 

            try
            {
                // Delete an existing Ezsigntemplatesigner
                EzsigntemplatesignerDeleteObjectV1Response result = apiInstance.EzsigntemplatesignerDeleteObjectV1(pkiEzsigntemplatesignerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignerDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Ezsigntemplatesigner
    ApiResponse<EzsigntemplatesignerDeleteObjectV1Response> response = apiInstance.EzsigntemplatesignerDeleteObjectV1WithHttpInfo(pkiEzsigntemplatesignerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatesignerID** | **int** |  |  |

### Return type

[**EzsigntemplatesignerDeleteObjectV1Response**](EzsigntemplatesignerDeleteObjectV1Response.md)

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

<a id="ezsigntemplatesignereditobjectv1"></a>
# **EzsigntemplatesignerEditObjectV1**
> EzsigntemplatesignerEditObjectV1Response EzsigntemplatesignerEditObjectV1 (int pkiEzsigntemplatesignerID, EzsigntemplatesignerEditObjectV1Request ezsigntemplatesignerEditObjectV1Request)

Edit an existing Ezsigntemplatesigner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatesignerEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatesignerApi(config);
            var pkiEzsigntemplatesignerID = 56;  // int | 
            var ezsigntemplatesignerEditObjectV1Request = new EzsigntemplatesignerEditObjectV1Request(); // EzsigntemplatesignerEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsigntemplatesigner
                EzsigntemplatesignerEditObjectV1Response result = apiInstance.EzsigntemplatesignerEditObjectV1(pkiEzsigntemplatesignerID, ezsigntemplatesignerEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignerEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsigntemplatesigner
    ApiResponse<EzsigntemplatesignerEditObjectV1Response> response = apiInstance.EzsigntemplatesignerEditObjectV1WithHttpInfo(pkiEzsigntemplatesignerID, ezsigntemplatesignerEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatesignerID** | **int** |  |  |
| **ezsigntemplatesignerEditObjectV1Request** | [**EzsigntemplatesignerEditObjectV1Request**](EzsigntemplatesignerEditObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatesignerEditObjectV1Response**](EzsigntemplatesignerEditObjectV1Response.md)

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

<a id="ezsigntemplatesignereditobjectv2"></a>
# **EzsigntemplatesignerEditObjectV2**
> EzsigntemplatesignerEditObjectV2Response EzsigntemplatesignerEditObjectV2 (int pkiEzsigntemplatesignerID, EzsigntemplatesignerEditObjectV2Request ezsigntemplatesignerEditObjectV2Request)

Edit an existing Ezsigntemplatesigner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatesignerEditObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatesignerApi(config);
            var pkiEzsigntemplatesignerID = 56;  // int | 
            var ezsigntemplatesignerEditObjectV2Request = new EzsigntemplatesignerEditObjectV2Request(); // EzsigntemplatesignerEditObjectV2Request | 

            try
            {
                // Edit an existing Ezsigntemplatesigner
                EzsigntemplatesignerEditObjectV2Response result = apiInstance.EzsigntemplatesignerEditObjectV2(pkiEzsigntemplatesignerID, ezsigntemplatesignerEditObjectV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerEditObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignerEditObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsigntemplatesigner
    ApiResponse<EzsigntemplatesignerEditObjectV2Response> response = apiInstance.EzsigntemplatesignerEditObjectV2WithHttpInfo(pkiEzsigntemplatesignerID, ezsigntemplatesignerEditObjectV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerEditObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatesignerID** | **int** |  |  |
| **ezsigntemplatesignerEditObjectV2Request** | [**EzsigntemplatesignerEditObjectV2Request**](EzsigntemplatesignerEditObjectV2Request.md) |  |  |

### Return type

[**EzsigntemplatesignerEditObjectV2Response**](EzsigntemplatesignerEditObjectV2Response.md)

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

<a id="ezsigntemplatesignergetobjectv2"></a>
# **EzsigntemplatesignerGetObjectV2**
> EzsigntemplatesignerGetObjectV2Response EzsigntemplatesignerGetObjectV2 (int pkiEzsigntemplatesignerID)

Retrieve an existing Ezsigntemplatesigner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatesignerGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatesignerApi(config);
            var pkiEzsigntemplatesignerID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplatesigner
                EzsigntemplatesignerGetObjectV2Response result = apiInstance.EzsigntemplatesignerGetObjectV2(pkiEzsigntemplatesignerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignerGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatesigner
    ApiResponse<EzsigntemplatesignerGetObjectV2Response> response = apiInstance.EzsigntemplatesignerGetObjectV2WithHttpInfo(pkiEzsigntemplatesignerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatesignerID** | **int** |  |  |

### Return type

[**EzsigntemplatesignerGetObjectV2Response**](EzsigntemplatesignerGetObjectV2Response.md)

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

<a id="ezsigntemplatesignergetobjectv3"></a>
# **EzsigntemplatesignerGetObjectV3**
> EzsigntemplatesignerGetObjectV3Response EzsigntemplatesignerGetObjectV3 (int pkiEzsigntemplatesignerID)

Retrieve an existing Ezsigntemplatesigner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatesignerGetObjectV3Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatesignerApi(config);
            var pkiEzsigntemplatesignerID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplatesigner
                EzsigntemplatesignerGetObjectV3Response result = apiInstance.EzsigntemplatesignerGetObjectV3(pkiEzsigntemplatesignerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerGetObjectV3: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatesignerGetObjectV3WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatesigner
    ApiResponse<EzsigntemplatesignerGetObjectV3Response> response = apiInstance.EzsigntemplatesignerGetObjectV3WithHttpInfo(pkiEzsigntemplatesignerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatesignerApi.EzsigntemplatesignerGetObjectV3WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatesignerID** | **int** |  |  |

### Return type

[**EzsigntemplatesignerGetObjectV3Response**](EzsigntemplatesignerGetObjectV3Response.md)

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


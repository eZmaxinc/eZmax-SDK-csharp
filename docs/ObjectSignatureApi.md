# eZmaxApi.Api.ObjectSignatureApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SignatureCreateObjectV1**](ObjectSignatureApi.md#signaturecreateobjectv1) | **POST** /1/object/signature | Create a new Signature |
| [**SignatureDeleteObjectV1**](ObjectSignatureApi.md#signaturedeleteobjectv1) | **DELETE** /1/object/signature/{pkiSignatureID} | Delete an existing Signature |
| [**SignatureEditObjectV1**](ObjectSignatureApi.md#signatureeditobjectv1) | **PUT** /1/object/signature/{pkiSignatureID} | Edit an existing Signature |
| [**SignatureGetObjectV2**](ObjectSignatureApi.md#signaturegetobjectv2) | **GET** /2/object/signature/{pkiSignatureID} | Retrieve an existing Signature |

<a id="signaturecreateobjectv1"></a>
# **SignatureCreateObjectV1**
> SignatureCreateObjectV1Response SignatureCreateObjectV1 (SignatureCreateObjectV1Request signatureCreateObjectV1Request)

Create a new Signature

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
    public class SignatureCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectSignatureApi(config);
            var signatureCreateObjectV1Request = new SignatureCreateObjectV1Request(); // SignatureCreateObjectV1Request | 

            try
            {
                // Create a new Signature
                SignatureCreateObjectV1Response result = apiInstance.SignatureCreateObjectV1(signatureCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectSignatureApi.SignatureCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignatureCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Signature
    ApiResponse<SignatureCreateObjectV1Response> response = apiInstance.SignatureCreateObjectV1WithHttpInfo(signatureCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectSignatureApi.SignatureCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureCreateObjectV1Request** | [**SignatureCreateObjectV1Request**](SignatureCreateObjectV1Request.md) |  |  |

### Return type

[**SignatureCreateObjectV1Response**](SignatureCreateObjectV1Response.md)

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

<a id="signaturedeleteobjectv1"></a>
# **SignatureDeleteObjectV1**
> SignatureDeleteObjectV1Response SignatureDeleteObjectV1 (int pkiSignatureID)

Delete an existing Signature

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class SignatureDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectSignatureApi(config);
            var pkiSignatureID = 56;  // int | The unique ID of the Signature

            try
            {
                // Delete an existing Signature
                SignatureDeleteObjectV1Response result = apiInstance.SignatureDeleteObjectV1(pkiSignatureID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectSignatureApi.SignatureDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignatureDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Signature
    ApiResponse<SignatureDeleteObjectV1Response> response = apiInstance.SignatureDeleteObjectV1WithHttpInfo(pkiSignatureID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectSignatureApi.SignatureDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSignatureID** | **int** | The unique ID of the Signature |  |

### Return type

[**SignatureDeleteObjectV1Response**](SignatureDeleteObjectV1Response.md)

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

<a id="signatureeditobjectv1"></a>
# **SignatureEditObjectV1**
> SignatureEditObjectV1Response SignatureEditObjectV1 (int pkiSignatureID, SignatureEditObjectV1Request signatureEditObjectV1Request)

Edit an existing Signature

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class SignatureEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectSignatureApi(config);
            var pkiSignatureID = 56;  // int | The unique ID of the Signature
            var signatureEditObjectV1Request = new SignatureEditObjectV1Request(); // SignatureEditObjectV1Request | 

            try
            {
                // Edit an existing Signature
                SignatureEditObjectV1Response result = apiInstance.SignatureEditObjectV1(pkiSignatureID, signatureEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectSignatureApi.SignatureEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignatureEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Signature
    ApiResponse<SignatureEditObjectV1Response> response = apiInstance.SignatureEditObjectV1WithHttpInfo(pkiSignatureID, signatureEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectSignatureApi.SignatureEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSignatureID** | **int** | The unique ID of the Signature |  |
| **signatureEditObjectV1Request** | [**SignatureEditObjectV1Request**](SignatureEditObjectV1Request.md) |  |  |

### Return type

[**SignatureEditObjectV1Response**](SignatureEditObjectV1Response.md)

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

<a id="signaturegetobjectv2"></a>
# **SignatureGetObjectV2**
> SignatureGetObjectV2Response SignatureGetObjectV2 (int pkiSignatureID)

Retrieve an existing Signature

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class SignatureGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectSignatureApi(config);
            var pkiSignatureID = 56;  // int | The unique ID of the Signature

            try
            {
                // Retrieve an existing Signature
                SignatureGetObjectV2Response result = apiInstance.SignatureGetObjectV2(pkiSignatureID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectSignatureApi.SignatureGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignatureGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Signature
    ApiResponse<SignatureGetObjectV2Response> response = apiInstance.SignatureGetObjectV2WithHttpInfo(pkiSignatureID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectSignatureApi.SignatureGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSignatureID** | **int** | The unique ID of the Signature |  |

### Return type

[**SignatureGetObjectV2Response**](SignatureGetObjectV2Response.md)

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


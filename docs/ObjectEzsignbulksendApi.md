# eZmaxApi.Api.ObjectEzsignbulksendApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignbulksendCreateEzsignbulksendtransmissionV2**](ObjectEzsignbulksendApi.md#ezsignbulksendcreateezsignbulksendtransmissionv2) | **POST** /2/object/ezsignbulksend/{pkiEzsignbulksendID}/createEzsignbulksendtransmission | Create a new Ezsignbulksendtransmission in the Ezsignbulksend |
| [**EzsignbulksendCreateObjectV1**](ObjectEzsignbulksendApi.md#ezsignbulksendcreateobjectv1) | **POST** /1/object/ezsignbulksend | Create a new Ezsignbulksend |
| [**EzsignbulksendDeleteObjectV1**](ObjectEzsignbulksendApi.md#ezsignbulksenddeleteobjectv1) | **DELETE** /1/object/ezsignbulksend/{pkiEzsignbulksendID} | Delete an existing Ezsignbulksend |
| [**EzsignbulksendEditObjectV1**](ObjectEzsignbulksendApi.md#ezsignbulksendeditobjectv1) | **PUT** /1/object/ezsignbulksend/{pkiEzsignbulksendID} | Edit an existing Ezsignbulksend |
| [**EzsignbulksendGetCsvTemplateV1**](ObjectEzsignbulksendApi.md#ezsignbulksendgetcsvtemplatev1) | **GET** /1/object/ezsignbulksend/{pkiEzsignbulksendID}/getCsvTemplate | Retrieve an existing Ezsignbulksend&#39;s empty Csv template |
| [**EzsignbulksendGetEzsignbulksendtransmissionsV1**](ObjectEzsignbulksendApi.md#ezsignbulksendgetezsignbulksendtransmissionsv1) | **GET** /1/object/ezsignbulksend/{pkiEzsignbulksendID}/getEzsignbulksendtransmissions | Retrieve an existing Ezsignbulksend&#39;s Ezsignbulksendtransmissions |
| [**EzsignbulksendGetEzsignsignaturesAutomaticV1**](ObjectEzsignbulksendApi.md#ezsignbulksendgetezsignsignaturesautomaticv1) | **GET** /1/object/ezsignbulksend/{pkiEzsignbulksendID}/getEzsignsignaturesAutomatic | Retrieve an existing Ezsignbulksend&#39;s automatic Ezsignsignatures |
| [**EzsignbulksendGetFormsDataV1**](ObjectEzsignbulksendApi.md#ezsignbulksendgetformsdatav1) | **GET** /1/object/ezsignbulksend/{pkiEzsignbulksendID}/getFormsData | Retrieve an existing Ezsignbulksend&#39;s forms data |
| [**EzsignbulksendGetListV1**](ObjectEzsignbulksendApi.md#ezsignbulksendgetlistv1) | **GET** /1/object/ezsignbulksend/getList | Retrieve Ezsignbulksend list |
| [**EzsignbulksendGetObjectV2**](ObjectEzsignbulksendApi.md#ezsignbulksendgetobjectv2) | **GET** /2/object/ezsignbulksend/{pkiEzsignbulksendID} | Retrieve an existing Ezsignbulksend |
| [**EzsignbulksendReorderV1**](ObjectEzsignbulksendApi.md#ezsignbulksendreorderv1) | **POST** /1/object/ezsignbulksend/{pkiEzsignbulksendID}/reorder | Reorder Ezsignbulksenddocumentmappings in the Ezsignbulksend |

<a id="ezsignbulksendcreateezsignbulksendtransmissionv2"></a>
# **EzsignbulksendCreateEzsignbulksendtransmissionV2**
> EzsignbulksendCreateEzsignbulksendtransmissionV2Response EzsignbulksendCreateEzsignbulksendtransmissionV2 (int pkiEzsignbulksendID, EzsignbulksendCreateEzsignbulksendtransmissionV2Request ezsignbulksendCreateEzsignbulksendtransmissionV2Request)

Create a new Ezsignbulksendtransmission in the Ezsignbulksend

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendCreateEzsignbulksendtransmissionV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendApi(config);
            var pkiEzsignbulksendID = 56;  // int | 
            var ezsignbulksendCreateEzsignbulksendtransmissionV2Request = new EzsignbulksendCreateEzsignbulksendtransmissionV2Request(); // EzsignbulksendCreateEzsignbulksendtransmissionV2Request | 

            try
            {
                // Create a new Ezsignbulksendtransmission in the Ezsignbulksend
                EzsignbulksendCreateEzsignbulksendtransmissionV2Response result = apiInstance.EzsignbulksendCreateEzsignbulksendtransmissionV2(pkiEzsignbulksendID, ezsignbulksendCreateEzsignbulksendtransmissionV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendCreateEzsignbulksendtransmissionV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendCreateEzsignbulksendtransmissionV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsignbulksendtransmission in the Ezsignbulksend
    ApiResponse<EzsignbulksendCreateEzsignbulksendtransmissionV2Response> response = apiInstance.EzsignbulksendCreateEzsignbulksendtransmissionV2WithHttpInfo(pkiEzsignbulksendID, ezsignbulksendCreateEzsignbulksendtransmissionV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendCreateEzsignbulksendtransmissionV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |
| **ezsignbulksendCreateEzsignbulksendtransmissionV2Request** | [**EzsignbulksendCreateEzsignbulksendtransmissionV2Request**](EzsignbulksendCreateEzsignbulksendtransmissionV2Request.md) |  |  |

### Return type

[**EzsignbulksendCreateEzsignbulksendtransmissionV2Response**](EzsignbulksendCreateEzsignbulksendtransmissionV2Response.md)

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

<a id="ezsignbulksendcreateobjectv1"></a>
# **EzsignbulksendCreateObjectV1**
> EzsignbulksendCreateObjectV1Response EzsignbulksendCreateObjectV1 (EzsignbulksendCreateObjectV1Request ezsignbulksendCreateObjectV1Request)

Create a new Ezsignbulksend

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
    public class EzsignbulksendCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendApi(config);
            var ezsignbulksendCreateObjectV1Request = new EzsignbulksendCreateObjectV1Request(); // EzsignbulksendCreateObjectV1Request | 

            try
            {
                // Create a new Ezsignbulksend
                EzsignbulksendCreateObjectV1Response result = apiInstance.EzsignbulksendCreateObjectV1(ezsignbulksendCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsignbulksend
    ApiResponse<EzsignbulksendCreateObjectV1Response> response = apiInstance.EzsignbulksendCreateObjectV1WithHttpInfo(ezsignbulksendCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignbulksendCreateObjectV1Request** | [**EzsignbulksendCreateObjectV1Request**](EzsignbulksendCreateObjectV1Request.md) |  |  |

### Return type

[**EzsignbulksendCreateObjectV1Response**](EzsignbulksendCreateObjectV1Response.md)

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

<a id="ezsignbulksenddeleteobjectv1"></a>
# **EzsignbulksendDeleteObjectV1**
> EzsignbulksendDeleteObjectV1Response EzsignbulksendDeleteObjectV1 (int pkiEzsignbulksendID)

Delete an existing Ezsignbulksend

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendApi(config);
            var pkiEzsignbulksendID = 56;  // int | 

            try
            {
                // Delete an existing Ezsignbulksend
                EzsignbulksendDeleteObjectV1Response result = apiInstance.EzsignbulksendDeleteObjectV1(pkiEzsignbulksendID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Ezsignbulksend
    ApiResponse<EzsignbulksendDeleteObjectV1Response> response = apiInstance.EzsignbulksendDeleteObjectV1WithHttpInfo(pkiEzsignbulksendID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |

### Return type

[**EzsignbulksendDeleteObjectV1Response**](EzsignbulksendDeleteObjectV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignbulksendeditobjectv1"></a>
# **EzsignbulksendEditObjectV1**
> EzsignbulksendEditObjectV1Response EzsignbulksendEditObjectV1 (int pkiEzsignbulksendID, EzsignbulksendEditObjectV1Request ezsignbulksendEditObjectV1Request)

Edit an existing Ezsignbulksend

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendApi(config);
            var pkiEzsignbulksendID = 56;  // int | 
            var ezsignbulksendEditObjectV1Request = new EzsignbulksendEditObjectV1Request(); // EzsignbulksendEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsignbulksend
                EzsignbulksendEditObjectV1Response result = apiInstance.EzsignbulksendEditObjectV1(pkiEzsignbulksendID, ezsignbulksendEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsignbulksend
    ApiResponse<EzsignbulksendEditObjectV1Response> response = apiInstance.EzsignbulksendEditObjectV1WithHttpInfo(pkiEzsignbulksendID, ezsignbulksendEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |
| **ezsignbulksendEditObjectV1Request** | [**EzsignbulksendEditObjectV1Request**](EzsignbulksendEditObjectV1Request.md) |  |  |

### Return type

[**EzsignbulksendEditObjectV1Response**](EzsignbulksendEditObjectV1Response.md)

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

<a id="ezsignbulksendgetcsvtemplatev1"></a>
# **EzsignbulksendGetCsvTemplateV1**
> string EzsignbulksendGetCsvTemplateV1 (int pkiEzsignbulksendID, string eCsvSeparator)

Retrieve an existing Ezsignbulksend's empty Csv template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendGetCsvTemplateV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendApi(config);
            var pkiEzsignbulksendID = 56;  // int | 
            var eCsvSeparator = "Comma";  // string | Separator that will be used to separate fields

            try
            {
                // Retrieve an existing Ezsignbulksend's empty Csv template
                string result = apiInstance.EzsignbulksendGetCsvTemplateV1(pkiEzsignbulksendID, eCsvSeparator);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendGetCsvTemplateV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendGetCsvTemplateV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignbulksend's empty Csv template
    ApiResponse<string> response = apiInstance.EzsignbulksendGetCsvTemplateV1WithHttpInfo(pkiEzsignbulksendID, eCsvSeparator);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendGetCsvTemplateV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |
| **eCsvSeparator** | **string** | Separator that will be used to separate fields |  |

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignbulksendgetezsignbulksendtransmissionsv1"></a>
# **EzsignbulksendGetEzsignbulksendtransmissionsV1**
> EzsignbulksendGetEzsignbulksendtransmissionsV1Response EzsignbulksendGetEzsignbulksendtransmissionsV1 (int pkiEzsignbulksendID)

Retrieve an existing Ezsignbulksend's Ezsignbulksendtransmissions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendGetEzsignbulksendtransmissionsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendApi(config);
            var pkiEzsignbulksendID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignbulksend's Ezsignbulksendtransmissions
                EzsignbulksendGetEzsignbulksendtransmissionsV1Response result = apiInstance.EzsignbulksendGetEzsignbulksendtransmissionsV1(pkiEzsignbulksendID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendGetEzsignbulksendtransmissionsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendGetEzsignbulksendtransmissionsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignbulksend's Ezsignbulksendtransmissions
    ApiResponse<EzsignbulksendGetEzsignbulksendtransmissionsV1Response> response = apiInstance.EzsignbulksendGetEzsignbulksendtransmissionsV1WithHttpInfo(pkiEzsignbulksendID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendGetEzsignbulksendtransmissionsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |

### Return type

[**EzsignbulksendGetEzsignbulksendtransmissionsV1Response**](EzsignbulksendGetEzsignbulksendtransmissionsV1Response.md)

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

<a id="ezsignbulksendgetezsignsignaturesautomaticv1"></a>
# **EzsignbulksendGetEzsignsignaturesAutomaticV1**
> EzsignbulksendGetEzsignsignaturesAutomaticV1Response EzsignbulksendGetEzsignsignaturesAutomaticV1 (int pkiEzsignbulksendID)

Retrieve an existing Ezsignbulksend's automatic Ezsignsignatures

Return the Ezsignsignatures that can be signed by the current user at the current step in the process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendGetEzsignsignaturesAutomaticV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendApi(config);
            var pkiEzsignbulksendID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignbulksend's automatic Ezsignsignatures
                EzsignbulksendGetEzsignsignaturesAutomaticV1Response result = apiInstance.EzsignbulksendGetEzsignsignaturesAutomaticV1(pkiEzsignbulksendID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendGetEzsignsignaturesAutomaticV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendGetEzsignsignaturesAutomaticV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignbulksend's automatic Ezsignsignatures
    ApiResponse<EzsignbulksendGetEzsignsignaturesAutomaticV1Response> response = apiInstance.EzsignbulksendGetEzsignsignaturesAutomaticV1WithHttpInfo(pkiEzsignbulksendID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendGetEzsignsignaturesAutomaticV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |

### Return type

[**EzsignbulksendGetEzsignsignaturesAutomaticV1Response**](EzsignbulksendGetEzsignsignaturesAutomaticV1Response.md)

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

<a id="ezsignbulksendgetformsdatav1"></a>
# **EzsignbulksendGetFormsDataV1**
> EzsignbulksendGetFormsDataV1Response EzsignbulksendGetFormsDataV1 (int pkiEzsignbulksendID)

Retrieve an existing Ezsignbulksend's forms data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendGetFormsDataV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendApi(config);
            var pkiEzsignbulksendID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignbulksend's forms data
                EzsignbulksendGetFormsDataV1Response result = apiInstance.EzsignbulksendGetFormsDataV1(pkiEzsignbulksendID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendGetFormsDataV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendGetFormsDataV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignbulksend's forms data
    ApiResponse<EzsignbulksendGetFormsDataV1Response> response = apiInstance.EzsignbulksendGetFormsDataV1WithHttpInfo(pkiEzsignbulksendID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendGetFormsDataV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |

### Return type

[**EzsignbulksendGetFormsDataV1Response**](EzsignbulksendGetFormsDataV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/zip


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignbulksendgetlistv1"></a>
# **EzsignbulksendGetListV1**
> EzsignbulksendGetListV1Response EzsignbulksendGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Ezsignbulksend list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eEzsignfoldertypePrivacylevel | User<br>Usergroup |

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendApi(config);
            var eOrderBy = "pkiEzsignbulksendID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Ezsignbulksend list
                EzsignbulksendGetListV1Response result = apiInstance.EzsignbulksendGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsignbulksend list
    ApiResponse<EzsignbulksendGetListV1Response> response = apiInstance.EzsignbulksendGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendGetListV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string?** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int?** |  | [optional]  |
| **iRowOffset** | **int?** |  | [optional] [default to 0] |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |
| **sFilter** | **string?** |  | [optional]  |

### Return type

[**EzsignbulksendGetListV1Response**](EzsignbulksendGetListV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignbulksendgetobjectv2"></a>
# **EzsignbulksendGetObjectV2**
> EzsignbulksendGetObjectV2Response EzsignbulksendGetObjectV2 (int pkiEzsignbulksendID)

Retrieve an existing Ezsignbulksend

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendApi(config);
            var pkiEzsignbulksendID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignbulksend
                EzsignbulksendGetObjectV2Response result = apiInstance.EzsignbulksendGetObjectV2(pkiEzsignbulksendID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignbulksend
    ApiResponse<EzsignbulksendGetObjectV2Response> response = apiInstance.EzsignbulksendGetObjectV2WithHttpInfo(pkiEzsignbulksendID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |

### Return type

[**EzsignbulksendGetObjectV2Response**](EzsignbulksendGetObjectV2Response.md)

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

<a id="ezsignbulksendreorderv1"></a>
# **EzsignbulksendReorderV1**
> EzsignbulksendReorderV1Response EzsignbulksendReorderV1 (int pkiEzsignbulksendID, EzsignbulksendReorderV1Request ezsignbulksendReorderV1Request)

Reorder Ezsignbulksenddocumentmappings in the Ezsignbulksend

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendReorderV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendApi(config);
            var pkiEzsignbulksendID = 56;  // int | 
            var ezsignbulksendReorderV1Request = new EzsignbulksendReorderV1Request(); // EzsignbulksendReorderV1Request | 

            try
            {
                // Reorder Ezsignbulksenddocumentmappings in the Ezsignbulksend
                EzsignbulksendReorderV1Response result = apiInstance.EzsignbulksendReorderV1(pkiEzsignbulksendID, ezsignbulksendReorderV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendReorderV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignbulksendReorderV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reorder Ezsignbulksenddocumentmappings in the Ezsignbulksend
    ApiResponse<EzsignbulksendReorderV1Response> response = apiInstance.EzsignbulksendReorderV1WithHttpInfo(pkiEzsignbulksendID, ezsignbulksendReorderV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignbulksendApi.EzsignbulksendReorderV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |
| **ezsignbulksendReorderV1Request** | [**EzsignbulksendReorderV1Request**](EzsignbulksendReorderV1Request.md) |  |  |

### Return type

[**EzsignbulksendReorderV1Response**](EzsignbulksendReorderV1Response.md)

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


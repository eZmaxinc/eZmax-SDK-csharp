# eZmaxApi.Api.ObjectEzsigntemplatedocumentApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplatedocumentCreateObjectV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentcreateobjectv1) | **POST** /1/object/ezsigntemplatedocument | Create a new Ezsigntemplatedocument |
| [**EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumenteditezsigntemplateformfieldgroupsv1) | **PUT** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/editEzsigntemplateformfieldgroups | Edit multiple Ezsigntemplateformfieldgroups |
| [**EzsigntemplatedocumentEditEzsigntemplatesignaturesV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumenteditezsigntemplatesignaturesv1) | **PUT** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/editEzsigntemplatesignatures | Edit multiple Ezsigntemplatesignatures |
| [**EzsigntemplatedocumentEditObjectV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumenteditobjectv1) | **PUT** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID} | Edit an existing Ezsigntemplatedocument |
| [**EzsigntemplatedocumentFlattenV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentflattenv1) | **POST** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/flatten | Flatten |
| [**EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentgetezsigntemplatedocumentpagesv1) | **GET** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/getEzsigntemplatedocumentpages | Retrieve an existing Ezsigntemplatedocument&#39;s Ezsigntemplatedocumentpages |
| [**EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentgetezsigntemplateformfieldgroupsv1) | **GET** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/getEzsigntemplateformfieldgroups | Retrieve an existing Ezsigntemplatedocument&#39;s Ezsigntemplateformfieldgroups |
| [**EzsigntemplatedocumentGetEzsigntemplatesignaturesV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentgetezsigntemplatesignaturesv1) | **GET** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/getEzsigntemplatesignatures | Retrieve an existing Ezsigntemplatedocument&#39;s Ezsigntemplatesignatures |
| [**EzsigntemplatedocumentGetObjectV2**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentgetobjectv2) | **GET** /2/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID} | Retrieve an existing Ezsigntemplatedocument |
| [**EzsigntemplatedocumentGetWordsPositionsV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentgetwordspositionsv1) | **POST** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/getWordsPositions | Retrieve positions X,Y of given words from a Ezsigntemplatedocument |
| [**EzsigntemplatedocumentPatchObjectV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentpatchobjectv1) | **PATCH** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID} | Patch an existing Ezsigntemplatedocument |

<a id="ezsigntemplatedocumentcreateobjectv1"></a>
# **EzsigntemplatedocumentCreateObjectV1**
> EzsigntemplatedocumentCreateObjectV1Response EzsigntemplatedocumentCreateObjectV1 (EzsigntemplatedocumentCreateObjectV1Request ezsigntemplatedocumentCreateObjectV1Request)

Create a new Ezsigntemplatedocument

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
    public class EzsigntemplatedocumentCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentApi(config);
            var ezsigntemplatedocumentCreateObjectV1Request = new EzsigntemplatedocumentCreateObjectV1Request(); // EzsigntemplatedocumentCreateObjectV1Request | 

            try
            {
                // Create a new Ezsigntemplatedocument
                EzsigntemplatedocumentCreateObjectV1Response result = apiInstance.EzsigntemplatedocumentCreateObjectV1(ezsigntemplatedocumentCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsigntemplatedocument
    ApiResponse<EzsigntemplatedocumentCreateObjectV1Response> response = apiInstance.EzsigntemplatedocumentCreateObjectV1WithHttpInfo(ezsigntemplatedocumentCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatedocumentCreateObjectV1Request** | [**EzsigntemplatedocumentCreateObjectV1Request**](EzsigntemplatedocumentCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatedocumentCreateObjectV1Response**](EzsigntemplatedocumentCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **413** | The request was large. Look for detail about the error in the body |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. If the error is recoverable sTemporaryFileUrl will be set and you can use this url to try a new request without sending the file over again |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigntemplatedocumenteditezsigntemplateformfieldgroupsv1"></a>
# **EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1**
> EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Response EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1 (int pkiEzsigntemplatedocumentID, EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Request ezsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Request)

Edit multiple Ezsigntemplateformfieldgroups

Using this endpoint, you can edit multiple Ezsigntemplateformfieldgroups at the same time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentApi(config);
            var pkiEzsigntemplatedocumentID = 56;  // int | 
            var ezsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Request = new EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Request(); // EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Request | 

            try
            {
                // Edit multiple Ezsigntemplateformfieldgroups
                EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Response result = apiInstance.EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit multiple Ezsigntemplateformfieldgroups
    ApiResponse<EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Response> response = apiInstance.EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1WithHttpInfo(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |
| **ezsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Request** | [**EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Request**](EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Request.md) |  |  |

### Return type

[**EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Response**](EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1Response.md)

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

<a id="ezsigntemplatedocumenteditezsigntemplatesignaturesv1"></a>
# **EzsigntemplatedocumentEditEzsigntemplatesignaturesV1**
> EzsigntemplatedocumentEditEzsigntemplatesignaturesV1Response EzsigntemplatedocumentEditEzsigntemplatesignaturesV1 (int pkiEzsigntemplatedocumentID, EzsigntemplatedocumentEditEzsigntemplatesignaturesV1Request ezsigntemplatedocumentEditEzsigntemplatesignaturesV1Request)

Edit multiple Ezsigntemplatesignatures

Using this endpoint, you can edit multiple Ezsigntemplatesignatures at the same time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentEditEzsigntemplatesignaturesV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentApi(config);
            var pkiEzsigntemplatedocumentID = 56;  // int | 
            var ezsigntemplatedocumentEditEzsigntemplatesignaturesV1Request = new EzsigntemplatedocumentEditEzsigntemplatesignaturesV1Request(); // EzsigntemplatedocumentEditEzsigntemplatesignaturesV1Request | 

            try
            {
                // Edit multiple Ezsigntemplatesignatures
                EzsigntemplatedocumentEditEzsigntemplatesignaturesV1Response result = apiInstance.EzsigntemplatedocumentEditEzsigntemplatesignaturesV1(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentEditEzsigntemplatesignaturesV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentEditEzsigntemplatesignaturesV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentEditEzsigntemplatesignaturesV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit multiple Ezsigntemplatesignatures
    ApiResponse<EzsigntemplatedocumentEditEzsigntemplatesignaturesV1Response> response = apiInstance.EzsigntemplatedocumentEditEzsigntemplatesignaturesV1WithHttpInfo(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentEditEzsigntemplatesignaturesV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentEditEzsigntemplatesignaturesV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |
| **ezsigntemplatedocumentEditEzsigntemplatesignaturesV1Request** | [**EzsigntemplatedocumentEditEzsigntemplatesignaturesV1Request**](EzsigntemplatedocumentEditEzsigntemplatesignaturesV1Request.md) |  |  |

### Return type

[**EzsigntemplatedocumentEditEzsigntemplatesignaturesV1Response**](EzsigntemplatedocumentEditEzsigntemplatesignaturesV1Response.md)

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

<a id="ezsigntemplatedocumenteditobjectv1"></a>
# **EzsigntemplatedocumentEditObjectV1**
> EzsigntemplatedocumentEditObjectV1Response EzsigntemplatedocumentEditObjectV1 (int pkiEzsigntemplatedocumentID, EzsigntemplatedocumentEditObjectV1Request ezsigntemplatedocumentEditObjectV1Request)

Edit an existing Ezsigntemplatedocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentApi(config);
            var pkiEzsigntemplatedocumentID = 56;  // int | 
            var ezsigntemplatedocumentEditObjectV1Request = new EzsigntemplatedocumentEditObjectV1Request(); // EzsigntemplatedocumentEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsigntemplatedocument
                EzsigntemplatedocumentEditObjectV1Response result = apiInstance.EzsigntemplatedocumentEditObjectV1(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsigntemplatedocument
    ApiResponse<EzsigntemplatedocumentEditObjectV1Response> response = apiInstance.EzsigntemplatedocumentEditObjectV1WithHttpInfo(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |
| **ezsigntemplatedocumentEditObjectV1Request** | [**EzsigntemplatedocumentEditObjectV1Request**](EzsigntemplatedocumentEditObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatedocumentEditObjectV1Response**](EzsigntemplatedocumentEditObjectV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. If the error is recoverable sTemporaryFileUrl will be set and you can use this url to try a new request without sending the file over again |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigntemplatedocumentflattenv1"></a>
# **EzsigntemplatedocumentFlattenV1**
> EzsigntemplatedocumentFlattenV1Response EzsigntemplatedocumentFlattenV1 (int pkiEzsigntemplatedocumentID, Object body)

Flatten

Flatten an Ezsigntemplatedocument signatures, forms and annotations. This process finalizes the PDF so that the forms and annotations become part of the document content and cannot be edited.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentFlattenV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentApi(config);
            var pkiEzsigntemplatedocumentID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Flatten
                EzsigntemplatedocumentFlattenV1Response result = apiInstance.EzsigntemplatedocumentFlattenV1(pkiEzsigntemplatedocumentID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentFlattenV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentFlattenV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Flatten
    ApiResponse<EzsigntemplatedocumentFlattenV1Response> response = apiInstance.EzsigntemplatedocumentFlattenV1WithHttpInfo(pkiEzsigntemplatedocumentID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentFlattenV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsigntemplatedocumentFlattenV1Response**](EzsigntemplatedocumentFlattenV1Response.md)

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

<a id="ezsigntemplatedocumentgetezsigntemplatedocumentpagesv1"></a>
# **EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1**
> EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1Response EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1 (int pkiEzsigntemplatedocumentID)

Retrieve an existing Ezsigntemplatedocument's Ezsigntemplatedocumentpages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentApi(config);
            var pkiEzsigntemplatedocumentID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplatedocument's Ezsigntemplatedocumentpages
                EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1Response result = apiInstance.EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1(pkiEzsigntemplatedocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatedocument's Ezsigntemplatedocumentpages
    ApiResponse<EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1Response> response = apiInstance.EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1WithHttpInfo(pkiEzsigntemplatedocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |

### Return type

[**EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1Response**](EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1Response.md)

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

<a id="ezsigntemplatedocumentgetezsigntemplateformfieldgroupsv1"></a>
# **EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1**
> EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1Response EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1 (int pkiEzsigntemplatedocumentID)

Retrieve an existing Ezsigntemplatedocument's Ezsigntemplateformfieldgroups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentApi(config);
            var pkiEzsigntemplatedocumentID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplatedocument's Ezsigntemplateformfieldgroups
                EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1Response result = apiInstance.EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1(pkiEzsigntemplatedocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatedocument's Ezsigntemplateformfieldgroups
    ApiResponse<EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1Response> response = apiInstance.EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1WithHttpInfo(pkiEzsigntemplatedocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |

### Return type

[**EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1Response**](EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1Response.md)

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

<a id="ezsigntemplatedocumentgetezsigntemplatesignaturesv1"></a>
# **EzsigntemplatedocumentGetEzsigntemplatesignaturesV1**
> EzsigntemplatedocumentGetEzsigntemplatesignaturesV1Response EzsigntemplatedocumentGetEzsigntemplatesignaturesV1 (int pkiEzsigntemplatedocumentID)

Retrieve an existing Ezsigntemplatedocument's Ezsigntemplatesignatures

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentGetEzsigntemplatesignaturesV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentApi(config);
            var pkiEzsigntemplatedocumentID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplatedocument's Ezsigntemplatesignatures
                EzsigntemplatedocumentGetEzsigntemplatesignaturesV1Response result = apiInstance.EzsigntemplatedocumentGetEzsigntemplatesignaturesV1(pkiEzsigntemplatedocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetEzsigntemplatesignaturesV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentGetEzsigntemplatesignaturesV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatedocument's Ezsigntemplatesignatures
    ApiResponse<EzsigntemplatedocumentGetEzsigntemplatesignaturesV1Response> response = apiInstance.EzsigntemplatedocumentGetEzsigntemplatesignaturesV1WithHttpInfo(pkiEzsigntemplatedocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetEzsigntemplatesignaturesV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |

### Return type

[**EzsigntemplatedocumentGetEzsigntemplatesignaturesV1Response**](EzsigntemplatedocumentGetEzsigntemplatesignaturesV1Response.md)

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

<a id="ezsigntemplatedocumentgetobjectv2"></a>
# **EzsigntemplatedocumentGetObjectV2**
> EzsigntemplatedocumentGetObjectV2Response EzsigntemplatedocumentGetObjectV2 (int pkiEzsigntemplatedocumentID)

Retrieve an existing Ezsigntemplatedocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentApi(config);
            var pkiEzsigntemplatedocumentID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplatedocument
                EzsigntemplatedocumentGetObjectV2Response result = apiInstance.EzsigntemplatedocumentGetObjectV2(pkiEzsigntemplatedocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatedocument
    ApiResponse<EzsigntemplatedocumentGetObjectV2Response> response = apiInstance.EzsigntemplatedocumentGetObjectV2WithHttpInfo(pkiEzsigntemplatedocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |

### Return type

[**EzsigntemplatedocumentGetObjectV2Response**](EzsigntemplatedocumentGetObjectV2Response.md)

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

<a id="ezsigntemplatedocumentgetwordspositionsv1"></a>
# **EzsigntemplatedocumentGetWordsPositionsV1**
> EzsigntemplatedocumentGetWordsPositionsV1Response EzsigntemplatedocumentGetWordsPositionsV1 (int pkiEzsigntemplatedocumentID, EzsigntemplatedocumentGetWordsPositionsV1Request ezsigntemplatedocumentGetWordsPositionsV1Request)

Retrieve positions X,Y of given words from a Ezsigntemplatedocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentGetWordsPositionsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentApi(config);
            var pkiEzsigntemplatedocumentID = 56;  // int | 
            var ezsigntemplatedocumentGetWordsPositionsV1Request = new EzsigntemplatedocumentGetWordsPositionsV1Request(); // EzsigntemplatedocumentGetWordsPositionsV1Request | 

            try
            {
                // Retrieve positions X,Y of given words from a Ezsigntemplatedocument
                EzsigntemplatedocumentGetWordsPositionsV1Response result = apiInstance.EzsigntemplatedocumentGetWordsPositionsV1(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentGetWordsPositionsV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetWordsPositionsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentGetWordsPositionsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve positions X,Y of given words from a Ezsigntemplatedocument
    ApiResponse<EzsigntemplatedocumentGetWordsPositionsV1Response> response = apiInstance.EzsigntemplatedocumentGetWordsPositionsV1WithHttpInfo(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentGetWordsPositionsV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetWordsPositionsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |
| **ezsigntemplatedocumentGetWordsPositionsV1Request** | [**EzsigntemplatedocumentGetWordsPositionsV1Request**](EzsigntemplatedocumentGetWordsPositionsV1Request.md) |  |  |

### Return type

[**EzsigntemplatedocumentGetWordsPositionsV1Response**](EzsigntemplatedocumentGetWordsPositionsV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigntemplatedocumentpatchobjectv1"></a>
# **EzsigntemplatedocumentPatchObjectV1**
> EzsigntemplatedocumentPatchObjectV1Response EzsigntemplatedocumentPatchObjectV1 (int pkiEzsigntemplatedocumentID, EzsigntemplatedocumentPatchObjectV1Request ezsigntemplatedocumentPatchObjectV1Request)

Patch an existing Ezsigntemplatedocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentPatchObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatedocumentApi(config);
            var pkiEzsigntemplatedocumentID = 56;  // int | 
            var ezsigntemplatedocumentPatchObjectV1Request = new EzsigntemplatedocumentPatchObjectV1Request(); // EzsigntemplatedocumentPatchObjectV1Request | 

            try
            {
                // Patch an existing Ezsigntemplatedocument
                EzsigntemplatedocumentPatchObjectV1Response result = apiInstance.EzsigntemplatedocumentPatchObjectV1(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentPatchObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentPatchObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentPatchObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patch an existing Ezsigntemplatedocument
    ApiResponse<EzsigntemplatedocumentPatchObjectV1Response> response = apiInstance.EzsigntemplatedocumentPatchObjectV1WithHttpInfo(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentPatchObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentPatchObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |
| **ezsigntemplatedocumentPatchObjectV1Request** | [**EzsigntemplatedocumentPatchObjectV1Request**](EzsigntemplatedocumentPatchObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatedocumentPatchObjectV1Response**](EzsigntemplatedocumentPatchObjectV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# eZmaxApi.Api.ObjectEzsigntemplatedocumentApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplatedocumentCreateObjectV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentcreateobjectv1) | **POST** /1/object/ezsigntemplatedocument | Create a new Ezsigntemplatedocument |
| [**EzsigntemplatedocumentDownloadV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentdownloadv1) | **GET** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/download | Retrieve an existing Ezsigntemplatedocument&#39;s original file |
| [**EzsigntemplatedocumentEditEzsigntemplateannotationsV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumenteditezsigntemplateannotationsv1) | **PUT** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/editEzsigntemplateannotations | Edit multiple Ezsigntemplateannotations |
| [**EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumenteditezsigntemplatedocumentpagerecognitionsv1) | **PUT** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/editEzsigntemplatedocumentpagerecognitions | Edit multiple Ezsigntemplatedocumentpagerecognitions |
| [**EzsigntemplatedocumentEditEzsigntemplateformfieldgroupsV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumenteditezsigntemplateformfieldgroupsv1) | **PUT** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/editEzsigntemplateformfieldgroups | Edit multiple Ezsigntemplateformfieldgroups |
| [**EzsigntemplatedocumentEditEzsigntemplatesignaturesV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumenteditezsigntemplatesignaturesv1) | **PUT** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/editEzsigntemplatesignatures | Edit multiple Ezsigntemplatesignatures |
| [**EzsigntemplatedocumentEditEzsigntemplatesignaturesV2**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumenteditezsigntemplatesignaturesv2) | **PUT** /2/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/editEzsigntemplatesignatures | Edit multiple Ezsigntemplatesignatures |
| [**EzsigntemplatedocumentEditObjectV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumenteditobjectv1) | **PUT** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID} | Edit an existing Ezsigntemplatedocument |
| [**EzsigntemplatedocumentExtractTextV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentextracttextv1) | **POST** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/extractText | Extract text from Ezsigntemplatedocument area |
| [**EzsigntemplatedocumentFlattenV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentflattenv1) | **POST** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/flatten | Flatten |
| [**EzsigntemplatedocumentGetEzsigntemplateannotationsV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentgetezsigntemplateannotationsv1) | **GET** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/getEzsigntemplateannotations | Retrieve an existing Ezsigntemplatedocument&#39;s Ezsigntemplateannotations |
| [**EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentgetezsigntemplatedocumentpagerecognitionsv1) | **GET** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/getEzsigntemplatedocumentpagerecognitions | Retrieve an existing Ezsigntemplatedocument&#39;s Ezsigntemplatedocumentpagerecognitions |
| [**EzsigntemplatedocumentGetEzsigntemplatedocumentpagesV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentgetezsigntemplatedocumentpagesv1) | **GET** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/getEzsigntemplatedocumentpages | Retrieve an existing Ezsigntemplatedocument&#39;s Ezsigntemplatedocumentpages |
| [**EzsigntemplatedocumentGetEzsigntemplateformfieldgroupsV1**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentgetezsigntemplateformfieldgroupsv1) | **GET** /1/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/getEzsigntemplateformfieldgroups | Retrieve an existing Ezsigntemplatedocument&#39;s Ezsigntemplateformfieldgroups |
| [**EzsigntemplatedocumentGetEzsigntemplatesignaturesV2**](ObjectEzsigntemplatedocumentApi.md#ezsigntemplatedocumentgetezsigntemplatesignaturesv2) | **GET** /2/object/ezsigntemplatedocument/{pkiEzsigntemplatedocumentID}/getEzsigntemplatesignatures | Retrieve an existing Ezsigntemplatedocument&#39;s Ezsigntemplatesignatures |
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

<a id="ezsigntemplatedocumentdownloadv1"></a>
# **EzsigntemplatedocumentDownloadV1**
> void EzsigntemplatedocumentDownloadV1 (int pkiEzsigntemplatedocumentID)

Retrieve an existing Ezsigntemplatedocument's original file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentDownloadV1Example
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
                // Retrieve an existing Ezsigntemplatedocument's original file
                apiInstance.EzsigntemplatedocumentDownloadV1(pkiEzsigntemplatedocumentID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatedocument's original file
    apiInstance.EzsigntemplatedocumentDownloadV1WithHttpInfo(pkiEzsigntemplatedocumentID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | The user has been redirected |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigntemplatedocumenteditezsigntemplateannotationsv1"></a>
# **EzsigntemplatedocumentEditEzsigntemplateannotationsV1**
> EzsigntemplatedocumentEditEzsigntemplateannotationsV1Response EzsigntemplatedocumentEditEzsigntemplateannotationsV1 (int pkiEzsigntemplatedocumentID, EzsigntemplatedocumentEditEzsigntemplateannotationsV1Request ezsigntemplatedocumentEditEzsigntemplateannotationsV1Request)

Edit multiple Ezsigntemplateannotations

Using this endpoint, you can edit multiple Ezsigntemplateannotations at the same time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentEditEzsigntemplateannotationsV1Example
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
            var ezsigntemplatedocumentEditEzsigntemplateannotationsV1Request = new EzsigntemplatedocumentEditEzsigntemplateannotationsV1Request(); // EzsigntemplatedocumentEditEzsigntemplateannotationsV1Request | 

            try
            {
                // Edit multiple Ezsigntemplateannotations
                EzsigntemplatedocumentEditEzsigntemplateannotationsV1Response result = apiInstance.EzsigntemplatedocumentEditEzsigntemplateannotationsV1(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentEditEzsigntemplateannotationsV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentEditEzsigntemplateannotationsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentEditEzsigntemplateannotationsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit multiple Ezsigntemplateannotations
    ApiResponse<EzsigntemplatedocumentEditEzsigntemplateannotationsV1Response> response = apiInstance.EzsigntemplatedocumentEditEzsigntemplateannotationsV1WithHttpInfo(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentEditEzsigntemplateannotationsV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentEditEzsigntemplateannotationsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |
| **ezsigntemplatedocumentEditEzsigntemplateannotationsV1Request** | [**EzsigntemplatedocumentEditEzsigntemplateannotationsV1Request**](EzsigntemplatedocumentEditEzsigntemplateannotationsV1Request.md) |  |  |

### Return type

[**EzsigntemplatedocumentEditEzsigntemplateannotationsV1Response**](EzsigntemplatedocumentEditEzsigntemplateannotationsV1Response.md)

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

<a id="ezsigntemplatedocumenteditezsigntemplatedocumentpagerecognitionsv1"></a>
# **EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1**
> EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Response EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1 (int pkiEzsigntemplatedocumentID, EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Request ezsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Request)

Edit multiple Ezsigntemplatedocumentpagerecognitions

Edit multiple Ezsigntemplatedocumentpagerecognitions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Example
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
            var ezsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Request = new EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Request(); // EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Request | 

            try
            {
                // Edit multiple Ezsigntemplatedocumentpagerecognitions
                EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Response result = apiInstance.EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit multiple Ezsigntemplatedocumentpagerecognitions
    ApiResponse<EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Response> response = apiInstance.EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1WithHttpInfo(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |
| **ezsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Request** | [**EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Request**](EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Request.md) |  |  |

### Return type

[**EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Response**](EzsigntemplatedocumentEditEzsigntemplatedocumentpagerecognitionsV1Response.md)

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

Using this endpoint, you can edit multiple Ezsigntemplatesignatures at the same time.  Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.

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

<a id="ezsigntemplatedocumenteditezsigntemplatesignaturesv2"></a>
# **EzsigntemplatedocumentEditEzsigntemplatesignaturesV2**
> EzsigntemplatedocumentEditEzsigntemplatesignaturesV2Response EzsigntemplatedocumentEditEzsigntemplatesignaturesV2 (int pkiEzsigntemplatedocumentID, EzsigntemplatedocumentEditEzsigntemplatesignaturesV2Request ezsigntemplatedocumentEditEzsigntemplatesignaturesV2Request)

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
    public class EzsigntemplatedocumentEditEzsigntemplatesignaturesV2Example
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
            var ezsigntemplatedocumentEditEzsigntemplatesignaturesV2Request = new EzsigntemplatedocumentEditEzsigntemplatesignaturesV2Request(); // EzsigntemplatedocumentEditEzsigntemplatesignaturesV2Request | 

            try
            {
                // Edit multiple Ezsigntemplatesignatures
                EzsigntemplatedocumentEditEzsigntemplatesignaturesV2Response result = apiInstance.EzsigntemplatedocumentEditEzsigntemplatesignaturesV2(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentEditEzsigntemplatesignaturesV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentEditEzsigntemplatesignaturesV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentEditEzsigntemplatesignaturesV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit multiple Ezsigntemplatesignatures
    ApiResponse<EzsigntemplatedocumentEditEzsigntemplatesignaturesV2Response> response = apiInstance.EzsigntemplatedocumentEditEzsigntemplatesignaturesV2WithHttpInfo(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentEditEzsigntemplatesignaturesV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentEditEzsigntemplatesignaturesV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |
| **ezsigntemplatedocumentEditEzsigntemplatesignaturesV2Request** | [**EzsigntemplatedocumentEditEzsigntemplatesignaturesV2Request**](EzsigntemplatedocumentEditEzsigntemplatesignaturesV2Request.md) |  |  |

### Return type

[**EzsigntemplatedocumentEditEzsigntemplatesignaturesV2Response**](EzsigntemplatedocumentEditEzsigntemplatesignaturesV2Response.md)

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

<a id="ezsigntemplatedocumentextracttextv1"></a>
# **EzsigntemplatedocumentExtractTextV1**
> EzsigntemplatedocumentExtractTextV1Response EzsigntemplatedocumentExtractTextV1 (int pkiEzsigntemplatedocumentID, EzsigntemplatedocumentExtractTextV1Request ezsigntemplatedocumentExtractTextV1Request)

Extract text from Ezsigntemplatedocument area

Extract text from Ezsigntemplatedocument area

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentExtractTextV1Example
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
            var ezsigntemplatedocumentExtractTextV1Request = new EzsigntemplatedocumentExtractTextV1Request(); // EzsigntemplatedocumentExtractTextV1Request | 

            try
            {
                // Extract text from Ezsigntemplatedocument area
                EzsigntemplatedocumentExtractTextV1Response result = apiInstance.EzsigntemplatedocumentExtractTextV1(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentExtractTextV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentExtractTextV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentExtractTextV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract text from Ezsigntemplatedocument area
    ApiResponse<EzsigntemplatedocumentExtractTextV1Response> response = apiInstance.EzsigntemplatedocumentExtractTextV1WithHttpInfo(pkiEzsigntemplatedocumentID, ezsigntemplatedocumentExtractTextV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentExtractTextV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |
| **ezsigntemplatedocumentExtractTextV1Request** | [**EzsigntemplatedocumentExtractTextV1Request**](EzsigntemplatedocumentExtractTextV1Request.md) |  |  |

### Return type

[**EzsigntemplatedocumentExtractTextV1Response**](EzsigntemplatedocumentExtractTextV1Response.md)

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

<a id="ezsigntemplatedocumentgetezsigntemplateannotationsv1"></a>
# **EzsigntemplatedocumentGetEzsigntemplateannotationsV1**
> EzsigntemplatedocumentGetEzsigntemplateannotationsV1Response EzsigntemplatedocumentGetEzsigntemplateannotationsV1 (int pkiEzsigntemplatedocumentID)

Retrieve an existing Ezsigntemplatedocument's Ezsigntemplateannotations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentGetEzsigntemplateannotationsV1Example
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
                // Retrieve an existing Ezsigntemplatedocument's Ezsigntemplateannotations
                EzsigntemplatedocumentGetEzsigntemplateannotationsV1Response result = apiInstance.EzsigntemplatedocumentGetEzsigntemplateannotationsV1(pkiEzsigntemplatedocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetEzsigntemplateannotationsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentGetEzsigntemplateannotationsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatedocument's Ezsigntemplateannotations
    ApiResponse<EzsigntemplatedocumentGetEzsigntemplateannotationsV1Response> response = apiInstance.EzsigntemplatedocumentGetEzsigntemplateannotationsV1WithHttpInfo(pkiEzsigntemplatedocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetEzsigntemplateannotationsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |

### Return type

[**EzsigntemplatedocumentGetEzsigntemplateannotationsV1Response**](EzsigntemplatedocumentGetEzsigntemplateannotationsV1Response.md)

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

<a id="ezsigntemplatedocumentgetezsigntemplatedocumentpagerecognitionsv1"></a>
# **EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1**
> EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1Response EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1 (int pkiEzsigntemplatedocumentID)

Retrieve an existing Ezsigntemplatedocument's Ezsigntemplatedocumentpagerecognitions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1Example
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
                // Retrieve an existing Ezsigntemplatedocument's Ezsigntemplatedocumentpagerecognitions
                EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1Response result = apiInstance.EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1(pkiEzsigntemplatedocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatedocument's Ezsigntemplatedocumentpagerecognitions
    ApiResponse<EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1Response> response = apiInstance.EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1WithHttpInfo(pkiEzsigntemplatedocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |

### Return type

[**EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1Response**](EzsigntemplatedocumentGetEzsigntemplatedocumentpagerecognitionsV1Response.md)

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

<a id="ezsigntemplatedocumentgetezsigntemplatesignaturesv2"></a>
# **EzsigntemplatedocumentGetEzsigntemplatesignaturesV2**
> EzsigntemplatedocumentGetEzsigntemplatesignaturesV2Response EzsigntemplatedocumentGetEzsigntemplatesignaturesV2 (int pkiEzsigntemplatedocumentID)

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
    public class EzsigntemplatedocumentGetEzsigntemplatesignaturesV2Example
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
                EzsigntemplatedocumentGetEzsigntemplatesignaturesV2Response result = apiInstance.EzsigntemplatedocumentGetEzsigntemplatesignaturesV2(pkiEzsigntemplatedocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetEzsigntemplatesignaturesV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatedocumentGetEzsigntemplatesignaturesV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatedocument's Ezsigntemplatesignatures
    ApiResponse<EzsigntemplatedocumentGetEzsigntemplatesignaturesV2Response> response = apiInstance.EzsigntemplatedocumentGetEzsigntemplatesignaturesV2WithHttpInfo(pkiEzsigntemplatedocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatedocumentApi.EzsigntemplatedocumentGetEzsigntemplatesignaturesV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentID** | **int** |  |  |

### Return type

[**EzsigntemplatedocumentGetEzsigntemplatesignaturesV2Response**](EzsigntemplatedocumentGetEzsigntemplatesignaturesV2Response.md)

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


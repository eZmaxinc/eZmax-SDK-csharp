# eZmaxApi.Api.ObjectEzdoctemplatedocumentApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzdoctemplatedocumentCreateObjectV1**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumentcreateobjectv1) | **POST** /1/object/ezdoctemplatedocument | Create a new Ezdoctemplatedocument |
| [**EzdoctemplatedocumentDownloadV1**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumentdownloadv1) | **GET** /1/object/ezdoctemplatedocument/{pkiEzdoctemplatedocumentID}/download | Retrieve the content |
| [**EzdoctemplatedocumentEditObjectV1**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumenteditobjectv1) | **PUT** /1/object/ezdoctemplatedocument/{pkiEzdoctemplatedocumentID} | Edit an existing Ezdoctemplatedocument |
| [**EzdoctemplatedocumentGetAutocompleteV2**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumentgetautocompletev2) | **GET** /2/object/ezdoctemplatedocument/getAutocomplete/{sSelector} | Retrieve Ezdoctemplatedocuments and IDs |
| [**EzdoctemplatedocumentGetListV1**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumentgetlistv1) | **GET** /1/object/ezdoctemplatedocument/getList | Retrieve Ezdoctemplatedocument list |
| [**EzdoctemplatedocumentGetObjectV2**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumentgetobjectv2) | **GET** /2/object/ezdoctemplatedocument/{pkiEzdoctemplatedocumentID} | Retrieve an existing Ezdoctemplatedocument |
| [**EzdoctemplatedocumentPatchObjectV1**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumentpatchobjectv1) | **PATCH** /1/object/ezdoctemplatedocument/{pkiEzdoctemplatedocumentID} | Patch an existing Ezdoctemplatedocument |

<a id="ezdoctemplatedocumentcreateobjectv1"></a>
# **EzdoctemplatedocumentCreateObjectV1**
> EzdoctemplatedocumentCreateObjectV1Response EzdoctemplatedocumentCreateObjectV1 (EzdoctemplatedocumentCreateObjectV1Request ezdoctemplatedocumentCreateObjectV1Request)

Create a new Ezdoctemplatedocument

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
    public class EzdoctemplatedocumentCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzdoctemplatedocumentApi(config);
            var ezdoctemplatedocumentCreateObjectV1Request = new EzdoctemplatedocumentCreateObjectV1Request(); // EzdoctemplatedocumentCreateObjectV1Request | 

            try
            {
                // Create a new Ezdoctemplatedocument
                EzdoctemplatedocumentCreateObjectV1Response result = apiInstance.EzdoctemplatedocumentCreateObjectV1(ezdoctemplatedocumentCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzdoctemplatedocumentCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezdoctemplatedocument
    ApiResponse<EzdoctemplatedocumentCreateObjectV1Response> response = apiInstance.EzdoctemplatedocumentCreateObjectV1WithHttpInfo(ezdoctemplatedocumentCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezdoctemplatedocumentCreateObjectV1Request** | [**EzdoctemplatedocumentCreateObjectV1Request**](EzdoctemplatedocumentCreateObjectV1Request.md) |  |  |

### Return type

[**EzdoctemplatedocumentCreateObjectV1Response**](EzdoctemplatedocumentCreateObjectV1Response.md)

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

<a id="ezdoctemplatedocumentdownloadv1"></a>
# **EzdoctemplatedocumentDownloadV1**
> void EzdoctemplatedocumentDownloadV1 (int pkiEzdoctemplatedocumentID)

Retrieve the content

Using this endpoint, you can retrieve the content of an ezdoctemplatedocument.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzdoctemplatedocumentDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: Presigned
            config.AddApiKey("sAuthorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sAuthorization", "Bearer");

            var apiInstance = new ObjectEzdoctemplatedocumentApi(config);
            var pkiEzdoctemplatedocumentID = 56;  // int | 

            try
            {
                // Retrieve the content
                apiInstance.EzdoctemplatedocumentDownloadV1(pkiEzdoctemplatedocumentID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzdoctemplatedocumentDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the content
    apiInstance.EzdoctemplatedocumentDownloadV1WithHttpInfo(pkiEzdoctemplatedocumentID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzdoctemplatedocumentID** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization), [Presigned](../README.md#Presigned)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | The user has been redirected |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezdoctemplatedocumenteditobjectv1"></a>
# **EzdoctemplatedocumentEditObjectV1**
> CommonResponse EzdoctemplatedocumentEditObjectV1 (int pkiEzdoctemplatedocumentID, EzdoctemplatedocumentEditObjectV1Request ezdoctemplatedocumentEditObjectV1Request)

Edit an existing Ezdoctemplatedocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzdoctemplatedocumentEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzdoctemplatedocumentApi(config);
            var pkiEzdoctemplatedocumentID = 56;  // int | The unique ID of the Ezdoctemplatedocument
            var ezdoctemplatedocumentEditObjectV1Request = new EzdoctemplatedocumentEditObjectV1Request(); // EzdoctemplatedocumentEditObjectV1Request | 

            try
            {
                // Edit an existing Ezdoctemplatedocument
                CommonResponse result = apiInstance.EzdoctemplatedocumentEditObjectV1(pkiEzdoctemplatedocumentID, ezdoctemplatedocumentEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzdoctemplatedocumentEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezdoctemplatedocument
    ApiResponse<CommonResponse> response = apiInstance.EzdoctemplatedocumentEditObjectV1WithHttpInfo(pkiEzdoctemplatedocumentID, ezdoctemplatedocumentEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzdoctemplatedocumentID** | **int** | The unique ID of the Ezdoctemplatedocument |  |
| **ezdoctemplatedocumentEditObjectV1Request** | [**EzdoctemplatedocumentEditObjectV1Request**](EzdoctemplatedocumentEditObjectV1Request.md) |  |  |

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

<a id="ezdoctemplatedocumentgetautocompletev2"></a>
# **EzdoctemplatedocumentGetAutocompleteV2**
> EzdoctemplatedocumentGetAutocompleteV2Response EzdoctemplatedocumentGetAutocompleteV2 (string sSelector, string eType, string? fkiEzsignfoldertypeID = null, string? eFilterActive = null, string? sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Ezdoctemplatedocuments and IDs

Get the list of Ezdoctemplatedocument to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzdoctemplatedocumentGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzdoctemplatedocumentApi(config);
            var sSelector = "All";  // string | The type of Ezdoctemplatedocuments to return
            var eType = "User";  // string | The type of Ezdoctemplatedocument (default to CompanyEzsignfoldertype)
            var fkiEzsignfoldertypeID = "fkiEzsignfoldertypeID_example";  // string? | Specify which fkiEzsignfoldertypeID we want to display. only used when eType = Ezsignfoldertype (optional) 
            var eFilterActive = "All";  // string? | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string? | Allow to filter the returned results (optional) 
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Ezdoctemplatedocuments and IDs
                EzdoctemplatedocumentGetAutocompleteV2Response result = apiInstance.EzdoctemplatedocumentGetAutocompleteV2(sSelector, eType, fkiEzsignfoldertypeID, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentGetAutocompleteV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzdoctemplatedocumentGetAutocompleteV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezdoctemplatedocuments and IDs
    ApiResponse<EzdoctemplatedocumentGetAutocompleteV2Response> response = apiInstance.EzdoctemplatedocumentGetAutocompleteV2WithHttpInfo(sSelector, eType, fkiEzsignfoldertypeID, eFilterActive, sQuery, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentGetAutocompleteV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Ezdoctemplatedocuments to return |  |
| **eType** | **string** | The type of Ezdoctemplatedocument | [default to CompanyEzsignfoldertype] |
| **fkiEzsignfoldertypeID** | **string?** | Specify which fkiEzsignfoldertypeID we want to display. only used when eType &#x3D; Ezsignfoldertype | [optional]  |
| **eFilterActive** | **string?** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string?** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |

### Return type

[**EzdoctemplatedocumentGetAutocompleteV2Response**](EzdoctemplatedocumentGetAutocompleteV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezdoctemplatedocumentgetlistv1"></a>
# **EzdoctemplatedocumentGetListV1**
> EzdoctemplatedocumentGetListV1Response EzdoctemplatedocumentGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Ezdoctemplatedocument list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzdoctemplatedocumentGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzdoctemplatedocumentApi(config);
            var eOrderBy = "pkiEzdoctemplatedocumentID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Ezdoctemplatedocument list
                EzdoctemplatedocumentGetListV1Response result = apiInstance.EzdoctemplatedocumentGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzdoctemplatedocumentGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezdoctemplatedocument list
    ApiResponse<EzdoctemplatedocumentGetListV1Response> response = apiInstance.EzdoctemplatedocumentGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentGetListV1WithHttpInfo: " + e.Message);
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

[**EzdoctemplatedocumentGetListV1Response**](EzdoctemplatedocumentGetListV1Response.md)

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

<a id="ezdoctemplatedocumentgetobjectv2"></a>
# **EzdoctemplatedocumentGetObjectV2**
> EzdoctemplatedocumentGetObjectV2Response EzdoctemplatedocumentGetObjectV2 (int pkiEzdoctemplatedocumentID)

Retrieve an existing Ezdoctemplatedocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzdoctemplatedocumentGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzdoctemplatedocumentApi(config);
            var pkiEzdoctemplatedocumentID = 56;  // int | The unique ID of the Ezdoctemplatedocument

            try
            {
                // Retrieve an existing Ezdoctemplatedocument
                EzdoctemplatedocumentGetObjectV2Response result = apiInstance.EzdoctemplatedocumentGetObjectV2(pkiEzdoctemplatedocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzdoctemplatedocumentGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezdoctemplatedocument
    ApiResponse<EzdoctemplatedocumentGetObjectV2Response> response = apiInstance.EzdoctemplatedocumentGetObjectV2WithHttpInfo(pkiEzdoctemplatedocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzdoctemplatedocumentID** | **int** | The unique ID of the Ezdoctemplatedocument |  |

### Return type

[**EzdoctemplatedocumentGetObjectV2Response**](EzdoctemplatedocumentGetObjectV2Response.md)

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

<a id="ezdoctemplatedocumentpatchobjectv1"></a>
# **EzdoctemplatedocumentPatchObjectV1**
> CommonResponse EzdoctemplatedocumentPatchObjectV1 (int pkiEzdoctemplatedocumentID, EzdoctemplatedocumentPatchObjectV1Request ezdoctemplatedocumentPatchObjectV1Request)

Patch an existing Ezdoctemplatedocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzdoctemplatedocumentPatchObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzdoctemplatedocumentApi(config);
            var pkiEzdoctemplatedocumentID = 56;  // int | The unique ID of the Ezdoctemplatedocument
            var ezdoctemplatedocumentPatchObjectV1Request = new EzdoctemplatedocumentPatchObjectV1Request(); // EzdoctemplatedocumentPatchObjectV1Request | 

            try
            {
                // Patch an existing Ezdoctemplatedocument
                CommonResponse result = apiInstance.EzdoctemplatedocumentPatchObjectV1(pkiEzdoctemplatedocumentID, ezdoctemplatedocumentPatchObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentPatchObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzdoctemplatedocumentPatchObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patch an existing Ezdoctemplatedocument
    ApiResponse<CommonResponse> response = apiInstance.EzdoctemplatedocumentPatchObjectV1WithHttpInfo(pkiEzdoctemplatedocumentID, ezdoctemplatedocumentPatchObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzdoctemplatedocumentApi.EzdoctemplatedocumentPatchObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzdoctemplatedocumentID** | **int** | The unique ID of the Ezdoctemplatedocument |  |
| **ezdoctemplatedocumentPatchObjectV1Request** | [**EzdoctemplatedocumentPatchObjectV1Request**](EzdoctemplatedocumentPatchObjectV1Request.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


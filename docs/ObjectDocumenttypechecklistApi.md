# eZmaxApi.Api.ObjectDocumenttypechecklistApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DocumenttypechecklistCreateObjectV1**](ObjectDocumenttypechecklistApi.md#documenttypechecklistcreateobjectv1) | **POST** /1/object/documenttypechecklist | Create a new Documenttypechecklist |
| [**DocumenttypechecklistDeleteObjectV1**](ObjectDocumenttypechecklistApi.md#documenttypechecklistdeleteobjectv1) | **DELETE** /1/object/documenttypechecklist/{pkiDocumenttypechecklistID} | Delete an existing Documenttypechecklist |
| [**DocumenttypechecklistEditObjectV1**](ObjectDocumenttypechecklistApi.md#documenttypechecklisteditobjectv1) | **PUT** /1/object/documenttypechecklist/{pkiDocumenttypechecklistID} | Edit an existing Documenttypechecklist |
| [**DocumenttypechecklistGetListV1**](ObjectDocumenttypechecklistApi.md#documenttypechecklistgetlistv1) | **GET** /1/object/documenttypechecklist/getList | Retrieve Documenttypechecklist list |
| [**DocumenttypechecklistGetObjectV2**](ObjectDocumenttypechecklistApi.md#documenttypechecklistgetobjectv2) | **GET** /2/object/documenttypechecklist/{pkiDocumenttypechecklistID} | Retrieve an existing Documenttypechecklist |

<a id="documenttypechecklistcreateobjectv1"></a>
# **DocumenttypechecklistCreateObjectV1**
> DocumenttypechecklistCreateObjectV1Response DocumenttypechecklistCreateObjectV1 (DocumenttypechecklistCreateObjectV1Request documenttypechecklistCreateObjectV1Request)

Create a new Documenttypechecklist

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
    public class DocumenttypechecklistCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDocumenttypechecklistApi(config);
            var documenttypechecklistCreateObjectV1Request = new DocumenttypechecklistCreateObjectV1Request(); // DocumenttypechecklistCreateObjectV1Request | 

            try
            {
                // Create a new Documenttypechecklist
                DocumenttypechecklistCreateObjectV1Response result = apiInstance.DocumenttypechecklistCreateObjectV1(documenttypechecklistCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumenttypechecklistCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Documenttypechecklist
    ApiResponse<DocumenttypechecklistCreateObjectV1Response> response = apiInstance.DocumenttypechecklistCreateObjectV1WithHttpInfo(documenttypechecklistCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documenttypechecklistCreateObjectV1Request** | [**DocumenttypechecklistCreateObjectV1Request**](DocumenttypechecklistCreateObjectV1Request.md) |  |  |

### Return type

[**DocumenttypechecklistCreateObjectV1Response**](DocumenttypechecklistCreateObjectV1Response.md)

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

<a id="documenttypechecklistdeleteobjectv1"></a>
# **DocumenttypechecklistDeleteObjectV1**
> DocumenttypechecklistDeleteObjectV1Response DocumenttypechecklistDeleteObjectV1 (int pkiDocumenttypechecklistID)

Delete an existing Documenttypechecklist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DocumenttypechecklistDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDocumenttypechecklistApi(config);
            var pkiDocumenttypechecklistID = 56;  // int | The unique ID of the Documenttypechecklist

            try
            {
                // Delete an existing Documenttypechecklist
                DocumenttypechecklistDeleteObjectV1Response result = apiInstance.DocumenttypechecklistDeleteObjectV1(pkiDocumenttypechecklistID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumenttypechecklistDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Documenttypechecklist
    ApiResponse<DocumenttypechecklistDeleteObjectV1Response> response = apiInstance.DocumenttypechecklistDeleteObjectV1WithHttpInfo(pkiDocumenttypechecklistID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDocumenttypechecklistID** | **int** | The unique ID of the Documenttypechecklist |  |

### Return type

[**DocumenttypechecklistDeleteObjectV1Response**](DocumenttypechecklistDeleteObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="documenttypechecklisteditobjectv1"></a>
# **DocumenttypechecklistEditObjectV1**
> DocumenttypechecklistEditObjectV1Response DocumenttypechecklistEditObjectV1 (int pkiDocumenttypechecklistID, DocumenttypechecklistEditObjectV1Request documenttypechecklistEditObjectV1Request)

Edit an existing Documenttypechecklist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DocumenttypechecklistEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDocumenttypechecklistApi(config);
            var pkiDocumenttypechecklistID = 56;  // int | The unique ID of the Documenttypechecklist
            var documenttypechecklistEditObjectV1Request = new DocumenttypechecklistEditObjectV1Request(); // DocumenttypechecklistEditObjectV1Request | 

            try
            {
                // Edit an existing Documenttypechecklist
                DocumenttypechecklistEditObjectV1Response result = apiInstance.DocumenttypechecklistEditObjectV1(pkiDocumenttypechecklistID, documenttypechecklistEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumenttypechecklistEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Documenttypechecklist
    ApiResponse<DocumenttypechecklistEditObjectV1Response> response = apiInstance.DocumenttypechecklistEditObjectV1WithHttpInfo(pkiDocumenttypechecklistID, documenttypechecklistEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDocumenttypechecklistID** | **int** | The unique ID of the Documenttypechecklist |  |
| **documenttypechecklistEditObjectV1Request** | [**DocumenttypechecklistEditObjectV1Request**](DocumenttypechecklistEditObjectV1Request.md) |  |  |

### Return type

[**DocumenttypechecklistEditObjectV1Response**](DocumenttypechecklistEditObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="documenttypechecklistgetlistv1"></a>
# **DocumenttypechecklistGetListV1**
> DocumenttypechecklistGetListV1Response DocumenttypechecklistGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Documenttypechecklist list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eDocumenttypechecklistStatus | Not required<br>Required<br>Filed<br>Justified |

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DocumenttypechecklistGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDocumenttypechecklistApi(config);
            var eOrderBy = "pkiDocumenttypechecklistID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Documenttypechecklist list
                DocumenttypechecklistGetListV1Response result = apiInstance.DocumenttypechecklistGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumenttypechecklistGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Documenttypechecklist list
    ApiResponse<DocumenttypechecklistGetListV1Response> response = apiInstance.DocumenttypechecklistGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistGetListV1WithHttpInfo: " + e.Message);
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

[**DocumenttypechecklistGetListV1Response**](DocumenttypechecklistGetListV1Response.md)

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

<a id="documenttypechecklistgetobjectv2"></a>
# **DocumenttypechecklistGetObjectV2**
> DocumenttypechecklistGetObjectV2Response DocumenttypechecklistGetObjectV2 (int pkiDocumenttypechecklistID)

Retrieve an existing Documenttypechecklist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DocumenttypechecklistGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDocumenttypechecklistApi(config);
            var pkiDocumenttypechecklistID = 56;  // int | The unique ID of the Documenttypechecklist

            try
            {
                // Retrieve an existing Documenttypechecklist
                DocumenttypechecklistGetObjectV2Response result = apiInstance.DocumenttypechecklistGetObjectV2(pkiDocumenttypechecklistID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumenttypechecklistGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Documenttypechecklist
    ApiResponse<DocumenttypechecklistGetObjectV2Response> response = apiInstance.DocumenttypechecklistGetObjectV2WithHttpInfo(pkiDocumenttypechecklistID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDocumenttypechecklistID** | **int** | The unique ID of the Documenttypechecklist |  |

### Return type

[**DocumenttypechecklistGetObjectV2Response**](DocumenttypechecklistGetObjectV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


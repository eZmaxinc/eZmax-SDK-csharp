# eZmaxApi.Api.ObjectEzsigntemplateApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplateCopyV1**](ObjectEzsigntemplateApi.md#ezsigntemplatecopyv1) | **POST** /1/object/ezsigntemplate/{pkiEzsigntemplateID}/copy | Copy the Ezsigntemplate |
| [**EzsigntemplateCreateObjectV3**](ObjectEzsigntemplateApi.md#ezsigntemplatecreateobjectv3) | **POST** /3/object/ezsigntemplate | Create a new Ezsigntemplate |
| [**EzsigntemplateDeleteObjectV1**](ObjectEzsigntemplateApi.md#ezsigntemplatedeleteobjectv1) | **DELETE** /1/object/ezsigntemplate/{pkiEzsigntemplateID} | Delete an existing Ezsigntemplate |
| [**EzsigntemplateEditObjectV3**](ObjectEzsigntemplateApi.md#ezsigntemplateeditobjectv3) | **PUT** /3/object/ezsigntemplate/{pkiEzsigntemplateID} | Edit an existing Ezsigntemplate |
| [**EzsigntemplateGetAutocompleteV2**](ObjectEzsigntemplateApi.md#ezsigntemplategetautocompletev2) | **GET** /2/object/ezsigntemplate/getAutocomplete/{sSelector} | Retrieve Ezsigntemplates and IDs |
| [**EzsigntemplateGetListV1**](ObjectEzsigntemplateApi.md#ezsigntemplategetlistv1) | **GET** /1/object/ezsigntemplate/getList | Retrieve Ezsigntemplate list |
| [**EzsigntemplateGetObjectV3**](ObjectEzsigntemplateApi.md#ezsigntemplategetobjectv3) | **GET** /3/object/ezsigntemplate/{pkiEzsigntemplateID} | Retrieve an existing Ezsigntemplate |

<a id="ezsigntemplatecopyv1"></a>
# **EzsigntemplateCopyV1**
> EzsigntemplateCopyV1Response EzsigntemplateCopyV1 (int pkiEzsigntemplateID, EzsigntemplateCopyV1Request ezsigntemplateCopyV1Request)

Copy the Ezsigntemplate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplateCopyV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplateApi(config);
            var pkiEzsigntemplateID = 56;  // int | 
            var ezsigntemplateCopyV1Request = new EzsigntemplateCopyV1Request(); // EzsigntemplateCopyV1Request | 

            try
            {
                // Copy the Ezsigntemplate
                EzsigntemplateCopyV1Response result = apiInstance.EzsigntemplateCopyV1(pkiEzsigntemplateID, ezsigntemplateCopyV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateCopyV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplateCopyV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy the Ezsigntemplate
    ApiResponse<EzsigntemplateCopyV1Response> response = apiInstance.EzsigntemplateCopyV1WithHttpInfo(pkiEzsigntemplateID, ezsigntemplateCopyV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateCopyV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateID** | **int** |  |  |
| **ezsigntemplateCopyV1Request** | [**EzsigntemplateCopyV1Request**](EzsigntemplateCopyV1Request.md) |  |  |

### Return type

[**EzsigntemplateCopyV1Response**](EzsigntemplateCopyV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigntemplatecreateobjectv3"></a>
# **EzsigntemplateCreateObjectV3**
> EzsigntemplateCreateObjectV3Response EzsigntemplateCreateObjectV3 (EzsigntemplateCreateObjectV3Request ezsigntemplateCreateObjectV3Request)

Create a new Ezsigntemplate

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
    public class EzsigntemplateCreateObjectV3Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplateApi(config);
            var ezsigntemplateCreateObjectV3Request = new EzsigntemplateCreateObjectV3Request(); // EzsigntemplateCreateObjectV3Request | 

            try
            {
                // Create a new Ezsigntemplate
                EzsigntemplateCreateObjectV3Response result = apiInstance.EzsigntemplateCreateObjectV3(ezsigntemplateCreateObjectV3Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateCreateObjectV3: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplateCreateObjectV3WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsigntemplate
    ApiResponse<EzsigntemplateCreateObjectV3Response> response = apiInstance.EzsigntemplateCreateObjectV3WithHttpInfo(ezsigntemplateCreateObjectV3Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateCreateObjectV3WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplateCreateObjectV3Request** | [**EzsigntemplateCreateObjectV3Request**](EzsigntemplateCreateObjectV3Request.md) |  |  |

### Return type

[**EzsigntemplateCreateObjectV3Response**](EzsigntemplateCreateObjectV3Response.md)

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

<a id="ezsigntemplatedeleteobjectv1"></a>
# **EzsigntemplateDeleteObjectV1**
> CommonResponse EzsigntemplateDeleteObjectV1 (int pkiEzsigntemplateID)

Delete an existing Ezsigntemplate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplateDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplateApi(config);
            var pkiEzsigntemplateID = 56;  // int | 

            try
            {
                // Delete an existing Ezsigntemplate
                CommonResponse result = apiInstance.EzsigntemplateDeleteObjectV1(pkiEzsigntemplateID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplateDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Ezsigntemplate
    ApiResponse<CommonResponse> response = apiInstance.EzsigntemplateDeleteObjectV1WithHttpInfo(pkiEzsigntemplateID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateID** | **int** |  |  |

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

<a id="ezsigntemplateeditobjectv3"></a>
# **EzsigntemplateEditObjectV3**
> CommonResponse EzsigntemplateEditObjectV3 (int pkiEzsigntemplateID, EzsigntemplateEditObjectV3Request ezsigntemplateEditObjectV3Request)

Edit an existing Ezsigntemplate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplateEditObjectV3Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplateApi(config);
            var pkiEzsigntemplateID = 56;  // int | 
            var ezsigntemplateEditObjectV3Request = new EzsigntemplateEditObjectV3Request(); // EzsigntemplateEditObjectV3Request | 

            try
            {
                // Edit an existing Ezsigntemplate
                CommonResponse result = apiInstance.EzsigntemplateEditObjectV3(pkiEzsigntemplateID, ezsigntemplateEditObjectV3Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateEditObjectV3: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplateEditObjectV3WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsigntemplate
    ApiResponse<CommonResponse> response = apiInstance.EzsigntemplateEditObjectV3WithHttpInfo(pkiEzsigntemplateID, ezsigntemplateEditObjectV3Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateEditObjectV3WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateID** | **int** |  |  |
| **ezsigntemplateEditObjectV3Request** | [**EzsigntemplateEditObjectV3Request**](EzsigntemplateEditObjectV3Request.md) |  |  |

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

<a id="ezsigntemplategetautocompletev2"></a>
# **EzsigntemplateGetAutocompleteV2**
> EzsigntemplateGetAutocompleteV2Response EzsigntemplateGetAutocompleteV2 (string sSelector, string? eFilterActive = null, string? sQuery = null, HeaderAcceptLanguage? acceptLanguage = null, int? fkiEzsignfoldertypeID = null)

Retrieve Ezsigntemplates and IDs

Get the list of Ezsigntemplate to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplateGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplateApi(config);
            var sSelector = "All";  // string | The type of Ezsigntemplates to return
            var eFilterActive = "All";  // string? | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string? | Allow to filter the returned results (optional) 
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var fkiEzsignfoldertypeID = 56;  // int? | The fkiEzsignfoldertypeID to use with the selector Ezsigntemplatepublic (optional) 

            try
            {
                // Retrieve Ezsigntemplates and IDs
                EzsigntemplateGetAutocompleteV2Response result = apiInstance.EzsigntemplateGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage, fkiEzsignfoldertypeID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateGetAutocompleteV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplateGetAutocompleteV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsigntemplates and IDs
    ApiResponse<EzsigntemplateGetAutocompleteV2Response> response = apiInstance.EzsigntemplateGetAutocompleteV2WithHttpInfo(sSelector, eFilterActive, sQuery, acceptLanguage, fkiEzsignfoldertypeID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateGetAutocompleteV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Ezsigntemplates to return |  |
| **eFilterActive** | **string?** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string?** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |
| **fkiEzsignfoldertypeID** | **int?** | The fkiEzsignfoldertypeID to use with the selector Ezsigntemplatepublic | [optional]  |

### Return type

[**EzsigntemplateGetAutocompleteV2Response**](EzsigntemplateGetAutocompleteV2Response.md)

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

<a id="ezsigntemplategetlistv1"></a>
# **EzsigntemplateGetListV1**
> EzsigntemplateGetListV1Response EzsigntemplateGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Ezsigntemplate list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eEzsigntemplateType | Company<br>Team<br>User<br>Usergroup | 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplateGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplateApi(config);
            var eOrderBy = "pkiEzsigntemplateID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Ezsigntemplate list
                EzsigntemplateGetListV1Response result = apiInstance.EzsigntemplateGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplateGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsigntemplate list
    ApiResponse<EzsigntemplateGetListV1Response> response = apiInstance.EzsigntemplateGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateGetListV1WithHttpInfo: " + e.Message);
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

[**EzsigntemplateGetListV1Response**](EzsigntemplateGetListV1Response.md)

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

<a id="ezsigntemplategetobjectv3"></a>
# **EzsigntemplateGetObjectV3**
> EzsigntemplateGetObjectV3Response EzsigntemplateGetObjectV3 (int pkiEzsigntemplateID)

Retrieve an existing Ezsigntemplate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplateGetObjectV3Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplateApi(config);
            var pkiEzsigntemplateID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplate
                EzsigntemplateGetObjectV3Response result = apiInstance.EzsigntemplateGetObjectV3(pkiEzsigntemplateID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateGetObjectV3: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplateGetObjectV3WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplate
    ApiResponse<EzsigntemplateGetObjectV3Response> response = apiInstance.EzsigntemplateGetObjectV3WithHttpInfo(pkiEzsigntemplateID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplateApi.EzsigntemplateGetObjectV3WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateID** | **int** |  |  |

### Return type

[**EzsigntemplateGetObjectV3Response**](EzsigntemplateGetObjectV3Response.md)

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


# eZmaxApi.Api.ObjectEzsignfoldertypeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignfoldertypeCreateObjectV2**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypecreateobjectv2) | **POST** /2/object/ezsignfoldertype | Create a new Ezsignfoldertype |
| [**EzsignfoldertypeEditObjectV1**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypeeditobjectv1) | **PUT** /1/object/ezsignfoldertype/{pkiEzsignfoldertypeID} | Edit an existing Ezsignfoldertype |
| [**EzsignfoldertypeEditObjectV2**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypeeditobjectv2) | **PUT** /2/object/ezsignfoldertype/{pkiEzsignfoldertypeID} | Edit an existing Ezsignfoldertype |
| [**EzsignfoldertypeGetAutocompleteV2**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypegetautocompletev2) | **GET** /2/object/ezsignfoldertype/getAutocomplete/{sSelector} | Retrieve Ezsignfoldertypes and IDs |
| [**EzsignfoldertypeGetListV1**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypegetlistv1) | **GET** /1/object/ezsignfoldertype/getList | Retrieve Ezsignfoldertype list |
| [**EzsignfoldertypeGetObjectV2**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypegetobjectv2) | **GET** /2/object/ezsignfoldertype/{pkiEzsignfoldertypeID} | Retrieve an existing Ezsignfoldertype |
| [**EzsignfoldertypeGetObjectV3**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypegetobjectv3) | **GET** /3/object/ezsignfoldertype/{pkiEzsignfoldertypeID} | Retrieve an existing Ezsignfoldertype |

<a id="ezsignfoldertypecreateobjectv2"></a>
# **EzsignfoldertypeCreateObjectV2**
> EzsignfoldertypeCreateObjectV2Response EzsignfoldertypeCreateObjectV2 (EzsignfoldertypeCreateObjectV2Request ezsignfoldertypeCreateObjectV2Request)

Create a new Ezsignfoldertype

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
    public class EzsignfoldertypeCreateObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldertypeApi(config);
            var ezsignfoldertypeCreateObjectV2Request = new EzsignfoldertypeCreateObjectV2Request(); // EzsignfoldertypeCreateObjectV2Request | 

            try
            {
                // Create a new Ezsignfoldertype
                EzsignfoldertypeCreateObjectV2Response result = apiInstance.EzsignfoldertypeCreateObjectV2(ezsignfoldertypeCreateObjectV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeCreateObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfoldertypeCreateObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsignfoldertype
    ApiResponse<EzsignfoldertypeCreateObjectV2Response> response = apiInstance.EzsignfoldertypeCreateObjectV2WithHttpInfo(ezsignfoldertypeCreateObjectV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeCreateObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignfoldertypeCreateObjectV2Request** | [**EzsignfoldertypeCreateObjectV2Request**](EzsignfoldertypeCreateObjectV2Request.md) |  |  |

### Return type

[**EzsignfoldertypeCreateObjectV2Response**](EzsignfoldertypeCreateObjectV2Response.md)

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

<a id="ezsignfoldertypeeditobjectv1"></a>
# **EzsignfoldertypeEditObjectV1**
> EzsignfoldertypeEditObjectV1Response EzsignfoldertypeEditObjectV1 (int pkiEzsignfoldertypeID, EzsignfoldertypeEditObjectV1Request ezsignfoldertypeEditObjectV1Request)

Edit an existing Ezsignfoldertype

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldertypeEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldertypeApi(config);
            var pkiEzsignfoldertypeID = 56;  // int | 
            var ezsignfoldertypeEditObjectV1Request = new EzsignfoldertypeEditObjectV1Request(); // EzsignfoldertypeEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsignfoldertype
                EzsignfoldertypeEditObjectV1Response result = apiInstance.EzsignfoldertypeEditObjectV1(pkiEzsignfoldertypeID, ezsignfoldertypeEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfoldertypeEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsignfoldertype
    ApiResponse<EzsignfoldertypeEditObjectV1Response> response = apiInstance.EzsignfoldertypeEditObjectV1WithHttpInfo(pkiEzsignfoldertypeID, ezsignfoldertypeEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldertypeID** | **int** |  |  |
| **ezsignfoldertypeEditObjectV1Request** | [**EzsignfoldertypeEditObjectV1Request**](EzsignfoldertypeEditObjectV1Request.md) |  |  |

### Return type

[**EzsignfoldertypeEditObjectV1Response**](EzsignfoldertypeEditObjectV1Response.md)

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

<a id="ezsignfoldertypeeditobjectv2"></a>
# **EzsignfoldertypeEditObjectV2**
> EzsignfoldertypeEditObjectV2Response EzsignfoldertypeEditObjectV2 (int pkiEzsignfoldertypeID, EzsignfoldertypeEditObjectV2Request ezsignfoldertypeEditObjectV2Request)

Edit an existing Ezsignfoldertype

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldertypeEditObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldertypeApi(config);
            var pkiEzsignfoldertypeID = 56;  // int | 
            var ezsignfoldertypeEditObjectV2Request = new EzsignfoldertypeEditObjectV2Request(); // EzsignfoldertypeEditObjectV2Request | 

            try
            {
                // Edit an existing Ezsignfoldertype
                EzsignfoldertypeEditObjectV2Response result = apiInstance.EzsignfoldertypeEditObjectV2(pkiEzsignfoldertypeID, ezsignfoldertypeEditObjectV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeEditObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfoldertypeEditObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsignfoldertype
    ApiResponse<EzsignfoldertypeEditObjectV2Response> response = apiInstance.EzsignfoldertypeEditObjectV2WithHttpInfo(pkiEzsignfoldertypeID, ezsignfoldertypeEditObjectV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeEditObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldertypeID** | **int** |  |  |
| **ezsignfoldertypeEditObjectV2Request** | [**EzsignfoldertypeEditObjectV2Request**](EzsignfoldertypeEditObjectV2Request.md) |  |  |

### Return type

[**EzsignfoldertypeEditObjectV2Response**](EzsignfoldertypeEditObjectV2Response.md)

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

<a id="ezsignfoldertypegetautocompletev2"></a>
# **EzsignfoldertypeGetAutocompleteV2**
> EzsignfoldertypeGetAutocompleteV2Response EzsignfoldertypeGetAutocompleteV2 (string sSelector, string? eFilterActive = null, string? sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Ezsignfoldertypes and IDs

Get the list of Ezsignfoldertype to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldertypeGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldertypeApi(config);
            var sSelector = "Active";  // string | The type of Ezsignfoldertypes to return
            var eFilterActive = "All";  // string? | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string? | Allow to filter the returned results (optional) 
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Ezsignfoldertypes and IDs
                EzsignfoldertypeGetAutocompleteV2Response result = apiInstance.EzsignfoldertypeGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeGetAutocompleteV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfoldertypeGetAutocompleteV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsignfoldertypes and IDs
    ApiResponse<EzsignfoldertypeGetAutocompleteV2Response> response = apiInstance.EzsignfoldertypeGetAutocompleteV2WithHttpInfo(sSelector, eFilterActive, sQuery, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeGetAutocompleteV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Ezsignfoldertypes to return |  |
| **eFilterActive** | **string?** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string?** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |

### Return type

[**EzsignfoldertypeGetAutocompleteV2Response**](EzsignfoldertypeGetAutocompleteV2Response.md)

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

<a id="ezsignfoldertypegetlistv1"></a>
# **EzsignfoldertypeGetListV1**
> EzsignfoldertypeGetListV1Response EzsignfoldertypeGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Ezsignfoldertype list

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
    public class EzsignfoldertypeGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldertypeApi(config);
            var eOrderBy = "pkiEzsignfoldertypeID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Ezsignfoldertype list
                EzsignfoldertypeGetListV1Response result = apiInstance.EzsignfoldertypeGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfoldertypeGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsignfoldertype list
    ApiResponse<EzsignfoldertypeGetListV1Response> response = apiInstance.EzsignfoldertypeGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeGetListV1WithHttpInfo: " + e.Message);
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

[**EzsignfoldertypeGetListV1Response**](EzsignfoldertypeGetListV1Response.md)

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

<a id="ezsignfoldertypegetobjectv2"></a>
# **EzsignfoldertypeGetObjectV2**
> EzsignfoldertypeGetObjectV2Response EzsignfoldertypeGetObjectV2 (int pkiEzsignfoldertypeID)

Retrieve an existing Ezsignfoldertype

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldertypeGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldertypeApi(config);
            var pkiEzsignfoldertypeID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfoldertype
                EzsignfoldertypeGetObjectV2Response result = apiInstance.EzsignfoldertypeGetObjectV2(pkiEzsignfoldertypeID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfoldertypeGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignfoldertype
    ApiResponse<EzsignfoldertypeGetObjectV2Response> response = apiInstance.EzsignfoldertypeGetObjectV2WithHttpInfo(pkiEzsignfoldertypeID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldertypeID** | **int** |  |  |

### Return type

[**EzsignfoldertypeGetObjectV2Response**](EzsignfoldertypeGetObjectV2Response.md)

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

<a id="ezsignfoldertypegetobjectv3"></a>
# **EzsignfoldertypeGetObjectV3**
> EzsignfoldertypeGetObjectV3Response EzsignfoldertypeGetObjectV3 (int pkiEzsignfoldertypeID)

Retrieve an existing Ezsignfoldertype

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldertypeGetObjectV3Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldertypeApi(config);
            var pkiEzsignfoldertypeID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfoldertype
                EzsignfoldertypeGetObjectV3Response result = apiInstance.EzsignfoldertypeGetObjectV3(pkiEzsignfoldertypeID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeGetObjectV3: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfoldertypeGetObjectV3WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignfoldertype
    ApiResponse<EzsignfoldertypeGetObjectV3Response> response = apiInstance.EzsignfoldertypeGetObjectV3WithHttpInfo(pkiEzsignfoldertypeID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeGetObjectV3WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldertypeID** | **int** |  |  |

### Return type

[**EzsignfoldertypeGetObjectV3Response**](EzsignfoldertypeGetObjectV3Response.md)

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


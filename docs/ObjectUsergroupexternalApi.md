# eZmaxApi.Api.ObjectUsergroupexternalApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UsergroupexternalCreateObjectV1**](ObjectUsergroupexternalApi.md#usergroupexternalcreateobjectv1) | **POST** /1/object/usergroupexternal | Create a new Usergroupexternal |
| [**UsergroupexternalDeleteObjectV1**](ObjectUsergroupexternalApi.md#usergroupexternaldeleteobjectv1) | **DELETE** /1/object/usergroupexternal/{pkiUsergroupexternalID} | Delete an existing Usergroupexternal |
| [**UsergroupexternalEditObjectV1**](ObjectUsergroupexternalApi.md#usergroupexternaleditobjectv1) | **PUT** /1/object/usergroupexternal/{pkiUsergroupexternalID} | Edit an existing Usergroupexternal |
| [**UsergroupexternalGetAutocompleteV2**](ObjectUsergroupexternalApi.md#usergroupexternalgetautocompletev2) | **GET** /2/object/usergroupexternal/getAutocomplete/{sSelector} | Retrieve Usergroupexternals and IDs |
| [**UsergroupexternalGetListV1**](ObjectUsergroupexternalApi.md#usergroupexternalgetlistv1) | **GET** /1/object/usergroupexternal/getList | Retrieve Usergroupexternal list |
| [**UsergroupexternalGetObjectV2**](ObjectUsergroupexternalApi.md#usergroupexternalgetobjectv2) | **GET** /2/object/usergroupexternal/{pkiUsergroupexternalID} | Retrieve an existing Usergroupexternal |
| [**UsergroupexternalGetUsergroupexternalmembershipsV1**](ObjectUsergroupexternalApi.md#usergroupexternalgetusergroupexternalmembershipsv1) | **GET** /1/object/usergroupexternal/{pkiUsergroupexternalID}/getUsergroupexternalmemberships | Retrieve an existing Usergroupexternal&#39;s Usergroupexternalmemberships |
| [**UsergroupexternalGetUsergroupsV1**](ObjectUsergroupexternalApi.md#usergroupexternalgetusergroupsv1) | **GET** /1/object/usergroupexternal/{pkiUsergroupexternalID}/getUsergroups | Get Usergroupexternal&#39;s Usergroups |

<a id="usergroupexternalcreateobjectv1"></a>
# **UsergroupexternalCreateObjectV1**
> UsergroupexternalCreateObjectV1Response UsergroupexternalCreateObjectV1 (UsergroupexternalCreateObjectV1Request usergroupexternalCreateObjectV1Request)

Create a new Usergroupexternal

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
    public class UsergroupexternalCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUsergroupexternalApi(config);
            var usergroupexternalCreateObjectV1Request = new UsergroupexternalCreateObjectV1Request(); // UsergroupexternalCreateObjectV1Request | 

            try
            {
                // Create a new Usergroupexternal
                UsergroupexternalCreateObjectV1Response result = apiInstance.UsergroupexternalCreateObjectV1(usergroupexternalCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsergroupexternalCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Usergroupexternal
    ApiResponse<UsergroupexternalCreateObjectV1Response> response = apiInstance.UsergroupexternalCreateObjectV1WithHttpInfo(usergroupexternalCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **usergroupexternalCreateObjectV1Request** | [**UsergroupexternalCreateObjectV1Request**](UsergroupexternalCreateObjectV1Request.md) |  |  |

### Return type

[**UsergroupexternalCreateObjectV1Response**](UsergroupexternalCreateObjectV1Response.md)

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

<a id="usergroupexternaldeleteobjectv1"></a>
# **UsergroupexternalDeleteObjectV1**
> UsergroupexternalDeleteObjectV1Response UsergroupexternalDeleteObjectV1 (int pkiUsergroupexternalID)

Delete an existing Usergroupexternal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsergroupexternalDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUsergroupexternalApi(config);
            var pkiUsergroupexternalID = 56;  // int | The unique ID of the Usergroupexternal

            try
            {
                // Delete an existing Usergroupexternal
                UsergroupexternalDeleteObjectV1Response result = apiInstance.UsergroupexternalDeleteObjectV1(pkiUsergroupexternalID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsergroupexternalDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Usergroupexternal
    ApiResponse<UsergroupexternalDeleteObjectV1Response> response = apiInstance.UsergroupexternalDeleteObjectV1WithHttpInfo(pkiUsergroupexternalID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupexternalID** | **int** | The unique ID of the Usergroupexternal |  |

### Return type

[**UsergroupexternalDeleteObjectV1Response**](UsergroupexternalDeleteObjectV1Response.md)

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

<a id="usergroupexternaleditobjectv1"></a>
# **UsergroupexternalEditObjectV1**
> UsergroupexternalEditObjectV1Response UsergroupexternalEditObjectV1 (int pkiUsergroupexternalID, UsergroupexternalEditObjectV1Request usergroupexternalEditObjectV1Request)

Edit an existing Usergroupexternal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsergroupexternalEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUsergroupexternalApi(config);
            var pkiUsergroupexternalID = 56;  // int | The unique ID of the Usergroupexternal
            var usergroupexternalEditObjectV1Request = new UsergroupexternalEditObjectV1Request(); // UsergroupexternalEditObjectV1Request | 

            try
            {
                // Edit an existing Usergroupexternal
                UsergroupexternalEditObjectV1Response result = apiInstance.UsergroupexternalEditObjectV1(pkiUsergroupexternalID, usergroupexternalEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsergroupexternalEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Usergroupexternal
    ApiResponse<UsergroupexternalEditObjectV1Response> response = apiInstance.UsergroupexternalEditObjectV1WithHttpInfo(pkiUsergroupexternalID, usergroupexternalEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupexternalID** | **int** | The unique ID of the Usergroupexternal |  |
| **usergroupexternalEditObjectV1Request** | [**UsergroupexternalEditObjectV1Request**](UsergroupexternalEditObjectV1Request.md) |  |  |

### Return type

[**UsergroupexternalEditObjectV1Response**](UsergroupexternalEditObjectV1Response.md)

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

<a id="usergroupexternalgetautocompletev2"></a>
# **UsergroupexternalGetAutocompleteV2**
> UsergroupexternalGetAutocompleteV2Response UsergroupexternalGetAutocompleteV2 (string sSelector, string? eFilterActive = null, string? sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Usergroupexternals and IDs

Get the list of Usergroupexternal to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsergroupexternalGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUsergroupexternalApi(config);
            var sSelector = "All";  // string | The type of Usergroupexternals to return
            var eFilterActive = "All";  // string? | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string? | Allow to filter the returned results (optional) 
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Usergroupexternals and IDs
                UsergroupexternalGetAutocompleteV2Response result = apiInstance.UsergroupexternalGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalGetAutocompleteV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsergroupexternalGetAutocompleteV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Usergroupexternals and IDs
    ApiResponse<UsergroupexternalGetAutocompleteV2Response> response = apiInstance.UsergroupexternalGetAutocompleteV2WithHttpInfo(sSelector, eFilterActive, sQuery, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalGetAutocompleteV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Usergroupexternals to return |  |
| **eFilterActive** | **string?** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string?** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |

### Return type

[**UsergroupexternalGetAutocompleteV2Response**](UsergroupexternalGetAutocompleteV2Response.md)

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

<a id="usergroupexternalgetlistv1"></a>
# **UsergroupexternalGetListV1**
> UsergroupexternalGetListV1Response UsergroupexternalGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Usergroupexternal list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsergroupexternalGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUsergroupexternalApi(config);
            var eOrderBy = "pkiUsergroupexternalID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Usergroupexternal list
                UsergroupexternalGetListV1Response result = apiInstance.UsergroupexternalGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsergroupexternalGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Usergroupexternal list
    ApiResponse<UsergroupexternalGetListV1Response> response = apiInstance.UsergroupexternalGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalGetListV1WithHttpInfo: " + e.Message);
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

[**UsergroupexternalGetListV1Response**](UsergroupexternalGetListV1Response.md)

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

<a id="usergroupexternalgetobjectv2"></a>
# **UsergroupexternalGetObjectV2**
> UsergroupexternalGetObjectV2Response UsergroupexternalGetObjectV2 (int pkiUsergroupexternalID)

Retrieve an existing Usergroupexternal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsergroupexternalGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUsergroupexternalApi(config);
            var pkiUsergroupexternalID = 56;  // int | The unique ID of the Usergroupexternal

            try
            {
                // Retrieve an existing Usergroupexternal
                UsergroupexternalGetObjectV2Response result = apiInstance.UsergroupexternalGetObjectV2(pkiUsergroupexternalID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsergroupexternalGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Usergroupexternal
    ApiResponse<UsergroupexternalGetObjectV2Response> response = apiInstance.UsergroupexternalGetObjectV2WithHttpInfo(pkiUsergroupexternalID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupexternalID** | **int** | The unique ID of the Usergroupexternal |  |

### Return type

[**UsergroupexternalGetObjectV2Response**](UsergroupexternalGetObjectV2Response.md)

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

<a id="usergroupexternalgetusergroupexternalmembershipsv1"></a>
# **UsergroupexternalGetUsergroupexternalmembershipsV1**
> UsergroupexternalGetUsergroupexternalmembershipsV1Response UsergroupexternalGetUsergroupexternalmembershipsV1 (int pkiUsergroupexternalID)

Retrieve an existing Usergroupexternal's Usergroupexternalmemberships

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsergroupexternalGetUsergroupexternalmembershipsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUsergroupexternalApi(config);
            var pkiUsergroupexternalID = 56;  // int | 

            try
            {
                // Retrieve an existing Usergroupexternal's Usergroupexternalmemberships
                UsergroupexternalGetUsergroupexternalmembershipsV1Response result = apiInstance.UsergroupexternalGetUsergroupexternalmembershipsV1(pkiUsergroupexternalID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalGetUsergroupexternalmembershipsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsergroupexternalGetUsergroupexternalmembershipsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Usergroupexternal's Usergroupexternalmemberships
    ApiResponse<UsergroupexternalGetUsergroupexternalmembershipsV1Response> response = apiInstance.UsergroupexternalGetUsergroupexternalmembershipsV1WithHttpInfo(pkiUsergroupexternalID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalGetUsergroupexternalmembershipsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupexternalID** | **int** |  |  |

### Return type

[**UsergroupexternalGetUsergroupexternalmembershipsV1Response**](UsergroupexternalGetUsergroupexternalmembershipsV1Response.md)

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

<a id="usergroupexternalgetusergroupsv1"></a>
# **UsergroupexternalGetUsergroupsV1**
> UsergroupexternalGetUsergroupsV1Response UsergroupexternalGetUsergroupsV1 (int pkiUsergroupexternalID)

Get Usergroupexternal's Usergroups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsergroupexternalGetUsergroupsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUsergroupexternalApi(config);
            var pkiUsergroupexternalID = 56;  // int | 

            try
            {
                // Get Usergroupexternal's Usergroups
                UsergroupexternalGetUsergroupsV1Response result = apiInstance.UsergroupexternalGetUsergroupsV1(pkiUsergroupexternalID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalGetUsergroupsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsergroupexternalGetUsergroupsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Usergroupexternal's Usergroups
    ApiResponse<UsergroupexternalGetUsergroupsV1Response> response = apiInstance.UsergroupexternalGetUsergroupsV1WithHttpInfo(pkiUsergroupexternalID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectUsergroupexternalApi.UsergroupexternalGetUsergroupsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupexternalID** | **int** |  |  |

### Return type

[**UsergroupexternalGetUsergroupsV1Response**](UsergroupexternalGetUsergroupsV1Response.md)

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


# eZmaxApi.Api.ObjectUserstagedApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserstagedCreateUserV1**](ObjectUserstagedApi.md#userstagedcreateuserv1) | **POST** /1/object/userstaged/{pkiUserstagedID}/createUser | Create a User from a Userstaged and then map it |
| [**UserstagedDeleteObjectV1**](ObjectUserstagedApi.md#userstageddeleteobjectv1) | **DELETE** /1/object/userstaged/{pkiUserstagedID} | Delete an existing Userstaged |
| [**UserstagedGetListV1**](ObjectUserstagedApi.md#userstagedgetlistv1) | **GET** /1/object/userstaged/getList | Retrieve Userstaged list |
| [**UserstagedGetObjectV2**](ObjectUserstagedApi.md#userstagedgetobjectv2) | **GET** /2/object/userstaged/{pkiUserstagedID} | Retrieve an existing Userstaged |
| [**UserstagedMapV1**](ObjectUserstagedApi.md#userstagedmapv1) | **POST** /1/object/userstaged/{pkiUserstagedID}/map | Map the Userstaged to an existing user |

<a id="userstagedcreateuserv1"></a>
# **UserstagedCreateUserV1**
> UserstagedCreateUserV1Response UserstagedCreateUserV1 (int pkiUserstagedID, Object body)

Create a User from a Userstaged and then map it

Default values will be used while creating the User. If you need to change those values, you should use the route to edit a User.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UserstagedCreateUserV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUserstagedApi(config);
            var pkiUserstagedID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Create a User from a Userstaged and then map it
                UserstagedCreateUserV1Response result = apiInstance.UserstagedCreateUserV1(pkiUserstagedID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectUserstagedApi.UserstagedCreateUserV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserstagedCreateUserV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a User from a Userstaged and then map it
    ApiResponse<UserstagedCreateUserV1Response> response = apiInstance.UserstagedCreateUserV1WithHttpInfo(pkiUserstagedID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectUserstagedApi.UserstagedCreateUserV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserstagedID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**UserstagedCreateUserV1Response**](UserstagedCreateUserV1Response.md)

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

<a id="userstageddeleteobjectv1"></a>
# **UserstagedDeleteObjectV1**
> CommonResponse UserstagedDeleteObjectV1 (int pkiUserstagedID)

Delete an existing Userstaged

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UserstagedDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUserstagedApi(config);
            var pkiUserstagedID = 56;  // int | 

            try
            {
                // Delete an existing Userstaged
                CommonResponse result = apiInstance.UserstagedDeleteObjectV1(pkiUserstagedID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectUserstagedApi.UserstagedDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserstagedDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Userstaged
    ApiResponse<CommonResponse> response = apiInstance.UserstagedDeleteObjectV1WithHttpInfo(pkiUserstagedID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectUserstagedApi.UserstagedDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserstagedID** | **int** |  |  |

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

<a id="userstagedgetlistv1"></a>
# **UserstagedGetListV1**
> UserstagedGetListV1Response UserstagedGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Userstaged list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UserstagedGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUserstagedApi(config);
            var eOrderBy = "pkiUserstagedID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Userstaged list
                UserstagedGetListV1Response result = apiInstance.UserstagedGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectUserstagedApi.UserstagedGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserstagedGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Userstaged list
    ApiResponse<UserstagedGetListV1Response> response = apiInstance.UserstagedGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectUserstagedApi.UserstagedGetListV1WithHttpInfo: " + e.Message);
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

[**UserstagedGetListV1Response**](UserstagedGetListV1Response.md)

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

<a id="userstagedgetobjectv2"></a>
# **UserstagedGetObjectV2**
> UserstagedGetObjectV2Response UserstagedGetObjectV2 (int pkiUserstagedID)

Retrieve an existing Userstaged

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UserstagedGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUserstagedApi(config);
            var pkiUserstagedID = 56;  // int | 

            try
            {
                // Retrieve an existing Userstaged
                UserstagedGetObjectV2Response result = apiInstance.UserstagedGetObjectV2(pkiUserstagedID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectUserstagedApi.UserstagedGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserstagedGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Userstaged
    ApiResponse<UserstagedGetObjectV2Response> response = apiInstance.UserstagedGetObjectV2WithHttpInfo(pkiUserstagedID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectUserstagedApi.UserstagedGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserstagedID** | **int** |  |  |

### Return type

[**UserstagedGetObjectV2Response**](UserstagedGetObjectV2Response.md)

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

<a id="userstagedmapv1"></a>
# **UserstagedMapV1**
> CommonResponse UserstagedMapV1 (int pkiUserstagedID, UserstagedMapV1Request userstagedMapV1Request)

Map the Userstaged to an existing user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UserstagedMapV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUserstagedApi(config);
            var pkiUserstagedID = 56;  // int | 
            var userstagedMapV1Request = new UserstagedMapV1Request(); // UserstagedMapV1Request | 

            try
            {
                // Map the Userstaged to an existing user
                CommonResponse result = apiInstance.UserstagedMapV1(pkiUserstagedID, userstagedMapV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectUserstagedApi.UserstagedMapV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserstagedMapV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Map the Userstaged to an existing user
    ApiResponse<CommonResponse> response = apiInstance.UserstagedMapV1WithHttpInfo(pkiUserstagedID, userstagedMapV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectUserstagedApi.UserstagedMapV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserstagedID** | **int** |  |  |
| **userstagedMapV1Request** | [**UserstagedMapV1Request**](UserstagedMapV1Request.md) |  |  |

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


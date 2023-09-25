# eZmaxApi.Api.ScimUsersApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UsersCreateObjectScimV2**](ScimUsersApi.md#userscreateobjectscimv2) | **POST** /2/scim/Users | Create a new User |
| [**UsersDeleteObjectScimV2**](ScimUsersApi.md#usersdeleteobjectscimv2) | **DELETE** /2/scim/Users/{userId} | Delete an existing User |
| [**UsersEditObjectScimV2**](ScimUsersApi.md#userseditobjectscimv2) | **PUT** /2/scim/Users/{userId} | Edit an existing User |
| [**UsersGetListScimV2**](ScimUsersApi.md#usersgetlistscimv2) | **GET** /2/scim/Users | Retrieve User list |
| [**UsersGetObjectScimV2**](ScimUsersApi.md#usersgetobjectscimv2) | **GET** /2/scim/Users/{userId} | Retrieve an existing User |

<a id="userscreateobjectscimv2"></a>
# **UsersCreateObjectScimV2**
> ScimUser UsersCreateObjectScimV2 (ScimUser scimUser)

Create a new User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsersCreateObjectScimV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ScimUsersApi(config);
            var scimUser = new ScimUser(); // ScimUser | 

            try
            {
                // Create a new User
                ScimUser result = apiInstance.UsersCreateObjectScimV2(scimUser);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScimUsersApi.UsersCreateObjectScimV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersCreateObjectScimV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new User
    ApiResponse<ScimUser> response = apiInstance.UsersCreateObjectScimV2WithHttpInfo(scimUser);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScimUsersApi.UsersCreateObjectScimV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scimUser** | [**ScimUser**](ScimUser.md) |  |  |

### Return type

[**ScimUser**](ScimUser.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usersdeleteobjectscimv2"></a>
# **UsersDeleteObjectScimV2**
> void UsersDeleteObjectScimV2 (string userId)

Delete an existing User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsersDeleteObjectScimV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ScimUsersApi(config);
            var userId = "userId_example";  // string | 

            try
            {
                // Delete an existing User
                apiInstance.UsersDeleteObjectScimV2(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScimUsersApi.UsersDeleteObjectScimV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersDeleteObjectScimV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing User
    apiInstance.UsersDeleteObjectScimV2WithHttpInfo(userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScimUsersApi.UsersDeleteObjectScimV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userseditobjectscimv2"></a>
# **UsersEditObjectScimV2**
> ScimUser UsersEditObjectScimV2 (string userId, ScimUser scimUser)

Edit an existing User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsersEditObjectScimV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ScimUsersApi(config);
            var userId = "userId_example";  // string | 
            var scimUser = new ScimUser(); // ScimUser | 

            try
            {
                // Edit an existing User
                ScimUser result = apiInstance.UsersEditObjectScimV2(userId, scimUser);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScimUsersApi.UsersEditObjectScimV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersEditObjectScimV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing User
    ApiResponse<ScimUser> response = apiInstance.UsersEditObjectScimV2WithHttpInfo(userId, scimUser);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScimUsersApi.UsersEditObjectScimV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **scimUser** | [**ScimUser**](ScimUser.md) |  |  |

### Return type

[**ScimUser**](ScimUser.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usersgetlistscimv2"></a>
# **UsersGetListScimV2**
> ScimUserList UsersGetListScimV2 (string? filter = null)

Retrieve User list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsersGetListScimV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ScimUsersApi(config);
            var filter = "filter_example";  // string? | Filter expression for searching users (optional) 

            try
            {
                // Retrieve User list
                ScimUserList result = apiInstance.UsersGetListScimV2(filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScimUsersApi.UsersGetListScimV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersGetListScimV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve User list
    ApiResponse<ScimUserList> response = apiInstance.UsersGetListScimV2WithHttpInfo(filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScimUsersApi.UsersGetListScimV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string?** | Filter expression for searching users | [optional]  |

### Return type

[**ScimUserList**](ScimUserList.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usersgetobjectscimv2"></a>
# **UsersGetObjectScimV2**
> ScimUser UsersGetObjectScimV2 (string userId)

Retrieve an existing User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsersGetObjectScimV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ScimUsersApi(config);
            var userId = "userId_example";  // string | 

            try
            {
                // Retrieve an existing User
                ScimUser result = apiInstance.UsersGetObjectScimV2(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScimUsersApi.UsersGetObjectScimV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersGetObjectScimV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing User
    ApiResponse<ScimUser> response = apiInstance.UsersGetObjectScimV2WithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScimUsersApi.UsersGetObjectScimV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |

### Return type

[**ScimUser**](ScimUser.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


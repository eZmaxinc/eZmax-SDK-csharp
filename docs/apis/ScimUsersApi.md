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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersdeleteobjectscimv2"></a>
# **UsersDeleteObjectScimV2**
> void UsersDeleteObjectScimV2 (string userId)

Delete an existing User


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="userseditobjectscimv2"></a>
# **UsersEditObjectScimV2**
> ScimUser UsersEditObjectScimV2 (string userId, ScimUser scimUser)

Edit an existing User


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersgetlistscimv2"></a>
# **UsersGetListScimV2**
> ScimUserList UsersGetListScimV2 (string filter = null)

Retrieve User list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string** | Filter expression for searching users | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersgetobjectscimv2"></a>
# **UsersGetObjectScimV2**
> ScimUser UsersGetObjectScimV2 (string userId)

Retrieve an existing User


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


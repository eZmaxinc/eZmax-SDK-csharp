# eZmaxApi.Api.ScimGroupsApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GroupsCreateObjectScimV2**](ScimGroupsApi.md#groupscreateobjectscimv2) | **POST** /2/scim/Groups | Create a new Usergroup |
| [**GroupsDeleteObjectScimV2**](ScimGroupsApi.md#groupsdeleteobjectscimv2) | **DELETE** /2/scim/Groups/{groupId} | Delete an existing Usergroup |
| [**GroupsEditObjectScimV2**](ScimGroupsApi.md#groupseditobjectscimv2) | **PUT** /2/scim/Groups/{groupId} | Edit an existing Usergroup |
| [**GroupsGetListScimV2**](ScimGroupsApi.md#groupsgetlistscimv2) | **GET** /2/scim/Groups | Retrieve Usergroup list |
| [**GroupsGetObjectScimV2**](ScimGroupsApi.md#groupsgetobjectscimv2) | **GET** /2/scim/Groups/{groupId} | Retrieve an existing Usergroup |

<a id="groupscreateobjectscimv2"></a>
# **GroupsCreateObjectScimV2**
> ScimGroup GroupsCreateObjectScimV2 (ScimGroup scimGroup)

Create a new Usergroup


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scimGroup** | [**ScimGroup**](ScimGroup.md) |  |  |

### Return type

[**ScimGroup**](ScimGroup.md)

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

<a id="groupsdeleteobjectscimv2"></a>
# **GroupsDeleteObjectScimV2**
> void GroupsDeleteObjectScimV2 (string groupId)

Delete an existing Usergroup


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** |  |  |

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

<a id="groupseditobjectscimv2"></a>
# **GroupsEditObjectScimV2**
> ScimGroup GroupsEditObjectScimV2 (string groupId, ScimGroup scimGroup)

Edit an existing Usergroup


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** |  |  |
| **scimGroup** | [**ScimGroup**](ScimGroup.md) |  |  |

### Return type

[**ScimGroup**](ScimGroup.md)

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

<a id="groupsgetlistscimv2"></a>
# **GroupsGetListScimV2**
> ScimGroup GroupsGetListScimV2 (string filter = null)

Retrieve Usergroup list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string** | Filter expression for searching groups | [optional]  |

### Return type

[**ScimGroup**](ScimGroup.md)

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

<a id="groupsgetobjectscimv2"></a>
# **GroupsGetObjectScimV2**
> ScimGroup GroupsGetObjectScimV2 (string groupId)

Retrieve an existing Usergroup


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** |  |  |

### Return type

[**ScimGroup**](ScimGroup.md)

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


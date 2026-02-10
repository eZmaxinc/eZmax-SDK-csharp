# eZmaxApi.Api.ObjectPermissionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PermissionCreateObjectV1**](ObjectPermissionApi.md#permissioncreateobjectv1) | **POST** /1/object/permission | Create a new Permission |
| [**PermissionDeleteObjectV1**](ObjectPermissionApi.md#permissiondeleteobjectv1) | **DELETE** /1/object/permission/{pkiPermissionID} | Delete an existing Permission |
| [**PermissionEditObjectV1**](ObjectPermissionApi.md#permissioneditobjectv1) | **PUT** /1/object/permission/{pkiPermissionID} | Edit an existing Permission |
| [**PermissionGetObjectV2**](ObjectPermissionApi.md#permissiongetobjectv2) | **GET** /2/object/permission/{pkiPermissionID} | Retrieve an existing Permission |

<a id="permissioncreateobjectv1"></a>
# **PermissionCreateObjectV1**
> PermissionCreateObjectV1Response PermissionCreateObjectV1 (PermissionCreateObjectV1Request permissionCreateObjectV1Request)

Create a new Permission

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **permissionCreateObjectV1Request** | [**PermissionCreateObjectV1Request**](PermissionCreateObjectV1Request.md) |  |  |

### Return type

[**PermissionCreateObjectV1Response**](PermissionCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="permissiondeleteobjectv1"></a>
# **PermissionDeleteObjectV1**
> PermissionDeleteObjectV1Response PermissionDeleteObjectV1 (int pkiPermissionID)

Delete an existing Permission


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiPermissionID** | **int** | The unique ID of the Permission |  |

### Return type

[**PermissionDeleteObjectV1Response**](PermissionDeleteObjectV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="permissioneditobjectv1"></a>
# **PermissionEditObjectV1**
> PermissionEditObjectV1Response PermissionEditObjectV1 (int pkiPermissionID, PermissionEditObjectV1Request permissionEditObjectV1Request)

Edit an existing Permission


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiPermissionID** | **int** | The unique ID of the Permission |  |
| **permissionEditObjectV1Request** | [**PermissionEditObjectV1Request**](PermissionEditObjectV1Request.md) |  |  |

### Return type

[**PermissionEditObjectV1Response**](PermissionEditObjectV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="permissiongetobjectv2"></a>
# **PermissionGetObjectV2**
> PermissionGetObjectV2Response PermissionGetObjectV2 (int pkiPermissionID)

Retrieve an existing Permission


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiPermissionID** | **int** | The unique ID of the Permission |  |

### Return type

[**PermissionGetObjectV2Response**](PermissionGetObjectV2Response.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


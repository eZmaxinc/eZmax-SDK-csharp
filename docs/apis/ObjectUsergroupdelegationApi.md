# eZmaxApi.Api.ObjectUsergroupdelegationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UsergroupdelegationCreateObjectV1**](ObjectUsergroupdelegationApi.md#usergroupdelegationcreateobjectv1) | **POST** /1/object/usergroupdelegation | Create a new Usergroupdelegation |
| [**UsergroupdelegationDeleteObjectV1**](ObjectUsergroupdelegationApi.md#usergroupdelegationdeleteobjectv1) | **DELETE** /1/object/usergroupdelegation/{pkiUsergroupdelegationID} | Delete an existing Usergroupdelegation |
| [**UsergroupdelegationEditObjectV1**](ObjectUsergroupdelegationApi.md#usergroupdelegationeditobjectv1) | **PUT** /1/object/usergroupdelegation/{pkiUsergroupdelegationID} | Edit an existing Usergroupdelegation |
| [**UsergroupdelegationGetObjectV2**](ObjectUsergroupdelegationApi.md#usergroupdelegationgetobjectv2) | **GET** /2/object/usergroupdelegation/{pkiUsergroupdelegationID} | Retrieve an existing Usergroupdelegation |

<a id="usergroupdelegationcreateobjectv1"></a>
# **UsergroupdelegationCreateObjectV1**
> UsergroupdelegationCreateObjectV1Response UsergroupdelegationCreateObjectV1 (UsergroupdelegationCreateObjectV1Request usergroupdelegationCreateObjectV1Request)

Create a new Usergroupdelegation

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **usergroupdelegationCreateObjectV1Request** | [**UsergroupdelegationCreateObjectV1Request**](UsergroupdelegationCreateObjectV1Request.md) |  |  |

### Return type

[**UsergroupdelegationCreateObjectV1Response**](UsergroupdelegationCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergroupdelegationdeleteobjectv1"></a>
# **UsergroupdelegationDeleteObjectV1**
> UsergroupdelegationDeleteObjectV1Response UsergroupdelegationDeleteObjectV1 (int pkiUsergroupdelegationID)

Delete an existing Usergroupdelegation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupdelegationID** | **int** | The unique ID of the Usergroupdelegation |  |

### Return type

[**UsergroupdelegationDeleteObjectV1Response**](UsergroupdelegationDeleteObjectV1Response.md)

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

<a id="usergroupdelegationeditobjectv1"></a>
# **UsergroupdelegationEditObjectV1**
> UsergroupdelegationEditObjectV1Response UsergroupdelegationEditObjectV1 (int pkiUsergroupdelegationID, UsergroupdelegationEditObjectV1Request usergroupdelegationEditObjectV1Request)

Edit an existing Usergroupdelegation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupdelegationID** | **int** | The unique ID of the Usergroupdelegation |  |
| **usergroupdelegationEditObjectV1Request** | [**UsergroupdelegationEditObjectV1Request**](UsergroupdelegationEditObjectV1Request.md) |  |  |

### Return type

[**UsergroupdelegationEditObjectV1Response**](UsergroupdelegationEditObjectV1Response.md)

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

<a id="usergroupdelegationgetobjectv2"></a>
# **UsergroupdelegationGetObjectV2**
> UsergroupdelegationGetObjectV2Response UsergroupdelegationGetObjectV2 (int pkiUsergroupdelegationID)

Retrieve an existing Usergroupdelegation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupdelegationID** | **int** | The unique ID of the Usergroupdelegation |  |

### Return type

[**UsergroupdelegationGetObjectV2Response**](UsergroupdelegationGetObjectV2Response.md)

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


# eZmaxApi.Api.ObjectUsergroupmembershipApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UsergroupmembershipCreateObjectV1**](ObjectUsergroupmembershipApi.md#usergroupmembershipcreateobjectv1) | **POST** /1/object/usergroupmembership | Create a new Usergroupmembership |
| [**UsergroupmembershipDeleteObjectV1**](ObjectUsergroupmembershipApi.md#usergroupmembershipdeleteobjectv1) | **DELETE** /1/object/usergroupmembership/{pkiUsergroupmembershipID} | Delete an existing Usergroupmembership |
| [**UsergroupmembershipEditObjectV1**](ObjectUsergroupmembershipApi.md#usergroupmembershipeditobjectv1) | **PUT** /1/object/usergroupmembership/{pkiUsergroupmembershipID} | Edit an existing Usergroupmembership |
| [**UsergroupmembershipGetObjectV2**](ObjectUsergroupmembershipApi.md#usergroupmembershipgetobjectv2) | **GET** /2/object/usergroupmembership/{pkiUsergroupmembershipID} | Retrieve an existing Usergroupmembership |

<a id="usergroupmembershipcreateobjectv1"></a>
# **UsergroupmembershipCreateObjectV1**
> UsergroupmembershipCreateObjectV1Response UsergroupmembershipCreateObjectV1 (UsergroupmembershipCreateObjectV1Request usergroupmembershipCreateObjectV1Request)

Create a new Usergroupmembership

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **usergroupmembershipCreateObjectV1Request** | [**UsergroupmembershipCreateObjectV1Request**](UsergroupmembershipCreateObjectV1Request.md) |  |  |

### Return type

[**UsergroupmembershipCreateObjectV1Response**](UsergroupmembershipCreateObjectV1Response.md)

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

<a id="usergroupmembershipdeleteobjectv1"></a>
# **UsergroupmembershipDeleteObjectV1**
> UsergroupmembershipDeleteObjectV1Response UsergroupmembershipDeleteObjectV1 (int pkiUsergroupmembershipID)

Delete an existing Usergroupmembership


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupmembershipID** | **int** |  |  |

### Return type

[**UsergroupmembershipDeleteObjectV1Response**](UsergroupmembershipDeleteObjectV1Response.md)

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

<a id="usergroupmembershipeditobjectv1"></a>
# **UsergroupmembershipEditObjectV1**
> UsergroupmembershipEditObjectV1Response UsergroupmembershipEditObjectV1 (int pkiUsergroupmembershipID, UsergroupmembershipEditObjectV1Request usergroupmembershipEditObjectV1Request)

Edit an existing Usergroupmembership


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupmembershipID** | **int** |  |  |
| **usergroupmembershipEditObjectV1Request** | [**UsergroupmembershipEditObjectV1Request**](UsergroupmembershipEditObjectV1Request.md) |  |  |

### Return type

[**UsergroupmembershipEditObjectV1Response**](UsergroupmembershipEditObjectV1Response.md)

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

<a id="usergroupmembershipgetobjectv2"></a>
# **UsergroupmembershipGetObjectV2**
> UsergroupmembershipGetObjectV2Response UsergroupmembershipGetObjectV2 (int pkiUsergroupmembershipID)

Retrieve an existing Usergroupmembership


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupmembershipID** | **int** |  |  |

### Return type

[**UsergroupmembershipGetObjectV2Response**](UsergroupmembershipGetObjectV2Response.md)

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


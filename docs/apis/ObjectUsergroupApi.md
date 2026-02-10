# eZmaxApi.Api.ObjectUsergroupApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UsergroupCreateObjectV1**](ObjectUsergroupApi.md#usergroupcreateobjectv1) | **POST** /1/object/usergroup | Create a new Usergroup |
| [**UsergroupEditObjectV1**](ObjectUsergroupApi.md#usergroupeditobjectv1) | **PUT** /1/object/usergroup/{pkiUsergroupID} | Edit an existing Usergroup |
| [**UsergroupEditPermissionsV1**](ObjectUsergroupApi.md#usergroupeditpermissionsv1) | **PUT** /1/object/usergroup/{pkiUsergroupID}/editPermissions | Edit multiple Permissions |
| [**UsergroupEditUsergroupdelegationsV1**](ObjectUsergroupApi.md#usergroupeditusergroupdelegationsv1) | **PUT** /1/object/usergroup/{pkiUsergroupID}/editUsergroupdelegations | Edit multiple Usergroupdelegations |
| [**UsergroupEditUsergroupmembershipsV1**](ObjectUsergroupApi.md#usergroupeditusergroupmembershipsv1) | **PUT** /1/object/usergroup/{pkiUsergroupID}/editUsergroupmemberships | Edit multiple Usergroupmemberships |
| [**UsergroupGetAutocompleteV2**](ObjectUsergroupApi.md#usergroupgetautocompletev2) | **GET** /2/object/usergroup/getAutocomplete/{sSelector} | Retrieve Usergroups and IDs |
| [**UsergroupGetListV1**](ObjectUsergroupApi.md#usergroupgetlistv1) | **GET** /1/object/usergroup/getList | Retrieve Usergroup list |
| [**UsergroupGetObjectV2**](ObjectUsergroupApi.md#usergroupgetobjectv2) | **GET** /2/object/usergroup/{pkiUsergroupID} | Retrieve an existing Usergroup |
| [**UsergroupGetPermissionsV1**](ObjectUsergroupApi.md#usergroupgetpermissionsv1) | **GET** /1/object/usergroup/{pkiUsergroupID}/getPermissions | Retrieve an existing Usergroup&#39;s Permissions |
| [**UsergroupGetUsergroupdelegationsV1**](ObjectUsergroupApi.md#usergroupgetusergroupdelegationsv1) | **GET** /1/object/usergroup/{pkiUsergroupID}/getUsergroupdelegations | Retrieve an existing Usergroup&#39;s Usergroupdelegations |
| [**UsergroupGetUsergroupmembershipsV1**](ObjectUsergroupApi.md#usergroupgetusergroupmembershipsv1) | **GET** /1/object/usergroup/{pkiUsergroupID}/getUsergroupmemberships | Retrieve an existing Usergroup&#39;s Usergroupmemberships |

<a id="usergroupcreateobjectv1"></a>
# **UsergroupCreateObjectV1**
> UsergroupCreateObjectV1Response UsergroupCreateObjectV1 (UsergroupCreateObjectV1Request usergroupCreateObjectV1Request)

Create a new Usergroup

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **usergroupCreateObjectV1Request** | [**UsergroupCreateObjectV1Request**](UsergroupCreateObjectV1Request.md) |  |  |

### Return type

[**UsergroupCreateObjectV1Response**](UsergroupCreateObjectV1Response.md)

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

<a id="usergroupeditobjectv1"></a>
# **UsergroupEditObjectV1**
> UsergroupEditObjectV1Response UsergroupEditObjectV1 (int pkiUsergroupID, UsergroupEditObjectV1Request usergroupEditObjectV1Request)

Edit an existing Usergroup


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupID** | **int** |  |  |
| **usergroupEditObjectV1Request** | [**UsergroupEditObjectV1Request**](UsergroupEditObjectV1Request.md) |  |  |

### Return type

[**UsergroupEditObjectV1Response**](UsergroupEditObjectV1Response.md)

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

<a id="usergroupeditpermissionsv1"></a>
# **UsergroupEditPermissionsV1**
> UsergroupEditPermissionsV1Response UsergroupEditPermissionsV1 (int pkiUsergroupID, UsergroupEditPermissionsV1Request usergroupEditPermissionsV1Request)

Edit multiple Permissions

Using this endpoint, you can edit multiple Permissions at the same time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupID** | **int** |  |  |
| **usergroupEditPermissionsV1Request** | [**UsergroupEditPermissionsV1Request**](UsergroupEditPermissionsV1Request.md) |  |  |

### Return type

[**UsergroupEditPermissionsV1Response**](UsergroupEditPermissionsV1Response.md)

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

<a id="usergroupeditusergroupdelegationsv1"></a>
# **UsergroupEditUsergroupdelegationsV1**
> UsergroupEditUsergroupdelegationsV1Response UsergroupEditUsergroupdelegationsV1 (int pkiUsergroupID, UsergroupEditUsergroupdelegationsV1Request usergroupEditUsergroupdelegationsV1Request)

Edit multiple Usergroupdelegations

Edit multiple Usergroupdelegations


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupID** | **int** |  |  |
| **usergroupEditUsergroupdelegationsV1Request** | [**UsergroupEditUsergroupdelegationsV1Request**](UsergroupEditUsergroupdelegationsV1Request.md) |  |  |

### Return type

[**UsergroupEditUsergroupdelegationsV1Response**](UsergroupEditUsergroupdelegationsV1Response.md)

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

<a id="usergroupeditusergroupmembershipsv1"></a>
# **UsergroupEditUsergroupmembershipsV1**
> UsergroupEditUsergroupmembershipsV1Response UsergroupEditUsergroupmembershipsV1 (int pkiUsergroupID, UsergroupEditUsergroupmembershipsV1Request usergroupEditUsergroupmembershipsV1Request)

Edit multiple Usergroupmemberships

Using this endpoint, you can edit multiple Usergroupmemberships at the same time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupID** | **int** |  |  |
| **usergroupEditUsergroupmembershipsV1Request** | [**UsergroupEditUsergroupmembershipsV1Request**](UsergroupEditUsergroupmembershipsV1Request.md) |  |  |

### Return type

[**UsergroupEditUsergroupmembershipsV1Response**](UsergroupEditUsergroupmembershipsV1Response.md)

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

<a id="usergroupgetautocompletev2"></a>
# **UsergroupGetAutocompleteV2**
> UsergroupGetAutocompleteV2Response UsergroupGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Usergroups and IDs

Get the list of Usergroup to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Usergroups to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**UsergroupGetAutocompleteV2Response**](UsergroupGetAutocompleteV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergroupgetlistv1"></a>
# **UsergroupGetListV1**
> UsergroupGetListV1Response UsergroupGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Usergroup list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**UsergroupGetListV1Response**](UsergroupGetListV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergroupgetobjectv2"></a>
# **UsergroupGetObjectV2**
> UsergroupGetObjectV2Response UsergroupGetObjectV2 (int pkiUsergroupID)

Retrieve an existing Usergroup


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupID** | **int** |  |  |

### Return type

[**UsergroupGetObjectV2Response**](UsergroupGetObjectV2Response.md)

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

<a id="usergroupgetpermissionsv1"></a>
# **UsergroupGetPermissionsV1**
> UsergroupGetPermissionsV1Response UsergroupGetPermissionsV1 (int pkiUsergroupID)

Retrieve an existing Usergroup's Permissions


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupID** | **int** |  |  |

### Return type

[**UsergroupGetPermissionsV1Response**](UsergroupGetPermissionsV1Response.md)

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

<a id="usergroupgetusergroupdelegationsv1"></a>
# **UsergroupGetUsergroupdelegationsV1**
> UsergroupGetUsergroupdelegationsV1Response UsergroupGetUsergroupdelegationsV1 (int pkiUsergroupID)

Retrieve an existing Usergroup's Usergroupdelegations


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupID** | **int** |  |  |

### Return type

[**UsergroupGetUsergroupdelegationsV1Response**](UsergroupGetUsergroupdelegationsV1Response.md)

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

<a id="usergroupgetusergroupmembershipsv1"></a>
# **UsergroupGetUsergroupmembershipsV1**
> UsergroupGetUsergroupmembershipsV1Response UsergroupGetUsergroupmembershipsV1 (int pkiUsergroupID)

Retrieve an existing Usergroup's Usergroupmemberships


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUsergroupID** | **int** |  |  |

### Return type

[**UsergroupGetUsergroupmembershipsV1Response**](UsergroupGetUsergroupmembershipsV1Response.md)

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


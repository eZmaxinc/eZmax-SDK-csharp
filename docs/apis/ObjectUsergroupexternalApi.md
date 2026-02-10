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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergroupexternaldeleteobjectv1"></a>
# **UsergroupexternalDeleteObjectV1**
> UsergroupexternalDeleteObjectV1Response UsergroupexternalDeleteObjectV1 (int pkiUsergroupexternalID)

Delete an existing Usergroupexternal


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergroupexternaleditobjectv1"></a>
# **UsergroupexternalEditObjectV1**
> UsergroupexternalEditObjectV1Response UsergroupexternalEditObjectV1 (int pkiUsergroupexternalID, UsergroupexternalEditObjectV1Request usergroupexternalEditObjectV1Request)

Edit an existing Usergroupexternal


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergroupexternalgetautocompletev2"></a>
# **UsergroupexternalGetAutocompleteV2**
> UsergroupexternalGetAutocompleteV2Response UsergroupexternalGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Usergroupexternals and IDs

Get the list of Usergroupexternal to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Usergroupexternals to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergroupexternalgetlistv1"></a>
# **UsergroupexternalGetListV1**
> UsergroupexternalGetListV1Response UsergroupexternalGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Usergroupexternal list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergroupexternalgetobjectv2"></a>
# **UsergroupexternalGetObjectV2**
> UsergroupexternalGetObjectV2Response UsergroupexternalGetObjectV2 (int pkiUsergroupexternalID)

Retrieve an existing Usergroupexternal


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergroupexternalgetusergroupexternalmembershipsv1"></a>
# **UsergroupexternalGetUsergroupexternalmembershipsV1**
> UsergroupexternalGetUsergroupexternalmembershipsV1Response UsergroupexternalGetUsergroupexternalmembershipsV1 (int pkiUsergroupexternalID)

Retrieve an existing Usergroupexternal's Usergroupexternalmemberships


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergroupexternalgetusergroupsv1"></a>
# **UsergroupexternalGetUsergroupsV1**
> UsergroupexternalGetUsergroupsV1Response UsergroupexternalGetUsergroupsV1 (int pkiUsergroupexternalID)

Get Usergroupexternal's Usergroups


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


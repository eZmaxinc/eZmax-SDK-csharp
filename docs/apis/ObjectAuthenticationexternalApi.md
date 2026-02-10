# eZmaxApi.Api.ObjectAuthenticationexternalApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthenticationexternalCreateObjectV1**](ObjectAuthenticationexternalApi.md#authenticationexternalcreateobjectv1) | **POST** /1/object/authenticationexternal | Create a new Authenticationexternal |
| [**AuthenticationexternalDeleteObjectV1**](ObjectAuthenticationexternalApi.md#authenticationexternaldeleteobjectv1) | **DELETE** /1/object/authenticationexternal/{pkiAuthenticationexternalID} | Delete an existing Authenticationexternal |
| [**AuthenticationexternalEditObjectV1**](ObjectAuthenticationexternalApi.md#authenticationexternaleditobjectv1) | **PUT** /1/object/authenticationexternal/{pkiAuthenticationexternalID} | Edit an existing Authenticationexternal |
| [**AuthenticationexternalGetAutocompleteV2**](ObjectAuthenticationexternalApi.md#authenticationexternalgetautocompletev2) | **GET** /2/object/authenticationexternal/getAutocomplete/{sSelector} | Retrieve Authenticationexternals and IDs |
| [**AuthenticationexternalGetListV1**](ObjectAuthenticationexternalApi.md#authenticationexternalgetlistv1) | **GET** /1/object/authenticationexternal/getList | Retrieve Authenticationexternal list |
| [**AuthenticationexternalGetObjectV2**](ObjectAuthenticationexternalApi.md#authenticationexternalgetobjectv2) | **GET** /2/object/authenticationexternal/{pkiAuthenticationexternalID} | Retrieve an existing Authenticationexternal |
| [**AuthenticationexternalResetAuthorizationV1**](ObjectAuthenticationexternalApi.md#authenticationexternalresetauthorizationv1) | **POST** /1/object/authenticationexternal/{pkiAuthenticationexternalID}/resetAuthorization | Reset the Authenticationexternal authorization |

<a id="authenticationexternalcreateobjectv1"></a>
# **AuthenticationexternalCreateObjectV1**
> AuthenticationexternalCreateObjectV1Response AuthenticationexternalCreateObjectV1 (AuthenticationexternalCreateObjectV1Request authenticationexternalCreateObjectV1Request)

Create a new Authenticationexternal

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authenticationexternalCreateObjectV1Request** | [**AuthenticationexternalCreateObjectV1Request**](AuthenticationexternalCreateObjectV1Request.md) |  |  |

### Return type

[**AuthenticationexternalCreateObjectV1Response**](AuthenticationexternalCreateObjectV1Response.md)

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

<a id="authenticationexternaldeleteobjectv1"></a>
# **AuthenticationexternalDeleteObjectV1**
> AuthenticationexternalDeleteObjectV1Response AuthenticationexternalDeleteObjectV1 (int pkiAuthenticationexternalID)

Delete an existing Authenticationexternal


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAuthenticationexternalID** | **int** | The unique ID of the Authenticationexternal |  |

### Return type

[**AuthenticationexternalDeleteObjectV1Response**](AuthenticationexternalDeleteObjectV1Response.md)

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

<a id="authenticationexternaleditobjectv1"></a>
# **AuthenticationexternalEditObjectV1**
> AuthenticationexternalEditObjectV1Response AuthenticationexternalEditObjectV1 (int pkiAuthenticationexternalID, AuthenticationexternalEditObjectV1Request authenticationexternalEditObjectV1Request)

Edit an existing Authenticationexternal


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAuthenticationexternalID** | **int** | The unique ID of the Authenticationexternal |  |
| **authenticationexternalEditObjectV1Request** | [**AuthenticationexternalEditObjectV1Request**](AuthenticationexternalEditObjectV1Request.md) |  |  |

### Return type

[**AuthenticationexternalEditObjectV1Response**](AuthenticationexternalEditObjectV1Response.md)

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

<a id="authenticationexternalgetautocompletev2"></a>
# **AuthenticationexternalGetAutocompleteV2**
> AuthenticationexternalGetAutocompleteV2Response AuthenticationexternalGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Authenticationexternals and IDs

Get the list of Authenticationexternal to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Authenticationexternals to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**AuthenticationexternalGetAutocompleteV2Response**](AuthenticationexternalGetAutocompleteV2Response.md)

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

<a id="authenticationexternalgetlistv1"></a>
# **AuthenticationexternalGetListV1**
> AuthenticationexternalGetListV1Response AuthenticationexternalGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Authenticationexternal list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eAuthenticationexternalType | Salesforce<br>SalesforceSandbox |


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**AuthenticationexternalGetListV1Response**](AuthenticationexternalGetListV1Response.md)

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

<a id="authenticationexternalgetobjectv2"></a>
# **AuthenticationexternalGetObjectV2**
> AuthenticationexternalGetObjectV2Response AuthenticationexternalGetObjectV2 (int pkiAuthenticationexternalID)

Retrieve an existing Authenticationexternal


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAuthenticationexternalID** | **int** | The unique ID of the Authenticationexternal |  |

### Return type

[**AuthenticationexternalGetObjectV2Response**](AuthenticationexternalGetObjectV2Response.md)

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

<a id="authenticationexternalresetauthorizationv1"></a>
# **AuthenticationexternalResetAuthorizationV1**
> AuthenticationexternalResetAuthorizationV1Response AuthenticationexternalResetAuthorizationV1 (int pkiAuthenticationexternalID, Object body)

Reset the Authenticationexternal authorization


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAuthenticationexternalID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**AuthenticationexternalResetAuthorizationV1Response**](AuthenticationexternalResetAuthorizationV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


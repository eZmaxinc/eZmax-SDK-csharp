# eZmaxApi.Api.ObjectApikeyApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApikeyCreateObjectV2**](ObjectApikeyApi.md#apikeycreateobjectv2) | **POST** /2/object/apikey | Create a new Apikey |
| [**ApikeyEditObjectV1**](ObjectApikeyApi.md#apikeyeditobjectv1) | **PUT** /1/object/apikey/{pkiApikeyID} | Edit an existing Apikey |
| [**ApikeyEditPermissionsV1**](ObjectApikeyApi.md#apikeyeditpermissionsv1) | **PUT** /1/object/apikey/{pkiApikeyID}/editPermissions | Edit multiple Permissions |
| [**ApikeyGenerateDelegatedCredentialsV1**](ObjectApikeyApi.md#apikeygeneratedelegatedcredentialsv1) | **POST** /1/object/apikey/generateDelegatedCredentials | Generate a delegated credentials |
| [**ApikeyGetCorsV1**](ObjectApikeyApi.md#apikeygetcorsv1) | **GET** /1/object/apikey/{pkiApikeyID}/getCors | Retrieve an existing Apikey&#39;s cors |
| [**ApikeyGetListV1**](ObjectApikeyApi.md#apikeygetlistv1) | **GET** /1/object/apikey/getList | Retrieve Apikey list |
| [**ApikeyGetObjectV2**](ObjectApikeyApi.md#apikeygetobjectv2) | **GET** /2/object/apikey/{pkiApikeyID} | Retrieve an existing Apikey |
| [**ApikeyGetPermissionsV1**](ObjectApikeyApi.md#apikeygetpermissionsv1) | **GET** /1/object/apikey/{pkiApikeyID}/getPermissions | Retrieve an existing Apikey&#39;s Permissions |
| [**ApikeyGetSubnetsV1**](ObjectApikeyApi.md#apikeygetsubnetsv1) | **GET** /1/object/apikey/{pkiApikeyID}/getSubnets | Retrieve an existing Apikey&#39;s subnets |
| [**ApikeyRegenerateV1**](ObjectApikeyApi.md#apikeyregeneratev1) | **POST** /1/object/apikey/{pkiApikeyID}/regenerate | Regenerate the Apikey |

<a id="apikeycreateobjectv2"></a>
# **ApikeyCreateObjectV2**
> ApikeyCreateObjectV2Response ApikeyCreateObjectV2 (ApikeyCreateObjectV2Request apikeyCreateObjectV2Request)

Create a new Apikey

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikeyCreateObjectV2Request** | [**ApikeyCreateObjectV2Request**](ApikeyCreateObjectV2Request.md) |  |  |

### Return type

[**ApikeyCreateObjectV2Response**](ApikeyCreateObjectV2Response.md)

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

<a id="apikeyeditobjectv1"></a>
# **ApikeyEditObjectV1**
> ApikeyEditObjectV1Response ApikeyEditObjectV1 (int pkiApikeyID, ApikeyEditObjectV1Request apikeyEditObjectV1Request)

Edit an existing Apikey


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiApikeyID** | **int** | The unique ID of the Apikey |  |
| **apikeyEditObjectV1Request** | [**ApikeyEditObjectV1Request**](ApikeyEditObjectV1Request.md) |  |  |

### Return type

[**ApikeyEditObjectV1Response**](ApikeyEditObjectV1Response.md)

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

<a id="apikeyeditpermissionsv1"></a>
# **ApikeyEditPermissionsV1**
> ApikeyEditPermissionsV1Response ApikeyEditPermissionsV1 (int pkiApikeyID, ApikeyEditPermissionsV1Request apikeyEditPermissionsV1Request)

Edit multiple Permissions

Using this endpoint, you can edit multiple Permissions at the same time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiApikeyID** | **int** |  |  |
| **apikeyEditPermissionsV1Request** | [**ApikeyEditPermissionsV1Request**](ApikeyEditPermissionsV1Request.md) |  |  |

### Return type

[**ApikeyEditPermissionsV1Response**](ApikeyEditPermissionsV1Response.md)

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

<a id="apikeygeneratedelegatedcredentialsv1"></a>
# **ApikeyGenerateDelegatedCredentialsV1**
> ApikeyGenerateDelegatedCredentialsV1Response ApikeyGenerateDelegatedCredentialsV1 (ApikeyGenerateDelegatedCredentialsV1Request apikeyGenerateDelegatedCredentialsV1Request)

Generate a delegated credentials


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikeyGenerateDelegatedCredentialsV1Request** | [**ApikeyGenerateDelegatedCredentialsV1Request**](ApikeyGenerateDelegatedCredentialsV1Request.md) |  |  |

### Return type

[**ApikeyGenerateDelegatedCredentialsV1Response**](ApikeyGenerateDelegatedCredentialsV1Response.md)

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

<a id="apikeygetcorsv1"></a>
# **ApikeyGetCorsV1**
> ApikeyGetCorsV1Response ApikeyGetCorsV1 (int pkiApikeyID)

Retrieve an existing Apikey's cors


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiApikeyID** | **int** |  |  |

### Return type

[**ApikeyGetCorsV1Response**](ApikeyGetCorsV1Response.md)

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

<a id="apikeygetlistv1"></a>
# **ApikeyGetListV1**
> ApikeyGetListV1Response ApikeyGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Apikey list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --|


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**ApikeyGetListV1Response**](ApikeyGetListV1Response.md)

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

<a id="apikeygetobjectv2"></a>
# **ApikeyGetObjectV2**
> ApikeyGetObjectV2Response ApikeyGetObjectV2 (int pkiApikeyID)

Retrieve an existing Apikey


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiApikeyID** | **int** | The unique ID of the Apikey |  |

### Return type

[**ApikeyGetObjectV2Response**](ApikeyGetObjectV2Response.md)

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

<a id="apikeygetpermissionsv1"></a>
# **ApikeyGetPermissionsV1**
> ApikeyGetPermissionsV1Response ApikeyGetPermissionsV1 (int pkiApikeyID)

Retrieve an existing Apikey's Permissions


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiApikeyID** | **int** |  |  |

### Return type

[**ApikeyGetPermissionsV1Response**](ApikeyGetPermissionsV1Response.md)

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

<a id="apikeygetsubnetsv1"></a>
# **ApikeyGetSubnetsV1**
> ApikeyGetSubnetsV1Response ApikeyGetSubnetsV1 (int pkiApikeyID)

Retrieve an existing Apikey's subnets


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiApikeyID** | **int** |  |  |

### Return type

[**ApikeyGetSubnetsV1Response**](ApikeyGetSubnetsV1Response.md)

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

<a id="apikeyregeneratev1"></a>
# **ApikeyRegenerateV1**
> ApikeyRegenerateV1Response ApikeyRegenerateV1 (int pkiApikeyID, ApikeyRegenerateV1Request apikeyRegenerateV1Request)

Regenerate the Apikey


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiApikeyID** | **int** |  |  |
| **apikeyRegenerateV1Request** | [**ApikeyRegenerateV1Request**](ApikeyRegenerateV1Request.md) |  |  |

### Return type

[**ApikeyRegenerateV1Response**](ApikeyRegenerateV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


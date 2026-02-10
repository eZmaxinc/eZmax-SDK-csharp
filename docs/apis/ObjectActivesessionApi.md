# eZmaxApi.Api.ObjectActivesessionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivesessionGenerateFederationTokenV1**](ObjectActivesessionApi.md#activesessiongeneratefederationtokenv1) | **POST** /1/object/activesession/generateFederationToken | Generate a federation token |
| [**ActivesessionGetCurrentV1**](ObjectActivesessionApi.md#activesessiongetcurrentv1) | **GET** /1/object/activesession/getCurrent | Get Current Activesession |
| [**ActivesessionGetCurrentV2**](ObjectActivesessionApi.md#activesessiongetcurrentv2) | **GET** /2/object/activesession/getCurrent | Get Current Activesession |
| [**ActivesessionGetListV1**](ObjectActivesessionApi.md#activesessiongetlistv1) | **GET** /1/object/activesession/getList | Retrieve Activesession list |

<a id="activesessiongeneratefederationtokenv1"></a>
# **ActivesessionGenerateFederationTokenV1**
> ActivesessionGenerateFederationTokenV1Response ActivesessionGenerateFederationTokenV1 (ActivesessionGenerateFederationTokenV1Request activesessionGenerateFederationTokenV1Request)

Generate a federation token


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activesessionGenerateFederationTokenV1Request** | [**ActivesessionGenerateFederationTokenV1Request**](ActivesessionGenerateFederationTokenV1Request.md) |  |  |

### Return type

[**ActivesessionGenerateFederationTokenV1Response**](ActivesessionGenerateFederationTokenV1Response.md)

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

<a id="activesessiongetcurrentv1"></a>
# **ActivesessionGetCurrentV1**
> ActivesessionGetCurrentV1Response ActivesessionGetCurrentV1 ()

Get Current Activesession

Retrieve the details about the current activesession


### Parameters
This endpoint does not need any parameter.
### Return type

[**ActivesessionGetCurrentV1Response**](ActivesessionGetCurrentV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **350** | The user must authenticate before he can continue with this request |  -  |
| **351** | The user is configured with 2FA and needs to validate its phone number before he can continue with this request |  -  |
| **352** | The user is configured with 2FA and needs to answer a Secretquestion before he can continue with this request |  -  |
| **353** | The user must accept clauses before he can continue with this request |  -  |
| **354** | The user&#39;s computer must be validated before he can continue with this request |  -  |
| **355** | The user must change its password before he can continue with this request |  -  |
| **356** | The user is not running the latest version of the native application. He must valide or update its version before he can continue with this request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="activesessiongetcurrentv2"></a>
# **ActivesessionGetCurrentV2**
> ActivesessionGetCurrentV2Response ActivesessionGetCurrentV2 ()

Get Current Activesession

Retrieve the details about the current activesession


### Parameters
This endpoint does not need any parameter.
### Return type

[**ActivesessionGetCurrentV2Response**](ActivesessionGetCurrentV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **350** | The user must authenticate before he can continue with this request |  -  |
| **351** | The user is configured with 2FA and needs to validate its phone number before he can continue with this request |  -  |
| **352** | The user is configured with 2FA and needs to answer a Secretquestion before he can continue with this request |  -  |
| **353** | The user must accept clauses before he can continue with this request |  -  |
| **354** | The user&#39;s computer must be validated before he can continue with this request |  -  |
| **355** | The user must change its password before he can continue with this request |  -  |
| **356** | The user is not running the latest version of the native application. He must valide or update its version before he can continue with this request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="activesessiongetlistv1"></a>
# **ActivesessionGetListV1**
> ActivesessionGetListV1Response ActivesessionGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Activesession list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**ActivesessionGetListV1Response**](ActivesessionGetListV1Response.md)

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


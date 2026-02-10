# eZmaxApi.Api.ObjectEzsignfoldertypeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignfoldertypeCreateObjectV3**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypecreateobjectv3) | **POST** /3/object/ezsignfoldertype | Create a new Ezsignfoldertype |
| [**EzsignfoldertypeEditObjectV3**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypeeditobjectv3) | **PUT** /3/object/ezsignfoldertype/{pkiEzsignfoldertypeID} | Edit an existing Ezsignfoldertype |
| [**EzsignfoldertypeGetAutocompleteV2**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypegetautocompletev2) | **GET** /2/object/ezsignfoldertype/getAutocomplete/{sSelector} | Retrieve Ezsignfoldertypes and IDs |
| [**EzsignfoldertypeGetListV1**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypegetlistv1) | **GET** /1/object/ezsignfoldertype/getList | Retrieve Ezsignfoldertype list |
| [**EzsignfoldertypeGetObjectV2**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypegetobjectv2) | **GET** /2/object/ezsignfoldertype/{pkiEzsignfoldertypeID} | Retrieve an existing Ezsignfoldertype |
| [**EzsignfoldertypeGetObjectV4**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypegetobjectv4) | **GET** /4/object/ezsignfoldertype/{pkiEzsignfoldertypeID} | Retrieve an existing Ezsignfoldertype |

<a id="ezsignfoldertypecreateobjectv3"></a>
# **EzsignfoldertypeCreateObjectV3**
> EzsignfoldertypeCreateObjectV3Response EzsignfoldertypeCreateObjectV3 (EzsignfoldertypeCreateObjectV3Request ezsignfoldertypeCreateObjectV3Request)

Create a new Ezsignfoldertype

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignfoldertypeCreateObjectV3Request** | [**EzsignfoldertypeCreateObjectV3Request**](EzsignfoldertypeCreateObjectV3Request.md) |  |  |

### Return type

[**EzsignfoldertypeCreateObjectV3Response**](EzsignfoldertypeCreateObjectV3Response.md)

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

<a id="ezsignfoldertypeeditobjectv3"></a>
# **EzsignfoldertypeEditObjectV3**
> EzsignfoldertypeEditObjectV3Response EzsignfoldertypeEditObjectV3 (int pkiEzsignfoldertypeID, EzsignfoldertypeEditObjectV3Request ezsignfoldertypeEditObjectV3Request)

Edit an existing Ezsignfoldertype


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldertypeID** | **int** |  |  |
| **ezsignfoldertypeEditObjectV3Request** | [**EzsignfoldertypeEditObjectV3Request**](EzsignfoldertypeEditObjectV3Request.md) |  |  |

### Return type

[**EzsignfoldertypeEditObjectV3Response**](EzsignfoldertypeEditObjectV3Response.md)

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

<a id="ezsignfoldertypegetautocompletev2"></a>
# **EzsignfoldertypeGetAutocompleteV2**
> EzsignfoldertypeGetAutocompleteV2Response EzsignfoldertypeGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Ezsignfoldertypes and IDs

Get the list of Ezsignfoldertype to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Ezsignfoldertypes to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**EzsignfoldertypeGetAutocompleteV2Response**](EzsignfoldertypeGetAutocompleteV2Response.md)

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

<a id="ezsignfoldertypegetlistv1"></a>
# **EzsignfoldertypeGetListV1**
> EzsignfoldertypeGetListV1Response EzsignfoldertypeGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Ezsignfoldertype list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eEzsignfoldertypePrivacylevel | User<br>Usergroup |


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**EzsignfoldertypeGetListV1Response**](EzsignfoldertypeGetListV1Response.md)

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

<a id="ezsignfoldertypegetobjectv2"></a>
# **EzsignfoldertypeGetObjectV2**
> EzsignfoldertypeGetObjectV2Response EzsignfoldertypeGetObjectV2 (int pkiEzsignfoldertypeID)

Retrieve an existing Ezsignfoldertype


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldertypeID** | **int** |  |  |

### Return type

[**EzsignfoldertypeGetObjectV2Response**](EzsignfoldertypeGetObjectV2Response.md)

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

<a id="ezsignfoldertypegetobjectv4"></a>
# **EzsignfoldertypeGetObjectV4**
> EzsignfoldertypeGetObjectV4Response EzsignfoldertypeGetObjectV4 (int pkiEzsignfoldertypeID)

Retrieve an existing Ezsignfoldertype


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldertypeID** | **int** |  |  |

### Return type

[**EzsignfoldertypeGetObjectV4Response**](EzsignfoldertypeGetObjectV4Response.md)

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


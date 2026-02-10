# eZmaxApi.Api.ObjectEzsigntemplateApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplateCopyV1**](ObjectEzsigntemplateApi.md#ezsigntemplatecopyv1) | **POST** /1/object/ezsigntemplate/{pkiEzsigntemplateID}/copy | Copy the Ezsigntemplate |
| [**EzsigntemplateCreateObjectV3**](ObjectEzsigntemplateApi.md#ezsigntemplatecreateobjectv3) | **POST** /3/object/ezsigntemplate | Create a new Ezsigntemplate |
| [**EzsigntemplateDeleteObjectV1**](ObjectEzsigntemplateApi.md#ezsigntemplatedeleteobjectv1) | **DELETE** /1/object/ezsigntemplate/{pkiEzsigntemplateID} | Delete an existing Ezsigntemplate |
| [**EzsigntemplateEditObjectV3**](ObjectEzsigntemplateApi.md#ezsigntemplateeditobjectv3) | **PUT** /3/object/ezsigntemplate/{pkiEzsigntemplateID} | Edit an existing Ezsigntemplate |
| [**EzsigntemplateGetAutocompleteV2**](ObjectEzsigntemplateApi.md#ezsigntemplategetautocompletev2) | **GET** /2/object/ezsigntemplate/getAutocomplete/{sSelector} | Retrieve Ezsigntemplates and IDs |
| [**EzsigntemplateGetListV1**](ObjectEzsigntemplateApi.md#ezsigntemplategetlistv1) | **GET** /1/object/ezsigntemplate/getList | Retrieve Ezsigntemplate list |
| [**EzsigntemplateGetObjectV3**](ObjectEzsigntemplateApi.md#ezsigntemplategetobjectv3) | **GET** /3/object/ezsigntemplate/{pkiEzsigntemplateID} | Retrieve an existing Ezsigntemplate |

<a id="ezsigntemplatecopyv1"></a>
# **EzsigntemplateCopyV1**
> EzsigntemplateCopyV1Response EzsigntemplateCopyV1 (int pkiEzsigntemplateID, EzsigntemplateCopyV1Request ezsigntemplateCopyV1Request)

Copy the Ezsigntemplate


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateID** | **int** |  |  |
| **ezsigntemplateCopyV1Request** | [**EzsigntemplateCopyV1Request**](EzsigntemplateCopyV1Request.md) |  |  |

### Return type

[**EzsigntemplateCopyV1Response**](EzsigntemplateCopyV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsigntemplatecreateobjectv3"></a>
# **EzsigntemplateCreateObjectV3**
> EzsigntemplateCreateObjectV3Response EzsigntemplateCreateObjectV3 (EzsigntemplateCreateObjectV3Request ezsigntemplateCreateObjectV3Request)

Create a new Ezsigntemplate

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplateCreateObjectV3Request** | [**EzsigntemplateCreateObjectV3Request**](EzsigntemplateCreateObjectV3Request.md) |  |  |

### Return type

[**EzsigntemplateCreateObjectV3Response**](EzsigntemplateCreateObjectV3Response.md)

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

<a id="ezsigntemplatedeleteobjectv1"></a>
# **EzsigntemplateDeleteObjectV1**
> EzsigntemplateDeleteObjectV1Response EzsigntemplateDeleteObjectV1 (int pkiEzsigntemplateID)

Delete an existing Ezsigntemplate


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateID** | **int** |  |  |

### Return type

[**EzsigntemplateDeleteObjectV1Response**](EzsigntemplateDeleteObjectV1Response.md)

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

<a id="ezsigntemplateeditobjectv3"></a>
# **EzsigntemplateEditObjectV3**
> EzsigntemplateEditObjectV3Response EzsigntemplateEditObjectV3 (int pkiEzsigntemplateID, EzsigntemplateEditObjectV3Request ezsigntemplateEditObjectV3Request)

Edit an existing Ezsigntemplate


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateID** | **int** |  |  |
| **ezsigntemplateEditObjectV3Request** | [**EzsigntemplateEditObjectV3Request**](EzsigntemplateEditObjectV3Request.md) |  |  |

### Return type

[**EzsigntemplateEditObjectV3Response**](EzsigntemplateEditObjectV3Response.md)

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

<a id="ezsigntemplategetautocompletev2"></a>
# **EzsigntemplateGetAutocompleteV2**
> EzsigntemplateGetAutocompleteV2Response EzsigntemplateGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null, int fkiEzsignfoldertypeID = null)

Retrieve Ezsigntemplates and IDs

Get the list of Ezsigntemplate to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Ezsigntemplates to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **fkiEzsignfoldertypeID** | **int** | The fkiEzsignfoldertypeID to use with the selector Ezsigntemplatepublic | [optional]  |

### Return type

[**EzsigntemplateGetAutocompleteV2Response**](EzsigntemplateGetAutocompleteV2Response.md)

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

<a id="ezsigntemplategetlistv1"></a>
# **EzsigntemplateGetListV1**
> EzsigntemplateGetListV1Response EzsigntemplateGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Ezsigntemplate list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eEzsigntemplateType | Company<br>Team<br>User<br>Usergroup | 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**EzsigntemplateGetListV1Response**](EzsigntemplateGetListV1Response.md)

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

<a id="ezsigntemplategetobjectv3"></a>
# **EzsigntemplateGetObjectV3**
> EzsigntemplateGetObjectV3Response EzsigntemplateGetObjectV3 (int pkiEzsigntemplateID)

Retrieve an existing Ezsigntemplate


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateID** | **int** |  |  |

### Return type

[**EzsigntemplateGetObjectV3Response**](EzsigntemplateGetObjectV3Response.md)

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


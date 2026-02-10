# eZmaxApi.Api.ObjectEzsigntemplatepublicApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplatepublicCreateEzsignfolderV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepubliccreateezsignfolderv1) | **POST** /1/object/ezsigntemplatepublic/createEzsignfolder | Create an Ezsignfolder |
| [**EzsigntemplatepublicCreateObjectV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepubliccreateobjectv1) | **POST** /1/object/ezsigntemplatepublic | Create a new Ezsigntemplatepublic |
| [**EzsigntemplatepublicDeleteObjectV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepublicdeleteobjectv1) | **DELETE** /1/object/ezsigntemplatepublic/{pkiEzsigntemplatepublicID} | Delete an existing Ezsigntemplatepublic |
| [**EzsigntemplatepublicEditObjectV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepubliceditobjectv1) | **PUT** /1/object/ezsigntemplatepublic/{pkiEzsigntemplatepublicID} | Edit an existing Ezsigntemplatepublic |
| [**EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepublicgetezsigntemplatepublicdetailsv1) | **POST** /1/object/ezsigntemplatepublic/getEzsigntemplatepublicDetails | Retrieve the Ezsigntemplatepublic details |
| [**EzsigntemplatepublicGetFormsDataV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepublicgetformsdatav1) | **GET** /1/object/ezsigntemplatepublic/{pkiEzsigntemplatepublicID}/getFormsData | Retrieve an existing Ezsigntemplatepublic&#39;s forms data |
| [**EzsigntemplatepublicGetListV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepublicgetlistv1) | **GET** /1/object/ezsigntemplatepublic/getList | Retrieve Ezsigntemplatepublic list |
| [**EzsigntemplatepublicGetObjectV2**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepublicgetobjectv2) | **GET** /2/object/ezsigntemplatepublic/{pkiEzsigntemplatepublicID} | Retrieve an existing Ezsigntemplatepublic |
| [**EzsigntemplatepublicResetLimitExceededCounterV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepublicresetlimitexceededcounterv1) | **POST** /1/object/ezsigntemplatepublic/{pkiEzsigntemplatepublicID}/resetLimitExceededCounter | Reset the limit exceeded counter |
| [**EzsigntemplatepublicResetUrlV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepublicreseturlv1) | **POST** /1/object/ezsigntemplatepublic/{pkiEzsigntemplatepublicID}/resetUrl | Reset the Ezsigntemplatepublic url |

<a id="ezsigntemplatepubliccreateezsignfolderv1"></a>
# **EzsigntemplatepublicCreateEzsignfolderV1**
> EzsigntemplatepublicCreateEzsignfolderV1Response EzsigntemplatepublicCreateEzsignfolderV1 (EzsigntemplatepublicCreateEzsignfolderV1Request ezsigntemplatepublicCreateEzsignfolderV1Request)

Create an Ezsignfolder

Create an Ezsignfolder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatepublicCreateEzsignfolderV1Request** | [**EzsigntemplatepublicCreateEzsignfolderV1Request**](EzsigntemplatepublicCreateEzsignfolderV1Request.md) |  |  |

### Return type

[**EzsigntemplatepublicCreateEzsignfolderV1Response**](EzsigntemplatepublicCreateEzsignfolderV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsigntemplatepubliccreateobjectv1"></a>
# **EzsigntemplatepublicCreateObjectV1**
> EzsigntemplatepublicCreateObjectV1Response EzsigntemplatepublicCreateObjectV1 (EzsigntemplatepublicCreateObjectV1Request ezsigntemplatepublicCreateObjectV1Request)

Create a new Ezsigntemplatepublic

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatepublicCreateObjectV1Request** | [**EzsigntemplatepublicCreateObjectV1Request**](EzsigntemplatepublicCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatepublicCreateObjectV1Response**](EzsigntemplatepublicCreateObjectV1Response.md)

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

<a id="ezsigntemplatepublicdeleteobjectv1"></a>
# **EzsigntemplatepublicDeleteObjectV1**
> EzsigntemplatepublicDeleteObjectV1Response EzsigntemplatepublicDeleteObjectV1 (int pkiEzsigntemplatepublicID)

Delete an existing Ezsigntemplatepublic


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepublicID** | **int** | The unique ID of the Ezsigntemplatepublic |  |

### Return type

[**EzsigntemplatepublicDeleteObjectV1Response**](EzsigntemplatepublicDeleteObjectV1Response.md)

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

<a id="ezsigntemplatepubliceditobjectv1"></a>
# **EzsigntemplatepublicEditObjectV1**
> EzsigntemplatepublicEditObjectV1Response EzsigntemplatepublicEditObjectV1 (int pkiEzsigntemplatepublicID, EzsigntemplatepublicEditObjectV1Request ezsigntemplatepublicEditObjectV1Request)

Edit an existing Ezsigntemplatepublic


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepublicID** | **int** | The unique ID of the Ezsigntemplatepublic |  |
| **ezsigntemplatepublicEditObjectV1Request** | [**EzsigntemplatepublicEditObjectV1Request**](EzsigntemplatepublicEditObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatepublicEditObjectV1Response**](EzsigntemplatepublicEditObjectV1Response.md)

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

<a id="ezsigntemplatepublicgetezsigntemplatepublicdetailsv1"></a>
# **EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1**
> EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Response EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1 (EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request ezsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request)

Retrieve the Ezsigntemplatepublic details

Retrieve the Ezsigntemplatepublic details


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request** | [**EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request**](EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request.md) |  |  |

### Return type

[**EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Response**](EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsigntemplatepublicgetformsdatav1"></a>
# **EzsigntemplatepublicGetFormsDataV1**
> EzsigntemplatepublicGetFormsDataV1Response EzsigntemplatepublicGetFormsDataV1 (int pkiEzsigntemplatepublicID)

Retrieve an existing Ezsigntemplatepublic's forms data


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepublicID** | **int** |  |  |

### Return type

[**EzsigntemplatepublicGetFormsDataV1Response**](EzsigntemplatepublicGetFormsDataV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/zip


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsigntemplatepublicgetlistv1"></a>
# **EzsigntemplatepublicGetListV1**
> EzsigntemplatepublicGetListV1Response EzsigntemplatepublicGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Ezsigntemplatepublic list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eEzsigntemplatepublicLimittype | Hour<br>Day<br>Month<br>Total |


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**EzsigntemplatepublicGetListV1Response**](EzsigntemplatepublicGetListV1Response.md)

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

<a id="ezsigntemplatepublicgetobjectv2"></a>
# **EzsigntemplatepublicGetObjectV2**
> EzsigntemplatepublicGetObjectV2Response EzsigntemplatepublicGetObjectV2 (int pkiEzsigntemplatepublicID)

Retrieve an existing Ezsigntemplatepublic


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepublicID** | **int** | The unique ID of the Ezsigntemplatepublic |  |

### Return type

[**EzsigntemplatepublicGetObjectV2Response**](EzsigntemplatepublicGetObjectV2Response.md)

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

<a id="ezsigntemplatepublicresetlimitexceededcounterv1"></a>
# **EzsigntemplatepublicResetLimitExceededCounterV1**
> EzsigntemplatepublicResetLimitExceededCounterV1Response EzsigntemplatepublicResetLimitExceededCounterV1 (int pkiEzsigntemplatepublicID, Object body)

Reset the limit exceeded counter


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepublicID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsigntemplatepublicResetLimitExceededCounterV1Response**](EzsigntemplatepublicResetLimitExceededCounterV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsigntemplatepublicreseturlv1"></a>
# **EzsigntemplatepublicResetUrlV1**
> EzsigntemplatepublicResetUrlV1Response EzsigntemplatepublicResetUrlV1 (int pkiEzsigntemplatepublicID, Object body)

Reset the Ezsigntemplatepublic url


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepublicID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsigntemplatepublicResetUrlV1Response**](EzsigntemplatepublicResetUrlV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


# eZmaxApi.Api.ObjectEzsignbulksendApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignbulksendCreateEzsignbulksendtransmissionV2**](ObjectEzsignbulksendApi.md#ezsignbulksendcreateezsignbulksendtransmissionv2) | **POST** /2/object/ezsignbulksend/{pkiEzsignbulksendID}/createEzsignbulksendtransmission | Create a new Ezsignbulksendtransmission in the Ezsignbulksend |
| [**EzsignbulksendCreateObjectV1**](ObjectEzsignbulksendApi.md#ezsignbulksendcreateobjectv1) | **POST** /1/object/ezsignbulksend | Create a new Ezsignbulksend |
| [**EzsignbulksendCreateObjectV2**](ObjectEzsignbulksendApi.md#ezsignbulksendcreateobjectv2) | **POST** /2/object/ezsignbulksend | Create a new Ezsignbulksend |
| [**EzsignbulksendDeleteObjectV1**](ObjectEzsignbulksendApi.md#ezsignbulksenddeleteobjectv1) | **DELETE** /1/object/ezsignbulksend/{pkiEzsignbulksendID} | Delete an existing Ezsignbulksend |
| [**EzsignbulksendEditObjectV2**](ObjectEzsignbulksendApi.md#ezsignbulksendeditobjectv2) | **PUT** /2/object/ezsignbulksend/{pkiEzsignbulksendID} | Edit an existing Ezsignbulksend |
| [**EzsignbulksendGetBatchFileV1**](ObjectEzsignbulksendApi.md#ezsignbulksendgetbatchfilev1) | **GET** /1/object/ezsignbulksend/{pkiEzsignbulksendID}/getBatchFile | Retrieve file to download documents in batch |
| [**EzsignbulksendGetCsvTemplateV1**](ObjectEzsignbulksendApi.md#ezsignbulksendgetcsvtemplatev1) | **GET** /1/object/ezsignbulksend/{pkiEzsignbulksendID}/getCsvTemplate | Retrieve an existing Ezsignbulksend&#39;s empty Csv template |
| [**EzsignbulksendGetEzsignbulksendtransmissionsV1**](ObjectEzsignbulksendApi.md#ezsignbulksendgetezsignbulksendtransmissionsv1) | **GET** /1/object/ezsignbulksend/{pkiEzsignbulksendID}/getEzsignbulksendtransmissions | Retrieve an existing Ezsignbulksend&#39;s Ezsignbulksendtransmissions |
| [**EzsignbulksendGetEzsignsignaturesAutomaticV1**](ObjectEzsignbulksendApi.md#ezsignbulksendgetezsignsignaturesautomaticv1) | **GET** /1/object/ezsignbulksend/{pkiEzsignbulksendID}/getEzsignsignaturesAutomatic | Retrieve an existing Ezsignbulksend&#39;s automatic Ezsignsignatures |
| [**EzsignbulksendGetFormsDataV1**](ObjectEzsignbulksendApi.md#ezsignbulksendgetformsdatav1) | **GET** /1/object/ezsignbulksend/{pkiEzsignbulksendID}/getFormsData | Retrieve an existing Ezsignbulksend&#39;s forms data |
| [**EzsignbulksendGetListV1**](ObjectEzsignbulksendApi.md#ezsignbulksendgetlistv1) | **GET** /1/object/ezsignbulksend/getList | Retrieve Ezsignbulksend list |
| [**EzsignbulksendGetObjectV2**](ObjectEzsignbulksendApi.md#ezsignbulksendgetobjectv2) | **GET** /2/object/ezsignbulksend/{pkiEzsignbulksendID} | Retrieve an existing Ezsignbulksend |
| [**EzsignbulksendGetObjectV3**](ObjectEzsignbulksendApi.md#ezsignbulksendgetobjectv3) | **GET** /3/object/ezsignbulksend/{pkiEzsignbulksendID} | Retrieve an existing Ezsignbulksend |
| [**EzsignbulksendReorderV1**](ObjectEzsignbulksendApi.md#ezsignbulksendreorderv1) | **POST** /1/object/ezsignbulksend/{pkiEzsignbulksendID}/reorder | Reorder Ezsignbulksenddocumentmappings in the Ezsignbulksend |

<a id="ezsignbulksendcreateezsignbulksendtransmissionv2"></a>
# **EzsignbulksendCreateEzsignbulksendtransmissionV2**
> EzsignbulksendCreateEzsignbulksendtransmissionV2Response EzsignbulksendCreateEzsignbulksendtransmissionV2 (int pkiEzsignbulksendID, EzsignbulksendCreateEzsignbulksendtransmissionV2Request ezsignbulksendCreateEzsignbulksendtransmissionV2Request)

Create a new Ezsignbulksendtransmission in the Ezsignbulksend


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |
| **ezsignbulksendCreateEzsignbulksendtransmissionV2Request** | [**EzsignbulksendCreateEzsignbulksendtransmissionV2Request**](EzsignbulksendCreateEzsignbulksendtransmissionV2Request.md) |  |  |

### Return type

[**EzsignbulksendCreateEzsignbulksendtransmissionV2Response**](EzsignbulksendCreateEzsignbulksendtransmissionV2Response.md)

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

<a id="ezsignbulksendcreateobjectv1"></a>
# **EzsignbulksendCreateObjectV1**
> EzsignbulksendCreateObjectV1Response EzsignbulksendCreateObjectV1 (EzsignbulksendCreateObjectV1Request ezsignbulksendCreateObjectV1Request)

Create a new Ezsignbulksend

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignbulksendCreateObjectV1Request** | [**EzsignbulksendCreateObjectV1Request**](EzsignbulksendCreateObjectV1Request.md) |  |  |

### Return type

[**EzsignbulksendCreateObjectV1Response**](EzsignbulksendCreateObjectV1Response.md)

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

<a id="ezsignbulksendcreateobjectv2"></a>
# **EzsignbulksendCreateObjectV2**
> EzsignbulksendCreateObjectV2Response EzsignbulksendCreateObjectV2 (EzsignbulksendCreateObjectV2Request ezsignbulksendCreateObjectV2Request)

Create a new Ezsignbulksend

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignbulksendCreateObjectV2Request** | [**EzsignbulksendCreateObjectV2Request**](EzsignbulksendCreateObjectV2Request.md) |  |  |

### Return type

[**EzsignbulksendCreateObjectV2Response**](EzsignbulksendCreateObjectV2Response.md)

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

<a id="ezsignbulksenddeleteobjectv1"></a>
# **EzsignbulksendDeleteObjectV1**
> EzsignbulksendDeleteObjectV1Response EzsignbulksendDeleteObjectV1 (int pkiEzsignbulksendID)

Delete an existing Ezsignbulksend


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |

### Return type

[**EzsignbulksendDeleteObjectV1Response**](EzsignbulksendDeleteObjectV1Response.md)

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

<a id="ezsignbulksendeditobjectv2"></a>
# **EzsignbulksendEditObjectV2**
> EzsignbulksendEditObjectV2Response EzsignbulksendEditObjectV2 (int pkiEzsignbulksendID, EzsignbulksendEditObjectV2Request ezsignbulksendEditObjectV2Request)

Edit an existing Ezsignbulksend


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |
| **ezsignbulksendEditObjectV2Request** | [**EzsignbulksendEditObjectV2Request**](EzsignbulksendEditObjectV2Request.md) |  |  |

### Return type

[**EzsignbulksendEditObjectV2Response**](EzsignbulksendEditObjectV2Response.md)

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

<a id="ezsignbulksendgetbatchfilev1"></a>
# **EzsignbulksendGetBatchFileV1**
> System.IO.Stream EzsignbulksendGetBatchFileV1 (int pkiEzsignbulksendID, bool bIncludeSigned = null, bool bIncludeAttachment = null, bool bIncludeProofdocument = null, bool bIncludeProof = null)

Retrieve file to download documents in batch


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |
| **bIncludeSigned** | **bool** | Include final document once all signatures were applied | [optional]  |
| **bIncludeAttachment** | **bool** | Include attached files in signatures | [optional]  |
| **bIncludeProofdocument** | **bool** | Include the evidence report | [optional]  |
| **bIncludeProof** | **bool** | include the complete evidence archive including all of the above and more | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsignbulksendgetcsvtemplatev1"></a>
# **EzsignbulksendGetCsvTemplateV1**
> string EzsignbulksendGetCsvTemplateV1 (int pkiEzsignbulksendID, string eCsvSeparator)

Retrieve an existing Ezsignbulksend's empty Csv template


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |
| **eCsvSeparator** | **string** | Separator that will be used to separate fields |  |

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsignbulksendgetezsignbulksendtransmissionsv1"></a>
# **EzsignbulksendGetEzsignbulksendtransmissionsV1**
> EzsignbulksendGetEzsignbulksendtransmissionsV1Response EzsignbulksendGetEzsignbulksendtransmissionsV1 (int pkiEzsignbulksendID)

Retrieve an existing Ezsignbulksend's Ezsignbulksendtransmissions


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |

### Return type

[**EzsignbulksendGetEzsignbulksendtransmissionsV1Response**](EzsignbulksendGetEzsignbulksendtransmissionsV1Response.md)

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

<a id="ezsignbulksendgetezsignsignaturesautomaticv1"></a>
# **EzsignbulksendGetEzsignsignaturesAutomaticV1**
> EzsignbulksendGetEzsignsignaturesAutomaticV1Response EzsignbulksendGetEzsignsignaturesAutomaticV1 (int pkiEzsignbulksendID)

Retrieve an existing Ezsignbulksend's automatic Ezsignsignatures

Return the Ezsignsignatures that can be signed by the current user at the current step in the process


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |

### Return type

[**EzsignbulksendGetEzsignsignaturesAutomaticV1Response**](EzsignbulksendGetEzsignsignaturesAutomaticV1Response.md)

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

<a id="ezsignbulksendgetformsdatav1"></a>
# **EzsignbulksendGetFormsDataV1**
> EzsignbulksendGetFormsDataV1Response EzsignbulksendGetFormsDataV1 (int pkiEzsignbulksendID)

Retrieve an existing Ezsignbulksend's forms data


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |

### Return type

[**EzsignbulksendGetFormsDataV1Response**](EzsignbulksendGetFormsDataV1Response.md)

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

<a id="ezsignbulksendgetlistv1"></a>
# **EzsignbulksendGetListV1**
> EzsignbulksendGetListV1Response EzsignbulksendGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Ezsignbulksend list

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

[**EzsignbulksendGetListV1Response**](EzsignbulksendGetListV1Response.md)

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

<a id="ezsignbulksendgetobjectv2"></a>
# **EzsignbulksendGetObjectV2**
> EzsignbulksendGetObjectV2Response EzsignbulksendGetObjectV2 (int pkiEzsignbulksendID)

Retrieve an existing Ezsignbulksend


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |

### Return type

[**EzsignbulksendGetObjectV2Response**](EzsignbulksendGetObjectV2Response.md)

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

<a id="ezsignbulksendgetobjectv3"></a>
# **EzsignbulksendGetObjectV3**
> EzsignbulksendGetObjectV3Response EzsignbulksendGetObjectV3 (int pkiEzsignbulksendID)

Retrieve an existing Ezsignbulksend


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |

### Return type

[**EzsignbulksendGetObjectV3Response**](EzsignbulksendGetObjectV3Response.md)

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

<a id="ezsignbulksendreorderv1"></a>
# **EzsignbulksendReorderV1**
> EzsignbulksendReorderV1Response EzsignbulksendReorderV1 (int pkiEzsignbulksendID, EzsignbulksendReorderV1Request ezsignbulksendReorderV1Request)

Reorder Ezsignbulksenddocumentmappings in the Ezsignbulksend


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendID** | **int** |  |  |
| **ezsignbulksendReorderV1Request** | [**EzsignbulksendReorderV1Request**](EzsignbulksendReorderV1Request.md) |  |  |

### Return type

[**EzsignbulksendReorderV1Response**](EzsignbulksendReorderV1Response.md)

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


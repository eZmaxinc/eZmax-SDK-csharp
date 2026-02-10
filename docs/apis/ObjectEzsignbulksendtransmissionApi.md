# eZmaxApi.Api.ObjectEzsignbulksendtransmissionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignbulksendtransmissionGetBatchFileV1**](ObjectEzsignbulksendtransmissionApi.md#ezsignbulksendtransmissiongetbatchfilev1) | **GET** /1/object/ezsignbulksendtransmission/{pkiEzsignbulksendtransmissionID}/getBatchFile | Retrieve file to download documents in batch |
| [**EzsignbulksendtransmissionGetCsvErrorsV1**](ObjectEzsignbulksendtransmissionApi.md#ezsignbulksendtransmissiongetcsverrorsv1) | **GET** /1/object/ezsignbulksendtransmission/{pkiEzsignbulksendtransmissionID}/getCsvErrors | Retrieve an existing Ezsignbulksendtransmission&#39;s Csv containing errors |
| [**EzsignbulksendtransmissionGetEzsignsignaturesAutomaticV1**](ObjectEzsignbulksendtransmissionApi.md#ezsignbulksendtransmissiongetezsignsignaturesautomaticv1) | **GET** /1/object/ezsignbulksendtransmission/{pkiEzsignbulksendtransmissionID}/getEzsignsignaturesAutomatic | Retrieve an existing Ezsignbulksendtransmission&#39;s automatic Ezsignsignatures |
| [**EzsignbulksendtransmissionGetFormsDataV1**](ObjectEzsignbulksendtransmissionApi.md#ezsignbulksendtransmissiongetformsdatav1) | **GET** /1/object/ezsignbulksendtransmission/{pkiEzsignbulksendtransmissionID}/getFormsData | Retrieve an existing Ezsignbulksendtransmission&#39;s forms data |
| [**EzsignbulksendtransmissionGetObjectV2**](ObjectEzsignbulksendtransmissionApi.md#ezsignbulksendtransmissiongetobjectv2) | **GET** /2/object/ezsignbulksendtransmission/{pkiEzsignbulksendtransmissionID} | Retrieve an existing Ezsignbulksendtransmission |

<a id="ezsignbulksendtransmissiongetbatchfilev1"></a>
# **EzsignbulksendtransmissionGetBatchFileV1**
> System.IO.Stream EzsignbulksendtransmissionGetBatchFileV1 (int pkiEzsignbulksendtransmissionID, bool bIncludeSigned = null, bool bIncludeAttachment = null, bool bIncludeProofdocument = null, bool bIncludeProof = null)

Retrieve file to download documents in batch


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendtransmissionID** | **int** |  |  |
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

<a id="ezsignbulksendtransmissiongetcsverrorsv1"></a>
# **EzsignbulksendtransmissionGetCsvErrorsV1**
> string EzsignbulksendtransmissionGetCsvErrorsV1 (int pkiEzsignbulksendtransmissionID)

Retrieve an existing Ezsignbulksendtransmission's Csv containing errors


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendtransmissionID** | **int** |  |  |

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

<a id="ezsignbulksendtransmissiongetezsignsignaturesautomaticv1"></a>
# **EzsignbulksendtransmissionGetEzsignsignaturesAutomaticV1**
> EzsignbulksendtransmissionGetEzsignsignaturesAutomaticV1Response EzsignbulksendtransmissionGetEzsignsignaturesAutomaticV1 (int pkiEzsignbulksendtransmissionID)

Retrieve an existing Ezsignbulksendtransmission's automatic Ezsignsignatures

Return the Ezsignsignatures that can be signed by the current user at the current step in the process


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendtransmissionID** | **int** |  |  |

### Return type

[**EzsignbulksendtransmissionGetEzsignsignaturesAutomaticV1Response**](EzsignbulksendtransmissionGetEzsignsignaturesAutomaticV1Response.md)

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

<a id="ezsignbulksendtransmissiongetformsdatav1"></a>
# **EzsignbulksendtransmissionGetFormsDataV1**
> EzsignbulksendtransmissionGetFormsDataV1Response EzsignbulksendtransmissionGetFormsDataV1 (int pkiEzsignbulksendtransmissionID)

Retrieve an existing Ezsignbulksendtransmission's forms data


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendtransmissionID** | **int** |  |  |

### Return type

[**EzsignbulksendtransmissionGetFormsDataV1Response**](EzsignbulksendtransmissionGetFormsDataV1Response.md)

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

<a id="ezsignbulksendtransmissiongetobjectv2"></a>
# **EzsignbulksendtransmissionGetObjectV2**
> EzsignbulksendtransmissionGetObjectV2Response EzsignbulksendtransmissionGetObjectV2 (int pkiEzsignbulksendtransmissionID)

Retrieve an existing Ezsignbulksendtransmission


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendtransmissionID** | **int** |  |  |

### Return type

[**EzsignbulksendtransmissionGetObjectV2Response**](EzsignbulksendtransmissionGetObjectV2Response.md)

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


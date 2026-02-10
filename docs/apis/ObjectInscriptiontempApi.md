# eZmaxApi.Api.ObjectInscriptiontempApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InscriptiontempGetCommunicationCountV1**](ObjectInscriptiontempApi.md#inscriptiontempgetcommunicationcountv1) | **GET** /1/object/inscriptiontemp/{pkiInscriptiontempID}/getCommunicationCount | Retrieve Communication count |
| [**InscriptiontempGetCommunicationListV1**](ObjectInscriptiontempApi.md#inscriptiontempgetcommunicationlistv1) | **GET** /1/object/inscriptiontemp/{pkiInscriptiontempID}/getCommunicationList | Retrieve Communication list |
| [**InscriptiontempGetCommunicationrecipientsV1**](ObjectInscriptiontempApi.md#inscriptiontempgetcommunicationrecipientsv1) | **GET** /1/object/inscriptiontemp/{pkiInscriptiontempID}/getCommunicationrecipients | Retrieve Inscriptiontemp&#39;s Communicationrecipient |
| [**InscriptiontempGetCommunicationsendersV1**](ObjectInscriptiontempApi.md#inscriptiontempgetcommunicationsendersv1) | **GET** /1/object/inscriptiontemp/{pkiInscriptiontempID}/getCommunicationsenders | Retrieve Inscriptiontemp&#39;s Communicationsender |
| [**InscriptiontempGetListV1**](ObjectInscriptiontempApi.md#inscriptiontempgetlistv1) | **GET** /1/object/inscriptiontemp/getList | Retrieve Inscriptiontemp list |
| [**InscriptiontempImportIntoEDMV1**](ObjectInscriptiontempApi.md#inscriptiontempimportintoedmv1) | **POST** /1/object/inscriptiontemp/{pkiInscriptiontempID}/importIntoEDM | Import attachments into the Inscriptiontemp |

<a id="inscriptiontempgetcommunicationcountv1"></a>
# **InscriptiontempGetCommunicationCountV1**
> InscriptiontempGetCommunicationCountV1Response InscriptiontempGetCommunicationCountV1 (int pkiInscriptiontempID)

Retrieve Communication count


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptiontempID** | **int** |  |  |

### Return type

[**InscriptiontempGetCommunicationCountV1Response**](InscriptiontempGetCommunicationCountV1Response.md)

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

<a id="inscriptiontempgetcommunicationlistv1"></a>
# **InscriptiontempGetCommunicationListV1**
> InscriptiontempGetCommunicationListV1Response InscriptiontempGetCommunicationListV1 (int pkiInscriptiontempID)

Retrieve Communication list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptiontempID** | **int** |  |  |

### Return type

[**InscriptiontempGetCommunicationListV1Response**](InscriptiontempGetCommunicationListV1Response.md)

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

<a id="inscriptiontempgetcommunicationrecipientsv1"></a>
# **InscriptiontempGetCommunicationrecipientsV1**
> InscriptiontempGetCommunicationrecipientsV1Response InscriptiontempGetCommunicationrecipientsV1 (int pkiInscriptiontempID)

Retrieve Inscriptiontemp's Communicationrecipient


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptiontempID** | **int** |  |  |

### Return type

[**InscriptiontempGetCommunicationrecipientsV1Response**](InscriptiontempGetCommunicationrecipientsV1Response.md)

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

<a id="inscriptiontempgetcommunicationsendersv1"></a>
# **InscriptiontempGetCommunicationsendersV1**
> InscriptiontempGetCommunicationsendersV1Response InscriptiontempGetCommunicationsendersV1 (int pkiInscriptiontempID)

Retrieve Inscriptiontemp's Communicationsender


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptiontempID** | **int** |  |  |

### Return type

[**InscriptiontempGetCommunicationsendersV1Response**](InscriptiontempGetCommunicationsendersV1Response.md)

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

<a id="inscriptiontempgetlistv1"></a>
# **InscriptiontempGetListV1**
> InscriptiontempGetListV1Response InscriptiontempGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Inscriptiontemp list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eInscriptiontempStatus | Imported<br>Processed<br>Modified |


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**InscriptiontempGetListV1Response**](InscriptiontempGetListV1Response.md)

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

<a id="inscriptiontempimportintoedmv1"></a>
# **InscriptiontempImportIntoEDMV1**
> InscriptiontempImportIntoEDMV1Response InscriptiontempImportIntoEDMV1 (int pkiInscriptiontempID, InscriptiontempImportIntoEDMV1Request inscriptiontempImportIntoEDMV1Request)

Import attachments into the Inscriptiontemp


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptiontempID** | **int** |  |  |
| **inscriptiontempImportIntoEDMV1Request** | [**InscriptiontempImportIntoEDMV1Request**](InscriptiontempImportIntoEDMV1Request.md) |  |  |

### Return type

[**InscriptiontempImportIntoEDMV1Response**](InscriptiontempImportIntoEDMV1Response.md)

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


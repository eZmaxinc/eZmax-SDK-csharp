# eZmaxApi.Api.ObjectInscriptionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InscriptionGetAttachmentsV1**](ObjectInscriptionApi.md#inscriptiongetattachmentsv1) | **GET** /1/object/inscription/{pkiInscriptionID}/getAttachments | Retrieve Inscription&#39;s Attachments |
| [**InscriptionGetCommunicationCountV1**](ObjectInscriptionApi.md#inscriptiongetcommunicationcountv1) | **GET** /1/object/inscription/{pkiInscriptionID}/getCommunicationCount | Retrieve Communication count |
| [**InscriptionGetCommunicationListV1**](ObjectInscriptionApi.md#inscriptiongetcommunicationlistv1) | **GET** /1/object/inscription/{pkiInscriptionID}/getCommunicationList | Retrieve Communication list |
| [**InscriptionGetCommunicationrecipientsV1**](ObjectInscriptionApi.md#inscriptiongetcommunicationrecipientsv1) | **GET** /1/object/inscription/{pkiInscriptionID}/getCommunicationrecipients | Retrieve Inscription&#39;s Communicationrecipient |
| [**InscriptionGetCommunicationsendersV1**](ObjectInscriptionApi.md#inscriptiongetcommunicationsendersv1) | **GET** /1/object/inscription/{pkiInscriptionID}/getCommunicationsenders | Retrieve Inscription&#39;s Communicationsender |
| [**InscriptionGetListV1**](ObjectInscriptionApi.md#inscriptiongetlistv1) | **GET** /1/object/inscription/getList | Retrieve Inscription list |
| [**InscriptionImportIntoEDMV1**](ObjectInscriptionApi.md#inscriptionimportintoedmv1) | **POST** /1/object/inscription/{pkiInscriptionID}/importIntoEDM | Import attachments into the Inscription |
| [**InscriptionPrepareFilesTransferV1**](ObjectInscriptionApi.md#inscriptionpreparefilestransferv1) | **POST** /1/object/inscription/{pkiInscriptionID}/prepareFilesTransfer | Prepares file transfer into EDM |

<a id="inscriptiongetattachmentsv1"></a>
# **InscriptionGetAttachmentsV1**
> InscriptionGetAttachmentsV1Response InscriptionGetAttachmentsV1 (int pkiInscriptionID)

Retrieve Inscription's Attachments


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |

### Return type

[**InscriptionGetAttachmentsV1Response**](InscriptionGetAttachmentsV1Response.md)

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

<a id="inscriptiongetcommunicationcountv1"></a>
# **InscriptionGetCommunicationCountV1**
> InscriptionGetCommunicationCountV1Response InscriptionGetCommunicationCountV1 (int pkiInscriptionID)

Retrieve Communication count


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |

### Return type

[**InscriptionGetCommunicationCountV1Response**](InscriptionGetCommunicationCountV1Response.md)

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

<a id="inscriptiongetcommunicationlistv1"></a>
# **InscriptionGetCommunicationListV1**
> InscriptionGetCommunicationListV1Response InscriptionGetCommunicationListV1 (int pkiInscriptionID)

Retrieve Communication list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |

### Return type

[**InscriptionGetCommunicationListV1Response**](InscriptionGetCommunicationListV1Response.md)

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

<a id="inscriptiongetcommunicationrecipientsv1"></a>
# **InscriptionGetCommunicationrecipientsV1**
> InscriptionGetCommunicationrecipientsV1Response InscriptionGetCommunicationrecipientsV1 (int pkiInscriptionID)

Retrieve Inscription's Communicationrecipient


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |

### Return type

[**InscriptionGetCommunicationrecipientsV1Response**](InscriptionGetCommunicationrecipientsV1Response.md)

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

<a id="inscriptiongetcommunicationsendersv1"></a>
# **InscriptionGetCommunicationsendersV1**
> InscriptionGetCommunicationsendersV1Response InscriptionGetCommunicationsendersV1 (int pkiInscriptionID)

Retrieve Inscription's Communicationsender


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |

### Return type

[**InscriptionGetCommunicationsendersV1Response**](InscriptionGetCommunicationsendersV1Response.md)

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

<a id="inscriptiongetlistv1"></a>
# **InscriptionGetListV1**
> InscriptionGetListV1Response InscriptionGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Inscription list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eInscriptionStep | TemporaryNotAuthenticated<br>ImportedInscription<br>Inscription<br>ModifiedInscription<br>ContractEnded<br>ExpiredInscription<br>Out-market<br>ImportedNotauthenticated<br>NotAuthenticated<br>ModifiedNotauthenticated<br>Authenticated |


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**InscriptionGetListV1Response**](InscriptionGetListV1Response.md)

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

<a id="inscriptionimportintoedmv1"></a>
# **InscriptionImportIntoEDMV1**
> InscriptionImportIntoEDMV1Response InscriptionImportIntoEDMV1 (int pkiInscriptionID, InscriptionImportIntoEDMV1Request inscriptionImportIntoEDMV1Request)

Import attachments into the Inscription


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |
| **inscriptionImportIntoEDMV1Request** | [**InscriptionImportIntoEDMV1Request**](InscriptionImportIntoEDMV1Request.md) |  |  |

### Return type

[**InscriptionImportIntoEDMV1Response**](InscriptionImportIntoEDMV1Response.md)

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

<a id="inscriptionpreparefilestransferv1"></a>
# **InscriptionPrepareFilesTransferV1**
> InscriptionPrepareFilesTransferV1Response InscriptionPrepareFilesTransferV1 (int pkiInscriptionID, InscriptionPrepareFilesTransferV1Request inscriptionPrepareFilesTransferV1Request)

Prepares file transfer into EDM


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |
| **inscriptionPrepareFilesTransferV1Request** | [**InscriptionPrepareFilesTransferV1Request**](InscriptionPrepareFilesTransferV1Request.md) |  |  |

### Return type

[**InscriptionPrepareFilesTransferV1Response**](InscriptionPrepareFilesTransferV1Response.md)

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


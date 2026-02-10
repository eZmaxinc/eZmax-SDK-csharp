# eZmaxApi.Api.ObjectInvoiceApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InvoiceGetAttachmentsV1**](ObjectInvoiceApi.md#invoicegetattachmentsv1) | **GET** /1/object/invoice/{pkiInvoiceID}/getAttachments | Retrieve Invoice&#39;s Attachments |
| [**InvoiceGetCommunicationCountV1**](ObjectInvoiceApi.md#invoicegetcommunicationcountv1) | **GET** /1/object/invoice/{pkiInvoiceID}/getCommunicationCount | Retrieve Communication count |
| [**InvoiceGetCommunicationListV1**](ObjectInvoiceApi.md#invoicegetcommunicationlistv1) | **GET** /1/object/invoice/{pkiInvoiceID}/getCommunicationList | Retrieve Communication list |
| [**InvoiceGetCommunicationrecipientsV1**](ObjectInvoiceApi.md#invoicegetcommunicationrecipientsv1) | **GET** /1/object/invoice/{pkiInvoiceID}/getCommunicationrecipients | Retrieve Invoice&#39;s Communicationrecipient |
| [**InvoiceGetCommunicationsendersV1**](ObjectInvoiceApi.md#invoicegetcommunicationsendersv1) | **GET** /1/object/invoice/{pkiInvoiceID}/getCommunicationsenders | Retrieve Invoice&#39;s Communicationsender |
| [**InvoiceImportIntoEDMV1**](ObjectInvoiceApi.md#invoiceimportintoedmv1) | **POST** /1/object/invoice/{pkiInvoiceID}/importIntoEDM | Import attachments into the Invoice |

<a id="invoicegetattachmentsv1"></a>
# **InvoiceGetAttachmentsV1**
> InvoiceGetAttachmentsV1Response InvoiceGetAttachmentsV1 (int pkiInvoiceID)

Retrieve Invoice's Attachments


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInvoiceID** | **int** |  |  |

### Return type

[**InvoiceGetAttachmentsV1Response**](InvoiceGetAttachmentsV1Response.md)

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

<a id="invoicegetcommunicationcountv1"></a>
# **InvoiceGetCommunicationCountV1**
> InvoiceGetCommunicationCountV1Response InvoiceGetCommunicationCountV1 (int pkiInvoiceID)

Retrieve Communication count


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInvoiceID** | **int** |  |  |

### Return type

[**InvoiceGetCommunicationCountV1Response**](InvoiceGetCommunicationCountV1Response.md)

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

<a id="invoicegetcommunicationlistv1"></a>
# **InvoiceGetCommunicationListV1**
> InvoiceGetCommunicationListV1Response InvoiceGetCommunicationListV1 (int pkiInvoiceID)

Retrieve Communication list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInvoiceID** | **int** |  |  |

### Return type

[**InvoiceGetCommunicationListV1Response**](InvoiceGetCommunicationListV1Response.md)

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

<a id="invoicegetcommunicationrecipientsv1"></a>
# **InvoiceGetCommunicationrecipientsV1**
> InvoiceGetCommunicationrecipientsV1Response InvoiceGetCommunicationrecipientsV1 (int pkiInvoiceID)

Retrieve Invoice's Communicationrecipient


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInvoiceID** | **int** |  |  |

### Return type

[**InvoiceGetCommunicationrecipientsV1Response**](InvoiceGetCommunicationrecipientsV1Response.md)

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

<a id="invoicegetcommunicationsendersv1"></a>
# **InvoiceGetCommunicationsendersV1**
> InvoiceGetCommunicationsendersV1Response InvoiceGetCommunicationsendersV1 (int pkiInvoiceID)

Retrieve Invoice's Communicationsender


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInvoiceID** | **int** |  |  |

### Return type

[**InvoiceGetCommunicationsendersV1Response**](InvoiceGetCommunicationsendersV1Response.md)

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

<a id="invoiceimportintoedmv1"></a>
# **InvoiceImportIntoEDMV1**
> InvoiceImportIntoEDMV1Response InvoiceImportIntoEDMV1 (int pkiInvoiceID, InvoiceImportIntoEDMV1Request invoiceImportIntoEDMV1Request)

Import attachments into the Invoice


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInvoiceID** | **int** |  |  |
| **invoiceImportIntoEDMV1Request** | [**InvoiceImportIntoEDMV1Request**](InvoiceImportIntoEDMV1Request.md) |  |  |

### Return type

[**InvoiceImportIntoEDMV1Response**](InvoiceImportIntoEDMV1Response.md)

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


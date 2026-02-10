# eZmaxApi.Api.ObjectTranqcontractApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TranqcontractGetCommunicationCountV1**](ObjectTranqcontractApi.md#tranqcontractgetcommunicationcountv1) | **GET** /1/object/tranqcontract/{pkiTranqcontractID}/getCommunicationCount | Retrieve Communication count |
| [**TranqcontractGetCommunicationListV1**](ObjectTranqcontractApi.md#tranqcontractgetcommunicationlistv1) | **GET** /1/object/tranqcontract/{pkiTranqcontractID}/getCommunicationList | Retrieve Communication list |
| [**TranqcontractGetCommunicationrecipientsV1**](ObjectTranqcontractApi.md#tranqcontractgetcommunicationrecipientsv1) | **GET** /1/object/tranqcontract/{pkiTranqcontractID}/getCommunicationrecipients | Retrieve Tranqcontract&#39;s Communicationrecipient |
| [**TranqcontractGetCommunicationsendersV1**](ObjectTranqcontractApi.md#tranqcontractgetcommunicationsendersv1) | **GET** /1/object/tranqcontract/{pkiTranqcontractID}/getCommunicationsenders | Retrieve Tranqcontract&#39;s Communicationsender |
| [**TranqcontractImportIntoEDMV1**](ObjectTranqcontractApi.md#tranqcontractimportintoedmv1) | **POST** /1/object/tranqcontract/{pkiTranqcontractID}/importIntoEDM | Import attachments into the Tranqcontract |

<a id="tranqcontractgetcommunicationcountv1"></a>
# **TranqcontractGetCommunicationCountV1**
> TranqcontractGetCommunicationCountV1Response TranqcontractGetCommunicationCountV1 (int pkiTranqcontractID)

Retrieve Communication count


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiTranqcontractID** | **int** |  |  |

### Return type

[**TranqcontractGetCommunicationCountV1Response**](TranqcontractGetCommunicationCountV1Response.md)

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

<a id="tranqcontractgetcommunicationlistv1"></a>
# **TranqcontractGetCommunicationListV1**
> TranqcontractGetCommunicationListV1Response TranqcontractGetCommunicationListV1 (int pkiTranqcontractID)

Retrieve Communication list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiTranqcontractID** | **int** |  |  |

### Return type

[**TranqcontractGetCommunicationListV1Response**](TranqcontractGetCommunicationListV1Response.md)

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

<a id="tranqcontractgetcommunicationrecipientsv1"></a>
# **TranqcontractGetCommunicationrecipientsV1**
> TranqcontractGetCommunicationrecipientsV1Response TranqcontractGetCommunicationrecipientsV1 (int pkiTranqcontractID)

Retrieve Tranqcontract's Communicationrecipient


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiTranqcontractID** | **int** |  |  |

### Return type

[**TranqcontractGetCommunicationrecipientsV1Response**](TranqcontractGetCommunicationrecipientsV1Response.md)

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

<a id="tranqcontractgetcommunicationsendersv1"></a>
# **TranqcontractGetCommunicationsendersV1**
> TranqcontractGetCommunicationsendersV1Response TranqcontractGetCommunicationsendersV1 (int pkiTranqcontractID)

Retrieve Tranqcontract's Communicationsender


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiTranqcontractID** | **int** |  |  |

### Return type

[**TranqcontractGetCommunicationsendersV1Response**](TranqcontractGetCommunicationsendersV1Response.md)

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

<a id="tranqcontractimportintoedmv1"></a>
# **TranqcontractImportIntoEDMV1**
> TranqcontractImportIntoEDMV1Response TranqcontractImportIntoEDMV1 (int pkiTranqcontractID, TranqcontractImportIntoEDMV1Request tranqcontractImportIntoEDMV1Request)

Import attachments into the Tranqcontract


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiTranqcontractID** | **int** |  |  |
| **tranqcontractImportIntoEDMV1Request** | [**TranqcontractImportIntoEDMV1Request**](TranqcontractImportIntoEDMV1Request.md) |  |  |

### Return type

[**TranqcontractImportIntoEDMV1Response**](TranqcontractImportIntoEDMV1Response.md)

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


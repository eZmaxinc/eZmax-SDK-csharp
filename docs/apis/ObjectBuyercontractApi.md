# eZmaxApi.Api.ObjectBuyercontractApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BuyercontractGetCommunicationCountV1**](ObjectBuyercontractApi.md#buyercontractgetcommunicationcountv1) | **GET** /1/object/buyercontract/{pkiBuyercontractID}/getCommunicationCount | Retrieve Communication count |
| [**BuyercontractGetCommunicationListV1**](ObjectBuyercontractApi.md#buyercontractgetcommunicationlistv1) | **GET** /1/object/buyercontract/{pkiBuyercontractID}/getCommunicationList | Retrieve Communication list |
| [**BuyercontractGetCommunicationrecipientsV1**](ObjectBuyercontractApi.md#buyercontractgetcommunicationrecipientsv1) | **GET** /1/object/buyercontract/{pkiBuyercontractID}/getCommunicationrecipients | Retrieve Buyercontract&#39;s Communicationrecipient |
| [**BuyercontractGetCommunicationsendersV1**](ObjectBuyercontractApi.md#buyercontractgetcommunicationsendersv1) | **GET** /1/object/buyercontract/{pkiBuyercontractID}/getCommunicationsenders | Retrieve Buyercontract&#39;s Communicationsender |
| [**BuyercontractGetListV1**](ObjectBuyercontractApi.md#buyercontractgetlistv1) | **GET** /1/object/buyercontract/getList | Retrieve Buyercontract list |
| [**BuyercontractImportIntoEDMV1**](ObjectBuyercontractApi.md#buyercontractimportintoedmv1) | **POST** /1/object/buyercontract/{pkiBuyercontractID}/importIntoEDM | Import attachments into the Buyercontract |

<a id="buyercontractgetcommunicationcountv1"></a>
# **BuyercontractGetCommunicationCountV1**
> BuyercontractGetCommunicationCountV1Response BuyercontractGetCommunicationCountV1 (int pkiBuyercontractID)

Retrieve Communication count


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBuyercontractID** | **int** |  |  |

### Return type

[**BuyercontractGetCommunicationCountV1Response**](BuyercontractGetCommunicationCountV1Response.md)

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

<a id="buyercontractgetcommunicationlistv1"></a>
# **BuyercontractGetCommunicationListV1**
> BuyercontractGetCommunicationListV1Response BuyercontractGetCommunicationListV1 (int pkiBuyercontractID)

Retrieve Communication list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBuyercontractID** | **int** |  |  |

### Return type

[**BuyercontractGetCommunicationListV1Response**](BuyercontractGetCommunicationListV1Response.md)

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

<a id="buyercontractgetcommunicationrecipientsv1"></a>
# **BuyercontractGetCommunicationrecipientsV1**
> BuyercontractGetCommunicationrecipientsV1Response BuyercontractGetCommunicationrecipientsV1 (int pkiBuyercontractID)

Retrieve Buyercontract's Communicationrecipient


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBuyercontractID** | **int** |  |  |

### Return type

[**BuyercontractGetCommunicationrecipientsV1Response**](BuyercontractGetCommunicationrecipientsV1Response.md)

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

<a id="buyercontractgetcommunicationsendersv1"></a>
# **BuyercontractGetCommunicationsendersV1**
> BuyercontractGetCommunicationsendersV1Response BuyercontractGetCommunicationsendersV1 (int pkiBuyercontractID)

Retrieve Buyercontract's Communicationsender


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBuyercontractID** | **int** |  |  |

### Return type

[**BuyercontractGetCommunicationsendersV1Response**](BuyercontractGetCommunicationsendersV1Response.md)

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

<a id="buyercontractgetlistv1"></a>
# **BuyercontractGetListV1**
> BuyercontractGetListV1Response BuyercontractGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Buyercontract list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eBuyercontractStep | Imported<br>Active<br>Modified<br>ContractEnded<br>ExpiredContract<br>Bought | | eBuyercontractType | Rent<br>Sale<br>RentOrSale |


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**BuyercontractGetListV1Response**](BuyercontractGetListV1Response.md)

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

<a id="buyercontractimportintoedmv1"></a>
# **BuyercontractImportIntoEDMV1**
> BuyercontractImportIntoEDMV1Response BuyercontractImportIntoEDMV1 (int pkiBuyercontractID, BuyercontractImportIntoEDMV1Request buyercontractImportIntoEDMV1Request)

Import attachments into the Buyercontract


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBuyercontractID** | **int** |  |  |
| **buyercontractImportIntoEDMV1Request** | [**BuyercontractImportIntoEDMV1Request**](BuyercontractImportIntoEDMV1Request.md) |  |  |

### Return type

[**BuyercontractImportIntoEDMV1Response**](BuyercontractImportIntoEDMV1Response.md)

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


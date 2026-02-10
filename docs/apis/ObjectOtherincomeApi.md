# eZmaxApi.Api.ObjectOtherincomeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OtherincomeGetCommunicationCountV1**](ObjectOtherincomeApi.md#otherincomegetcommunicationcountv1) | **GET** /1/object/otherincome/{pkiOtherincomeID}/getCommunicationCount | Retrieve Communication count |
| [**OtherincomeGetCommunicationListV1**](ObjectOtherincomeApi.md#otherincomegetcommunicationlistv1) | **GET** /1/object/otherincome/{pkiOtherincomeID}/getCommunicationList | Retrieve Communication list |
| [**OtherincomeGetCommunicationrecipientsV1**](ObjectOtherincomeApi.md#otherincomegetcommunicationrecipientsv1) | **GET** /1/object/otherincome/{pkiOtherincomeID}/getCommunicationrecipients | Retrieve Otherincome&#39;s Communicationrecipient |
| [**OtherincomeGetCommunicationsendersV1**](ObjectOtherincomeApi.md#otherincomegetcommunicationsendersv1) | **GET** /1/object/otherincome/{pkiOtherincomeID}/getCommunicationsenders | Retrieve Otherincome&#39;s Communicationsender |
| [**OtherincomeGetListV1**](ObjectOtherincomeApi.md#otherincomegetlistv1) | **GET** /1/object/otherincome/getList | Retrieve Otherincome list |
| [**OtherincomeImportIntoEDMV1**](ObjectOtherincomeApi.md#otherincomeimportintoedmv1) | **POST** /1/object/otherincome/{pkiOtherincomeID}/importIntoEDM | Import attachments into the Otherincome |

<a id="otherincomegetcommunicationcountv1"></a>
# **OtherincomeGetCommunicationCountV1**
> OtherincomeGetCommunicationCountV1Response OtherincomeGetCommunicationCountV1 (int pkiOtherincomeID)

Retrieve Communication count


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiOtherincomeID** | **int** |  |  |

### Return type

[**OtherincomeGetCommunicationCountV1Response**](OtherincomeGetCommunicationCountV1Response.md)

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

<a id="otherincomegetcommunicationlistv1"></a>
# **OtherincomeGetCommunicationListV1**
> OtherincomeGetCommunicationListV1Response OtherincomeGetCommunicationListV1 (int pkiOtherincomeID)

Retrieve Communication list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiOtherincomeID** | **int** |  |  |

### Return type

[**OtherincomeGetCommunicationListV1Response**](OtherincomeGetCommunicationListV1Response.md)

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

<a id="otherincomegetcommunicationrecipientsv1"></a>
# **OtherincomeGetCommunicationrecipientsV1**
> OtherincomeGetCommunicationrecipientsV1Response OtherincomeGetCommunicationrecipientsV1 (int pkiOtherincomeID)

Retrieve Otherincome's Communicationrecipient


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiOtherincomeID** | **int** |  |  |

### Return type

[**OtherincomeGetCommunicationrecipientsV1Response**](OtherincomeGetCommunicationrecipientsV1Response.md)

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

<a id="otherincomegetcommunicationsendersv1"></a>
# **OtherincomeGetCommunicationsendersV1**
> OtherincomeGetCommunicationsendersV1Response OtherincomeGetCommunicationsendersV1 (int pkiOtherincomeID)

Retrieve Otherincome's Communicationsender


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiOtherincomeID** | **int** |  |  |

### Return type

[**OtherincomeGetCommunicationsendersV1Response**](OtherincomeGetCommunicationsendersV1Response.md)

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

<a id="otherincomegetlistv1"></a>
# **OtherincomeGetListV1**
> OtherincomeGetListV1Response OtherincomeGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Otherincome list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eOtherincomeRemunerationtype | Dollars<br>DollarsTaxesIncluded |


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**OtherincomeGetListV1Response**](OtherincomeGetListV1Response.md)

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

<a id="otherincomeimportintoedmv1"></a>
# **OtherincomeImportIntoEDMV1**
> OtherincomeImportIntoEDMV1Response OtherincomeImportIntoEDMV1 (int pkiOtherincomeID, OtherincomeImportIntoEDMV1Request otherincomeImportIntoEDMV1Request)

Import attachments into the Otherincome


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiOtherincomeID** | **int** |  |  |
| **otherincomeImportIntoEDMV1Request** | [**OtherincomeImportIntoEDMV1Request**](OtherincomeImportIntoEDMV1Request.md) |  |  |

### Return type

[**OtherincomeImportIntoEDMV1Response**](OtherincomeImportIntoEDMV1Response.md)

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


# eZmaxApi.Api.ObjectLeadApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LeadGetListV1**](ObjectLeadApi.md#leadgetlistv1) | **GET** /1/object/lead/getList | Retrieve Lead list |
| [**LeadImportIntoEDMV1**](ObjectLeadApi.md#leadimportintoedmv1) | **POST** /1/object/lead/{pkiLeadID}/importIntoEDM | Import attachments into the Lead |

<a id="leadgetlistv1"></a>
# **LeadGetListV1**
> LeadGetListV1Response LeadGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Lead list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eLeadStatus | New<br>Dispatching<br>Assigned<br>Lost<br>Won |


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**LeadGetListV1Response**](LeadGetListV1Response.md)

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

<a id="leadimportintoedmv1"></a>
# **LeadImportIntoEDMV1**
> LeadImportIntoEDMV1Response LeadImportIntoEDMV1 (int pkiLeadID, LeadImportIntoEDMV1Request leadImportIntoEDMV1Request)

Import attachments into the Lead


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiLeadID** | **int** |  |  |
| **leadImportIntoEDMV1Request** | [**LeadImportIntoEDMV1Request**](LeadImportIntoEDMV1Request.md) |  |  |

### Return type

[**LeadImportIntoEDMV1Response**](LeadImportIntoEDMV1Response.md)

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


# eZmaxApi.Api.ObjectEzsignimportfolderApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignimportfolderDeleteObjectV1**](ObjectEzsignimportfolderApi.md#ezsignimportfolderdeleteobjectv1) | **DELETE** /1/object/ezsignimportfolder/{pkiEzsignimportfolderID} | Delete an existing Ezsignimportfolder |
| [**EzsignimportfolderGetListV1**](ObjectEzsignimportfolderApi.md#ezsignimportfoldergetlistv1) | **GET** /1/object/ezsignimportfolder/getList | Retrieve Ezsignimportfolder list |
| [**EzsignimportfolderGetObjectV2**](ObjectEzsignimportfolderApi.md#ezsignimportfoldergetobjectv2) | **GET** /2/object/ezsignimportfolder/{pkiEzsignimportfolderID} | Retrieve an existing Ezsignimportfolder |

<a id="ezsignimportfolderdeleteobjectv1"></a>
# **EzsignimportfolderDeleteObjectV1**
> EzsignimportfolderDeleteObjectV1Response EzsignimportfolderDeleteObjectV1 (int pkiEzsignimportfolderID)

Delete an existing Ezsignimportfolder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignimportfolderID** | **int** | The unique ID of the Ezsignimportfolder |  |

### Return type

[**EzsignimportfolderDeleteObjectV1Response**](EzsignimportfolderDeleteObjectV1Response.md)

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

<a id="ezsignimportfoldergetlistv1"></a>
# **EzsignimportfolderGetListV1**
> EzsignimportfolderGetListV1Response EzsignimportfolderGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Ezsignimportfolder list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**EzsignimportfolderGetListV1Response**](EzsignimportfolderGetListV1Response.md)

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

<a id="ezsignimportfoldergetobjectv2"></a>
# **EzsignimportfolderGetObjectV2**
> EzsignimportfolderGetObjectV2Response EzsignimportfolderGetObjectV2 (int pkiEzsignimportfolderID)

Retrieve an existing Ezsignimportfolder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignimportfolderID** | **int** | The unique ID of the Ezsignimportfolder |  |

### Return type

[**EzsignimportfolderGetObjectV2Response**](EzsignimportfolderGetObjectV2Response.md)

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


# eZmaxApi.Api.ObjectEzdoctemplatedocumentApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzdoctemplatedocumentCreateObjectV1**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumentcreateobjectv1) | **POST** /1/object/ezdoctemplatedocument | Create a new Ezdoctemplatedocument |
| [**EzdoctemplatedocumentDownloadV1**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumentdownloadv1) | **GET** /1/object/ezdoctemplatedocument/{pkiEzdoctemplatedocumentID}/download | Retrieve the content |
| [**EzdoctemplatedocumentEditObjectV1**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumenteditobjectv1) | **PUT** /1/object/ezdoctemplatedocument/{pkiEzdoctemplatedocumentID} | Edit an existing Ezdoctemplatedocument |
| [**EzdoctemplatedocumentGetAutocompleteV2**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumentgetautocompletev2) | **GET** /2/object/ezdoctemplatedocument/getAutocomplete/{sSelector} | Retrieve Ezdoctemplatedocuments and IDs |
| [**EzdoctemplatedocumentGetListV1**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumentgetlistv1) | **GET** /1/object/ezdoctemplatedocument/getList | Retrieve Ezdoctemplatedocument list |
| [**EzdoctemplatedocumentGetObjectV2**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumentgetobjectv2) | **GET** /2/object/ezdoctemplatedocument/{pkiEzdoctemplatedocumentID} | Retrieve an existing Ezdoctemplatedocument |
| [**EzdoctemplatedocumentPatchObjectV1**](ObjectEzdoctemplatedocumentApi.md#ezdoctemplatedocumentpatchobjectv1) | **PATCH** /1/object/ezdoctemplatedocument/{pkiEzdoctemplatedocumentID} | Patch an existing Ezdoctemplatedocument |

<a id="ezdoctemplatedocumentcreateobjectv1"></a>
# **EzdoctemplatedocumentCreateObjectV1**
> EzdoctemplatedocumentCreateObjectV1Response EzdoctemplatedocumentCreateObjectV1 (EzdoctemplatedocumentCreateObjectV1Request ezdoctemplatedocumentCreateObjectV1Request)

Create a new Ezdoctemplatedocument

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezdoctemplatedocumentCreateObjectV1Request** | [**EzdoctemplatedocumentCreateObjectV1Request**](EzdoctemplatedocumentCreateObjectV1Request.md) |  |  |

### Return type

[**EzdoctemplatedocumentCreateObjectV1Response**](EzdoctemplatedocumentCreateObjectV1Response.md)

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

<a id="ezdoctemplatedocumentdownloadv1"></a>
# **EzdoctemplatedocumentDownloadV1**
> void EzdoctemplatedocumentDownloadV1 (int pkiEzdoctemplatedocumentID)

Retrieve the content

Using this endpoint, you can retrieve the content of an ezdoctemplatedocument.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzdoctemplatedocumentID** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization), [Presigned](../README.md#Presigned)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | The user has been redirected |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezdoctemplatedocumenteditobjectv1"></a>
# **EzdoctemplatedocumentEditObjectV1**
> EzdoctemplatedocumentEditObjectV1Response EzdoctemplatedocumentEditObjectV1 (int pkiEzdoctemplatedocumentID, EzdoctemplatedocumentEditObjectV1Request ezdoctemplatedocumentEditObjectV1Request)

Edit an existing Ezdoctemplatedocument


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzdoctemplatedocumentID** | **int** | The unique ID of the Ezdoctemplatedocument |  |
| **ezdoctemplatedocumentEditObjectV1Request** | [**EzdoctemplatedocumentEditObjectV1Request**](EzdoctemplatedocumentEditObjectV1Request.md) |  |  |

### Return type

[**EzdoctemplatedocumentEditObjectV1Response**](EzdoctemplatedocumentEditObjectV1Response.md)

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

<a id="ezdoctemplatedocumentgetautocompletev2"></a>
# **EzdoctemplatedocumentGetAutocompleteV2**
> EzdoctemplatedocumentGetAutocompleteV2Response EzdoctemplatedocumentGetAutocompleteV2 (string sSelector, string eType, string fkiEzsignfoldertypeID = null, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Ezdoctemplatedocuments and IDs

Get the list of Ezdoctemplatedocument to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Ezdoctemplatedocuments to return |  |
| **eType** | **string** | The type of Ezdoctemplatedocument | [default to CompanyEzsignfoldertype] |
| **fkiEzsignfoldertypeID** | **string** | Specify which fkiEzsignfoldertypeID we want to display. only used when eType &#x3D; Ezsignfoldertype | [optional]  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**EzdoctemplatedocumentGetAutocompleteV2Response**](EzdoctemplatedocumentGetAutocompleteV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezdoctemplatedocumentgetlistv1"></a>
# **EzdoctemplatedocumentGetListV1**
> EzdoctemplatedocumentGetListV1Response EzdoctemplatedocumentGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Ezdoctemplatedocument list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**EzdoctemplatedocumentGetListV1Response**](EzdoctemplatedocumentGetListV1Response.md)

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

<a id="ezdoctemplatedocumentgetobjectv2"></a>
# **EzdoctemplatedocumentGetObjectV2**
> EzdoctemplatedocumentGetObjectV2Response EzdoctemplatedocumentGetObjectV2 (int pkiEzdoctemplatedocumentID)

Retrieve an existing Ezdoctemplatedocument


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzdoctemplatedocumentID** | **int** | The unique ID of the Ezdoctemplatedocument |  |

### Return type

[**EzdoctemplatedocumentGetObjectV2Response**](EzdoctemplatedocumentGetObjectV2Response.md)

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

<a id="ezdoctemplatedocumentpatchobjectv1"></a>
# **EzdoctemplatedocumentPatchObjectV1**
> EzdoctemplatedocumentPatchObjectV1Response EzdoctemplatedocumentPatchObjectV1 (int pkiEzdoctemplatedocumentID, EzdoctemplatedocumentPatchObjectV1Request ezdoctemplatedocumentPatchObjectV1Request)

Patch an existing Ezdoctemplatedocument


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzdoctemplatedocumentID** | **int** | The unique ID of the Ezdoctemplatedocument |  |
| **ezdoctemplatedocumentPatchObjectV1Request** | [**EzdoctemplatedocumentPatchObjectV1Request**](EzdoctemplatedocumentPatchObjectV1Request.md) |  |  |

### Return type

[**EzdoctemplatedocumentPatchObjectV1Response**](EzdoctemplatedocumentPatchObjectV1Response.md)

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


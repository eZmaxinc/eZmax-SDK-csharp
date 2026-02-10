# eZmaxApi.Api.ObjectEzsignformfieldgroupApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignformfieldgroupCreateObjectV1**](ObjectEzsignformfieldgroupApi.md#ezsignformfieldgroupcreateobjectv1) | **POST** /1/object/ezsignformfieldgroup | Create a new Ezsignformfieldgroup |
| [**EzsignformfieldgroupDeleteObjectV1**](ObjectEzsignformfieldgroupApi.md#ezsignformfieldgroupdeleteobjectv1) | **DELETE** /1/object/ezsignformfieldgroup/{pkiEzsignformfieldgroupID} | Delete an existing Ezsignformfieldgroup |
| [**EzsignformfieldgroupEditObjectV1**](ObjectEzsignformfieldgroupApi.md#ezsignformfieldgroupeditobjectv1) | **PUT** /1/object/ezsignformfieldgroup/{pkiEzsignformfieldgroupID} | Edit an existing Ezsignformfieldgroup |
| [**EzsignformfieldgroupGetObjectV2**](ObjectEzsignformfieldgroupApi.md#ezsignformfieldgroupgetobjectv2) | **GET** /2/object/ezsignformfieldgroup/{pkiEzsignformfieldgroupID} | Retrieve an existing Ezsignformfieldgroup |

<a id="ezsignformfieldgroupcreateobjectv1"></a>
# **EzsignformfieldgroupCreateObjectV1**
> EzsignformfieldgroupCreateObjectV1Response EzsignformfieldgroupCreateObjectV1 (EzsignformfieldgroupCreateObjectV1Request ezsignformfieldgroupCreateObjectV1Request)

Create a new Ezsignformfieldgroup

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignformfieldgroupCreateObjectV1Request** | [**EzsignformfieldgroupCreateObjectV1Request**](EzsignformfieldgroupCreateObjectV1Request.md) |  |  |

### Return type

[**EzsignformfieldgroupCreateObjectV1Response**](EzsignformfieldgroupCreateObjectV1Response.md)

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

<a id="ezsignformfieldgroupdeleteobjectv1"></a>
# **EzsignformfieldgroupDeleteObjectV1**
> EzsignformfieldgroupDeleteObjectV1Response EzsignformfieldgroupDeleteObjectV1 (int pkiEzsignformfieldgroupID)

Delete an existing Ezsignformfieldgroup


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignformfieldgroupID** | **int** |  |  |

### Return type

[**EzsignformfieldgroupDeleteObjectV1Response**](EzsignformfieldgroupDeleteObjectV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsignformfieldgroupeditobjectv1"></a>
# **EzsignformfieldgroupEditObjectV1**
> EzsignformfieldgroupEditObjectV1Response EzsignformfieldgroupEditObjectV1 (int pkiEzsignformfieldgroupID, EzsignformfieldgroupEditObjectV1Request ezsignformfieldgroupEditObjectV1Request)

Edit an existing Ezsignformfieldgroup


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignformfieldgroupID** | **int** |  |  |
| **ezsignformfieldgroupEditObjectV1Request** | [**EzsignformfieldgroupEditObjectV1Request**](EzsignformfieldgroupEditObjectV1Request.md) |  |  |

### Return type

[**EzsignformfieldgroupEditObjectV1Response**](EzsignformfieldgroupEditObjectV1Response.md)

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

<a id="ezsignformfieldgroupgetobjectv2"></a>
# **EzsignformfieldgroupGetObjectV2**
> EzsignformfieldgroupGetObjectV2Response EzsignformfieldgroupGetObjectV2 (int pkiEzsignformfieldgroupID)

Retrieve an existing Ezsignformfieldgroup


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignformfieldgroupID** | **int** |  |  |

### Return type

[**EzsignformfieldgroupGetObjectV2Response**](EzsignformfieldgroupGetObjectV2Response.md)

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


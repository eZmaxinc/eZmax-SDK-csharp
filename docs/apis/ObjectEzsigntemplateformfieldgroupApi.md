# eZmaxApi.Api.ObjectEzsigntemplateformfieldgroupApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplateformfieldgroupCreateObjectV1**](ObjectEzsigntemplateformfieldgroupApi.md#ezsigntemplateformfieldgroupcreateobjectv1) | **POST** /1/object/ezsigntemplateformfieldgroup | Create a new Ezsigntemplateformfieldgroup |
| [**EzsigntemplateformfieldgroupDeleteObjectV1**](ObjectEzsigntemplateformfieldgroupApi.md#ezsigntemplateformfieldgroupdeleteobjectv1) | **DELETE** /1/object/ezsigntemplateformfieldgroup/{pkiEzsigntemplateformfieldgroupID} | Delete an existing Ezsigntemplateformfieldgroup |
| [**EzsigntemplateformfieldgroupEditObjectV1**](ObjectEzsigntemplateformfieldgroupApi.md#ezsigntemplateformfieldgroupeditobjectv1) | **PUT** /1/object/ezsigntemplateformfieldgroup/{pkiEzsigntemplateformfieldgroupID} | Edit an existing Ezsigntemplateformfieldgroup |
| [**EzsigntemplateformfieldgroupGetObjectV2**](ObjectEzsigntemplateformfieldgroupApi.md#ezsigntemplateformfieldgroupgetobjectv2) | **GET** /2/object/ezsigntemplateformfieldgroup/{pkiEzsigntemplateformfieldgroupID} | Retrieve an existing Ezsigntemplateformfieldgroup |

<a id="ezsigntemplateformfieldgroupcreateobjectv1"></a>
# **EzsigntemplateformfieldgroupCreateObjectV1**
> EzsigntemplateformfieldgroupCreateObjectV1Response EzsigntemplateformfieldgroupCreateObjectV1 (EzsigntemplateformfieldgroupCreateObjectV1Request ezsigntemplateformfieldgroupCreateObjectV1Request)

Create a new Ezsigntemplateformfieldgroup

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplateformfieldgroupCreateObjectV1Request** | [**EzsigntemplateformfieldgroupCreateObjectV1Request**](EzsigntemplateformfieldgroupCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplateformfieldgroupCreateObjectV1Response**](EzsigntemplateformfieldgroupCreateObjectV1Response.md)

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

<a id="ezsigntemplateformfieldgroupdeleteobjectv1"></a>
# **EzsigntemplateformfieldgroupDeleteObjectV1**
> EzsigntemplateformfieldgroupDeleteObjectV1Response EzsigntemplateformfieldgroupDeleteObjectV1 (int pkiEzsigntemplateformfieldgroupID)

Delete an existing Ezsigntemplateformfieldgroup


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateformfieldgroupID** | **int** |  |  |

### Return type

[**EzsigntemplateformfieldgroupDeleteObjectV1Response**](EzsigntemplateformfieldgroupDeleteObjectV1Response.md)

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

<a id="ezsigntemplateformfieldgroupeditobjectv1"></a>
# **EzsigntemplateformfieldgroupEditObjectV1**
> EzsigntemplateformfieldgroupEditObjectV1Response EzsigntemplateformfieldgroupEditObjectV1 (int pkiEzsigntemplateformfieldgroupID, EzsigntemplateformfieldgroupEditObjectV1Request ezsigntemplateformfieldgroupEditObjectV1Request)

Edit an existing Ezsigntemplateformfieldgroup


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateformfieldgroupID** | **int** |  |  |
| **ezsigntemplateformfieldgroupEditObjectV1Request** | [**EzsigntemplateformfieldgroupEditObjectV1Request**](EzsigntemplateformfieldgroupEditObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplateformfieldgroupEditObjectV1Response**](EzsigntemplateformfieldgroupEditObjectV1Response.md)

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

<a id="ezsigntemplateformfieldgroupgetobjectv2"></a>
# **EzsigntemplateformfieldgroupGetObjectV2**
> EzsigntemplateformfieldgroupGetObjectV2Response EzsigntemplateformfieldgroupGetObjectV2 (int pkiEzsigntemplateformfieldgroupID)

Retrieve an existing Ezsigntemplateformfieldgroup


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateformfieldgroupID** | **int** |  |  |

### Return type

[**EzsigntemplateformfieldgroupGetObjectV2Response**](EzsigntemplateformfieldgroupGetObjectV2Response.md)

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


# eZmaxApi.Api.ObjectEzsigntemplateannotationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplateannotationCreateObjectV1**](ObjectEzsigntemplateannotationApi.md#ezsigntemplateannotationcreateobjectv1) | **POST** /1/object/ezsigntemplateannotation | Create a new Ezsigntemplateannotation |
| [**EzsigntemplateannotationDeleteObjectV1**](ObjectEzsigntemplateannotationApi.md#ezsigntemplateannotationdeleteobjectv1) | **DELETE** /1/object/ezsigntemplateannotation/{pkiEzsigntemplateannotationID} | Delete an existing Ezsigntemplateannotation |
| [**EzsigntemplateannotationEditObjectV1**](ObjectEzsigntemplateannotationApi.md#ezsigntemplateannotationeditobjectv1) | **PUT** /1/object/ezsigntemplateannotation/{pkiEzsigntemplateannotationID} | Edit an existing Ezsigntemplateannotation |
| [**EzsigntemplateannotationGetObjectV2**](ObjectEzsigntemplateannotationApi.md#ezsigntemplateannotationgetobjectv2) | **GET** /2/object/ezsigntemplateannotation/{pkiEzsigntemplateannotationID} | Retrieve an existing Ezsigntemplateannotation |

<a id="ezsigntemplateannotationcreateobjectv1"></a>
# **EzsigntemplateannotationCreateObjectV1**
> EzsigntemplateannotationCreateObjectV1Response EzsigntemplateannotationCreateObjectV1 (EzsigntemplateannotationCreateObjectV1Request ezsigntemplateannotationCreateObjectV1Request)

Create a new Ezsigntemplateannotation

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplateannotationCreateObjectV1Request** | [**EzsigntemplateannotationCreateObjectV1Request**](EzsigntemplateannotationCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplateannotationCreateObjectV1Response**](EzsigntemplateannotationCreateObjectV1Response.md)

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

<a id="ezsigntemplateannotationdeleteobjectv1"></a>
# **EzsigntemplateannotationDeleteObjectV1**
> EzsigntemplateannotationDeleteObjectV1Response EzsigntemplateannotationDeleteObjectV1 (int pkiEzsigntemplateannotationID)

Delete an existing Ezsigntemplateannotation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateannotationID** | **int** | The unique ID of the Ezsigntemplateannotation |  |

### Return type

[**EzsigntemplateannotationDeleteObjectV1Response**](EzsigntemplateannotationDeleteObjectV1Response.md)

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

<a id="ezsigntemplateannotationeditobjectv1"></a>
# **EzsigntemplateannotationEditObjectV1**
> EzsigntemplateannotationEditObjectV1Response EzsigntemplateannotationEditObjectV1 (int pkiEzsigntemplateannotationID, EzsigntemplateannotationEditObjectV1Request ezsigntemplateannotationEditObjectV1Request)

Edit an existing Ezsigntemplateannotation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateannotationID** | **int** | The unique ID of the Ezsigntemplateannotation |  |
| **ezsigntemplateannotationEditObjectV1Request** | [**EzsigntemplateannotationEditObjectV1Request**](EzsigntemplateannotationEditObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplateannotationEditObjectV1Response**](EzsigntemplateannotationEditObjectV1Response.md)

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

<a id="ezsigntemplateannotationgetobjectv2"></a>
# **EzsigntemplateannotationGetObjectV2**
> EzsigntemplateannotationGetObjectV2Response EzsigntemplateannotationGetObjectV2 (int pkiEzsigntemplateannotationID)

Retrieve an existing Ezsigntemplateannotation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateannotationID** | **int** | The unique ID of the Ezsigntemplateannotation |  |

### Return type

[**EzsigntemplateannotationGetObjectV2Response**](EzsigntemplateannotationGetObjectV2Response.md)

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


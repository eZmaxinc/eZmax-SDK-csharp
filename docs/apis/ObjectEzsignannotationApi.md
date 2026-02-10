# eZmaxApi.Api.ObjectEzsignannotationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignannotationCreateObjectV1**](ObjectEzsignannotationApi.md#ezsignannotationcreateobjectv1) | **POST** /1/object/ezsignannotation | Create a new Ezsignannotation |
| [**EzsignannotationDeleteObjectV1**](ObjectEzsignannotationApi.md#ezsignannotationdeleteobjectv1) | **DELETE** /1/object/ezsignannotation/{pkiEzsignannotationID} | Delete an existing Ezsignannotation |
| [**EzsignannotationEditObjectV1**](ObjectEzsignannotationApi.md#ezsignannotationeditobjectv1) | **PUT** /1/object/ezsignannotation/{pkiEzsignannotationID} | Edit an existing Ezsignannotation |
| [**EzsignannotationGetObjectV2**](ObjectEzsignannotationApi.md#ezsignannotationgetobjectv2) | **GET** /2/object/ezsignannotation/{pkiEzsignannotationID} | Retrieve an existing Ezsignannotation |

<a id="ezsignannotationcreateobjectv1"></a>
# **EzsignannotationCreateObjectV1**
> EzsignannotationCreateObjectV1Response EzsignannotationCreateObjectV1 (EzsignannotationCreateObjectV1Request ezsignannotationCreateObjectV1Request)

Create a new Ezsignannotation

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignannotationCreateObjectV1Request** | [**EzsignannotationCreateObjectV1Request**](EzsignannotationCreateObjectV1Request.md) |  |  |

### Return type

[**EzsignannotationCreateObjectV1Response**](EzsignannotationCreateObjectV1Response.md)

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

<a id="ezsignannotationdeleteobjectv1"></a>
# **EzsignannotationDeleteObjectV1**
> EzsignannotationDeleteObjectV1Response EzsignannotationDeleteObjectV1 (int pkiEzsignannotationID)

Delete an existing Ezsignannotation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignannotationID** | **int** |  |  |

### Return type

[**EzsignannotationDeleteObjectV1Response**](EzsignannotationDeleteObjectV1Response.md)

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

<a id="ezsignannotationeditobjectv1"></a>
# **EzsignannotationEditObjectV1**
> EzsignannotationEditObjectV1Response EzsignannotationEditObjectV1 (int pkiEzsignannotationID, EzsignannotationEditObjectV1Request ezsignannotationEditObjectV1Request)

Edit an existing Ezsignannotation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignannotationID** | **int** |  |  |
| **ezsignannotationEditObjectV1Request** | [**EzsignannotationEditObjectV1Request**](EzsignannotationEditObjectV1Request.md) |  |  |

### Return type

[**EzsignannotationEditObjectV1Response**](EzsignannotationEditObjectV1Response.md)

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

<a id="ezsignannotationgetobjectv2"></a>
# **EzsignannotationGetObjectV2**
> EzsignannotationGetObjectV2Response EzsignannotationGetObjectV2 (int pkiEzsignannotationID)

Retrieve an existing Ezsignannotation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignannotationID** | **int** |  |  |

### Return type

[**EzsignannotationGetObjectV2Response**](EzsignannotationGetObjectV2Response.md)

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


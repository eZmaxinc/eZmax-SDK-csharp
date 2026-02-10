# eZmaxApi.Api.ObjectEzsigntemplatedocumentpagerecognitionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplatedocumentpagerecognitionCreateObjectV1**](ObjectEzsigntemplatedocumentpagerecognitionApi.md#ezsigntemplatedocumentpagerecognitioncreateobjectv1) | **POST** /1/object/ezsigntemplatedocumentpagerecognition | Create a new Ezsigntemplatedocumentpagerecognition |
| [**EzsigntemplatedocumentpagerecognitionDeleteObjectV1**](ObjectEzsigntemplatedocumentpagerecognitionApi.md#ezsigntemplatedocumentpagerecognitiondeleteobjectv1) | **DELETE** /1/object/ezsigntemplatedocumentpagerecognition/{pkiEzsigntemplatedocumentpagerecognitionID} | Delete an existing Ezsigntemplatedocumentpagerecognition |
| [**EzsigntemplatedocumentpagerecognitionEditObjectV1**](ObjectEzsigntemplatedocumentpagerecognitionApi.md#ezsigntemplatedocumentpagerecognitioneditobjectv1) | **PUT** /1/object/ezsigntemplatedocumentpagerecognition/{pkiEzsigntemplatedocumentpagerecognitionID} | Edit an existing Ezsigntemplatedocumentpagerecognition |
| [**EzsigntemplatedocumentpagerecognitionGetObjectV2**](ObjectEzsigntemplatedocumentpagerecognitionApi.md#ezsigntemplatedocumentpagerecognitiongetobjectv2) | **GET** /2/object/ezsigntemplatedocumentpagerecognition/{pkiEzsigntemplatedocumentpagerecognitionID} | Retrieve an existing Ezsigntemplatedocumentpagerecognition |

<a id="ezsigntemplatedocumentpagerecognitioncreateobjectv1"></a>
# **EzsigntemplatedocumentpagerecognitionCreateObjectV1**
> EzsigntemplatedocumentpagerecognitionCreateObjectV1Response EzsigntemplatedocumentpagerecognitionCreateObjectV1 (EzsigntemplatedocumentpagerecognitionCreateObjectV1Request ezsigntemplatedocumentpagerecognitionCreateObjectV1Request)

Create a new Ezsigntemplatedocumentpagerecognition

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatedocumentpagerecognitionCreateObjectV1Request** | [**EzsigntemplatedocumentpagerecognitionCreateObjectV1Request**](EzsigntemplatedocumentpagerecognitionCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatedocumentpagerecognitionCreateObjectV1Response**](EzsigntemplatedocumentpagerecognitionCreateObjectV1Response.md)

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

<a id="ezsigntemplatedocumentpagerecognitiondeleteobjectv1"></a>
# **EzsigntemplatedocumentpagerecognitionDeleteObjectV1**
> EzsigntemplatedocumentpagerecognitionDeleteObjectV1Response EzsigntemplatedocumentpagerecognitionDeleteObjectV1 (int pkiEzsigntemplatedocumentpagerecognitionID)

Delete an existing Ezsigntemplatedocumentpagerecognition


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentpagerecognitionID** | **int** | The unique ID of the Ezsigntemplatedocumentpagerecognition |  |

### Return type

[**EzsigntemplatedocumentpagerecognitionDeleteObjectV1Response**](EzsigntemplatedocumentpagerecognitionDeleteObjectV1Response.md)

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

<a id="ezsigntemplatedocumentpagerecognitioneditobjectv1"></a>
# **EzsigntemplatedocumentpagerecognitionEditObjectV1**
> EzsigntemplatedocumentpagerecognitionEditObjectV1Response EzsigntemplatedocumentpagerecognitionEditObjectV1 (int pkiEzsigntemplatedocumentpagerecognitionID, EzsigntemplatedocumentpagerecognitionEditObjectV1Request ezsigntemplatedocumentpagerecognitionEditObjectV1Request)

Edit an existing Ezsigntemplatedocumentpagerecognition


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentpagerecognitionID** | **int** | The unique ID of the Ezsigntemplatedocumentpagerecognition |  |
| **ezsigntemplatedocumentpagerecognitionEditObjectV1Request** | [**EzsigntemplatedocumentpagerecognitionEditObjectV1Request**](EzsigntemplatedocumentpagerecognitionEditObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatedocumentpagerecognitionEditObjectV1Response**](EzsigntemplatedocumentpagerecognitionEditObjectV1Response.md)

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

<a id="ezsigntemplatedocumentpagerecognitiongetobjectv2"></a>
# **EzsigntemplatedocumentpagerecognitionGetObjectV2**
> EzsigntemplatedocumentpagerecognitionGetObjectV2Response EzsigntemplatedocumentpagerecognitionGetObjectV2 (int pkiEzsigntemplatedocumentpagerecognitionID)

Retrieve an existing Ezsigntemplatedocumentpagerecognition


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatedocumentpagerecognitionID** | **int** | The unique ID of the Ezsigntemplatedocumentpagerecognition |  |

### Return type

[**EzsigntemplatedocumentpagerecognitionGetObjectV2Response**](EzsigntemplatedocumentpagerecognitionGetObjectV2Response.md)

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


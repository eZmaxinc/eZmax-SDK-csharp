# eZmaxApi.Api.ObjectEzsigndiscussionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigndiscussionCreateObjectV1**](ObjectEzsigndiscussionApi.md#ezsigndiscussioncreateobjectv1) | **POST** /1/object/ezsigndiscussion | Create a new Ezsigndiscussion |
| [**EzsigndiscussionDeleteObjectV1**](ObjectEzsigndiscussionApi.md#ezsigndiscussiondeleteobjectv1) | **DELETE** /1/object/ezsigndiscussion/{pkiEzsigndiscussionID} | Delete an existing Ezsigndiscussion |
| [**EzsigndiscussionGetObjectV2**](ObjectEzsigndiscussionApi.md#ezsigndiscussiongetobjectv2) | **GET** /2/object/ezsigndiscussion/{pkiEzsigndiscussionID} | Retrieve an existing Ezsigndiscussion |

<a id="ezsigndiscussioncreateobjectv1"></a>
# **EzsigndiscussionCreateObjectV1**
> EzsigndiscussionCreateObjectV1Response EzsigndiscussionCreateObjectV1 (EzsigndiscussionCreateObjectV1Request ezsigndiscussionCreateObjectV1Request)

Create a new Ezsigndiscussion

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigndiscussionCreateObjectV1Request** | [**EzsigndiscussionCreateObjectV1Request**](EzsigndiscussionCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigndiscussionCreateObjectV1Response**](EzsigndiscussionCreateObjectV1Response.md)

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

<a id="ezsigndiscussiondeleteobjectv1"></a>
# **EzsigndiscussionDeleteObjectV1**
> EzsigndiscussionDeleteObjectV1Response EzsigndiscussionDeleteObjectV1 (int pkiEzsigndiscussionID)

Delete an existing Ezsigndiscussion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndiscussionID** | **int** | The unique ID of the Ezsigndiscussion |  |

### Return type

[**EzsigndiscussionDeleteObjectV1Response**](EzsigndiscussionDeleteObjectV1Response.md)

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

<a id="ezsigndiscussiongetobjectv2"></a>
# **EzsigndiscussionGetObjectV2**
> EzsigndiscussionGetObjectV2Response EzsigndiscussionGetObjectV2 (int pkiEzsigndiscussionID)

Retrieve an existing Ezsigndiscussion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndiscussionID** | **int** | The unique ID of the Ezsigndiscussion |  |

### Return type

[**EzsigndiscussionGetObjectV2Response**](EzsigndiscussionGetObjectV2Response.md)

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


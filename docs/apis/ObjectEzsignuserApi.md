# eZmaxApi.Api.ObjectEzsignuserApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignuserEditObjectV1**](ObjectEzsignuserApi.md#ezsignusereditobjectv1) | **PUT** /1/object/ezsignuser/{pkiEzsignuserID} | Edit an existing Ezsignuser |
| [**EzsignuserGetObjectV2**](ObjectEzsignuserApi.md#ezsignusergetobjectv2) | **GET** /2/object/ezsignuser/{pkiEzsignuserID} | Retrieve an existing Ezsignuser |

<a id="ezsignusereditobjectv1"></a>
# **EzsignuserEditObjectV1**
> EzsignuserEditObjectV1Response EzsignuserEditObjectV1 (int pkiEzsignuserID, EzsignuserEditObjectV1Request ezsignuserEditObjectV1Request)

Edit an existing Ezsignuser


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignuserID** | **int** | The unique ID of the Ezsignuser |  |
| **ezsignuserEditObjectV1Request** | [**EzsignuserEditObjectV1Request**](EzsignuserEditObjectV1Request.md) |  |  |

### Return type

[**EzsignuserEditObjectV1Response**](EzsignuserEditObjectV1Response.md)

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

<a id="ezsignusergetobjectv2"></a>
# **EzsignuserGetObjectV2**
> EzsignuserGetObjectV2Response EzsignuserGetObjectV2 (int pkiEzsignuserID)

Retrieve an existing Ezsignuser


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignuserID** | **int** | The unique ID of the Ezsignuser |  |

### Return type

[**EzsignuserGetObjectV2Response**](EzsignuserGetObjectV2Response.md)

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


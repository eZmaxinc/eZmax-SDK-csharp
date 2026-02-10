# eZmaxApi.Api.ObjectEzsigntemplatesignatureApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplatesignatureCreateObjectV2**](ObjectEzsigntemplatesignatureApi.md#ezsigntemplatesignaturecreateobjectv2) | **POST** /2/object/ezsigntemplatesignature | Create a new Ezsigntemplatesignature |
| [**EzsigntemplatesignatureCreateObjectV3**](ObjectEzsigntemplatesignatureApi.md#ezsigntemplatesignaturecreateobjectv3) | **POST** /3/object/ezsigntemplatesignature | Create a new Ezsigntemplatesignature |
| [**EzsigntemplatesignatureDeleteObjectV1**](ObjectEzsigntemplatesignatureApi.md#ezsigntemplatesignaturedeleteobjectv1) | **DELETE** /1/object/ezsigntemplatesignature/{pkiEzsigntemplatesignatureID} | Delete an existing Ezsigntemplatesignature |
| [**EzsigntemplatesignatureEditObjectV3**](ObjectEzsigntemplatesignatureApi.md#ezsigntemplatesignatureeditobjectv3) | **PUT** /3/object/ezsigntemplatesignature/{pkiEzsigntemplatesignatureID} | Edit an existing Ezsigntemplatesignature |
| [**EzsigntemplatesignatureGetObjectV4**](ObjectEzsigntemplatesignatureApi.md#ezsigntemplatesignaturegetobjectv4) | **GET** /4/object/ezsigntemplatesignature/{pkiEzsigntemplatesignatureID} | Retrieve an existing Ezsigntemplatesignature |

<a id="ezsigntemplatesignaturecreateobjectv2"></a>
# **EzsigntemplatesignatureCreateObjectV2**
> EzsigntemplatesignatureCreateObjectV2Response EzsigntemplatesignatureCreateObjectV2 (EzsigntemplatesignatureCreateObjectV2Request ezsigntemplatesignatureCreateObjectV2Request)

Create a new Ezsigntemplatesignature

The endpoint allows to create one or many elements at once.  Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatesignatureCreateObjectV2Request** | [**EzsigntemplatesignatureCreateObjectV2Request**](EzsigntemplatesignatureCreateObjectV2Request.md) |  |  |

### Return type

[**EzsigntemplatesignatureCreateObjectV2Response**](EzsigntemplatesignatureCreateObjectV2Response.md)

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

<a id="ezsigntemplatesignaturecreateobjectv3"></a>
# **EzsigntemplatesignatureCreateObjectV3**
> EzsigntemplatesignatureCreateObjectV3Response EzsigntemplatesignatureCreateObjectV3 (EzsigntemplatesignatureCreateObjectV3Request ezsigntemplatesignatureCreateObjectV3Request)

Create a new Ezsigntemplatesignature

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatesignatureCreateObjectV3Request** | [**EzsigntemplatesignatureCreateObjectV3Request**](EzsigntemplatesignatureCreateObjectV3Request.md) |  |  |

### Return type

[**EzsigntemplatesignatureCreateObjectV3Response**](EzsigntemplatesignatureCreateObjectV3Response.md)

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

<a id="ezsigntemplatesignaturedeleteobjectv1"></a>
# **EzsigntemplatesignatureDeleteObjectV1**
> EzsigntemplatesignatureDeleteObjectV1Response EzsigntemplatesignatureDeleteObjectV1 (int pkiEzsigntemplatesignatureID)

Delete an existing Ezsigntemplatesignature


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatesignatureID** | **int** |  |  |

### Return type

[**EzsigntemplatesignatureDeleteObjectV1Response**](EzsigntemplatesignatureDeleteObjectV1Response.md)

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

<a id="ezsigntemplatesignatureeditobjectv3"></a>
# **EzsigntemplatesignatureEditObjectV3**
> EzsigntemplatesignatureEditObjectV3Response EzsigntemplatesignatureEditObjectV3 (int pkiEzsigntemplatesignatureID, EzsigntemplatesignatureEditObjectV3Request ezsigntemplatesignatureEditObjectV3Request)

Edit an existing Ezsigntemplatesignature


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatesignatureID** | **int** |  |  |
| **ezsigntemplatesignatureEditObjectV3Request** | [**EzsigntemplatesignatureEditObjectV3Request**](EzsigntemplatesignatureEditObjectV3Request.md) |  |  |

### Return type

[**EzsigntemplatesignatureEditObjectV3Response**](EzsigntemplatesignatureEditObjectV3Response.md)

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

<a id="ezsigntemplatesignaturegetobjectv4"></a>
# **EzsigntemplatesignatureGetObjectV4**
> EzsigntemplatesignatureGetObjectV4Response EzsigntemplatesignatureGetObjectV4 (int pkiEzsigntemplatesignatureID)

Retrieve an existing Ezsigntemplatesignature


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatesignatureID** | **int** |  |  |

### Return type

[**EzsigntemplatesignatureGetObjectV4Response**](EzsigntemplatesignatureGetObjectV4Response.md)

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


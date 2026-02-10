# eZmaxApi.Api.ObjectSignatureApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SignatureCreateObjectV1**](ObjectSignatureApi.md#signaturecreateobjectv1) | **POST** /1/object/signature | Create a new Signature |
| [**SignatureDeleteObjectV1**](ObjectSignatureApi.md#signaturedeleteobjectv1) | **DELETE** /1/object/signature/{pkiSignatureID} | Delete an existing Signature |
| [**SignatureEditObjectV1**](ObjectSignatureApi.md#signatureeditobjectv1) | **PUT** /1/object/signature/{pkiSignatureID} | Edit an existing Signature |
| [**SignatureGetObjectV3**](ObjectSignatureApi.md#signaturegetobjectv3) | **GET** /3/object/signature/{pkiSignatureID} | Retrieve an existing Signature |
| [**SignatureGetSVGInitialsV1**](ObjectSignatureApi.md#signaturegetsvginitialsv1) | **GET** /1/object/signature/{pkiSignatureID}/getSVGInitials | Retrieve an existing Signature initial SVG |
| [**SignatureGetSVGSignatureV1**](ObjectSignatureApi.md#signaturegetsvgsignaturev1) | **GET** /1/object/signature/{pkiSignatureID}/getSVGSignature | Retrieve an existing Signature SVG |

<a id="signaturecreateobjectv1"></a>
# **SignatureCreateObjectV1**
> SignatureCreateObjectV1Response SignatureCreateObjectV1 (SignatureCreateObjectV1Request signatureCreateObjectV1Request)

Create a new Signature

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureCreateObjectV1Request** | [**SignatureCreateObjectV1Request**](SignatureCreateObjectV1Request.md) |  |  |

### Return type

[**SignatureCreateObjectV1Response**](SignatureCreateObjectV1Response.md)

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

<a id="signaturedeleteobjectv1"></a>
# **SignatureDeleteObjectV1**
> SignatureDeleteObjectV1Response SignatureDeleteObjectV1 (int pkiSignatureID)

Delete an existing Signature


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSignatureID** | **int** | The unique ID of the Signature |  |

### Return type

[**SignatureDeleteObjectV1Response**](SignatureDeleteObjectV1Response.md)

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

<a id="signatureeditobjectv1"></a>
# **SignatureEditObjectV1**
> SignatureEditObjectV1Response SignatureEditObjectV1 (int pkiSignatureID, SignatureEditObjectV1Request signatureEditObjectV1Request)

Edit an existing Signature


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSignatureID** | **int** | The unique ID of the Signature |  |
| **signatureEditObjectV1Request** | [**SignatureEditObjectV1Request**](SignatureEditObjectV1Request.md) |  |  |

### Return type

[**SignatureEditObjectV1Response**](SignatureEditObjectV1Response.md)

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

<a id="signaturegetobjectv3"></a>
# **SignatureGetObjectV3**
> SignatureGetObjectV3Response SignatureGetObjectV3 (int pkiSignatureID)

Retrieve an existing Signature


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSignatureID** | **int** | The unique ID of the Signature |  |

### Return type

[**SignatureGetObjectV3Response**](SignatureGetObjectV3Response.md)

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

<a id="signaturegetsvginitialsv1"></a>
# **SignatureGetSVGInitialsV1**
> void SignatureGetSVGInitialsV1 (int pkiSignatureID)

Retrieve an existing Signature initial SVG


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSignatureID** | **int** | The unique ID of the Signature |  |

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | The user has been redirected |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="signaturegetsvgsignaturev1"></a>
# **SignatureGetSVGSignatureV1**
> void SignatureGetSVGSignatureV1 (int pkiSignatureID)

Retrieve an existing Signature SVG


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSignatureID** | **int** | The unique ID of the Signature |  |

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | The user has been redirected |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


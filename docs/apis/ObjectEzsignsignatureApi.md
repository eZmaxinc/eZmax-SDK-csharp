# eZmaxApi.Api.ObjectEzsignsignatureApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignsignatureCreateObjectV1**](ObjectEzsignsignatureApi.md#ezsignsignaturecreateobjectv1) | **POST** /1/object/ezsignsignature | Create a new Ezsignsignature |
| [**EzsignsignatureCreateObjectV2**](ObjectEzsignsignatureApi.md#ezsignsignaturecreateobjectv2) | **POST** /2/object/ezsignsignature | Create a new Ezsignsignature |
| [**EzsignsignatureCreateObjectV3**](ObjectEzsignsignatureApi.md#ezsignsignaturecreateobjectv3) | **POST** /3/object/ezsignsignature | Create a new Ezsignsignature |
| [**EzsignsignatureCreateObjectV4**](ObjectEzsignsignatureApi.md#ezsignsignaturecreateobjectv4) | **POST** /4/object/ezsignsignature | Create a new Ezsignsignature |
| [**EzsignsignatureDeleteObjectV1**](ObjectEzsignsignatureApi.md#ezsignsignaturedeleteobjectv1) | **DELETE** /1/object/ezsignsignature/{pkiEzsignsignatureID} | Delete an existing Ezsignsignature |
| [**EzsignsignatureEditObjectV3**](ObjectEzsignsignatureApi.md#ezsignsignatureeditobjectv3) | **PUT** /3/object/ezsignsignature/{pkiEzsignsignatureID} | Edit an existing Ezsignsignature |
| [**EzsignsignatureGetEzsignsignatureattachmentV1**](ObjectEzsignsignatureApi.md#ezsignsignaturegetezsignsignatureattachmentv1) | **GET** /1/object/ezsignsignature/{pkiEzsignsignatureID}/getEzsignsignatureattachment | Retrieve an existing Ezsignsignature&#39;s Ezsignsignatureattachments |
| [**EzsignsignatureGetEzsignsignaturesAutomaticV1**](ObjectEzsignsignatureApi.md#ezsignsignaturegetezsignsignaturesautomaticv1) | **GET** /1/object/ezsignsignature/getEzsignsignaturesAutomatic | Retrieve all automatic Ezsignsignatures |
| [**EzsignsignatureGetObjectV4**](ObjectEzsignsignatureApi.md#ezsignsignaturegetobjectv4) | **GET** /4/object/ezsignsignature/{pkiEzsignsignatureID} | Retrieve an existing Ezsignsignature |
| [**EzsignsignatureSignV1**](ObjectEzsignsignatureApi.md#ezsignsignaturesignv1) | **POST** /1/object/ezsignsignature/{pkiEzsignsignatureID}/sign | Sign the Ezsignsignature |

<a id="ezsignsignaturecreateobjectv1"></a>
# **EzsignsignatureCreateObjectV1**
> EzsignsignatureCreateObjectV1Response EzsignsignatureCreateObjectV1 (List<EzsignsignatureCreateObjectV1Request> ezsignsignatureCreateObjectV1Request)

Create a new Ezsignsignature

The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.  Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignsignatureCreateObjectV1Request** | [**List&lt;EzsignsignatureCreateObjectV1Request&gt;**](EzsignsignatureCreateObjectV1Request.md) |  |  |

### Return type

[**EzsignsignatureCreateObjectV1Response**](EzsignsignatureCreateObjectV1Response.md)

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

<a id="ezsignsignaturecreateobjectv2"></a>
# **EzsignsignatureCreateObjectV2**
> EzsignsignatureCreateObjectV2Response EzsignsignatureCreateObjectV2 (EzsignsignatureCreateObjectV2Request ezsignsignatureCreateObjectV2Request)

Create a new Ezsignsignature

The endpoint allows to create one or many elements at once.  Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignsignatureCreateObjectV2Request** | [**EzsignsignatureCreateObjectV2Request**](EzsignsignatureCreateObjectV2Request.md) |  |  |

### Return type

[**EzsignsignatureCreateObjectV2Response**](EzsignsignatureCreateObjectV2Response.md)

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

<a id="ezsignsignaturecreateobjectv3"></a>
# **EzsignsignatureCreateObjectV3**
> EzsignsignatureCreateObjectV3Response EzsignsignatureCreateObjectV3 (EzsignsignatureCreateObjectV3Request ezsignsignatureCreateObjectV3Request)

Create a new Ezsignsignature

The endpoint allows to create one or many elements at once.  Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignsignatureCreateObjectV3Request** | [**EzsignsignatureCreateObjectV3Request**](EzsignsignatureCreateObjectV3Request.md) |  |  |

### Return type

[**EzsignsignatureCreateObjectV3Response**](EzsignsignatureCreateObjectV3Response.md)

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

<a id="ezsignsignaturecreateobjectv4"></a>
# **EzsignsignatureCreateObjectV4**
> EzsignsignatureCreateObjectV4Response EzsignsignatureCreateObjectV4 (EzsignsignatureCreateObjectV4Request ezsignsignatureCreateObjectV4Request)

Create a new Ezsignsignature

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignsignatureCreateObjectV4Request** | [**EzsignsignatureCreateObjectV4Request**](EzsignsignatureCreateObjectV4Request.md) |  |  |

### Return type

[**EzsignsignatureCreateObjectV4Response**](EzsignsignatureCreateObjectV4Response.md)

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

<a id="ezsignsignaturedeleteobjectv1"></a>
# **EzsignsignatureDeleteObjectV1**
> EzsignsignatureDeleteObjectV1Response EzsignsignatureDeleteObjectV1 (int pkiEzsignsignatureID)

Delete an existing Ezsignsignature


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignsignatureID** | **int** |  |  |

### Return type

[**EzsignsignatureDeleteObjectV1Response**](EzsignsignatureDeleteObjectV1Response.md)

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

<a id="ezsignsignatureeditobjectv3"></a>
# **EzsignsignatureEditObjectV3**
> EzsignsignatureEditObjectV3Response EzsignsignatureEditObjectV3 (int pkiEzsignsignatureID, EzsignsignatureEditObjectV3Request ezsignsignatureEditObjectV3Request)

Edit an existing Ezsignsignature


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignsignatureID** | **int** |  |  |
| **ezsignsignatureEditObjectV3Request** | [**EzsignsignatureEditObjectV3Request**](EzsignsignatureEditObjectV3Request.md) |  |  |

### Return type

[**EzsignsignatureEditObjectV3Response**](EzsignsignatureEditObjectV3Response.md)

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

<a id="ezsignsignaturegetezsignsignatureattachmentv1"></a>
# **EzsignsignatureGetEzsignsignatureattachmentV1**
> EzsignsignatureGetEzsignsignatureattachmentV1Response EzsignsignatureGetEzsignsignatureattachmentV1 (int pkiEzsignsignatureID)

Retrieve an existing Ezsignsignature's Ezsignsignatureattachments


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignsignatureID** | **int** |  |  |

### Return type

[**EzsignsignatureGetEzsignsignatureattachmentV1Response**](EzsignsignatureGetEzsignsignatureattachmentV1Response.md)

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

<a id="ezsignsignaturegetezsignsignaturesautomaticv1"></a>
# **EzsignsignatureGetEzsignsignaturesAutomaticV1**
> EzsignsignatureGetEzsignsignaturesAutomaticV1Response EzsignsignatureGetEzsignsignaturesAutomaticV1 ()

Retrieve all automatic Ezsignsignatures

Return all the Ezsignsignatures that can be signed by the current user


### Parameters
This endpoint does not need any parameter.
### Return type

[**EzsignsignatureGetEzsignsignaturesAutomaticV1Response**](EzsignsignatureGetEzsignsignaturesAutomaticV1Response.md)

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

<a id="ezsignsignaturegetobjectv4"></a>
# **EzsignsignatureGetObjectV4**
> EzsignsignatureGetObjectV4Response EzsignsignatureGetObjectV4 (int pkiEzsignsignatureID)

Retrieve an existing Ezsignsignature


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignsignatureID** | **int** |  |  |

### Return type

[**EzsignsignatureGetObjectV4Response**](EzsignsignatureGetObjectV4Response.md)

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

<a id="ezsignsignaturesignv1"></a>
# **EzsignsignatureSignV1**
> EzsignsignatureSignV1Response EzsignsignatureSignV1 (int pkiEzsignsignatureID, EzsignsignatureSignV1Request ezsignsignatureSignV1Request)

Sign the Ezsignsignature


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignsignatureID** | **int** |  |  |
| **ezsignsignatureSignV1Request** | [**EzsignsignatureSignV1Request**](EzsignsignatureSignV1Request.md) |  |  |

### Return type

[**EzsignsignatureSignV1Response**](EzsignsignatureSignV1Response.md)

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


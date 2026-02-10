# eZmaxApi.Api.ObjectEzsignfoldersignerassociationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignfoldersignerassociationCreateEmbeddedUrlV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationcreateembeddedurlv1) | **POST** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID}/createEmbeddedUrl | Creates an Url to allow embedded signing |
| [**EzsignfoldersignerassociationCreateEmbeddedUrlV2**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationcreateembeddedurlv2) | **POST** /2/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID}/createEmbeddedUrl | Creates an Url to allow embedded signing |
| [**EzsignfoldersignerassociationCreateObjectV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationcreateobjectv1) | **POST** /1/object/ezsignfoldersignerassociation | Create a new Ezsignfoldersignerassociation |
| [**EzsignfoldersignerassociationCreateObjectV2**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationcreateobjectv2) | **POST** /2/object/ezsignfoldersignerassociation | Create a new Ezsignfoldersignerassociation |
| [**EzsignfoldersignerassociationDeleteObjectV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationdeleteobjectv1) | **DELETE** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID} | Delete an existing Ezsignfoldersignerassociation |
| [**EzsignfoldersignerassociationEditObjectV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationeditobjectv1) | **PUT** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID} | Edit an existing Ezsignfoldersignerassociation |
| [**EzsignfoldersignerassociationForceDisconnectV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationforcedisconnectv1) | **POST** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID}/forceDisconnect | Disconnects the Ezsignfoldersignerassociation |
| [**EzsignfoldersignerassociationGetInPersonLoginUrlV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationgetinpersonloginurlv1) | **GET** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID}/getInPersonLoginUrl | Retrieve a Login Url to allow In-Person signing |
| [**EzsignfoldersignerassociationGetObjectV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationgetobjectv1) | **GET** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID} | Retrieve an existing Ezsignfoldersignerassociation |
| [**EzsignfoldersignerassociationGetObjectV2**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationgetobjectv2) | **GET** /2/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID} | Retrieve an existing Ezsignfoldersignerassociation |
| [**EzsignfoldersignerassociationPatchObjectV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationpatchobjectv1) | **PATCH** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID} | Patch an existing Ezsignfoldersignerassociation |
| [**EzsignfoldersignerassociationReassignV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationreassignv1) | **POST** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID}/reassign | Reassign remaining unsigned signatures and forms |

<a id="ezsignfoldersignerassociationcreateembeddedurlv1"></a>
# **EzsignfoldersignerassociationCreateEmbeddedUrlV1**
> EzsignfoldersignerassociationCreateEmbeddedUrlV1Response EzsignfoldersignerassociationCreateEmbeddedUrlV1 (int pkiEzsignfoldersignerassociationID, EzsignfoldersignerassociationCreateEmbeddedUrlV1Request ezsignfoldersignerassociationCreateEmbeddedUrlV1Request)

Creates an Url to allow embedded signing

This endpoint creates an Url that can be used in a browser or embedded in an I-Frame to allow signing.  The signer Login type must be configured as Embedded.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldersignerassociationID** | **int** |  |  |
| **ezsignfoldersignerassociationCreateEmbeddedUrlV1Request** | [**EzsignfoldersignerassociationCreateEmbeddedUrlV1Request**](EzsignfoldersignerassociationCreateEmbeddedUrlV1Request.md) |  |  |

### Return type

[**EzsignfoldersignerassociationCreateEmbeddedUrlV1Response**](EzsignfoldersignerassociationCreateEmbeddedUrlV1Response.md)

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

<a id="ezsignfoldersignerassociationcreateembeddedurlv2"></a>
# **EzsignfoldersignerassociationCreateEmbeddedUrlV2**
> EzsignfoldersignerassociationCreateEmbeddedUrlV2Response EzsignfoldersignerassociationCreateEmbeddedUrlV2 (int pkiEzsignfoldersignerassociationID, EzsignfoldersignerassociationCreateEmbeddedUrlV2Request ezsignfoldersignerassociationCreateEmbeddedUrlV2Request)

Creates an Url to allow embedded signing

This endpoint creates an Url that can be used in a browser or embedded in an I-Frame to allow signing.  The signer Login type must be configured as Embedded.  ### Iframe Communication (postMessage)  If the signing page is embedded in an `iframe`, the application sends events to the parent window via `window.postMessage`.  The message structure is defined as follows:  ```json {   \"source\": \"ezsign\",   \"type\": \"eEzsignEvent\",   \"payload\": \"CompletedEzsignfolder\" } ```  * **source**: Always `'ezsign'`. * **type**: Always `'eEzsignEvent'`. * **payload**: Corresponds to the **eEzsignEvent** values listed in the table above (e.g., `SessionTimeout`, `CompletedStep`, etc.).  #### Example listener  ```javascript window.addEventListener('message', (event) => {     const { source, type, payload } = event.data;         if (source === 'ezsign' && type === 'eEzsignEvent') {         console.log('Event received:', payload);     } }); ``` 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldersignerassociationID** | **int** |  |  |
| **ezsignfoldersignerassociationCreateEmbeddedUrlV2Request** | [**EzsignfoldersignerassociationCreateEmbeddedUrlV2Request**](EzsignfoldersignerassociationCreateEmbeddedUrlV2Request.md) |  |  |

### Return type

[**EzsignfoldersignerassociationCreateEmbeddedUrlV2Response**](EzsignfoldersignerassociationCreateEmbeddedUrlV2Response.md)

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

<a id="ezsignfoldersignerassociationcreateobjectv1"></a>
# **EzsignfoldersignerassociationCreateObjectV1**
> EzsignfoldersignerassociationCreateObjectV1Response EzsignfoldersignerassociationCreateObjectV1 (List<EzsignfoldersignerassociationCreateObjectV1Request> ezsignfoldersignerassociationCreateObjectV1Request)

Create a new Ezsignfoldersignerassociation

The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignfoldersignerassociationCreateObjectV1Request** | [**List&lt;EzsignfoldersignerassociationCreateObjectV1Request&gt;**](EzsignfoldersignerassociationCreateObjectV1Request.md) |  |  |

### Return type

[**EzsignfoldersignerassociationCreateObjectV1Response**](EzsignfoldersignerassociationCreateObjectV1Response.md)

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

<a id="ezsignfoldersignerassociationcreateobjectv2"></a>
# **EzsignfoldersignerassociationCreateObjectV2**
> EzsignfoldersignerassociationCreateObjectV2Response EzsignfoldersignerassociationCreateObjectV2 (EzsignfoldersignerassociationCreateObjectV2Request ezsignfoldersignerassociationCreateObjectV2Request)

Create a new Ezsignfoldersignerassociation

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignfoldersignerassociationCreateObjectV2Request** | [**EzsignfoldersignerassociationCreateObjectV2Request**](EzsignfoldersignerassociationCreateObjectV2Request.md) |  |  |

### Return type

[**EzsignfoldersignerassociationCreateObjectV2Response**](EzsignfoldersignerassociationCreateObjectV2Response.md)

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

<a id="ezsignfoldersignerassociationdeleteobjectv1"></a>
# **EzsignfoldersignerassociationDeleteObjectV1**
> EzsignfoldersignerassociationDeleteObjectV1Response EzsignfoldersignerassociationDeleteObjectV1 (int pkiEzsignfoldersignerassociationID)

Delete an existing Ezsignfoldersignerassociation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldersignerassociationID** | **int** |  |  |

### Return type

[**EzsignfoldersignerassociationDeleteObjectV1Response**](EzsignfoldersignerassociationDeleteObjectV1Response.md)

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

<a id="ezsignfoldersignerassociationeditobjectv1"></a>
# **EzsignfoldersignerassociationEditObjectV1**
> EzsignfoldersignerassociationEditObjectV1Response EzsignfoldersignerassociationEditObjectV1 (int pkiEzsignfoldersignerassociationID, EzsignfoldersignerassociationEditObjectV1Request ezsignfoldersignerassociationEditObjectV1Request)

Edit an existing Ezsignfoldersignerassociation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldersignerassociationID** | **int** |  |  |
| **ezsignfoldersignerassociationEditObjectV1Request** | [**EzsignfoldersignerassociationEditObjectV1Request**](EzsignfoldersignerassociationEditObjectV1Request.md) |  |  |

### Return type

[**EzsignfoldersignerassociationEditObjectV1Response**](EzsignfoldersignerassociationEditObjectV1Response.md)

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

<a id="ezsignfoldersignerassociationforcedisconnectv1"></a>
# **EzsignfoldersignerassociationForceDisconnectV1**
> EzsignfoldersignerassociationForceDisconnectV1Response EzsignfoldersignerassociationForceDisconnectV1 (int pkiEzsignfoldersignerassociationID, Object body)

Disconnects the Ezsignfoldersignerassociation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldersignerassociationID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsignfoldersignerassociationForceDisconnectV1Response**](EzsignfoldersignerassociationForceDisconnectV1Response.md)

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

<a id="ezsignfoldersignerassociationgetinpersonloginurlv1"></a>
# **EzsignfoldersignerassociationGetInPersonLoginUrlV1**
> EzsignfoldersignerassociationGetInPersonLoginUrlV1Response EzsignfoldersignerassociationGetInPersonLoginUrlV1 (int pkiEzsignfoldersignerassociationID)

Retrieve a Login Url to allow In-Person signing

This endpoint returns a Login Url that can be used in a browser or embedded in an I-Frame to allow in person signing.  The signer Login type must be configured as In-Person.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldersignerassociationID** | **int** |  |  |

### Return type

[**EzsignfoldersignerassociationGetInPersonLoginUrlV1Response**](EzsignfoldersignerassociationGetInPersonLoginUrlV1Response.md)

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

<a id="ezsignfoldersignerassociationgetobjectv1"></a>
# **EzsignfoldersignerassociationGetObjectV1**
> EzsignfoldersignerassociationGetObjectV1Response EzsignfoldersignerassociationGetObjectV1 (int pkiEzsignfoldersignerassociationID)

Retrieve an existing Ezsignfoldersignerassociation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldersignerassociationID** | **int** |  |  |

### Return type

[**EzsignfoldersignerassociationGetObjectV1Response**](EzsignfoldersignerassociationGetObjectV1Response.md)

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

<a id="ezsignfoldersignerassociationgetobjectv2"></a>
# **EzsignfoldersignerassociationGetObjectV2**
> EzsignfoldersignerassociationGetObjectV2Response EzsignfoldersignerassociationGetObjectV2 (int pkiEzsignfoldersignerassociationID)

Retrieve an existing Ezsignfoldersignerassociation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldersignerassociationID** | **int** |  |  |

### Return type

[**EzsignfoldersignerassociationGetObjectV2Response**](EzsignfoldersignerassociationGetObjectV2Response.md)

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

<a id="ezsignfoldersignerassociationpatchobjectv1"></a>
# **EzsignfoldersignerassociationPatchObjectV1**
> EzsignfoldersignerassociationPatchObjectV1Response EzsignfoldersignerassociationPatchObjectV1 (int pkiEzsignfoldersignerassociationID, EzsignfoldersignerassociationPatchObjectV1Request ezsignfoldersignerassociationPatchObjectV1Request)

Patch an existing Ezsignfoldersignerassociation


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldersignerassociationID** | **int** |  |  |
| **ezsignfoldersignerassociationPatchObjectV1Request** | [**EzsignfoldersignerassociationPatchObjectV1Request**](EzsignfoldersignerassociationPatchObjectV1Request.md) |  |  |

### Return type

[**EzsignfoldersignerassociationPatchObjectV1Response**](EzsignfoldersignerassociationPatchObjectV1Response.md)

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

<a id="ezsignfoldersignerassociationreassignv1"></a>
# **EzsignfoldersignerassociationReassignV1**
> EzsignfoldersignerassociationReassignV1Response EzsignfoldersignerassociationReassignV1 (int pkiEzsignfoldersignerassociationID, EzsignfoldersignerassociationReassignV1Request ezsignfoldersignerassociationReassignV1Request)

Reassign remaining unsigned signatures and forms

Reassign remaining unsigned signatures and forms


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfoldersignerassociationID** | **int** |  |  |
| **ezsignfoldersignerassociationReassignV1Request** | [**EzsignfoldersignerassociationReassignV1Request**](EzsignfoldersignerassociationReassignV1Request.md) |  |  |

### Return type

[**EzsignfoldersignerassociationReassignV1Response**](EzsignfoldersignerassociationReassignV1Response.md)

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


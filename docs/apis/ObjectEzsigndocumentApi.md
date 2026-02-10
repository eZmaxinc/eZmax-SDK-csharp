# eZmaxApi.Api.ObjectEzsigndocumentApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigndocumentApplyEzsigntemplateV1**](ObjectEzsigndocumentApi.md#ezsigndocumentapplyezsigntemplatev1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/applyezsigntemplate | Apply an Ezsigntemplate to the Ezsigndocument |
| [**EzsigndocumentApplyEzsigntemplateV2**](ObjectEzsigndocumentApi.md#ezsigndocumentapplyezsigntemplatev2) | **POST** /2/object/ezsigndocument/{pkiEzsigndocumentID}/applyEzsigntemplate | Apply an Ezsigntemplate to the Ezsigndocument |
| [**EzsigndocumentApplyEzsigntemplateglobalV1**](ObjectEzsigndocumentApi.md#ezsigndocumentapplyezsigntemplateglobalv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/applyEzsigntemplateglobal | Apply an Ezsigntemplateglobal to the Ezsigndocument |
| [**EzsigndocumentCreateEzsignelementsPositionedByWordV1**](ObjectEzsigndocumentApi.md#ezsigndocumentcreateezsignelementspositionedbywordv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/createEzsignelementsPositionedByWord | Create multiple Ezsignsignatures/Ezsignformfieldgroups |
| [**EzsigndocumentCreateEzsignelementsPositionedByWordV2**](ObjectEzsigndocumentApi.md#ezsigndocumentcreateezsignelementspositionedbywordv2) | **POST** /2/object/ezsigndocument/{pkiEzsigndocumentID}/createEzsignelementsPositionedByWord | Create multiple Ezsignsignatures/Ezsignformfieldgroups |
| [**EzsigndocumentCreateObjectV1**](ObjectEzsigndocumentApi.md#ezsigndocumentcreateobjectv1) | **POST** /1/object/ezsigndocument | Create a new Ezsigndocument |
| [**EzsigndocumentCreateObjectV2**](ObjectEzsigndocumentApi.md#ezsigndocumentcreateobjectv2) | **POST** /2/object/ezsigndocument | Create a new Ezsigndocument |
| [**EzsigndocumentCreateObjectV3**](ObjectEzsigndocumentApi.md#ezsigndocumentcreateobjectv3) | **POST** /3/object/ezsigndocument | Create a new Ezsigndocument |
| [**EzsigndocumentDeclineToSignV1**](ObjectEzsigndocumentApi.md#ezsigndocumentdeclinetosignv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/declineToSign | Decline to sign |
| [**EzsigndocumentDeleteObjectV1**](ObjectEzsigndocumentApi.md#ezsigndocumentdeleteobjectv1) | **DELETE** /1/object/ezsigndocument/{pkiEzsigndocumentID} | Delete an existing Ezsigndocument |
| [**EzsigndocumentEditEzsignannotationsV1**](ObjectEzsigndocumentApi.md#ezsigndocumenteditezsignannotationsv1) | **PUT** /1/object/ezsigndocument/{pkiEzsigndocumentID}/editEzsignannotations | Edit multiple Ezsignannotations |
| [**EzsigndocumentEditEzsignformfieldgroupsV1**](ObjectEzsigndocumentApi.md#ezsigndocumenteditezsignformfieldgroupsv1) | **PUT** /1/object/ezsigndocument/{pkiEzsigndocumentID}/editEzsignformfieldgroups | Edit multiple Ezsignformfieldgroups |
| [**EzsigndocumentEditEzsignformfieldgroupsV2**](ObjectEzsigndocumentApi.md#ezsigndocumenteditezsignformfieldgroupsv2) | **PUT** /2/object/ezsigndocument/{pkiEzsigndocumentID}/editEzsignformfieldgroups | Edit multiple Ezsignformfieldgroups |
| [**EzsigndocumentEditEzsignsignaturesV1**](ObjectEzsigndocumentApi.md#ezsigndocumenteditezsignsignaturesv1) | **PUT** /1/object/ezsigndocument/{pkiEzsigndocumentID}/editEzsignsignatures | Edit multiple Ezsignsignatures |
| [**EzsigndocumentEditEzsignsignaturesV2**](ObjectEzsigndocumentApi.md#ezsigndocumenteditezsignsignaturesv2) | **PUT** /2/object/ezsigndocument/{pkiEzsigndocumentID}/editEzsignsignatures | Edit multiple Ezsignsignatures |
| [**EzsigndocumentEditObjectV1**](ObjectEzsigndocumentApi.md#ezsigndocumenteditobjectv1) | **PUT** /1/object/ezsigndocument/{pkiEzsigndocumentID} | Edit an existing Ezsigndocument |
| [**EzsigndocumentEndPrematurelyV1**](ObjectEzsigndocumentApi.md#ezsigndocumentendprematurelyv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/endPrematurely | End prematurely |
| [**EzsigndocumentExtractTextV1**](ObjectEzsigndocumentApi.md#ezsigndocumentextracttextv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/extractText | Extract text from Ezsigndocument area |
| [**EzsigndocumentFlattenV1**](ObjectEzsigndocumentApi.md#ezsigndocumentflattenv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/flatten | Flatten |
| [**EzsigndocumentGetActionableElementsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetactionableelementsv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getActionableElements | Retrieve actionable elements for the Ezsigndocument |
| [**EzsigndocumentGetActionableElementsV2**](ObjectEzsigndocumentApi.md#ezsigndocumentgetactionableelementsv2) | **GET** /2/object/ezsigndocument/{pkiEzsigndocumentID}/getActionableElements | Retrieve actionable elements for the Ezsigndocument |
| [**EzsigndocumentGetActionableElementsV3**](ObjectEzsigndocumentApi.md#ezsigndocumentgetactionableelementsv3) | **GET** /3/object/ezsigndocument/{pkiEzsigndocumentID}/getActionableElements | Retrieve actionable elements for the Ezsigndocument |
| [**EzsigndocumentGetAttachmentsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetattachmentsv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getAttachments | Retrieve Ezsigndocument&#39;s Attachments |
| [**EzsigndocumentGetCompletedElementsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetcompletedelementsv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getCompletedElements | Retrieve completed elements for the Ezsigndocument |
| [**EzsigndocumentGetCompletedElementsV2**](ObjectEzsigndocumentApi.md#ezsigndocumentgetcompletedelementsv2) | **GET** /2/object/ezsigndocument/{pkiEzsigndocumentID}/getCompletedElements | Retrieve completed elements for the Ezsigndocument |
| [**EzsigndocumentGetDownloadUrlV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetdownloadurlv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getDownloadUrl/{eDocumentType} | Retrieve a URL to download documents |
| [**EzsigndocumentGetEzsignannotationsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetezsignannotationsv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getEzsignannotations | Retrieve an existing Ezsigndocument&#39;s Ezsignannotations |
| [**EzsigndocumentGetEzsigndiscussionsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetezsigndiscussionsv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getEzsigndiscussions | Retrieve an existing Ezsigndocument&#39;s Ezsigndiscussions |
| [**EzsigndocumentGetEzsignformfieldgroupsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetezsignformfieldgroupsv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getEzsignformfieldgroups | Retrieve an existing Ezsigndocument&#39;s Ezsignformfieldgroups |
| [**EzsigndocumentGetEzsignpagesV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetezsignpagesv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getEzsignpages | Retrieve an existing Ezsigndocument&#39;s Ezsignpages |
| [**EzsigndocumentGetEzsignsignaturesAutomaticV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetezsignsignaturesautomaticv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getEzsignsignaturesAutomatic | Retrieve an existing Ezsigndocument&#39;s automatic Ezsignsignatures |
| [**EzsigndocumentGetEzsignsignaturesV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetezsignsignaturesv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getEzsignsignatures | Retrieve an existing Ezsigndocument&#39;s Ezsignsignatures |
| [**EzsigndocumentGetEzsignsignaturesV2**](ObjectEzsigndocumentApi.md#ezsigndocumentgetezsignsignaturesv2) | **GET** /2/object/ezsigndocument/{pkiEzsigndocumentID}/getEzsignsignatures | Retrieve an existing Ezsigndocument&#39;s Ezsignsignatures |
| [**EzsigndocumentGetFormDataV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetformdatav1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getFormData | Retrieve an existing Ezsigndocument&#39;s Form Data |
| [**EzsigndocumentGetObjectV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetobjectv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID} | Retrieve an existing Ezsigndocument |
| [**EzsigndocumentGetObjectV2**](ObjectEzsigndocumentApi.md#ezsigndocumentgetobjectv2) | **GET** /2/object/ezsigndocument/{pkiEzsigndocumentID} | Retrieve an existing Ezsigndocument |
| [**EzsigndocumentGetObjectV3**](ObjectEzsigndocumentApi.md#ezsigndocumentgetobjectv3) | **GET** /3/object/ezsigndocument/{pkiEzsigndocumentID} | Retrieve an existing Ezsigndocument |
| [**EzsigndocumentGetTemporaryProofV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgettemporaryproofv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getTemporaryProof | Retrieve the temporary proof |
| [**EzsigndocumentGetWordsPositionsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetwordspositionsv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getWordsPositions | Retrieve positions X,Y of given words from a Ezsigndocument |
| [**EzsigndocumentPatchObjectV1**](ObjectEzsigndocumentApi.md#ezsigndocumentpatchobjectv1) | **PATCH** /1/object/ezsigndocument/{pkiEzsigndocumentID} | Patch an existing Ezsigndocument |
| [**EzsigndocumentPrefillEzsignformV1**](ObjectEzsigndocumentApi.md#ezsigndocumentprefillezsignformv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/prefillEzsignform | Prefill an Ezsignform |
| [**EzsigndocumentSubmitEzsignformV1**](ObjectEzsigndocumentApi.md#ezsigndocumentsubmitezsignformv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/submitEzsignform | Submit the Ezsignform |
| [**EzsigndocumentUnsendV1**](ObjectEzsigndocumentApi.md#ezsigndocumentunsendv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/unsend | Unsend the Ezsigndocument |

<a id="ezsigndocumentapplyezsigntemplatev1"></a>
# **EzsigndocumentApplyEzsigntemplateV1**
> EzsigndocumentApplyEzsigntemplateV1Response EzsigndocumentApplyEzsigntemplateV1 (int pkiEzsigndocumentID, EzsigndocumentApplyEzsigntemplateV1Request ezsigndocumentApplyEzsigntemplateV1Request)

Apply an Ezsigntemplate to the Ezsigndocument

This function is deprecated. Please use *applyEzsigntemplate* instead which is doing the same thing but with a capital \"E\" to normalize the nomenclature.  This endpoint applies a predefined template to the ezsign document. This allows to automatically apply all the form and signature fields on a document in a single step.  The document must not already have fields otherwise an error will be returned.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentApplyEzsigntemplateV1Request** | [**EzsigndocumentApplyEzsigntemplateV1Request**](EzsigndocumentApplyEzsigntemplateV1Request.md) |  |  |

### Return type

[**EzsigndocumentApplyEzsigntemplateV1Response**](EzsigndocumentApplyEzsigntemplateV1Response.md)

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

<a id="ezsigndocumentapplyezsigntemplatev2"></a>
# **EzsigndocumentApplyEzsigntemplateV2**
> EzsigndocumentApplyEzsigntemplateV2Response EzsigndocumentApplyEzsigntemplateV2 (int pkiEzsigndocumentID, EzsigndocumentApplyEzsigntemplateV2Request ezsigndocumentApplyEzsigntemplateV2Request)

Apply an Ezsigntemplate to the Ezsigndocument

This endpoint applies a predefined template to the ezsign document. This allows to automatically apply all the form and signature fields on a document in a single step.  The document must not already have fields otherwise an error will be returned.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentApplyEzsigntemplateV2Request** | [**EzsigndocumentApplyEzsigntemplateV2Request**](EzsigndocumentApplyEzsigntemplateV2Request.md) |  |  |

### Return type

[**EzsigndocumentApplyEzsigntemplateV2Response**](EzsigndocumentApplyEzsigntemplateV2Response.md)

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

<a id="ezsigndocumentapplyezsigntemplateglobalv1"></a>
# **EzsigndocumentApplyEzsigntemplateglobalV1**
> EzsigndocumentApplyEzsigntemplateglobalV1Response EzsigndocumentApplyEzsigntemplateglobalV1 (int pkiEzsigndocumentID, EzsigndocumentApplyEzsigntemplateglobalV1Request ezsigndocumentApplyEzsigntemplateglobalV1Request)

Apply an Ezsigntemplateglobal to the Ezsigndocument

This endpoint applies a predefined template to the ezsign document. This allows to automatically apply all the form and signature fields on a document in a single step.  The document must not already have fields otherwise an error will be returned.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentApplyEzsigntemplateglobalV1Request** | [**EzsigndocumentApplyEzsigntemplateglobalV1Request**](EzsigndocumentApplyEzsigntemplateglobalV1Request.md) |  |  |

### Return type

[**EzsigndocumentApplyEzsigntemplateglobalV1Response**](EzsigndocumentApplyEzsigntemplateglobalV1Response.md)

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

<a id="ezsigndocumentcreateezsignelementspositionedbywordv1"></a>
# **EzsigndocumentCreateEzsignelementsPositionedByWordV1**
> EzsigndocumentCreateEzsignelementsPositionedByWordV1Response EzsigndocumentCreateEzsignelementsPositionedByWordV1 (int pkiEzsigndocumentID, EzsigndocumentCreateEzsignelementsPositionedByWordV1Request ezsigndocumentCreateEzsignelementsPositionedByWordV1Request)

Create multiple Ezsignsignatures/Ezsignformfieldgroups

Using this endpoint, you can create multiple Ezsignsignatures/Ezsignformfieldgroups positioned by word at the same time.  Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentCreateEzsignelementsPositionedByWordV1Request** | [**EzsigndocumentCreateEzsignelementsPositionedByWordV1Request**](EzsigndocumentCreateEzsignelementsPositionedByWordV1Request.md) |  |  |

### Return type

[**EzsigndocumentCreateEzsignelementsPositionedByWordV1Response**](EzsigndocumentCreateEzsignelementsPositionedByWordV1Response.md)

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

<a id="ezsigndocumentcreateezsignelementspositionedbywordv2"></a>
# **EzsigndocumentCreateEzsignelementsPositionedByWordV2**
> EzsigndocumentCreateEzsignelementsPositionedByWordV2Response EzsigndocumentCreateEzsignelementsPositionedByWordV2 (int pkiEzsigndocumentID, EzsigndocumentCreateEzsignelementsPositionedByWordV2Request ezsigndocumentCreateEzsignelementsPositionedByWordV2Request)

Create multiple Ezsignsignatures/Ezsignformfieldgroups

Using this endpoint, you can create multiple Ezsignsignatures/Ezsignformfieldgroups positioned by word at the same time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentCreateEzsignelementsPositionedByWordV2Request** | [**EzsigndocumentCreateEzsignelementsPositionedByWordV2Request**](EzsigndocumentCreateEzsignelementsPositionedByWordV2Request.md) |  |  |

### Return type

[**EzsigndocumentCreateEzsignelementsPositionedByWordV2Response**](EzsigndocumentCreateEzsignelementsPositionedByWordV2Response.md)

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

<a id="ezsigndocumentcreateobjectv1"></a>
# **EzsigndocumentCreateObjectV1**
> EzsigndocumentCreateObjectV1Response EzsigndocumentCreateObjectV1 (List<EzsigndocumentCreateObjectV1Request> ezsigndocumentCreateObjectV1Request)

Create a new Ezsigndocument

The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigndocumentCreateObjectV1Request** | [**List&lt;EzsigndocumentCreateObjectV1Request&gt;**](EzsigndocumentCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigndocumentCreateObjectV1Response**](EzsigndocumentCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **413** | The request was large. Look for detail about the error in the body |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. If the error is recoverable sTemporaryFileUrl will be set and you can use this url to try a new request without sending the file over again |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsigndocumentcreateobjectv2"></a>
# **EzsigndocumentCreateObjectV2**
> EzsigndocumentCreateObjectV2Response EzsigndocumentCreateObjectV2 (EzsigndocumentCreateObjectV2Request ezsigndocumentCreateObjectV2Request)

Create a new Ezsigndocument

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigndocumentCreateObjectV2Request** | [**EzsigndocumentCreateObjectV2Request**](EzsigndocumentCreateObjectV2Request.md) |  |  |

### Return type

[**EzsigndocumentCreateObjectV2Response**](EzsigndocumentCreateObjectV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. If the error is recoverable sTemporaryFileUrl will be set and you can use this url to try a new request without sending the file over again |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsigndocumentcreateobjectv3"></a>
# **EzsigndocumentCreateObjectV3**
> EzsigndocumentCreateObjectV3Response EzsigndocumentCreateObjectV3 (EzsigndocumentCreateObjectV3Request ezsigndocumentCreateObjectV3Request)

Create a new Ezsigndocument

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigndocumentCreateObjectV3Request** | [**EzsigndocumentCreateObjectV3Request**](EzsigndocumentCreateObjectV3Request.md) |  |  |

### Return type

[**EzsigndocumentCreateObjectV3Response**](EzsigndocumentCreateObjectV3Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. If the error is recoverable sTemporaryFileUrl will be set and you can use this url to try a new request without sending the file over again |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsigndocumentdeclinetosignv1"></a>
# **EzsigndocumentDeclineToSignV1**
> EzsigndocumentDeclineToSignV1Response EzsigndocumentDeclineToSignV1 (int pkiEzsigndocumentID, EzsigndocumentDeclineToSignV1Request ezsigndocumentDeclineToSignV1Request)

Decline to sign

Decline to sign


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentDeclineToSignV1Request** | [**EzsigndocumentDeclineToSignV1Request**](EzsigndocumentDeclineToSignV1Request.md) |  |  |

### Return type

[**EzsigndocumentDeclineToSignV1Response**](EzsigndocumentDeclineToSignV1Response.md)

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

<a id="ezsigndocumentdeleteobjectv1"></a>
# **EzsigndocumentDeleteObjectV1**
> EzsigndocumentDeleteObjectV1Response EzsigndocumentDeleteObjectV1 (int pkiEzsigndocumentID)

Delete an existing Ezsigndocument


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentDeleteObjectV1Response**](EzsigndocumentDeleteObjectV1Response.md)

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

<a id="ezsigndocumenteditezsignannotationsv1"></a>
# **EzsigndocumentEditEzsignannotationsV1**
> EzsigndocumentEditEzsignannotationsV1Response EzsigndocumentEditEzsignannotationsV1 (int pkiEzsigndocumentID, EzsigndocumentEditEzsignannotationsV1Request ezsigndocumentEditEzsignannotationsV1Request)

Edit multiple Ezsignannotations

Using this endpoint, you can edit multiple Ezsignannotations at the same time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentEditEzsignannotationsV1Request** | [**EzsigndocumentEditEzsignannotationsV1Request**](EzsigndocumentEditEzsignannotationsV1Request.md) |  |  |

### Return type

[**EzsigndocumentEditEzsignannotationsV1Response**](EzsigndocumentEditEzsignannotationsV1Response.md)

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

<a id="ezsigndocumenteditezsignformfieldgroupsv1"></a>
# **EzsigndocumentEditEzsignformfieldgroupsV1**
> EzsigndocumentEditEzsignformfieldgroupsV1Response EzsigndocumentEditEzsignformfieldgroupsV1 (int pkiEzsigndocumentID, EzsigndocumentEditEzsignformfieldgroupsV1Request ezsigndocumentEditEzsignformfieldgroupsV1Request)

Edit multiple Ezsignformfieldgroups

Using this endpoint, you can edit multiple Ezsignformfieldgroups at the same time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentEditEzsignformfieldgroupsV1Request** | [**EzsigndocumentEditEzsignformfieldgroupsV1Request**](EzsigndocumentEditEzsignformfieldgroupsV1Request.md) |  |  |

### Return type

[**EzsigndocumentEditEzsignformfieldgroupsV1Response**](EzsigndocumentEditEzsignformfieldgroupsV1Response.md)

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

<a id="ezsigndocumenteditezsignformfieldgroupsv2"></a>
# **EzsigndocumentEditEzsignformfieldgroupsV2**
> EzsigndocumentEditEzsignformfieldgroupsV2Response EzsigndocumentEditEzsignformfieldgroupsV2 (int pkiEzsigndocumentID, EzsigndocumentEditEzsignformfieldgroupsV2Request ezsigndocumentEditEzsignformfieldgroupsV2Request)

Edit multiple Ezsignformfieldgroups

Using this endpoint, you can edit multiple Ezsignformfieldgroups at the same time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentEditEzsignformfieldgroupsV2Request** | [**EzsigndocumentEditEzsignformfieldgroupsV2Request**](EzsigndocumentEditEzsignformfieldgroupsV2Request.md) |  |  |

### Return type

[**EzsigndocumentEditEzsignformfieldgroupsV2Response**](EzsigndocumentEditEzsignformfieldgroupsV2Response.md)

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

<a id="ezsigndocumenteditezsignsignaturesv1"></a>
# **EzsigndocumentEditEzsignsignaturesV1**
> EzsigndocumentEditEzsignsignaturesV1Response EzsigndocumentEditEzsignsignaturesV1 (int pkiEzsigndocumentID, EzsigndocumentEditEzsignsignaturesV1Request ezsigndocumentEditEzsignsignaturesV1Request)

Edit multiple Ezsignsignatures

Using this endpoint, you can edit multiple Ezsignsignatures at the same time.  Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentEditEzsignsignaturesV1Request** | [**EzsigndocumentEditEzsignsignaturesV1Request**](EzsigndocumentEditEzsignsignaturesV1Request.md) |  |  |

### Return type

[**EzsigndocumentEditEzsignsignaturesV1Response**](EzsigndocumentEditEzsignsignaturesV1Response.md)

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

<a id="ezsigndocumenteditezsignsignaturesv2"></a>
# **EzsigndocumentEditEzsignsignaturesV2**
> EzsigndocumentEditEzsignsignaturesV2Response EzsigndocumentEditEzsignsignaturesV2 (int pkiEzsigndocumentID, EzsigndocumentEditEzsignsignaturesV2Request ezsigndocumentEditEzsignsignaturesV2Request)

Edit multiple Ezsignsignatures

Using this endpoint, you can edit multiple Ezsignsignatures at the same time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentEditEzsignsignaturesV2Request** | [**EzsigndocumentEditEzsignsignaturesV2Request**](EzsigndocumentEditEzsignsignaturesV2Request.md) |  |  |

### Return type

[**EzsigndocumentEditEzsignsignaturesV2Response**](EzsigndocumentEditEzsignsignaturesV2Response.md)

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

<a id="ezsigndocumenteditobjectv1"></a>
# **EzsigndocumentEditObjectV1**
> EzsigndocumentEditObjectV1Response EzsigndocumentEditObjectV1 (int pkiEzsigndocumentID, EzsigndocumentEditObjectV1Request ezsigndocumentEditObjectV1Request)

Edit an existing Ezsigndocument


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentEditObjectV1Request** | [**EzsigndocumentEditObjectV1Request**](EzsigndocumentEditObjectV1Request.md) |  |  |

### Return type

[**EzsigndocumentEditObjectV1Response**](EzsigndocumentEditObjectV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. If the error is recoverable sTemporaryFileUrl will be set and you can use this url to try a new request without sending the file over again |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsigndocumentendprematurelyv1"></a>
# **EzsigndocumentEndPrematurelyV1**
> EzsigndocumentEndPrematurelyV1Response EzsigndocumentEndPrematurelyV1 (int pkiEzsigndocumentID, Object body)

End prematurely

End prematurely an Ezsigndocument when some signatures are still required


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsigndocumentEndPrematurelyV1Response**](EzsigndocumentEndPrematurelyV1Response.md)

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

<a id="ezsigndocumentextracttextv1"></a>
# **EzsigndocumentExtractTextV1**
> EzsigndocumentExtractTextV1Response EzsigndocumentExtractTextV1 (int pkiEzsigndocumentID, EzsigndocumentExtractTextV1Request ezsigndocumentExtractTextV1Request)

Extract text from Ezsigndocument area

Extract text from Ezsigndocument area


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentExtractTextV1Request** | [**EzsigndocumentExtractTextV1Request**](EzsigndocumentExtractTextV1Request.md) |  |  |

### Return type

[**EzsigndocumentExtractTextV1Response**](EzsigndocumentExtractTextV1Response.md)

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

<a id="ezsigndocumentflattenv1"></a>
# **EzsigndocumentFlattenV1**
> EzsigndocumentFlattenV1Response EzsigndocumentFlattenV1 (int pkiEzsigndocumentID, Object body)

Flatten

Flatten an Ezsigndocument signatures, forms and annotations. This process finalizes the PDF so that the forms and annotations become part of the document content and cannot be edited.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsigndocumentFlattenV1Response**](EzsigndocumentFlattenV1Response.md)

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

<a id="ezsigndocumentgetactionableelementsv1"></a>
# **EzsigndocumentGetActionableElementsV1**
> EzsigndocumentGetActionableElementsV1Response EzsigndocumentGetActionableElementsV1 (int pkiEzsigndocumentID)

Retrieve actionable elements for the Ezsigndocument

Return the Ezsignsignatures that can be signed and Ezsignformfieldgroups that can be filled by the current user at the current step in the process.  Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetActionableElementsV1Response**](EzsigndocumentGetActionableElementsV1Response.md)

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

<a id="ezsigndocumentgetactionableelementsv2"></a>
# **EzsigndocumentGetActionableElementsV2**
> EzsigndocumentGetActionableElementsV2Response EzsigndocumentGetActionableElementsV2 (int pkiEzsigndocumentID)

Retrieve actionable elements for the Ezsigndocument

Return the Ezsignsignatures that can be signed and Ezsignformfieldgroups that can be filled by the current user at the current step in the process


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetActionableElementsV2Response**](EzsigndocumentGetActionableElementsV2Response.md)

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

<a id="ezsigndocumentgetactionableelementsv3"></a>
# **EzsigndocumentGetActionableElementsV3**
> EzsigndocumentGetActionableElementsV3Response EzsigndocumentGetActionableElementsV3 (int pkiEzsigndocumentID)

Retrieve actionable elements for the Ezsigndocument

Return the Ezsignsignatures that can be signed and Ezsignformfieldgroups that can be filled by the current user at the current step in the process


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetActionableElementsV3Response**](EzsigndocumentGetActionableElementsV3Response.md)

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

<a id="ezsigndocumentgetattachmentsv1"></a>
# **EzsigndocumentGetAttachmentsV1**
> EzsigndocumentGetAttachmentsV1Response EzsigndocumentGetAttachmentsV1 (int pkiEzsigndocumentID)

Retrieve Ezsigndocument's Attachments


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetAttachmentsV1Response**](EzsigndocumentGetAttachmentsV1Response.md)

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

<a id="ezsigndocumentgetcompletedelementsv1"></a>
# **EzsigndocumentGetCompletedElementsV1**
> EzsigndocumentGetCompletedElementsV1Response EzsigndocumentGetCompletedElementsV1 (int pkiEzsigndocumentID)

Retrieve completed elements for the Ezsigndocument

Return the completed Ezsignsignatures, Ezsignformfieldgroups and Ezsignannotations at the current step in the process  Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetCompletedElementsV1Response**](EzsigndocumentGetCompletedElementsV1Response.md)

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

<a id="ezsigndocumentgetcompletedelementsv2"></a>
# **EzsigndocumentGetCompletedElementsV2**
> EzsigndocumentGetCompletedElementsV2Response EzsigndocumentGetCompletedElementsV2 (int pkiEzsigndocumentID)

Retrieve completed elements for the Ezsigndocument

Return the completed Ezsignsignatures, Ezsignformfieldgroups and Ezsignannotations at the current step in the process


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetCompletedElementsV2Response**](EzsigndocumentGetCompletedElementsV2Response.md)

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

<a id="ezsigndocumentgetdownloadurlv1"></a>
# **EzsigndocumentGetDownloadUrlV1**
> EzsigndocumentGetDownloadUrlV1Response EzsigndocumentGetDownloadUrlV1 (int pkiEzsigndocumentID, string eDocumentType)

Retrieve a URL to download documents

This endpoint returns URLs to different files that can be downloaded during the signing process.  These links will expire after 5 minutes so the download of the file should be made soon after retrieving the link.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **eDocumentType** | **string** | The type of document to retrieve.  1. **original** Is the original document before any repair or conversion were applied. **Initial** Is the initial document after initial signature were applied. 2. **SignatureReady** Is the version containing the annotations/form to show the signer. 3. **Signed** Is the final document once all signatures were applied in current document if eEzsignfolderCompletion is PerEzsigndocument.&lt;br&gt;     Is the final document once all signatures were applied in all documents if eEzsignfolderCompletion is PerEzsignfolder. 4. **Proofdocument** Is the evidence report. 5. **Proof** Is the complete evidence archive including all of the above and more.  |  |

### Return type

[**EzsigndocumentGetDownloadUrlV1Response**](EzsigndocumentGetDownloadUrlV1Response.md)

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

<a id="ezsigndocumentgetezsignannotationsv1"></a>
# **EzsigndocumentGetEzsignannotationsV1**
> EzsigndocumentGetEzsignannotationsV1Response EzsigndocumentGetEzsignannotationsV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's Ezsignannotations


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetEzsignannotationsV1Response**](EzsigndocumentGetEzsignannotationsV1Response.md)

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

<a id="ezsigndocumentgetezsigndiscussionsv1"></a>
# **EzsigndocumentGetEzsigndiscussionsV1**
> EzsigndocumentGetEzsigndiscussionsV1Response EzsigndocumentGetEzsigndiscussionsV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's Ezsigndiscussions


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetEzsigndiscussionsV1Response**](EzsigndocumentGetEzsigndiscussionsV1Response.md)

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

<a id="ezsigndocumentgetezsignformfieldgroupsv1"></a>
# **EzsigndocumentGetEzsignformfieldgroupsV1**
> EzsigndocumentGetEzsignformfieldgroupsV1Response EzsigndocumentGetEzsignformfieldgroupsV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's Ezsignformfieldgroups


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetEzsignformfieldgroupsV1Response**](EzsigndocumentGetEzsignformfieldgroupsV1Response.md)

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

<a id="ezsigndocumentgetezsignpagesv1"></a>
# **EzsigndocumentGetEzsignpagesV1**
> EzsigndocumentGetEzsignpagesV1Response EzsigndocumentGetEzsignpagesV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's Ezsignpages


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetEzsignpagesV1Response**](EzsigndocumentGetEzsignpagesV1Response.md)

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

<a id="ezsigndocumentgetezsignsignaturesautomaticv1"></a>
# **EzsigndocumentGetEzsignsignaturesAutomaticV1**
> EzsigndocumentGetEzsignsignaturesAutomaticV1Response EzsigndocumentGetEzsignsignaturesAutomaticV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's automatic Ezsignsignatures

Return the Ezsignsignatures that can be signed by the current user at the current step in the process


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetEzsignsignaturesAutomaticV1Response**](EzsigndocumentGetEzsignsignaturesAutomaticV1Response.md)

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

<a id="ezsigndocumentgetezsignsignaturesv1"></a>
# **EzsigndocumentGetEzsignsignaturesV1**
> EzsigndocumentGetEzsignsignaturesV1Response EzsigndocumentGetEzsignsignaturesV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's Ezsignsignatures

Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetEzsignsignaturesV1Response**](EzsigndocumentGetEzsignsignaturesV1Response.md)

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

<a id="ezsigndocumentgetezsignsignaturesv2"></a>
# **EzsigndocumentGetEzsignsignaturesV2**
> EzsigndocumentGetEzsignsignaturesV2Response EzsigndocumentGetEzsignsignaturesV2 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's Ezsignsignatures


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetEzsignsignaturesV2Response**](EzsigndocumentGetEzsignsignaturesV2Response.md)

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

<a id="ezsigndocumentgetformdatav1"></a>
# **EzsigndocumentGetFormDataV1**
> EzsigndocumentGetFormDataV1Response EzsigndocumentGetFormDataV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's Form Data


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetFormDataV1Response**](EzsigndocumentGetFormDataV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/zip, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsigndocumentgetobjectv1"></a>
# **EzsigndocumentGetObjectV1**
> EzsigndocumentGetObjectV1Response EzsigndocumentGetObjectV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument

Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetObjectV1Response**](EzsigndocumentGetObjectV1Response.md)

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

<a id="ezsigndocumentgetobjectv2"></a>
# **EzsigndocumentGetObjectV2**
> EzsigndocumentGetObjectV2Response EzsigndocumentGetObjectV2 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument

Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetObjectV2Response**](EzsigndocumentGetObjectV2Response.md)

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

<a id="ezsigndocumentgetobjectv3"></a>
# **EzsigndocumentGetObjectV3**
> EzsigndocumentGetObjectV3Response EzsigndocumentGetObjectV3 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetObjectV3Response**](EzsigndocumentGetObjectV3Response.md)

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

<a id="ezsigndocumentgettemporaryproofv1"></a>
# **EzsigndocumentGetTemporaryProofV1**
> EzsigndocumentGetTemporaryProofV1Response EzsigndocumentGetTemporaryProofV1 (int pkiEzsigndocumentID)

Retrieve the temporary proof

Retrieve the temporary proof while the Ezsigndocument is being processed since the proof isn't available until the Ezsigndocument is completed


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetTemporaryProofV1Response**](EzsigndocumentGetTemporaryProofV1Response.md)

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

<a id="ezsigndocumentgetwordspositionsv1"></a>
# **EzsigndocumentGetWordsPositionsV1**
> EzsigndocumentGetWordsPositionsV1Response EzsigndocumentGetWordsPositionsV1 (int pkiEzsigndocumentID, EzsigndocumentGetWordsPositionsV1Request ezsigndocumentGetWordsPositionsV1Request)

Retrieve positions X,Y of given words from a Ezsigndocument


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentGetWordsPositionsV1Request** | [**EzsigndocumentGetWordsPositionsV1Request**](EzsigndocumentGetWordsPositionsV1Request.md) |  |  |

### Return type

[**EzsigndocumentGetWordsPositionsV1Response**](EzsigndocumentGetWordsPositionsV1Response.md)

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

<a id="ezsigndocumentpatchobjectv1"></a>
# **EzsigndocumentPatchObjectV1**
> EzsigndocumentPatchObjectV1Response EzsigndocumentPatchObjectV1 (int pkiEzsigndocumentID, EzsigndocumentPatchObjectV1Request ezsigndocumentPatchObjectV1Request)

Patch an existing Ezsigndocument


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentPatchObjectV1Request** | [**EzsigndocumentPatchObjectV1Request**](EzsigndocumentPatchObjectV1Request.md) |  |  |

### Return type

[**EzsigndocumentPatchObjectV1Response**](EzsigndocumentPatchObjectV1Response.md)

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

<a id="ezsigndocumentprefillezsignformv1"></a>
# **EzsigndocumentPrefillEzsignformV1**
> EzsigndocumentPrefillEzsignformV1Response EzsigndocumentPrefillEzsignformV1 (int pkiEzsigndocumentID, EzsigndocumentPrefillEzsignformV1Request ezsigndocumentPrefillEzsignformV1Request)

Prefill an Ezsignform

Using this endpoint, you can prefill an Ezsignform.  To fill Ezsignformfield with type **Dropdown**, **Text**, **Textarea**, **Checkbox**, **Date**, **Number**, you must provide properties sEzsignformfieldgroupLabel and sEzsignformfieldLabel.  To fill Ezsignformfield with type **Radio**, you must provide only the property sEzsignformfieldgroupLabel.  In **PowerAutomate** if you need to add a line feed in sEzsignformfieldEnteredvalue, you should do it like this: concat('string1',decodeUriComponent('%0A'),'string2',decodeUriComponent('%0A'),'string3')


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentPrefillEzsignformV1Request** | [**EzsigndocumentPrefillEzsignformV1Request**](EzsigndocumentPrefillEzsignformV1Request.md) |  |  |

### Return type

[**EzsigndocumentPrefillEzsignformV1Response**](EzsigndocumentPrefillEzsignformV1Response.md)

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

<a id="ezsigndocumentsubmitezsignformv1"></a>
# **EzsigndocumentSubmitEzsignformV1**
> EzsigndocumentSubmitEzsignformV1Response EzsigndocumentSubmitEzsignformV1 (int pkiEzsigndocumentID, EzsigndocumentSubmitEzsignformV1Request ezsigndocumentSubmitEzsignformV1Request)

Submit the Ezsignform


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentSubmitEzsignformV1Request** | [**EzsigndocumentSubmitEzsignformV1Request**](EzsigndocumentSubmitEzsignformV1Request.md) |  |  |

### Return type

[**EzsigndocumentSubmitEzsignformV1Response**](EzsigndocumentSubmitEzsignformV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsigndocumentunsendv1"></a>
# **EzsigndocumentUnsendV1**
> EzsigndocumentUnsendV1Response EzsigndocumentUnsendV1 (int pkiEzsigndocumentID, Object body)

Unsend the Ezsigndocument

Once an Ezsigndocument has been sent to signatories, it cannot be modified.  Using this endpoint, you can unsend the Ezsigndocument and make it modifiable again.  Signatories will receive an email informing them the signature process was aborted and they might receive a new invitation to sign.  ⚠️ Warning: Any signature previously made by signatories on this Ezsigndocumentswill be lost.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsigndocumentUnsendV1Response**](EzsigndocumentUnsendV1Response.md)

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


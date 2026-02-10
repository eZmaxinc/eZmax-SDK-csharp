# eZmaxApi.Api.ObjectEzsignfolderApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignfolderArchiveV1**](ObjectEzsignfolderApi.md#ezsignfolderarchivev1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/archive | Archive the Ezsignfolder |
| [**EzsignfolderBatchDownloadV1**](ObjectEzsignfolderApi.md#ezsignfolderbatchdownloadv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/batchDownload | Download multiples files from an Ezsignfolder |
| [**EzsignfolderCreateObjectV1**](ObjectEzsignfolderApi.md#ezsignfoldercreateobjectv1) | **POST** /1/object/ezsignfolder | Create a new Ezsignfolder |
| [**EzsignfolderCreateObjectV2**](ObjectEzsignfolderApi.md#ezsignfoldercreateobjectv2) | **POST** /2/object/ezsignfolder | Create a new Ezsignfolder |
| [**EzsignfolderCreateObjectV3**](ObjectEzsignfolderApi.md#ezsignfoldercreateobjectv3) | **POST** /3/object/ezsignfolder | Create a new Ezsignfolder |
| [**EzsignfolderDeleteObjectV1**](ObjectEzsignfolderApi.md#ezsignfolderdeleteobjectv1) | **DELETE** /1/object/ezsignfolder/{pkiEzsignfolderID} | Delete an existing Ezsignfolder |
| [**EzsignfolderDisposeEzsignfoldersV1**](ObjectEzsignfolderApi.md#ezsignfolderdisposeezsignfoldersv1) | **POST** /1/object/ezsignfolder/disposeEzsignfolders | Dispose Ezsignfolders |
| [**EzsignfolderDisposeV1**](ObjectEzsignfolderApi.md#ezsignfolderdisposev1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/dispose | Dispose the Ezsignfolder |
| [**EzsignfolderEditObjectV3**](ObjectEzsignfolderApi.md#ezsignfoldereditobjectv3) | **PUT** /3/object/ezsignfolder/{pkiEzsignfolderID} | Edit an existing Ezsignfolder |
| [**EzsignfolderEndPrematurelyV1**](ObjectEzsignfolderApi.md#ezsignfolderendprematurelyv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/endPrematurely | End prematurely |
| [**EzsignfolderGetActionableElementsV1**](ObjectEzsignfolderApi.md#ezsignfoldergetactionableelementsv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getActionableElements | Retrieve actionable elements for the Ezsignfolder |
| [**EzsignfolderGetActionableElementsV2**](ObjectEzsignfolderApi.md#ezsignfoldergetactionableelementsv2) | **GET** /2/object/ezsignfolder/{pkiEzsignfolderID}/getActionableElements | Retrieve actionable elements for the Ezsignfolder |
| [**EzsignfolderGetActionableElementsV3**](ObjectEzsignfolderApi.md#ezsignfoldergetactionableelementsv3) | **GET** /3/object/ezsignfolder/{pkiEzsignfolderID}/getActionableElements | Retrieve actionable elements for the Ezsignfolder |
| [**EzsignfolderGetAttachmentCountV1**](ObjectEzsignfolderApi.md#ezsignfoldergetattachmentcountv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getAttachmentCount | Retrieve Attachment count |
| [**EzsignfolderGetAttachmentsV1**](ObjectEzsignfolderApi.md#ezsignfoldergetattachmentsv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getAttachments | Retrieve Ezsignfolder&#39;s Attachments |
| [**EzsignfolderGetCommunicationCountV1**](ObjectEzsignfolderApi.md#ezsignfoldergetcommunicationcountv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getCommunicationCount | Retrieve Communication count |
| [**EzsignfolderGetCommunicationListV1**](ObjectEzsignfolderApi.md#ezsignfoldergetcommunicationlistv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getCommunicationList | Retrieve Communication list |
| [**EzsignfolderGetCommunicationrecipientsV1**](ObjectEzsignfolderApi.md#ezsignfoldergetcommunicationrecipientsv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getCommunicationrecipients | Retrieve Ezsignfolder&#39;s Communicationrecipient |
| [**EzsignfolderGetCommunicationsendersV1**](ObjectEzsignfolderApi.md#ezsignfoldergetcommunicationsendersv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getCommunicationsenders | Retrieve Ezsignfolder&#39;s Communicationsender |
| [**EzsignfolderGetEzsigndocumentsV1**](ObjectEzsignfolderApi.md#ezsignfoldergetezsigndocumentsv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getEzsigndocuments | Retrieve an existing Ezsignfolder&#39;s Ezsigndocuments |
| [**EzsignfolderGetEzsigndocumentsV2**](ObjectEzsignfolderApi.md#ezsignfoldergetezsigndocumentsv2) | **GET** /2/object/ezsignfolder/{pkiEzsignfolderID}/getEzsigndocuments | Retrieve an existing Ezsignfolder&#39;s Ezsigndocuments |
| [**EzsignfolderGetEzsignfoldersignerassociationsV1**](ObjectEzsignfolderApi.md#ezsignfoldergetezsignfoldersignerassociationsv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getEzsignfoldersignerassociations | Retrieve an existing Ezsignfolder&#39;s Ezsignfoldersignerassociations |
| [**EzsignfolderGetEzsignsignaturesAutomaticV1**](ObjectEzsignfolderApi.md#ezsignfoldergetezsignsignaturesautomaticv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getEzsignsignaturesAutomatic | Retrieve an existing Ezsignfolder&#39;s automatic Ezsignsignatures |
| [**EzsignfolderGetFormsDataV1**](ObjectEzsignfolderApi.md#ezsignfoldergetformsdatav1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getFormsData | Retrieve an existing Ezsignfolder&#39;s forms data |
| [**EzsignfolderGetListV1**](ObjectEzsignfolderApi.md#ezsignfoldergetlistv1) | **GET** /1/object/ezsignfolder/getList | Retrieve Ezsignfolder list |
| [**EzsignfolderGetObjectV1**](ObjectEzsignfolderApi.md#ezsignfoldergetobjectv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID} | Retrieve an existing Ezsignfolder |
| [**EzsignfolderGetObjectV2**](ObjectEzsignfolderApi.md#ezsignfoldergetobjectv2) | **GET** /2/object/ezsignfolder/{pkiEzsignfolderID} | Retrieve an existing Ezsignfolder |
| [**EzsignfolderGetObjectV3**](ObjectEzsignfolderApi.md#ezsignfoldergetobjectv3) | **GET** /3/object/ezsignfolder/{pkiEzsignfolderID} | Retrieve an existing Ezsignfolder |
| [**EzsignfolderImportEzsignfoldersignerassociationsV1**](ObjectEzsignfolderApi.md#ezsignfolderimportezsignfoldersignerassociationsv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/importEzsignfoldersignerassociations | Import an existing Ezsignfoldersignerassociation into this Ezsignfolder |
| [**EzsignfolderImportEzsigntemplatepackageV1**](ObjectEzsignfolderApi.md#ezsignfolderimportezsigntemplatepackagev1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/importEzsigntemplatepackage | Import an Ezsigntemplatepackage in the Ezsignfolder |
| [**EzsignfolderImportEzsigntemplatepackageV2**](ObjectEzsignfolderApi.md#ezsignfolderimportezsigntemplatepackagev2) | **POST** /2/object/ezsignfolder/{pkiEzsignfolderID}/importEzsigntemplatepackage | Import an Ezsigntemplatepackage in the Ezsignfolder |
| [**EzsignfolderReorderV2**](ObjectEzsignfolderApi.md#ezsignfolderreorderv2) | **POST** /2/object/ezsignfolder/{pkiEzsignfolderID}/reorder | Reorder Ezsigndocuments in the Ezsignfolder |
| [**EzsignfolderSendV1**](ObjectEzsignfolderApi.md#ezsignfoldersendv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/send | Send the Ezsignfolder to the signatories for signature |
| [**EzsignfolderSendV3**](ObjectEzsignfolderApi.md#ezsignfoldersendv3) | **POST** /3/object/ezsignfolder/{pkiEzsignfolderID}/send | Send the Ezsignfolder to the signatories for signature |
| [**EzsignfolderUnsendV1**](ObjectEzsignfolderApi.md#ezsignfolderunsendv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/unsend | Unsend the Ezsignfolder |

<a id="ezsignfolderarchivev1"></a>
# **EzsignfolderArchiveV1**
> EzsignfolderArchiveV1Response EzsignfolderArchiveV1 (int pkiEzsignfolderID, Object body)

Archive the Ezsignfolder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsignfolderArchiveV1Response**](EzsignfolderArchiveV1Response.md)

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

<a id="ezsignfolderbatchdownloadv1"></a>
# **EzsignfolderBatchDownloadV1**
> System.IO.Stream EzsignfolderBatchDownloadV1 (int pkiEzsignfolderID, EzsignfolderBatchDownloadV1Request ezsignfolderBatchDownloadV1Request, string accept = null)

Download multiples files from an Ezsignfolder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderBatchDownloadV1Request** | [**EzsignfolderBatchDownloadV1Request**](EzsignfolderBatchDownloadV1Request.md) |  |  |
| **accept** | **string** | Test csharp | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/zip, application/pdf, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsignfoldercreateobjectv1"></a>
# **EzsignfolderCreateObjectV1**
> EzsignfolderCreateObjectV1Response EzsignfolderCreateObjectV1 (List<EzsignfolderCreateObjectV1Request> ezsignfolderCreateObjectV1Request)

Create a new Ezsignfolder

The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignfolderCreateObjectV1Request** | [**List&lt;EzsignfolderCreateObjectV1Request&gt;**](EzsignfolderCreateObjectV1Request.md) |  |  |

### Return type

[**EzsignfolderCreateObjectV1Response**](EzsignfolderCreateObjectV1Response.md)

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

<a id="ezsignfoldercreateobjectv2"></a>
# **EzsignfolderCreateObjectV2**
> EzsignfolderCreateObjectV2Response EzsignfolderCreateObjectV2 (EzsignfolderCreateObjectV2Request ezsignfolderCreateObjectV2Request)

Create a new Ezsignfolder

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignfolderCreateObjectV2Request** | [**EzsignfolderCreateObjectV2Request**](EzsignfolderCreateObjectV2Request.md) |  |  |

### Return type

[**EzsignfolderCreateObjectV2Response**](EzsignfolderCreateObjectV2Response.md)

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

<a id="ezsignfoldercreateobjectv3"></a>
# **EzsignfolderCreateObjectV3**
> EzsignfolderCreateObjectV3Response EzsignfolderCreateObjectV3 (EzsignfolderCreateObjectV3Request ezsignfolderCreateObjectV3Request)

Create a new Ezsignfolder

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignfolderCreateObjectV3Request** | [**EzsignfolderCreateObjectV3Request**](EzsignfolderCreateObjectV3Request.md) |  |  |

### Return type

[**EzsignfolderCreateObjectV3Response**](EzsignfolderCreateObjectV3Response.md)

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

<a id="ezsignfolderdeleteobjectv1"></a>
# **EzsignfolderDeleteObjectV1**
> EzsignfolderDeleteObjectV1Response EzsignfolderDeleteObjectV1 (int pkiEzsignfolderID)

Delete an existing Ezsignfolder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderDeleteObjectV1Response**](EzsignfolderDeleteObjectV1Response.md)

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

<a id="ezsignfolderdisposeezsignfoldersv1"></a>
# **EzsignfolderDisposeEzsignfoldersV1**
> EzsignfolderDisposeEzsignfoldersV1Response EzsignfolderDisposeEzsignfoldersV1 (EzsignfolderDisposeEzsignfoldersV1Request ezsignfolderDisposeEzsignfoldersV1Request)

Dispose Ezsignfolders


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignfolderDisposeEzsignfoldersV1Request** | [**EzsignfolderDisposeEzsignfoldersV1Request**](EzsignfolderDisposeEzsignfoldersV1Request.md) |  |  |

### Return type

[**EzsignfolderDisposeEzsignfoldersV1Response**](EzsignfolderDisposeEzsignfoldersV1Response.md)

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

<a id="ezsignfolderdisposev1"></a>
# **EzsignfolderDisposeV1**
> EzsignfolderDisposeV1Response EzsignfolderDisposeV1 (int pkiEzsignfolderID, Object body)

Dispose the Ezsignfolder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsignfolderDisposeV1Response**](EzsignfolderDisposeV1Response.md)

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

<a id="ezsignfoldereditobjectv3"></a>
# **EzsignfolderEditObjectV3**
> EzsignfolderEditObjectV3Response EzsignfolderEditObjectV3 (int pkiEzsignfolderID, EzsignfolderEditObjectV3Request ezsignfolderEditObjectV3Request)

Edit an existing Ezsignfolder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderEditObjectV3Request** | [**EzsignfolderEditObjectV3Request**](EzsignfolderEditObjectV3Request.md) |  |  |

### Return type

[**EzsignfolderEditObjectV3Response**](EzsignfolderEditObjectV3Response.md)

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

<a id="ezsignfolderendprematurelyv1"></a>
# **EzsignfolderEndPrematurelyV1**
> EzsignfolderEndPrematurelyV1Response EzsignfolderEndPrematurelyV1 (int pkiEzsignfolderID, Object body)

End prematurely

End prematurely all Ezsigndocument of Ezsignfolder when some signatures are still required


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsignfolderEndPrematurelyV1Response**](EzsignfolderEndPrematurelyV1Response.md)

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

<a id="ezsignfoldergetactionableelementsv1"></a>
# **EzsignfolderGetActionableElementsV1**
> EzsignfolderGetActionableElementsV1Response EzsignfolderGetActionableElementsV1 (int pkiEzsignfolderID)

Retrieve actionable elements for the Ezsignfolder

Return the Ezsignsignatures that can be signed and Ezsignformfieldgroups that can be filled by the current user at the current step in the process.    Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetActionableElementsV1Response**](EzsignfolderGetActionableElementsV1Response.md)

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

<a id="ezsignfoldergetactionableelementsv2"></a>
# **EzsignfolderGetActionableElementsV2**
> EzsignfolderGetActionableElementsV2Response EzsignfolderGetActionableElementsV2 (int pkiEzsignfolderID)

Retrieve actionable elements for the Ezsignfolder

Return the Ezsignsignatures that can be signed and Ezsignformfieldgroups that can be filled by the current user at the current step in the process


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetActionableElementsV2Response**](EzsignfolderGetActionableElementsV2Response.md)

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

<a id="ezsignfoldergetactionableelementsv3"></a>
# **EzsignfolderGetActionableElementsV3**
> EzsignfolderGetActionableElementsV3Response EzsignfolderGetActionableElementsV3 (int pkiEzsignfolderID)

Retrieve actionable elements for the Ezsignfolder

Return the Ezsignsignatures that can be signed and Ezsignformfieldgroups that can be filled by the current user at the current step in the process


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetActionableElementsV3Response**](EzsignfolderGetActionableElementsV3Response.md)

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

<a id="ezsignfoldergetattachmentcountv1"></a>
# **EzsignfolderGetAttachmentCountV1**
> EzsignfolderGetAttachmentCountV1Response EzsignfolderGetAttachmentCountV1 (int pkiEzsignfolderID)

Retrieve Attachment count


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetAttachmentCountV1Response**](EzsignfolderGetAttachmentCountV1Response.md)

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

<a id="ezsignfoldergetattachmentsv1"></a>
# **EzsignfolderGetAttachmentsV1**
> EzsignfolderGetAttachmentsV1Response EzsignfolderGetAttachmentsV1 (int pkiEzsignfolderID)

Retrieve Ezsignfolder's Attachments


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetAttachmentsV1Response**](EzsignfolderGetAttachmentsV1Response.md)

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

<a id="ezsignfoldergetcommunicationcountv1"></a>
# **EzsignfolderGetCommunicationCountV1**
> EzsignfolderGetCommunicationCountV1Response EzsignfolderGetCommunicationCountV1 (int pkiEzsignfolderID)

Retrieve Communication count


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetCommunicationCountV1Response**](EzsignfolderGetCommunicationCountV1Response.md)

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

<a id="ezsignfoldergetcommunicationlistv1"></a>
# **EzsignfolderGetCommunicationListV1**
> EzsignfolderGetCommunicationListV1Response EzsignfolderGetCommunicationListV1 (int pkiEzsignfolderID)

Retrieve Communication list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetCommunicationListV1Response**](EzsignfolderGetCommunicationListV1Response.md)

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

<a id="ezsignfoldergetcommunicationrecipientsv1"></a>
# **EzsignfolderGetCommunicationrecipientsV1**
> EzsignfolderGetCommunicationrecipientsV1Response EzsignfolderGetCommunicationrecipientsV1 (int pkiEzsignfolderID)

Retrieve Ezsignfolder's Communicationrecipient


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetCommunicationrecipientsV1Response**](EzsignfolderGetCommunicationrecipientsV1Response.md)

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

<a id="ezsignfoldergetcommunicationsendersv1"></a>
# **EzsignfolderGetCommunicationsendersV1**
> EzsignfolderGetCommunicationsendersV1Response EzsignfolderGetCommunicationsendersV1 (int pkiEzsignfolderID)

Retrieve Ezsignfolder's Communicationsender


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetCommunicationsendersV1Response**](EzsignfolderGetCommunicationsendersV1Response.md)

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

<a id="ezsignfoldergetezsigndocumentsv1"></a>
# **EzsignfolderGetEzsigndocumentsV1**
> EzsignfolderGetEzsigndocumentsV1Response EzsignfolderGetEzsigndocumentsV1 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder's Ezsigndocuments

Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetEzsigndocumentsV1Response**](EzsignfolderGetEzsigndocumentsV1Response.md)

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

<a id="ezsignfoldergetezsigndocumentsv2"></a>
# **EzsignfolderGetEzsigndocumentsV2**
> EzsignfolderGetEzsigndocumentsV2Response EzsignfolderGetEzsigndocumentsV2 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder's Ezsigndocuments


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetEzsigndocumentsV2Response**](EzsignfolderGetEzsigndocumentsV2Response.md)

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

<a id="ezsignfoldergetezsignfoldersignerassociationsv1"></a>
# **EzsignfolderGetEzsignfoldersignerassociationsV1**
> EzsignfolderGetEzsignfoldersignerassociationsV1Response EzsignfolderGetEzsignfoldersignerassociationsV1 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder's Ezsignfoldersignerassociations


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetEzsignfoldersignerassociationsV1Response**](EzsignfolderGetEzsignfoldersignerassociationsV1Response.md)

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

<a id="ezsignfoldergetezsignsignaturesautomaticv1"></a>
# **EzsignfolderGetEzsignsignaturesAutomaticV1**
> EzsignfolderGetEzsignsignaturesAutomaticV1Response EzsignfolderGetEzsignsignaturesAutomaticV1 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder's automatic Ezsignsignatures

Return the Ezsignsignatures that can be signed by the current user at the current step in the process


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetEzsignsignaturesAutomaticV1Response**](EzsignfolderGetEzsignsignaturesAutomaticV1Response.md)

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

<a id="ezsignfoldergetformsdatav1"></a>
# **EzsignfolderGetFormsDataV1**
> EzsignfolderGetFormsDataV1Response EzsignfolderGetFormsDataV1 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder's forms data


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetFormsDataV1Response**](EzsignfolderGetFormsDataV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/zip


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsignfoldergetlistv1"></a>
# **EzsignfolderGetListV1**
> EzsignfolderGetListV1Response EzsignfolderGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Ezsignfolder list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eEzsignfolderStep | Unsent<br>Sent<br>PartiallySigned<br>Expired<br>Completed<br>Archived<br>Disposed| | eEzsignfoldertypePrivacylevel | User<br>Usergroup |  Advanced filters that can be used in query parameter *sFilter*:  | Variable | |- --| | fkiUserID | | sContactFirstname | | sContactLastname | | sUserFirstname | | sUserLastname | | sEzsigndocumentName |


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**EzsignfolderGetListV1Response**](EzsignfolderGetListV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsignfoldergetobjectv1"></a>
# **EzsignfolderGetObjectV1**
> EzsignfolderGetObjectV1Response EzsignfolderGetObjectV1 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetObjectV1Response**](EzsignfolderGetObjectV1Response.md)

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

<a id="ezsignfoldergetobjectv2"></a>
# **EzsignfolderGetObjectV2**
> EzsignfolderGetObjectV2Response EzsignfolderGetObjectV2 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetObjectV2Response**](EzsignfolderGetObjectV2Response.md)

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

<a id="ezsignfoldergetobjectv3"></a>
# **EzsignfolderGetObjectV3**
> EzsignfolderGetObjectV3Response EzsignfolderGetObjectV3 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetObjectV3Response**](EzsignfolderGetObjectV3Response.md)

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

<a id="ezsignfolderimportezsignfoldersignerassociationsv1"></a>
# **EzsignfolderImportEzsignfoldersignerassociationsV1**
> EzsignfolderImportEzsignfoldersignerassociationsV1Response EzsignfolderImportEzsignfoldersignerassociationsV1 (int pkiEzsignfolderID, EzsignfolderImportEzsignfoldersignerassociationsV1Request ezsignfolderImportEzsignfoldersignerassociationsV1Request)

Import an existing Ezsignfoldersignerassociation into this Ezsignfolder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderImportEzsignfoldersignerassociationsV1Request** | [**EzsignfolderImportEzsignfoldersignerassociationsV1Request**](EzsignfolderImportEzsignfoldersignerassociationsV1Request.md) |  |  |

### Return type

[**EzsignfolderImportEzsignfoldersignerassociationsV1Response**](EzsignfolderImportEzsignfoldersignerassociationsV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **403** | The request is not allowed to be executed. Look for detail about the error in the body |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsignfolderimportezsigntemplatepackagev1"></a>
# **EzsignfolderImportEzsigntemplatepackageV1**
> EzsignfolderImportEzsigntemplatepackageV1Response EzsignfolderImportEzsigntemplatepackageV1 (int pkiEzsignfolderID, EzsignfolderImportEzsigntemplatepackageV1Request ezsignfolderImportEzsigntemplatepackageV1Request)

Import an Ezsigntemplatepackage in the Ezsignfolder

This endpoint imports all of the Ezsigntemplates from the Ezsigntemplatepackage into the Ezsignfolder as Ezsigndocuments.  This allows to automatically apply all the Ezsigntemplateformfieldgroups and Ezsigntemplatesignatures on the newly created Ezsigndocuments in a single step.  Major step overhaul.  Endpoints that existed before version 1.3 do not allow you to combine forms and signatures in the same step. The step numbers are different from those indicated by endpoints added since version 1.3. This endpoint is compatible with endpoints that existed before 1.3 but are not compatible with those added since 1.3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderImportEzsigntemplatepackageV1Request** | [**EzsignfolderImportEzsigntemplatepackageV1Request**](EzsignfolderImportEzsigntemplatepackageV1Request.md) |  |  |

### Return type

[**EzsignfolderImportEzsigntemplatepackageV1Response**](EzsignfolderImportEzsigntemplatepackageV1Response.md)

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

<a id="ezsignfolderimportezsigntemplatepackagev2"></a>
# **EzsignfolderImportEzsigntemplatepackageV2**
> EzsignfolderImportEzsigntemplatepackageV2Response EzsignfolderImportEzsigntemplatepackageV2 (int pkiEzsignfolderID, EzsignfolderImportEzsigntemplatepackageV2Request ezsignfolderImportEzsigntemplatepackageV2Request)

Import an Ezsigntemplatepackage in the Ezsignfolder

This endpoint imports all of the Ezsigntemplates from the Ezsigntemplatepackage into the Ezsignfolder as Ezsigndocuments.  This allows to automatically apply all the Ezsigntemplateformfieldgroups and Ezsigntemplatesignatures on the newly created Ezsigndocuments in a single step.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderImportEzsigntemplatepackageV2Request** | [**EzsignfolderImportEzsigntemplatepackageV2Request**](EzsignfolderImportEzsigntemplatepackageV2Request.md) |  |  |

### Return type

[**EzsignfolderImportEzsigntemplatepackageV2Response**](EzsignfolderImportEzsigntemplatepackageV2Response.md)

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

<a id="ezsignfolderreorderv2"></a>
# **EzsignfolderReorderV2**
> EzsignfolderReorderV2Response EzsignfolderReorderV2 (int pkiEzsignfolderID, EzsignfolderReorderV2Request ezsignfolderReorderV2Request)

Reorder Ezsigndocuments in the Ezsignfolder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderReorderV2Request** | [**EzsignfolderReorderV2Request**](EzsignfolderReorderV2Request.md) |  |  |

### Return type

[**EzsignfolderReorderV2Response**](EzsignfolderReorderV2Response.md)

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

<a id="ezsignfoldersendv1"></a>
# **EzsignfolderSendV1**
> EzsignfolderSendV1Response EzsignfolderSendV1 (int pkiEzsignfolderID, EzsignfolderSendV1Request ezsignfolderSendV1Request)

Send the Ezsignfolder to the signatories for signature


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderSendV1Request** | [**EzsignfolderSendV1Request**](EzsignfolderSendV1Request.md) |  |  |

### Return type

[**EzsignfolderSendV1Response**](EzsignfolderSendV1Response.md)

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

<a id="ezsignfoldersendv3"></a>
# **EzsignfolderSendV3**
> EzsignfolderSendV3Response EzsignfolderSendV3 (int pkiEzsignfolderID, EzsignfolderSendV3Request ezsignfolderSendV3Request)

Send the Ezsignfolder to the signatories for signature


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderSendV3Request** | [**EzsignfolderSendV3Request**](EzsignfolderSendV3Request.md) |  |  |

### Return type

[**EzsignfolderSendV3Response**](EzsignfolderSendV3Response.md)

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

<a id="ezsignfolderunsendv1"></a>
# **EzsignfolderUnsendV1**
> EzsignfolderUnsendV1Response EzsignfolderUnsendV1 (int pkiEzsignfolderID, Object body)

Unsend the Ezsignfolder

Once an Ezsignfolder has been sent to signatories, it cannot be modified.  Using this endpoint, you can unsend the Ezsignfolder and make it modifiable again.  Signatories will receive an email informing them the signature process was aborted and they might receive a new invitation to sign.  ⚠️ Warning: Any signature previously made by signatories on \"Non-completed\" Ezsigndocuments will be lost.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsignfolderUnsendV1Response**](EzsignfolderUnsendV1Response.md)

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


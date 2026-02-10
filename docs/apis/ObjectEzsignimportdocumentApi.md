# eZmaxApi.Api.ObjectEzsignimportdocumentApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignimportdocumentDownloadV1**](ObjectEzsignimportdocumentApi.md#ezsignimportdocumentdownloadv1) | **GET** /1/object/ezsignimportdocument/{pkiEzsignimportdocumentID}/download | Retrieve the content |

<a id="ezsignimportdocumentdownloadv1"></a>
# **EzsignimportdocumentDownloadV1**
> EzsignimportdocumentDownloadV1Response EzsignimportdocumentDownloadV1 (int pkiEzsignimportdocumentID)

Retrieve the content


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignimportdocumentID** | **int** |  |  |

### Return type

[**EzsignimportdocumentDownloadV1Response**](EzsignimportdocumentDownloadV1Response.md)

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


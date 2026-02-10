# eZmaxApi.Api.ObjectExternalbrokerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExternalbrokerImportIntoEDMV1**](ObjectExternalbrokerApi.md#externalbrokerimportintoedmv1) | **POST** /1/object/externalbroker/{pkiExternalbrokerID}/importIntoEDM | Import attachments into the Externalbroker |

<a id="externalbrokerimportintoedmv1"></a>
# **ExternalbrokerImportIntoEDMV1**
> ExternalbrokerImportIntoEDMV1Response ExternalbrokerImportIntoEDMV1 (int pkiExternalbrokerID, ExternalbrokerImportIntoEDMV1Request externalbrokerImportIntoEDMV1Request)

Import attachments into the Externalbroker


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiExternalbrokerID** | **int** |  |  |
| **externalbrokerImportIntoEDMV1Request** | [**ExternalbrokerImportIntoEDMV1Request**](ExternalbrokerImportIntoEDMV1Request.md) |  |  |

### Return type

[**ExternalbrokerImportIntoEDMV1Response**](ExternalbrokerImportIntoEDMV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


# eZmaxApi.Api.ObjectEzsignpageApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignpageConsultV1**](ObjectEzsignpageApi.md#ezsignpageconsultv1) | **POST** /1/object/ezsignpage/{pkiEzsignpageID}/consult | Consult an Ezsignpage |

<a id="ezsignpageconsultv1"></a>
# **EzsignpageConsultV1**
> EzsignpageConsultV1Response EzsignpageConsultV1 (int pkiEzsignpageID, Object body)

Consult an Ezsignpage


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignpageID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsignpageConsultV1Response**](EzsignpageConsultV1Response.md)

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


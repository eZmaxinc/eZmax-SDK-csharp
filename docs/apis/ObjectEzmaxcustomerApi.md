# eZmaxApi.Api.ObjectEzmaxcustomerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzmaxcustomerPatchObjectV1**](ObjectEzmaxcustomerApi.md#ezmaxcustomerpatchobjectv1) | **PATCH** /1/object/ezmaxcustomer/{pkiEzmaxcustomerID} | Patch an existing Ezmaxcustomer |

<a id="ezmaxcustomerpatchobjectv1"></a>
# **EzmaxcustomerPatchObjectV1**
> EzmaxcustomerPatchObjectV1Response EzmaxcustomerPatchObjectV1 (int pkiEzmaxcustomerID, EzmaxcustomerPatchObjectV1Request ezmaxcustomerPatchObjectV1Request)

Patch an existing Ezmaxcustomer


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzmaxcustomerID** | **int** | The unique ID of the Ezmaxcustomer |  |
| **ezmaxcustomerPatchObjectV1Request** | [**EzmaxcustomerPatchObjectV1Request**](EzmaxcustomerPatchObjectV1Request.md) |  |  |

### Return type

[**EzmaxcustomerPatchObjectV1Response**](EzmaxcustomerPatchObjectV1Response.md)

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


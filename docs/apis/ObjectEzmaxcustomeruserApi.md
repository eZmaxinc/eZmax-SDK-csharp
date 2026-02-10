# eZmaxApi.Api.ObjectEzmaxcustomeruserApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzmaxcustomeruserPatchObjectV1**](ObjectEzmaxcustomeruserApi.md#ezmaxcustomeruserpatchobjectv1) | **PATCH** /1/object/ezmaxcustomeruser/{pkiEzmaxcustomeruserID} | Patch an existing Ezmaxcustomeruser |

<a id="ezmaxcustomeruserpatchobjectv1"></a>
# **EzmaxcustomeruserPatchObjectV1**
> EzmaxcustomeruserPatchObjectV1Response EzmaxcustomeruserPatchObjectV1 (int pkiEzmaxcustomeruserID, EzmaxcustomeruserPatchObjectV1Request ezmaxcustomeruserPatchObjectV1Request)

Patch an existing Ezmaxcustomeruser


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzmaxcustomeruserID** | **int** | The unique ID of the Ezmaxcustomeruser |  |
| **ezmaxcustomeruserPatchObjectV1Request** | [**EzmaxcustomeruserPatchObjectV1Request**](EzmaxcustomeruserPatchObjectV1Request.md) |  |  |

### Return type

[**EzmaxcustomeruserPatchObjectV1Response**](EzmaxcustomeruserPatchObjectV1Response.md)

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


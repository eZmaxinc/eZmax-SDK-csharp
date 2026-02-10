# eZmaxApi.Api.ObjectEzsigntemplatepackagesignermembershipApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplatepackagesignermembershipCreateObjectV1**](ObjectEzsigntemplatepackagesignermembershipApi.md#ezsigntemplatepackagesignermembershipcreateobjectv1) | **POST** /1/object/ezsigntemplatepackagesignermembership | Create a new Ezsigntemplatepackagesignermembership |
| [**EzsigntemplatepackagesignermembershipDeleteObjectV1**](ObjectEzsigntemplatepackagesignermembershipApi.md#ezsigntemplatepackagesignermembershipdeleteobjectv1) | **DELETE** /1/object/ezsigntemplatepackagesignermembership/{pkiEzsigntemplatepackagesignermembershipID} | Delete an existing Ezsigntemplatepackagesignermembership |
| [**EzsigntemplatepackagesignermembershipGetObjectV2**](ObjectEzsigntemplatepackagesignermembershipApi.md#ezsigntemplatepackagesignermembershipgetobjectv2) | **GET** /2/object/ezsigntemplatepackagesignermembership/{pkiEzsigntemplatepackagesignermembershipID} | Retrieve an existing Ezsigntemplatepackagesignermembership |

<a id="ezsigntemplatepackagesignermembershipcreateobjectv1"></a>
# **EzsigntemplatepackagesignermembershipCreateObjectV1**
> EzsigntemplatepackagesignermembershipCreateObjectV1Response EzsigntemplatepackagesignermembershipCreateObjectV1 (EzsigntemplatepackagesignermembershipCreateObjectV1Request ezsigntemplatepackagesignermembershipCreateObjectV1Request)

Create a new Ezsigntemplatepackagesignermembership

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatepackagesignermembershipCreateObjectV1Request** | [**EzsigntemplatepackagesignermembershipCreateObjectV1Request**](EzsigntemplatepackagesignermembershipCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatepackagesignermembershipCreateObjectV1Response**](EzsigntemplatepackagesignermembershipCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsigntemplatepackagesignermembershipdeleteobjectv1"></a>
# **EzsigntemplatepackagesignermembershipDeleteObjectV1**
> EzsigntemplatepackagesignermembershipDeleteObjectV1Response EzsigntemplatepackagesignermembershipDeleteObjectV1 (int pkiEzsigntemplatepackagesignermembershipID)

Delete an existing Ezsigntemplatepackagesignermembership


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepackagesignermembershipID** | **int** |  |  |

### Return type

[**EzsigntemplatepackagesignermembershipDeleteObjectV1Response**](EzsigntemplatepackagesignermembershipDeleteObjectV1Response.md)

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

<a id="ezsigntemplatepackagesignermembershipgetobjectv2"></a>
# **EzsigntemplatepackagesignermembershipGetObjectV2**
> EzsigntemplatepackagesignermembershipGetObjectV2Response EzsigntemplatepackagesignermembershipGetObjectV2 (int pkiEzsigntemplatepackagesignermembershipID)

Retrieve an existing Ezsigntemplatepackagesignermembership


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepackagesignermembershipID** | **int** |  |  |

### Return type

[**EzsigntemplatepackagesignermembershipGetObjectV2Response**](EzsigntemplatepackagesignermembershipGetObjectV2Response.md)

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


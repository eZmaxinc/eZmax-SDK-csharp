# eZmaxApi.Api.GlobalCustomerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GlobalCustomerGetEndpointV1**](GlobalCustomerApi.md#globalcustomergetendpointv1) | **GET** /1/customer/{pksCustomerCode}/endpoint | Get customer endpoint |

<a id="globalcustomergetendpointv1"></a>
# **GlobalCustomerGetEndpointV1**
> GlobalCustomerGetEndpointV1Response GlobalCustomerGetEndpointV1 (string pksCustomerCode, string sInfrastructureproductCode = null)

Get customer endpoint

Retrieve the customer's specific server endpoint where to send requests. This will help locate the proper region (ie: sInfrastructureregionCode) and the proper environment (ie: sInfrastructureenvironmenttypeDescription) where the customer's data is stored.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pksCustomerCode** | **string** |  |  |
| **sInfrastructureproductCode** | **string** | The infrastructure product Code  If undefined, \&quot;appcluster01\&quot; is assumed | [optional]  |

### Return type

[**GlobalCustomerGetEndpointV1Response**](GlobalCustomerGetEndpointV1Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


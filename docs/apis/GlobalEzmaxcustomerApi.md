# eZmaxApi.Api.GlobalEzmaxcustomerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GlobalEzmaxcustomerGetConfigurationV1**](GlobalEzmaxcustomerApi.md#globalezmaxcustomergetconfigurationv1) | **GET** /1/ezmaxcustomer/{pksEzmaxcustomerCode}/getConfiguration | Get ezmaxcustomer configuration |

<a id="globalezmaxcustomergetconfigurationv1"></a>
# **GlobalEzmaxcustomerGetConfigurationV1**
> GlobalEzmaxcustomerGetConfigurationV1Response GlobalEzmaxcustomerGetConfigurationV1 (string pksEzmaxcustomerCode)

Get ezmaxcustomer configuration

Retrieve the ezmaxcustomer's specific configuration. This will help locate the proper region (ie: sInfrastructureregionCode) and the proper environment (ie: sInfrastructureenvironmenttypeDescription) where the customer's data is stored.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pksEzmaxcustomerCode** | **string** |  |  |

### Return type

[**GlobalEzmaxcustomerGetConfigurationV1Response**](GlobalEzmaxcustomerGetConfigurationV1Response.md)

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


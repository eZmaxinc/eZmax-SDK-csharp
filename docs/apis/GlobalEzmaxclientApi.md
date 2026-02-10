# eZmaxApi.Api.GlobalEzmaxclientApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GlobalEzmaxclientVersionV1**](GlobalEzmaxclientApi.md#globalezmaxclientversionv1) | **GET** /1/ezmaxclient/{pksEzmaxclientOs}/version | Retrieve the latest version of the Ezmaxclient |

<a id="globalezmaxclientversionv1"></a>
# **GlobalEzmaxclientVersionV1**
> GlobalEzmaxclientVersionV1Response GlobalEzmaxclientVersionV1 (FieldPksEzmaxclientOs pksEzmaxclientOs)

Retrieve the latest version of the Ezmaxclient

Retrieve the latest version of the Ezmaxclient that is available on the store.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pksEzmaxclientOs** | **FieldPksEzmaxclientOs** |  |  |

### Return type

[**GlobalEzmaxclientVersionV1Response**](GlobalEzmaxclientVersionV1Response.md)

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


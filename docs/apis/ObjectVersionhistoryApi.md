# eZmaxApi.Api.ObjectVersionhistoryApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VersionhistoryGetObjectV2**](ObjectVersionhistoryApi.md#versionhistorygetobjectv2) | **GET** /2/object/versionhistory/{pkiVersionhistoryID} | Retrieve an existing Versionhistory |

<a id="versionhistorygetobjectv2"></a>
# **VersionhistoryGetObjectV2**
> VersionhistoryGetObjectV2Response VersionhistoryGetObjectV2 (int pkiVersionhistoryID)

Retrieve an existing Versionhistory


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiVersionhistoryID** | **int** |  |  |

### Return type

[**VersionhistoryGetObjectV2Response**](VersionhistoryGetObjectV2Response.md)

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


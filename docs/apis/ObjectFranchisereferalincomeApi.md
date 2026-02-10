# eZmaxApi.Api.ObjectFranchisereferalincomeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FranchisereferalincomeCreateObjectV2**](ObjectFranchisereferalincomeApi.md#franchisereferalincomecreateobjectv2) | **POST** /2/object/franchisereferalincome | Create a new Franchisereferalincome |

<a id="franchisereferalincomecreateobjectv2"></a>
# **FranchisereferalincomeCreateObjectV2**
> FranchisereferalincomeCreateObjectV2Response FranchisereferalincomeCreateObjectV2 (FranchisereferalincomeCreateObjectV2Request franchisereferalincomeCreateObjectV2Request)

Create a new Franchisereferalincome

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **franchisereferalincomeCreateObjectV2Request** | [**FranchisereferalincomeCreateObjectV2Request**](FranchisereferalincomeCreateObjectV2Request.md) |  |  |

### Return type

[**FranchisereferalincomeCreateObjectV2Response**](FranchisereferalincomeCreateObjectV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of this Franchisebroker is not in this Franchiseoffice. fkiFranchiseofficeID contains the id of Franchiseoffice where the Franchisebroker is located on the dtFranchisereferalincomeDisbursed.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


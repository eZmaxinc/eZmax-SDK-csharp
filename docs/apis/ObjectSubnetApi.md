# eZmaxApi.Api.ObjectSubnetApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubnetCreateObjectV1**](ObjectSubnetApi.md#subnetcreateobjectv1) | **POST** /1/object/subnet | Create a new Subnet |
| [**SubnetDeleteObjectV1**](ObjectSubnetApi.md#subnetdeleteobjectv1) | **DELETE** /1/object/subnet/{pkiSubnetID} | Delete an existing Subnet |
| [**SubnetEditObjectV1**](ObjectSubnetApi.md#subneteditobjectv1) | **PUT** /1/object/subnet/{pkiSubnetID} | Edit an existing Subnet |
| [**SubnetGetObjectV2**](ObjectSubnetApi.md#subnetgetobjectv2) | **GET** /2/object/subnet/{pkiSubnetID} | Retrieve an existing Subnet |

<a id="subnetcreateobjectv1"></a>
# **SubnetCreateObjectV1**
> SubnetCreateObjectV1Response SubnetCreateObjectV1 (SubnetCreateObjectV1Request subnetCreateObjectV1Request)

Create a new Subnet

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subnetCreateObjectV1Request** | [**SubnetCreateObjectV1Request**](SubnetCreateObjectV1Request.md) |  |  |

### Return type

[**SubnetCreateObjectV1Response**](SubnetCreateObjectV1Response.md)

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

<a id="subnetdeleteobjectv1"></a>
# **SubnetDeleteObjectV1**
> SubnetDeleteObjectV1Response SubnetDeleteObjectV1 (int pkiSubnetID)

Delete an existing Subnet


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSubnetID** | **int** | The unique ID of the Subnet |  |

### Return type

[**SubnetDeleteObjectV1Response**](SubnetDeleteObjectV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="subneteditobjectv1"></a>
# **SubnetEditObjectV1**
> SubnetEditObjectV1Response SubnetEditObjectV1 (int pkiSubnetID, SubnetEditObjectV1Request subnetEditObjectV1Request)

Edit an existing Subnet


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSubnetID** | **int** | The unique ID of the Subnet |  |
| **subnetEditObjectV1Request** | [**SubnetEditObjectV1Request**](SubnetEditObjectV1Request.md) |  |  |

### Return type

[**SubnetEditObjectV1Response**](SubnetEditObjectV1Response.md)

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

<a id="subnetgetobjectv2"></a>
# **SubnetGetObjectV2**
> SubnetGetObjectV2Response SubnetGetObjectV2 (int pkiSubnetID)

Retrieve an existing Subnet


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSubnetID** | **int** | The unique ID of the Subnet |  |

### Return type

[**SubnetGetObjectV2Response**](SubnetGetObjectV2Response.md)

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


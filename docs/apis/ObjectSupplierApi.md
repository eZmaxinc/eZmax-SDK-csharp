# eZmaxApi.Api.ObjectSupplierApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SupplierGetListV1**](ObjectSupplierApi.md#suppliergetlistv1) | **GET** /1/object/supplier/getList | Retrieve Supplier list |
| [**SupplierImportIntoEDMV1**](ObjectSupplierApi.md#supplierimportintoedmv1) | **POST** /1/object/supplier/{pkiSupplierID}/importIntoEDM | Import attachments into the Supplier |

<a id="suppliergetlistv1"></a>
# **SupplierGetListV1**
> SupplierGetListV1Response SupplierGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Supplier list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**SupplierGetListV1Response**](SupplierGetListV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="supplierimportintoedmv1"></a>
# **SupplierImportIntoEDMV1**
> SupplierImportIntoEDMV1Response SupplierImportIntoEDMV1 (int pkiSupplierID, SupplierImportIntoEDMV1Request supplierImportIntoEDMV1Request)

Import attachments into the Supplier


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSupplierID** | **int** |  |  |
| **supplierImportIntoEDMV1Request** | [**SupplierImportIntoEDMV1Request**](SupplierImportIntoEDMV1Request.md) |  |  |

### Return type

[**SupplierImportIntoEDMV1Response**](SupplierImportIntoEDMV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


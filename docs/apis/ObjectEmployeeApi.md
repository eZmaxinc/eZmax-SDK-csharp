# eZmaxApi.Api.ObjectEmployeeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EmployeeGetListV1**](ObjectEmployeeApi.md#employeegetlistv1) | **GET** /1/object/employee/getList | Retrieve Employee list |
| [**EmployeeImportIntoEDMV1**](ObjectEmployeeApi.md#employeeimportintoedmv1) | **POST** /1/object/employee/{pkiEmployeeID}/importIntoEDM | Import attachments into the Employee |

<a id="employeegetlistv1"></a>
# **EmployeeGetListV1**
> EmployeeGetListV1Response EmployeeGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Employee list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**EmployeeGetListV1Response**](EmployeeGetListV1Response.md)

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

<a id="employeeimportintoedmv1"></a>
# **EmployeeImportIntoEDMV1**
> EmployeeImportIntoEDMV1Response EmployeeImportIntoEDMV1 (int pkiEmployeeID, EmployeeImportIntoEDMV1Request employeeImportIntoEDMV1Request)

Import attachments into the Employee


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEmployeeID** | **int** |  |  |
| **employeeImportIntoEDMV1Request** | [**EmployeeImportIntoEDMV1Request**](EmployeeImportIntoEDMV1Request.md) |  |  |

### Return type

[**EmployeeImportIntoEDMV1Response**](EmployeeImportIntoEDMV1Response.md)

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


# eZmaxApi.Api.ObjectBrandingApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BrandingCreateObjectV2**](ObjectBrandingApi.md#brandingcreateobjectv2) | **POST** /2/object/branding | Create a new Branding |
| [**BrandingEditObjectV2**](ObjectBrandingApi.md#brandingeditobjectv2) | **PUT** /2/object/branding/{pkiBrandingID} | Edit an existing Branding |
| [**BrandingGetAutocompleteV2**](ObjectBrandingApi.md#brandinggetautocompletev2) | **GET** /2/object/branding/getAutocomplete/{sSelector} | Retrieve Brandings and IDs |
| [**BrandingGetListV1**](ObjectBrandingApi.md#brandinggetlistv1) | **GET** /1/object/branding/getList | Retrieve Branding list |
| [**BrandingGetObjectV3**](ObjectBrandingApi.md#brandinggetobjectv3) | **GET** /3/object/branding/{pkiBrandingID} | Retrieve an existing Branding |

<a id="brandingcreateobjectv2"></a>
# **BrandingCreateObjectV2**
> BrandingCreateObjectV2Response BrandingCreateObjectV2 (BrandingCreateObjectV2Request brandingCreateObjectV2Request)

Create a new Branding

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **brandingCreateObjectV2Request** | [**BrandingCreateObjectV2Request**](BrandingCreateObjectV2Request.md) |  |  |

### Return type

[**BrandingCreateObjectV2Response**](BrandingCreateObjectV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="brandingeditobjectv2"></a>
# **BrandingEditObjectV2**
> BrandingEditObjectV2Response BrandingEditObjectV2 (int pkiBrandingID, BrandingEditObjectV2Request brandingEditObjectV2Request)

Edit an existing Branding


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBrandingID** | **int** |  |  |
| **brandingEditObjectV2Request** | [**BrandingEditObjectV2Request**](BrandingEditObjectV2Request.md) |  |  |

### Return type

[**BrandingEditObjectV2Response**](BrandingEditObjectV2Response.md)

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

<a id="brandinggetautocompletev2"></a>
# **BrandingGetAutocompleteV2**
> BrandingGetAutocompleteV2Response BrandingGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Brandings and IDs

Get the list of Branding to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Brandings to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**BrandingGetAutocompleteV2Response**](BrandingGetAutocompleteV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="brandinggetlistv1"></a>
# **BrandingGetListV1**
> BrandingGetListV1Response BrandingGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Branding list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eBrandingLogo | Default<br>JPEG<br>PNG | | eBrandingLogointerface | Default<br>JPEG<br>PNG |


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**BrandingGetListV1Response**](BrandingGetListV1Response.md)

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

<a id="brandinggetobjectv3"></a>
# **BrandingGetObjectV3**
> BrandingGetObjectV3Response BrandingGetObjectV3 (int pkiBrandingID)

Retrieve an existing Branding


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBrandingID** | **int** |  |  |

### Return type

[**BrandingGetObjectV3Response**](BrandingGetObjectV3Response.md)

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


# eZmaxApi.Api.ModuleReportApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportGetReportFromCacheV1**](ModuleReportApi.md#reportgetreportfromcachev1) | **GET** /1/module/report/getReportFromCache/{sReportgroupCacheID} | Retrieve report from cache |

<a id="reportgetreportfromcachev1"></a>
# **ReportGetReportFromCacheV1**
> CommonGetReportV1Response ReportGetReportFromCacheV1 (string sReportgroupCacheID)

Retrieve report from cache

Retrieve a report that was previously generated and cached


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sReportgroupCacheID** | **string** |  |  |

### Return type

[**CommonGetReportV1Response**](CommonGetReportV1Response.md)

### Authorization

[Authorization](../README.md#Authorization), [Presigned](../README.md#Presigned)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/pdf, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet, application/zip, text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


# eZmaxApi.Api.ObjectAgentApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AgentGetAutocompleteV2**](ObjectAgentApi.md#agentgetautocompletev2) | **GET** /2/object/agent/getAutocomplete/{sSelector} | Retrieve Agents and IDs |
| [**AgentGetListV1**](ObjectAgentApi.md#agentgetlistv1) | **GET** /1/object/agent/getList | Retrieve Agent list |
| [**AgentImportIntoEDMV1**](ObjectAgentApi.md#agentimportintoedmv1) | **POST** /1/object/agent/{pkiAgentID}/importIntoEDM | Import attachments into the Agent |

<a id="agentgetautocompletev2"></a>
# **AgentGetAutocompleteV2**
> AgentGetAutocompleteV2Response AgentGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Agents and IDs

Get the list of Agent to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Agents to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**AgentGetAutocompleteV2Response**](AgentGetAutocompleteV2Response.md)

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

<a id="agentgetlistv1"></a>
# **AgentGetListV1**
> AgentGetListV1Response AgentGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Agent list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**AgentGetListV1Response**](AgentGetListV1Response.md)

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

<a id="agentimportintoedmv1"></a>
# **AgentImportIntoEDMV1**
> AgentImportIntoEDMV1Response AgentImportIntoEDMV1 (int pkiAgentID, AgentImportIntoEDMV1Request agentImportIntoEDMV1Request)

Import attachments into the Agent


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAgentID** | **int** |  |  |
| **agentImportIntoEDMV1Request** | [**AgentImportIntoEDMV1Request**](AgentImportIntoEDMV1Request.md) |  |  |

### Return type

[**AgentImportIntoEDMV1Response**](AgentImportIntoEDMV1Response.md)

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


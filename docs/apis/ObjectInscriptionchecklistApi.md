# eZmaxApi.Api.ObjectInscriptionchecklistApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InscriptionchecklistGetAutocompleteV3**](ObjectInscriptionchecklistApi.md#inscriptionchecklistgetautocompletev3) | **GET** /3/object/inscriptionchecklist/getAutocomplete/{sSelector} | Retrieve Inscriptionchecklists and IDs |

<a id="inscriptionchecklistgetautocompletev3"></a>
# **InscriptionchecklistGetAutocompleteV3**
> InscriptionchecklistGetAutocompleteV3Response InscriptionchecklistGetAutocompleteV3 (string sSelector, string fkiBuyercontractID = null, string fkiInscriptionID = null, string fkiInscriptionnotauthenticatedID = null, string fkiInscriptiontempID = null, string fkiAgentID = null, string fkiBrokerID = null, string fkiOtherincomeID = null, string fkiRejectedoffertopurchaseID = null, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Inscriptionchecklists and IDs

Get the list of Inscriptionchecklist to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Inscriptionchecklist to return |  |
| **fkiBuyercontractID** | **string** | Specify which Buyercontract we want to display. | [optional]  |
| **fkiInscriptionID** | **string** | Specify which Inscription we want to display. | [optional]  |
| **fkiInscriptionnotauthenticatedID** | **string** | Specify which Inscriptionnotauthenticated we want to display. | [optional]  |
| **fkiInscriptiontempID** | **string** | Specify which Inscriptiontemp we want to display. | [optional]  |
| **fkiAgentID** | **string** | Specify which Agent we want to display. | [optional]  |
| **fkiBrokerID** | **string** | Specify which Broker we want to display. | [optional]  |
| **fkiOtherincomeID** | **string** | Specify which Otherincome we want to display. | [optional]  |
| **fkiRejectedoffertopurchaseID** | **string** | Specify which Rejectedoffertopurchase we want to display. | [optional]  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**InscriptionchecklistGetAutocompleteV3Response**](InscriptionchecklistGetAutocompleteV3Response.md)

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


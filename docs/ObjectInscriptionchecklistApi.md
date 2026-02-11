# eZmaxApi.Api.ObjectInscriptionchecklistApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InscriptionchecklistGetAutocompleteV3**](ObjectInscriptionchecklistApi.md#inscriptionchecklistgetautocompletev3) | **GET** /3/object/inscriptionchecklist/getAutocomplete/{sSelector} | Retrieve Inscriptionchecklists and IDs |

<a id="inscriptionchecklistgetautocompletev3"></a>
# **InscriptionchecklistGetAutocompleteV3**
> InscriptionchecklistGetAutocompleteV3Response InscriptionchecklistGetAutocompleteV3 (string sSelector, string? fkiBuyercontractID = null, string? fkiInscriptionID = null, string? fkiInscriptionnotauthenticatedID = null, string? fkiInscriptiontempID = null, string? fkiAgentID = null, string? fkiBrokerID = null, string? fkiOtherincomeID = null, string? fkiRejectedoffertopurchaseID = null, string? eFilterActive = null, string? sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Inscriptionchecklists and IDs

Get the list of Inscriptionchecklist to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionchecklistGetAutocompleteV3Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionchecklistApi(config);
            var sSelector = "All";  // string | The type of Inscriptionchecklist to return
            var fkiBuyercontractID = "fkiBuyercontractID_example";  // string? | Specify which Buyercontract we want to display. (optional) 
            var fkiInscriptionID = "fkiInscriptionID_example";  // string? | Specify which Inscription we want to display. (optional) 
            var fkiInscriptionnotauthenticatedID = "fkiInscriptionnotauthenticatedID_example";  // string? | Specify which Inscriptionnotauthenticated we want to display. (optional) 
            var fkiInscriptiontempID = "fkiInscriptiontempID_example";  // string? | Specify which Inscriptiontemp we want to display. (optional) 
            var fkiAgentID = "fkiAgentID_example";  // string? | Specify which Agent we want to display. (optional) 
            var fkiBrokerID = "fkiBrokerID_example";  // string? | Specify which Broker we want to display. (optional) 
            var fkiOtherincomeID = "fkiOtherincomeID_example";  // string? | Specify which Otherincome we want to display. (optional) 
            var fkiRejectedoffertopurchaseID = "fkiRejectedoffertopurchaseID_example";  // string? | Specify which Rejectedoffertopurchase we want to display. (optional) 
            var eFilterActive = "All";  // string? | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string? | Allow to filter the returned results (optional) 
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Inscriptionchecklists and IDs
                InscriptionchecklistGetAutocompleteV3Response result = apiInstance.InscriptionchecklistGetAutocompleteV3(sSelector, fkiBuyercontractID, fkiInscriptionID, fkiInscriptionnotauthenticatedID, fkiInscriptiontempID, fkiAgentID, fkiBrokerID, fkiOtherincomeID, fkiRejectedoffertopurchaseID, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionchecklistApi.InscriptionchecklistGetAutocompleteV3: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionchecklistGetAutocompleteV3WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Inscriptionchecklists and IDs
    ApiResponse<InscriptionchecklistGetAutocompleteV3Response> response = apiInstance.InscriptionchecklistGetAutocompleteV3WithHttpInfo(sSelector, fkiBuyercontractID, fkiInscriptionID, fkiInscriptionnotauthenticatedID, fkiInscriptiontempID, fkiAgentID, fkiBrokerID, fkiOtherincomeID, fkiRejectedoffertopurchaseID, eFilterActive, sQuery, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionchecklistApi.InscriptionchecklistGetAutocompleteV3WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Inscriptionchecklist to return |  |
| **fkiBuyercontractID** | **string?** | Specify which Buyercontract we want to display. | [optional]  |
| **fkiInscriptionID** | **string?** | Specify which Inscription we want to display. | [optional]  |
| **fkiInscriptionnotauthenticatedID** | **string?** | Specify which Inscriptionnotauthenticated we want to display. | [optional]  |
| **fkiInscriptiontempID** | **string?** | Specify which Inscriptiontemp we want to display. | [optional]  |
| **fkiAgentID** | **string?** | Specify which Agent we want to display. | [optional]  |
| **fkiBrokerID** | **string?** | Specify which Broker we want to display. | [optional]  |
| **fkiOtherincomeID** | **string?** | Specify which Otherincome we want to display. | [optional]  |
| **fkiRejectedoffertopurchaseID** | **string?** | Specify which Rejectedoffertopurchase we want to display. | [optional]  |
| **eFilterActive** | **string?** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string?** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


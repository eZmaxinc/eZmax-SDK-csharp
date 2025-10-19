# eZmaxApi.Api.ObjectInscriptiontypeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InscriptiontypeGetAutocompleteV2**](ObjectInscriptiontypeApi.md#inscriptiontypegetautocompletev2) | **GET** /2/object/inscriptiontype/getAutocomplete/{sSelector} | Retrieve Inscriptiontypes and IDs |

<a id="inscriptiontypegetautocompletev2"></a>
# **InscriptiontypeGetAutocompleteV2**
> InscriptiontypeGetAutocompleteV2Response InscriptiontypeGetAutocompleteV2 (string sSelector, string? sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Inscriptiontypes and IDs

Get the list of Inscriptiontype to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptiontypeGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptiontypeApi(config);
            var sSelector = "All";  // string | The type of Inscriptiontypes to return
            var sQuery = "sQuery_example";  // string? | Allow to filter the returned results (optional) 
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Inscriptiontypes and IDs
                InscriptiontypeGetAutocompleteV2Response result = apiInstance.InscriptiontypeGetAutocompleteV2(sSelector, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptiontypeApi.InscriptiontypeGetAutocompleteV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptiontypeGetAutocompleteV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Inscriptiontypes and IDs
    ApiResponse<InscriptiontypeGetAutocompleteV2Response> response = apiInstance.InscriptiontypeGetAutocompleteV2WithHttpInfo(sSelector, sQuery, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptiontypeApi.InscriptiontypeGetAutocompleteV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Inscriptiontypes to return |  |
| **sQuery** | **string?** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |

### Return type

[**InscriptiontypeGetAutocompleteV2Response**](InscriptiontypeGetAutocompleteV2Response.md)

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


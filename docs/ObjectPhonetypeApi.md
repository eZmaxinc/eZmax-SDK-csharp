# eZmaxApi.Api.ObjectPhonetypeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PhonetypeGetAutocompleteV2**](ObjectPhonetypeApi.md#phonetypegetautocompletev2) | **GET** /2/object/phonetype/getAutocomplete/{sSelector} | Retrieve Phonetypes and IDs



## PhonetypeGetAutocompleteV2

> PhonetypeGetAutocompleteV2Response PhonetypeGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Phonetypes and IDs

Get the list of Phonetype to be used in a dropdown or autocomplete control.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class PhonetypeGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectPhonetypeApi(Configuration.Default);
            var sSelector = "All";  // string | The type of Phonetypes to return
            var eFilterActive = "All";  // string | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string | Allow to filter the returned results (optional) 
            var acceptLanguage = (HeaderAcceptLanguage) "*";  // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Phonetypes and IDs
                PhonetypeGetAutocompleteV2Response result = apiInstance.PhonetypeGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectPhonetypeApi.PhonetypeGetAutocompleteV2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sSelector** | **string**| The type of Phonetypes to return | 
 **eFilterActive** | **string**| Specify which results we want to display. | [optional] [default to Active]
 **sQuery** | **string**| Allow to filter the returned results | [optional] 
 **acceptLanguage** | **HeaderAcceptLanguage?**|  | [optional] 

### Return type

[**PhonetypeGetAutocompleteV2Response**](PhonetypeGetAutocompleteV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


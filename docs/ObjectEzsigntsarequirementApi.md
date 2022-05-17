# eZmaxApi.Api.ObjectEzsigntsarequirementApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EzsigntsarequirementGetAutocompleteV1**](ObjectEzsigntsarequirementApi.md#ezsigntsarequirementgetautocompletev1) | **GET** /1/object/ezsigntsarequirement/getAutocomplete/{sSelector} | Retrieve Ezsigntsarequirements and IDs



## EzsigntsarequirementGetAutocompleteV1

> CommonGetAutocompleteDisabledV1Response EzsigntsarequirementGetAutocompleteV1 (string sSelector, int? fkiEzsignfoldertypeID = null, string sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Ezsigntsarequirements and IDs

Get the list of Ezsigntsarequirement to be used in a dropdown or autocomplete control.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntsarequirementGetAutocompleteV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntsarequirementApi(Configuration.Default);
            var sSelector = "User";  // string | The type of Ezsigntsarequirements to return
            var fkiEzsignfoldertypeID = 56;  // int? |  (optional) 
            var sQuery = "sQuery_example";  // string | Allow to filter the returned results (optional) 
            var acceptLanguage = (HeaderAcceptLanguage) "*";  // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Ezsigntsarequirements and IDs
                CommonGetAutocompleteDisabledV1Response result = apiInstance.EzsigntsarequirementGetAutocompleteV1(sSelector, fkiEzsignfoldertypeID, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsigntsarequirementApi.EzsigntsarequirementGetAutocompleteV1: " + e.Message );
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
 **sSelector** | **string**| The type of Ezsigntsarequirements to return | 
 **fkiEzsignfoldertypeID** | **int?**|  | [optional] 
 **sQuery** | **string**| Allow to filter the returned results | [optional] 
 **acceptLanguage** | **HeaderAcceptLanguage?**|  | [optional] 

### Return type

[**CommonGetAutocompleteDisabledV1Response**](CommonGetAutocompleteDisabledV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **422** | The syntax of the request is valid but the request cannot be completed. Look for detail in body. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


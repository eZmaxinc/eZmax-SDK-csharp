# eZmaxApi.Api.ObjectFranchisebrokerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FranchisebrokerGetAutocompleteV1**](ObjectFranchisebrokerApi.md#franchisebrokergetautocompletev1) | **GET** /1/object/franchisebroker/getAutocomplete/{sSelector} | Retrieve Franchisebrokers and IDs
[**FranchisebrokerGetAutocompleteV2**](ObjectFranchisebrokerApi.md#franchisebrokergetautocompletev2) | **GET** /2/object/franchisebroker/getAutocomplete/{sSelector} | Retrieve Franchisebrokers and IDs



## FranchisebrokerGetAutocompleteV1

> CommonGetAutocompleteV1Response FranchisebrokerGetAutocompleteV1 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Franchisebrokers and IDs

Get the list of Franchisebrokers to be used in a dropdown or autocomplete control.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class FranchisebrokerGetAutocompleteV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectFranchisebrokerApi(Configuration.Default);
            var sSelector = "Active";  // string | The type of Franchisebrokers to return
            var eFilterActive = "All";  // string | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string | Allow to filter the returned results (optional) 
            var acceptLanguage = (HeaderAcceptLanguage) "*";  // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Franchisebrokers and IDs
                CommonGetAutocompleteV1Response result = apiInstance.FranchisebrokerGetAutocompleteV1(sSelector, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectFranchisebrokerApi.FranchisebrokerGetAutocompleteV1: " + e.Message );
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
 **sSelector** | **string**| The type of Franchisebrokers to return | 
 **eFilterActive** | **string**| Specify which results we want to display. | [optional] [default to Active]
 **sQuery** | **string**| Allow to filter the returned results | [optional] 
 **acceptLanguage** | **HeaderAcceptLanguage?**|  | [optional] 

### Return type

[**CommonGetAutocompleteV1Response**](CommonGetAutocompleteV1Response.md)

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


## FranchisebrokerGetAutocompleteV2

> FranchisebrokerGetAutocompleteV2Response FranchisebrokerGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Franchisebrokers and IDs

Get the list of Franchisebroker to be used in a dropdown or autocomplete control.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class FranchisebrokerGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectFranchisebrokerApi(Configuration.Default);
            var sSelector = "All";  // string | The type of Franchisebrokers to return
            var eFilterActive = "All";  // string | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string | Allow to filter the returned results (optional) 
            var acceptLanguage = (HeaderAcceptLanguage) "*";  // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Franchisebrokers and IDs
                FranchisebrokerGetAutocompleteV2Response result = apiInstance.FranchisebrokerGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectFranchisebrokerApi.FranchisebrokerGetAutocompleteV2: " + e.Message );
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
 **sSelector** | **string**| The type of Franchisebrokers to return | 
 **eFilterActive** | **string**| Specify which results we want to display. | [optional] [default to Active]
 **sQuery** | **string**| Allow to filter the returned results | [optional] 
 **acceptLanguage** | **HeaderAcceptLanguage?**|  | [optional] 

### Return type

[**FranchisebrokerGetAutocompleteV2Response**](FranchisebrokerGetAutocompleteV2Response.md)

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


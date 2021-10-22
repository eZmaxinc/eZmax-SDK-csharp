# eZmaxApi.Api.ModuleListApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListListpresentationV1**](ModuleListApi.md#listlistpresentationv1) | **POST** /1/module/list/listpresentation/{sListName} | Save all Listpresentation for a specific list



## ListListpresentationV1

> ListSaveListpresentationV1Response ListListpresentationV1 (string sListName, ListSaveListpresentationV1Request listSaveListpresentationV1Request)

Save all Listpresentation for a specific list

Users can create many Listpresentations for lists in the system. They can customize orber by, filters, numbers of rows, etc.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ListListpresentationV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleListApi(Configuration.Default);
            var sListName = sListName_example;  // string | The list Name
            var listSaveListpresentationV1Request = new ListSaveListpresentationV1Request(); // ListSaveListpresentationV1Request | 

            try
            {
                // Save all Listpresentation for a specific list
                ListSaveListpresentationV1Response result = apiInstance.ListListpresentationV1(sListName, listSaveListpresentationV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModuleListApi.ListListpresentationV1: " + e.Message );
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
 **sListName** | **string**| The list Name | 
 **listSaveListpresentationV1Request** | [**ListSaveListpresentationV1Request**](ListSaveListpresentationV1Request.md)|  | 

### Return type

[**ListSaveListpresentationV1Response**](ListSaveListpresentationV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The element you are trying to work on does not exist |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


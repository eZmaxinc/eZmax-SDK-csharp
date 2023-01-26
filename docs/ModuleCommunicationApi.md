# eZmaxApi.Api.ModuleCommunicationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CommunicationGetCommunicationCountV1**](ModuleCommunicationApi.md#communicationgetcommunicationcountv1) | **GET** /1/module/communication/getCount | Retrieve Communication count



## CommunicationGetCommunicationCountV1

> CommunicationGetCountV1Response CommunicationGetCommunicationCountV1 (string eCommunicationObjecttype, int? pkiEzsignfolderID = null)

Retrieve Communication count

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class CommunicationGetCommunicationCountV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleCommunicationApi(Configuration.Default);
            var eCommunicationObjecttype = "Ezsignfolder";  // string | The object type for the Communication
            var pkiEzsignfolderID = 56;  // int? | The unique ID of the Ezsignfolder (optional) 

            try
            {
                // Retrieve Communication count
                CommunicationGetCountV1Response result = apiInstance.CommunicationGetCommunicationCountV1(eCommunicationObjecttype, pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModuleCommunicationApi.CommunicationGetCommunicationCountV1: " + e.Message );
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
 **eCommunicationObjecttype** | **string**| The object type for the Communication | 
 **pkiEzsignfolderID** | **int?**| The unique ID of the Ezsignfolder | [optional] 

### Return type

[**CommunicationGetCountV1Response**](CommunicationGetCountV1Response.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


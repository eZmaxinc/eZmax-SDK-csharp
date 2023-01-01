# eZmaxApi.Api.ModuleCommunicationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CommunicationGetCommunicationCountV1**](ModuleCommunicationApi.md#communicationgetcommunicationcountv1) | **GET** /1/module/communication/getCommunicationCount | Get the number of communication
[**CommunicationGetCommunicationListV1**](ModuleCommunicationApi.md#communicationgetcommunicationlistv1) | **GET** /1/module/communication/getCommunicationList | Retrieve communication list



## CommunicationGetCommunicationCountV1

> CommunicationGetCountV1Response CommunicationGetCommunicationCountV1 (string eCommunicationModule, int? pkiEzsignfolderID = null)

Get the number of communication

Get the number of communication in specified module

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
            var eCommunicationModule = "Ezsignfolder";  // string | Specify the requested module
            var pkiEzsignfolderID = 56;  // int? | The unique ID of the Ezsignfolder (optional) 

            try
            {
                // Get the number of communication
                CommunicationGetCountV1Response result = apiInstance.CommunicationGetCommunicationCountV1(eCommunicationModule, pkiEzsignfolderID);
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
 **eCommunicationModule** | **string**| Specify the requested module | 
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


## CommunicationGetCommunicationListV1

> CommunicationGetListV1Response CommunicationGetCommunicationListV1 (string eCommunicationModule, int? pkiEzsignfolderID = null)

Retrieve communication list

Retrieve communication list

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class CommunicationGetCommunicationListV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleCommunicationApi(Configuration.Default);
            var eCommunicationModule = "Ezsignfolder";  // string | Specify the requested module
            var pkiEzsignfolderID = 56;  // int? | The unique ID of the Ezsignfolder (optional) 

            try
            {
                // Retrieve communication list
                CommunicationGetListV1Response result = apiInstance.CommunicationGetCommunicationListV1(eCommunicationModule, pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModuleCommunicationApi.CommunicationGetCommunicationListV1: " + e.Message );
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
 **eCommunicationModule** | **string**| Specify the requested module | 
 **pkiEzsignfolderID** | **int?**| The unique ID of the Ezsignfolder | [optional] 

### Return type

[**CommunicationGetListV1Response**](CommunicationGetListV1Response.md)

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


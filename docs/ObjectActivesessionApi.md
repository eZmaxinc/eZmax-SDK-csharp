# eZmaxApi.Api.ObjectActivesessionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivesessionGetCurrentV1**](ObjectActivesessionApi.md#activesessiongetcurrentv1) | **GET** /1/object/activesession/getCurrent | Get Current Activesession



## ActivesessionGetCurrentV1

> ActivesessionGetCurrentV1Response ActivesessionGetCurrentV1 ()

Get Current Activesession

Retrieve the details about the current activesession

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ActivesessionGetCurrentV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectActivesessionApi(Configuration.Default);

            try
            {
                // Get Current Activesession
                ActivesessionGetCurrentV1Response result = apiInstance.ActivesessionGetCurrentV1();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectActivesessionApi.ActivesessionGetCurrentV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ActivesessionGetCurrentV1Response**](ActivesessionGetCurrentV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **350** | The user must authenticate before he can continue with this request |  -  |
| **351** | The user is configured with 2FA and needs to validate its phone number before he can continue with this request |  -  |
| **352** | The user is configured with 2FA and needs to answer a Secretquestion before he can continue with this request |  -  |
| **353** | The user must accept clauses before he can continue with this request |  -  |
| **354** | The user&#39;s computer must be validated before he can continue with this request |  -  |
| **355** | The user must change its password before he can continue with this request |  -  |
| **356** | The user is not running the latest version of the native application. He must valide or update its version before he can continue with this request |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


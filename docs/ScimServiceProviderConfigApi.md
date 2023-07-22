# eZmaxApi.Api.ScimServiceProviderConfigApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServiceProviderConfigGetObjectScimV2**](ScimServiceProviderConfigApi.md#serviceproviderconfiggetobjectscimv2) | **GET** /2/scim/ServiceProviderConfig | Get Service Provider Configuration



## ServiceProviderConfigGetObjectScimV2

> ScimServiceProviderConfig ServiceProviderConfigGetObjectScimV2 ()

Get Service Provider Configuration

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ServiceProviderConfigGetObjectScimV2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            var apiInstance = new ScimServiceProviderConfigApi(Configuration.Default);

            try
            {
                // Get Service Provider Configuration
                ScimServiceProviderConfig result = apiInstance.ServiceProviderConfigGetObjectScimV2();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ScimServiceProviderConfigApi.ServiceProviderConfigGetObjectScimV2: " + e.Message );
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

[**ScimServiceProviderConfig**](ScimServiceProviderConfig.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


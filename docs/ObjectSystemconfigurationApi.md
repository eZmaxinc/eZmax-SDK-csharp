# eZmaxApi.Api.ObjectSystemconfigurationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SystemconfigurationEditObjectV1**](ObjectSystemconfigurationApi.md#systemconfigurationeditobjectv1) | **PUT** /1/object/systemconfiguration/{pkiSystemconfigurationID} | Edit an existing Systemconfiguration
[**SystemconfigurationGetObjectV2**](ObjectSystemconfigurationApi.md#systemconfigurationgetobjectv2) | **GET** /2/object/systemconfiguration/{pkiSystemconfigurationID} | Retrieve an existing Systemconfiguration



## SystemconfigurationEditObjectV1

> SystemconfigurationEditObjectV1Response SystemconfigurationEditObjectV1 (int pkiSystemconfigurationID, SystemconfigurationEditObjectV1Request systemconfigurationEditObjectV1Request)

Edit an existing Systemconfiguration

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class SystemconfigurationEditObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectSystemconfigurationApi(Configuration.Default);
            var pkiSystemconfigurationID = 56;  // int | The unique ID of the Systemconfiguration
            var systemconfigurationEditObjectV1Request = new SystemconfigurationEditObjectV1Request(); // SystemconfigurationEditObjectV1Request | 

            try
            {
                // Edit an existing Systemconfiguration
                SystemconfigurationEditObjectV1Response result = apiInstance.SystemconfigurationEditObjectV1(pkiSystemconfigurationID, systemconfigurationEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectSystemconfigurationApi.SystemconfigurationEditObjectV1: " + e.Message );
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
 **pkiSystemconfigurationID** | **int**| The unique ID of the Systemconfiguration | 
 **systemconfigurationEditObjectV1Request** | [**SystemconfigurationEditObjectV1Request**](SystemconfigurationEditObjectV1Request.md)|  | 

### Return type

[**SystemconfigurationEditObjectV1Response**](SystemconfigurationEditObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SystemconfigurationGetObjectV2

> SystemconfigurationGetObjectV2Response SystemconfigurationGetObjectV2 (int pkiSystemconfigurationID)

Retrieve an existing Systemconfiguration

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class SystemconfigurationGetObjectV2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectSystemconfigurationApi(Configuration.Default);
            var pkiSystemconfigurationID = 56;  // int | The unique ID of the Systemconfiguration

            try
            {
                // Retrieve an existing Systemconfiguration
                SystemconfigurationGetObjectV2Response result = apiInstance.SystemconfigurationGetObjectV2(pkiSystemconfigurationID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectSystemconfigurationApi.SystemconfigurationGetObjectV2: " + e.Message );
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
 **pkiSystemconfigurationID** | **int**| The unique ID of the Systemconfiguration | 

### Return type

[**SystemconfigurationGetObjectV2Response**](SystemconfigurationGetObjectV2Response.md)

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


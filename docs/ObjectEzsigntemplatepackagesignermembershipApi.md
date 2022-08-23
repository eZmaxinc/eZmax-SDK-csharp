# eZmaxApi.Api.ObjectEzsigntemplatepackagesignermembershipApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EzsigntemplatepackagesignermembershipCreateObjectV1**](ObjectEzsigntemplatepackagesignermembershipApi.md#ezsigntemplatepackagesignermembershipcreateobjectv1) | **POST** /1/object/ezsigntemplatepackagesignermembership | Create a new Ezsigntemplatepackagesignermembership
[**EzsigntemplatepackagesignermembershipDeleteObjectV1**](ObjectEzsigntemplatepackagesignermembershipApi.md#ezsigntemplatepackagesignermembershipdeleteobjectv1) | **DELETE** /1/object/ezsigntemplatepackagesignermembership/{pkiEzsigntemplatepackagesignermembershipID} | Delete an existing Ezsigntemplatepackagesignermembership
[**EzsigntemplatepackagesignermembershipGetObjectV1**](ObjectEzsigntemplatepackagesignermembershipApi.md#ezsigntemplatepackagesignermembershipgetobjectv1) | **GET** /1/object/ezsigntemplatepackagesignermembership/{pkiEzsigntemplatepackagesignermembershipID} | Retrieve an existing Ezsigntemplatepackagesignermembership



## EzsigntemplatepackagesignermembershipCreateObjectV1

> EzsigntemplatepackagesignermembershipCreateObjectV1Response EzsigntemplatepackagesignermembershipCreateObjectV1 (EzsigntemplatepackagesignermembershipCreateObjectV1Request ezsigntemplatepackagesignermembershipCreateObjectV1Request)

Create a new Ezsigntemplatepackagesignermembership

The endpoint allows to create one or many elements at once.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepackagesignermembershipCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepackagesignermembershipApi(Configuration.Default);
            var ezsigntemplatepackagesignermembershipCreateObjectV1Request = new EzsigntemplatepackagesignermembershipCreateObjectV1Request(); // EzsigntemplatepackagesignermembershipCreateObjectV1Request | 

            try
            {
                // Create a new Ezsigntemplatepackagesignermembership
                EzsigntemplatepackagesignermembershipCreateObjectV1Response result = apiInstance.EzsigntemplatepackagesignermembershipCreateObjectV1(ezsigntemplatepackagesignermembershipCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepackagesignermembershipApi.EzsigntemplatepackagesignermembershipCreateObjectV1: " + e.Message );
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
 **ezsigntemplatepackagesignermembershipCreateObjectV1Request** | [**EzsigntemplatepackagesignermembershipCreateObjectV1Request**](EzsigntemplatepackagesignermembershipCreateObjectV1Request.md)|  | 

### Return type

[**EzsigntemplatepackagesignermembershipCreateObjectV1Response**](EzsigntemplatepackagesignermembershipCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsigntemplatepackagesignermembershipDeleteObjectV1

> EzsigntemplatepackagesignermembershipDeleteObjectV1Response EzsigntemplatepackagesignermembershipDeleteObjectV1 (int pkiEzsigntemplatepackagesignermembershipID)

Delete an existing Ezsigntemplatepackagesignermembership

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepackagesignermembershipDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepackagesignermembershipApi(Configuration.Default);
            var pkiEzsigntemplatepackagesignermembershipID = 56;  // int | 

            try
            {
                // Delete an existing Ezsigntemplatepackagesignermembership
                EzsigntemplatepackagesignermembershipDeleteObjectV1Response result = apiInstance.EzsigntemplatepackagesignermembershipDeleteObjectV1(pkiEzsigntemplatepackagesignermembershipID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepackagesignermembershipApi.EzsigntemplatepackagesignermembershipDeleteObjectV1: " + e.Message );
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
 **pkiEzsigntemplatepackagesignermembershipID** | **int**|  | 

### Return type

[**EzsigntemplatepackagesignermembershipDeleteObjectV1Response**](EzsigntemplatepackagesignermembershipDeleteObjectV1Response.md)

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


## EzsigntemplatepackagesignermembershipGetObjectV1

> EzsigntemplatepackagesignermembershipGetObjectV1Response EzsigntemplatepackagesignermembershipGetObjectV1 (int pkiEzsigntemplatepackagesignermembershipID)

Retrieve an existing Ezsigntemplatepackagesignermembership

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepackagesignermembershipGetObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepackagesignermembershipApi(Configuration.Default);
            var pkiEzsigntemplatepackagesignermembershipID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplatepackagesignermembership
                EzsigntemplatepackagesignermembershipGetObjectV1Response result = apiInstance.EzsigntemplatepackagesignermembershipGetObjectV1(pkiEzsigntemplatepackagesignermembershipID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepackagesignermembershipApi.EzsigntemplatepackagesignermembershipGetObjectV1: " + e.Message );
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
 **pkiEzsigntemplatepackagesignermembershipID** | **int**|  | 

### Return type

[**EzsigntemplatepackagesignermembershipGetObjectV1Response**](EzsigntemplatepackagesignermembershipGetObjectV1Response.md)

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


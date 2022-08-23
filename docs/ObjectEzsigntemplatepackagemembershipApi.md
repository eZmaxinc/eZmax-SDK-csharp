# eZmaxApi.Api.ObjectEzsigntemplatepackagemembershipApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EzsigntemplatepackagemembershipCreateObjectV1**](ObjectEzsigntemplatepackagemembershipApi.md#ezsigntemplatepackagemembershipcreateobjectv1) | **POST** /1/object/ezsigntemplatepackagemembership | Create a new Ezsigntemplatepackagemembership
[**EzsigntemplatepackagemembershipDeleteObjectV1**](ObjectEzsigntemplatepackagemembershipApi.md#ezsigntemplatepackagemembershipdeleteobjectv1) | **DELETE** /1/object/ezsigntemplatepackagemembership/{pkiEzsigntemplatepackagemembershipID} | Delete an existing Ezsigntemplatepackagemembership
[**EzsigntemplatepackagemembershipGetObjectV1**](ObjectEzsigntemplatepackagemembershipApi.md#ezsigntemplatepackagemembershipgetobjectv1) | **GET** /1/object/ezsigntemplatepackagemembership/{pkiEzsigntemplatepackagemembershipID} | Retrieve an existing Ezsigntemplatepackagemembership



## EzsigntemplatepackagemembershipCreateObjectV1

> EzsigntemplatepackagemembershipCreateObjectV1Response EzsigntemplatepackagemembershipCreateObjectV1 (EzsigntemplatepackagemembershipCreateObjectV1Request ezsigntemplatepackagemembershipCreateObjectV1Request)

Create a new Ezsigntemplatepackagemembership

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
    public class EzsigntemplatepackagemembershipCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepackagemembershipApi(Configuration.Default);
            var ezsigntemplatepackagemembershipCreateObjectV1Request = new EzsigntemplatepackagemembershipCreateObjectV1Request(); // EzsigntemplatepackagemembershipCreateObjectV1Request | 

            try
            {
                // Create a new Ezsigntemplatepackagemembership
                EzsigntemplatepackagemembershipCreateObjectV1Response result = apiInstance.EzsigntemplatepackagemembershipCreateObjectV1(ezsigntemplatepackagemembershipCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepackagemembershipApi.EzsigntemplatepackagemembershipCreateObjectV1: " + e.Message );
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
 **ezsigntemplatepackagemembershipCreateObjectV1Request** | [**EzsigntemplatepackagemembershipCreateObjectV1Request**](EzsigntemplatepackagemembershipCreateObjectV1Request.md)|  | 

### Return type

[**EzsigntemplatepackagemembershipCreateObjectV1Response**](EzsigntemplatepackagemembershipCreateObjectV1Response.md)

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


## EzsigntemplatepackagemembershipDeleteObjectV1

> EzsigntemplatepackagemembershipDeleteObjectV1Response EzsigntemplatepackagemembershipDeleteObjectV1 (int pkiEzsigntemplatepackagemembershipID)

Delete an existing Ezsigntemplatepackagemembership

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepackagemembershipDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepackagemembershipApi(Configuration.Default);
            var pkiEzsigntemplatepackagemembershipID = 56;  // int | 

            try
            {
                // Delete an existing Ezsigntemplatepackagemembership
                EzsigntemplatepackagemembershipDeleteObjectV1Response result = apiInstance.EzsigntemplatepackagemembershipDeleteObjectV1(pkiEzsigntemplatepackagemembershipID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepackagemembershipApi.EzsigntemplatepackagemembershipDeleteObjectV1: " + e.Message );
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
 **pkiEzsigntemplatepackagemembershipID** | **int**|  | 

### Return type

[**EzsigntemplatepackagemembershipDeleteObjectV1Response**](EzsigntemplatepackagemembershipDeleteObjectV1Response.md)

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


## EzsigntemplatepackagemembershipGetObjectV1

> EzsigntemplatepackagemembershipGetObjectV1Response EzsigntemplatepackagemembershipGetObjectV1 (int pkiEzsigntemplatepackagemembershipID)

Retrieve an existing Ezsigntemplatepackagemembership

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepackagemembershipGetObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepackagemembershipApi(Configuration.Default);
            var pkiEzsigntemplatepackagemembershipID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplatepackagemembership
                EzsigntemplatepackagemembershipGetObjectV1Response result = apiInstance.EzsigntemplatepackagemembershipGetObjectV1(pkiEzsigntemplatepackagemembershipID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepackagemembershipApi.EzsigntemplatepackagemembershipGetObjectV1: " + e.Message );
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
 **pkiEzsigntemplatepackagemembershipID** | **int**|  | 

### Return type

[**EzsigntemplatepackagemembershipGetObjectV1Response**](EzsigntemplatepackagemembershipGetObjectV1Response.md)

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


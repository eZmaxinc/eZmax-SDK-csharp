# eZmaxApi.Api.ObjectEzsignsignergroupmembershipApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EzsignsignergroupmembershipCreateObjectV1**](ObjectEzsignsignergroupmembershipApi.md#ezsignsignergroupmembershipcreateobjectv1) | **POST** /1/object/ezsignsignergroupmembership | Create a new Ezsignsignergroupmembership
[**EzsignsignergroupmembershipDeleteObjectV1**](ObjectEzsignsignergroupmembershipApi.md#ezsignsignergroupmembershipdeleteobjectv1) | **DELETE** /1/object/ezsignsignergroupmembership/{pkiEzsignsignergroupmembershipID} | Delete an existing Ezsignsignergroupmembership
[**EzsignsignergroupmembershipGetObjectV2**](ObjectEzsignsignergroupmembershipApi.md#ezsignsignergroupmembershipgetobjectv2) | **GET** /2/object/ezsignsignergroupmembership/{pkiEzsignsignergroupmembershipID} | Retrieve an existing Ezsignsignergroupmembership



## EzsignsignergroupmembershipCreateObjectV1

> EzsignsignergroupmembershipCreateObjectV1Response EzsignsignergroupmembershipCreateObjectV1 (EzsignsignergroupmembershipCreateObjectV1Request ezsignsignergroupmembershipCreateObjectV1Request)

Create a new Ezsignsignergroupmembership

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
    public class EzsignsignergroupmembershipCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsignergroupmembershipApi(Configuration.Default);
            var ezsignsignergroupmembershipCreateObjectV1Request = new EzsignsignergroupmembershipCreateObjectV1Request(); // EzsignsignergroupmembershipCreateObjectV1Request | 

            try
            {
                // Create a new Ezsignsignergroupmembership
                EzsignsignergroupmembershipCreateObjectV1Response result = apiInstance.EzsignsignergroupmembershipCreateObjectV1(ezsignsignergroupmembershipCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignsignergroupmembershipApi.EzsignsignergroupmembershipCreateObjectV1: " + e.Message );
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
 **ezsignsignergroupmembershipCreateObjectV1Request** | [**EzsignsignergroupmembershipCreateObjectV1Request**](EzsignsignergroupmembershipCreateObjectV1Request.md)|  | 

### Return type

[**EzsignsignergroupmembershipCreateObjectV1Response**](EzsignsignergroupmembershipCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignsignergroupmembershipDeleteObjectV1

> EzsignsignergroupmembershipDeleteObjectV1Response EzsignsignergroupmembershipDeleteObjectV1 (int pkiEzsignsignergroupmembershipID)

Delete an existing Ezsignsignergroupmembership

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignsignergroupmembershipDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsignergroupmembershipApi(Configuration.Default);
            var pkiEzsignsignergroupmembershipID = 56;  // int | The unique ID of the Ezsignsignergroupmembership

            try
            {
                // Delete an existing Ezsignsignergroupmembership
                EzsignsignergroupmembershipDeleteObjectV1Response result = apiInstance.EzsignsignergroupmembershipDeleteObjectV1(pkiEzsignsignergroupmembershipID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignsignergroupmembershipApi.EzsignsignergroupmembershipDeleteObjectV1: " + e.Message );
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
 **pkiEzsignsignergroupmembershipID** | **int**| The unique ID of the Ezsignsignergroupmembership | 

### Return type

[**EzsignsignergroupmembershipDeleteObjectV1Response**](EzsignsignergroupmembershipDeleteObjectV1Response.md)

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


## EzsignsignergroupmembershipGetObjectV2

> EzsignsignergroupmembershipGetObjectV2Response EzsignsignergroupmembershipGetObjectV2 (int pkiEzsignsignergroupmembershipID)

Retrieve an existing Ezsignsignergroupmembership

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignsignergroupmembershipGetObjectV2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsignergroupmembershipApi(Configuration.Default);
            var pkiEzsignsignergroupmembershipID = 56;  // int | The unique ID of the Ezsignsignergroupmembership

            try
            {
                // Retrieve an existing Ezsignsignergroupmembership
                EzsignsignergroupmembershipGetObjectV2Response result = apiInstance.EzsignsignergroupmembershipGetObjectV2(pkiEzsignsignergroupmembershipID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignsignergroupmembershipApi.EzsignsignergroupmembershipGetObjectV2: " + e.Message );
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
 **pkiEzsignsignergroupmembershipID** | **int**| The unique ID of the Ezsignsignergroupmembership | 

### Return type

[**EzsignsignergroupmembershipGetObjectV2Response**](EzsignsignergroupmembershipGetObjectV2Response.md)

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


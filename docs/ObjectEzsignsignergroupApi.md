# eZmaxApi.Api.ObjectEzsignsignergroupApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EzsignsignergroupCreateObjectV1**](ObjectEzsignsignergroupApi.md#ezsignsignergroupcreateobjectv1) | **POST** /1/object/ezsignsignergroup | Create a new Ezsignsignergroup
[**EzsignsignergroupDeleteObjectV1**](ObjectEzsignsignergroupApi.md#ezsignsignergroupdeleteobjectv1) | **DELETE** /1/object/ezsignsignergroup/{pkiEzsignsignergroupID} | Delete an existing Ezsignsignergroup
[**EzsignsignergroupEditEzsignsignergroupmembershipsV1**](ObjectEzsignsignergroupApi.md#ezsignsignergroupeditezsignsignergroupmembershipsv1) | **PUT** /1/object/ezsignsignergroup/{pkiEzsignsignergroupID}/editEzsignsignergroupmemberships | Edit multiple Ezsignsignergroupmemberships
[**EzsignsignergroupEditObjectV1**](ObjectEzsignsignergroupApi.md#ezsignsignergroupeditobjectv1) | **PUT** /1/object/ezsignsignergroup/{pkiEzsignsignergroupID} | Edit an existing Ezsignsignergroup
[**EzsignsignergroupGetEzsignsignergroupmembershipsV1**](ObjectEzsignsignergroupApi.md#ezsignsignergroupgetezsignsignergroupmembershipsv1) | **GET** /1/object/ezsignsignergroup/{pkiEzsignsignergroupID}/getEzsignsignergroupmemberships | Retrieve an existing Ezsignsignergroup&#39;s Ezsignsignergroupmemberships
[**EzsignsignergroupGetObjectV2**](ObjectEzsignsignergroupApi.md#ezsignsignergroupgetobjectv2) | **GET** /2/object/ezsignsignergroup/{pkiEzsignsignergroupID} | Retrieve an existing Ezsignsignergroup



## EzsignsignergroupCreateObjectV1

> EzsignsignergroupCreateObjectV1Response EzsignsignergroupCreateObjectV1 (EzsignsignergroupCreateObjectV1Request ezsignsignergroupCreateObjectV1Request)

Create a new Ezsignsignergroup

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
    public class EzsignsignergroupCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsignergroupApi(Configuration.Default);
            var ezsignsignergroupCreateObjectV1Request = new EzsignsignergroupCreateObjectV1Request(); // EzsignsignergroupCreateObjectV1Request | 

            try
            {
                // Create a new Ezsignsignergroup
                EzsignsignergroupCreateObjectV1Response result = apiInstance.EzsignsignergroupCreateObjectV1(ezsignsignergroupCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignsignergroupApi.EzsignsignergroupCreateObjectV1: " + e.Message );
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
 **ezsignsignergroupCreateObjectV1Request** | [**EzsignsignergroupCreateObjectV1Request**](EzsignsignergroupCreateObjectV1Request.md)|  | 

### Return type

[**EzsignsignergroupCreateObjectV1Response**](EzsignsignergroupCreateObjectV1Response.md)

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


## EzsignsignergroupDeleteObjectV1

> EzsignsignergroupDeleteObjectV1Response EzsignsignergroupDeleteObjectV1 (int pkiEzsignsignergroupID)

Delete an existing Ezsignsignergroup

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignsignergroupDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsignergroupApi(Configuration.Default);
            var pkiEzsignsignergroupID = 56;  // int | The unique ID of the Ezsignsignergroup

            try
            {
                // Delete an existing Ezsignsignergroup
                EzsignsignergroupDeleteObjectV1Response result = apiInstance.EzsignsignergroupDeleteObjectV1(pkiEzsignsignergroupID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignsignergroupApi.EzsignsignergroupDeleteObjectV1: " + e.Message );
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
 **pkiEzsignsignergroupID** | **int**| The unique ID of the Ezsignsignergroup | 

### Return type

[**EzsignsignergroupDeleteObjectV1Response**](EzsignsignergroupDeleteObjectV1Response.md)

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


## EzsignsignergroupEditEzsignsignergroupmembershipsV1

> EzsignsignergroupEditEzsignsignergroupmembershipsV1Response EzsignsignergroupEditEzsignsignergroupmembershipsV1 (int pkiEzsignsignergroupID, EzsignsignergroupEditEzsignsignergroupmembershipsV1Request ezsignsignergroupEditEzsignsignergroupmembershipsV1Request)

Edit multiple Ezsignsignergroupmemberships

Using this endpoint, you can edit multiple Ezsignsignergroupmemberships at the same time.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignsignergroupEditEzsignsignergroupmembershipsV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsignergroupApi(Configuration.Default);
            var pkiEzsignsignergroupID = 56;  // int | 
            var ezsignsignergroupEditEzsignsignergroupmembershipsV1Request = new EzsignsignergroupEditEzsignsignergroupmembershipsV1Request(); // EzsignsignergroupEditEzsignsignergroupmembershipsV1Request | 

            try
            {
                // Edit multiple Ezsignsignergroupmemberships
                EzsignsignergroupEditEzsignsignergroupmembershipsV1Response result = apiInstance.EzsignsignergroupEditEzsignsignergroupmembershipsV1(pkiEzsignsignergroupID, ezsignsignergroupEditEzsignsignergroupmembershipsV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignsignergroupApi.EzsignsignergroupEditEzsignsignergroupmembershipsV1: " + e.Message );
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
 **pkiEzsignsignergroupID** | **int**|  | 
 **ezsignsignergroupEditEzsignsignergroupmembershipsV1Request** | [**EzsignsignergroupEditEzsignsignergroupmembershipsV1Request**](EzsignsignergroupEditEzsignsignergroupmembershipsV1Request.md)|  | 

### Return type

[**EzsignsignergroupEditEzsignsignergroupmembershipsV1Response**](EzsignsignergroupEditEzsignsignergroupmembershipsV1Response.md)

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


## EzsignsignergroupEditObjectV1

> EzsignsignergroupEditObjectV1Response EzsignsignergroupEditObjectV1 (int pkiEzsignsignergroupID, EzsignsignergroupEditObjectV1Request ezsignsignergroupEditObjectV1Request)

Edit an existing Ezsignsignergroup

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignsignergroupEditObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsignergroupApi(Configuration.Default);
            var pkiEzsignsignergroupID = 56;  // int | The unique ID of the Ezsignsignergroup
            var ezsignsignergroupEditObjectV1Request = new EzsignsignergroupEditObjectV1Request(); // EzsignsignergroupEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsignsignergroup
                EzsignsignergroupEditObjectV1Response result = apiInstance.EzsignsignergroupEditObjectV1(pkiEzsignsignergroupID, ezsignsignergroupEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignsignergroupApi.EzsignsignergroupEditObjectV1: " + e.Message );
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
 **pkiEzsignsignergroupID** | **int**| The unique ID of the Ezsignsignergroup | 
 **ezsignsignergroupEditObjectV1Request** | [**EzsignsignergroupEditObjectV1Request**](EzsignsignergroupEditObjectV1Request.md)|  | 

### Return type

[**EzsignsignergroupEditObjectV1Response**](EzsignsignergroupEditObjectV1Response.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignsignergroupGetEzsignsignergroupmembershipsV1

> EzsignsignergroupGetEzsignsignergroupmembershipsV1Response EzsignsignergroupGetEzsignsignergroupmembershipsV1 (int pkiEzsignsignergroupID)

Retrieve an existing Ezsignsignergroup's Ezsignsignergroupmemberships

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignsignergroupGetEzsignsignergroupmembershipsV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsignergroupApi(Configuration.Default);
            var pkiEzsignsignergroupID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignsignergroup's Ezsignsignergroupmemberships
                EzsignsignergroupGetEzsignsignergroupmembershipsV1Response result = apiInstance.EzsignsignergroupGetEzsignsignergroupmembershipsV1(pkiEzsignsignergroupID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignsignergroupApi.EzsignsignergroupGetEzsignsignergroupmembershipsV1: " + e.Message );
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
 **pkiEzsignsignergroupID** | **int**|  | 

### Return type

[**EzsignsignergroupGetEzsignsignergroupmembershipsV1Response**](EzsignsignergroupGetEzsignsignergroupmembershipsV1Response.md)

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


## EzsignsignergroupGetObjectV2

> EzsignsignergroupGetObjectV2Response EzsignsignergroupGetObjectV2 (int pkiEzsignsignergroupID)

Retrieve an existing Ezsignsignergroup

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignsignergroupGetObjectV2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignsignergroupApi(Configuration.Default);
            var pkiEzsignsignergroupID = 56;  // int | The unique ID of the Ezsignsignergroup

            try
            {
                // Retrieve an existing Ezsignsignergroup
                EzsignsignergroupGetObjectV2Response result = apiInstance.EzsignsignergroupGetObjectV2(pkiEzsignsignergroupID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignsignergroupApi.EzsignsignergroupGetObjectV2: " + e.Message );
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
 **pkiEzsignsignergroupID** | **int**| The unique ID of the Ezsignsignergroup | 

### Return type

[**EzsignsignergroupGetObjectV2Response**](EzsignsignergroupGetObjectV2Response.md)

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


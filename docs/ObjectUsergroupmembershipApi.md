# eZmaxApi.Api.ObjectUsergroupmembershipApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsergroupmembershipCreateObjectV1**](ObjectUsergroupmembershipApi.md#usergroupmembershipcreateobjectv1) | **POST** /1/object/usergroupmembership | Create a new Usergroupmembership
[**UsergroupmembershipDeleteObjectV1**](ObjectUsergroupmembershipApi.md#usergroupmembershipdeleteobjectv1) | **DELETE** /1/object/usergroupmembership/{pkiUsergroupmembershipID} | Delete an existing Usergroupmembership
[**UsergroupmembershipEditObjectV1**](ObjectUsergroupmembershipApi.md#usergroupmembershipeditobjectv1) | **PUT** /1/object/usergroupmembership/{pkiUsergroupmembershipID} | Edit an existing Usergroupmembership
[**UsergroupmembershipGetObjectV2**](ObjectUsergroupmembershipApi.md#usergroupmembershipgetobjectv2) | **GET** /2/object/usergroupmembership/{pkiUsergroupmembershipID} | Retrieve an existing Usergroupmembership



## UsergroupmembershipCreateObjectV1

> UsergroupmembershipCreateObjectV1Response UsergroupmembershipCreateObjectV1 (UsergroupmembershipCreateObjectV1Request usergroupmembershipCreateObjectV1Request)

Create a new Usergroupmembership

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
    public class UsergroupmembershipCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUsergroupmembershipApi(Configuration.Default);
            var usergroupmembershipCreateObjectV1Request = new UsergroupmembershipCreateObjectV1Request(); // UsergroupmembershipCreateObjectV1Request | 

            try
            {
                // Create a new Usergroupmembership
                UsergroupmembershipCreateObjectV1Response result = apiInstance.UsergroupmembershipCreateObjectV1(usergroupmembershipCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectUsergroupmembershipApi.UsergroupmembershipCreateObjectV1: " + e.Message );
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
 **usergroupmembershipCreateObjectV1Request** | [**UsergroupmembershipCreateObjectV1Request**](UsergroupmembershipCreateObjectV1Request.md)|  | 

### Return type

[**UsergroupmembershipCreateObjectV1Response**](UsergroupmembershipCreateObjectV1Response.md)

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


## UsergroupmembershipDeleteObjectV1

> UsergroupmembershipDeleteObjectV1Response UsergroupmembershipDeleteObjectV1 (int pkiUsergroupmembershipID)

Delete an existing Usergroupmembership

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsergroupmembershipDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUsergroupmembershipApi(Configuration.Default);
            var pkiUsergroupmembershipID = 56;  // int | 

            try
            {
                // Delete an existing Usergroupmembership
                UsergroupmembershipDeleteObjectV1Response result = apiInstance.UsergroupmembershipDeleteObjectV1(pkiUsergroupmembershipID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectUsergroupmembershipApi.UsergroupmembershipDeleteObjectV1: " + e.Message );
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
 **pkiUsergroupmembershipID** | **int**|  | 

### Return type

[**UsergroupmembershipDeleteObjectV1Response**](UsergroupmembershipDeleteObjectV1Response.md)

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


## UsergroupmembershipEditObjectV1

> UsergroupmembershipEditObjectV1Response UsergroupmembershipEditObjectV1 (int pkiUsergroupmembershipID, UsergroupmembershipEditObjectV1Request usergroupmembershipEditObjectV1Request)

Edit an existing Usergroupmembership

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsergroupmembershipEditObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUsergroupmembershipApi(Configuration.Default);
            var pkiUsergroupmembershipID = 56;  // int | 
            var usergroupmembershipEditObjectV1Request = new UsergroupmembershipEditObjectV1Request(); // UsergroupmembershipEditObjectV1Request | 

            try
            {
                // Edit an existing Usergroupmembership
                UsergroupmembershipEditObjectV1Response result = apiInstance.UsergroupmembershipEditObjectV1(pkiUsergroupmembershipID, usergroupmembershipEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectUsergroupmembershipApi.UsergroupmembershipEditObjectV1: " + e.Message );
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
 **pkiUsergroupmembershipID** | **int**|  | 
 **usergroupmembershipEditObjectV1Request** | [**UsergroupmembershipEditObjectV1Request**](UsergroupmembershipEditObjectV1Request.md)|  | 

### Return type

[**UsergroupmembershipEditObjectV1Response**](UsergroupmembershipEditObjectV1Response.md)

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


## UsergroupmembershipGetObjectV2

> UsergroupmembershipGetObjectV2Response UsergroupmembershipGetObjectV2 (int pkiUsergroupmembershipID)

Retrieve an existing Usergroupmembership

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UsergroupmembershipGetObjectV2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectUsergroupmembershipApi(Configuration.Default);
            var pkiUsergroupmembershipID = 56;  // int | 

            try
            {
                // Retrieve an existing Usergroupmembership
                UsergroupmembershipGetObjectV2Response result = apiInstance.UsergroupmembershipGetObjectV2(pkiUsergroupmembershipID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectUsergroupmembershipApi.UsergroupmembershipGetObjectV2: " + e.Message );
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
 **pkiUsergroupmembershipID** | **int**|  | 

### Return type

[**UsergroupmembershipGetObjectV2Response**](UsergroupmembershipGetObjectV2Response.md)

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


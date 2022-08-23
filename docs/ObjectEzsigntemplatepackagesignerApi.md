# eZmaxApi.Api.ObjectEzsigntemplatepackagesignerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EzsigntemplatepackagesignerCreateObjectV1**](ObjectEzsigntemplatepackagesignerApi.md#ezsigntemplatepackagesignercreateobjectv1) | **POST** /1/object/ezsigntemplatepackagesigner | Create a new Ezsigntemplatepackagesigner
[**EzsigntemplatepackagesignerDeleteObjectV1**](ObjectEzsigntemplatepackagesignerApi.md#ezsigntemplatepackagesignerdeleteobjectv1) | **DELETE** /1/object/ezsigntemplatepackagesigner/{pkiEzsigntemplatepackagesignerID} | Delete an existing Ezsigntemplatepackagesigner
[**EzsigntemplatepackagesignerEditObjectV1**](ObjectEzsigntemplatepackagesignerApi.md#ezsigntemplatepackagesignereditobjectv1) | **PUT** /1/object/ezsigntemplatepackagesigner/{pkiEzsigntemplatepackagesignerID} | Edit an existing Ezsigntemplatepackagesigner
[**EzsigntemplatepackagesignerGetObjectV1**](ObjectEzsigntemplatepackagesignerApi.md#ezsigntemplatepackagesignergetobjectv1) | **GET** /1/object/ezsigntemplatepackagesigner/{pkiEzsigntemplatepackagesignerID} | Retrieve an existing Ezsigntemplatepackagesigner



## EzsigntemplatepackagesignerCreateObjectV1

> EzsigntemplatepackagesignerCreateObjectV1Response EzsigntemplatepackagesignerCreateObjectV1 (EzsigntemplatepackagesignerCreateObjectV1Request ezsigntemplatepackagesignerCreateObjectV1Request)

Create a new Ezsigntemplatepackagesigner

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
    public class EzsigntemplatepackagesignerCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepackagesignerApi(Configuration.Default);
            var ezsigntemplatepackagesignerCreateObjectV1Request = new EzsigntemplatepackagesignerCreateObjectV1Request(); // EzsigntemplatepackagesignerCreateObjectV1Request | 

            try
            {
                // Create a new Ezsigntemplatepackagesigner
                EzsigntemplatepackagesignerCreateObjectV1Response result = apiInstance.EzsigntemplatepackagesignerCreateObjectV1(ezsigntemplatepackagesignerCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepackagesignerApi.EzsigntemplatepackagesignerCreateObjectV1: " + e.Message );
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
 **ezsigntemplatepackagesignerCreateObjectV1Request** | [**EzsigntemplatepackagesignerCreateObjectV1Request**](EzsigntemplatepackagesignerCreateObjectV1Request.md)|  | 

### Return type

[**EzsigntemplatepackagesignerCreateObjectV1Response**](EzsigntemplatepackagesignerCreateObjectV1Response.md)

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


## EzsigntemplatepackagesignerDeleteObjectV1

> EzsigntemplatepackagesignerDeleteObjectV1Response EzsigntemplatepackagesignerDeleteObjectV1 (int pkiEzsigntemplatepackagesignerID)

Delete an existing Ezsigntemplatepackagesigner

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepackagesignerDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepackagesignerApi(Configuration.Default);
            var pkiEzsigntemplatepackagesignerID = 56;  // int | 

            try
            {
                // Delete an existing Ezsigntemplatepackagesigner
                EzsigntemplatepackagesignerDeleteObjectV1Response result = apiInstance.EzsigntemplatepackagesignerDeleteObjectV1(pkiEzsigntemplatepackagesignerID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepackagesignerApi.EzsigntemplatepackagesignerDeleteObjectV1: " + e.Message );
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
 **pkiEzsigntemplatepackagesignerID** | **int**|  | 

### Return type

[**EzsigntemplatepackagesignerDeleteObjectV1Response**](EzsigntemplatepackagesignerDeleteObjectV1Response.md)

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


## EzsigntemplatepackagesignerEditObjectV1

> EzsigntemplatepackagesignerEditObjectV1Response EzsigntemplatepackagesignerEditObjectV1 (int pkiEzsigntemplatepackagesignerID, EzsigntemplatepackagesignerEditObjectV1Request ezsigntemplatepackagesignerEditObjectV1Request)

Edit an existing Ezsigntemplatepackagesigner

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepackagesignerEditObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepackagesignerApi(Configuration.Default);
            var pkiEzsigntemplatepackagesignerID = 56;  // int | 
            var ezsigntemplatepackagesignerEditObjectV1Request = new EzsigntemplatepackagesignerEditObjectV1Request(); // EzsigntemplatepackagesignerEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsigntemplatepackagesigner
                EzsigntemplatepackagesignerEditObjectV1Response result = apiInstance.EzsigntemplatepackagesignerEditObjectV1(pkiEzsigntemplatepackagesignerID, ezsigntemplatepackagesignerEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepackagesignerApi.EzsigntemplatepackagesignerEditObjectV1: " + e.Message );
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
 **pkiEzsigntemplatepackagesignerID** | **int**|  | 
 **ezsigntemplatepackagesignerEditObjectV1Request** | [**EzsigntemplatepackagesignerEditObjectV1Request**](EzsigntemplatepackagesignerEditObjectV1Request.md)|  | 

### Return type

[**EzsigntemplatepackagesignerEditObjectV1Response**](EzsigntemplatepackagesignerEditObjectV1Response.md)

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


## EzsigntemplatepackagesignerGetObjectV1

> EzsigntemplatepackagesignerGetObjectV1Response EzsigntemplatepackagesignerGetObjectV1 (int pkiEzsigntemplatepackagesignerID)

Retrieve an existing Ezsigntemplatepackagesigner

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepackagesignerGetObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepackagesignerApi(Configuration.Default);
            var pkiEzsigntemplatepackagesignerID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplatepackagesigner
                EzsigntemplatepackagesignerGetObjectV1Response result = apiInstance.EzsigntemplatepackagesignerGetObjectV1(pkiEzsigntemplatepackagesignerID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepackagesignerApi.EzsigntemplatepackagesignerGetObjectV1: " + e.Message );
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
 **pkiEzsigntemplatepackagesignerID** | **int**|  | 

### Return type

[**EzsigntemplatepackagesignerGetObjectV1Response**](EzsigntemplatepackagesignerGetObjectV1Response.md)

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


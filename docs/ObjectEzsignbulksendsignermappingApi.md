# eZmaxApi.Api.ObjectEzsignbulksendsignermappingApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EzsignbulksendsignermappingCreateObjectV1**](ObjectEzsignbulksendsignermappingApi.md#ezsignbulksendsignermappingcreateobjectv1) | **POST** /1/object/ezsignbulksendsignermapping | Create a new Ezsignbulksendsignermapping
[**EzsignbulksendsignermappingDeleteObjectV1**](ObjectEzsignbulksendsignermappingApi.md#ezsignbulksendsignermappingdeleteobjectv1) | **DELETE** /1/object/ezsignbulksendsignermapping/{pkiEzsignbulksendsignermappingID} | Delete an existing Ezsignbulksendsignermapping
[**EzsignbulksendsignermappingGetObjectV1**](ObjectEzsignbulksendsignermappingApi.md#ezsignbulksendsignermappinggetobjectv1) | **GET** /1/object/ezsignbulksendsignermapping/{pkiEzsignbulksendsignermappingID} | Retrieve an existing Ezsignbulksendsignermapping



## EzsignbulksendsignermappingCreateObjectV1

> EzsignbulksendsignermappingCreateObjectV1Response EzsignbulksendsignermappingCreateObjectV1 (EzsignbulksendsignermappingCreateObjectV1Request ezsignbulksendsignermappingCreateObjectV1Request)

Create a new Ezsignbulksendsignermapping

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
    public class EzsignbulksendsignermappingCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendsignermappingApi(Configuration.Default);
            var ezsignbulksendsignermappingCreateObjectV1Request = new EzsignbulksendsignermappingCreateObjectV1Request(); // EzsignbulksendsignermappingCreateObjectV1Request | 

            try
            {
                // Create a new Ezsignbulksendsignermapping
                EzsignbulksendsignermappingCreateObjectV1Response result = apiInstance.EzsignbulksendsignermappingCreateObjectV1(ezsignbulksendsignermappingCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendsignermappingApi.EzsignbulksendsignermappingCreateObjectV1: " + e.Message );
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
 **ezsignbulksendsignermappingCreateObjectV1Request** | [**EzsignbulksendsignermappingCreateObjectV1Request**](EzsignbulksendsignermappingCreateObjectV1Request.md)|  | 

### Return type

[**EzsignbulksendsignermappingCreateObjectV1Response**](EzsignbulksendsignermappingCreateObjectV1Response.md)

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


## EzsignbulksendsignermappingDeleteObjectV1

> EzsignbulksendsignermappingDeleteObjectV1Response EzsignbulksendsignermappingDeleteObjectV1 (int pkiEzsignbulksendsignermappingID)

Delete an existing Ezsignbulksendsignermapping

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendsignermappingDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendsignermappingApi(Configuration.Default);
            var pkiEzsignbulksendsignermappingID = 56;  // int | 

            try
            {
                // Delete an existing Ezsignbulksendsignermapping
                EzsignbulksendsignermappingDeleteObjectV1Response result = apiInstance.EzsignbulksendsignermappingDeleteObjectV1(pkiEzsignbulksendsignermappingID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendsignermappingApi.EzsignbulksendsignermappingDeleteObjectV1: " + e.Message );
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
 **pkiEzsignbulksendsignermappingID** | **int**|  | 

### Return type

[**EzsignbulksendsignermappingDeleteObjectV1Response**](EzsignbulksendsignermappingDeleteObjectV1Response.md)

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


## EzsignbulksendsignermappingGetObjectV1

> EzsignbulksendsignermappingGetObjectV1Response EzsignbulksendsignermappingGetObjectV1 (int pkiEzsignbulksendsignermappingID)

Retrieve an existing Ezsignbulksendsignermapping

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksendsignermappingGetObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksendsignermappingApi(Configuration.Default);
            var pkiEzsignbulksendsignermappingID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignbulksendsignermapping
                EzsignbulksendsignermappingGetObjectV1Response result = apiInstance.EzsignbulksendsignermappingGetObjectV1(pkiEzsignbulksendsignermappingID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksendsignermappingApi.EzsignbulksendsignermappingGetObjectV1: " + e.Message );
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
 **pkiEzsignbulksendsignermappingID** | **int**|  | 

### Return type

[**EzsignbulksendsignermappingGetObjectV1Response**](EzsignbulksendsignermappingGetObjectV1Response.md)

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


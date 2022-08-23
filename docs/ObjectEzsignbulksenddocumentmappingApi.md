# eZmaxApi.Api.ObjectEzsignbulksenddocumentmappingApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EzsignbulksenddocumentmappingCreateObjectV1**](ObjectEzsignbulksenddocumentmappingApi.md#ezsignbulksenddocumentmappingcreateobjectv1) | **POST** /1/object/ezsignbulksenddocumentmapping | Create a new Ezsignbulksenddocumentmapping
[**EzsignbulksenddocumentmappingDeleteObjectV1**](ObjectEzsignbulksenddocumentmappingApi.md#ezsignbulksenddocumentmappingdeleteobjectv1) | **DELETE** /1/object/ezsignbulksenddocumentmapping/{pkiEzsignbulksenddocumentmappingID} | Delete an existing Ezsignbulksenddocumentmapping
[**EzsignbulksenddocumentmappingGetObjectV1**](ObjectEzsignbulksenddocumentmappingApi.md#ezsignbulksenddocumentmappinggetobjectv1) | **GET** /1/object/ezsignbulksenddocumentmapping/{pkiEzsignbulksenddocumentmappingID} | Retrieve an existing Ezsignbulksenddocumentmapping



## EzsignbulksenddocumentmappingCreateObjectV1

> EzsignbulksenddocumentmappingCreateObjectV1Response EzsignbulksenddocumentmappingCreateObjectV1 (EzsignbulksenddocumentmappingCreateObjectV1Request ezsignbulksenddocumentmappingCreateObjectV1Request)

Create a new Ezsignbulksenddocumentmapping

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
    public class EzsignbulksenddocumentmappingCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksenddocumentmappingApi(Configuration.Default);
            var ezsignbulksenddocumentmappingCreateObjectV1Request = new EzsignbulksenddocumentmappingCreateObjectV1Request(); // EzsignbulksenddocumentmappingCreateObjectV1Request | 

            try
            {
                // Create a new Ezsignbulksenddocumentmapping
                EzsignbulksenddocumentmappingCreateObjectV1Response result = apiInstance.EzsignbulksenddocumentmappingCreateObjectV1(ezsignbulksenddocumentmappingCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksenddocumentmappingApi.EzsignbulksenddocumentmappingCreateObjectV1: " + e.Message );
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
 **ezsignbulksenddocumentmappingCreateObjectV1Request** | [**EzsignbulksenddocumentmappingCreateObjectV1Request**](EzsignbulksenddocumentmappingCreateObjectV1Request.md)|  | 

### Return type

[**EzsignbulksenddocumentmappingCreateObjectV1Response**](EzsignbulksenddocumentmappingCreateObjectV1Response.md)

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


## EzsignbulksenddocumentmappingDeleteObjectV1

> EzsignbulksenddocumentmappingDeleteObjectV1Response EzsignbulksenddocumentmappingDeleteObjectV1 (int pkiEzsignbulksenddocumentmappingID)

Delete an existing Ezsignbulksenddocumentmapping

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksenddocumentmappingDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksenddocumentmappingApi(Configuration.Default);
            var pkiEzsignbulksenddocumentmappingID = 56;  // int | 

            try
            {
                // Delete an existing Ezsignbulksenddocumentmapping
                EzsignbulksenddocumentmappingDeleteObjectV1Response result = apiInstance.EzsignbulksenddocumentmappingDeleteObjectV1(pkiEzsignbulksenddocumentmappingID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksenddocumentmappingApi.EzsignbulksenddocumentmappingDeleteObjectV1: " + e.Message );
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
 **pkiEzsignbulksenddocumentmappingID** | **int**|  | 

### Return type

[**EzsignbulksenddocumentmappingDeleteObjectV1Response**](EzsignbulksenddocumentmappingDeleteObjectV1Response.md)

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


## EzsignbulksenddocumentmappingGetObjectV1

> EzsignbulksenddocumentmappingGetObjectV1Response EzsignbulksenddocumentmappingGetObjectV1 (int pkiEzsignbulksenddocumentmappingID)

Retrieve an existing Ezsignbulksenddocumentmapping

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignbulksenddocumentmappingGetObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignbulksenddocumentmappingApi(Configuration.Default);
            var pkiEzsignbulksenddocumentmappingID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignbulksenddocumentmapping
                EzsignbulksenddocumentmappingGetObjectV1Response result = apiInstance.EzsignbulksenddocumentmappingGetObjectV1(pkiEzsignbulksenddocumentmappingID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignbulksenddocumentmappingApi.EzsignbulksenddocumentmappingGetObjectV1: " + e.Message );
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
 **pkiEzsignbulksenddocumentmappingID** | **int**|  | 

### Return type

[**EzsignbulksenddocumentmappingGetObjectV1Response**](EzsignbulksenddocumentmappingGetObjectV1Response.md)

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


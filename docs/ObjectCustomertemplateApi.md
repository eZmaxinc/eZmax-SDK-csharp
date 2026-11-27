# eZmaxApi.Api.ObjectCustomertemplateApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CustomertemplateGetDocumenttypechecklistV1**](ObjectCustomertemplateApi.md#customertemplategetdocumenttypechecklistv1) | **GET** /1/object/customertemplate/{pkiCustomertemplateID}/getDocumenttypechecklist | Retrieve Document type checklist |
| [**CustomertemplateSyncDocumenttypechecklistV1**](ObjectCustomertemplateApi.md#customertemplatesyncdocumenttypechecklistv1) | **POST** /1/object/customertemplate/{pkiCustomertemplateID}/syncDocumenttypechecklist | Synchronize Document type checklist |

<a id="customertemplategetdocumenttypechecklistv1"></a>
# **CustomertemplateGetDocumenttypechecklistV1**
> CustomertemplateGetDocumenttypechecklistV1Response CustomertemplateGetDocumenttypechecklistV1 (int pkiCustomertemplateID)

Retrieve Document type checklist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class CustomertemplateGetDocumenttypechecklistV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectCustomertemplateApi(config);
            var pkiCustomertemplateID = 56;  // int | 

            try
            {
                // Retrieve Document type checklist
                CustomertemplateGetDocumenttypechecklistV1Response result = apiInstance.CustomertemplateGetDocumenttypechecklistV1(pkiCustomertemplateID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectCustomertemplateApi.CustomertemplateGetDocumenttypechecklistV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomertemplateGetDocumenttypechecklistV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Document type checklist
    ApiResponse<CustomertemplateGetDocumenttypechecklistV1Response> response = apiInstance.CustomertemplateGetDocumenttypechecklistV1WithHttpInfo(pkiCustomertemplateID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectCustomertemplateApi.CustomertemplateGetDocumenttypechecklistV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCustomertemplateID** | **int** |  |  |

### Return type

[**CustomertemplateGetDocumenttypechecklistV1Response**](CustomertemplateGetDocumenttypechecklistV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="customertemplatesyncdocumenttypechecklistv1"></a>
# **CustomertemplateSyncDocumenttypechecklistV1**
> CustomertemplateSyncDocumenttypechecklistV1Response CustomertemplateSyncDocumenttypechecklistV1 (int pkiCustomertemplateID, Object? body = null)

Synchronize Document type checklist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class CustomertemplateSyncDocumenttypechecklistV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectCustomertemplateApi(config);
            var pkiCustomertemplateID = 56;  // int | 
            var body = null;  // Object? |  (optional) 

            try
            {
                // Synchronize Document type checklist
                CustomertemplateSyncDocumenttypechecklistV1Response result = apiInstance.CustomertemplateSyncDocumenttypechecklistV1(pkiCustomertemplateID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectCustomertemplateApi.CustomertemplateSyncDocumenttypechecklistV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomertemplateSyncDocumenttypechecklistV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Synchronize Document type checklist
    ApiResponse<CustomertemplateSyncDocumenttypechecklistV1Response> response = apiInstance.CustomertemplateSyncDocumenttypechecklistV1WithHttpInfo(pkiCustomertemplateID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectCustomertemplateApi.CustomertemplateSyncDocumenttypechecklistV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCustomertemplateID** | **int** |  |  |
| **body** | **Object?** |  | [optional]  |

### Return type

[**CustomertemplateSyncDocumenttypechecklistV1Response**](CustomertemplateSyncDocumenttypechecklistV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


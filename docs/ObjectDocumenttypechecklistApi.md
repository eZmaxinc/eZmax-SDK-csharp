# eZmaxApi.Api.ObjectDocumenttypechecklistApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DocumenttypechecklistDeleteObjectV1**](ObjectDocumenttypechecklistApi.md#documenttypechecklistdeleteobjectv1) | **DELETE** /1/object/documenttypechecklist/{pkiDocumenttypechecklistID} | Delete an existing Documenttypechecklist |
| [**DocumenttypechecklistPatchObjectV1**](ObjectDocumenttypechecklistApi.md#documenttypechecklistpatchobjectv1) | **PATCH** /1/object/documenttypechecklist/{pkiDocumenttypechecklistID} | Patch an existing Documenttypechecklist |

<a id="documenttypechecklistdeleteobjectv1"></a>
# **DocumenttypechecklistDeleteObjectV1**
> DocumenttypechecklistDeleteObjectV1Response DocumenttypechecklistDeleteObjectV1 (int pkiDocumenttypechecklistID)

Delete an existing Documenttypechecklist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DocumenttypechecklistDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDocumenttypechecklistApi(config);
            var pkiDocumenttypechecklistID = 56;  // int | The unique ID of the Documenttypechecklist

            try
            {
                // Delete an existing Documenttypechecklist
                DocumenttypechecklistDeleteObjectV1Response result = apiInstance.DocumenttypechecklistDeleteObjectV1(pkiDocumenttypechecklistID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumenttypechecklistDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Documenttypechecklist
    ApiResponse<DocumenttypechecklistDeleteObjectV1Response> response = apiInstance.DocumenttypechecklistDeleteObjectV1WithHttpInfo(pkiDocumenttypechecklistID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDocumenttypechecklistID** | **int** | The unique ID of the Documenttypechecklist |  |

### Return type

[**DocumenttypechecklistDeleteObjectV1Response**](DocumenttypechecklistDeleteObjectV1Response.md)

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

<a id="documenttypechecklistpatchobjectv1"></a>
# **DocumenttypechecklistPatchObjectV1**
> DocumenttypechecklistPatchObjectV1Response DocumenttypechecklistPatchObjectV1 (int pkiDocumenttypechecklistID, DocumenttypechecklistPatchObjectV1Request documenttypechecklistPatchObjectV1Request)

Patch an existing Documenttypechecklist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DocumenttypechecklistPatchObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDocumenttypechecklistApi(config);
            var pkiDocumenttypechecklistID = 56;  // int | The unique ID of the Documenttypechecklist
            var documenttypechecklistPatchObjectV1Request = new DocumenttypechecklistPatchObjectV1Request(); // DocumenttypechecklistPatchObjectV1Request | 

            try
            {
                // Patch an existing Documenttypechecklist
                DocumenttypechecklistPatchObjectV1Response result = apiInstance.DocumenttypechecklistPatchObjectV1(pkiDocumenttypechecklistID, documenttypechecklistPatchObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistPatchObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumenttypechecklistPatchObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patch an existing Documenttypechecklist
    ApiResponse<DocumenttypechecklistPatchObjectV1Response> response = apiInstance.DocumenttypechecklistPatchObjectV1WithHttpInfo(pkiDocumenttypechecklistID, documenttypechecklistPatchObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDocumenttypechecklistApi.DocumenttypechecklistPatchObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDocumenttypechecklistID** | **int** | The unique ID of the Documenttypechecklist |  |
| **documenttypechecklistPatchObjectV1Request** | [**DocumenttypechecklistPatchObjectV1Request**](DocumenttypechecklistPatchObjectV1Request.md) |  |  |

### Return type

[**DocumenttypechecklistPatchObjectV1Response**](DocumenttypechecklistPatchObjectV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# eZmaxApi.Api.ObjectEzsignfolderApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignfolderArchiveV1**](ObjectEzsignfolderApi.md#ezsignfolderarchivev1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/archive | Archive the Ezsignfolder |
| [**EzsignfolderBatchDownloadV1**](ObjectEzsignfolderApi.md#ezsignfolderbatchdownloadv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/batchDownload | Download multiples files from an Ezsignfolder |
| [**EzsignfolderCreateObjectV1**](ObjectEzsignfolderApi.md#ezsignfoldercreateobjectv1) | **POST** /1/object/ezsignfolder | Create a new Ezsignfolder |
| [**EzsignfolderCreateObjectV2**](ObjectEzsignfolderApi.md#ezsignfoldercreateobjectv2) | **POST** /2/object/ezsignfolder | Create a new Ezsignfolder |
| [**EzsignfolderCreateObjectV3**](ObjectEzsignfolderApi.md#ezsignfoldercreateobjectv3) | **POST** /3/object/ezsignfolder | Create a new Ezsignfolder |
| [**EzsignfolderDeleteObjectV1**](ObjectEzsignfolderApi.md#ezsignfolderdeleteobjectv1) | **DELETE** /1/object/ezsignfolder/{pkiEzsignfolderID} | Delete an existing Ezsignfolder |
| [**EzsignfolderDisposeEzsignfoldersV1**](ObjectEzsignfolderApi.md#ezsignfolderdisposeezsignfoldersv1) | **POST** /1/object/ezsignfolder/disposeEzsignfolders | Dispose Ezsignfolders |
| [**EzsignfolderDisposeV1**](ObjectEzsignfolderApi.md#ezsignfolderdisposev1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/dispose | Dispose the Ezsignfolder |
| [**EzsignfolderEditObjectV3**](ObjectEzsignfolderApi.md#ezsignfoldereditobjectv3) | **PUT** /3/object/ezsignfolder/{pkiEzsignfolderID} | Edit an existing Ezsignfolder |
| [**EzsignfolderEndPrematurelyV1**](ObjectEzsignfolderApi.md#ezsignfolderendprematurelyv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/endPrematurely | End prematurely |
| [**EzsignfolderGetActionableElementsV1**](ObjectEzsignfolderApi.md#ezsignfoldergetactionableelementsv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getActionableElements | Retrieve actionable elements for the Ezsignfolder |
| [**EzsignfolderGetAttachmentCountV1**](ObjectEzsignfolderApi.md#ezsignfoldergetattachmentcountv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getAttachmentCount | Retrieve Attachment count |
| [**EzsignfolderGetAttachmentsV1**](ObjectEzsignfolderApi.md#ezsignfoldergetattachmentsv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getAttachments | Retrieve Ezsignfolder&#39;s Attachments |
| [**EzsignfolderGetCommunicationCountV1**](ObjectEzsignfolderApi.md#ezsignfoldergetcommunicationcountv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getCommunicationCount | Retrieve Communication count |
| [**EzsignfolderGetCommunicationListV1**](ObjectEzsignfolderApi.md#ezsignfoldergetcommunicationlistv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getCommunicationList | Retrieve Communication list |
| [**EzsignfolderGetCommunicationrecipientsV1**](ObjectEzsignfolderApi.md#ezsignfoldergetcommunicationrecipientsv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getCommunicationrecipients | Retrieve Ezsignfolder&#39;s Communicationrecipient |
| [**EzsignfolderGetCommunicationsendersV1**](ObjectEzsignfolderApi.md#ezsignfoldergetcommunicationsendersv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getCommunicationsenders | Retrieve Ezsignfolder&#39;s Communicationsender |
| [**EzsignfolderGetEzsigndocumentsV1**](ObjectEzsignfolderApi.md#ezsignfoldergetezsigndocumentsv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getEzsigndocuments | Retrieve an existing Ezsignfolder&#39;s Ezsigndocuments |
| [**EzsignfolderGetEzsignfoldersignerassociationsV1**](ObjectEzsignfolderApi.md#ezsignfoldergetezsignfoldersignerassociationsv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getEzsignfoldersignerassociations | Retrieve an existing Ezsignfolder&#39;s Ezsignfoldersignerassociations |
| [**EzsignfolderGetEzsignsignaturesAutomaticV1**](ObjectEzsignfolderApi.md#ezsignfoldergetezsignsignaturesautomaticv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getEzsignsignaturesAutomatic | Retrieve an existing Ezsignfolder&#39;s automatic Ezsignsignatures |
| [**EzsignfolderGetFormsDataV1**](ObjectEzsignfolderApi.md#ezsignfoldergetformsdatav1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getFormsData | Retrieve an existing Ezsignfolder&#39;s forms data |
| [**EzsignfolderGetListV1**](ObjectEzsignfolderApi.md#ezsignfoldergetlistv1) | **GET** /1/object/ezsignfolder/getList | Retrieve Ezsignfolder list |
| [**EzsignfolderGetObjectV1**](ObjectEzsignfolderApi.md#ezsignfoldergetobjectv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID} | Retrieve an existing Ezsignfolder |
| [**EzsignfolderGetObjectV2**](ObjectEzsignfolderApi.md#ezsignfoldergetobjectv2) | **GET** /2/object/ezsignfolder/{pkiEzsignfolderID} | Retrieve an existing Ezsignfolder |
| [**EzsignfolderGetObjectV3**](ObjectEzsignfolderApi.md#ezsignfoldergetobjectv3) | **GET** /3/object/ezsignfolder/{pkiEzsignfolderID} | Retrieve an existing Ezsignfolder |
| [**EzsignfolderImportEzsignfoldersignerassociationsV1**](ObjectEzsignfolderApi.md#ezsignfolderimportezsignfoldersignerassociationsv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/importEzsignfoldersignerassociations | Import an existing Ezsignfoldersignerassociation into this Ezsignfolder |
| [**EzsignfolderImportEzsigntemplatepackageV1**](ObjectEzsignfolderApi.md#ezsignfolderimportezsigntemplatepackagev1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/importEzsigntemplatepackage | Import an Ezsigntemplatepackage in the Ezsignfolder. |
| [**EzsignfolderReorderV1**](ObjectEzsignfolderApi.md#ezsignfolderreorderv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/reorder | Reorder Ezsigndocuments in the Ezsignfolder |
| [**EzsignfolderReorderV2**](ObjectEzsignfolderApi.md#ezsignfolderreorderv2) | **POST** /2/object/ezsignfolder/{pkiEzsignfolderID}/reorder | Reorder Ezsigndocuments in the Ezsignfolder |
| [**EzsignfolderSendV1**](ObjectEzsignfolderApi.md#ezsignfoldersendv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/send | Send the Ezsignfolder to the signatories for signature |
| [**EzsignfolderSendV3**](ObjectEzsignfolderApi.md#ezsignfoldersendv3) | **POST** /3/object/ezsignfolder/{pkiEzsignfolderID}/send | Send the Ezsignfolder to the signatories for signature |
| [**EzsignfolderUnsendV1**](ObjectEzsignfolderApi.md#ezsignfolderunsendv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/unsend | Unsend the Ezsignfolder |

<a id="ezsignfolderarchivev1"></a>
# **EzsignfolderArchiveV1**
> CommonResponse EzsignfolderArchiveV1 (int pkiEzsignfolderID, Object body)

Archive the Ezsignfolder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderArchiveV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Archive the Ezsignfolder
                CommonResponse result = apiInstance.EzsignfolderArchiveV1(pkiEzsignfolderID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderArchiveV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderArchiveV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive the Ezsignfolder
    ApiResponse<CommonResponse> response = apiInstance.EzsignfolderArchiveV1WithHttpInfo(pkiEzsignfolderID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderArchiveV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfolderbatchdownloadv1"></a>
# **EzsignfolderBatchDownloadV1**
> System.IO.Stream EzsignfolderBatchDownloadV1 (int pkiEzsignfolderID, EzsignfolderBatchDownloadV1Request ezsignfolderBatchDownloadV1Request)

Download multiples files from an Ezsignfolder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderBatchDownloadV1Request = new EzsignfolderBatchDownloadV1Request(); // EzsignfolderBatchDownloadV1Request | 

            try
            {
                // Download multiples files from an Ezsignfolder
                System.IO.Stream result = apiInstance.EzsignfolderBatchDownloadV1(pkiEzsignfolderID, ezsignfolderBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples files from an Ezsignfolder
    ApiResponse<System.IO.Stream> response = apiInstance.EzsignfolderBatchDownloadV1WithHttpInfo(pkiEzsignfolderID, ezsignfolderBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderBatchDownloadV1Request** | [**EzsignfolderBatchDownloadV1Request**](EzsignfolderBatchDownloadV1Request.md) |  |  |

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/zip, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldercreateobjectv1"></a>
# **EzsignfolderCreateObjectV1**
> EzsignfolderCreateObjectV1Response EzsignfolderCreateObjectV1 (List<EzsignfolderCreateObjectV1Request> ezsignfolderCreateObjectV1Request)

Create a new Ezsignfolder

The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var ezsignfolderCreateObjectV1Request = new List<EzsignfolderCreateObjectV1Request>(); // List<EzsignfolderCreateObjectV1Request> | 

            try
            {
                // Create a new Ezsignfolder
                EzsignfolderCreateObjectV1Response result = apiInstance.EzsignfolderCreateObjectV1(ezsignfolderCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsignfolder
    ApiResponse<EzsignfolderCreateObjectV1Response> response = apiInstance.EzsignfolderCreateObjectV1WithHttpInfo(ezsignfolderCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignfolderCreateObjectV1Request** | [**List&lt;EzsignfolderCreateObjectV1Request&gt;**](EzsignfolderCreateObjectV1Request.md) |  |  |

### Return type

[**EzsignfolderCreateObjectV1Response**](EzsignfolderCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldercreateobjectv2"></a>
# **EzsignfolderCreateObjectV2**
> EzsignfolderCreateObjectV2Response EzsignfolderCreateObjectV2 (EzsignfolderCreateObjectV2Request ezsignfolderCreateObjectV2Request)

Create a new Ezsignfolder

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
    public class EzsignfolderCreateObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var ezsignfolderCreateObjectV2Request = new EzsignfolderCreateObjectV2Request(); // EzsignfolderCreateObjectV2Request | 

            try
            {
                // Create a new Ezsignfolder
                EzsignfolderCreateObjectV2Response result = apiInstance.EzsignfolderCreateObjectV2(ezsignfolderCreateObjectV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderCreateObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderCreateObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsignfolder
    ApiResponse<EzsignfolderCreateObjectV2Response> response = apiInstance.EzsignfolderCreateObjectV2WithHttpInfo(ezsignfolderCreateObjectV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderCreateObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignfolderCreateObjectV2Request** | [**EzsignfolderCreateObjectV2Request**](EzsignfolderCreateObjectV2Request.md) |  |  |

### Return type

[**EzsignfolderCreateObjectV2Response**](EzsignfolderCreateObjectV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldercreateobjectv3"></a>
# **EzsignfolderCreateObjectV3**
> EzsignfolderCreateObjectV3Response EzsignfolderCreateObjectV3 (EzsignfolderCreateObjectV3Request ezsignfolderCreateObjectV3Request)

Create a new Ezsignfolder

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
    public class EzsignfolderCreateObjectV3Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var ezsignfolderCreateObjectV3Request = new EzsignfolderCreateObjectV3Request(); // EzsignfolderCreateObjectV3Request | 

            try
            {
                // Create a new Ezsignfolder
                EzsignfolderCreateObjectV3Response result = apiInstance.EzsignfolderCreateObjectV3(ezsignfolderCreateObjectV3Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderCreateObjectV3: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderCreateObjectV3WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsignfolder
    ApiResponse<EzsignfolderCreateObjectV3Response> response = apiInstance.EzsignfolderCreateObjectV3WithHttpInfo(ezsignfolderCreateObjectV3Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderCreateObjectV3WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignfolderCreateObjectV3Request** | [**EzsignfolderCreateObjectV3Request**](EzsignfolderCreateObjectV3Request.md) |  |  |

### Return type

[**EzsignfolderCreateObjectV3Response**](EzsignfolderCreateObjectV3Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfolderdeleteobjectv1"></a>
# **EzsignfolderDeleteObjectV1**
> CommonResponse EzsignfolderDeleteObjectV1 (int pkiEzsignfolderID)

Delete an existing Ezsignfolder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Delete an existing Ezsignfolder
                CommonResponse result = apiInstance.EzsignfolderDeleteObjectV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Ezsignfolder
    ApiResponse<CommonResponse> response = apiInstance.EzsignfolderDeleteObjectV1WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfolderdisposeezsignfoldersv1"></a>
# **EzsignfolderDisposeEzsignfoldersV1**
> CommonResponse EzsignfolderDisposeEzsignfoldersV1 (EzsignfolderDisposeEzsignfoldersV1Request ezsignfolderDisposeEzsignfoldersV1Request)

Dispose Ezsignfolders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderDisposeEzsignfoldersV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var ezsignfolderDisposeEzsignfoldersV1Request = new EzsignfolderDisposeEzsignfoldersV1Request(); // EzsignfolderDisposeEzsignfoldersV1Request | 

            try
            {
                // Dispose Ezsignfolders
                CommonResponse result = apiInstance.EzsignfolderDisposeEzsignfoldersV1(ezsignfolderDisposeEzsignfoldersV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderDisposeEzsignfoldersV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderDisposeEzsignfoldersV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dispose Ezsignfolders
    ApiResponse<CommonResponse> response = apiInstance.EzsignfolderDisposeEzsignfoldersV1WithHttpInfo(ezsignfolderDisposeEzsignfoldersV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderDisposeEzsignfoldersV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignfolderDisposeEzsignfoldersV1Request** | [**EzsignfolderDisposeEzsignfoldersV1Request**](EzsignfolderDisposeEzsignfoldersV1Request.md) |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfolderdisposev1"></a>
# **EzsignfolderDisposeV1**
> CommonResponse EzsignfolderDisposeV1 (int pkiEzsignfolderID, Object body)

Dispose the Ezsignfolder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderDisposeV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Dispose the Ezsignfolder
                CommonResponse result = apiInstance.EzsignfolderDisposeV1(pkiEzsignfolderID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderDisposeV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderDisposeV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dispose the Ezsignfolder
    ApiResponse<CommonResponse> response = apiInstance.EzsignfolderDisposeV1WithHttpInfo(pkiEzsignfolderID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderDisposeV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldereditobjectv3"></a>
# **EzsignfolderEditObjectV3**
> CommonResponse EzsignfolderEditObjectV3 (int pkiEzsignfolderID, EzsignfolderEditObjectV3Request ezsignfolderEditObjectV3Request)

Edit an existing Ezsignfolder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderEditObjectV3Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderEditObjectV3Request = new EzsignfolderEditObjectV3Request(); // EzsignfolderEditObjectV3Request | 

            try
            {
                // Edit an existing Ezsignfolder
                CommonResponse result = apiInstance.EzsignfolderEditObjectV3(pkiEzsignfolderID, ezsignfolderEditObjectV3Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderEditObjectV3: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderEditObjectV3WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsignfolder
    ApiResponse<CommonResponse> response = apiInstance.EzsignfolderEditObjectV3WithHttpInfo(pkiEzsignfolderID, ezsignfolderEditObjectV3Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderEditObjectV3WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderEditObjectV3Request** | [**EzsignfolderEditObjectV3Request**](EzsignfolderEditObjectV3Request.md) |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfolderendprematurelyv1"></a>
# **EzsignfolderEndPrematurelyV1**
> CommonResponse EzsignfolderEndPrematurelyV1 (int pkiEzsignfolderID, Object body)

End prematurely

End prematurely all Ezsigndocument of Ezsignfolder when some signatures are still required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderEndPrematurelyV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // End prematurely
                CommonResponse result = apiInstance.EzsignfolderEndPrematurelyV1(pkiEzsignfolderID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderEndPrematurelyV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderEndPrematurelyV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // End prematurely
    ApiResponse<CommonResponse> response = apiInstance.EzsignfolderEndPrematurelyV1WithHttpInfo(pkiEzsignfolderID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderEndPrematurelyV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetactionableelementsv1"></a>
# **EzsignfolderGetActionableElementsV1**
> EzsignfolderGetActionableElementsV1Response EzsignfolderGetActionableElementsV1 (int pkiEzsignfolderID)

Retrieve actionable elements for the Ezsignfolder

Return the Ezsignsignatures that can be signed and Ezsignformfieldgroups that can be filled by the current user at the current step in the process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetActionableElementsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve actionable elements for the Ezsignfolder
                EzsignfolderGetActionableElementsV1Response result = apiInstance.EzsignfolderGetActionableElementsV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetActionableElementsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetActionableElementsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve actionable elements for the Ezsignfolder
    ApiResponse<EzsignfolderGetActionableElementsV1Response> response = apiInstance.EzsignfolderGetActionableElementsV1WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetActionableElementsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetActionableElementsV1Response**](EzsignfolderGetActionableElementsV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetattachmentcountv1"></a>
# **EzsignfolderGetAttachmentCountV1**
> EzsignfolderGetAttachmentCountV1Response EzsignfolderGetAttachmentCountV1 (int pkiEzsignfolderID)

Retrieve Attachment count

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetAttachmentCountV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve Attachment count
                EzsignfolderGetAttachmentCountV1Response result = apiInstance.EzsignfolderGetAttachmentCountV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetAttachmentCountV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetAttachmentCountV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Attachment count
    ApiResponse<EzsignfolderGetAttachmentCountV1Response> response = apiInstance.EzsignfolderGetAttachmentCountV1WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetAttachmentCountV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetAttachmentCountV1Response**](EzsignfolderGetAttachmentCountV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetattachmentsv1"></a>
# **EzsignfolderGetAttachmentsV1**
> EzsignfolderGetAttachmentsV1Response EzsignfolderGetAttachmentsV1 (int pkiEzsignfolderID)

Retrieve Ezsignfolder's Attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve Ezsignfolder's Attachments
                EzsignfolderGetAttachmentsV1Response result = apiInstance.EzsignfolderGetAttachmentsV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsignfolder's Attachments
    ApiResponse<EzsignfolderGetAttachmentsV1Response> response = apiInstance.EzsignfolderGetAttachmentsV1WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetAttachmentsV1Response**](EzsignfolderGetAttachmentsV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetcommunicationcountv1"></a>
# **EzsignfolderGetCommunicationCountV1**
> EzsignfolderGetCommunicationCountV1Response EzsignfolderGetCommunicationCountV1 (int pkiEzsignfolderID)

Retrieve Communication count

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetCommunicationCountV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve Communication count
                EzsignfolderGetCommunicationCountV1Response result = apiInstance.EzsignfolderGetCommunicationCountV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetCommunicationCountV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetCommunicationCountV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication count
    ApiResponse<EzsignfolderGetCommunicationCountV1Response> response = apiInstance.EzsignfolderGetCommunicationCountV1WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetCommunicationCountV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetCommunicationCountV1Response**](EzsignfolderGetCommunicationCountV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetcommunicationlistv1"></a>
# **EzsignfolderGetCommunicationListV1**
> EzsignfolderGetCommunicationListV1Response EzsignfolderGetCommunicationListV1 (int pkiEzsignfolderID)

Retrieve Communication list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetCommunicationListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve Communication list
                EzsignfolderGetCommunicationListV1Response result = apiInstance.EzsignfolderGetCommunicationListV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetCommunicationListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetCommunicationListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication list
    ApiResponse<EzsignfolderGetCommunicationListV1Response> response = apiInstance.EzsignfolderGetCommunicationListV1WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetCommunicationListV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetCommunicationListV1Response**](EzsignfolderGetCommunicationListV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetcommunicationrecipientsv1"></a>
# **EzsignfolderGetCommunicationrecipientsV1**
> EzsignfolderGetCommunicationrecipientsV1Response EzsignfolderGetCommunicationrecipientsV1 (int pkiEzsignfolderID)

Retrieve Ezsignfolder's Communicationrecipient

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetCommunicationrecipientsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve Ezsignfolder's Communicationrecipient
                EzsignfolderGetCommunicationrecipientsV1Response result = apiInstance.EzsignfolderGetCommunicationrecipientsV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetCommunicationrecipientsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetCommunicationrecipientsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsignfolder's Communicationrecipient
    ApiResponse<EzsignfolderGetCommunicationrecipientsV1Response> response = apiInstance.EzsignfolderGetCommunicationrecipientsV1WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetCommunicationrecipientsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetCommunicationrecipientsV1Response**](EzsignfolderGetCommunicationrecipientsV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetcommunicationsendersv1"></a>
# **EzsignfolderGetCommunicationsendersV1**
> EzsignfolderGetCommunicationsendersV1Response EzsignfolderGetCommunicationsendersV1 (int pkiEzsignfolderID)

Retrieve Ezsignfolder's Communicationsender

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetCommunicationsendersV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve Ezsignfolder's Communicationsender
                EzsignfolderGetCommunicationsendersV1Response result = apiInstance.EzsignfolderGetCommunicationsendersV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetCommunicationsendersV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetCommunicationsendersV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsignfolder's Communicationsender
    ApiResponse<EzsignfolderGetCommunicationsendersV1Response> response = apiInstance.EzsignfolderGetCommunicationsendersV1WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetCommunicationsendersV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetCommunicationsendersV1Response**](EzsignfolderGetCommunicationsendersV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetezsigndocumentsv1"></a>
# **EzsignfolderGetEzsigndocumentsV1**
> EzsignfolderGetEzsigndocumentsV1Response EzsignfolderGetEzsigndocumentsV1 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder's Ezsigndocuments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetEzsigndocumentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfolder's Ezsigndocuments
                EzsignfolderGetEzsigndocumentsV1Response result = apiInstance.EzsignfolderGetEzsigndocumentsV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetEzsigndocumentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetEzsigndocumentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignfolder's Ezsigndocuments
    ApiResponse<EzsignfolderGetEzsigndocumentsV1Response> response = apiInstance.EzsignfolderGetEzsigndocumentsV1WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetEzsigndocumentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetEzsigndocumentsV1Response**](EzsignfolderGetEzsigndocumentsV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetezsignfoldersignerassociationsv1"></a>
# **EzsignfolderGetEzsignfoldersignerassociationsV1**
> EzsignfolderGetEzsignfoldersignerassociationsV1Response EzsignfolderGetEzsignfoldersignerassociationsV1 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder's Ezsignfoldersignerassociations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetEzsignfoldersignerassociationsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfolder's Ezsignfoldersignerassociations
                EzsignfolderGetEzsignfoldersignerassociationsV1Response result = apiInstance.EzsignfolderGetEzsignfoldersignerassociationsV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetEzsignfoldersignerassociationsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetEzsignfoldersignerassociationsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignfolder's Ezsignfoldersignerassociations
    ApiResponse<EzsignfolderGetEzsignfoldersignerassociationsV1Response> response = apiInstance.EzsignfolderGetEzsignfoldersignerassociationsV1WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetEzsignfoldersignerassociationsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetEzsignfoldersignerassociationsV1Response**](EzsignfolderGetEzsignfoldersignerassociationsV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetezsignsignaturesautomaticv1"></a>
# **EzsignfolderGetEzsignsignaturesAutomaticV1**
> EzsignfolderGetEzsignsignaturesAutomaticV1Response EzsignfolderGetEzsignsignaturesAutomaticV1 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder's automatic Ezsignsignatures

Return the Ezsignsignatures that can be signed by the current user at the current step in the process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetEzsignsignaturesAutomaticV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfolder's automatic Ezsignsignatures
                EzsignfolderGetEzsignsignaturesAutomaticV1Response result = apiInstance.EzsignfolderGetEzsignsignaturesAutomaticV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetEzsignsignaturesAutomaticV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetEzsignsignaturesAutomaticV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignfolder's automatic Ezsignsignatures
    ApiResponse<EzsignfolderGetEzsignsignaturesAutomaticV1Response> response = apiInstance.EzsignfolderGetEzsignsignaturesAutomaticV1WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetEzsignsignaturesAutomaticV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetEzsignsignaturesAutomaticV1Response**](EzsignfolderGetEzsignsignaturesAutomaticV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetformsdatav1"></a>
# **EzsignfolderGetFormsDataV1**
> EzsignfolderGetFormsDataV1Response EzsignfolderGetFormsDataV1 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder's forms data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetFormsDataV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfolder's forms data
                EzsignfolderGetFormsDataV1Response result = apiInstance.EzsignfolderGetFormsDataV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetFormsDataV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetFormsDataV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignfolder's forms data
    ApiResponse<EzsignfolderGetFormsDataV1Response> response = apiInstance.EzsignfolderGetFormsDataV1WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetFormsDataV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetFormsDataV1Response**](EzsignfolderGetFormsDataV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/zip


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetlistv1"></a>
# **EzsignfolderGetListV1**
> EzsignfolderGetListV1Response EzsignfolderGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Ezsignfolder list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eEzsignfolderStep | Unsent<br>Sent<br>PartiallySigned<br>Expired<br>Completed<br>Archived<br>Disposed| | eEzsignfoldertypePrivacylevel | User<br>Usergroup |  Advanced filters that can be used in query parameter *sFilter*:  | Variable | |- --| | fkiUserID | | sContactFirstname | | sContactLastname | | sUserFirstname | | sUserLastname | | sEzsigndocumentName |

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var eOrderBy = "pkiEzsignfolderID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Ezsignfolder list
                EzsignfolderGetListV1Response result = apiInstance.EzsignfolderGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsignfolder list
    ApiResponse<EzsignfolderGetListV1Response> response = apiInstance.EzsignfolderGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetListV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string?** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int?** |  | [optional]  |
| **iRowOffset** | **int?** |  | [optional] [default to 0] |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |
| **sFilter** | **string?** |  | [optional]  |

### Return type

[**EzsignfolderGetListV1Response**](EzsignfolderGetListV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetobjectv1"></a>
# **EzsignfolderGetObjectV1**
> EzsignfolderGetObjectV1Response EzsignfolderGetObjectV1 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfolder
                EzsignfolderGetObjectV1Response result = apiInstance.EzsignfolderGetObjectV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignfolder
    ApiResponse<EzsignfolderGetObjectV1Response> response = apiInstance.EzsignfolderGetObjectV1WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetObjectV1Response**](EzsignfolderGetObjectV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetobjectv2"></a>
# **EzsignfolderGetObjectV2**
> EzsignfolderGetObjectV2Response EzsignfolderGetObjectV2 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfolder
                EzsignfolderGetObjectV2Response result = apiInstance.EzsignfolderGetObjectV2(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignfolder
    ApiResponse<EzsignfolderGetObjectV2Response> response = apiInstance.EzsignfolderGetObjectV2WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetObjectV2Response**](EzsignfolderGetObjectV2Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldergetobjectv3"></a>
# **EzsignfolderGetObjectV3**
> EzsignfolderGetObjectV3Response EzsignfolderGetObjectV3 (int pkiEzsignfolderID)

Retrieve an existing Ezsignfolder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderGetObjectV3Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfolder
                EzsignfolderGetObjectV3Response result = apiInstance.EzsignfolderGetObjectV3(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetObjectV3: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderGetObjectV3WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsignfolder
    ApiResponse<EzsignfolderGetObjectV3Response> response = apiInstance.EzsignfolderGetObjectV3WithHttpInfo(pkiEzsignfolderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetObjectV3WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |

### Return type

[**EzsignfolderGetObjectV3Response**](EzsignfolderGetObjectV3Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfolderimportezsignfoldersignerassociationsv1"></a>
# **EzsignfolderImportEzsignfoldersignerassociationsV1**
> EzsignfolderImportEzsignfoldersignerassociationsV1Response EzsignfolderImportEzsignfoldersignerassociationsV1 (int pkiEzsignfolderID, EzsignfolderImportEzsignfoldersignerassociationsV1Request ezsignfolderImportEzsignfoldersignerassociationsV1Request)

Import an existing Ezsignfoldersignerassociation into this Ezsignfolder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderImportEzsignfoldersignerassociationsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderImportEzsignfoldersignerassociationsV1Request = new EzsignfolderImportEzsignfoldersignerassociationsV1Request(); // EzsignfolderImportEzsignfoldersignerassociationsV1Request | 

            try
            {
                // Import an existing Ezsignfoldersignerassociation into this Ezsignfolder
                EzsignfolderImportEzsignfoldersignerassociationsV1Response result = apiInstance.EzsignfolderImportEzsignfoldersignerassociationsV1(pkiEzsignfolderID, ezsignfolderImportEzsignfoldersignerassociationsV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderImportEzsignfoldersignerassociationsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderImportEzsignfoldersignerassociationsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import an existing Ezsignfoldersignerassociation into this Ezsignfolder
    ApiResponse<EzsignfolderImportEzsignfoldersignerassociationsV1Response> response = apiInstance.EzsignfolderImportEzsignfoldersignerassociationsV1WithHttpInfo(pkiEzsignfolderID, ezsignfolderImportEzsignfoldersignerassociationsV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderImportEzsignfoldersignerassociationsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderImportEzsignfoldersignerassociationsV1Request** | [**EzsignfolderImportEzsignfoldersignerassociationsV1Request**](EzsignfolderImportEzsignfoldersignerassociationsV1Request.md) |  |  |

### Return type

[**EzsignfolderImportEzsignfoldersignerassociationsV1Response**](EzsignfolderImportEzsignfoldersignerassociationsV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **403** | The request is not allowed to be executed. Look for detail about the error in the body |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfolderimportezsigntemplatepackagev1"></a>
# **EzsignfolderImportEzsigntemplatepackageV1**
> EzsignfolderImportEzsigntemplatepackageV1Response EzsignfolderImportEzsigntemplatepackageV1 (int pkiEzsignfolderID, EzsignfolderImportEzsigntemplatepackageV1Request ezsignfolderImportEzsigntemplatepackageV1Request)

Import an Ezsigntemplatepackage in the Ezsignfolder.

This endpoint imports all of the Ezsigntemplates from the Ezsigntemplatepackage into the Ezsignfolder as Ezsigndocuments.  This allows to automatically apply all the Ezsigntemplateformfieldgroups and Ezsigntemplatesignatures on the newly created Ezsigndocuments in a single step.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderImportEzsigntemplatepackageV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderImportEzsigntemplatepackageV1Request = new EzsignfolderImportEzsigntemplatepackageV1Request(); // EzsignfolderImportEzsigntemplatepackageV1Request | 

            try
            {
                // Import an Ezsigntemplatepackage in the Ezsignfolder.
                EzsignfolderImportEzsigntemplatepackageV1Response result = apiInstance.EzsignfolderImportEzsigntemplatepackageV1(pkiEzsignfolderID, ezsignfolderImportEzsigntemplatepackageV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderImportEzsigntemplatepackageV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderImportEzsigntemplatepackageV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import an Ezsigntemplatepackage in the Ezsignfolder.
    ApiResponse<EzsignfolderImportEzsigntemplatepackageV1Response> response = apiInstance.EzsignfolderImportEzsigntemplatepackageV1WithHttpInfo(pkiEzsignfolderID, ezsignfolderImportEzsigntemplatepackageV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderImportEzsigntemplatepackageV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderImportEzsigntemplatepackageV1Request** | [**EzsignfolderImportEzsigntemplatepackageV1Request**](EzsignfolderImportEzsigntemplatepackageV1Request.md) |  |  |

### Return type

[**EzsignfolderImportEzsigntemplatepackageV1Response**](EzsignfolderImportEzsigntemplatepackageV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfolderreorderv1"></a>
# **EzsignfolderReorderV1**
> CommonResponse EzsignfolderReorderV1 (int pkiEzsignfolderID, EzsignfolderReorderV1Request ezsignfolderReorderV1Request)

Reorder Ezsigndocuments in the Ezsignfolder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderReorderV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderReorderV1Request = new EzsignfolderReorderV1Request(); // EzsignfolderReorderV1Request | 

            try
            {
                // Reorder Ezsigndocuments in the Ezsignfolder
                CommonResponse result = apiInstance.EzsignfolderReorderV1(pkiEzsignfolderID, ezsignfolderReorderV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderReorderV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderReorderV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reorder Ezsigndocuments in the Ezsignfolder
    ApiResponse<CommonResponse> response = apiInstance.EzsignfolderReorderV1WithHttpInfo(pkiEzsignfolderID, ezsignfolderReorderV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderReorderV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderReorderV1Request** | [**EzsignfolderReorderV1Request**](EzsignfolderReorderV1Request.md) |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfolderreorderv2"></a>
# **EzsignfolderReorderV2**
> CommonResponse EzsignfolderReorderV2 (int pkiEzsignfolderID, EzsignfolderReorderV2Request ezsignfolderReorderV2Request)

Reorder Ezsigndocuments in the Ezsignfolder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderReorderV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderReorderV2Request = new EzsignfolderReorderV2Request(); // EzsignfolderReorderV2Request | 

            try
            {
                // Reorder Ezsigndocuments in the Ezsignfolder
                CommonResponse result = apiInstance.EzsignfolderReorderV2(pkiEzsignfolderID, ezsignfolderReorderV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderReorderV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderReorderV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reorder Ezsigndocuments in the Ezsignfolder
    ApiResponse<CommonResponse> response = apiInstance.EzsignfolderReorderV2WithHttpInfo(pkiEzsignfolderID, ezsignfolderReorderV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderReorderV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderReorderV2Request** | [**EzsignfolderReorderV2Request**](EzsignfolderReorderV2Request.md) |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldersendv1"></a>
# **EzsignfolderSendV1**
> CommonResponse EzsignfolderSendV1 (int pkiEzsignfolderID, EzsignfolderSendV1Request ezsignfolderSendV1Request)

Send the Ezsignfolder to the signatories for signature

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderSendV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderSendV1Request = new EzsignfolderSendV1Request(); // EzsignfolderSendV1Request | 

            try
            {
                // Send the Ezsignfolder to the signatories for signature
                CommonResponse result = apiInstance.EzsignfolderSendV1(pkiEzsignfolderID, ezsignfolderSendV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderSendV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderSendV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send the Ezsignfolder to the signatories for signature
    ApiResponse<CommonResponse> response = apiInstance.EzsignfolderSendV1WithHttpInfo(pkiEzsignfolderID, ezsignfolderSendV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderSendV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderSendV1Request** | [**EzsignfolderSendV1Request**](EzsignfolderSendV1Request.md) |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfoldersendv3"></a>
# **EzsignfolderSendV3**
> CommonResponse EzsignfolderSendV3 (int pkiEzsignfolderID, EzsignfolderSendV3Request ezsignfolderSendV3Request)

Send the Ezsignfolder to the signatories for signature

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderSendV3Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderSendV3Request = new EzsignfolderSendV3Request(); // EzsignfolderSendV3Request | 

            try
            {
                // Send the Ezsignfolder to the signatories for signature
                CommonResponse result = apiInstance.EzsignfolderSendV3(pkiEzsignfolderID, ezsignfolderSendV3Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderSendV3: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderSendV3WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send the Ezsignfolder to the signatories for signature
    ApiResponse<CommonResponse> response = apiInstance.EzsignfolderSendV3WithHttpInfo(pkiEzsignfolderID, ezsignfolderSendV3Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderSendV3WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **ezsignfolderSendV3Request** | [**EzsignfolderSendV3Request**](EzsignfolderSendV3Request.md) |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsignfolderunsendv1"></a>
# **EzsignfolderUnsendV1**
> CommonResponse EzsignfolderUnsendV1 (int pkiEzsignfolderID, Object body)

Unsend the Ezsignfolder

Once an Ezsignfolder has been sent to signatories, it cannot be modified.  Using this endpoint, you can unsend the Ezsignfolder and make it modifiable again.  Signatories will receive an email informing them the signature process was aborted and they might receive a new invitation to sign.  ⚠️ Warning: Any signature previously made by signatories on \"Non-completed\" Ezsigndocuments will be lost.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfolderUnsendV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(config);
            var pkiEzsignfolderID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Unsend the Ezsignfolder
                CommonResponse result = apiInstance.EzsignfolderUnsendV1(pkiEzsignfolderID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderUnsendV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsignfolderUnsendV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unsend the Ezsignfolder
    ApiResponse<CommonResponse> response = apiInstance.EzsignfolderUnsendV1WithHttpInfo(pkiEzsignfolderID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderUnsendV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignfolderID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


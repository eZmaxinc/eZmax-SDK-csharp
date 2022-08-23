# eZmaxApi.Api.ObjectEzsignfolderApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EzsignfolderArchiveV1**](ObjectEzsignfolderApi.md#ezsignfolderarchivev1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/archive | Archive the Ezsignfolder
[**EzsignfolderBatchDownloadV1**](ObjectEzsignfolderApi.md#ezsignfolderbatchdownloadv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/batchDownload | Download multiples files from an Ezsignfolder
[**EzsignfolderCreateObjectV1**](ObjectEzsignfolderApi.md#ezsignfoldercreateobjectv1) | **POST** /1/object/ezsignfolder | Create a new Ezsignfolder
[**EzsignfolderCreateObjectV2**](ObjectEzsignfolderApi.md#ezsignfoldercreateobjectv2) | **POST** /2/object/ezsignfolder | Create a new Ezsignfolder
[**EzsignfolderDeleteObjectV1**](ObjectEzsignfolderApi.md#ezsignfolderdeleteobjectv1) | **DELETE** /1/object/ezsignfolder/{pkiEzsignfolderID} | Delete an existing Ezsignfolder
[**EzsignfolderDisposeEzsignfoldersV1**](ObjectEzsignfolderApi.md#ezsignfolderdisposeezsignfoldersv1) | **POST** /1/object/ezsignfolder/disposeEzsignfolders | Dispose Ezsignfolders
[**EzsignfolderDisposeV1**](ObjectEzsignfolderApi.md#ezsignfolderdisposev1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/dispose | Dispose the Ezsignfolder
[**EzsignfolderEditObjectV1**](ObjectEzsignfolderApi.md#ezsignfoldereditobjectv1) | **PUT** /1/object/ezsignfolder/{pkiEzsignfolderID} | Edit an existing Ezsignfolder
[**EzsignfolderGetActionableElementsV1**](ObjectEzsignfolderApi.md#ezsignfoldergetactionableelementsv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getActionableElements | Retrieve actionable elements for the Ezsignfolder
[**EzsignfolderGetEzsigndocumentsV1**](ObjectEzsignfolderApi.md#ezsignfoldergetezsigndocumentsv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getEzsigndocuments | Retrieve an existing Ezsignfolder&#39;s Ezsigndocuments
[**EzsignfolderGetEzsignfoldersignerassociationsV1**](ObjectEzsignfolderApi.md#ezsignfoldergetezsignfoldersignerassociationsv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getEzsignfoldersignerassociations | Retrieve an existing Ezsignfolder&#39;s Ezsignfoldersignerassociations
[**EzsignfolderGetFormsDataV1**](ObjectEzsignfolderApi.md#ezsignfoldergetformsdatav1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getFormsData | Retrieve an existing Ezsignfolder&#39;s forms data
[**EzsignfolderGetListV1**](ObjectEzsignfolderApi.md#ezsignfoldergetlistv1) | **GET** /1/object/ezsignfolder/getList | Retrieve Ezsignfolder list
[**EzsignfolderGetObjectV1**](ObjectEzsignfolderApi.md#ezsignfoldergetobjectv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID} | Retrieve an existing Ezsignfolder
[**EzsignfolderImportEzsignfoldersignerassociationsV1**](ObjectEzsignfolderApi.md#ezsignfolderimportezsignfoldersignerassociationsv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/importEzsignfoldersignerassociations | Import an existing Ezsignfoldersignerassociation into this Ezsignfolder
[**EzsignfolderImportEzsigntemplatepackageV1**](ObjectEzsignfolderApi.md#ezsignfolderimportezsigntemplatepackagev1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/importEzsigntemplatepackage | Import an Ezsigntemplatepackage in the Ezsignfolder.
[**EzsignfolderReorderV1**](ObjectEzsignfolderApi.md#ezsignfolderreorderv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/reorder | Reorder Ezsigndocuments in the Ezsignfolder
[**EzsignfolderSendV1**](ObjectEzsignfolderApi.md#ezsignfoldersendv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/send | Send the Ezsignfolder to the signatories for signature
[**EzsignfolderSendV2**](ObjectEzsignfolderApi.md#ezsignfoldersendv2) | **POST** /2/object/ezsignfolder/{pkiEzsignfolderID}/send | Send the Ezsignfolder to the signatories for signature
[**EzsignfolderUnsendV1**](ObjectEzsignfolderApi.md#ezsignfolderunsendv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/unsend | Unsend the Ezsignfolder



## EzsignfolderArchiveV1

> EzsignfolderArchiveV1Response EzsignfolderArchiveV1 (int pkiEzsignfolderID, Object body)

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Archive the Ezsignfolder
                EzsignfolderArchiveV1Response result = apiInstance.EzsignfolderArchiveV1(pkiEzsignfolderID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderArchiveV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 
 **body** | **Object**|  | 

### Return type

[**EzsignfolderArchiveV1Response**](EzsignfolderArchiveV1Response.md)

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


## EzsignfolderBatchDownloadV1

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderBatchDownloadV1Request = new EzsignfolderBatchDownloadV1Request(); // EzsignfolderBatchDownloadV1Request | 

            try
            {
                // Download multiples files from an Ezsignfolder
                System.IO.Stream result = apiInstance.EzsignfolderBatchDownloadV1(pkiEzsignfolderID, ezsignfolderBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderBatchDownloadV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 
 **ezsignfolderBatchDownloadV1Request** | [**EzsignfolderBatchDownloadV1Request**](EzsignfolderBatchDownloadV1Request.md)|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfolderCreateObjectV1

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var ezsignfolderCreateObjectV1Request = new List<EzsignfolderCreateObjectV1Request>(); // List<EzsignfolderCreateObjectV1Request> | 

            try
            {
                // Create a new Ezsignfolder
                EzsignfolderCreateObjectV1Response result = apiInstance.EzsignfolderCreateObjectV1(ezsignfolderCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderCreateObjectV1: " + e.Message );
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
 **ezsignfolderCreateObjectV1Request** | [**List&lt;EzsignfolderCreateObjectV1Request&gt;**](EzsignfolderCreateObjectV1Request.md)|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfolderCreateObjectV2

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var ezsignfolderCreateObjectV2Request = new EzsignfolderCreateObjectV2Request(); // EzsignfolderCreateObjectV2Request | 

            try
            {
                // Create a new Ezsignfolder
                EzsignfolderCreateObjectV2Response result = apiInstance.EzsignfolderCreateObjectV2(ezsignfolderCreateObjectV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderCreateObjectV2: " + e.Message );
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
 **ezsignfolderCreateObjectV2Request** | [**EzsignfolderCreateObjectV2Request**](EzsignfolderCreateObjectV2Request.md)|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfolderDeleteObjectV1

> EzsignfolderDeleteObjectV1Response EzsignfolderDeleteObjectV1 (int pkiEzsignfolderID)

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Delete an existing Ezsignfolder
                EzsignfolderDeleteObjectV1Response result = apiInstance.EzsignfolderDeleteObjectV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderDeleteObjectV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 

### Return type

[**EzsignfolderDeleteObjectV1Response**](EzsignfolderDeleteObjectV1Response.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfolderDisposeEzsignfoldersV1

> EzsignfolderDisposeEzsignfoldersV1Response EzsignfolderDisposeEzsignfoldersV1 (EzsignfolderDisposeEzsignfoldersV1Request ezsignfolderDisposeEzsignfoldersV1Request)

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var ezsignfolderDisposeEzsignfoldersV1Request = new EzsignfolderDisposeEzsignfoldersV1Request(); // EzsignfolderDisposeEzsignfoldersV1Request | 

            try
            {
                // Dispose Ezsignfolders
                EzsignfolderDisposeEzsignfoldersV1Response result = apiInstance.EzsignfolderDisposeEzsignfoldersV1(ezsignfolderDisposeEzsignfoldersV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderDisposeEzsignfoldersV1: " + e.Message );
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
 **ezsignfolderDisposeEzsignfoldersV1Request** | [**EzsignfolderDisposeEzsignfoldersV1Request**](EzsignfolderDisposeEzsignfoldersV1Request.md)|  | 

### Return type

[**EzsignfolderDisposeEzsignfoldersV1Response**](EzsignfolderDisposeEzsignfoldersV1Response.md)

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


## EzsignfolderDisposeV1

> EzsignfolderDisposeV1Response EzsignfolderDisposeV1 (int pkiEzsignfolderID, Object body)

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Dispose the Ezsignfolder
                EzsignfolderDisposeV1Response result = apiInstance.EzsignfolderDisposeV1(pkiEzsignfolderID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderDisposeV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 
 **body** | **Object**|  | 

### Return type

[**EzsignfolderDisposeV1Response**](EzsignfolderDisposeV1Response.md)

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


## EzsignfolderEditObjectV1

> EzsignfolderEditObjectV1Response EzsignfolderEditObjectV1 (int pkiEzsignfolderID, EzsignfolderEditObjectV1Request ezsignfolderEditObjectV1Request)

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
    public class EzsignfolderEditObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderEditObjectV1Request = new EzsignfolderEditObjectV1Request(); // EzsignfolderEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsignfolder
                EzsignfolderEditObjectV1Response result = apiInstance.EzsignfolderEditObjectV1(pkiEzsignfolderID, ezsignfolderEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderEditObjectV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 
 **ezsignfolderEditObjectV1Request** | [**EzsignfolderEditObjectV1Request**](EzsignfolderEditObjectV1Request.md)|  | 

### Return type

[**EzsignfolderEditObjectV1Response**](EzsignfolderEditObjectV1Response.md)

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


## EzsignfolderGetActionableElementsV1

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve actionable elements for the Ezsignfolder
                EzsignfolderGetActionableElementsV1Response result = apiInstance.EzsignfolderGetActionableElementsV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetActionableElementsV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfolderGetEzsigndocumentsV1

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfolder's Ezsigndocuments
                EzsignfolderGetEzsigndocumentsV1Response result = apiInstance.EzsignfolderGetEzsigndocumentsV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetEzsigndocumentsV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfolderGetEzsignfoldersignerassociationsV1

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfolder's Ezsignfoldersignerassociations
                EzsignfolderGetEzsignfoldersignerassociationsV1Response result = apiInstance.EzsignfolderGetEzsignfoldersignerassociationsV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetEzsignfoldersignerassociationsV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfolderGetFormsDataV1

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfolder's forms data
                EzsignfolderGetFormsDataV1Response result = apiInstance.EzsignfolderGetFormsDataV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetFormsDataV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfolderGetListV1

> EzsignfolderGetListV1Response EzsignfolderGetListV1 (string eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string sFilter = null)

Retrieve Ezsignfolder list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eEzsignfolderStep | Unsent<br>Sent<br>PartiallySigned<br>Expired<br>Completed<br>Archived<br>Disposed| | eEzsignfoldertypePrivacylevel | User<br>Usergroup |

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var eOrderBy = "pkiEzsignfolderID_ASC";  // string | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 56;  // int? |  (optional) 
            var acceptLanguage = (HeaderAcceptLanguage) "*";  // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string |  (optional) 

            try
            {
                // Retrieve Ezsignfolder list
                EzsignfolderGetListV1Response result = apiInstance.EzsignfolderGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetListV1: " + e.Message );
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
 **eOrderBy** | **string**| Specify how you want the results to be sorted | [optional] 
 **iRowMax** | **int?**|  | [optional] 
 **iRowOffset** | **int?**|  | [optional] 
 **acceptLanguage** | **HeaderAcceptLanguage?**|  | [optional] 
 **sFilter** | **string**|  | [optional] 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfolderGetObjectV1

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfolder
                EzsignfolderGetObjectV1Response result = apiInstance.EzsignfolderGetObjectV1(pkiEzsignfolderID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderGetObjectV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfolderImportEzsignfoldersignerassociationsV1

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderImportEzsignfoldersignerassociationsV1Request = new EzsignfolderImportEzsignfoldersignerassociationsV1Request(); // EzsignfolderImportEzsignfoldersignerassociationsV1Request | 

            try
            {
                // Import an existing Ezsignfoldersignerassociation into this Ezsignfolder
                EzsignfolderImportEzsignfoldersignerassociationsV1Response result = apiInstance.EzsignfolderImportEzsignfoldersignerassociationsV1(pkiEzsignfolderID, ezsignfolderImportEzsignfoldersignerassociationsV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderImportEzsignfoldersignerassociationsV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 
 **ezsignfolderImportEzsignfoldersignerassociationsV1Request** | [**EzsignfolderImportEzsignfoldersignerassociationsV1Request**](EzsignfolderImportEzsignfoldersignerassociationsV1Request.md)|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfolderImportEzsigntemplatepackageV1

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderImportEzsigntemplatepackageV1Request = new EzsignfolderImportEzsigntemplatepackageV1Request(); // EzsignfolderImportEzsigntemplatepackageV1Request | 

            try
            {
                // Import an Ezsigntemplatepackage in the Ezsignfolder.
                EzsignfolderImportEzsigntemplatepackageV1Response result = apiInstance.EzsignfolderImportEzsigntemplatepackageV1(pkiEzsignfolderID, ezsignfolderImportEzsigntemplatepackageV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderImportEzsigntemplatepackageV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 
 **ezsignfolderImportEzsigntemplatepackageV1Request** | [**EzsignfolderImportEzsigntemplatepackageV1Request**](EzsignfolderImportEzsigntemplatepackageV1Request.md)|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfolderReorderV1

> EzsignfolderReorderV1Response EzsignfolderReorderV1 (int pkiEzsignfolderID, EzsignfolderReorderV1Request ezsignfolderReorderV1Request)

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderReorderV1Request = new EzsignfolderReorderV1Request(); // EzsignfolderReorderV1Request | 

            try
            {
                // Reorder Ezsigndocuments in the Ezsignfolder
                EzsignfolderReorderV1Response result = apiInstance.EzsignfolderReorderV1(pkiEzsignfolderID, ezsignfolderReorderV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderReorderV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 
 **ezsignfolderReorderV1Request** | [**EzsignfolderReorderV1Request**](EzsignfolderReorderV1Request.md)|  | 

### Return type

[**EzsignfolderReorderV1Response**](EzsignfolderReorderV1Response.md)

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


## EzsignfolderSendV1

> EzsignfolderSendV1Response EzsignfolderSendV1 (int pkiEzsignfolderID, EzsignfolderSendV1Request ezsignfolderSendV1Request)

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderSendV1Request = new EzsignfolderSendV1Request(); // EzsignfolderSendV1Request | 

            try
            {
                // Send the Ezsignfolder to the signatories for signature
                EzsignfolderSendV1Response result = apiInstance.EzsignfolderSendV1(pkiEzsignfolderID, ezsignfolderSendV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderSendV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 
 **ezsignfolderSendV1Request** | [**EzsignfolderSendV1Request**](EzsignfolderSendV1Request.md)|  | 

### Return type

[**EzsignfolderSendV1Response**](EzsignfolderSendV1Response.md)

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


## EzsignfolderSendV2

> EzsignfolderSendV2Response EzsignfolderSendV2 (int pkiEzsignfolderID, EzsignfolderSendV2Request ezsignfolderSendV2Request)

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
    public class EzsignfolderSendV2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 
            var ezsignfolderSendV2Request = new EzsignfolderSendV2Request(); // EzsignfolderSendV2Request | 

            try
            {
                // Send the Ezsignfolder to the signatories for signature
                EzsignfolderSendV2Response result = apiInstance.EzsignfolderSendV2(pkiEzsignfolderID, ezsignfolderSendV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderSendV2: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 
 **ezsignfolderSendV2Request** | [**EzsignfolderSendV2Request**](EzsignfolderSendV2Request.md)|  | 

### Return type

[**EzsignfolderSendV2Response**](EzsignfolderSendV2Response.md)

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


## EzsignfolderUnsendV1

> EzsignfolderUnsendV1Response EzsignfolderUnsendV1 (int pkiEzsignfolderID, Object body)

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfolderApi(Configuration.Default);
            var pkiEzsignfolderID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Unsend the Ezsignfolder
                EzsignfolderUnsendV1Response result = apiInstance.EzsignfolderUnsendV1(pkiEzsignfolderID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfolderApi.EzsignfolderUnsendV1: " + e.Message );
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
 **pkiEzsignfolderID** | **int**|  | 
 **body** | **Object**|  | 

### Return type

[**EzsignfolderUnsendV1Response**](EzsignfolderUnsendV1Response.md)

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


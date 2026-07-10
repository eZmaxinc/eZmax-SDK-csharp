# eZmaxApi.Api.ObjectInscriptionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InscriptionGetAttachmentsV1**](ObjectInscriptionApi.md#inscriptiongetattachmentsv1) | **GET** /1/object/inscription/{pkiInscriptionID}/getAttachments | Retrieve Inscription&#39;s Attachments |
| [**InscriptionGetCommunicationCountV1**](ObjectInscriptionApi.md#inscriptiongetcommunicationcountv1) | **GET** /1/object/inscription/{pkiInscriptionID}/getCommunicationCount | Retrieve Communication count |
| [**InscriptionGetCommunicationListV1**](ObjectInscriptionApi.md#inscriptiongetcommunicationlistv1) | **GET** /1/object/inscription/{pkiInscriptionID}/getCommunicationList | Retrieve Communication list |
| [**InscriptionGetCommunicationrecipientsV1**](ObjectInscriptionApi.md#inscriptiongetcommunicationrecipientsv1) | **GET** /1/object/inscription/{pkiInscriptionID}/getCommunicationrecipients | Retrieve Inscription&#39;s Communicationrecipient |
| [**InscriptionGetCommunicationsendersV1**](ObjectInscriptionApi.md#inscriptiongetcommunicationsendersv1) | **GET** /1/object/inscription/{pkiInscriptionID}/getCommunicationsenders | Retrieve Inscription&#39;s Communicationsender |
| [**InscriptionGetInscriptionnotauthenticatedsV1**](ObjectInscriptionApi.md#inscriptiongetinscriptionnotauthenticatedsv1) | **GET** /1/object/inscription/{pkiInscriptionID}/getInscriptionnotauthenticateds | Retrieve Inscriptionnotauthenticated list |
| [**InscriptionGetListV1**](ObjectInscriptionApi.md#inscriptiongetlistv1) | **GET** /1/object/inscription/getList | Retrieve Inscription list |
| [**InscriptionGetObjectV2**](ObjectInscriptionApi.md#inscriptiongetobjectv2) | **GET** /2/object/inscription/{pkiInscriptionID} | Retrieve an existing Inscription |
| [**InscriptionImportIntoEDMV1**](ObjectInscriptionApi.md#inscriptionimportintoedmv1) | **POST** /1/object/inscription/{pkiInscriptionID}/importIntoEDM | Import attachments into the Inscription |
| [**InscriptionPrepareFilesTransferV1**](ObjectInscriptionApi.md#inscriptionpreparefilestransferv1) | **POST** /1/object/inscription/{pkiInscriptionID}/prepareFilesTransfer | Prepares file transfer into EDM |

<a id="inscriptiongetattachmentsv1"></a>
# **InscriptionGetAttachmentsV1**
> InscriptionGetAttachmentsV1Response InscriptionGetAttachmentsV1 (int pkiInscriptionID)

Retrieve Inscription's Attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionApi(config);
            var pkiInscriptionID = 56;  // int | 

            try
            {
                // Retrieve Inscription's Attachments
                InscriptionGetAttachmentsV1Response result = apiInstance.InscriptionGetAttachmentsV1(pkiInscriptionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Inscription's Attachments
    ApiResponse<InscriptionGetAttachmentsV1Response> response = apiInstance.InscriptionGetAttachmentsV1WithHttpInfo(pkiInscriptionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |

### Return type

[**InscriptionGetAttachmentsV1Response**](InscriptionGetAttachmentsV1Response.md)

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

<a id="inscriptiongetcommunicationcountv1"></a>
# **InscriptionGetCommunicationCountV1**
> InscriptionGetCommunicationCountV1Response InscriptionGetCommunicationCountV1 (int pkiInscriptionID)

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
    public class InscriptionGetCommunicationCountV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionApi(config);
            var pkiInscriptionID = 56;  // int | 

            try
            {
                // Retrieve Communication count
                InscriptionGetCommunicationCountV1Response result = apiInstance.InscriptionGetCommunicationCountV1(pkiInscriptionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetCommunicationCountV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionGetCommunicationCountV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication count
    ApiResponse<InscriptionGetCommunicationCountV1Response> response = apiInstance.InscriptionGetCommunicationCountV1WithHttpInfo(pkiInscriptionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetCommunicationCountV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |

### Return type

[**InscriptionGetCommunicationCountV1Response**](InscriptionGetCommunicationCountV1Response.md)

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

<a id="inscriptiongetcommunicationlistv1"></a>
# **InscriptionGetCommunicationListV1**
> InscriptionGetCommunicationListV1Response InscriptionGetCommunicationListV1 (int pkiInscriptionID)

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
    public class InscriptionGetCommunicationListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionApi(config);
            var pkiInscriptionID = 56;  // int | 

            try
            {
                // Retrieve Communication list
                InscriptionGetCommunicationListV1Response result = apiInstance.InscriptionGetCommunicationListV1(pkiInscriptionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetCommunicationListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionGetCommunicationListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication list
    ApiResponse<InscriptionGetCommunicationListV1Response> response = apiInstance.InscriptionGetCommunicationListV1WithHttpInfo(pkiInscriptionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetCommunicationListV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |

### Return type

[**InscriptionGetCommunicationListV1Response**](InscriptionGetCommunicationListV1Response.md)

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

<a id="inscriptiongetcommunicationrecipientsv1"></a>
# **InscriptionGetCommunicationrecipientsV1**
> InscriptionGetCommunicationrecipientsV1Response InscriptionGetCommunicationrecipientsV1 (int pkiInscriptionID)

Retrieve Inscription's Communicationrecipient

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionGetCommunicationrecipientsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionApi(config);
            var pkiInscriptionID = 56;  // int | 

            try
            {
                // Retrieve Inscription's Communicationrecipient
                InscriptionGetCommunicationrecipientsV1Response result = apiInstance.InscriptionGetCommunicationrecipientsV1(pkiInscriptionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetCommunicationrecipientsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionGetCommunicationrecipientsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Inscription's Communicationrecipient
    ApiResponse<InscriptionGetCommunicationrecipientsV1Response> response = apiInstance.InscriptionGetCommunicationrecipientsV1WithHttpInfo(pkiInscriptionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetCommunicationrecipientsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |

### Return type

[**InscriptionGetCommunicationrecipientsV1Response**](InscriptionGetCommunicationrecipientsV1Response.md)

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

<a id="inscriptiongetcommunicationsendersv1"></a>
# **InscriptionGetCommunicationsendersV1**
> InscriptionGetCommunicationsendersV1Response InscriptionGetCommunicationsendersV1 (int pkiInscriptionID)

Retrieve Inscription's Communicationsender

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionGetCommunicationsendersV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionApi(config);
            var pkiInscriptionID = 56;  // int | 

            try
            {
                // Retrieve Inscription's Communicationsender
                InscriptionGetCommunicationsendersV1Response result = apiInstance.InscriptionGetCommunicationsendersV1(pkiInscriptionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetCommunicationsendersV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionGetCommunicationsendersV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Inscription's Communicationsender
    ApiResponse<InscriptionGetCommunicationsendersV1Response> response = apiInstance.InscriptionGetCommunicationsendersV1WithHttpInfo(pkiInscriptionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetCommunicationsendersV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |

### Return type

[**InscriptionGetCommunicationsendersV1Response**](InscriptionGetCommunicationsendersV1Response.md)

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

<a id="inscriptiongetinscriptionnotauthenticatedsv1"></a>
# **InscriptionGetInscriptionnotauthenticatedsV1**
> InscriptionGetInscriptionnotauthenticatedsV1Response InscriptionGetInscriptionnotauthenticatedsV1 (int pkiInscriptionID)

Retrieve Inscriptionnotauthenticated list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionGetInscriptionnotauthenticatedsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionApi(config);
            var pkiInscriptionID = 56;  // int | 

            try
            {
                // Retrieve Inscriptionnotauthenticated list
                InscriptionGetInscriptionnotauthenticatedsV1Response result = apiInstance.InscriptionGetInscriptionnotauthenticatedsV1(pkiInscriptionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetInscriptionnotauthenticatedsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionGetInscriptionnotauthenticatedsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Inscriptionnotauthenticated list
    ApiResponse<InscriptionGetInscriptionnotauthenticatedsV1Response> response = apiInstance.InscriptionGetInscriptionnotauthenticatedsV1WithHttpInfo(pkiInscriptionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetInscriptionnotauthenticatedsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |

### Return type

[**InscriptionGetInscriptionnotauthenticatedsV1Response**](InscriptionGetInscriptionnotauthenticatedsV1Response.md)

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

<a id="inscriptiongetlistv1"></a>
# **InscriptionGetListV1**
> InscriptionGetListV1Response InscriptionGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Inscription list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eInscriptionStep | TemporaryNotAuthenticated<br>ImportedInscription<br>Inscription<br>ModifiedInscription<br>ContractEnded<br>ExpiredInscription<br>Out-market<br>ImportedNotauthenticated<br>NotAuthenticated<br>ModifiedNotauthenticated<br>Authenticated |  Advanced filters that can be used in query parameter *sFilter*:  | Variable | |- --| | sBrokerNameInscriptor | | sBrokerNameSeller | | sContactFirstnameAgentInscriptor | | sContactLastnameAgentInscriptor | | sContactFirstnameAgentSeller | | sContactLastnameAgentSeller |         | sContactFirstnameBuyer | | sContactLastnameBuyer | | sContactFirstnameSeller | | sContactLastnameSeller |  | sContactFirstnameNotaryBuyer | | sContactLastnameNotaryBuyer |  | sContactFirstnameNotarySeller | | sContactLastnameNotarySeller |         

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionApi(config);
            var eOrderBy = "pkiInscriptionID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Inscription list
                InscriptionGetListV1Response result = apiInstance.InscriptionGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Inscription list
    ApiResponse<InscriptionGetListV1Response> response = apiInstance.InscriptionGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetListV1WithHttpInfo: " + e.Message);
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

[**InscriptionGetListV1Response**](InscriptionGetListV1Response.md)

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

<a id="inscriptiongetobjectv2"></a>
# **InscriptionGetObjectV2**
> InscriptionGetObjectV2Response InscriptionGetObjectV2 (int pkiInscriptionID)

Retrieve an existing Inscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionApi(config);
            var pkiInscriptionID = 56;  // int | The unique ID of the Inscription

            try
            {
                // Retrieve an existing Inscription
                InscriptionGetObjectV2Response result = apiInstance.InscriptionGetObjectV2(pkiInscriptionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Inscription
    ApiResponse<InscriptionGetObjectV2Response> response = apiInstance.InscriptionGetObjectV2WithHttpInfo(pkiInscriptionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** | The unique ID of the Inscription |  |

### Return type

[**InscriptionGetObjectV2Response**](InscriptionGetObjectV2Response.md)

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

<a id="inscriptionimportintoedmv1"></a>
# **InscriptionImportIntoEDMV1**
> InscriptionImportIntoEDMV1Response InscriptionImportIntoEDMV1 (int pkiInscriptionID, InscriptionImportIntoEDMV1Request inscriptionImportIntoEDMV1Request)

Import attachments into the Inscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionApi(config);
            var pkiInscriptionID = 56;  // int | 
            var inscriptionImportIntoEDMV1Request = new InscriptionImportIntoEDMV1Request(); // InscriptionImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Inscription
                InscriptionImportIntoEDMV1Response result = apiInstance.InscriptionImportIntoEDMV1(pkiInscriptionID, inscriptionImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Inscription
    ApiResponse<InscriptionImportIntoEDMV1Response> response = apiInstance.InscriptionImportIntoEDMV1WithHttpInfo(pkiInscriptionID, inscriptionImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |
| **inscriptionImportIntoEDMV1Request** | [**InscriptionImportIntoEDMV1Request**](InscriptionImportIntoEDMV1Request.md) |  |  |

### Return type

[**InscriptionImportIntoEDMV1Response**](InscriptionImportIntoEDMV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inscriptionpreparefilestransferv1"></a>
# **InscriptionPrepareFilesTransferV1**
> InscriptionPrepareFilesTransferV1Response InscriptionPrepareFilesTransferV1 (int pkiInscriptionID, InscriptionPrepareFilesTransferV1Request inscriptionPrepareFilesTransferV1Request)

Prepares file transfer into EDM

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionPrepareFilesTransferV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionApi(config);
            var pkiInscriptionID = 56;  // int | 
            var inscriptionPrepareFilesTransferV1Request = new InscriptionPrepareFilesTransferV1Request(); // InscriptionPrepareFilesTransferV1Request | 

            try
            {
                // Prepares file transfer into EDM
                InscriptionPrepareFilesTransferV1Response result = apiInstance.InscriptionPrepareFilesTransferV1(pkiInscriptionID, inscriptionPrepareFilesTransferV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionPrepareFilesTransferV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionPrepareFilesTransferV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Prepares file transfer into EDM
    ApiResponse<InscriptionPrepareFilesTransferV1Response> response = apiInstance.InscriptionPrepareFilesTransferV1WithHttpInfo(pkiInscriptionID, inscriptionPrepareFilesTransferV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionApi.InscriptionPrepareFilesTransferV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionID** | **int** |  |  |
| **inscriptionPrepareFilesTransferV1Request** | [**InscriptionPrepareFilesTransferV1Request**](InscriptionPrepareFilesTransferV1Request.md) |  |  |

### Return type

[**InscriptionPrepareFilesTransferV1Response**](InscriptionPrepareFilesTransferV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# eZmaxApi.Api.ObjectInscriptionnotauthenticatedApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1**](ObjectInscriptionnotauthenticatedApi.md#inscriptionnotauthenticatedfillinscriptionnotauthenticatedconditionv1) | **POST** /1/object/inscriptionnotauthenticated/{pkiInscriptionnotauthenticatedID}/fillInscriptionnotauthenticatedcondition | Fills the Inscriptionnotauthenticatedcondition in the Inscriptionnotauthenticated |
| [**InscriptionnotauthenticatedGetCommunicationCountV1**](ObjectInscriptionnotauthenticatedApi.md#inscriptionnotauthenticatedgetcommunicationcountv1) | **GET** /1/object/inscriptionnotauthenticated/{pkiInscriptionnotauthenticatedID}/getCommunicationCount | Retrieve Communication count |
| [**InscriptionnotauthenticatedGetCommunicationListV1**](ObjectInscriptionnotauthenticatedApi.md#inscriptionnotauthenticatedgetcommunicationlistv1) | **GET** /1/object/inscriptionnotauthenticated/{pkiInscriptionnotauthenticatedID}/getCommunicationList | Retrieve Communication list |
| [**InscriptionnotauthenticatedGetCommunicationrecipientsV1**](ObjectInscriptionnotauthenticatedApi.md#inscriptionnotauthenticatedgetcommunicationrecipientsv1) | **GET** /1/object/inscriptionnotauthenticated/{pkiInscriptionnotauthenticatedID}/getCommunicationrecipients | Retrieve Inscriptionnotauthenticated&#39;s Communicationrecipient |
| [**InscriptionnotauthenticatedGetCommunicationsendersV1**](ObjectInscriptionnotauthenticatedApi.md#inscriptionnotauthenticatedgetcommunicationsendersv1) | **GET** /1/object/inscriptionnotauthenticated/{pkiInscriptionnotauthenticatedID}/getCommunicationsenders | Retrieve Inscriptionnotauthenticated&#39;s Communicationsender |
| [**InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1**](ObjectInscriptionnotauthenticatedApi.md#inscriptionnotauthenticatedgetinscriptionnotauthenticatedconditionsv1) | **GET** /1/object/inscriptionnotauthenticated/{pkiInscriptionnotauthenticatedID}/getInscriptionnotauthenticatedconditions | Retrieve Inscriptionnotauthenticated conditions |
| [**InscriptionnotauthenticatedGetListV1**](ObjectInscriptionnotauthenticatedApi.md#inscriptionnotauthenticatedgetlistv1) | **GET** /1/object/inscriptionnotauthenticated/getList | Retrieve Inscriptionnotauthenticated list |
| [**InscriptionnotauthenticatedGetObjectV2**](ObjectInscriptionnotauthenticatedApi.md#inscriptionnotauthenticatedgetobjectv2) | **GET** /2/object/inscriptionnotauthenticated/{pkiInscriptionnotauthenticatedID} | Retrieve an existing Inscriptionnotauthenticated |
| [**InscriptionnotauthenticatedImportIntoEDMV1**](ObjectInscriptionnotauthenticatedApi.md#inscriptionnotauthenticatedimportintoedmv1) | **POST** /1/object/inscriptionnotauthenticated/{pkiInscriptionnotauthenticatedID}/importIntoEDM | Import attachments into the Inscriptionnotauthenticated |

<a id="inscriptionnotauthenticatedfillinscriptionnotauthenticatedconditionv1"></a>
# **InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1**
> InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Response InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1 (int pkiInscriptionnotauthenticatedID, InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Request inscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Request)

Fills the Inscriptionnotauthenticatedcondition in the Inscriptionnotauthenticated

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionnotauthenticatedApi(config);
            var pkiInscriptionnotauthenticatedID = 56;  // int | 
            var inscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Request = new InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Request(); // InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Request | 

            try
            {
                // Fills the Inscriptionnotauthenticatedcondition in the Inscriptionnotauthenticated
                InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Response result = apiInstance.InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1(pkiInscriptionnotauthenticatedID, inscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fills the Inscriptionnotauthenticatedcondition in the Inscriptionnotauthenticated
    ApiResponse<InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Response> response = apiInstance.InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1WithHttpInfo(pkiInscriptionnotauthenticatedID, inscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionnotauthenticatedID** | **int** |  |  |
| **inscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Request** | [**InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Request**](InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Request.md) |  |  |

### Return type

[**InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Response**](InscriptionnotauthenticatedFillInscriptionnotauthenticatedconditionV1Response.md)

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

<a id="inscriptionnotauthenticatedgetcommunicationcountv1"></a>
# **InscriptionnotauthenticatedGetCommunicationCountV1**
> InscriptionnotauthenticatedGetCommunicationCountV1Response InscriptionnotauthenticatedGetCommunicationCountV1 (int pkiInscriptionnotauthenticatedID)

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
    public class InscriptionnotauthenticatedGetCommunicationCountV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionnotauthenticatedApi(config);
            var pkiInscriptionnotauthenticatedID = 56;  // int | 

            try
            {
                // Retrieve Communication count
                InscriptionnotauthenticatedGetCommunicationCountV1Response result = apiInstance.InscriptionnotauthenticatedGetCommunicationCountV1(pkiInscriptionnotauthenticatedID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetCommunicationCountV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionnotauthenticatedGetCommunicationCountV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication count
    ApiResponse<InscriptionnotauthenticatedGetCommunicationCountV1Response> response = apiInstance.InscriptionnotauthenticatedGetCommunicationCountV1WithHttpInfo(pkiInscriptionnotauthenticatedID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetCommunicationCountV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionnotauthenticatedID** | **int** |  |  |

### Return type

[**InscriptionnotauthenticatedGetCommunicationCountV1Response**](InscriptionnotauthenticatedGetCommunicationCountV1Response.md)

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

<a id="inscriptionnotauthenticatedgetcommunicationlistv1"></a>
# **InscriptionnotauthenticatedGetCommunicationListV1**
> InscriptionnotauthenticatedGetCommunicationListV1Response InscriptionnotauthenticatedGetCommunicationListV1 (int pkiInscriptionnotauthenticatedID)

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
    public class InscriptionnotauthenticatedGetCommunicationListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionnotauthenticatedApi(config);
            var pkiInscriptionnotauthenticatedID = 56;  // int | 

            try
            {
                // Retrieve Communication list
                InscriptionnotauthenticatedGetCommunicationListV1Response result = apiInstance.InscriptionnotauthenticatedGetCommunicationListV1(pkiInscriptionnotauthenticatedID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetCommunicationListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionnotauthenticatedGetCommunicationListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication list
    ApiResponse<InscriptionnotauthenticatedGetCommunicationListV1Response> response = apiInstance.InscriptionnotauthenticatedGetCommunicationListV1WithHttpInfo(pkiInscriptionnotauthenticatedID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetCommunicationListV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionnotauthenticatedID** | **int** |  |  |

### Return type

[**InscriptionnotauthenticatedGetCommunicationListV1Response**](InscriptionnotauthenticatedGetCommunicationListV1Response.md)

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

<a id="inscriptionnotauthenticatedgetcommunicationrecipientsv1"></a>
# **InscriptionnotauthenticatedGetCommunicationrecipientsV1**
> InscriptionnotauthenticatedGetCommunicationrecipientsV1Response InscriptionnotauthenticatedGetCommunicationrecipientsV1 (int pkiInscriptionnotauthenticatedID)

Retrieve Inscriptionnotauthenticated's Communicationrecipient

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionnotauthenticatedGetCommunicationrecipientsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionnotauthenticatedApi(config);
            var pkiInscriptionnotauthenticatedID = 56;  // int | 

            try
            {
                // Retrieve Inscriptionnotauthenticated's Communicationrecipient
                InscriptionnotauthenticatedGetCommunicationrecipientsV1Response result = apiInstance.InscriptionnotauthenticatedGetCommunicationrecipientsV1(pkiInscriptionnotauthenticatedID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetCommunicationrecipientsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionnotauthenticatedGetCommunicationrecipientsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Inscriptionnotauthenticated's Communicationrecipient
    ApiResponse<InscriptionnotauthenticatedGetCommunicationrecipientsV1Response> response = apiInstance.InscriptionnotauthenticatedGetCommunicationrecipientsV1WithHttpInfo(pkiInscriptionnotauthenticatedID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetCommunicationrecipientsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionnotauthenticatedID** | **int** |  |  |

### Return type

[**InscriptionnotauthenticatedGetCommunicationrecipientsV1Response**](InscriptionnotauthenticatedGetCommunicationrecipientsV1Response.md)

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

<a id="inscriptionnotauthenticatedgetcommunicationsendersv1"></a>
# **InscriptionnotauthenticatedGetCommunicationsendersV1**
> InscriptionnotauthenticatedGetCommunicationsendersV1Response InscriptionnotauthenticatedGetCommunicationsendersV1 (int pkiInscriptionnotauthenticatedID)

Retrieve Inscriptionnotauthenticated's Communicationsender

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionnotauthenticatedGetCommunicationsendersV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionnotauthenticatedApi(config);
            var pkiInscriptionnotauthenticatedID = 56;  // int | 

            try
            {
                // Retrieve Inscriptionnotauthenticated's Communicationsender
                InscriptionnotauthenticatedGetCommunicationsendersV1Response result = apiInstance.InscriptionnotauthenticatedGetCommunicationsendersV1(pkiInscriptionnotauthenticatedID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetCommunicationsendersV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionnotauthenticatedGetCommunicationsendersV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Inscriptionnotauthenticated's Communicationsender
    ApiResponse<InscriptionnotauthenticatedGetCommunicationsendersV1Response> response = apiInstance.InscriptionnotauthenticatedGetCommunicationsendersV1WithHttpInfo(pkiInscriptionnotauthenticatedID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetCommunicationsendersV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionnotauthenticatedID** | **int** |  |  |

### Return type

[**InscriptionnotauthenticatedGetCommunicationsendersV1Response**](InscriptionnotauthenticatedGetCommunicationsendersV1Response.md)

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

<a id="inscriptionnotauthenticatedgetinscriptionnotauthenticatedconditionsv1"></a>
# **InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1**
> InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1Response InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1 (int pkiInscriptionnotauthenticatedID)

Retrieve Inscriptionnotauthenticated conditions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionnotauthenticatedApi(config);
            var pkiInscriptionnotauthenticatedID = 56;  // int | 

            try
            {
                // Retrieve Inscriptionnotauthenticated conditions
                InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1Response result = apiInstance.InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1(pkiInscriptionnotauthenticatedID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Inscriptionnotauthenticated conditions
    ApiResponse<InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1Response> response = apiInstance.InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1WithHttpInfo(pkiInscriptionnotauthenticatedID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionnotauthenticatedID** | **int** |  |  |

### Return type

[**InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1Response**](InscriptionnotauthenticatedGetInscriptionnotauthenticatedconditionsV1Response.md)

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

<a id="inscriptionnotauthenticatedgetlistv1"></a>
# **InscriptionnotauthenticatedGetListV1**
> InscriptionnotauthenticatedGetListV1Response InscriptionnotauthenticatedGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Inscriptionnotauthenticated list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eInscriptionStep | TemporaryNotAuthenticated<br>ImportedInscription<br>Inscription<br>ModifiedInscription<br>ContractEnded<br>ExpiredInscription<br>Out-market<br>ImportedNotauthenticated<br>NotAuthenticated<br>ModifiedNotauthenticated<br>Authenticated |

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionnotauthenticatedGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionnotauthenticatedApi(config);
            var eOrderBy = "pkiInscriptionID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Inscriptionnotauthenticated list
                InscriptionnotauthenticatedGetListV1Response result = apiInstance.InscriptionnotauthenticatedGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionnotauthenticatedGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Inscriptionnotauthenticated list
    ApiResponse<InscriptionnotauthenticatedGetListV1Response> response = apiInstance.InscriptionnotauthenticatedGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetListV1WithHttpInfo: " + e.Message);
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

[**InscriptionnotauthenticatedGetListV1Response**](InscriptionnotauthenticatedGetListV1Response.md)

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

<a id="inscriptionnotauthenticatedgetobjectv2"></a>
# **InscriptionnotauthenticatedGetObjectV2**
> InscriptionnotauthenticatedGetObjectV2Response InscriptionnotauthenticatedGetObjectV2 (int pkiInscriptionnotauthenticatedID)

Retrieve an existing Inscriptionnotauthenticated

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionnotauthenticatedGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionnotauthenticatedApi(config);
            var pkiInscriptionnotauthenticatedID = 56;  // int | The unique ID of the Inscriptionnotauthenticated

            try
            {
                // Retrieve an existing Inscriptionnotauthenticated
                InscriptionnotauthenticatedGetObjectV2Response result = apiInstance.InscriptionnotauthenticatedGetObjectV2(pkiInscriptionnotauthenticatedID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionnotauthenticatedGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Inscriptionnotauthenticated
    ApiResponse<InscriptionnotauthenticatedGetObjectV2Response> response = apiInstance.InscriptionnotauthenticatedGetObjectV2WithHttpInfo(pkiInscriptionnotauthenticatedID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionnotauthenticatedID** | **int** | The unique ID of the Inscriptionnotauthenticated |  |

### Return type

[**InscriptionnotauthenticatedGetObjectV2Response**](InscriptionnotauthenticatedGetObjectV2Response.md)

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

<a id="inscriptionnotauthenticatedimportintoedmv1"></a>
# **InscriptionnotauthenticatedImportIntoEDMV1**
> InscriptionnotauthenticatedImportIntoEDMV1Response InscriptionnotauthenticatedImportIntoEDMV1 (int pkiInscriptionnotauthenticatedID, InscriptionnotauthenticatedImportIntoEDMV1Request inscriptionnotauthenticatedImportIntoEDMV1Request)

Import attachments into the Inscriptionnotauthenticated

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class InscriptionnotauthenticatedImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectInscriptionnotauthenticatedApi(config);
            var pkiInscriptionnotauthenticatedID = 56;  // int | 
            var inscriptionnotauthenticatedImportIntoEDMV1Request = new InscriptionnotauthenticatedImportIntoEDMV1Request(); // InscriptionnotauthenticatedImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Inscriptionnotauthenticated
                InscriptionnotauthenticatedImportIntoEDMV1Response result = apiInstance.InscriptionnotauthenticatedImportIntoEDMV1(pkiInscriptionnotauthenticatedID, inscriptionnotauthenticatedImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InscriptionnotauthenticatedImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Inscriptionnotauthenticated
    ApiResponse<InscriptionnotauthenticatedImportIntoEDMV1Response> response = apiInstance.InscriptionnotauthenticatedImportIntoEDMV1WithHttpInfo(pkiInscriptionnotauthenticatedID, inscriptionnotauthenticatedImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectInscriptionnotauthenticatedApi.InscriptionnotauthenticatedImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiInscriptionnotauthenticatedID** | **int** |  |  |
| **inscriptionnotauthenticatedImportIntoEDMV1Request** | [**InscriptionnotauthenticatedImportIntoEDMV1Request**](InscriptionnotauthenticatedImportIntoEDMV1Request.md) |  |  |

### Return type

[**InscriptionnotauthenticatedImportIntoEDMV1Response**](InscriptionnotauthenticatedImportIntoEDMV1Response.md)

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


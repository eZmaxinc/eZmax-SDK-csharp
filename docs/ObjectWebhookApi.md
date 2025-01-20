# eZmaxApi.Api.ObjectWebhookApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WebhookCreateObjectV2**](ObjectWebhookApi.md#webhookcreateobjectv2) | **POST** /2/object/webhook | Create a new Webhook |
| [**WebhookDeleteObjectV1**](ObjectWebhookApi.md#webhookdeleteobjectv1) | **DELETE** /1/object/webhook/{pkiWebhookID} | Delete an existing Webhook |
| [**WebhookEditObjectV1**](ObjectWebhookApi.md#webhookeditobjectv1) | **PUT** /1/object/webhook/{pkiWebhookID} | Edit an existing Webhook |
| [**WebhookGetHistoryV1**](ObjectWebhookApi.md#webhookgethistoryv1) | **GET** /1/object/webhook/{pkiWebhookID}/getHistory | Retrieve the logs for recent Webhook calls |
| [**WebhookGetListV1**](ObjectWebhookApi.md#webhookgetlistv1) | **GET** /1/object/webhook/getList | Retrieve Webhook list |
| [**WebhookGetObjectV2**](ObjectWebhookApi.md#webhookgetobjectv2) | **GET** /2/object/webhook/{pkiWebhookID} | Retrieve an existing Webhook |
| [**WebhookRegenerateApikeyV1**](ObjectWebhookApi.md#webhookregenerateapikeyv1) | **POST** /1/object/webhook/{pkiWebhookID}/regenerateApikey | Regenerate the Apikey |
| [**WebhookSendWebhookV1**](ObjectWebhookApi.md#webhooksendwebhookv1) | **POST** /1/object/webhook/sendWebhook | Emit a Webhook event |
| [**WebhookTestV1**](ObjectWebhookApi.md#webhooktestv1) | **POST** /1/object/webhook/{pkiWebhookID}/test | Test the Webhook by calling the Url |

<a id="webhookcreateobjectv2"></a>
# **WebhookCreateObjectV2**
> WebhookCreateObjectV2Response WebhookCreateObjectV2 (WebhookCreateObjectV2Request webhookCreateObjectV2Request)

Create a new Webhook

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
    public class WebhookCreateObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(config);
            var webhookCreateObjectV2Request = new WebhookCreateObjectV2Request(); // WebhookCreateObjectV2Request | 

            try
            {
                // Create a new Webhook
                WebhookCreateObjectV2Response result = apiInstance.WebhookCreateObjectV2(webhookCreateObjectV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookCreateObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookCreateObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Webhook
    ApiResponse<WebhookCreateObjectV2Response> response = apiInstance.WebhookCreateObjectV2WithHttpInfo(webhookCreateObjectV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectWebhookApi.WebhookCreateObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookCreateObjectV2Request** | [**WebhookCreateObjectV2Request**](WebhookCreateObjectV2Request.md) |  |  |

### Return type

[**WebhookCreateObjectV2Response**](WebhookCreateObjectV2Response.md)

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

<a id="webhookdeleteobjectv1"></a>
# **WebhookDeleteObjectV1**
> CommonResponse WebhookDeleteObjectV1 (int pkiWebhookID)

Delete an existing Webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class WebhookDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(config);
            var pkiWebhookID = 56;  // int | 

            try
            {
                // Delete an existing Webhook
                CommonResponse result = apiInstance.WebhookDeleteObjectV1(pkiWebhookID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Webhook
    ApiResponse<CommonResponse> response = apiInstance.WebhookDeleteObjectV1WithHttpInfo(pkiWebhookID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectWebhookApi.WebhookDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiWebhookID** | **int** |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="webhookeditobjectv1"></a>
# **WebhookEditObjectV1**
> CommonResponse WebhookEditObjectV1 (int pkiWebhookID, WebhookEditObjectV1Request webhookEditObjectV1Request)

Edit an existing Webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class WebhookEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(config);
            var pkiWebhookID = 56;  // int | 
            var webhookEditObjectV1Request = new WebhookEditObjectV1Request(); // WebhookEditObjectV1Request | 

            try
            {
                // Edit an existing Webhook
                CommonResponse result = apiInstance.WebhookEditObjectV1(pkiWebhookID, webhookEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Webhook
    ApiResponse<CommonResponse> response = apiInstance.WebhookEditObjectV1WithHttpInfo(pkiWebhookID, webhookEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectWebhookApi.WebhookEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiWebhookID** | **int** |  |  |
| **webhookEditObjectV1Request** | [**WebhookEditObjectV1Request**](WebhookEditObjectV1Request.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="webhookgethistoryv1"></a>
# **WebhookGetHistoryV1**
> WebhookGetHistoryV1Response WebhookGetHistoryV1 (int pkiWebhookID, string eWebhookHistoryinterval)

Retrieve the logs for recent Webhook calls

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class WebhookGetHistoryV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(config);
            var pkiWebhookID = 56;  // int | 
            var eWebhookHistoryinterval = "LastDay";  // string | The number of days to return

            try
            {
                // Retrieve the logs for recent Webhook calls
                WebhookGetHistoryV1Response result = apiInstance.WebhookGetHistoryV1(pkiWebhookID, eWebhookHistoryinterval);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookGetHistoryV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookGetHistoryV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the logs for recent Webhook calls
    ApiResponse<WebhookGetHistoryV1Response> response = apiInstance.WebhookGetHistoryV1WithHttpInfo(pkiWebhookID, eWebhookHistoryinterval);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectWebhookApi.WebhookGetHistoryV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiWebhookID** | **int** |  |  |
| **eWebhookHistoryinterval** | **string** | The number of days to return |  |

### Return type

[**WebhookGetHistoryV1Response**](WebhookGetHistoryV1Response.md)

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
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="webhookgetlistv1"></a>
# **WebhookGetListV1**
> WebhookGetListV1Response WebhookGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Webhook list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eWebhookModule | Ezsign<br>Management | | eWebhookEzsignevent | DocumentCompleted<br>FolderCompleted | | eWebhookManagementevent | UserCreated |

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class WebhookGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(config);
            var eOrderBy = "pkiWebhookID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Webhook list
                WebhookGetListV1Response result = apiInstance.WebhookGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Webhook list
    ApiResponse<WebhookGetListV1Response> response = apiInstance.WebhookGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectWebhookApi.WebhookGetListV1WithHttpInfo: " + e.Message);
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

[**WebhookGetListV1Response**](WebhookGetListV1Response.md)

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

<a id="webhookgetobjectv2"></a>
# **WebhookGetObjectV2**
> WebhookGetObjectV2Response WebhookGetObjectV2 (int pkiWebhookID)

Retrieve an existing Webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class WebhookGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(config);
            var pkiWebhookID = 56;  // int | 

            try
            {
                // Retrieve an existing Webhook
                WebhookGetObjectV2Response result = apiInstance.WebhookGetObjectV2(pkiWebhookID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Webhook
    ApiResponse<WebhookGetObjectV2Response> response = apiInstance.WebhookGetObjectV2WithHttpInfo(pkiWebhookID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectWebhookApi.WebhookGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiWebhookID** | **int** |  |  |

### Return type

[**WebhookGetObjectV2Response**](WebhookGetObjectV2Response.md)

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

<a id="webhookregenerateapikeyv1"></a>
# **WebhookRegenerateApikeyV1**
> WebhookRegenerateApikeyV1Response WebhookRegenerateApikeyV1 (int pkiWebhookID, WebhookRegenerateApikeyV1Request webhookRegenerateApikeyV1Request)

Regenerate the Apikey

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class WebhookRegenerateApikeyV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(config);
            var pkiWebhookID = 56;  // int | 
            var webhookRegenerateApikeyV1Request = new WebhookRegenerateApikeyV1Request(); // WebhookRegenerateApikeyV1Request | 

            try
            {
                // Regenerate the Apikey
                WebhookRegenerateApikeyV1Response result = apiInstance.WebhookRegenerateApikeyV1(pkiWebhookID, webhookRegenerateApikeyV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookRegenerateApikeyV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookRegenerateApikeyV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Regenerate the Apikey
    ApiResponse<WebhookRegenerateApikeyV1Response> response = apiInstance.WebhookRegenerateApikeyV1WithHttpInfo(pkiWebhookID, webhookRegenerateApikeyV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectWebhookApi.WebhookRegenerateApikeyV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiWebhookID** | **int** |  |  |
| **webhookRegenerateApikeyV1Request** | [**WebhookRegenerateApikeyV1Request**](WebhookRegenerateApikeyV1Request.md) |  |  |

### Return type

[**WebhookRegenerateApikeyV1Response**](WebhookRegenerateApikeyV1Response.md)

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

<a id="webhooksendwebhookv1"></a>
# **WebhookSendWebhookV1**
> CommonResponse WebhookSendWebhookV1 (WebhookSendWebhookV1Request webhookSendWebhookV1Request)

Emit a Webhook event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class WebhookSendWebhookV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(config);
            var webhookSendWebhookV1Request = new WebhookSendWebhookV1Request(); // WebhookSendWebhookV1Request | 

            try
            {
                // Emit a Webhook event
                CommonResponse result = apiInstance.WebhookSendWebhookV1(webhookSendWebhookV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookSendWebhookV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookSendWebhookV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Emit a Webhook event
    ApiResponse<CommonResponse> response = apiInstance.WebhookSendWebhookV1WithHttpInfo(webhookSendWebhookV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectWebhookApi.WebhookSendWebhookV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookSendWebhookV1Request** | [**WebhookSendWebhookV1Request**](WebhookSendWebhookV1Request.md) |  |  |

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="webhooktestv1"></a>
# **WebhookTestV1**
> CommonResponse WebhookTestV1 (int pkiWebhookID, Object body)

Test the Webhook by calling the Url

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class WebhookTestV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(config);
            var pkiWebhookID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Test the Webhook by calling the Url
                CommonResponse result = apiInstance.WebhookTestV1(pkiWebhookID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookTestV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookTestV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Test the Webhook by calling the Url
    ApiResponse<CommonResponse> response = apiInstance.WebhookTestV1WithHttpInfo(pkiWebhookID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectWebhookApi.WebhookTestV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiWebhookID** | **int** |  |  |
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


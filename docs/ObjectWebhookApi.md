# eZmaxApi.Api.ObjectWebhookApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WebhookCreateObjectV1**](ObjectWebhookApi.md#webhookcreateobjectv1) | **POST** /1/object/webhook | Create a new Webhook
[**WebhookDeleteObjectV1**](ObjectWebhookApi.md#webhookdeleteobjectv1) | **DELETE** /1/object/webhook/{pkiWebhookID} | Delete an existing Webhook
[**WebhookEditObjectV1**](ObjectWebhookApi.md#webhookeditobjectv1) | **PUT** /1/object/webhook/{pkiWebhookID} | Edit an existing Webhook
[**WebhookGetHistoryV1**](ObjectWebhookApi.md#webhookgethistoryv1) | **GET** /1/object/webhook/{pkiWebhookID}/getHistory | Retrieve the logs for recent Webhook calls
[**WebhookGetListV1**](ObjectWebhookApi.md#webhookgetlistv1) | **GET** /1/object/webhook/getList | Retrieve Webhook list
[**WebhookGetObjectV1**](ObjectWebhookApi.md#webhookgetobjectv1) | **GET** /1/object/webhook/{pkiWebhookID} | Retrieve an existing Webhook
[**WebhookTestUrlV1**](ObjectWebhookApi.md#webhooktesturlv1) | **POST** /1/object/webhook/{pkiWebhookID}/test | Test the Webhook by calling the Url



## WebhookCreateObjectV1

> WebhookCreateObjectV1Response WebhookCreateObjectV1 (WebhookCreateObjectV1Request webhookCreateObjectV1Request)

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
    public class WebhookCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(Configuration.Default);
            var webhookCreateObjectV1Request = new WebhookCreateObjectV1Request(); // WebhookCreateObjectV1Request | 

            try
            {
                // Create a new Webhook
                WebhookCreateObjectV1Response result = apiInstance.WebhookCreateObjectV1(webhookCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookCreateObjectV1: " + e.Message );
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
 **webhookCreateObjectV1Request** | [**WebhookCreateObjectV1Request**](WebhookCreateObjectV1Request.md)|  | 

### Return type

[**WebhookCreateObjectV1Response**](WebhookCreateObjectV1Response.md)

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


## WebhookDeleteObjectV1

> WebhookDeleteObjectV1Response WebhookDeleteObjectV1 (int pkiWebhookID)

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(Configuration.Default);
            var pkiWebhookID = 56;  // int | 

            try
            {
                // Delete an existing Webhook
                WebhookDeleteObjectV1Response result = apiInstance.WebhookDeleteObjectV1(pkiWebhookID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookDeleteObjectV1: " + e.Message );
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
 **pkiWebhookID** | **int**|  | 

### Return type

[**WebhookDeleteObjectV1Response**](WebhookDeleteObjectV1Response.md)

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


## WebhookEditObjectV1

> WebhookEditObjectV1Response WebhookEditObjectV1 (int pkiWebhookID, WebhookEditObjectV1Request webhookEditObjectV1Request)

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(Configuration.Default);
            var pkiWebhookID = 56;  // int | 
            var webhookEditObjectV1Request = new WebhookEditObjectV1Request(); // WebhookEditObjectV1Request | 

            try
            {
                // Edit an existing Webhook
                WebhookEditObjectV1Response result = apiInstance.WebhookEditObjectV1(pkiWebhookID, webhookEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookEditObjectV1: " + e.Message );
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
 **pkiWebhookID** | **int**|  | 
 **webhookEditObjectV1Request** | [**WebhookEditObjectV1Request**](WebhookEditObjectV1Request.md)|  | 

### Return type

[**WebhookEditObjectV1Response**](WebhookEditObjectV1Response.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WebhookGetHistoryV1

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(Configuration.Default);
            var pkiWebhookID = 56;  // int | 
            var eWebhookHistoryinterval = "LastDay";  // string | The number of days to return

            try
            {
                // Retrieve the logs for recent Webhook calls
                WebhookGetHistoryV1Response result = apiInstance.WebhookGetHistoryV1(pkiWebhookID, eWebhookHistoryinterval);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookGetHistoryV1: " + e.Message );
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
 **pkiWebhookID** | **int**|  | 
 **eWebhookHistoryinterval** | **string**| The number of days to return | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WebhookGetListV1

> WebhookGetListV1Response WebhookGetListV1 (string eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string sFilter = null)

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
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(Configuration.Default);
            var eOrderBy = "pkiWebhookID_ASC";  // string | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 56;  // int? |  (optional) 
            var acceptLanguage = (HeaderAcceptLanguage) "*";  // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string |  (optional) 

            try
            {
                // Retrieve Webhook list
                WebhookGetListV1Response result = apiInstance.WebhookGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookGetListV1: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WebhookGetObjectV1

> WebhookGetObjectV1Response WebhookGetObjectV1 (int pkiWebhookID)

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
    public class WebhookGetObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(Configuration.Default);
            var pkiWebhookID = 56;  // int | 

            try
            {
                // Retrieve an existing Webhook
                WebhookGetObjectV1Response result = apiInstance.WebhookGetObjectV1(pkiWebhookID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookGetObjectV1: " + e.Message );
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
 **pkiWebhookID** | **int**|  | 

### Return type

[**WebhookGetObjectV1Response**](WebhookGetObjectV1Response.md)

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


## WebhookTestUrlV1

> WebhookTestV1Response WebhookTestUrlV1 (int pkiWebhookID)

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
    public class WebhookTestUrlV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectWebhookApi(Configuration.Default);
            var pkiWebhookID = 56;  // int | 

            try
            {
                // Test the Webhook by calling the Url
                WebhookTestV1Response result = apiInstance.WebhookTestUrlV1(pkiWebhookID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectWebhookApi.WebhookTestUrlV1: " + e.Message );
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
 **pkiWebhookID** | **int**|  | 

### Return type

[**WebhookTestV1Response**](WebhookTestV1Response.md)

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


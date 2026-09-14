# eZmaxApi.Api.ObjectBrokerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BrokerBatchDownloadV1**](ObjectBrokerApi.md#brokerbatchdownloadv1) | **POST** /1/object/broker/{pkiBrokerID}/batchDownload | Download multiples attachments from a Broker |
| [**BrokerGetAttachmentsV1**](ObjectBrokerApi.md#brokergetattachmentsv1) | **GET** /1/object/broker/{pkiBrokerID}/getAttachments | Retrieve Broker&#39;s attachments |
| [**BrokerGetAutocompleteV2**](ObjectBrokerApi.md#brokergetautocompletev2) | **GET** /2/object/broker/getAutocomplete/{sSelector} | Retrieve Brokers and IDs |
| [**BrokerGetCommunicationCountV1**](ObjectBrokerApi.md#brokergetcommunicationcountv1) | **GET** /1/object/broker/{pkiBrokerID}/getCommunicationCount | Retrieve Communication count |
| [**BrokerGetCommunicationListV1**](ObjectBrokerApi.md#brokergetcommunicationlistv1) | **GET** /1/object/broker/{pkiBrokerID}/getCommunicationList | Retrieve Communication list |
| [**BrokerGetCommunicationrecipientsV1**](ObjectBrokerApi.md#brokergetcommunicationrecipientsv1) | **GET** /1/object/broker/{pkiBrokerID}/getCommunicationrecipients | Retrieve Communication recipients |
| [**BrokerGetCommunicationsendersV1**](ObjectBrokerApi.md#brokergetcommunicationsendersv1) | **GET** /1/object/broker/{pkiBrokerID}/getCommunicationsenders | Retrieve Communication senders |
| [**BrokerGetListV1**](ObjectBrokerApi.md#brokergetlistv1) | **GET** /1/object/broker/getList | Retrieve Broker list |
| [**BrokerImportIntoEDMV1**](ObjectBrokerApi.md#brokerimportintoedmv1) | **POST** /1/object/broker/{pkiBrokerID}/importIntoEDM | Import attachments into the Broker |

<a id="brokerbatchdownloadv1"></a>
# **BrokerBatchDownloadV1**
> System.IO.Stream BrokerBatchDownloadV1 (int pkiBrokerID, BrokerBatchDownloadV1Request brokerBatchDownloadV1Request)

Download multiples attachments from a Broker

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class BrokerBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectBrokerApi(config);
            var pkiBrokerID = 56;  // int | 
            var brokerBatchDownloadV1Request = new BrokerBatchDownloadV1Request(); // BrokerBatchDownloadV1Request | 

            try
            {
                // Download multiples attachments from a Broker
                System.IO.Stream result = apiInstance.BrokerBatchDownloadV1(pkiBrokerID, brokerBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectBrokerApi.BrokerBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BrokerBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples attachments from a Broker
    ApiResponse<System.IO.Stream> response = apiInstance.BrokerBatchDownloadV1WithHttpInfo(pkiBrokerID, brokerBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectBrokerApi.BrokerBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBrokerID** | **int** |  |  |
| **brokerBatchDownloadV1Request** | [**BrokerBatchDownloadV1Request**](BrokerBatchDownloadV1Request.md) |  |  |

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/zip, text/xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="brokergetattachmentsv1"></a>
# **BrokerGetAttachmentsV1**
> BrokerGetAttachmentsV1Response BrokerGetAttachmentsV1 (int pkiBrokerID)

Retrieve Broker's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class BrokerGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectBrokerApi(config);
            var pkiBrokerID = 56;  // int | 

            try
            {
                // Retrieve Broker's attachments
                BrokerGetAttachmentsV1Response result = apiInstance.BrokerGetAttachmentsV1(pkiBrokerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BrokerGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Broker's attachments
    ApiResponse<BrokerGetAttachmentsV1Response> response = apiInstance.BrokerGetAttachmentsV1WithHttpInfo(pkiBrokerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBrokerID** | **int** |  |  |

### Return type

[**BrokerGetAttachmentsV1Response**](BrokerGetAttachmentsV1Response.md)

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

<a id="brokergetautocompletev2"></a>
# **BrokerGetAutocompleteV2**
> BrokerGetAutocompleteV2Response BrokerGetAutocompleteV2 (string sSelector, string? eFilterActive = null, string? sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Brokers and IDs

Get the list of Broker to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class BrokerGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectBrokerApi(config);
            var sSelector = "All";  // string | The type of Brokers to return
            var eFilterActive = "All";  // string? | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string? | Allow to filter the returned results (optional) 
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Brokers and IDs
                BrokerGetAutocompleteV2Response result = apiInstance.BrokerGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetAutocompleteV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BrokerGetAutocompleteV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Brokers and IDs
    ApiResponse<BrokerGetAutocompleteV2Response> response = apiInstance.BrokerGetAutocompleteV2WithHttpInfo(sSelector, eFilterActive, sQuery, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetAutocompleteV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Brokers to return |  |
| **eFilterActive** | **string?** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string?** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |

### Return type

[**BrokerGetAutocompleteV2Response**](BrokerGetAutocompleteV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="brokergetcommunicationcountv1"></a>
# **BrokerGetCommunicationCountV1**
> BrokerGetCommunicationCountV1Response BrokerGetCommunicationCountV1 (int pkiBrokerID)

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
    public class BrokerGetCommunicationCountV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectBrokerApi(config);
            var pkiBrokerID = 56;  // int | 

            try
            {
                // Retrieve Communication count
                BrokerGetCommunicationCountV1Response result = apiInstance.BrokerGetCommunicationCountV1(pkiBrokerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetCommunicationCountV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BrokerGetCommunicationCountV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication count
    ApiResponse<BrokerGetCommunicationCountV1Response> response = apiInstance.BrokerGetCommunicationCountV1WithHttpInfo(pkiBrokerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetCommunicationCountV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBrokerID** | **int** |  |  |

### Return type

[**BrokerGetCommunicationCountV1Response**](BrokerGetCommunicationCountV1Response.md)

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

<a id="brokergetcommunicationlistv1"></a>
# **BrokerGetCommunicationListV1**
> BrokerGetCommunicationListV1Response BrokerGetCommunicationListV1 (int pkiBrokerID)

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
    public class BrokerGetCommunicationListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectBrokerApi(config);
            var pkiBrokerID = 56;  // int | 

            try
            {
                // Retrieve Communication list
                BrokerGetCommunicationListV1Response result = apiInstance.BrokerGetCommunicationListV1(pkiBrokerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetCommunicationListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BrokerGetCommunicationListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication list
    ApiResponse<BrokerGetCommunicationListV1Response> response = apiInstance.BrokerGetCommunicationListV1WithHttpInfo(pkiBrokerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetCommunicationListV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBrokerID** | **int** |  |  |

### Return type

[**BrokerGetCommunicationListV1Response**](BrokerGetCommunicationListV1Response.md)

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

<a id="brokergetcommunicationrecipientsv1"></a>
# **BrokerGetCommunicationrecipientsV1**
> BrokerGetCommunicationrecipientsV1Response BrokerGetCommunicationrecipientsV1 (int pkiBrokerID)

Retrieve Communication recipients

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class BrokerGetCommunicationrecipientsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectBrokerApi(config);
            var pkiBrokerID = 56;  // int | 

            try
            {
                // Retrieve Communication recipients
                BrokerGetCommunicationrecipientsV1Response result = apiInstance.BrokerGetCommunicationrecipientsV1(pkiBrokerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetCommunicationrecipientsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BrokerGetCommunicationrecipientsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication recipients
    ApiResponse<BrokerGetCommunicationrecipientsV1Response> response = apiInstance.BrokerGetCommunicationrecipientsV1WithHttpInfo(pkiBrokerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetCommunicationrecipientsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBrokerID** | **int** |  |  |

### Return type

[**BrokerGetCommunicationrecipientsV1Response**](BrokerGetCommunicationrecipientsV1Response.md)

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

<a id="brokergetcommunicationsendersv1"></a>
# **BrokerGetCommunicationsendersV1**
> BrokerGetCommunicationsendersV1Response BrokerGetCommunicationsendersV1 (int pkiBrokerID)

Retrieve Communication senders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class BrokerGetCommunicationsendersV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectBrokerApi(config);
            var pkiBrokerID = 56;  // int | 

            try
            {
                // Retrieve Communication senders
                BrokerGetCommunicationsendersV1Response result = apiInstance.BrokerGetCommunicationsendersV1(pkiBrokerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetCommunicationsendersV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BrokerGetCommunicationsendersV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication senders
    ApiResponse<BrokerGetCommunicationsendersV1Response> response = apiInstance.BrokerGetCommunicationsendersV1WithHttpInfo(pkiBrokerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetCommunicationsendersV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBrokerID** | **int** |  |  |

### Return type

[**BrokerGetCommunicationsendersV1Response**](BrokerGetCommunicationsendersV1Response.md)

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

<a id="brokergetlistv1"></a>
# **BrokerGetListV1**
> BrokerGetListV1Response BrokerGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Broker list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class BrokerGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectBrokerApi(config);
            var eOrderBy = "pkiBrokerID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Broker list
                BrokerGetListV1Response result = apiInstance.BrokerGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BrokerGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Broker list
    ApiResponse<BrokerGetListV1Response> response = apiInstance.BrokerGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectBrokerApi.BrokerGetListV1WithHttpInfo: " + e.Message);
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

[**BrokerGetListV1Response**](BrokerGetListV1Response.md)

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

<a id="brokerimportintoedmv1"></a>
# **BrokerImportIntoEDMV1**
> BrokerImportIntoEDMV1Response BrokerImportIntoEDMV1 (int pkiBrokerID, BrokerImportIntoEDMV1Request brokerImportIntoEDMV1Request)

Import attachments into the Broker

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class BrokerImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectBrokerApi(config);
            var pkiBrokerID = 56;  // int | 
            var brokerImportIntoEDMV1Request = new BrokerImportIntoEDMV1Request(); // BrokerImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Broker
                BrokerImportIntoEDMV1Response result = apiInstance.BrokerImportIntoEDMV1(pkiBrokerID, brokerImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectBrokerApi.BrokerImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BrokerImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Broker
    ApiResponse<BrokerImportIntoEDMV1Response> response = apiInstance.BrokerImportIntoEDMV1WithHttpInfo(pkiBrokerID, brokerImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectBrokerApi.BrokerImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBrokerID** | **int** |  |  |
| **brokerImportIntoEDMV1Request** | [**BrokerImportIntoEDMV1Request**](BrokerImportIntoEDMV1Request.md) |  |  |

### Return type

[**BrokerImportIntoEDMV1Response**](BrokerImportIntoEDMV1Response.md)

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


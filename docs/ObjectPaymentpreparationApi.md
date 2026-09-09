# eZmaxApi.Api.ObjectPaymentpreparationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PaymentpreparationBatchDownloadV1**](ObjectPaymentpreparationApi.md#paymentpreparationbatchdownloadv1) | **POST** /1/object/paymentpreparation/{pkiPaymentpreparationID}/batchDownload | Download multiples attachments from an Paymentpreparation |
| [**PaymentpreparationGetAttachmentsV1**](ObjectPaymentpreparationApi.md#paymentpreparationgetattachmentsv1) | **GET** /1/object/paymentpreparation/{pkiPaymentpreparationID}/getAttachments | Retrieve Paymentpreparation&#39;s attachments |
| [**PaymentpreparationImportIntoEDMV1**](ObjectPaymentpreparationApi.md#paymentpreparationimportintoedmv1) | **POST** /1/object/paymentpreparation/{pkiPaymentpreparationID}/importIntoEDM | Import attachments into the Paymentpreparation |

<a id="paymentpreparationbatchdownloadv1"></a>
# **PaymentpreparationBatchDownloadV1**
> System.IO.Stream PaymentpreparationBatchDownloadV1 (int pkiPaymentpreparationID, PaymentpreparationBatchDownloadV1Request paymentpreparationBatchDownloadV1Request)

Download multiples attachments from an Paymentpreparation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class PaymentpreparationBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectPaymentpreparationApi(config);
            var pkiPaymentpreparationID = 56;  // int | 
            var paymentpreparationBatchDownloadV1Request = new PaymentpreparationBatchDownloadV1Request(); // PaymentpreparationBatchDownloadV1Request | 

            try
            {
                // Download multiples attachments from an Paymentpreparation
                System.IO.Stream result = apiInstance.PaymentpreparationBatchDownloadV1(pkiPaymentpreparationID, paymentpreparationBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectPaymentpreparationApi.PaymentpreparationBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PaymentpreparationBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples attachments from an Paymentpreparation
    ApiResponse<System.IO.Stream> response = apiInstance.PaymentpreparationBatchDownloadV1WithHttpInfo(pkiPaymentpreparationID, paymentpreparationBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectPaymentpreparationApi.PaymentpreparationBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiPaymentpreparationID** | **int** |  |  |
| **paymentpreparationBatchDownloadV1Request** | [**PaymentpreparationBatchDownloadV1Request**](PaymentpreparationBatchDownloadV1Request.md) |  |  |

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
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="paymentpreparationgetattachmentsv1"></a>
# **PaymentpreparationGetAttachmentsV1**
> PaymentpreparationGetAttachmentsV1Response PaymentpreparationGetAttachmentsV1 (int pkiPaymentpreparationID)

Retrieve Paymentpreparation's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class PaymentpreparationGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectPaymentpreparationApi(config);
            var pkiPaymentpreparationID = 56;  // int | 

            try
            {
                // Retrieve Paymentpreparation's attachments
                PaymentpreparationGetAttachmentsV1Response result = apiInstance.PaymentpreparationGetAttachmentsV1(pkiPaymentpreparationID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectPaymentpreparationApi.PaymentpreparationGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PaymentpreparationGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Paymentpreparation's attachments
    ApiResponse<PaymentpreparationGetAttachmentsV1Response> response = apiInstance.PaymentpreparationGetAttachmentsV1WithHttpInfo(pkiPaymentpreparationID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectPaymentpreparationApi.PaymentpreparationGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiPaymentpreparationID** | **int** |  |  |

### Return type

[**PaymentpreparationGetAttachmentsV1Response**](PaymentpreparationGetAttachmentsV1Response.md)

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

<a id="paymentpreparationimportintoedmv1"></a>
# **PaymentpreparationImportIntoEDMV1**
> PaymentpreparationImportIntoEDMV1Response PaymentpreparationImportIntoEDMV1 (int pkiPaymentpreparationID, PaymentpreparationImportIntoEDMV1Request paymentpreparationImportIntoEDMV1Request)

Import attachments into the Paymentpreparation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class PaymentpreparationImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectPaymentpreparationApi(config);
            var pkiPaymentpreparationID = 56;  // int | 
            var paymentpreparationImportIntoEDMV1Request = new PaymentpreparationImportIntoEDMV1Request(); // PaymentpreparationImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Paymentpreparation
                PaymentpreparationImportIntoEDMV1Response result = apiInstance.PaymentpreparationImportIntoEDMV1(pkiPaymentpreparationID, paymentpreparationImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectPaymentpreparationApi.PaymentpreparationImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PaymentpreparationImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Paymentpreparation
    ApiResponse<PaymentpreparationImportIntoEDMV1Response> response = apiInstance.PaymentpreparationImportIntoEDMV1WithHttpInfo(pkiPaymentpreparationID, paymentpreparationImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectPaymentpreparationApi.PaymentpreparationImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiPaymentpreparationID** | **int** |  |  |
| **paymentpreparationImportIntoEDMV1Request** | [**PaymentpreparationImportIntoEDMV1Request**](PaymentpreparationImportIntoEDMV1Request.md) |  |  |

### Return type

[**PaymentpreparationImportIntoEDMV1Response**](PaymentpreparationImportIntoEDMV1Response.md)

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


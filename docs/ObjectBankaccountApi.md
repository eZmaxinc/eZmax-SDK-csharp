# eZmaxApi.Api.ObjectBankaccountApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BankaccountBatchDownloadV1**](ObjectBankaccountApi.md#bankaccountbatchdownloadv1) | **POST** /1/object/bankaccount/{pkiBankaccountID}/batchDownload | Download multiples attachments from a Bankaccount |
| [**BankaccountGetAttachmentsV1**](ObjectBankaccountApi.md#bankaccountgetattachmentsv1) | **GET** /1/object/bankaccount/{pkiBankaccountID}/getAttachments | Retrieve Bankaccount&#39;s attachments |
| [**BankaccountGetAutocompleteV2**](ObjectBankaccountApi.md#bankaccountgetautocompletev2) | **GET** /2/object/bankaccount/getAutocomplete/{sSelector} | Retrieve Bankaccounts and IDs |
| [**BankaccountImportIntoEDMV1**](ObjectBankaccountApi.md#bankaccountimportintoedmv1) | **POST** /1/object/bankaccount/{pkiBankaccountID}/importIntoEDM | Import attachments into the Bankaccount |

<a id="bankaccountbatchdownloadv1"></a>
# **BankaccountBatchDownloadV1**
> System.IO.Stream BankaccountBatchDownloadV1 (int pkiBankaccountID, BankaccountBatchDownloadV1Request bankaccountBatchDownloadV1Request)

Download multiples attachments from a Bankaccount

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class BankaccountBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectBankaccountApi(config);
            var pkiBankaccountID = 56;  // int | 
            var bankaccountBatchDownloadV1Request = new BankaccountBatchDownloadV1Request(); // BankaccountBatchDownloadV1Request | 

            try
            {
                // Download multiples attachments from a Bankaccount
                System.IO.Stream result = apiInstance.BankaccountBatchDownloadV1(pkiBankaccountID, bankaccountBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectBankaccountApi.BankaccountBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BankaccountBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples attachments from a Bankaccount
    ApiResponse<System.IO.Stream> response = apiInstance.BankaccountBatchDownloadV1WithHttpInfo(pkiBankaccountID, bankaccountBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectBankaccountApi.BankaccountBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBankaccountID** | **int** |  |  |
| **bankaccountBatchDownloadV1Request** | [**BankaccountBatchDownloadV1Request**](BankaccountBatchDownloadV1Request.md) |  |  |

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

<a id="bankaccountgetattachmentsv1"></a>
# **BankaccountGetAttachmentsV1**
> BankaccountGetAttachmentsV1Response BankaccountGetAttachmentsV1 (int pkiBankaccountID)

Retrieve Bankaccount's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class BankaccountGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectBankaccountApi(config);
            var pkiBankaccountID = 56;  // int | 

            try
            {
                // Retrieve Bankaccount's attachments
                BankaccountGetAttachmentsV1Response result = apiInstance.BankaccountGetAttachmentsV1(pkiBankaccountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectBankaccountApi.BankaccountGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BankaccountGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Bankaccount's attachments
    ApiResponse<BankaccountGetAttachmentsV1Response> response = apiInstance.BankaccountGetAttachmentsV1WithHttpInfo(pkiBankaccountID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectBankaccountApi.BankaccountGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBankaccountID** | **int** |  |  |

### Return type

[**BankaccountGetAttachmentsV1Response**](BankaccountGetAttachmentsV1Response.md)

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

<a id="bankaccountgetautocompletev2"></a>
# **BankaccountGetAutocompleteV2**
> BankaccountGetAutocompleteV2Response BankaccountGetAutocompleteV2 (string sSelector, string? eFilterActive = null, string? sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Bankaccounts and IDs

Get the list of Bankaccount to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class BankaccountGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectBankaccountApi(config);
            var sSelector = "All";  // string | The type of Bankaccounts to return
            var eFilterActive = "All";  // string? | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string? | Allow to filter the returned results (optional) 
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Bankaccounts and IDs
                BankaccountGetAutocompleteV2Response result = apiInstance.BankaccountGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectBankaccountApi.BankaccountGetAutocompleteV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BankaccountGetAutocompleteV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Bankaccounts and IDs
    ApiResponse<BankaccountGetAutocompleteV2Response> response = apiInstance.BankaccountGetAutocompleteV2WithHttpInfo(sSelector, eFilterActive, sQuery, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectBankaccountApi.BankaccountGetAutocompleteV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Bankaccounts to return |  |
| **eFilterActive** | **string?** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string?** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |

### Return type

[**BankaccountGetAutocompleteV2Response**](BankaccountGetAutocompleteV2Response.md)

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

<a id="bankaccountimportintoedmv1"></a>
# **BankaccountImportIntoEDMV1**
> BankaccountImportIntoEDMV1Response BankaccountImportIntoEDMV1 (int pkiBankaccountID, BankaccountImportIntoEDMV1Request bankaccountImportIntoEDMV1Request)

Import attachments into the Bankaccount

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class BankaccountImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectBankaccountApi(config);
            var pkiBankaccountID = 56;  // int | 
            var bankaccountImportIntoEDMV1Request = new BankaccountImportIntoEDMV1Request(); // BankaccountImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Bankaccount
                BankaccountImportIntoEDMV1Response result = apiInstance.BankaccountImportIntoEDMV1(pkiBankaccountID, bankaccountImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectBankaccountApi.BankaccountImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BankaccountImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Bankaccount
    ApiResponse<BankaccountImportIntoEDMV1Response> response = apiInstance.BankaccountImportIntoEDMV1WithHttpInfo(pkiBankaccountID, bankaccountImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectBankaccountApi.BankaccountImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBankaccountID** | **int** |  |  |
| **bankaccountImportIntoEDMV1Request** | [**BankaccountImportIntoEDMV1Request**](BankaccountImportIntoEDMV1Request.md) |  |  |

### Return type

[**BankaccountImportIntoEDMV1Response**](BankaccountImportIntoEDMV1Response.md)

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


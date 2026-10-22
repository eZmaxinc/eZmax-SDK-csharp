# eZmaxApi.Api.ObjectDocumenttypeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DocumenttypeCreateObjectV1**](ObjectDocumenttypeApi.md#documenttypecreateobjectv1) | **POST** /1/object/documenttype | Create a new Documenttype |
| [**DocumenttypeDeleteObjectV1**](ObjectDocumenttypeApi.md#documenttypedeleteobjectv1) | **DELETE** /1/object/documenttype/{pkiDocumenttypeID} | Delete an existing Documenttype |
| [**DocumenttypeEditObjectV1**](ObjectDocumenttypeApi.md#documenttypeeditobjectv1) | **PUT** /1/object/documenttype/{pkiDocumenttypeID} | Edit an existing Documenttype |
| [**DocumenttypeGetAutocompleteV2**](ObjectDocumenttypeApi.md#documenttypegetautocompletev2) | **GET** /2/object/documenttype/getAutocomplete/{sSelector} | Retrieve Documenttypes and IDs |
| [**DocumenttypeGetListV1**](ObjectDocumenttypeApi.md#documenttypegetlistv1) | **GET** /1/object/documenttype/getList | Retrieve Documenttype list |
| [**DocumenttypeGetObjectV2**](ObjectDocumenttypeApi.md#documenttypegetobjectv2) | **GET** /2/object/documenttype/{pkiDocumenttypeID} | Retrieve an existing Documenttype |

<a id="documenttypecreateobjectv1"></a>
# **DocumenttypeCreateObjectV1**
> DocumenttypeCreateObjectV1Response DocumenttypeCreateObjectV1 (DocumenttypeCreateObjectV1Request documenttypeCreateObjectV1Request)

Create a new Documenttype

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
    public class DocumenttypeCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDocumenttypeApi(config);
            var documenttypeCreateObjectV1Request = new DocumenttypeCreateObjectV1Request(); // DocumenttypeCreateObjectV1Request | 

            try
            {
                // Create a new Documenttype
                DocumenttypeCreateObjectV1Response result = apiInstance.DocumenttypeCreateObjectV1(documenttypeCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDocumenttypeApi.DocumenttypeCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumenttypeCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Documenttype
    ApiResponse<DocumenttypeCreateObjectV1Response> response = apiInstance.DocumenttypeCreateObjectV1WithHttpInfo(documenttypeCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDocumenttypeApi.DocumenttypeCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documenttypeCreateObjectV1Request** | [**DocumenttypeCreateObjectV1Request**](DocumenttypeCreateObjectV1Request.md) |  |  |

### Return type

[**DocumenttypeCreateObjectV1Response**](DocumenttypeCreateObjectV1Response.md)

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

<a id="documenttypedeleteobjectv1"></a>
# **DocumenttypeDeleteObjectV1**
> DocumenttypeDeleteObjectV1Response DocumenttypeDeleteObjectV1 (int pkiDocumenttypeID)

Delete an existing Documenttype

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DocumenttypeDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDocumenttypeApi(config);
            var pkiDocumenttypeID = 56;  // int | The unique ID of the Documenttype

            try
            {
                // Delete an existing Documenttype
                DocumenttypeDeleteObjectV1Response result = apiInstance.DocumenttypeDeleteObjectV1(pkiDocumenttypeID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDocumenttypeApi.DocumenttypeDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumenttypeDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Documenttype
    ApiResponse<DocumenttypeDeleteObjectV1Response> response = apiInstance.DocumenttypeDeleteObjectV1WithHttpInfo(pkiDocumenttypeID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDocumenttypeApi.DocumenttypeDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDocumenttypeID** | **int** | The unique ID of the Documenttype |  |

### Return type

[**DocumenttypeDeleteObjectV1Response**](DocumenttypeDeleteObjectV1Response.md)

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

<a id="documenttypeeditobjectv1"></a>
# **DocumenttypeEditObjectV1**
> DocumenttypeEditObjectV1Response DocumenttypeEditObjectV1 (int pkiDocumenttypeID, DocumenttypeEditObjectV1Request documenttypeEditObjectV1Request)

Edit an existing Documenttype

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DocumenttypeEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDocumenttypeApi(config);
            var pkiDocumenttypeID = 56;  // int | The unique ID of the Documenttype
            var documenttypeEditObjectV1Request = new DocumenttypeEditObjectV1Request(); // DocumenttypeEditObjectV1Request | 

            try
            {
                // Edit an existing Documenttype
                DocumenttypeEditObjectV1Response result = apiInstance.DocumenttypeEditObjectV1(pkiDocumenttypeID, documenttypeEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDocumenttypeApi.DocumenttypeEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumenttypeEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Documenttype
    ApiResponse<DocumenttypeEditObjectV1Response> response = apiInstance.DocumenttypeEditObjectV1WithHttpInfo(pkiDocumenttypeID, documenttypeEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDocumenttypeApi.DocumenttypeEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDocumenttypeID** | **int** | The unique ID of the Documenttype |  |
| **documenttypeEditObjectV1Request** | [**DocumenttypeEditObjectV1Request**](DocumenttypeEditObjectV1Request.md) |  |  |

### Return type

[**DocumenttypeEditObjectV1Response**](DocumenttypeEditObjectV1Response.md)

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

<a id="documenttypegetautocompletev2"></a>
# **DocumenttypeGetAutocompleteV2**
> DocumenttypeGetAutocompleteV2Response DocumenttypeGetAutocompleteV2 (string sSelector, string? eFilterActive = null, string? sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Documenttypes and IDs

Get the list of Documenttype to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DocumenttypeGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDocumenttypeApi(config);
            var sSelector = "All";  // string | The type of Documenttypes to return
            var eFilterActive = "All";  // string? | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string? | Allow to filter the returned results (optional) 
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Documenttypes and IDs
                DocumenttypeGetAutocompleteV2Response result = apiInstance.DocumenttypeGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDocumenttypeApi.DocumenttypeGetAutocompleteV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumenttypeGetAutocompleteV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Documenttypes and IDs
    ApiResponse<DocumenttypeGetAutocompleteV2Response> response = apiInstance.DocumenttypeGetAutocompleteV2WithHttpInfo(sSelector, eFilterActive, sQuery, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDocumenttypeApi.DocumenttypeGetAutocompleteV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Documenttypes to return |  |
| **eFilterActive** | **string?** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string?** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |

### Return type

[**DocumenttypeGetAutocompleteV2Response**](DocumenttypeGetAutocompleteV2Response.md)

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

<a id="documenttypegetlistv1"></a>
# **DocumenttypeGetListV1**
> DocumenttypeGetListV1Response DocumenttypeGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Documenttype list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --|  | Agentbroker<br>Buyercontract<br>Inscription<br>NotAuthenticated<br>Otherincome<br>RejectedOfferToPurchase | | eDocumenttypeEzcom | PromiseToPurchase<br>Annex<br>Modification<br>CounterOffer<br>Conditions<br>BankApproval<br>Other | | eDocumenttypePrivacydefault | Administration<br>Administrator<br>All<br>Creator<br>Inscriptor<br>Myself<br>Seller | | eDocumenttypeStatusdefault | Not required<br>Required | | eDocumenttypeSalebyowner | All<br>Yes<br>No | | eDocumenttypeSaledisplaybyrole | InscriptorSeller<br>Inscriptor<br>Seller | | eDocumenttypeTransactiontype | All<br>Inscriptor<br>InscriptorOnly<br>Seller<br>SellerOnly<br>InscriptorSeller | | eDocumenttypeRepossession | All<br>No<br>Yes |

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DocumenttypeGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDocumenttypeApi(config);
            var eOrderBy = "pkiDocumenttypeID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Documenttype list
                DocumenttypeGetListV1Response result = apiInstance.DocumenttypeGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDocumenttypeApi.DocumenttypeGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumenttypeGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Documenttype list
    ApiResponse<DocumenttypeGetListV1Response> response = apiInstance.DocumenttypeGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDocumenttypeApi.DocumenttypeGetListV1WithHttpInfo: " + e.Message);
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

[**DocumenttypeGetListV1Response**](DocumenttypeGetListV1Response.md)

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

<a id="documenttypegetobjectv2"></a>
# **DocumenttypeGetObjectV2**
> DocumenttypeGetObjectV2Response DocumenttypeGetObjectV2 (int pkiDocumenttypeID)

Retrieve an existing Documenttype

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DocumenttypeGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDocumenttypeApi(config);
            var pkiDocumenttypeID = 56;  // int | The unique ID of the Documenttype

            try
            {
                // Retrieve an existing Documenttype
                DocumenttypeGetObjectV2Response result = apiInstance.DocumenttypeGetObjectV2(pkiDocumenttypeID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDocumenttypeApi.DocumenttypeGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumenttypeGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Documenttype
    ApiResponse<DocumenttypeGetObjectV2Response> response = apiInstance.DocumenttypeGetObjectV2WithHttpInfo(pkiDocumenttypeID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDocumenttypeApi.DocumenttypeGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDocumenttypeID** | **int** | The unique ID of the Documenttype |  |

### Return type

[**DocumenttypeGetObjectV2Response**](DocumenttypeGetObjectV2Response.md)

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


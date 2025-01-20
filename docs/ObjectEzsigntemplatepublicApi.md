# eZmaxApi.Api.ObjectEzsigntemplatepublicApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplatepublicCreateEzsignfolderV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepubliccreateezsignfolderv1) | **POST** /1/object/ezsigntemplatepublic/createEzsignfolder | Create an Ezsignfolder |
| [**EzsigntemplatepublicCreateObjectV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepubliccreateobjectv1) | **POST** /1/object/ezsigntemplatepublic | Create a new Ezsigntemplatepublic |
| [**EzsigntemplatepublicEditObjectV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepubliceditobjectv1) | **PUT** /1/object/ezsigntemplatepublic/{pkiEzsigntemplatepublicID} | Edit an existing Ezsigntemplatepublic |
| [**EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepublicgetezsigntemplatepublicdetailsv1) | **POST** /1/object/ezsigntemplatepublic/getEzsigntemplatepublicDetails | Retrieve the Ezsigntemplatepublic details |
| [**EzsigntemplatepublicGetFormsDataV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepublicgetformsdatav1) | **GET** /1/object/ezsigntemplatepublic/{pkiEzsigntemplatepublicID}/getFormsData | Retrieve an existing Ezsigntemplatepublic&#39;s forms data |
| [**EzsigntemplatepublicGetListV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepublicgetlistv1) | **GET** /1/object/ezsigntemplatepublic/getList | Retrieve Ezsigntemplatepublic list |
| [**EzsigntemplatepublicGetObjectV2**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepublicgetobjectv2) | **GET** /2/object/ezsigntemplatepublic/{pkiEzsigntemplatepublicID} | Retrieve an existing Ezsigntemplatepublic |
| [**EzsigntemplatepublicResetLimitExceededCounterV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepublicresetlimitexceededcounterv1) | **POST** /1/object/ezsigntemplatepublic/{pkiEzsigntemplatepublicID}/resetLimitExceededCounter | Reset the limit exceeded counter |
| [**EzsigntemplatepublicResetUrlV1**](ObjectEzsigntemplatepublicApi.md#ezsigntemplatepublicreseturlv1) | **POST** /1/object/ezsigntemplatepublic/{pkiEzsigntemplatepublicID}/resetUrl | Reset the Ezsigntemplatepublic url |

<a id="ezsigntemplatepubliccreateezsignfolderv1"></a>
# **EzsigntemplatepublicCreateEzsignfolderV1**
> EzsigntemplatepublicCreateEzsignfolderV1Response EzsigntemplatepublicCreateEzsignfolderV1 (EzsigntemplatepublicCreateEzsignfolderV1Request ezsigntemplatepublicCreateEzsignfolderV1Request)

Create an Ezsignfolder

Create an Ezsignfolder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepublicCreateEzsignfolderV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepublicApi(config);
            var ezsigntemplatepublicCreateEzsignfolderV1Request = new EzsigntemplatepublicCreateEzsignfolderV1Request(); // EzsigntemplatepublicCreateEzsignfolderV1Request | 

            try
            {
                // Create an Ezsignfolder
                EzsigntemplatepublicCreateEzsignfolderV1Response result = apiInstance.EzsigntemplatepublicCreateEzsignfolderV1(ezsigntemplatepublicCreateEzsignfolderV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicCreateEzsignfolderV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatepublicCreateEzsignfolderV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an Ezsignfolder
    ApiResponse<EzsigntemplatepublicCreateEzsignfolderV1Response> response = apiInstance.EzsigntemplatepublicCreateEzsignfolderV1WithHttpInfo(ezsigntemplatepublicCreateEzsignfolderV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicCreateEzsignfolderV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatepublicCreateEzsignfolderV1Request** | [**EzsigntemplatepublicCreateEzsignfolderV1Request**](EzsigntemplatepublicCreateEzsignfolderV1Request.md) |  |  |

### Return type

[**EzsigntemplatepublicCreateEzsignfolderV1Response**](EzsigntemplatepublicCreateEzsignfolderV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigntemplatepubliccreateobjectv1"></a>
# **EzsigntemplatepublicCreateObjectV1**
> EzsigntemplatepublicCreateObjectV1Response EzsigntemplatepublicCreateObjectV1 (EzsigntemplatepublicCreateObjectV1Request ezsigntemplatepublicCreateObjectV1Request)

Create a new Ezsigntemplatepublic

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
    public class EzsigntemplatepublicCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepublicApi(config);
            var ezsigntemplatepublicCreateObjectV1Request = new EzsigntemplatepublicCreateObjectV1Request(); // EzsigntemplatepublicCreateObjectV1Request | 

            try
            {
                // Create a new Ezsigntemplatepublic
                EzsigntemplatepublicCreateObjectV1Response result = apiInstance.EzsigntemplatepublicCreateObjectV1(ezsigntemplatepublicCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatepublicCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsigntemplatepublic
    ApiResponse<EzsigntemplatepublicCreateObjectV1Response> response = apiInstance.EzsigntemplatepublicCreateObjectV1WithHttpInfo(ezsigntemplatepublicCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatepublicCreateObjectV1Request** | [**EzsigntemplatepublicCreateObjectV1Request**](EzsigntemplatepublicCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigntemplatepublicCreateObjectV1Response**](EzsigntemplatepublicCreateObjectV1Response.md)

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

<a id="ezsigntemplatepubliceditobjectv1"></a>
# **EzsigntemplatepublicEditObjectV1**
> CommonResponse EzsigntemplatepublicEditObjectV1 (int pkiEzsigntemplatepublicID, EzsigntemplatepublicEditObjectV1Request ezsigntemplatepublicEditObjectV1Request)

Edit an existing Ezsigntemplatepublic

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepublicEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepublicApi(config);
            var pkiEzsigntemplatepublicID = 56;  // int | The unique ID of the Ezsigntemplatepublic
            var ezsigntemplatepublicEditObjectV1Request = new EzsigntemplatepublicEditObjectV1Request(); // EzsigntemplatepublicEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsigntemplatepublic
                CommonResponse result = apiInstance.EzsigntemplatepublicEditObjectV1(pkiEzsigntemplatepublicID, ezsigntemplatepublicEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatepublicEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsigntemplatepublic
    ApiResponse<CommonResponse> response = apiInstance.EzsigntemplatepublicEditObjectV1WithHttpInfo(pkiEzsigntemplatepublicID, ezsigntemplatepublicEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepublicID** | **int** | The unique ID of the Ezsigntemplatepublic |  |
| **ezsigntemplatepublicEditObjectV1Request** | [**EzsigntemplatepublicEditObjectV1Request**](EzsigntemplatepublicEditObjectV1Request.md) |  |  |

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

<a id="ezsigntemplatepublicgetezsigntemplatepublicdetailsv1"></a>
# **EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1**
> EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Response EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1 (EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request ezsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request)

Retrieve the Ezsigntemplatepublic details

Retrieve the Ezsigntemplatepublic details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepublicApi(config);
            var ezsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request = new EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request(); // EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request | 

            try
            {
                // Retrieve the Ezsigntemplatepublic details
                EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Response result = apiInstance.EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1(ezsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the Ezsigntemplatepublic details
    ApiResponse<EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Response> response = apiInstance.EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1WithHttpInfo(ezsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request** | [**EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request**](EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Request.md) |  |  |

### Return type

[**EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Response**](EzsigntemplatepublicGetEzsigntemplatepublicDetailsV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigntemplatepublicgetformsdatav1"></a>
# **EzsigntemplatepublicGetFormsDataV1**
> EzsigntemplatepublicGetFormsDataV1Response EzsigntemplatepublicGetFormsDataV1 (int pkiEzsigntemplatepublicID)

Retrieve an existing Ezsigntemplatepublic's forms data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepublicGetFormsDataV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepublicApi(config);
            var pkiEzsigntemplatepublicID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigntemplatepublic's forms data
                EzsigntemplatepublicGetFormsDataV1Response result = apiInstance.EzsigntemplatepublicGetFormsDataV1(pkiEzsigntemplatepublicID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicGetFormsDataV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatepublicGetFormsDataV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatepublic's forms data
    ApiResponse<EzsigntemplatepublicGetFormsDataV1Response> response = apiInstance.EzsigntemplatepublicGetFormsDataV1WithHttpInfo(pkiEzsigntemplatepublicID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicGetFormsDataV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepublicID** | **int** |  |  |

### Return type

[**EzsigntemplatepublicGetFormsDataV1Response**](EzsigntemplatepublicGetFormsDataV1Response.md)

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

<a id="ezsigntemplatepublicgetlistv1"></a>
# **EzsigntemplatepublicGetListV1**
> EzsigntemplatepublicGetListV1Response EzsigntemplatepublicGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Ezsigntemplatepublic list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eEzsigntemplatepublicLimittype | Hour<br>Day<br>Month<br>Total |

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepublicGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepublicApi(config);
            var eOrderBy = "pkiEzsigntemplatepublicID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Ezsigntemplatepublic list
                EzsigntemplatepublicGetListV1Response result = apiInstance.EzsigntemplatepublicGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatepublicGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsigntemplatepublic list
    ApiResponse<EzsigntemplatepublicGetListV1Response> response = apiInstance.EzsigntemplatepublicGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicGetListV1WithHttpInfo: " + e.Message);
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

[**EzsigntemplatepublicGetListV1Response**](EzsigntemplatepublicGetListV1Response.md)

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

<a id="ezsigntemplatepublicgetobjectv2"></a>
# **EzsigntemplatepublicGetObjectV2**
> EzsigntemplatepublicGetObjectV2Response EzsigntemplatepublicGetObjectV2 (int pkiEzsigntemplatepublicID)

Retrieve an existing Ezsigntemplatepublic

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepublicGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepublicApi(config);
            var pkiEzsigntemplatepublicID = 56;  // int | The unique ID of the Ezsigntemplatepublic

            try
            {
                // Retrieve an existing Ezsigntemplatepublic
                EzsigntemplatepublicGetObjectV2Response result = apiInstance.EzsigntemplatepublicGetObjectV2(pkiEzsigntemplatepublicID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatepublicGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigntemplatepublic
    ApiResponse<EzsigntemplatepublicGetObjectV2Response> response = apiInstance.EzsigntemplatepublicGetObjectV2WithHttpInfo(pkiEzsigntemplatepublicID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepublicID** | **int** | The unique ID of the Ezsigntemplatepublic |  |

### Return type

[**EzsigntemplatepublicGetObjectV2Response**](EzsigntemplatepublicGetObjectV2Response.md)

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

<a id="ezsigntemplatepublicresetlimitexceededcounterv1"></a>
# **EzsigntemplatepublicResetLimitExceededCounterV1**
> EzsigntemplatepublicResetLimitExceededCounterV1Response EzsigntemplatepublicResetLimitExceededCounterV1 (int pkiEzsigntemplatepublicID, Object body)

Reset the limit exceeded counter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepublicResetLimitExceededCounterV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepublicApi(config);
            var pkiEzsigntemplatepublicID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Reset the limit exceeded counter
                EzsigntemplatepublicResetLimitExceededCounterV1Response result = apiInstance.EzsigntemplatepublicResetLimitExceededCounterV1(pkiEzsigntemplatepublicID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicResetLimitExceededCounterV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatepublicResetLimitExceededCounterV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset the limit exceeded counter
    ApiResponse<EzsigntemplatepublicResetLimitExceededCounterV1Response> response = apiInstance.EzsigntemplatepublicResetLimitExceededCounterV1WithHttpInfo(pkiEzsigntemplatepublicID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicResetLimitExceededCounterV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepublicID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsigntemplatepublicResetLimitExceededCounterV1Response**](EzsigntemplatepublicResetLimitExceededCounterV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigntemplatepublicreseturlv1"></a>
# **EzsigntemplatepublicResetUrlV1**
> EzsigntemplatepublicResetUrlV1Response EzsigntemplatepublicResetUrlV1 (int pkiEzsigntemplatepublicID, Object body)

Reset the Ezsigntemplatepublic url

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigntemplatepublicResetUrlV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigntemplatepublicApi(config);
            var pkiEzsigntemplatepublicID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Reset the Ezsigntemplatepublic url
                EzsigntemplatepublicResetUrlV1Response result = apiInstance.EzsigntemplatepublicResetUrlV1(pkiEzsigntemplatepublicID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicResetUrlV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigntemplatepublicResetUrlV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset the Ezsigntemplatepublic url
    ApiResponse<EzsigntemplatepublicResetUrlV1Response> response = apiInstance.EzsigntemplatepublicResetUrlV1WithHttpInfo(pkiEzsigntemplatepublicID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigntemplatepublicApi.EzsigntemplatepublicResetUrlV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplatepublicID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**EzsigntemplatepublicResetUrlV1Response**](EzsigntemplatepublicResetUrlV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# eZmaxApi.Api.ObjectEzsignfoldertypeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EzsignfoldertypeCreateObjectV1**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypecreateobjectv1) | **POST** /1/object/ezsignfoldertype | Create a new Ezsignfoldertype
[**EzsignfoldertypeEditObjectV1**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypeeditobjectv1) | **PUT** /1/object/ezsignfoldertype/{pkiEzsignfoldertypeID} | Edit an existing Ezsignfoldertype
[**EzsignfoldertypeGetAutocompleteV1**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypegetautocompletev1) | **GET** /1/object/ezsignfoldertype/getAutocomplete/{sSelector} | Retrieve Ezsignfoldertypes and IDs
[**EzsignfoldertypeGetListV1**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypegetlistv1) | **GET** /1/object/ezsignfoldertype/getList | Retrieve Ezsignfoldertype list
[**EzsignfoldertypeGetObjectV1**](ObjectEzsignfoldertypeApi.md#ezsignfoldertypegetobjectv1) | **GET** /1/object/ezsignfoldertype/{pkiEzsignfoldertypeID} | Retrieve an existing Ezsignfoldertype



## EzsignfoldertypeCreateObjectV1

> EzsignfoldertypeCreateObjectV1Response EzsignfoldertypeCreateObjectV1 (EzsignfoldertypeCreateObjectV1Request ezsignfoldertypeCreateObjectV1Request)

Create a new Ezsignfoldertype

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
    public class EzsignfoldertypeCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldertypeApi(Configuration.Default);
            var ezsignfoldertypeCreateObjectV1Request = new EzsignfoldertypeCreateObjectV1Request(); // EzsignfoldertypeCreateObjectV1Request | 

            try
            {
                // Create a new Ezsignfoldertype
                EzsignfoldertypeCreateObjectV1Response result = apiInstance.EzsignfoldertypeCreateObjectV1(ezsignfoldertypeCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeCreateObjectV1: " + e.Message );
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
 **ezsignfoldertypeCreateObjectV1Request** | [**EzsignfoldertypeCreateObjectV1Request**](EzsignfoldertypeCreateObjectV1Request.md)|  | 

### Return type

[**EzsignfoldertypeCreateObjectV1Response**](EzsignfoldertypeCreateObjectV1Response.md)

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


## EzsignfoldertypeEditObjectV1

> EzsignfoldertypeEditObjectV1Response EzsignfoldertypeEditObjectV1 (int pkiEzsignfoldertypeID, EzsignfoldertypeEditObjectV1Request ezsignfoldertypeEditObjectV1Request)

Edit an existing Ezsignfoldertype

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldertypeEditObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldertypeApi(Configuration.Default);
            var pkiEzsignfoldertypeID = 56;  // int | 
            var ezsignfoldertypeEditObjectV1Request = new EzsignfoldertypeEditObjectV1Request(); // EzsignfoldertypeEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsignfoldertype
                EzsignfoldertypeEditObjectV1Response result = apiInstance.EzsignfoldertypeEditObjectV1(pkiEzsignfoldertypeID, ezsignfoldertypeEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeEditObjectV1: " + e.Message );
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
 **pkiEzsignfoldertypeID** | **int**|  | 
 **ezsignfoldertypeEditObjectV1Request** | [**EzsignfoldertypeEditObjectV1Request**](EzsignfoldertypeEditObjectV1Request.md)|  | 

### Return type

[**EzsignfoldertypeEditObjectV1Response**](EzsignfoldertypeEditObjectV1Response.md)

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


## EzsignfoldertypeGetAutocompleteV1

> CommonGetAutocompleteV1Response EzsignfoldertypeGetAutocompleteV1 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Ezsignfoldertypes and IDs

Get the list of Ezsignfoldertypes to be used in a dropdown or autocomplete control.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldertypeGetAutocompleteV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldertypeApi(Configuration.Default);
            var sSelector = "Active";  // string | The type of Ezsignfoldertypes to return
            var eFilterActive = "All";  // string | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string | Allow to filter the returned results (optional) 
            var acceptLanguage = (HeaderAcceptLanguage) "*";  // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Ezsignfoldertypes and IDs
                CommonGetAutocompleteV1Response result = apiInstance.EzsignfoldertypeGetAutocompleteV1(sSelector, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeGetAutocompleteV1: " + e.Message );
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
 **sSelector** | **string**| The type of Ezsignfoldertypes to return | 
 **eFilterActive** | **string**| Specify which results we want to display. | [optional] [default to Active]
 **sQuery** | **string**| Allow to filter the returned results | [optional] 
 **acceptLanguage** | **HeaderAcceptLanguage?**|  | [optional] 

### Return type

[**CommonGetAutocompleteV1Response**](CommonGetAutocompleteV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfoldertypeGetListV1

> EzsignfoldertypeGetListV1Response EzsignfoldertypeGetListV1 (string eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string sFilter = null)

Retrieve Ezsignfoldertype list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eEzsignfoldertypePrivacylevel | User<br>Usergroup |

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldertypeGetListV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldertypeApi(Configuration.Default);
            var eOrderBy = "pkiEzsignfoldertypeID_ASC";  // string | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 56;  // int? |  (optional) 
            var acceptLanguage = (HeaderAcceptLanguage) "*";  // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string |  (optional) 

            try
            {
                // Retrieve Ezsignfoldertype list
                EzsignfoldertypeGetListV1Response result = apiInstance.EzsignfoldertypeGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeGetListV1: " + e.Message );
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

[**EzsignfoldertypeGetListV1Response**](EzsignfoldertypeGetListV1Response.md)

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


## EzsignfoldertypeGetObjectV1

> EzsignfoldertypeGetObjectV1Response EzsignfoldertypeGetObjectV1 (int pkiEzsignfoldertypeID)

Retrieve an existing Ezsignfoldertype

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldertypeGetObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldertypeApi(Configuration.Default);
            var pkiEzsignfoldertypeID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsignfoldertype
                EzsignfoldertypeGetObjectV1Response result = apiInstance.EzsignfoldertypeGetObjectV1(pkiEzsignfoldertypeID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldertypeApi.EzsignfoldertypeGetObjectV1: " + e.Message );
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
 **pkiEzsignfoldertypeID** | **int**|  | 

### Return type

[**EzsignfoldertypeGetObjectV1Response**](EzsignfoldertypeGetObjectV1Response.md)

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


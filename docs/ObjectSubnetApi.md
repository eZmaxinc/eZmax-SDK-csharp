# eZmaxApi.Api.ObjectSubnetApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubnetCreateObjectV1**](ObjectSubnetApi.md#subnetcreateobjectv1) | **POST** /1/object/subnet | Create a new Subnet |
| [**SubnetDeleteObjectV1**](ObjectSubnetApi.md#subnetdeleteobjectv1) | **DELETE** /1/object/subnet/{pkiSubnetID} | Delete an existing Subnet |
| [**SubnetEditObjectV1**](ObjectSubnetApi.md#subneteditobjectv1) | **PUT** /1/object/subnet/{pkiSubnetID} | Edit an existing Subnet |
| [**SubnetGetObjectV2**](ObjectSubnetApi.md#subnetgetobjectv2) | **GET** /2/object/subnet/{pkiSubnetID} | Retrieve an existing Subnet |

<a id="subnetcreateobjectv1"></a>
# **SubnetCreateObjectV1**
> SubnetCreateObjectV1Response SubnetCreateObjectV1 (SubnetCreateObjectV1Request subnetCreateObjectV1Request)

Create a new Subnet

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
    public class SubnetCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectSubnetApi(config);
            var subnetCreateObjectV1Request = new SubnetCreateObjectV1Request(); // SubnetCreateObjectV1Request | 

            try
            {
                // Create a new Subnet
                SubnetCreateObjectV1Response result = apiInstance.SubnetCreateObjectV1(subnetCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectSubnetApi.SubnetCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubnetCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Subnet
    ApiResponse<SubnetCreateObjectV1Response> response = apiInstance.SubnetCreateObjectV1WithHttpInfo(subnetCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectSubnetApi.SubnetCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subnetCreateObjectV1Request** | [**SubnetCreateObjectV1Request**](SubnetCreateObjectV1Request.md) |  |  |

### Return type

[**SubnetCreateObjectV1Response**](SubnetCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subnetdeleteobjectv1"></a>
# **SubnetDeleteObjectV1**
> SubnetDeleteObjectV1Response SubnetDeleteObjectV1 (int pkiSubnetID)

Delete an existing Subnet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class SubnetDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectSubnetApi(config);
            var pkiSubnetID = 56;  // int | The unique ID of the Subnet

            try
            {
                // Delete an existing Subnet
                SubnetDeleteObjectV1Response result = apiInstance.SubnetDeleteObjectV1(pkiSubnetID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectSubnetApi.SubnetDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubnetDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Subnet
    ApiResponse<SubnetDeleteObjectV1Response> response = apiInstance.SubnetDeleteObjectV1WithHttpInfo(pkiSubnetID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectSubnetApi.SubnetDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSubnetID** | **int** | The unique ID of the Subnet |  |

### Return type

[**SubnetDeleteObjectV1Response**](SubnetDeleteObjectV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subneteditobjectv1"></a>
# **SubnetEditObjectV1**
> SubnetEditObjectV1Response SubnetEditObjectV1 (int pkiSubnetID, SubnetEditObjectV1Request subnetEditObjectV1Request)

Edit an existing Subnet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class SubnetEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectSubnetApi(config);
            var pkiSubnetID = 56;  // int | The unique ID of the Subnet
            var subnetEditObjectV1Request = new SubnetEditObjectV1Request(); // SubnetEditObjectV1Request | 

            try
            {
                // Edit an existing Subnet
                SubnetEditObjectV1Response result = apiInstance.SubnetEditObjectV1(pkiSubnetID, subnetEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectSubnetApi.SubnetEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubnetEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Subnet
    ApiResponse<SubnetEditObjectV1Response> response = apiInstance.SubnetEditObjectV1WithHttpInfo(pkiSubnetID, subnetEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectSubnetApi.SubnetEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSubnetID** | **int** | The unique ID of the Subnet |  |
| **subnetEditObjectV1Request** | [**SubnetEditObjectV1Request**](SubnetEditObjectV1Request.md) |  |  |

### Return type

[**SubnetEditObjectV1Response**](SubnetEditObjectV1Response.md)

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

<a id="subnetgetobjectv2"></a>
# **SubnetGetObjectV2**
> SubnetGetObjectV2Response SubnetGetObjectV2 (int pkiSubnetID)

Retrieve an existing Subnet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class SubnetGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectSubnetApi(config);
            var pkiSubnetID = 56;  // int | The unique ID of the Subnet

            try
            {
                // Retrieve an existing Subnet
                SubnetGetObjectV2Response result = apiInstance.SubnetGetObjectV2(pkiSubnetID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectSubnetApi.SubnetGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubnetGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Subnet
    ApiResponse<SubnetGetObjectV2Response> response = apiInstance.SubnetGetObjectV2WithHttpInfo(pkiSubnetID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectSubnetApi.SubnetGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSubnetID** | **int** | The unique ID of the Subnet |  |

### Return type

[**SubnetGetObjectV2Response**](SubnetGetObjectV2Response.md)

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


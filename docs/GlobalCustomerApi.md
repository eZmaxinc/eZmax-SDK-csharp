# eZmaxApi.Api.GlobalCustomerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GlobalCustomerGetEndpointV1**](GlobalCustomerApi.md#globalcustomergetendpointv1) | **GET** /1/customer/{pksCustomerCode}/endpoint | Get customer endpoint |

<a id="globalcustomergetendpointv1"></a>
# **GlobalCustomerGetEndpointV1**
> GlobalCustomerGetEndpointV1Response GlobalCustomerGetEndpointV1 (string pksCustomerCode, string? sInfrastructureproductCode = null)

Get customer endpoint

Retrieve the customer's specific server endpoint where to send requests. This will help locate the proper region (ie: sInfrastructureregionCode) and the proper environment (ie: sInfrastructureenvironmenttypeDescription) where the customer's data is stored.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class GlobalCustomerGetEndpointV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            var apiInstance = new GlobalCustomerApi(config);
            var pksCustomerCode = "pksCustomerCode_example";  // string | 
            var sInfrastructureproductCode = "appcluster01";  // string? | The infrastructure product Code  If undefined, \"appcluster01\" is assumed (optional) 

            try
            {
                // Get customer endpoint
                GlobalCustomerGetEndpointV1Response result = apiInstance.GlobalCustomerGetEndpointV1(pksCustomerCode, sInfrastructureproductCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalCustomerApi.GlobalCustomerGetEndpointV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlobalCustomerGetEndpointV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get customer endpoint
    ApiResponse<GlobalCustomerGetEndpointV1Response> response = apiInstance.GlobalCustomerGetEndpointV1WithHttpInfo(pksCustomerCode, sInfrastructureproductCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalCustomerApi.GlobalCustomerGetEndpointV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pksCustomerCode** | **string** |  |  |
| **sInfrastructureproductCode** | **string?** | The infrastructure product Code  If undefined, \&quot;appcluster01\&quot; is assumed | [optional]  |

### Return type

[**GlobalCustomerGetEndpointV1Response**](GlobalCustomerGetEndpointV1Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


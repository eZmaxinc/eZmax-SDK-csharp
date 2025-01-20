# eZmaxApi.Api.ObjectEzsigndocumentApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigndocumentApplyEzsigntemplateV1**](ObjectEzsigndocumentApi.md#ezsigndocumentapplyezsigntemplatev1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/applyezsigntemplate | Apply an Ezsigntemplate to the Ezsigndocument. |
| [**EzsigndocumentApplyEzsigntemplateV2**](ObjectEzsigndocumentApi.md#ezsigndocumentapplyezsigntemplatev2) | **POST** /2/object/ezsigndocument/{pkiEzsigndocumentID}/applyEzsigntemplate | Apply an Ezsigntemplate to the Ezsigndocument. |
| [**EzsigndocumentApplyEzsigntemplateglobalV1**](ObjectEzsigndocumentApi.md#ezsigndocumentapplyezsigntemplateglobalv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/applyEzsigntemplateglobal | Apply an Ezsigntemplateglobal to the Ezsigndocument. |
| [**EzsigndocumentCreateEzsignelementsPositionedByWordV1**](ObjectEzsigndocumentApi.md#ezsigndocumentcreateezsignelementspositionedbywordv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/createEzsignelementsPositionedByWord | Create multiple Ezsignsignatures/Ezsignformfieldgroups |
| [**EzsigndocumentCreateObjectV1**](ObjectEzsigndocumentApi.md#ezsigndocumentcreateobjectv1) | **POST** /1/object/ezsigndocument | Create a new Ezsigndocument |
| [**EzsigndocumentCreateObjectV2**](ObjectEzsigndocumentApi.md#ezsigndocumentcreateobjectv2) | **POST** /2/object/ezsigndocument | Create a new Ezsigndocument |
| [**EzsigndocumentCreateObjectV3**](ObjectEzsigndocumentApi.md#ezsigndocumentcreateobjectv3) | **POST** /3/object/ezsigndocument | Create a new Ezsigndocument |
| [**EzsigndocumentDeclineToSignV1**](ObjectEzsigndocumentApi.md#ezsigndocumentdeclinetosignv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/declineToSign | Decline to sign |
| [**EzsigndocumentDeleteObjectV1**](ObjectEzsigndocumentApi.md#ezsigndocumentdeleteobjectv1) | **DELETE** /1/object/ezsigndocument/{pkiEzsigndocumentID} | Delete an existing Ezsigndocument |
| [**EzsigndocumentEditEzsignannotationsV1**](ObjectEzsigndocumentApi.md#ezsigndocumenteditezsignannotationsv1) | **PUT** /1/object/ezsigndocument/{pkiEzsigndocumentID}/editEzsignannotations | Edit multiple Ezsignannotations |
| [**EzsigndocumentEditEzsignformfieldgroupsV1**](ObjectEzsigndocumentApi.md#ezsigndocumenteditezsignformfieldgroupsv1) | **PUT** /1/object/ezsigndocument/{pkiEzsigndocumentID}/editEzsignformfieldgroups | Edit multiple Ezsignformfieldgroups |
| [**EzsigndocumentEditEzsignsignaturesV1**](ObjectEzsigndocumentApi.md#ezsigndocumenteditezsignsignaturesv1) | **PUT** /1/object/ezsigndocument/{pkiEzsigndocumentID}/editEzsignsignatures | Edit multiple Ezsignsignatures |
| [**EzsigndocumentEditObjectV1**](ObjectEzsigndocumentApi.md#ezsigndocumenteditobjectv1) | **PUT** /1/object/ezsigndocument/{pkiEzsigndocumentID} | Edit an existing Ezsigndocument |
| [**EzsigndocumentEndPrematurelyV1**](ObjectEzsigndocumentApi.md#ezsigndocumentendprematurelyv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/endPrematurely | End prematurely |
| [**EzsigndocumentExtractTextV1**](ObjectEzsigndocumentApi.md#ezsigndocumentextracttextv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/extractText | Extract text from Ezsigndocument area |
| [**EzsigndocumentFlattenV1**](ObjectEzsigndocumentApi.md#ezsigndocumentflattenv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/flatten | Flatten |
| [**EzsigndocumentGetActionableElementsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetactionableelementsv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getActionableElements | Retrieve actionable elements for the Ezsigndocument |
| [**EzsigndocumentGetAttachmentsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetattachmentsv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getAttachments | Retrieve Ezsigndocument&#39;s Attachments |
| [**EzsigndocumentGetCompletedElementsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetcompletedelementsv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getCompletedElements | Retrieve completed elements for the Ezsigndocument |
| [**EzsigndocumentGetDownloadUrlV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetdownloadurlv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getDownloadUrl/{eDocumentType} | Retrieve a URL to download documents. |
| [**EzsigndocumentGetEzsignannotationsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetezsignannotationsv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getEzsignannotations | Retrieve an existing Ezsigndocument&#39;s Ezsignannotations |
| [**EzsigndocumentGetEzsigndiscussionsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetezsigndiscussionsv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getEzsigndiscussions | Retrieve an existing Ezsigndocument&#39;s Ezsigndiscussions |
| [**EzsigndocumentGetEzsignformfieldgroupsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetezsignformfieldgroupsv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getEzsignformfieldgroups | Retrieve an existing Ezsigndocument&#39;s Ezsignformfieldgroups |
| [**EzsigndocumentGetEzsignpagesV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetezsignpagesv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getEzsignpages | Retrieve an existing Ezsigndocument&#39;s Ezsignpages |
| [**EzsigndocumentGetEzsignsignaturesAutomaticV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetezsignsignaturesautomaticv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getEzsignsignaturesAutomatic | Retrieve an existing Ezsigndocument&#39;s automatic Ezsignsignatures |
| [**EzsigndocumentGetEzsignsignaturesV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetezsignsignaturesv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getEzsignsignatures | Retrieve an existing Ezsigndocument&#39;s Ezsignsignatures |
| [**EzsigndocumentGetFormDataV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetformdatav1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getFormData | Retrieve an existing Ezsigndocument&#39;s Form Data |
| [**EzsigndocumentGetObjectV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetobjectv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID} | Retrieve an existing Ezsigndocument |
| [**EzsigndocumentGetObjectV2**](ObjectEzsigndocumentApi.md#ezsigndocumentgetobjectv2) | **GET** /2/object/ezsigndocument/{pkiEzsigndocumentID} | Retrieve an existing Ezsigndocument |
| [**EzsigndocumentGetTemporaryProofV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgettemporaryproofv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getTemporaryProof | Retrieve the temporary proof |
| [**EzsigndocumentGetWordsPositionsV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetwordspositionsv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getWordsPositions | Retrieve positions X,Y of given words from a Ezsigndocument |
| [**EzsigndocumentPatchObjectV1**](ObjectEzsigndocumentApi.md#ezsigndocumentpatchobjectv1) | **PATCH** /1/object/ezsigndocument/{pkiEzsigndocumentID} | Patch an existing Ezsigndocument |
| [**EzsigndocumentSubmitEzsignformV1**](ObjectEzsigndocumentApi.md#ezsigndocumentsubmitezsignformv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/submitEzsignform | Submit the Ezsignform |
| [**EzsigndocumentUnsendV1**](ObjectEzsigndocumentApi.md#ezsigndocumentunsendv1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/unsend | Unsend the Ezsigndocument |

<a id="ezsigndocumentapplyezsigntemplatev1"></a>
# **EzsigndocumentApplyEzsigntemplateV1**
> CommonResponse EzsigndocumentApplyEzsigntemplateV1 (int pkiEzsigndocumentID, EzsigndocumentApplyEzsigntemplateV1Request ezsigndocumentApplyEzsigntemplateV1Request)

Apply an Ezsigntemplate to the Ezsigndocument.

This function is deprecated. Please use *applyEzsigntemplate* instead which is doing the same thing but with a capital \"E\" to normalize the nomenclature.  This endpoint applies a predefined template to the ezsign document. This allows to automatically apply all the form and signature fields on a document in a single step.  The document must not already have fields otherwise an error will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentApplyEzsigntemplateV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var ezsigndocumentApplyEzsigntemplateV1Request = new EzsigndocumentApplyEzsigntemplateV1Request(); // EzsigndocumentApplyEzsigntemplateV1Request | 

            try
            {
                // Apply an Ezsigntemplate to the Ezsigndocument.
                CommonResponse result = apiInstance.EzsigndocumentApplyEzsigntemplateV1(pkiEzsigndocumentID, ezsigndocumentApplyEzsigntemplateV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentApplyEzsigntemplateV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentApplyEzsigntemplateV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Apply an Ezsigntemplate to the Ezsigndocument.
    ApiResponse<CommonResponse> response = apiInstance.EzsigndocumentApplyEzsigntemplateV1WithHttpInfo(pkiEzsigndocumentID, ezsigndocumentApplyEzsigntemplateV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentApplyEzsigntemplateV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentApplyEzsigntemplateV1Request** | [**EzsigndocumentApplyEzsigntemplateV1Request**](EzsigndocumentApplyEzsigntemplateV1Request.md) |  |  |

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

<a id="ezsigndocumentapplyezsigntemplatev2"></a>
# **EzsigndocumentApplyEzsigntemplateV2**
> EzsigndocumentApplyEzsigntemplateV2Response EzsigndocumentApplyEzsigntemplateV2 (int pkiEzsigndocumentID, EzsigndocumentApplyEzsigntemplateV2Request ezsigndocumentApplyEzsigntemplateV2Request)

Apply an Ezsigntemplate to the Ezsigndocument.

This endpoint applies a predefined template to the ezsign document. This allows to automatically apply all the form and signature fields on a document in a single step.  The document must not already have fields otherwise an error will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentApplyEzsigntemplateV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var ezsigndocumentApplyEzsigntemplateV2Request = new EzsigndocumentApplyEzsigntemplateV2Request(); // EzsigndocumentApplyEzsigntemplateV2Request | 

            try
            {
                // Apply an Ezsigntemplate to the Ezsigndocument.
                EzsigndocumentApplyEzsigntemplateV2Response result = apiInstance.EzsigndocumentApplyEzsigntemplateV2(pkiEzsigndocumentID, ezsigndocumentApplyEzsigntemplateV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentApplyEzsigntemplateV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentApplyEzsigntemplateV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Apply an Ezsigntemplate to the Ezsigndocument.
    ApiResponse<EzsigndocumentApplyEzsigntemplateV2Response> response = apiInstance.EzsigndocumentApplyEzsigntemplateV2WithHttpInfo(pkiEzsigndocumentID, ezsigndocumentApplyEzsigntemplateV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentApplyEzsigntemplateV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentApplyEzsigntemplateV2Request** | [**EzsigndocumentApplyEzsigntemplateV2Request**](EzsigndocumentApplyEzsigntemplateV2Request.md) |  |  |

### Return type

[**EzsigndocumentApplyEzsigntemplateV2Response**](EzsigndocumentApplyEzsigntemplateV2Response.md)

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

<a id="ezsigndocumentapplyezsigntemplateglobalv1"></a>
# **EzsigndocumentApplyEzsigntemplateglobalV1**
> EzsigndocumentApplyEzsigntemplateglobalV1Response EzsigndocumentApplyEzsigntemplateglobalV1 (int pkiEzsigndocumentID, EzsigndocumentApplyEzsigntemplateglobalV1Request ezsigndocumentApplyEzsigntemplateglobalV1Request)

Apply an Ezsigntemplateglobal to the Ezsigndocument.

This endpoint applies a predefined template to the ezsign document. This allows to automatically apply all the form and signature fields on a document in a single step.  The document must not already have fields otherwise an error will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentApplyEzsigntemplateglobalV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var ezsigndocumentApplyEzsigntemplateglobalV1Request = new EzsigndocumentApplyEzsigntemplateglobalV1Request(); // EzsigndocumentApplyEzsigntemplateglobalV1Request | 

            try
            {
                // Apply an Ezsigntemplateglobal to the Ezsigndocument.
                EzsigndocumentApplyEzsigntemplateglobalV1Response result = apiInstance.EzsigndocumentApplyEzsigntemplateglobalV1(pkiEzsigndocumentID, ezsigndocumentApplyEzsigntemplateglobalV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentApplyEzsigntemplateglobalV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentApplyEzsigntemplateglobalV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Apply an Ezsigntemplateglobal to the Ezsigndocument.
    ApiResponse<EzsigndocumentApplyEzsigntemplateglobalV1Response> response = apiInstance.EzsigndocumentApplyEzsigntemplateglobalV1WithHttpInfo(pkiEzsigndocumentID, ezsigndocumentApplyEzsigntemplateglobalV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentApplyEzsigntemplateglobalV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentApplyEzsigntemplateglobalV1Request** | [**EzsigndocumentApplyEzsigntemplateglobalV1Request**](EzsigndocumentApplyEzsigntemplateglobalV1Request.md) |  |  |

### Return type

[**EzsigndocumentApplyEzsigntemplateglobalV1Response**](EzsigndocumentApplyEzsigntemplateglobalV1Response.md)

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

<a id="ezsigndocumentcreateezsignelementspositionedbywordv1"></a>
# **EzsigndocumentCreateEzsignelementsPositionedByWordV1**
> EzsigndocumentCreateEzsignelementsPositionedByWordV1Response EzsigndocumentCreateEzsignelementsPositionedByWordV1 (int pkiEzsigndocumentID, EzsigndocumentCreateEzsignelementsPositionedByWordV1Request ezsigndocumentCreateEzsignelementsPositionedByWordV1Request)

Create multiple Ezsignsignatures/Ezsignformfieldgroups

Using this endpoint, you can create multiple Ezsignsignatures/Ezsignformfieldgroups positioned by word at the same time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentCreateEzsignelementsPositionedByWordV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var ezsigndocumentCreateEzsignelementsPositionedByWordV1Request = new EzsigndocumentCreateEzsignelementsPositionedByWordV1Request(); // EzsigndocumentCreateEzsignelementsPositionedByWordV1Request | 

            try
            {
                // Create multiple Ezsignsignatures/Ezsignformfieldgroups
                EzsigndocumentCreateEzsignelementsPositionedByWordV1Response result = apiInstance.EzsigndocumentCreateEzsignelementsPositionedByWordV1(pkiEzsigndocumentID, ezsigndocumentCreateEzsignelementsPositionedByWordV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentCreateEzsignelementsPositionedByWordV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentCreateEzsignelementsPositionedByWordV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create multiple Ezsignsignatures/Ezsignformfieldgroups
    ApiResponse<EzsigndocumentCreateEzsignelementsPositionedByWordV1Response> response = apiInstance.EzsigndocumentCreateEzsignelementsPositionedByWordV1WithHttpInfo(pkiEzsigndocumentID, ezsigndocumentCreateEzsignelementsPositionedByWordV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentCreateEzsignelementsPositionedByWordV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentCreateEzsignelementsPositionedByWordV1Request** | [**EzsigndocumentCreateEzsignelementsPositionedByWordV1Request**](EzsigndocumentCreateEzsignelementsPositionedByWordV1Request.md) |  |  |

### Return type

[**EzsigndocumentCreateEzsignelementsPositionedByWordV1Response**](EzsigndocumentCreateEzsignelementsPositionedByWordV1Response.md)

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

<a id="ezsigndocumentcreateobjectv1"></a>
# **EzsigndocumentCreateObjectV1**
> EzsigndocumentCreateObjectV1Response EzsigndocumentCreateObjectV1 (List<EzsigndocumentCreateObjectV1Request> ezsigndocumentCreateObjectV1Request)

Create a new Ezsigndocument

The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var ezsigndocumentCreateObjectV1Request = new List<EzsigndocumentCreateObjectV1Request>(); // List<EzsigndocumentCreateObjectV1Request> | 

            try
            {
                // Create a new Ezsigndocument
                EzsigndocumentCreateObjectV1Response result = apiInstance.EzsigndocumentCreateObjectV1(ezsigndocumentCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsigndocument
    ApiResponse<EzsigndocumentCreateObjectV1Response> response = apiInstance.EzsigndocumentCreateObjectV1WithHttpInfo(ezsigndocumentCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigndocumentCreateObjectV1Request** | [**List&lt;EzsigndocumentCreateObjectV1Request&gt;**](EzsigndocumentCreateObjectV1Request.md) |  |  |

### Return type

[**EzsigndocumentCreateObjectV1Response**](EzsigndocumentCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **413** | The request was large. Look for detail about the error in the body |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. If the error is recoverable sTemporaryFileUrl will be set and you can use this url to try a new request without sending the file over again |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigndocumentcreateobjectv2"></a>
# **EzsigndocumentCreateObjectV2**
> EzsigndocumentCreateObjectV2Response EzsigndocumentCreateObjectV2 (EzsigndocumentCreateObjectV2Request ezsigndocumentCreateObjectV2Request)

Create a new Ezsigndocument

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
    public class EzsigndocumentCreateObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var ezsigndocumentCreateObjectV2Request = new EzsigndocumentCreateObjectV2Request(); // EzsigndocumentCreateObjectV2Request | 

            try
            {
                // Create a new Ezsigndocument
                EzsigndocumentCreateObjectV2Response result = apiInstance.EzsigndocumentCreateObjectV2(ezsigndocumentCreateObjectV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentCreateObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentCreateObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsigndocument
    ApiResponse<EzsigndocumentCreateObjectV2Response> response = apiInstance.EzsigndocumentCreateObjectV2WithHttpInfo(ezsigndocumentCreateObjectV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentCreateObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigndocumentCreateObjectV2Request** | [**EzsigndocumentCreateObjectV2Request**](EzsigndocumentCreateObjectV2Request.md) |  |  |

### Return type

[**EzsigndocumentCreateObjectV2Response**](EzsigndocumentCreateObjectV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. If the error is recoverable sTemporaryFileUrl will be set and you can use this url to try a new request without sending the file over again |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigndocumentcreateobjectv3"></a>
# **EzsigndocumentCreateObjectV3**
> EzsigndocumentCreateObjectV3Response EzsigndocumentCreateObjectV3 (EzsigndocumentCreateObjectV3Request ezsigndocumentCreateObjectV3Request)

Create a new Ezsigndocument

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
    public class EzsigndocumentCreateObjectV3Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var ezsigndocumentCreateObjectV3Request = new EzsigndocumentCreateObjectV3Request(); // EzsigndocumentCreateObjectV3Request | 

            try
            {
                // Create a new Ezsigndocument
                EzsigndocumentCreateObjectV3Response result = apiInstance.EzsigndocumentCreateObjectV3(ezsigndocumentCreateObjectV3Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentCreateObjectV3: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentCreateObjectV3WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Ezsigndocument
    ApiResponse<EzsigndocumentCreateObjectV3Response> response = apiInstance.EzsigndocumentCreateObjectV3WithHttpInfo(ezsigndocumentCreateObjectV3Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentCreateObjectV3WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsigndocumentCreateObjectV3Request** | [**EzsigndocumentCreateObjectV3Request**](EzsigndocumentCreateObjectV3Request.md) |  |  |

### Return type

[**EzsigndocumentCreateObjectV3Response**](EzsigndocumentCreateObjectV3Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. If the error is recoverable sTemporaryFileUrl will be set and you can use this url to try a new request without sending the file over again |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigndocumentdeclinetosignv1"></a>
# **EzsigndocumentDeclineToSignV1**
> CommonResponse EzsigndocumentDeclineToSignV1 (int pkiEzsigndocumentID, EzsigndocumentDeclineToSignV1Request ezsigndocumentDeclineToSignV1Request)

Decline to sign

Decline to sign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentDeclineToSignV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var ezsigndocumentDeclineToSignV1Request = new EzsigndocumentDeclineToSignV1Request(); // EzsigndocumentDeclineToSignV1Request | 

            try
            {
                // Decline to sign
                CommonResponse result = apiInstance.EzsigndocumentDeclineToSignV1(pkiEzsigndocumentID, ezsigndocumentDeclineToSignV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentDeclineToSignV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentDeclineToSignV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Decline to sign
    ApiResponse<CommonResponse> response = apiInstance.EzsigndocumentDeclineToSignV1WithHttpInfo(pkiEzsigndocumentID, ezsigndocumentDeclineToSignV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentDeclineToSignV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentDeclineToSignV1Request** | [**EzsigndocumentDeclineToSignV1Request**](EzsigndocumentDeclineToSignV1Request.md) |  |  |

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

<a id="ezsigndocumentdeleteobjectv1"></a>
# **EzsigndocumentDeleteObjectV1**
> CommonResponse EzsigndocumentDeleteObjectV1 (int pkiEzsigndocumentID)

Delete an existing Ezsigndocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Delete an existing Ezsigndocument
                CommonResponse result = apiInstance.EzsigndocumentDeleteObjectV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Ezsigndocument
    ApiResponse<CommonResponse> response = apiInstance.EzsigndocumentDeleteObjectV1WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigndocumenteditezsignannotationsv1"></a>
# **EzsigndocumentEditEzsignannotationsV1**
> EzsigndocumentEditEzsignannotationsV1Response EzsigndocumentEditEzsignannotationsV1 (int pkiEzsigndocumentID, EzsigndocumentEditEzsignannotationsV1Request ezsigndocumentEditEzsignannotationsV1Request)

Edit multiple Ezsignannotations

Using this endpoint, you can edit multiple Ezsignannotations at the same time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentEditEzsignannotationsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var ezsigndocumentEditEzsignannotationsV1Request = new EzsigndocumentEditEzsignannotationsV1Request(); // EzsigndocumentEditEzsignannotationsV1Request | 

            try
            {
                // Edit multiple Ezsignannotations
                EzsigndocumentEditEzsignannotationsV1Response result = apiInstance.EzsigndocumentEditEzsignannotationsV1(pkiEzsigndocumentID, ezsigndocumentEditEzsignannotationsV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentEditEzsignannotationsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentEditEzsignannotationsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit multiple Ezsignannotations
    ApiResponse<EzsigndocumentEditEzsignannotationsV1Response> response = apiInstance.EzsigndocumentEditEzsignannotationsV1WithHttpInfo(pkiEzsigndocumentID, ezsigndocumentEditEzsignannotationsV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentEditEzsignannotationsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentEditEzsignannotationsV1Request** | [**EzsigndocumentEditEzsignannotationsV1Request**](EzsigndocumentEditEzsignannotationsV1Request.md) |  |  |

### Return type

[**EzsigndocumentEditEzsignannotationsV1Response**](EzsigndocumentEditEzsignannotationsV1Response.md)

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

<a id="ezsigndocumenteditezsignformfieldgroupsv1"></a>
# **EzsigndocumentEditEzsignformfieldgroupsV1**
> EzsigndocumentEditEzsignformfieldgroupsV1Response EzsigndocumentEditEzsignformfieldgroupsV1 (int pkiEzsigndocumentID, EzsigndocumentEditEzsignformfieldgroupsV1Request ezsigndocumentEditEzsignformfieldgroupsV1Request)

Edit multiple Ezsignformfieldgroups

Using this endpoint, you can edit multiple Ezsignformfieldgroups at the same time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentEditEzsignformfieldgroupsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var ezsigndocumentEditEzsignformfieldgroupsV1Request = new EzsigndocumentEditEzsignformfieldgroupsV1Request(); // EzsigndocumentEditEzsignformfieldgroupsV1Request | 

            try
            {
                // Edit multiple Ezsignformfieldgroups
                EzsigndocumentEditEzsignformfieldgroupsV1Response result = apiInstance.EzsigndocumentEditEzsignformfieldgroupsV1(pkiEzsigndocumentID, ezsigndocumentEditEzsignformfieldgroupsV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentEditEzsignformfieldgroupsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentEditEzsignformfieldgroupsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit multiple Ezsignformfieldgroups
    ApiResponse<EzsigndocumentEditEzsignformfieldgroupsV1Response> response = apiInstance.EzsigndocumentEditEzsignformfieldgroupsV1WithHttpInfo(pkiEzsigndocumentID, ezsigndocumentEditEzsignformfieldgroupsV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentEditEzsignformfieldgroupsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentEditEzsignformfieldgroupsV1Request** | [**EzsigndocumentEditEzsignformfieldgroupsV1Request**](EzsigndocumentEditEzsignformfieldgroupsV1Request.md) |  |  |

### Return type

[**EzsigndocumentEditEzsignformfieldgroupsV1Response**](EzsigndocumentEditEzsignformfieldgroupsV1Response.md)

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

<a id="ezsigndocumenteditezsignsignaturesv1"></a>
# **EzsigndocumentEditEzsignsignaturesV1**
> EzsigndocumentEditEzsignsignaturesV1Response EzsigndocumentEditEzsignsignaturesV1 (int pkiEzsigndocumentID, EzsigndocumentEditEzsignsignaturesV1Request ezsigndocumentEditEzsignsignaturesV1Request)

Edit multiple Ezsignsignatures

Using this endpoint, you can edit multiple Ezsignsignatures at the same time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentEditEzsignsignaturesV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var ezsigndocumentEditEzsignsignaturesV1Request = new EzsigndocumentEditEzsignsignaturesV1Request(); // EzsigndocumentEditEzsignsignaturesV1Request | 

            try
            {
                // Edit multiple Ezsignsignatures
                EzsigndocumentEditEzsignsignaturesV1Response result = apiInstance.EzsigndocumentEditEzsignsignaturesV1(pkiEzsigndocumentID, ezsigndocumentEditEzsignsignaturesV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentEditEzsignsignaturesV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentEditEzsignsignaturesV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit multiple Ezsignsignatures
    ApiResponse<EzsigndocumentEditEzsignsignaturesV1Response> response = apiInstance.EzsigndocumentEditEzsignsignaturesV1WithHttpInfo(pkiEzsigndocumentID, ezsigndocumentEditEzsignsignaturesV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentEditEzsignsignaturesV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentEditEzsignsignaturesV1Request** | [**EzsigndocumentEditEzsignsignaturesV1Request**](EzsigndocumentEditEzsignsignaturesV1Request.md) |  |  |

### Return type

[**EzsigndocumentEditEzsignsignaturesV1Response**](EzsigndocumentEditEzsignsignaturesV1Response.md)

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

<a id="ezsigndocumenteditobjectv1"></a>
# **EzsigndocumentEditObjectV1**
> EzsigndocumentEditObjectV1Response EzsigndocumentEditObjectV1 (int pkiEzsigndocumentID, EzsigndocumentEditObjectV1Request ezsigndocumentEditObjectV1Request)

Edit an existing Ezsigndocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentEditObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var ezsigndocumentEditObjectV1Request = new EzsigndocumentEditObjectV1Request(); // EzsigndocumentEditObjectV1Request | 

            try
            {
                // Edit an existing Ezsigndocument
                EzsigndocumentEditObjectV1Response result = apiInstance.EzsigndocumentEditObjectV1(pkiEzsigndocumentID, ezsigndocumentEditObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentEditObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentEditObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing Ezsigndocument
    ApiResponse<EzsigndocumentEditObjectV1Response> response = apiInstance.EzsigndocumentEditObjectV1WithHttpInfo(pkiEzsigndocumentID, ezsigndocumentEditObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentEditObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentEditObjectV1Request** | [**EzsigndocumentEditObjectV1Request**](EzsigndocumentEditObjectV1Request.md) |  |  |

### Return type

[**EzsigndocumentEditObjectV1Response**](EzsigndocumentEditObjectV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. If the error is recoverable sTemporaryFileUrl will be set and you can use this url to try a new request without sending the file over again |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigndocumentendprematurelyv1"></a>
# **EzsigndocumentEndPrematurelyV1**
> CommonResponse EzsigndocumentEndPrematurelyV1 (int pkiEzsigndocumentID, Object body)

End prematurely

End prematurely an Ezsigndocument when some signatures are still required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentEndPrematurelyV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // End prematurely
                CommonResponse result = apiInstance.EzsigndocumentEndPrematurelyV1(pkiEzsigndocumentID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentEndPrematurelyV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentEndPrematurelyV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // End prematurely
    ApiResponse<CommonResponse> response = apiInstance.EzsigndocumentEndPrematurelyV1WithHttpInfo(pkiEzsigndocumentID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentEndPrematurelyV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigndocumentextracttextv1"></a>
# **EzsigndocumentExtractTextV1**
> EzsigndocumentExtractTextV1Response EzsigndocumentExtractTextV1 (int pkiEzsigndocumentID, EzsigndocumentExtractTextV1Request ezsigndocumentExtractTextV1Request)

Extract text from Ezsigndocument area

Extract text from Ezsigndocument area

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentExtractTextV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var ezsigndocumentExtractTextV1Request = new EzsigndocumentExtractTextV1Request(); // EzsigndocumentExtractTextV1Request | 

            try
            {
                // Extract text from Ezsigndocument area
                EzsigndocumentExtractTextV1Response result = apiInstance.EzsigndocumentExtractTextV1(pkiEzsigndocumentID, ezsigndocumentExtractTextV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentExtractTextV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentExtractTextV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract text from Ezsigndocument area
    ApiResponse<EzsigndocumentExtractTextV1Response> response = apiInstance.EzsigndocumentExtractTextV1WithHttpInfo(pkiEzsigndocumentID, ezsigndocumentExtractTextV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentExtractTextV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentExtractTextV1Request** | [**EzsigndocumentExtractTextV1Request**](EzsigndocumentExtractTextV1Request.md) |  |  |

### Return type

[**EzsigndocumentExtractTextV1Response**](EzsigndocumentExtractTextV1Response.md)

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

<a id="ezsigndocumentflattenv1"></a>
# **EzsigndocumentFlattenV1**
> CommonResponse EzsigndocumentFlattenV1 (int pkiEzsigndocumentID, Object body)

Flatten

Flatten an Ezsigndocument signatures, forms and annotations. This process finalizes the PDF so that the forms and annotations become part of the document content and cannot be edited.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentFlattenV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Flatten
                CommonResponse result = apiInstance.EzsigndocumentFlattenV1(pkiEzsigndocumentID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentFlattenV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentFlattenV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Flatten
    ApiResponse<CommonResponse> response = apiInstance.EzsigndocumentFlattenV1WithHttpInfo(pkiEzsigndocumentID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentFlattenV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigndocumentgetactionableelementsv1"></a>
# **EzsigndocumentGetActionableElementsV1**
> EzsigndocumentGetActionableElementsV1Response EzsigndocumentGetActionableElementsV1 (int pkiEzsigndocumentID)

Retrieve actionable elements for the Ezsigndocument

Return the Ezsignsignatures that can be signed and Ezsignformfieldgroups that can be filled by the current user at the current step in the process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetActionableElementsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Retrieve actionable elements for the Ezsigndocument
                EzsigndocumentGetActionableElementsV1Response result = apiInstance.EzsigndocumentGetActionableElementsV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetActionableElementsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetActionableElementsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve actionable elements for the Ezsigndocument
    ApiResponse<EzsigndocumentGetActionableElementsV1Response> response = apiInstance.EzsigndocumentGetActionableElementsV1WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetActionableElementsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetActionableElementsV1Response**](EzsigndocumentGetActionableElementsV1Response.md)

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

<a id="ezsigndocumentgetattachmentsv1"></a>
# **EzsigndocumentGetAttachmentsV1**
> EzsigndocumentGetAttachmentsV1Response EzsigndocumentGetAttachmentsV1 (int pkiEzsigndocumentID)

Retrieve Ezsigndocument's Attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Retrieve Ezsigndocument's Attachments
                EzsigndocumentGetAttachmentsV1Response result = apiInstance.EzsigndocumentGetAttachmentsV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Ezsigndocument's Attachments
    ApiResponse<EzsigndocumentGetAttachmentsV1Response> response = apiInstance.EzsigndocumentGetAttachmentsV1WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetAttachmentsV1Response**](EzsigndocumentGetAttachmentsV1Response.md)

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

<a id="ezsigndocumentgetcompletedelementsv1"></a>
# **EzsigndocumentGetCompletedElementsV1**
> EzsigndocumentGetCompletedElementsV1Response EzsigndocumentGetCompletedElementsV1 (int pkiEzsigndocumentID)

Retrieve completed elements for the Ezsigndocument

Return the completed Ezsignsignatures, Ezsignformfieldgroups and Ezsignannotations at the current step in the process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetCompletedElementsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Retrieve completed elements for the Ezsigndocument
                EzsigndocumentGetCompletedElementsV1Response result = apiInstance.EzsigndocumentGetCompletedElementsV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetCompletedElementsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetCompletedElementsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve completed elements for the Ezsigndocument
    ApiResponse<EzsigndocumentGetCompletedElementsV1Response> response = apiInstance.EzsigndocumentGetCompletedElementsV1WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetCompletedElementsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetCompletedElementsV1Response**](EzsigndocumentGetCompletedElementsV1Response.md)

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

<a id="ezsigndocumentgetdownloadurlv1"></a>
# **EzsigndocumentGetDownloadUrlV1**
> EzsigndocumentGetDownloadUrlV1Response EzsigndocumentGetDownloadUrlV1 (int pkiEzsigndocumentID, string eDocumentType)

Retrieve a URL to download documents.

This endpoint returns URLs to different files that can be downloaded during the signing process.  These links will expire after 5 minutes so the download of the file should be made soon after retrieving the link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetDownloadUrlV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var eDocumentType = "Initial";  // string | The type of document to retrieve.  1. **Initial** Is the initial document before any signature were applied. 2. **SignatureReady** Is the version containing the annotations/form to show the signer. 3. **Signed** Is the final document once all signatures were applied in current document if eEzsignfolderCompletion is PerEzsigndocument.<br>     Is the final document once all signatures were applied in all documents if eEzsignfolderCompletion is PerEzsignfolder. 4. **Proofdocument** Is the evidence report. 5. **Proof** Is the complete evidence archive including all of the above and more. 

            try
            {
                // Retrieve a URL to download documents.
                EzsigndocumentGetDownloadUrlV1Response result = apiInstance.EzsigndocumentGetDownloadUrlV1(pkiEzsigndocumentID, eDocumentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetDownloadUrlV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetDownloadUrlV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a URL to download documents.
    ApiResponse<EzsigndocumentGetDownloadUrlV1Response> response = apiInstance.EzsigndocumentGetDownloadUrlV1WithHttpInfo(pkiEzsigndocumentID, eDocumentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetDownloadUrlV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **eDocumentType** | **string** | The type of document to retrieve.  1. **Initial** Is the initial document before any signature were applied. 2. **SignatureReady** Is the version containing the annotations/form to show the signer. 3. **Signed** Is the final document once all signatures were applied in current document if eEzsignfolderCompletion is PerEzsigndocument.&lt;br&gt;     Is the final document once all signatures were applied in all documents if eEzsignfolderCompletion is PerEzsignfolder. 4. **Proofdocument** Is the evidence report. 5. **Proof** Is the complete evidence archive including all of the above and more.  |  |

### Return type

[**EzsigndocumentGetDownloadUrlV1Response**](EzsigndocumentGetDownloadUrlV1Response.md)

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

<a id="ezsigndocumentgetezsignannotationsv1"></a>
# **EzsigndocumentGetEzsignannotationsV1**
> EzsigndocumentGetEzsignannotationsV1Response EzsigndocumentGetEzsignannotationsV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's Ezsignannotations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetEzsignannotationsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigndocument's Ezsignannotations
                EzsigndocumentGetEzsignannotationsV1Response result = apiInstance.EzsigndocumentGetEzsignannotationsV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetEzsignannotationsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetEzsignannotationsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigndocument's Ezsignannotations
    ApiResponse<EzsigndocumentGetEzsignannotationsV1Response> response = apiInstance.EzsigndocumentGetEzsignannotationsV1WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetEzsignannotationsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetEzsignannotationsV1Response**](EzsigndocumentGetEzsignannotationsV1Response.md)

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

<a id="ezsigndocumentgetezsigndiscussionsv1"></a>
# **EzsigndocumentGetEzsigndiscussionsV1**
> EzsigndocumentGetEzsigndiscussionsV1Response EzsigndocumentGetEzsigndiscussionsV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's Ezsigndiscussions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetEzsigndiscussionsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigndocument's Ezsigndiscussions
                EzsigndocumentGetEzsigndiscussionsV1Response result = apiInstance.EzsigndocumentGetEzsigndiscussionsV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetEzsigndiscussionsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetEzsigndiscussionsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigndocument's Ezsigndiscussions
    ApiResponse<EzsigndocumentGetEzsigndiscussionsV1Response> response = apiInstance.EzsigndocumentGetEzsigndiscussionsV1WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetEzsigndiscussionsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetEzsigndiscussionsV1Response**](EzsigndocumentGetEzsigndiscussionsV1Response.md)

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

<a id="ezsigndocumentgetezsignformfieldgroupsv1"></a>
# **EzsigndocumentGetEzsignformfieldgroupsV1**
> EzsigndocumentGetEzsignformfieldgroupsV1Response EzsigndocumentGetEzsignformfieldgroupsV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's Ezsignformfieldgroups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetEzsignformfieldgroupsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigndocument's Ezsignformfieldgroups
                EzsigndocumentGetEzsignformfieldgroupsV1Response result = apiInstance.EzsigndocumentGetEzsignformfieldgroupsV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetEzsignformfieldgroupsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetEzsignformfieldgroupsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigndocument's Ezsignformfieldgroups
    ApiResponse<EzsigndocumentGetEzsignformfieldgroupsV1Response> response = apiInstance.EzsigndocumentGetEzsignformfieldgroupsV1WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetEzsignformfieldgroupsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetEzsignformfieldgroupsV1Response**](EzsigndocumentGetEzsignformfieldgroupsV1Response.md)

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

<a id="ezsigndocumentgetezsignpagesv1"></a>
# **EzsigndocumentGetEzsignpagesV1**
> EzsigndocumentGetEzsignpagesV1Response EzsigndocumentGetEzsignpagesV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's Ezsignpages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetEzsignpagesV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigndocument's Ezsignpages
                EzsigndocumentGetEzsignpagesV1Response result = apiInstance.EzsigndocumentGetEzsignpagesV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetEzsignpagesV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetEzsignpagesV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigndocument's Ezsignpages
    ApiResponse<EzsigndocumentGetEzsignpagesV1Response> response = apiInstance.EzsigndocumentGetEzsignpagesV1WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetEzsignpagesV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetEzsignpagesV1Response**](EzsigndocumentGetEzsignpagesV1Response.md)

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

<a id="ezsigndocumentgetezsignsignaturesautomaticv1"></a>
# **EzsigndocumentGetEzsignsignaturesAutomaticV1**
> EzsigndocumentGetEzsignsignaturesAutomaticV1Response EzsigndocumentGetEzsignsignaturesAutomaticV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's automatic Ezsignsignatures

Return the Ezsignsignatures that can be signed by the current user at the current step in the process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetEzsignsignaturesAutomaticV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigndocument's automatic Ezsignsignatures
                EzsigndocumentGetEzsignsignaturesAutomaticV1Response result = apiInstance.EzsigndocumentGetEzsignsignaturesAutomaticV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetEzsignsignaturesAutomaticV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetEzsignsignaturesAutomaticV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigndocument's automatic Ezsignsignatures
    ApiResponse<EzsigndocumentGetEzsignsignaturesAutomaticV1Response> response = apiInstance.EzsigndocumentGetEzsignsignaturesAutomaticV1WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetEzsignsignaturesAutomaticV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetEzsignsignaturesAutomaticV1Response**](EzsigndocumentGetEzsignsignaturesAutomaticV1Response.md)

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

<a id="ezsigndocumentgetezsignsignaturesv1"></a>
# **EzsigndocumentGetEzsignsignaturesV1**
> EzsigndocumentGetEzsignsignaturesV1Response EzsigndocumentGetEzsignsignaturesV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's Ezsignsignatures

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetEzsignsignaturesV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigndocument's Ezsignsignatures
                EzsigndocumentGetEzsignsignaturesV1Response result = apiInstance.EzsigndocumentGetEzsignsignaturesV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetEzsignsignaturesV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetEzsignsignaturesV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigndocument's Ezsignsignatures
    ApiResponse<EzsigndocumentGetEzsignsignaturesV1Response> response = apiInstance.EzsigndocumentGetEzsignsignaturesV1WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetEzsignsignaturesV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetEzsignsignaturesV1Response**](EzsigndocumentGetEzsignsignaturesV1Response.md)

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

<a id="ezsigndocumentgetformdatav1"></a>
# **EzsigndocumentGetFormDataV1**
> EzsigndocumentGetFormDataV1Response EzsigndocumentGetFormDataV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's Form Data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetFormDataV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigndocument's Form Data
                EzsigndocumentGetFormDataV1Response result = apiInstance.EzsigndocumentGetFormDataV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetFormDataV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetFormDataV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigndocument's Form Data
    ApiResponse<EzsigndocumentGetFormDataV1Response> response = apiInstance.EzsigndocumentGetFormDataV1WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetFormDataV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetFormDataV1Response**](EzsigndocumentGetFormDataV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/zip, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigndocumentgetobjectv1"></a>
# **EzsigndocumentGetObjectV1**
> EzsigndocumentGetObjectV1Response EzsigndocumentGetObjectV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigndocument
                EzsigndocumentGetObjectV1Response result = apiInstance.EzsigndocumentGetObjectV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigndocument
    ApiResponse<EzsigndocumentGetObjectV1Response> response = apiInstance.EzsigndocumentGetObjectV1WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetObjectV1Response**](EzsigndocumentGetObjectV1Response.md)

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

<a id="ezsigndocumentgetobjectv2"></a>
# **EzsigndocumentGetObjectV2**
> EzsigndocumentGetObjectV2Response EzsigndocumentGetObjectV2 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Retrieve an existing Ezsigndocument
                EzsigndocumentGetObjectV2Response result = apiInstance.EzsigndocumentGetObjectV2(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Ezsigndocument
    ApiResponse<EzsigndocumentGetObjectV2Response> response = apiInstance.EzsigndocumentGetObjectV2WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetObjectV2Response**](EzsigndocumentGetObjectV2Response.md)

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

<a id="ezsigndocumentgettemporaryproofv1"></a>
# **EzsigndocumentGetTemporaryProofV1**
> EzsigndocumentGetTemporaryProofV1Response EzsigndocumentGetTemporaryProofV1 (int pkiEzsigndocumentID)

Retrieve the temporary proof

Retrieve the temporary proof while the Ezsigndocument is being processed since the proof isn't available until the Ezsigndocument is completed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetTemporaryProofV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 

            try
            {
                // Retrieve the temporary proof
                EzsigndocumentGetTemporaryProofV1Response result = apiInstance.EzsigndocumentGetTemporaryProofV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetTemporaryProofV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetTemporaryProofV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the temporary proof
    ApiResponse<EzsigndocumentGetTemporaryProofV1Response> response = apiInstance.EzsigndocumentGetTemporaryProofV1WithHttpInfo(pkiEzsigndocumentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetTemporaryProofV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |

### Return type

[**EzsigndocumentGetTemporaryProofV1Response**](EzsigndocumentGetTemporaryProofV1Response.md)

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

<a id="ezsigndocumentgetwordspositionsv1"></a>
# **EzsigndocumentGetWordsPositionsV1**
> EzsigndocumentGetWordsPositionsV1Response EzsigndocumentGetWordsPositionsV1 (int pkiEzsigndocumentID, EzsigndocumentGetWordsPositionsV1Request ezsigndocumentGetWordsPositionsV1Request)

Retrieve positions X,Y of given words from a Ezsigndocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetWordsPositionsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var ezsigndocumentGetWordsPositionsV1Request = new EzsigndocumentGetWordsPositionsV1Request(); // EzsigndocumentGetWordsPositionsV1Request | 

            try
            {
                // Retrieve positions X,Y of given words from a Ezsigndocument
                EzsigndocumentGetWordsPositionsV1Response result = apiInstance.EzsigndocumentGetWordsPositionsV1(pkiEzsigndocumentID, ezsigndocumentGetWordsPositionsV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetWordsPositionsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentGetWordsPositionsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve positions X,Y of given words from a Ezsigndocument
    ApiResponse<EzsigndocumentGetWordsPositionsV1Response> response = apiInstance.EzsigndocumentGetWordsPositionsV1WithHttpInfo(pkiEzsigndocumentID, ezsigndocumentGetWordsPositionsV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetWordsPositionsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentGetWordsPositionsV1Request** | [**EzsigndocumentGetWordsPositionsV1Request**](EzsigndocumentGetWordsPositionsV1Request.md) |  |  |

### Return type

[**EzsigndocumentGetWordsPositionsV1Response**](EzsigndocumentGetWordsPositionsV1Response.md)

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

<a id="ezsigndocumentpatchobjectv1"></a>
# **EzsigndocumentPatchObjectV1**
> CommonResponse EzsigndocumentPatchObjectV1 (int pkiEzsigndocumentID, EzsigndocumentPatchObjectV1Request ezsigndocumentPatchObjectV1Request)

Patch an existing Ezsigndocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentPatchObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var ezsigndocumentPatchObjectV1Request = new EzsigndocumentPatchObjectV1Request(); // EzsigndocumentPatchObjectV1Request | 

            try
            {
                // Patch an existing Ezsigndocument
                CommonResponse result = apiInstance.EzsigndocumentPatchObjectV1(pkiEzsigndocumentID, ezsigndocumentPatchObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentPatchObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentPatchObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patch an existing Ezsigndocument
    ApiResponse<CommonResponse> response = apiInstance.EzsigndocumentPatchObjectV1WithHttpInfo(pkiEzsigndocumentID, ezsigndocumentPatchObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentPatchObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentPatchObjectV1Request** | [**EzsigndocumentPatchObjectV1Request**](EzsigndocumentPatchObjectV1Request.md) |  |  |

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

<a id="ezsigndocumentsubmitezsignformv1"></a>
# **EzsigndocumentSubmitEzsignformV1**
> CommonResponse EzsigndocumentSubmitEzsignformV1 (int pkiEzsigndocumentID, EzsigndocumentSubmitEzsignformV1Request ezsigndocumentSubmitEzsignformV1Request)

Submit the Ezsignform

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentSubmitEzsignformV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var ezsigndocumentSubmitEzsignformV1Request = new EzsigndocumentSubmitEzsignformV1Request(); // EzsigndocumentSubmitEzsignformV1Request | 

            try
            {
                // Submit the Ezsignform
                CommonResponse result = apiInstance.EzsigndocumentSubmitEzsignformV1(pkiEzsigndocumentID, ezsigndocumentSubmitEzsignformV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentSubmitEzsignformV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentSubmitEzsignformV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit the Ezsignform
    ApiResponse<CommonResponse> response = apiInstance.EzsigndocumentSubmitEzsignformV1WithHttpInfo(pkiEzsigndocumentID, ezsigndocumentSubmitEzsignformV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentSubmitEzsignformV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
| **ezsigndocumentSubmitEzsignformV1Request** | [**EzsigndocumentSubmitEzsignformV1Request**](EzsigndocumentSubmitEzsignformV1Request.md) |  |  |

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ezsigndocumentunsendv1"></a>
# **EzsigndocumentUnsendV1**
> CommonResponse EzsigndocumentUnsendV1 (int pkiEzsigndocumentID, Object body)

Unsend the Ezsigndocument

Once an Ezsigndocument has been sent to signatories, it cannot be modified.  Using this endpoint, you can unsend the Ezsigndocument and make it modifiable again.  Signatories will receive an email informing them the signature process was aborted and they might receive a new invitation to sign.  ⚠️ Warning: Any signature previously made by signatories on this Ezsigndocumentswill be lost.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentUnsendV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | 
            var body = null;  // Object | 

            try
            {
                // Unsend the Ezsigndocument
                CommonResponse result = apiInstance.EzsigndocumentUnsendV1(pkiEzsigndocumentID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentUnsendV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EzsigndocumentUnsendV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unsend the Ezsigndocument
    ApiResponse<CommonResponse> response = apiInstance.EzsigndocumentUnsendV1WithHttpInfo(pkiEzsigndocumentID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentUnsendV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigndocumentID** | **int** |  |  |
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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


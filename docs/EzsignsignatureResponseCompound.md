# eZmaxApi.Model.EzsignsignatureResponseCompound
An Ezsignsignature Object and children to create a complete structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DtEzsignsignatureDateInFolderTimezone** | **string** | The date the Ezsignsignature was signed in folder&#39;s timezone | [optional] 
**BEzsignsignatureCustomdate** | **bool** | Whether the Ezsignsignature has a custom date format or not. (Only possible when eEzsignsignatureType is **Name** or **Handwritten**) | [optional] 
**AObjEzsignsignaturecustomdate** | [**List&lt;EzsignsignaturecustomdateResponseCompound&gt;**](EzsignsignaturecustomdateResponse.md) | An array of custom date blocks that will be filled at the time of signature.  Can only be used if bEzsignsignatureCustomdate is true.  Use an empty array if you don&#39;t want to have a date at all. | [optional] 
**ObjCreditcardtransaction** | [**CustomCreditcardtransactionResponse**](CustomCreditcardtransactionResponse.md) |  | [optional] 
**AObjEzsignelementdependency** | [**List&lt;EzsignelementdependencyResponseCompound&gt;**](EzsignelementdependencyResponse.md) |  | [optional] 
**ObjTimezone** | [**CustomTimezoneWithCodeResponse**](CustomTimezoneWithCodeResponse.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


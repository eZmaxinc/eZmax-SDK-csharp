# eZmaxApi.Model.EzsigntemplatesignatureRequestCompound
A Ezsigntemplatesignature Object and children

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BEzsigntemplatesignatureCustomdate** | **bool** | Whether the Ezsigntemplatesignature has a custom date format or not. (Only possible when eEzsigntemplatesignatureType is **Name** or **Handwritten**) | [optional] 
**AObjEzsigntemplatesignaturecustomdate** | [**List&lt;EzsigntemplatesignaturecustomdateRequestCompound&gt;**](EzsigntemplatesignaturecustomdateRequest.md) | An array of custom date blocks that will be filled at the time of signature.  Can only be used if bEzsigntemplatesignatureCustomdate is true.  Use an empty array if you don&#39;t want to have a date at all. | [optional] 
**AObjEzsigntemplateelementdependency** | [**List&lt;EzsigntemplateelementdependencyRequestCompound&gt;**](EzsigntemplateelementdependencyRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


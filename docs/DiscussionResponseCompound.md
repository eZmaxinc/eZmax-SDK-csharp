# eZmaxApi.Model.DiscussionResponseCompound
A Discussion Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiDiscussionID** | **int** | The unique ID of the Discussion | 
**SDiscussionDescription** | **string** | The description of the Discussion | 
**BDiscussionClosed** | **bool** | Whether if it&#39;s an closed | 
**DtDiscussionLastread** | **string** | The date the Discussion was last read | [optional] 
**IDiscussionmessageCount** | **int** | The count of Attachment. | 
**IDiscussionmessageCountunread** | **int** | The count of Attachment. | 
**ObjDiscussionconfiguration** | [**CustomDiscussionconfigurationResponse**](CustomDiscussionconfigurationResponse.md) |  | [optional] 
**AObjDiscussionmembership** | [**List&lt;DiscussionmembershipResponseCompound&gt;**](DiscussionmembershipResponseCompound.md) |  | 
**AObjDiscussionmessage** | [**List&lt;DiscussionmessageResponseCompound&gt;**](DiscussionmessageResponseCompound.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


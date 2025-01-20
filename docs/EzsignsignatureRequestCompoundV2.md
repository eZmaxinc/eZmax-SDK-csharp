# eZmaxApi.Model.EzsignsignatureRequestCompoundV2
An Ezsignsignature Object and children to create a complete structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignsignatureID** | **int** | The unique ID of the Ezsignsignature | [optional] 
**FkiEzsignfoldersignerassociationID** | **int** | The unique ID of the Ezsignfoldersignerassociation | 
**IEzsignpagePagenumber** | **int** | The page number in the Ezsigndocument | 
**IEzsignsignatureX** | **int** | The X coordinate (Horizontal) where to put the Ezsignsignature on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignsignature 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate. | 
**IEzsignsignatureY** | **int** | The Y coordinate (Vertical) where to put the Ezsignsignature on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignsignature 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate. | 
**IEzsignsignatureWidth** | **int** | The width of the Ezsignsignature.  Size is calculated at 100dpi (dot per inch). So for example, if you want the Ezsignsignature to have a width of 2 inches, you would use \&quot;200\&quot; for the iEzsignsignatureWidth. | [optional] 
**IEzsignsignatureHeight** | **int** | The height of the Ezsignsignature.  Size is calculated at 100dpi (dot per inch). So for example, if you want the Ezsignsignature to have an height of 2 inches, you would use \&quot;200\&quot; for the iEzsignsignatureHeight. | [optional] 
**IEzsignsignatureStep** | **int** | The step when the Ezsignsigner will be invited to sign | 
**EEzsignsignatureType** | **FieldEEzsignsignatureType** |  | 
**FkiEzsigndocumentID** | **int** | The unique ID of the Ezsigndocument | 
**TEzsignsignatureTooltip** | **string** | A tooltip that will be presented to Ezsignsigner about the Ezsignsignature | [optional] 
**EEzsignsignatureTooltipposition** | **FieldEEzsignsignatureTooltipposition** |  | [optional] 
**EEzsignsignatureFont** | **FieldEEzsignsignatureFont** |  | [optional] 
**FkiEzsignfoldersignerassociationIDValidation** | **int** | The unique ID of the Ezsignfoldersignerassociation | [optional] 
**BEzsignsignatureHandwritten** | **bool** | Whether the Ezsignsignature must be handwritten or not when eEzsignsignatureType &#x3D; Signature. | [optional] 
**BEzsignsignatureReason** | **bool** | Whether the Ezsignsignature must include a reason or not when eEzsignsignatureType &#x3D; Signature. | [optional] 
**BEzsignsignatureRequired** | **bool** | Whether the Ezsignsignature is required or not. This field is relevant only with Ezsignsignature with eEzsignsignatureType &#x3D; Attachments, Text or Textarea. | [optional] 
**EEzsignsignatureAttachmentnamesource** | **FieldEEzsignsignatureAttachmentnamesource** |  | [optional] 
**SEzsignsignatureAttachmentdescription** | **string** | The description attached to the attachment name added in Ezsignsignature of eEzsignsignatureType Attachments | [optional] 
**EEzsignsignatureConsultationtrigger** | **FieldEEzsignsignatureConsultationtrigger** |  | [optional] 
**IEzsignsignatureValidationstep** | **int** | The step when the Ezsignsigner will be invited to validate the Ezsignsignature of eEzsignsignatureType Attachments | [optional] 
**IEzsignsignatureMaxlength** | **int** | The maximum length for the value in the Ezsignsignature  This can only be set if eEzsignsignatureType is **FieldText** or **FieldTextarea** | [optional] 
**SEzsignsignatureDefaultvalue** | **string** | The default value for the Ezsignsignature  You can use the codes below and they will be replaced at signature time.    | Code | Description | Example | | - -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- - | - -- -- -- -- -- - | | {sUserFirstname} | The first name of the contact | John | | {sUserLastname} | The last name of the contact | Doe | | {sUserJobtitle} | The job title | Sales Representative | | {sCompany} | Company name | eZmax Solutions Inc. | | {sEmailAddress} | The email address | email@example.com | | {sPhoneE164} | A phone number in E.164 Format | +15149901516 | | {sPhoneE164Cell} | A phone number in E.164 Format | +15149901516 | | [optional] 
**EEzsignsignatureTextvalidation** | **EnumTextvalidation** |  | [optional] 
**SEzsignsignatureTextvalidationcustommessage** | **string** | Description of validation rule. Show by signatory. | [optional] 
**SEzsignsignatureRegexp** | **string** | A regular expression to indicate what values are acceptable for the Ezsignsignature.  This can only be set if eEzsignsignatureType is **FieldText** or **FieldTextarea** and eEzsignsignatureTextvalidation is **Custom** | [optional] 
**EEzsignsignatureDependencyrequirement** | **FieldEEzsignsignatureDependencyrequirement** |  | [optional] 
**BEzsignsignatureCustomdate** | **bool** | Whether the Ezsignsignature has a custom date format or not. (Only possible when eEzsignsignatureType is **Name** or **Handwritten**) | [optional] 
**AObjEzsignsignaturecustomdate** | [**List&lt;EzsignsignaturecustomdateRequestCompoundV2&gt;**](EzsignsignaturecustomdateRequestV2.md) | An array of custom date blocks that will be filled at the time of signature.  Can only be used if bEzsignsignatureCustomdate is true.  Use an empty array if you don&#39;t want to have a date at all. | [optional] 
**AObjEzsignelementdependency** | [**List&lt;EzsignelementdependencyRequestCompound&gt;**](EzsignelementdependencyRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


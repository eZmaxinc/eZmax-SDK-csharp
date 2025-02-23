# eZmaxApi.Model.EzsignsignatureResponseCompoundV3
An Ezsignsignature Object and children to create a complete structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignsignatureID** | **int** | The unique ID of the Ezsignsignature | 
**FkiEzsigndocumentID** | **int** | The unique ID of the Ezsigndocument | 
**FkiEzsignfoldersignerassociationID** | **int** | The unique ID of the Ezsignfoldersignerassociation | 
**FkiEzsignsigningreasonID** | **int** | The unique ID of the Ezsignsigningreason | [optional] 
**FkiFontID** | **int** | The unique ID of the Font | [optional] 
**SEzsignsigningreasonDescriptionX** | **string** | The description of the Ezsignsigningreason in the language of the requester | [optional] 
**IEzsignpagePagenumber** | **int** | The page number in the Ezsigndocument | 
**IEzsignsignatureX** | **int** | The X coordinate (Horizontal) where to put the Ezsignsignature on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignsignature 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate. | 
**IEzsignsignatureY** | **int** | The Y coordinate (Vertical) where to put the Ezsignsignature on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignsignature 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate. | 
**IEzsignsignatureHeight** | **int** | The height of the Ezsignsignature.  Size is calculated at 100dpi (dot per inch). So for example, if you want the Ezsignsignature to have an height of 2 inches, you would use \&quot;200\&quot; for the iEzsignsignatureHeight. | [optional] 
**IEzsignsignatureWidth** | **int** | The width of the Ezsignsignature.  Size is calculated at 100dpi (dot per inch). So for example, if you want the Ezsignsignature to have a width of 2 inches, you would use \&quot;200\&quot; for the iEzsignsignatureWidth. | [optional] 
**IEzsignsignatureStep** | **int** | The step when the Ezsignsigner will be invited to sign | 
**IEzsignsignatureStepadjusted** | **int** | The step when the Ezsignsigner will be invited to sign | [optional] 
**EEzsignsignatureType** | **FieldEEzsignsignatureType** |  | 
**TEzsignsignatureTooltip** | **string** | A tooltip that will be presented to Ezsignsigner about the Ezsignsignature | [optional] 
**EEzsignsignatureTooltipposition** | **FieldEEzsignsignatureTooltipposition** |  | [optional] 
**EEzsignsignatureFont** | **FieldEEzsignsignatureFont** |  | [optional] 
**IEzsignsignatureValidationstep** | **int** | The step when the Ezsignsigner will be invited to validate the Ezsignsignature of eEzsignsignatureType Attachments | [optional] 
**SEzsignsignatureAttachmentdescription** | **string** | The description attached to the attachment name added in Ezsignsignature of eEzsignsignatureType Attachments | [optional] 
**EEzsignsignatureAttachmentnamesource** | **FieldEEzsignsignatureAttachmentnamesource** |  | [optional] 
**EEzsignsignatureConsultationtrigger** | **FieldEEzsignsignatureConsultationtrigger** |  | [optional] 
**BEzsignsignatureHandwritten** | **bool** | Whether the Ezsignsignature must be handwritten or not when eEzsignsignatureType &#x3D; Signature. | [optional] 
**BEzsignsignatureReason** | **bool** | Whether the Ezsignsignature must include a reason or not when eEzsignsignatureType &#x3D; Signature. | [optional] 
**BEzsignsignatureRequired** | **bool** | Whether the Ezsignsignature is required or not. This field is relevant only with Ezsignsignature with eEzsignsignatureType &#x3D; Attachments, Text or Textarea. | [optional] 
**FkiEzsignfoldersignerassociationIDValidation** | **int** | The unique ID of the Ezsignfoldersignerassociation | [optional] 
**DtEzsignsignatureDate** | **string** | The date the Ezsignsignature was signed | [optional] 
**IEzsignsignatureattachmentCount** | **int** | The count of Ezsignsignatureattachment | [optional] 
**SEzsignsignatureDescription** | **string** | The value entered while signing Ezsignsignature of eEzsignsignatureType **City**, **FieldText** and **FieldTextarea** | [optional] 
**IEzsignsignatureMaxlength** | **int** | The maximum length for the value in the Ezsignsignature  This can only be set if eEzsignsignatureType is **FieldText** or **FieldTextarea** | [optional] 
**EEzsignsignatureTextvalidation** | **EnumTextvalidation** |  | [optional] 
**SEzsignsignatureTextvalidationcustommessage** | **string** | Description of validation rule. Show by signatory. | [optional] 
**EEzsignsignatureDependencyrequirement** | **FieldEEzsignsignatureDependencyrequirement** |  | [optional] 
**SEzsignsignatureDefaultvalue** | **string** | The default value for the Ezsignsignature  You can use the codes below and they will be replaced at signature time.    | Code | Description | Example | | - -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- - | - -- -- -- -- -- - | | {sUserFirstname} | The first name of the contact | John | | {sUserLastname} | The last name of the contact | Doe | | {sUserJobtitle} | The job title | Sales Representative | | {sCompany} | Company name | eZmax Solutions Inc. | | {sEmailAddress} | The email address | email@example.com | | {sPhoneE164} | A phone number in E.164 Format | +15149901516 | | {sPhoneE164Cell} | A phone number in E.164 Format | +15149901516 | | [optional] 
**SEzsignsignatureRegexp** | **string** | A regular expression to indicate what values are acceptable for the Ezsignsignature.  This can only be set if eEzsignsignatureType is **FieldText** or **FieldTextarea** and eEzsignsignatureTextvalidation is **Custom** | [optional] 
**ObjContactName** | [**CustomContactNameResponse**](CustomContactNameResponse.md) |  | 
**ObjContactNameDelegation** | [**CustomContactNameResponse**](CustomContactNameResponse.md) |  | [optional] 
**ObjSignature** | [**SignatureResponseCompound**](SignatureResponseCompound.md) |  | [optional] 
**BEzsignsignatureCustomdate** | **bool** | Whether the Ezsignsignature has a custom date format or not. (Only possible when eEzsignsignatureType is **Name** or **Handwritten**) | [optional] 
**AObjEzsignsignaturecustomdate** | [**List&lt;EzsignsignaturecustomdateResponseCompoundV2&gt;**](EzsignsignaturecustomdateResponseCompoundV2.md) | An array of custom date blocks that will be filled at the time of signature.  Can only be used if bEzsignsignatureCustomdate is true.  Use an empty array if you don&#39;t want to have a date at all. | [optional] 
**ObjCreditcardtransaction** | [**CustomCreditcardtransactionResponse**](CustomCreditcardtransactionResponse.md) |  | [optional] 
**AObjEzsignelementdependency** | [**List&lt;EzsignelementdependencyResponseCompound&gt;**](EzsignelementdependencyResponseCompound.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


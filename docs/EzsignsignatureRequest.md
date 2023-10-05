# eZmaxApi.Model.EzsignsignatureRequest
An Ezsignsignature Object

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
**BEzsignsignatureRequired** | **bool** | Whether the Ezsignsignature is required or not. This field is relevant only with Ezsignsignature with eEzsignsignatureType &#x3D; Attachments. | [optional] 
**EEzsignsignatureAttachmentnamesource** | **FieldEEzsignsignatureAttachmentnamesource** |  | [optional] 
**SEzsignsignatureAttachmentdescription** | **string** | The description attached to the attachment name added in Ezsignsignature of eEzsignsignatureType Attachments | [optional] 
**IEzsignsignatureValidationstep** | **int** | The step when the Ezsignsigner will be invited to validate the Ezsignsignature of eEzsignsignatureType Attachments | [optional] 
**IEzsignsignatureMaxlength** | **int** | The maximum length for the value in the Ezsignsignature  This can only be set if eEzsignsignatureType is **FieldText** or **FieldTextarea** | [optional] 
**EEzsignsignatureTextvalidation** | **EnumTextvalidation** |  | [optional] 
**SEzsignsignatureRegexp** | **string** | A regular expression to indicate what values are acceptable for the Ezsignsignature.  This can only be set if eEzsignsignatureType is **FieldText** or **FieldTextarea** and eEzsignsignatureTextvalidation is **Custom** | [optional] 
**EEzsignsignatureDependencyrequirement** | **FieldEEzsignsignatureDependencyrequirement** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


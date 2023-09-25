# eZmaxApi.Model.EzsigntemplatesignatureResponse
A Ezsigntemplatesignature Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsigntemplatesignatureID** | **int** | The unique ID of the Ezsigntemplatesignature | 
**FkiEzsigntemplatedocumentID** | **int** | The unique ID of the Ezsigntemplatedocument | 
**FkiEzsigntemplatesignerID** | **int** | The unique ID of the Ezsigntemplatesigner | 
**FkiEzsigntemplatesignerIDValidation** | **int** | The unique ID of the Ezsigntemplatesigner | [optional] 
**IEzsigntemplatedocumentpagePagenumber** | **int** | The page number in the Ezsigntemplatedocument | 
**IEzsigntemplatesignatureX** | **int** | The X coordinate (Horizontal) where to put the Ezsigntemplatesignature on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsigntemplatesignature 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate. | 
**IEzsigntemplatesignatureY** | **int** | The Y coordinate (Vertical) where to put the Ezsigntemplatesignature on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsigntemplatesignature 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate. | 
**IEzsigntemplatesignatureWidth** | **int** | The width of the Ezsigntemplatesignature.  Size is calculated at 100dpi (dot per inch). So for example, if you want the Ezsigntemplatesignature to have a width of 2 inches, you would use \&quot;200\&quot; for the iEzsigntemplatesignatureWidth. | [optional] 
**IEzsigntemplatesignatureHeight** | **int** | The height of the Ezsigntemplatesignature.  Size is calculated at 100dpi (dot per inch). So for example, if you want the Ezsigntemplatesignature to have an height of 2 inches, you would use \&quot;200\&quot; for the iEzsigntemplatesignatureHeight. | [optional] 
**IEzsigntemplatesignatureStep** | **int** | The step when the Ezsigntemplatesigner will be invited to sign | 
**EEzsigntemplatesignatureType** | **FieldEEzsigntemplatesignatureType** |  | 
**TEzsigntemplatesignatureTooltip** | **string** | A tooltip that will be presented to Ezsigntemplatesigner about the Ezsigntemplatesignature | [optional] 
**EEzsigntemplatesignatureTooltipposition** | **FieldEEzsigntemplatesignatureTooltipposition** |  | [optional] 
**EEzsigntemplatesignatureFont** | **FieldEEzsigntemplatesignatureFont** |  | [optional] 
**IEzsigntemplatesignatureValidationstep** | **int** | The step when the Ezsigntemplatesigner will be invited to validate the Ezsigntemplatesignature of eEzsigntemplatesignatureType Attachments | [optional] 
**SEzsigntemplatesignatureAttachmentdescription** | **string** | The description attached to the attachment name added in Ezsigntemplatesignature of eEzsigntemplatesignatureType Attachments | [optional] 
**EEzsigntemplatesignatureAttachmentnamesource** | **FieldEEzsigntemplatesignatureAttachmentnamesource** |  | [optional] 
**BEzsigntemplatesignatureRequired** | **bool** | Whether the Ezsigntemplatesignature is required or not. This field is relevant only with Ezsigntemplatesignature with eEzsigntemplatesignatureType &#x3D; Attachments. | [optional] 
**IEzsigntemplatesignatureMaxlength** | **int** | The maximum length for the value in the Ezsigntemplatesignature  This can only be set if eEzsigntemplatesignatureType is **FieldText** or **FieldTextarea** | [optional] 
**SEzsigntemplatesignatureRegexp** | **string** | A regular expression to indicate what values are acceptable for the Ezsigntemplatesignature.  This can only be set if eEzsigntemplatesignatureType is **Text** or **Textarea** | [optional] 
**EEzsigntemplatesignatureTextvalidation** | **EnumTextvalidation** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# eZmaxApi.Model.EzsignannotationRequestCompound
A Ezsignannotation Object and children

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignannotationID** | **int** | The unique ID of the Ezsignannotation | [optional] 
**FkiEzsigndocumentID** | **int** | The unique ID of the Ezsigndocument | 
**EEzsignannotationHorizontalalignment** | **EnumHorizontalalignment** |  | [optional] 
**EEzsignannotationVerticalalignment** | **EnumVerticalalignment** |  | [optional] 
**EEzsignannotationType** | **FieldEEzsignannotationType** |  | 
**IEzsignannotationX** | **int** | The X coordinate (Horizontal) where to put the Ezsignannotation on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignannotation 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate. | 
**IEzsignannotationY** | **int** | The Y coordinate (Vertical) where to put the Ezsignannotation on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignannotation 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate. | 
**IEzsignannotationWidth** | **int** | The Width of the Ezsignannotation.  Width is calculated at 100dpi (dot per inch). So for example, if you want to have the width of the Ezsignannotation to be 3 inches, you would use \&quot;300\&quot; for the Width. | [optional] 
**IEzsignannotationHeight** | **int** | The Height of the Ezsignannotation.  Height is calculated at 100dpi (dot per inch). So for example, if you want to have the height of the Ezsignannotation to be 2 inches, you would use \&quot;200\&quot; for the Height.  This can only be set if eEzsignannotationType is **StrikethroughBlock** or **Text** | [optional] 
**SEzsignannotationText** | **string** | The Text of the Ezsignannotation | [optional] 
**IEzsignpagePagenumber** | **int** | The page number in the Ezsigndocument | 
**ObjTextstylestatic** | [**TextstylestaticRequestCompound**](TextstylestaticRequestCompound.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


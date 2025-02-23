# eZmaxApi.Model.EzsignformfieldResponse
An Ezsignformfield Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignformfieldID** | **int** | The unique ID of the Ezsignformfield | 
**IEzsignpagePagenumber** | **int** | The page number in the Ezsigndocument | 
**SEzsignformfieldLabel** | **string** | The Label for the Ezsignformfield | 
**SEzsignformfieldValue** | **string** | The value for the Ezsignformfield  This can only be set if eEzsignformfieldgroupType is Checkbox or Radio | [optional] 
**IEzsignformfieldX** | **int** | The X coordinate (Horizontal) where to put the Ezsignformfield on the Ezsignpage.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignformfield 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate. | 
**IEzsignformfieldY** | **int** | The Y coordinate (Vertical) where to put the Ezsignformfield on the Ezsignpage.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignformfield 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate. | 
**IEzsignformfieldWidth** | **int** | The Width of the Ezsignformfield in pixels calculated at 100 DPI | 
**IEzsignformfieldHeight** | **int** | The Height of the Ezsignformfield in pixels calculated at 100 DPI  | 
**BEzsignformfieldAutocomplete** | **bool** | Whether the Ezsignformfield allows the use of the autocomplete of the browser.  This can only be set if eEzsignformfieldgroupType is **Text** | [optional] 
**BEzsignformfieldSelected** | **bool** | Whether the Ezsignformfield is selected or not by default.  This can only be set if eEzsignformfieldgroupType is **Checkbox** or **Radio** | [optional] 
**SEzsignformfieldEnteredvalue** | **string** | This is the value enterred for the Ezsignformfield  This can only be set if eEzsignformfieldgroupType is **Dropdown**, **Text** or **Textarea** | [optional] 
**EEzsignformfieldDependencyrequirement** | **FieldEEzsignformfieldDependencyrequirement** |  | [optional] 
**EEzsignformfieldHorizontalalignment** | **EnumHorizontalalignment** |  | [optional] 
**ObjTextstylestatic** | [**TextstylestaticResponseCompound**](TextstylestaticResponseCompound.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


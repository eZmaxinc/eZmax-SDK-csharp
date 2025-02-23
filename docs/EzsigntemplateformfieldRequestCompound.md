# eZmaxApi.Model.EzsigntemplateformfieldRequestCompound
An Ezsigntemplateformfield Object and children to create a complete structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsigntemplateformfieldID** | **int** | The unique ID of the Ezsigntemplateformfield | [optional] 
**EEzsigntemplateformfieldPositioning** | **FieldEEzsigntemplateformfieldPositioning** |  | [optional] 
**IEzsigntemplatedocumentpagePagenumber** | **int** | The page number in the Ezsigntemplatedocument | 
**SEzsigntemplateformfieldLabel** | **string** | The Label for the Ezsigntemplateformfield | 
**SEzsigntemplateformfieldValue** | **string** | The value for the Ezsigntemplateformfield | [optional] 
**IEzsigntemplateformfieldX** | **int** | The X coordinate (Horizontal) where to put the Ezsigntemplateformfield on the Ezsigntemplatepage.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsigntemplateformfield 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate. | [optional] 
**IEzsigntemplateformfieldY** | **int** | The Y coordinate (Vertical) where to put the Ezsigntemplateformfield on the Ezsigntemplatepage.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsigntemplateformfield 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate. | [optional] 
**IEzsigntemplateformfieldWidth** | **int** | The Width of the Ezsigntemplateformfield in pixels calculated at 100 DPI | 
**IEzsigntemplateformfieldHeight** | **int** | The Height of the Ezsigntemplateformfield in pixels calculated at 100 DPI  | 
**BEzsigntemplateformfieldAutocomplete** | **bool** | Whether the Ezsigntemplateformfield allows the use of the autocomplete of the browser.  This can only be set if eEzsigntemplateformfieldgroupType is **Text** | [optional] 
**BEzsigntemplateformfieldSelected** | **bool** | Whether the Ezsigntemplateformfield is selected or not by default.  This can only be set if eEzsigntemplateformfieldgroupType is **Checkbox** or **Radio** | [optional] 
**EEzsigntemplateformfieldDependencyrequirement** | **FieldEEzsigntemplateformfieldDependencyrequirement** |  | [optional] 
**SEzsigntemplateformfieldPositioningpattern** | **string** | The string pattern to search for the positioning. **This is not a regexp**  This will be required if **eEzsigntemplateformfieldPositioning** is set to **PerCoordinates** | [optional] 
**IEzsigntemplateformfieldPositioningoffsetx** | **int** | The offset X  This will be required if **eEzsigntemplateformfieldPositioning** is set to **PerCoordinates** | [optional] 
**IEzsigntemplateformfieldPositioningoffsety** | **int** | The offset Y  This will be required if **eEzsigntemplateformfieldPositioning** is set to **PerCoordinates** | [optional] 
**EEzsigntemplateformfieldPositioningoccurence** | **FieldEEzsigntemplateformfieldPositioningoccurence** |  | [optional] 
**EEzsigntemplateformfieldHorizontalalignment** | **EnumHorizontalalignment** |  | [optional] 
**ObjTextstylestatic** | [**TextstylestaticRequestCompound**](TextstylestaticRequestCompound.md) |  | [optional] 
**AObjEzsigntemplateelementdependency** | [**List&lt;EzsigntemplateelementdependencyRequestCompound&gt;**](EzsigntemplateelementdependencyRequestCompound.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


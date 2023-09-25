# eZmaxApi.Model.CommonResponseObjDebugPayloadGetList
This is a debug object containing debugging information on the actual function

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IVersionMin** | **int** | The minimum version of the function that can be called | 
**IVersionMax** | **int** | The maximum version of the function that can be called | 
**ARequiredPermission** | **List&lt;int&gt;** | An array of permissions required to access this function.  If the value \&quot;0\&quot; is present in the array, anyone can call this function.  You must have one of the permission to access the function. You don&#39;t need to have all of them. | 
**BVersionDeprecated** | **bool** | Wheter the current route is deprecated or not | 
**AFilter** | [**CommonResponseFilter**](CommonResponseFilter.md) |  | 
**AOrderBy** | **Dictionary&lt;string, string&gt;** | List of available values for *eOrderBy* | 
**IRowMax** | **int** | The maximum numbers of results to be returned | [default to 10000]
**IRowOffset** | **int** | The starting element from where to start retrieving the results. For example if you started at iRowOffset&#x3D;0 and asked for iRowMax&#x3D;100, to get the next 100 results, you could specify iRowOffset&#x3D;100&amp;iRowMax&#x3D;100, | [default to 0]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# eZmaxApi.Api.ObjectUserApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserCreateObjectV1**](ObjectUserApi.md#usercreateobjectv1) | **POST** /1/object/user | Create a new User |
| [**UserCreateObjectV2**](ObjectUserApi.md#usercreateobjectv2) | **POST** /2/object/user | Create a new User |
| [**UserEditColleaguesV2**](ObjectUserApi.md#usereditcolleaguesv2) | **PUT** /2/object/user/{pkiUserID}/editColleagues | Edit multiple Colleagues |
| [**UserEditObjectV1**](ObjectUserApi.md#usereditobjectv1) | **PUT** /1/object/user/{pkiUserID} | Edit an existing User |
| [**UserEditPermissionsV1**](ObjectUserApi.md#usereditpermissionsv1) | **PUT** /1/object/user/{pkiUserID}/editPermissions | Edit multiple Permissions |
| [**UserGetApikeysV1**](ObjectUserApi.md#usergetapikeysv1) | **GET** /1/object/user/{pkiUserID}/getApikeys | Retrieve an existing User&#39;s Apikeys |
| [**UserGetAutocompleteV2**](ObjectUserApi.md#usergetautocompletev2) | **GET** /2/object/user/getAutocomplete/{sSelector} | Retrieve Users and IDs |
| [**UserGetColleaguesV2**](ObjectUserApi.md#usergetcolleaguesv2) | **GET** /2/object/user/{pkiUserID}/getColleagues | Retrieve an existing User&#39;s Colleagues |
| [**UserGetEffectivePermissionsV1**](ObjectUserApi.md#usergeteffectivepermissionsv1) | **GET** /1/object/user/{pkiUserID}/getEffectivePermissions | Retrieve an existing User&#39;s Effective Permissions |
| [**UserGetListV1**](ObjectUserApi.md#usergetlistv1) | **GET** /1/object/user/getList | Retrieve User list |
| [**UserGetObjectV2**](ObjectUserApi.md#usergetobjectv2) | **GET** /2/object/user/{pkiUserID} | Retrieve an existing User |
| [**UserGetPermissionsV1**](ObjectUserApi.md#usergetpermissionsv1) | **GET** /1/object/user/{pkiUserID}/getPermissions | Retrieve an existing User&#39;s Permissions |
| [**UserGetSubnetsV1**](ObjectUserApi.md#usergetsubnetsv1) | **GET** /1/object/user/{pkiUserID}/getSubnets | Retrieve an existing User&#39;s Subnets |
| [**UserGetUsergroupexternalsV1**](ObjectUserApi.md#usergetusergroupexternalsv1) | **GET** /1/object/user/{pkiUserID}/getUsergroupexternals | Get User&#39;s Usergroupexternals |
| [**UserGetUsergroupsV1**](ObjectUserApi.md#usergetusergroupsv1) | **GET** /1/object/user/{pkiUserID}/getUsergroups | Get User&#39;s Usergroups |
| [**UserSendPasswordResetV1**](ObjectUserApi.md#usersendpasswordresetv1) | **POST** /1/object/user/{pkiUserID}/sendPasswordReset | Send password reset |

<a id="usercreateobjectv1"></a>
# **UserCreateObjectV1**
> UserCreateObjectV1Response UserCreateObjectV1 (UserCreateObjectV1Request userCreateObjectV1Request)

Create a new User

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userCreateObjectV1Request** | [**UserCreateObjectV1Request**](UserCreateObjectV1Request.md) |  |  |

### Return type

[**UserCreateObjectV1Response**](UserCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usercreateobjectv2"></a>
# **UserCreateObjectV2**
> UserCreateObjectV2Response UserCreateObjectV2 (UserCreateObjectV2Request userCreateObjectV2Request)

Create a new User

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userCreateObjectV2Request** | [**UserCreateObjectV2Request**](UserCreateObjectV2Request.md) |  |  |

### Return type

[**UserCreateObjectV2Response**](UserCreateObjectV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usereditcolleaguesv2"></a>
# **UserEditColleaguesV2**
> UserEditColleaguesV2Response UserEditColleaguesV2 (int pkiUserID, UserEditColleaguesV2Request userEditColleaguesV2Request)

Edit multiple Colleagues

Using this endpoint, you can edit multiple Colleagues at the same time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserID** | **int** |  |  |
| **userEditColleaguesV2Request** | [**UserEditColleaguesV2Request**](UserEditColleaguesV2Request.md) |  |  |

### Return type

[**UserEditColleaguesV2Response**](UserEditColleaguesV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usereditobjectv1"></a>
# **UserEditObjectV1**
> UserEditObjectV1Response UserEditObjectV1 (int pkiUserID, UserEditObjectV1Request userEditObjectV1Request)

Edit an existing User


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserID** | **int** | The unique ID of the User |  |
| **userEditObjectV1Request** | [**UserEditObjectV1Request**](UserEditObjectV1Request.md) |  |  |

### Return type

[**UserEditObjectV1Response**](UserEditObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usereditpermissionsv1"></a>
# **UserEditPermissionsV1**
> UserEditPermissionsV1Response UserEditPermissionsV1 (int pkiUserID, UserEditPermissionsV1Request userEditPermissionsV1Request)

Edit multiple Permissions

Using this endpoint, you can edit multiple Permissions at the same time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserID** | **int** |  |  |
| **userEditPermissionsV1Request** | [**UserEditPermissionsV1Request**](UserEditPermissionsV1Request.md) |  |  |

### Return type

[**UserEditPermissionsV1Response**](UserEditPermissionsV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergetapikeysv1"></a>
# **UserGetApikeysV1**
> UserGetApikeysV1Response UserGetApikeysV1 (int pkiUserID)

Retrieve an existing User's Apikeys


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserID** | **int** |  |  |

### Return type

[**UserGetApikeysV1Response**](UserGetApikeysV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergetautocompletev2"></a>
# **UserGetAutocompleteV2**
> UserGetAutocompleteV2Response UserGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Users and IDs

Get the list of User to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Users to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**UserGetAutocompleteV2Response**](UserGetAutocompleteV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergetcolleaguesv2"></a>
# **UserGetColleaguesV2**
> UserGetColleaguesV2Response UserGetColleaguesV2 (int pkiUserID)

Retrieve an existing User's Colleagues


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserID** | **int** |  |  |

### Return type

[**UserGetColleaguesV2Response**](UserGetColleaguesV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergeteffectivepermissionsv1"></a>
# **UserGetEffectivePermissionsV1**
> UserGetEffectivePermissionsV1Response UserGetEffectivePermissionsV1 (int pkiUserID)

Retrieve an existing User's Effective Permissions

Effective Permissions refers to the combination of Permissions held by a User and the Permissions associated with the Usergroups they belong to.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserID** | **int** |  |  |

### Return type

[**UserGetEffectivePermissionsV1Response**](UserGetEffectivePermissionsV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergetlistv1"></a>
# **UserGetListV1**
> UserGetListV1Response UserGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve User list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eUserType | AgentBroker<br>Assistant<br>Employee<br>EzsignUser<br>Normal | | eUserOrigin | BuiltIn<br>External | | eUserEzsignaccess | No<br>PaidByOffice<br>PerDocument<br>Prepaid |


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**UserGetListV1Response**](UserGetListV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergetobjectv2"></a>
# **UserGetObjectV2**
> UserGetObjectV2Response UserGetObjectV2 (int pkiUserID)

Retrieve an existing User


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserID** | **int** | The unique ID of the User |  |

### Return type

[**UserGetObjectV2Response**](UserGetObjectV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergetpermissionsv1"></a>
# **UserGetPermissionsV1**
> UserGetPermissionsV1Response UserGetPermissionsV1 (int pkiUserID)

Retrieve an existing User's Permissions


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserID** | **int** |  |  |

### Return type

[**UserGetPermissionsV1Response**](UserGetPermissionsV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergetsubnetsv1"></a>
# **UserGetSubnetsV1**
> UserGetSubnetsV1Response UserGetSubnetsV1 (int pkiUserID)

Retrieve an existing User's Subnets


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserID** | **int** |  |  |

### Return type

[**UserGetSubnetsV1Response**](UserGetSubnetsV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergetusergroupexternalsv1"></a>
# **UserGetUsergroupexternalsV1**
> UserGetUsergroupexternalsV1Response UserGetUsergroupexternalsV1 (int pkiUserID)

Get User's Usergroupexternals


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserID** | **int** |  |  |

### Return type

[**UserGetUsergroupexternalsV1Response**](UserGetUsergroupexternalsV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usergetusergroupsv1"></a>
# **UserGetUsergroupsV1**
> UserGetUsergroupsV1Response UserGetUsergroupsV1 (int pkiUserID)

Get User's Usergroups


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserID** | **int** |  |  |

### Return type

[**UserGetUsergroupsV1Response**](UserGetUsergroupsV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersendpasswordresetv1"></a>
# **UserSendPasswordResetV1**
> UserSendPasswordResetV1Response UserSendPasswordResetV1 (int pkiUserID, Object body)

Send password reset

Send the password reset email


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiUserID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**UserSendPasswordResetV1Response**](UserSendPasswordResetV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


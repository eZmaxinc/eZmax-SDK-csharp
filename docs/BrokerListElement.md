# eZmaxApi.Model.BrokerListElement
A Broker List Element

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiBrokerID** | **int** | The unique ID of the Broker. | 
**FkiDepartmentID** | **int** | The unique ID of the Department | 
**SDepartmentNameX** | **string** | The Name of the Department in the language of the requester | [optional] 
**FkiBrokertypeID** | **int** | The unique ID of the Brokertype | 
**SBrokertypeNameX** | **string** | The name of the Brokertype in the language of the requester | 
**SBrokerCode** | **string** | The code of the Broker | 
**SRealestateboardnumberNumber** | **string** | The number of the Realestateboardnumber | [optional] 
**IAgentBannernumber** | **long** | The bannernumber of the Agent | [optional] 
**SLanguageNameX** | **string** | The Name of the Language in the language of the requester | [optional] 
**IBrokerPhotocopiercode** | **int** | The photocopiercode of the Broker | 
**IBrokerLongdistancecode** | **int** | The longdistancecode of the Broker | 
**SBrokerName** | **string** | The name of the Broker | 
**SBrokerRealestateassociationlicense** | **string** | The realestateassociationlicense of the Broker | 
**DtBrokerHiredate** | **string** | The hiredate of the Broker | 
**DtBrokerLeavedate** | **string** | The leavedate of the Broker | [optional] 
**BBrokerTranquillit** | **bool** | Whether if it&#39;s an tranquillit | [optional] 
**BBrokerResidentiallicense** | **bool** | Whether if it&#39;s an residentiallicense | 
**BBrokerCommerciallicense** | **bool** | Whether if it&#39;s an commerciallicense | 
**BBrokerMortgagelicense** | **bool** | Whether if it&#39;s an mortgagelicense | 
**BBrokerPaidbyofficetranquillit** | **bool** | Whether if it&#39;s an paidbyofficetranquillit | 
**DtBrokerFintraccertification** | **string** | The fintraccertification of the Broker | [optional] 
**BBrokerIsactive** | **bool** | Whether the Broker is active or not | 
**SContactFirstname** | **string** | The First name of the contact | [optional] 
**SContactLastname** | **string** | The Last name of the contact | [optional] 
**DtContactBirthdate** | **string** | The Birth Date of the contact | [optional] 
**SEmailAddress** | **string** | The email address. | [optional] 
**SPhoneE164** | **string** | A phone number in E.164 Format | [optional] 
**SAddressCivic** | **string** | The Civic number. | [optional] 
**SAddressStreet** | **string** | The Street Name | [optional] 
**SAddressSuite** | **string** | The Suite or appartment number | [optional] 
**SAddressCity** | **string** | The City name | [optional] 
**SAddressZip** | **string** | The Postal/Zip Code  The value must be entered without spaces | [optional] 
**FkiProvinceID** | **int** | The unique ID of the Province.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|(Canada) Alberta |2|(Canada) British Columbia| |3|(Canada) Manitoba| |3|(Canada) Manitoba| |4|(Canada) New Brunswick| |5|(Canada) Newfoundland| |6|(Canada) Northwest Territories| |7|(Canada) Nova Scotia| |8|(Canada) Nunavut| |9|(Canada) Ontario| |10|(Canada) Prince Edward Island| |11|(Canada) Quebec| |12|(Canada) Saskatchewan| |13|(Canada) Yukon| |14|(United-States) Alabama| |15|(United-States) Alaska| |16|(United-States) Arizona| |17|(United-States) Arkansas| |18|(United-States) California| |19|(United-States) Colorado| |20|(United-States) Connecticut| |21|(United-States) Delaware| |22|(United-States) District of Columbia| |23|(United-States) Florida| |24|(United-States) Georgia| |25|(United-States) Hawaii| |26|(United-States) Idaho| |27|(United-States) Illinois| |28|(United-States) Indiana| |29|(United-States) Iowa| |30|(United-States) Kansas| |31|(United-States) Kentucky| |32|(United-States) Louisiane| |33|(United-States) Maine| |34|(United-States) Maryland| |35|(United-States) Massachusetts| |36|(United-States) Michigan| |37|(United-States) Minnesota| |38|(United-States) Mississippi| |39|(United-States) Missouri| |40|(United-States) Montana| |41|(United-States) Nebraska| |42|(United-States) Nevada| |43|(United-States) New Hampshire| |44|(United-States) New Jersey| |45|(United-States) New Mexico| |46|(United-States) New York| |47|(United-States) North Carolina| |48|(United-States) North Dakota| |49|(United-States) Ohio| |50|(United-States) Oklahoma| |51|(United-States) Oregon| |52|(United-States) Pennsylvania| |53|(United-States) Rhode Island| |54|(United-States) South Carolina| |55|(United-States) South Dakota| |56|(United-States) Tennessee| |57|(United-States) Texas| |58|(United-States) Utah| |60|(United-States) Vermont| |59|(United-States) Virginia| |61|(United-States) Washington| |62|(United-States) West Virginia| |63|(United-States) Wisconsin| |64|(United-States) Wyoming| | [optional] 
**SProvinceNameX** | **string** | The name of the Province in the language of the requester | [optional] 
**FkiCountryID** | **int** | The unique ID of the Country.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|Canada| |2|United-States| | [optional] 
**SCountryNameX** | **string** | The name of the Country in the language of the requester | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# eZmaxApi.Model.InscriptionListElement
A Inscription List Element

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiInscriptionID** | **int** | The unique ID of the Inscription. | 
**PkiInscriptionnotauthenticatedID** | **int** | The unique ID of the Inscriptionnotauthenticated. | [optional] 
**FkiInscriptiontypeID** | **int** | The unique ID of the Inscriptiontype | 
**SInscriptiontypeNameX** | **string** | The name of the Inscriptiontype in the language of the requester | 
**FkiInscriptionbuildingtypeID** | **int** | The unique ID of the Inscriptionbuildingtype | 
**SInscriptionbuildingtypeNameX** | **string** | The name of the Inscriptionbuildingtype in the language of the requester | 
**FkiInscriptioncategoryID** | **int** | The unique ID of the Inscriptioncategory | 
**SInscriptioncategoryNameX** | **string** | The name of the Inscriptioncategory in the language of the requester | 
**FkiBuyercontractID** | **int** | The unique ID of the Buyercontract | [optional] 
**SBuyercontractContract** | **string** | The number of the Buyercontract | [optional] 
**EInscriptionStep** | **FieldEInscriptionStep** |  | 
**EInscriptionType** | **FieldEInscriptionType** |  | 
**SInscriptionCivicend** | **string** | The civicend of the Inscription | 
**SInscriptionMLS** | **string** | The mls of the Inscription | [optional] 
**SInscriptionContract** | **string** | The sale contract number | [optional] 
**DInscriptionSaleprice** | **string** | The saleprice of the Inscription | 
**DInscriptionRentprice** | **string** | The rentprice of the Inscription | 
**DtInscriptionDate** | **string** | The date of the Inscription | [optional] 
**DtInscriptionExpirationdate** | **string** | The expirationdate of the Inscription | [optional] 
**DtInscriptionNotarydate** | **string** | The notarydate of the Inscription | [optional] 
**BInscriptionIsactive** | **bool** | Whether the inscription is active or not | 
**BInscriptionArchived** | **bool** | Whether the inscription is archived or not | 
**BInscriptionInspection** | **bool** | Whether the inscription can be acces by an inspector | [optional] 
**DtInscriptionnotauthenticatedNotaryscheduledate** | **string** | The notaryscheduledate of the Inscriptionnotauthenticated | [optional] 
**DtInscriptionnotauthenticatedTransactiondate** | **string** | The transactiondate of the Inscriptionnotauthenticated | [optional] 
**DtInscriptionnotauthenticatedTransactiondateReal** | **string** | The transactiondatereal of the Inscriptionnotauthenticated | [optional] 
**BInscriptionnotauthenticatedConditional** | **bool** | Whether the inscriptionnotauthenticated is conditional | [optional] 
**BInscriptionnotauthenticatedIsactive** | **bool** | Whether the inscriptionnotauthenticated is active or not | [optional] 
**SAddressCivic** | **string** | The Civic number. | [optional] 
**SAddressStreet** | **string** | The Street Name | [optional] 
**SAddressSuite** | **string** | The Suite or appartment number | [optional] 
**SAddressCity** | **string** | The City name | [optional] 
**SAddressZip** | **string** | The Postal/Zip Code  The value must be entered without spaces | [optional] 
**FkiProvinceID** | **int** | The unique ID of the Province.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|(Canada) Alberta |2|(Canada) British Columbia| |3|(Canada) Manitoba| |3|(Canada) Manitoba| |4|(Canada) New Brunswick| |5|(Canada) Newfoundland| |6|(Canada) Northwest Territories| |7|(Canada) Nova Scotia| |8|(Canada) Nunavut| |9|(Canada) Ontario| |10|(Canada) Prince Edward Island| |11|(Canada) Quebec| |12|(Canada) Saskatchewan| |13|(Canada) Yukon| |14|(United-States) Alabama| |15|(United-States) Alaska| |16|(United-States) Arizona| |17|(United-States) Arkansas| |18|(United-States) California| |19|(United-States) Colorado| |20|(United-States) Connecticut| |21|(United-States) Delaware| |22|(United-States) District of Columbia| |23|(United-States) Florida| |24|(United-States) Georgia| |25|(United-States) Hawaii| |26|(United-States) Idaho| |27|(United-States) Illinois| |28|(United-States) Indiana| |29|(United-States) Iowa| |30|(United-States) Kansas| |31|(United-States) Kentucky| |32|(United-States) Louisiane| |33|(United-States) Maine| |34|(United-States) Maryland| |35|(United-States) Massachusetts| |36|(United-States) Michigan| |37|(United-States) Minnesota| |38|(United-States) Mississippi| |39|(United-States) Missouri| |40|(United-States) Montana| |41|(United-States) Nebraska| |42|(United-States) Nevada| |43|(United-States) New Hampshire| |44|(United-States) New Jersey| |45|(United-States) New Mexico| |46|(United-States) New York| |47|(United-States) North Carolina| |48|(United-States) North Dakota| |49|(United-States) Ohio| |50|(United-States) Oklahoma| |51|(United-States) Oregon| |52|(United-States) Pennsylvania| |53|(United-States) Rhode Island| |54|(United-States) South Carolina| |55|(United-States) South Dakota| |56|(United-States) Tennessee| |57|(United-States) Texas| |58|(United-States) Utah| |60|(United-States) Vermont| |59|(United-States) Virginia| |61|(United-States) Washington| |62|(United-States) West Virginia| |63|(United-States) Wisconsin| |64|(United-States) Wyoming| | [optional] 
**SProvinceNameX** | **string** | The name of the Province in the language of the requester | [optional] 
**FkiCountryID** | **int** | The unique ID of the Country.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|Canada| |2|United-States| | [optional] 
**SCountryNameX** | **string** | The name of the Country in the language of the requester | [optional] 
**IInscriptionnotauthenticatedCanceled** | **int** | The numbre of inscriptionnotauthenticated was canceled in this Inscription | 
**IInscriptionUnit** | **int** | The unit of the Inscription | 
**BAllowedCopyintoinscriptionedm** | **bool** | Whether we are allowed to copy into the Inscription EDM | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# eZmaxApi.Model.InscriptionResponseCompound
A Inscription Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiInscriptionID** | **int** | The unique ID of the Inscription. | 
**FkiDepartmentID** | **int** | The unique ID of the Department | [optional] 
**SDepartmentNameX** | **string** | The Name of the Department in the language of the requester | [optional] 
**FkiRealestateboardID** | **int** | The unique ID of the Realestateboard | 
**SRealestateboardNameX** | **string** | The name of the Realestateboard | [optional] 
**FkiAddressID** | **int** | The unique ID of the Address | 
**ObjAddress** | [**AddressResponseCompound**](AddressResponseCompound.md) |  | [optional] 
**FkiInscriptionbuildingtypeID** | **int** | The unique ID of the Inscriptionbuildingtype | 
**SInscriptionbuildingtypeNameX** | **string** | The name of the Inscriptionbuildingtype in the language of the requester | [optional] 
**FkiInscriptiontypeID** | **int** | The unique ID of the Inscriptiontype | 
**SInscriptiontypeNameX** | **string** | The name of the Inscriptiontype in the language of the requester | [optional] 
**FkiInscriptioncategoryID** | **int** | The unique ID of the Inscriptioncategory | 
**SInscriptioncategoryNameX** | **string** | The name of the Inscriptioncategory in the language of the requester | [optional] 
**EInscriptionStep** | **FieldEInscriptionStep** |  | 
**EInscriptionResidenceType** | **FieldEInscriptionResidenceType** |  | 
**SInscriptionCivicend** | **string** | The address civic end of the Inscription | 
**SInscriptionMLS** | **string** | The mls of the Inscription | [optional] 
**SInscriptionContract** | **string** | The sale contract number | 
**IInscriptionSellerdeclaration** | **int** | The seller declaration number of the Inscription | 
**EInscriptionType** | **FieldEInscriptionType** |  | 
**DInscriptionInitialsaleprice** | **string** | The initial sale price of the Inscription | 
**DInscriptionSaleprice** | **string** | The saleprice of the Inscription | 
**DInscriptionRentprice** | **string** | The rent price of the Inscription | 
**EInscriptionRemunerationtype** | **FieldEInscriptionRemunerationtype** |  | 
**EInscriptionRemunerationinscriptorsellertype** | **FieldEInscriptionRemunerationinscriptorsellertype** |  | 
**EInscriptionRemunerationreferencetype** | **FieldEInscriptionRemunerationreferencetype** |  | 
**EInscriptionRemunerationtotaltype** | **FieldEInscriptionRemunerationtotaltype** |  | 
**DInscriptionRemuneration** | **string** | The remuneration amount of the Inscription | 
**DInscriptionRemunerationinscriptorseller** | **string** | The remuneration amount for the inscriptor or seller of the Inscription | 
**DInscriptionRemunerationreference** | **string** | The remuneration amount for the reference of the Inscription | 
**DInscriptionRemunerationtotal** | **string** | The remuneration amount total of the Inscription | 
**DInscriptionMortgagesold** | **string** | The balande for the mortgage of the Inscription | 
**DtInscriptionDate** | **string** | The date of the Inscription | [optional] 
**DtInscriptionCancellationdate** | **string** | The cancellation date of the Inscription | [optional] 
**DtInscriptionInitialexpirationdate** | **string** | The initial expiration date of the Inscription | [optional] 
**DtInscriptionExpirationdate** | **string** | The expiration date of the Inscription | [optional] 
**DtInscriptionNotarydate** | **string** | The notary date of the Inscription | [optional] 
**DtInscriptionNotaryentereddate** | **string** | The notary entered date of the Inscription | [optional] 
**TInscriptionCadastre** | **string** | The cadastre of the Inscription | 
**BInscriptionReference** | **bool** | Whether if it&#39;s an reference | 
**BInscriptionInspection** | **bool** | Whether the inscription can be acces by an inspector | 
**BInscriptionIsactive** | **bool** | Whether the inscription is active or not | 
**TInscriptionChecklistnote** | **string** | The checklist note of the Inscription | 
**BInscriptionNew** | **bool** | Whether if it&#39;s an new | 
**BInscriptionHomeowner** | **bool** | Whether if it&#39;s an homeowner | 
**BInscriptionArchived** | **bool** | Whether the inscription is archived or not | 
**BInscriptionLitigation** | **bool** | Whether if it&#39;s an litigation | 
**BInscriptionRepossession** | **bool** | Whether if it&#39;s an repossession | 
**BInscriptionIssolicitation** | **bool** | Whether if it&#39;s a solicitation | 
**BInscriptionSalebyowner** | **bool** | Whether if it&#39;s a sale by the owner | 
**BInscriptionSoldwithoutlegalwarranty** | **bool** | Whether if it&#39;s sold without the legal warranty | 
**IInscriptionConstructionyear** | **int** | The construction year of the Inscription | 
**IInscriptionUnit** | **int** | The number of unit for the Inscription | 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


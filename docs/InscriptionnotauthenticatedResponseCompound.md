# eZmaxApi.Model.InscriptionnotauthenticatedResponseCompound
A Inscriptionnotauthenticated Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiInscriptionnotauthenticatedID** | **int** | The unique ID of the Inscriptionnotauthenticated. | 
**FkiCompanyID** | **int** | The unique ID of the Company | 
**SCompanyNameX** | **string** | The Name of the Company in the language of the requester | [optional] 
**FkiInscriptionID** | **int** | The unique ID of the Inscription. | 
**FkiDepartmentID** | **int** | The unique ID of the Department | 
**SDepartmentNameX** | **string** | The Name of the Department in the language of the requester | [optional] 
**FkiFinancialinstitutionID** | **int** | The unique ID of the Financialinstitution | 
**SFinancialinstitutionNameX** | **string** | The name of the Financialinstitution in the language of the requester | [optional] 
**FkiBuyercontractID** | **int** | The unique ID of the Buyercontract | 
**SBuyercontractContract** | **string** | The number of the Buyercontract | [optional] 
**FkiMortgagesupplierID** | **int** | The unique ID of the Mortgagesupplier | 
**SMortgagesupplierNameX** | **string** | The name of the Mortagesupplier in the language of the requester | [optional] 
**FkiTaxassignmentID** | **int** | The unique ID of the Taxassignment.  Valid values:  |Value|Description| |-|-| |1|No tax| |2|GST| |3|HST (ON)| |4|HST (NB)| |5|HST (NS)| |6|HST (NL)| |7|HST (PE)| |8|GST + QST (QC)| |9|GST + QST (QC) Non-Recoverable| |10|GST + PST (BC)| |11|GST + PST (SK)| |12|GST + RST (MB)| |13|GST + PST (BC) Non-Recoverable| |14|GST + PST (SK) Non-Recoverable| |15|GST + RST (MB) Non-Recoverable| | 
**STaxassignmentDescriptionX** | **string** | The description of the Taxassignment  in the language of the requester | [optional] 
**DtInscriptionnotauthenticatedTransactiondate** | **string** | The transactiondate of the Inscriptionnotauthenticated | 
**DtInscriptionnotauthenticatedTransactiondateReal** | **string** | The transactiondatereal of the Inscriptionnotauthenticated | 
**DtInscriptionnotauthenticatedDepositdate** | **string** | The depositdate of the Inscriptionnotauthenticated | 
**EInscriptionnotauthenticatedType** | **FieldEInscriptionnotauthenticatedType** |  | 
**DInscriptionnotauthenticatedMortgageloan** | **string** | The mortgageloan of the Inscriptionnotauthenticated | 
**EtInscriptionnotauthenticatedMortgagetype** | **FieldEtInscriptionnotauthenticatedMortgagetype** |  | 
**DInscriptionnotauthenticatedTransactionprice** | **string** | The transactionprice of the Inscriptionnotauthenticated | 
**EInscriptionnotauthenticatedRemunerationtype** | **FieldEInscriptionnotauthenticatedRemunerationtype** |  | 
**DInscriptionnotauthenticatedRemuneration** | **string** | The remuneration of the Inscriptionnotauthenticated | 
**DInscriptionnotauthenticatedRemunerationsubtotal** | **string** | The remunerationsubtotal of the Inscriptionnotauthenticated | 
**DInscriptionnotauthenticatedRemunerationtotal** | **string** | The remunerationtotal of the Inscriptionnotauthenticated | 
**DtInscriptionnotauthenticatedCancellationdate** | **string** | The cancellationdate of the Inscriptionnotauthenticated | 
**DtInscriptionnotauthenticatedPossessiondate** | **string** | The possessiondate of the Inscriptionnotauthenticated | 
**SInscriptionnotauthenticatedOffertopurchasenumber** | **string** | The Offer to purchase number | 
**DtInscriptionnotauthenticatedNotaryscheduledate** | **string** | The notaryscheduledate of the Inscriptionnotauthenticated | 
**DtInscriptionnotauthenticatedFinancingscheduledate** | **string** | The financingscheduledate of the Inscriptionnotauthenticated | 
**BInscriptionnotauthenticatedConditional** | **bool** | Whether the inscriptionnotauthenticated is conditional | 
**BInscriptionnotauthenticatedMortgageisreferenced** | **bool** | Whether if it&#39;s an mortgageisreferenced | 
**BInscriptionnotauthenticatedHomeowner** | **bool** | Whether if it&#39;s an homeowner | 
**TInscriptionnotauthenticatedConditions** | **string** | The conditions of the Inscriptionnotauthenticated | 
**DtInscriptionnotauthenticatedConditiondeadlinedate** | **string** | The conditiondeadlinedate of the Inscriptionnotauthenticated | 
**IInscriptionnotauthenticatedOrder** | **int** | The order of the Inscriptionnotauthenticated | 
**BInscriptionnotauthenticatedIsactive** | **bool** | Whether the inscriptionnotauthenticated is active or not | 
**EInscriptionnotauthenticatedResidenceType** | **FieldEInscriptionnotauthenticatedResidenceType** |  | 
**TInscriptionnotauthenticatedChecklistnote** | **string** | The checklistnote of the Inscriptionnotauthenticated | 
**DInscriptionnotauthenticatedSelleronlyretribution** | **string** | The selleronlyretribution of the Inscriptionnotauthenticated | 
**BInscriptionnotauthenticatedDraft** | **bool** | Whether the inscriptionnotauthenticated is a draft or not | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


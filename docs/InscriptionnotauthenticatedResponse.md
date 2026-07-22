# eZmaxApi.Model.InscriptionnotauthenticatedResponse
A Inscriptionnotauthenticated Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiInscriptionnotauthenticatedID** | **int** | The unique ID of the Inscriptionnotauthenticated. | 
**FkiInscriptionID** | **int** | The unique ID of the Inscription. | 
**FkiDepartmentID** | **int** | The unique ID of the Department | [optional] 
**SDepartmentNameX** | **string** | The Name of the Department in the language of the requester | [optional] 
**FkiFinancialinstitutionID** | **int** | The unique ID of the Financialinstitution | [optional] 
**SFinancialinstitutionNameX** | **string** | The name of the Financialinstitution in the language of the requester | [optional] 
**FkiBuyercontractID** | **int** | The unique ID of the Buyercontract | [optional] 
**SBuyercontractContract** | **string** | The number of the Buyercontract | [optional] 
**FkiMortgagesupplierID** | **int** | The unique ID of the Mortgagesupplier | [optional] 
**SMortgagesupplierNameX** | **string** | The name of the Mortagesupplier in the language of the requester | [optional] 
**FkiTaxassignmentID** | **int** | The unique ID of the Taxassignment.  Valid values:  |Value|Description| |-|-| |1|No tax| |2|GST| |3|HST (ON)| |4|HST (NB)| |5|HST (NS)| |6|HST (NL)| |7|HST (PE)| |8|GST + QST (QC)| |9|GST + QST (QC) Non-Recoverable| |10|GST + PST (BC)| |11|GST + PST (SK)| |12|GST + RST (MB)| |13|GST + PST (BC) Non-Recoverable| |14|GST + PST (SK) Non-Recoverable| |15|GST + RST (MB) Non-Recoverable| | 
**STaxassignmentDescriptionX** | **string** | The description of the Taxassignment  in the language of the requester | [optional] 
**DtInscriptionnotauthenticatedTransactiondate** | **string** | The transaction date of the Inscriptionnotauthenticated | [optional] 
**DtInscriptionnotauthenticatedTransactiondateReal** | **string** | The real transactiondate of the Inscriptionnotauthenticated | [optional] 
**DtInscriptionnotauthenticatedDepositdate** | **string** | The deposit date of the Inscriptionnotauthenticated | [optional] 
**EInscriptionnotauthenticatedType** | **FieldEInscriptionnotauthenticatedType** |  | 
**DInscriptionnotauthenticatedMortgageloan** | **string** | The amount of the mortgage loan of the Inscriptionnotauthenticated | 
**EtInscriptionnotauthenticatedMortgagetype** | **FieldEtInscriptionnotauthenticatedMortgagetype** |  | 
**DInscriptionnotauthenticatedTransactionprice** | **string** | The transaction price of the Inscriptionnotauthenticated | 
**EInscriptionnotauthenticatedRemunerationtype** | **FieldEInscriptionnotauthenticatedRemunerationtype** |  | 
**DInscriptionnotauthenticatedRemuneration** | **string** | The amount for the remuneration of the Inscriptionnotauthenticated | 
**DInscriptionnotauthenticatedRemunerationsubtotal** | **string** | The subtotal for the remuneration of the Inscriptionnotauthenticated | 
**DInscriptionnotauthenticatedRemunerationtotal** | **string** | The total for the remuneration of the Inscriptionnotauthenticated | 
**DtInscriptionnotauthenticatedCancellationdate** | **string** | The cancellation date of the Inscriptionnotauthenticated | [optional] 
**DtInscriptionnotauthenticatedPossessiondate** | **string** | The possession date of the Inscriptionnotauthenticated | [optional] 
**SInscriptionnotauthenticatedOffertopurchasenumber** | **string** | The offer to purchase number of the Inscriptionnotauthenticated | 
**DtInscriptionnotauthenticatedNotaryscheduledate** | **string** | The notary schedule date of the Inscriptionnotauthenticated | [optional] 
**DtInscriptionnotauthenticatedFinancingscheduledate** | **string** | The financing schedule date of the Inscriptionnotauthenticated | [optional] 
**BInscriptionnotauthenticatedConditional** | **bool** | Whether the inscriptionnotauthenticated is conditional | 
**BInscriptionnotauthenticatedMortgageisreferenced** | **bool** | Whether if the mortgage is referenced | 
**BInscriptionnotauthenticatedHomeowner** | **bool** | Whether if it&#39;s an home owner | 
**TInscriptionnotauthenticatedConditions** | **string** | The conditions of the Inscriptionnotauthenticated | 
**DtInscriptionnotauthenticatedConditiondeadlinedate** | **string** | The condition deadline date of the Inscriptionnotauthenticated | [optional] 
**IInscriptionnotauthenticatedOrder** | **int** | The order of the Inscriptionnotauthenticated | 
**BInscriptionnotauthenticatedIsactive** | **bool** | Whether the inscriptionnotauthenticated is active or not | 
**EInscriptionnotauthenticatedResidenceType** | **FieldEInscriptionnotauthenticatedResidenceType** |  | 
**TInscriptionnotauthenticatedChecklistnote** | **string** | The checklist note of the Inscriptionnotauthenticated | 
**DInscriptionnotauthenticatedSelleronlyretribution** | **string** | The amount retribution for the seller only of the Inscriptionnotauthenticated | 
**BInscriptionnotauthenticatedDraft** | **bool** | Whether the Inscriptionnotauthenticated is a draft or not | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# eZmaxApi.Model.CreditcardmerchantResponseCompound
A Creditcardmerchant Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiCreditcardmerchantID** | **int** | The unique ID of the Creditcardmerchant | 
**FkiBankaccountID** | **int** | The unique ID of the Bankaccount | 
**SBankaccountBankname** | **string** | The name of the bank | [optional] 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | [optional] 
**SLanguageNameX** | **string** | The Name of the Language in the language of the requester | [optional] 
**BCreditcardmerchantDenyvisa** | **bool** | Whether if visa are denied | 
**BCreditcardmerchantDenymastercard** | **bool** | Whether if mastercard are denied | 
**BCreditcardmerchantDenyamex** | **bool** | Whether if amex are denied | 
**BCreditcardmerchantIsactive** | **bool** | Whether the creditcardmerchant is active or not | 
**SCreditcardmerchantDescription** | **string** | The description of the Creditcardmerchant | 
**SCreditcardmerchantStoreid** | **string** | The storeid of the Creditcardmerchant | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


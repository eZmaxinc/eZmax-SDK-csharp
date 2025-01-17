# eZmaxApi.Model.CustomerResponseCompound
A Customer Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiCustomerID** | **int** | The unique ID of the Customer. | 
**FkiCompanyID** | **int** | The unique ID of the Company | 
**FkiCustomergroupID** | **int** | The unique ID of the Customergroup | 
**SCustomerName** | **string** | The name of the Customer | 
**FkiContactinformationsID** | **int** | The unique ID of the Contactinformations | 
**FkiContactcontainerID** | **int** | The unique ID of the Contactcontainer | 
**FkiImageID** | **int** | The unique ID of the Image | 
**FkiGlaccountcontainerID** | **int** | The unique ID of the Glaccountcontainer | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**FkiDepartmentID** | **int** | The unique ID of the Department | 
**FkiPaymentmethodID** | **int** | The unique ID of the Paymentmethod | 
**FkiElectronicfundstransferbankaccountID** | **int** | The unique ID of the Electronicfundstransferbankaccount | 
**FkiElectronicfundstransferbankaccountIDDirectdebit** | **int** | The unique ID of the Electronicfundstransferbankaccount | 
**FkiSendingmethodID** | **int** | The unique ID of the Sendingmethod | 
**FkiTaxassignmentID** | **int** | The unique ID of the Taxassignment.  Valid values:  |Value|Description| |-|-| |1|No tax| |2|GST| |3|HST (ON)| |4|HST (NB)| |5|HST (NS)| |6|HST (NL)| |7|HST (PE)| |8|GST + QST (QC)| |9|GST + QST (QC) Non-Recoverable| |10|GST + PST (BC)| |11|GST + PST (SK)| |12|GST + RST (MB)| |13|GST + PST (BC) Non-Recoverable| |14|GST + PST (SK) Non-Recoverable| |15|GST + RST (MB) Non-Recoverable| | 
**FkiAttendancestatusID** | **int** | The unique ID of the Attendancestatus | 
**FkiAgentIDVariableexpensechargeto** | **int** | The unique ID of the Agent. | 
**FkiBrokerIDVariableexpensechargeto** | **int** | The unique ID of the Broker. | 
**FkiCustomerIDVariableexpensechargeto** | **int** | The unique ID of the Customer. | 
**FkiGlaccountcontainerIDVariableexpensechargeto** | **int** | The unique ID of the Glaccountcontainer | 
**FkiAgentIDSupplychargechargeto** | **int** | The unique ID of the Agent. | 
**FkiBrokerIDSupplychargechargeto** | **int** | The unique ID of the Broker. | 
**FkiCustomerIDSupplychargechargeto** | **int** | The unique ID of the Customer. | 
**FkiGlaccountcontainerIDSupplychargechargeto** | **int** | The unique ID of the Glaccountcontainer | 
**FkiInvoicealternatelogoID** | **int** | The unique ID of the Invoicealternatelogo | 
**FkiSynchronizationlinkserverID** | **int** | The unique ID of the Synchronizationlinkserver | 
**EfkiUserID** | **int** | The unique ID of the User | [optional] 
**EfksCustomerCode** | **string** | The code of the Customer | [optional] 
**SCustomerCode** | **string** | The code of the Customer | 
**DCustomerFulltimeequivalent** | **string** | The fulltimeequivalent of the Customer | 
**ICustomerPhotocopiercode** | **int** | The photocopiercode of the Customer | 
**ICustomerLongdistancecode** | **int** | The longdistancecode of the Customer | 
**ICustomerTimewindowstart** | **int** | The timewindowstart of the Customer | 
**ICustomerTimewindowend** | **int** | The timewindowend of the Customer | 
**DCustomerMinimumchargeableinterests** | **string** | The minimumchargeableinterests of the Customer | 
**DtCustomerBirthdate** | **string** | The birthdate of the Customer | 
**DtCustomerTransfer** | **string** | The transfer of the Customer | 
**DtCustomerTransferappointment** | **string** | The transferappointment of the Customer | 
**DtCustomerTransfersurvey** | **string** | The transfersurvey of the Customer | 
**BCustomerIsactive** | **bool** | Whether the customer is active or not | 
**BCustomerVariableexpensefinanced** | **bool** | Whether if it&#39;s an variableexpensefinanced | 
**BCustomerVariableexpensefinancedtaxes** | **bool** | Whether if it&#39;s an variableexpensefinancedtaxes | 
**BCustomerSupplychargefinanced** | **bool** | Whether if it&#39;s an supplychargefinanced | 
**BCustomerSupplychargefinancedtaxes** | **bool** | Whether if it&#39;s an supplychargefinancedtaxes | 
**BCustomerAttendance** | **bool** | Whether if it&#39;s an attendance | 
**ECustomerType** | **FieldECustomerType** |  | 
**ECustomerMarketingcorrespondence** | **FieldECustomerMarketingcorrespondence** |  | 
**BCustomerBlackcopycarbon** | **bool** | Whether if it&#39;s an blackcopycarbon | 
**BCustomerUnsubscribeinfo** | **bool** | Whether if it&#39;s an unsubscribeinfo | 
**TCustomerComment** | **string** | The comment of the Customer | 
**IMPORTID** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Ory.Hydra.Client.Model.HydraVerifyUserCodeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Challenge** | **string** | ID is the identifier (\&quot;device challenge\&quot;) of the device request. It is used to identify the session. | [optional] 
**VarClient** | [**HydraOAuth2Client**](HydraOAuth2Client.md) |  | [optional] 
**DeviceCodeRequestId** | **string** |  | [optional] 
**HandledAt** | **DateTime** |  | [optional] 
**RequestUrl** | **string** | RequestURL is the original Device Authorization URL requested. | [optional] 
**RequestedAccessTokenAudience** | **List&lt;string&gt;** |  | [optional] 
**RequestedScope** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.10
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// SettingsViaApiResponse : The Response for Settings Flows via API



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct SettingsViaApiResponse {
    #[serde(rename = "flow")]
    pub flow: Box<crate::models::SettingsFlow>,
    #[serde(rename = "identity")]
    pub identity: Box<crate::models::Identity>,
}

impl SettingsViaApiResponse {
    /// The Response for Settings Flows via API
    pub fn new(flow: crate::models::SettingsFlow, identity: crate::models::Identity) -> SettingsViaApiResponse {
        SettingsViaApiResponse {
            flow: Box::new(flow),
            identity: Box::new(identity),
        }
    }
}



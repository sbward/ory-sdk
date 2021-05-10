/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.6.0-alpha.2
 * Contact: hi@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct UpdateIdentity {
    /// SchemaID is the ID of the JSON Schema to be used for validating the identity's traits. If set will update the Identity's SchemaID.
    #[serde(rename = "schema_id", skip_serializing_if = "Option::is_none")]
    pub schema_id: Option<String>,
    /// Traits represent an identity's traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in `schema_id`.
    #[serde(rename = "traits")]
    pub traits: serde_json::Value,
}

impl UpdateIdentity {
    pub fn new(traits: serde_json::Value) -> UpdateIdentity {
        UpdateIdentity {
            schema_id: None,
            traits,
        }
    }
}


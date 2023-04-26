/*
 * ORY Oathkeeper
 *
 * ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.
 *
 * The version of the OpenAPI document: v0.40.2
 * Contact: hi@ory.am
 * Generated by: https://openapi-generator.tech
 */


use std::fmt::Display;

use num_traits;
use reqwest;

use crate::apis::ResponseContent;
use super::{Error, configuration};

trait NumVecJoin {
    fn join(&self, sep: &str) -> String;
}

impl <T: Display + num_traits::Num> NumVecJoin for Vec<T> {
    fn join(&self, sep: &str) -> String {
        self.iter()
            .map(ToString::to_string)
            .collect::<Vec<String>>()
            .join(sep)
    }
}


/// struct for typed errors of method `decisions`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum DecisionsError {
    Status401(crate::models::GenericError),
    Status403(crate::models::GenericError),
    Status404(crate::models::GenericError),
    Status500(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `get_rule`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum GetRuleError {
    Status404(crate::models::GenericError),
    Status500(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `get_well_known_json_web_keys`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum GetWellKnownJsonWebKeysError {
    Status500(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `list_rules`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ListRulesError {
    Status500(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}


/// > This endpoint works with all HTTP Methods (GET, POST, PUT, ...) and matches every path prefixed with /decisions.  This endpoint mirrors the proxy capability of ORY Oathkeeper's proxy functionality but instead of forwarding the request to the upstream server, returns 200 (request should be allowed), 401 (unauthorized), or 403 (forbidden) status codes. This endpoint can be used to integrate with other API Proxies like Ambassador, Kong, Envoy, and many more.
pub async fn decisions(configuration: &configuration::Configuration, ) -> Result<(), Error<DecisionsError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/decisions", configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        Ok(())
    } else {
        let local_var_entity: Option<DecisionsError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Use this method to retrieve a rule from the storage. If it does not exist you will receive a 404 error.
pub async fn get_rule(configuration: &configuration::Configuration, id: &str) -> Result<crate::models::Rule, Error<GetRuleError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/rules/{id}", configuration.base_path, id=crate::apis::urlencode(id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<GetRuleError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// This endpoint returns cryptographic keys that are required to, for example, verify signatures of ID Tokens.
pub async fn get_well_known_json_web_keys(configuration: &configuration::Configuration, ) -> Result<crate::models::JsonWebKeySet, Error<GetWellKnownJsonWebKeysError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/.well-known/jwks.json", configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<GetWellKnownJsonWebKeysError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// This method returns an array of all rules that are stored in the backend. This is useful if you want to get a full view of what rules you have currently in place.
pub async fn list_rules(configuration: &configuration::Configuration, limit: Option<i64>, offset: Option<i64>) -> Result<Vec<crate::models::Rule>, Error<ListRulesError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/rules", configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_str) = limit {
        local_var_req_builder = local_var_req_builder.query(&[("limit", local_var_str.to_string())]);
    }
    if let Some(ref local_var_str) = offset {
        local_var_req_builder = local_var_req_builder.query(&[("offset", local_var_str.to_string())]);
    }
    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<ListRulesError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}


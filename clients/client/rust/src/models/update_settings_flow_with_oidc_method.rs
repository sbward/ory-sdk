/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.7
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

/// UpdateSettingsFlowWithOidcMethod : Update Settings Flow with OpenID Connect Method
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct UpdateSettingsFlowWithOidcMethod {
    /// Flow ID is the flow's ID.  in: query
    #[serde(rename = "flow", skip_serializing_if = "Option::is_none")]
    pub flow: Option<String>,
    /// Link this provider  Either this or `unlink` must be set.  type: string in: body
    #[serde(rename = "link", skip_serializing_if = "Option::is_none")]
    pub link: Option<String>,
    /// Method  Should be set to profile when trying to update a profile.
    #[serde(rename = "method")]
    pub method: String,
    /// The identity's traits  in: body
    #[serde(rename = "traits", skip_serializing_if = "Option::is_none")]
    pub traits: Option<serde_json::Value>,
    /// Transient data to pass along to any webhooks
    #[serde(rename = "transient_payload", skip_serializing_if = "Option::is_none")]
    pub transient_payload: Option<serde_json::Value>,
    /// Unlink this provider  Either this or `link` must be set.  type: string in: body
    #[serde(rename = "unlink", skip_serializing_if = "Option::is_none")]
    pub unlink: Option<String>,
    /// UpstreamParameters are the parameters that are passed to the upstream identity provider.  These parameters are optional and depend on what the upstream identity provider supports. Supported parameters are: `login_hint` (string): The `login_hint` parameter suppresses the account chooser and either pre-fills the email box on the sign-in form, or selects the proper session. `hd` (string): The `hd` parameter limits the login/registration process to a Google Organization, e.g. `mycollege.edu`. `prompt` (string): The `prompt` specifies whether the Authorization Server prompts the End-User for reauthentication and consent, e.g. `select_account`.
    #[serde(rename = "upstream_parameters", skip_serializing_if = "Option::is_none")]
    pub upstream_parameters: Option<serde_json::Value>,
}

impl UpdateSettingsFlowWithOidcMethod {
    /// Update Settings Flow with OpenID Connect Method
    pub fn new(method: String) -> UpdateSettingsFlowWithOidcMethod {
        UpdateSettingsFlowWithOidcMethod {
            flow: None,
            link: None,
            method,
            traits: None,
            transient_payload: None,
            unlink: None,
            upstream_parameters: None,
        }
    }
}


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

#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct NormalizedProjectRevisionCourierChannel {
    /// The Channel's public ID
    #[serde(rename = "channel_id")]
    pub channel_id: String,
    /// The creation date
    #[serde(rename = "created_at", skip_serializing_if = "Option::is_none")]
    pub created_at: Option<String>,
    /// API key location  Can either be \"header\" or \"query\"
    #[serde(rename = "request_config_auth_config_api_key_in", skip_serializing_if = "Option::is_none")]
    pub request_config_auth_config_api_key_in: Option<String>,
    /// API key name  Only used if the auth type is api_key
    #[serde(rename = "request_config_auth_config_api_key_name", skip_serializing_if = "Option::is_none")]
    pub request_config_auth_config_api_key_name: Option<String>,
    /// API key value  Only used if the auth type is api_key
    #[serde(rename = "request_config_auth_config_api_key_value", skip_serializing_if = "Option::is_none")]
    pub request_config_auth_config_api_key_value: Option<String>,
    /// Basic Auth Password  Only used if the auth type is basic_auth
    #[serde(rename = "request_config_auth_config_basic_auth_password", skip_serializing_if = "Option::is_none")]
    pub request_config_auth_config_basic_auth_password: Option<String>,
    /// Basic Auth Username  Only used if the auth type is basic_auth
    #[serde(rename = "request_config_auth_config_basic_auth_user", skip_serializing_if = "Option::is_none")]
    pub request_config_auth_config_basic_auth_user: Option<String>,
    /// HTTP Auth Method to use for the HTTP call  Can either be basic_auth or api_key basic_auth CourierChannelAuthTypeBasicAuth api_key CourierChannelAuthTypeApiKey
    #[serde(rename = "request_config_auth_type", skip_serializing_if = "Option::is_none")]
    pub request_config_auth_type: Option<RequestConfigAuthTypeEnum>,
    /// URI pointing to the JsonNet template used for HTTP body payload generation.
    #[serde(rename = "request_config_body")]
    pub request_config_body: String,
    /// NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-
    #[serde(rename = "request_config_headers", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub request_config_headers: Option<Option<serde_json::Value>>,
    /// The HTTP method to use (GET, POST, etc) for the HTTP call
    #[serde(rename = "request_config_method")]
    pub request_config_method: String,
    #[serde(rename = "request_config_url", skip_serializing_if = "Option::is_none")]
    pub request_config_url: Option<String>,
    /// Last upate time
    #[serde(rename = "updated_at", skip_serializing_if = "Option::is_none")]
    pub updated_at: Option<String>,
}

impl NormalizedProjectRevisionCourierChannel {
    pub fn new(channel_id: String, request_config_body: String, request_config_method: String) -> NormalizedProjectRevisionCourierChannel {
        NormalizedProjectRevisionCourierChannel {
            channel_id,
            created_at: None,
            request_config_auth_config_api_key_in: None,
            request_config_auth_config_api_key_name: None,
            request_config_auth_config_api_key_value: None,
            request_config_auth_config_basic_auth_password: None,
            request_config_auth_config_basic_auth_user: None,
            request_config_auth_type: None,
            request_config_body,
            request_config_headers: None,
            request_config_method,
            request_config_url: None,
            updated_at: None,
        }
    }
}
/// HTTP Auth Method to use for the HTTP call  Can either be basic_auth or api_key basic_auth CourierChannelAuthTypeBasicAuth api_key CourierChannelAuthTypeApiKey
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum RequestConfigAuthTypeEnum {
    #[serde(rename = "basic_auth")]
    BasicAuth,
    #[serde(rename = "api_key")]
    ApiKey,
}

impl Default for RequestConfigAuthTypeEnum {
    fn default() -> RequestConfigAuthTypeEnum {
        Self::BasicAuth
    }
}


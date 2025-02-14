/*
Ory APIs

# Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 

API version: v1.16.7
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// checks if the IdentityWithCredentialsOidc type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &IdentityWithCredentialsOidc{}

// IdentityWithCredentialsOidc Create Identity and Import Social Sign In Credentials
type IdentityWithCredentialsOidc struct {
	Config *IdentityWithCredentialsOidcConfig `json:"config,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _IdentityWithCredentialsOidc IdentityWithCredentialsOidc

// NewIdentityWithCredentialsOidc instantiates a new IdentityWithCredentialsOidc object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewIdentityWithCredentialsOidc() *IdentityWithCredentialsOidc {
	this := IdentityWithCredentialsOidc{}
	return &this
}

// NewIdentityWithCredentialsOidcWithDefaults instantiates a new IdentityWithCredentialsOidc object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewIdentityWithCredentialsOidcWithDefaults() *IdentityWithCredentialsOidc {
	this := IdentityWithCredentialsOidc{}
	return &this
}

// GetConfig returns the Config field value if set, zero value otherwise.
func (o *IdentityWithCredentialsOidc) GetConfig() IdentityWithCredentialsOidcConfig {
	if o == nil || IsNil(o.Config) {
		var ret IdentityWithCredentialsOidcConfig
		return ret
	}
	return *o.Config
}

// GetConfigOk returns a tuple with the Config field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *IdentityWithCredentialsOidc) GetConfigOk() (*IdentityWithCredentialsOidcConfig, bool) {
	if o == nil || IsNil(o.Config) {
		return nil, false
	}
	return o.Config, true
}

// HasConfig returns a boolean if a field has been set.
func (o *IdentityWithCredentialsOidc) HasConfig() bool {
	if o != nil && !IsNil(o.Config) {
		return true
	}

	return false
}

// SetConfig gets a reference to the given IdentityWithCredentialsOidcConfig and assigns it to the Config field.
func (o *IdentityWithCredentialsOidc) SetConfig(v IdentityWithCredentialsOidcConfig) {
	o.Config = &v
}

func (o IdentityWithCredentialsOidc) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o IdentityWithCredentialsOidc) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Config) {
		toSerialize["config"] = o.Config
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *IdentityWithCredentialsOidc) UnmarshalJSON(data []byte) (err error) {
	varIdentityWithCredentialsOidc := _IdentityWithCredentialsOidc{}

	err = json.Unmarshal(data, &varIdentityWithCredentialsOidc)

	if err != nil {
		return err
	}

	*o = IdentityWithCredentialsOidc(varIdentityWithCredentialsOidc)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "config")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableIdentityWithCredentialsOidc struct {
	value *IdentityWithCredentialsOidc
	isSet bool
}

func (v NullableIdentityWithCredentialsOidc) Get() *IdentityWithCredentialsOidc {
	return v.value
}

func (v *NullableIdentityWithCredentialsOidc) Set(val *IdentityWithCredentialsOidc) {
	v.value = val
	v.isSet = true
}

func (v NullableIdentityWithCredentialsOidc) IsSet() bool {
	return v.isSet
}

func (v *NullableIdentityWithCredentialsOidc) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableIdentityWithCredentialsOidc(val *IdentityWithCredentialsOidc) *NullableIdentityWithCredentialsOidc {
	return &NullableIdentityWithCredentialsOidc{value: val, isSet: true}
}

func (v NullableIdentityWithCredentialsOidc) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableIdentityWithCredentialsOidc) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}



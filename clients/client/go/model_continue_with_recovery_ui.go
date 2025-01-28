/*
Ory APIs

# Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 

API version: v1.16.3
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"fmt"
)

// checks if the ContinueWithRecoveryUi type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &ContinueWithRecoveryUi{}

// ContinueWithRecoveryUi Indicates, that the UI flow could be continued by showing a recovery ui
type ContinueWithRecoveryUi struct {
	// Action will always be `show_recovery_ui` show_recovery_ui ContinueWithActionShowRecoveryUIString
	Action string `json:"action"`
	Flow ContinueWithRecoveryUiFlow `json:"flow"`
	AdditionalProperties map[string]interface{}
}

type _ContinueWithRecoveryUi ContinueWithRecoveryUi

// NewContinueWithRecoveryUi instantiates a new ContinueWithRecoveryUi object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewContinueWithRecoveryUi(action string, flow ContinueWithRecoveryUiFlow) *ContinueWithRecoveryUi {
	this := ContinueWithRecoveryUi{}
	this.Action = action
	this.Flow = flow
	return &this
}

// NewContinueWithRecoveryUiWithDefaults instantiates a new ContinueWithRecoveryUi object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewContinueWithRecoveryUiWithDefaults() *ContinueWithRecoveryUi {
	this := ContinueWithRecoveryUi{}
	return &this
}

// GetAction returns the Action field value
func (o *ContinueWithRecoveryUi) GetAction() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Action
}

// GetActionOk returns a tuple with the Action field value
// and a boolean to check if the value has been set.
func (o *ContinueWithRecoveryUi) GetActionOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Action, true
}

// SetAction sets field value
func (o *ContinueWithRecoveryUi) SetAction(v string) {
	o.Action = v
}

// GetFlow returns the Flow field value
func (o *ContinueWithRecoveryUi) GetFlow() ContinueWithRecoveryUiFlow {
	if o == nil {
		var ret ContinueWithRecoveryUiFlow
		return ret
	}

	return o.Flow
}

// GetFlowOk returns a tuple with the Flow field value
// and a boolean to check if the value has been set.
func (o *ContinueWithRecoveryUi) GetFlowOk() (*ContinueWithRecoveryUiFlow, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Flow, true
}

// SetFlow sets field value
func (o *ContinueWithRecoveryUi) SetFlow(v ContinueWithRecoveryUiFlow) {
	o.Flow = v
}

func (o ContinueWithRecoveryUi) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o ContinueWithRecoveryUi) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["action"] = o.Action
	toSerialize["flow"] = o.Flow

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *ContinueWithRecoveryUi) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"action",
		"flow",
	}

	allProperties := make(map[string]interface{})

	err = json.Unmarshal(data, &allProperties)

	if err != nil {
		return err;
	}

	for _, requiredProperty := range(requiredProperties) {
		if _, exists := allProperties[requiredProperty]; !exists {
			return fmt.Errorf("no value given for required property %v", requiredProperty)
		}
	}

	varContinueWithRecoveryUi := _ContinueWithRecoveryUi{}

	err = json.Unmarshal(data, &varContinueWithRecoveryUi)

	if err != nil {
		return err
	}

	*o = ContinueWithRecoveryUi(varContinueWithRecoveryUi)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "action")
		delete(additionalProperties, "flow")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableContinueWithRecoveryUi struct {
	value *ContinueWithRecoveryUi
	isSet bool
}

func (v NullableContinueWithRecoveryUi) Get() *ContinueWithRecoveryUi {
	return v.value
}

func (v *NullableContinueWithRecoveryUi) Set(val *ContinueWithRecoveryUi) {
	v.value = val
	v.isSet = true
}

func (v NullableContinueWithRecoveryUi) IsSet() bool {
	return v.isSet
}

func (v *NullableContinueWithRecoveryUi) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableContinueWithRecoveryUi(val *ContinueWithRecoveryUi) *NullableContinueWithRecoveryUi {
	return &NullableContinueWithRecoveryUi{value: val, isSet: true}
}

func (v NullableContinueWithRecoveryUi) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableContinueWithRecoveryUi) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}



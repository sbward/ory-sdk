/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v1.9.0
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"fmt"
)

// checks if the SuccessfulProjectUpdate type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &SuccessfulProjectUpdate{}

// SuccessfulProjectUpdate struct for SuccessfulProjectUpdate
type SuccessfulProjectUpdate struct {
	Project Project `json:"project"`
	// Import Warnings  Not all configuration items can be imported to the Ory Network. For example, setting the port does not make sense because the Ory Network provides the runtime and networking.  This field contains warnings where configuration keys were found but can not be imported. These keys will be ignored by the Ory Network. This field will help you understand why certain configuration keys might not be respected!
	Warnings []Warning `json:"warnings"`
	AdditionalProperties map[string]interface{}
}

type _SuccessfulProjectUpdate SuccessfulProjectUpdate

// NewSuccessfulProjectUpdate instantiates a new SuccessfulProjectUpdate object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewSuccessfulProjectUpdate(project Project, warnings []Warning) *SuccessfulProjectUpdate {
	this := SuccessfulProjectUpdate{}
	this.Project = project
	this.Warnings = warnings
	return &this
}

// NewSuccessfulProjectUpdateWithDefaults instantiates a new SuccessfulProjectUpdate object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewSuccessfulProjectUpdateWithDefaults() *SuccessfulProjectUpdate {
	this := SuccessfulProjectUpdate{}
	return &this
}

// GetProject returns the Project field value
func (o *SuccessfulProjectUpdate) GetProject() Project {
	if o == nil {
		var ret Project
		return ret
	}

	return o.Project
}

// GetProjectOk returns a tuple with the Project field value
// and a boolean to check if the value has been set.
func (o *SuccessfulProjectUpdate) GetProjectOk() (*Project, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Project, true
}

// SetProject sets field value
func (o *SuccessfulProjectUpdate) SetProject(v Project) {
	o.Project = v
}

// GetWarnings returns the Warnings field value
func (o *SuccessfulProjectUpdate) GetWarnings() []Warning {
	if o == nil {
		var ret []Warning
		return ret
	}

	return o.Warnings
}

// GetWarningsOk returns a tuple with the Warnings field value
// and a boolean to check if the value has been set.
func (o *SuccessfulProjectUpdate) GetWarningsOk() ([]Warning, bool) {
	if o == nil {
		return nil, false
	}
	return o.Warnings, true
}

// SetWarnings sets field value
func (o *SuccessfulProjectUpdate) SetWarnings(v []Warning) {
	o.Warnings = v
}

func (o SuccessfulProjectUpdate) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o SuccessfulProjectUpdate) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["project"] = o.Project
	toSerialize["warnings"] = o.Warnings

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *SuccessfulProjectUpdate) UnmarshalJSON(bytes []byte) (err error) {
    // This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"project",
		"warnings",
	}

	allProperties := make(map[string]interface{})

	err = json.Unmarshal(bytes, &allProperties)

	if err != nil {
		return err;
	}

	for _, requiredProperty := range(requiredProperties) {
		if _, exists := allProperties[requiredProperty]; !exists {
			return fmt.Errorf("no value given for required property %v", requiredProperty)
		}
	}

	varSuccessfulProjectUpdate := _SuccessfulProjectUpdate{}

	err = json.Unmarshal(bytes, &varSuccessfulProjectUpdate)

	if err != nil {
		return err
	}

	*o = SuccessfulProjectUpdate(varSuccessfulProjectUpdate)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(bytes, &additionalProperties); err == nil {
		delete(additionalProperties, "project")
		delete(additionalProperties, "warnings")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableSuccessfulProjectUpdate struct {
	value *SuccessfulProjectUpdate
	isSet bool
}

func (v NullableSuccessfulProjectUpdate) Get() *SuccessfulProjectUpdate {
	return v.value
}

func (v *NullableSuccessfulProjectUpdate) Set(val *SuccessfulProjectUpdate) {
	v.value = val
	v.isSet = true
}

func (v NullableSuccessfulProjectUpdate) IsSet() bool {
	return v.isSet
}

func (v *NullableSuccessfulProjectUpdate) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSuccessfulProjectUpdate(val *SuccessfulProjectUpdate) *NullableSuccessfulProjectUpdate {
	return &NullableSuccessfulProjectUpdate{value: val, isSet: true}
}

func (v NullableSuccessfulProjectUpdate) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSuccessfulProjectUpdate) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}



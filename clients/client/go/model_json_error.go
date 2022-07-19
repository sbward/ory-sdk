/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * API version: v0.1.0-alpha.4
 * Contact: support@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// JsonError The standard Ory JSON API error format.
type JsonError struct {
	Error GenericError `json:"error"`
}

// NewJsonError instantiates a new JsonError object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewJsonError(error_ GenericError) *JsonError {
	this := JsonError{}
	this.Error = error_
	return &this
}

// NewJsonErrorWithDefaults instantiates a new JsonError object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewJsonErrorWithDefaults() *JsonError {
	this := JsonError{}
	return &this
}

// GetError returns the Error field value
func (o *JsonError) GetError() GenericError {
	if o == nil {
		var ret GenericError
		return ret
	}

	return o.Error
}

// GetErrorOk returns a tuple with the Error field value
// and a boolean to check if the value has been set.
func (o *JsonError) GetErrorOk() (*GenericError, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.Error, true
}

// SetError sets field value
func (o *JsonError) SetError(v GenericError) {
	o.Error = v
}

func (o JsonError) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if true {
		toSerialize["error"] = o.Error
	}
	return json.Marshal(toSerialize)
}

type NullableJsonError struct {
	value *JsonError
	isSet bool
}

func (v NullableJsonError) Get() *JsonError {
	return v.value
}

func (v *NullableJsonError) Set(val *JsonError) {
	v.value = val
	v.isSet = true
}

func (v NullableJsonError) IsSet() bool {
	return v.isSet
}

func (v *NullableJsonError) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableJsonError(val *JsonError) *NullableJsonError {
	return &NullableJsonError{value: val, isSet: true}
}

func (v NullableJsonError) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableJsonError) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}



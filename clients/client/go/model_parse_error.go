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

// checks if the ParseError type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &ParseError{}

// ParseError struct for ParseError
type ParseError struct {
	End *SourcePosition `json:"end,omitempty"`
	Message *string `json:"message,omitempty"`
	Start *SourcePosition `json:"start,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _ParseError ParseError

// NewParseError instantiates a new ParseError object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewParseError() *ParseError {
	this := ParseError{}
	return &this
}

// NewParseErrorWithDefaults instantiates a new ParseError object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewParseErrorWithDefaults() *ParseError {
	this := ParseError{}
	return &this
}

// GetEnd returns the End field value if set, zero value otherwise.
func (o *ParseError) GetEnd() SourcePosition {
	if o == nil || IsNil(o.End) {
		var ret SourcePosition
		return ret
	}
	return *o.End
}

// GetEndOk returns a tuple with the End field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ParseError) GetEndOk() (*SourcePosition, bool) {
	if o == nil || IsNil(o.End) {
		return nil, false
	}
	return o.End, true
}

// HasEnd returns a boolean if a field has been set.
func (o *ParseError) HasEnd() bool {
	if o != nil && !IsNil(o.End) {
		return true
	}

	return false
}

// SetEnd gets a reference to the given SourcePosition and assigns it to the End field.
func (o *ParseError) SetEnd(v SourcePosition) {
	o.End = &v
}

// GetMessage returns the Message field value if set, zero value otherwise.
func (o *ParseError) GetMessage() string {
	if o == nil || IsNil(o.Message) {
		var ret string
		return ret
	}
	return *o.Message
}

// GetMessageOk returns a tuple with the Message field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ParseError) GetMessageOk() (*string, bool) {
	if o == nil || IsNil(o.Message) {
		return nil, false
	}
	return o.Message, true
}

// HasMessage returns a boolean if a field has been set.
func (o *ParseError) HasMessage() bool {
	if o != nil && !IsNil(o.Message) {
		return true
	}

	return false
}

// SetMessage gets a reference to the given string and assigns it to the Message field.
func (o *ParseError) SetMessage(v string) {
	o.Message = &v
}

// GetStart returns the Start field value if set, zero value otherwise.
func (o *ParseError) GetStart() SourcePosition {
	if o == nil || IsNil(o.Start) {
		var ret SourcePosition
		return ret
	}
	return *o.Start
}

// GetStartOk returns a tuple with the Start field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ParseError) GetStartOk() (*SourcePosition, bool) {
	if o == nil || IsNil(o.Start) {
		return nil, false
	}
	return o.Start, true
}

// HasStart returns a boolean if a field has been set.
func (o *ParseError) HasStart() bool {
	if o != nil && !IsNil(o.Start) {
		return true
	}

	return false
}

// SetStart gets a reference to the given SourcePosition and assigns it to the Start field.
func (o *ParseError) SetStart(v SourcePosition) {
	o.Start = &v
}

func (o ParseError) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o ParseError) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.End) {
		toSerialize["end"] = o.End
	}
	if !IsNil(o.Message) {
		toSerialize["message"] = o.Message
	}
	if !IsNil(o.Start) {
		toSerialize["start"] = o.Start
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *ParseError) UnmarshalJSON(data []byte) (err error) {
	varParseError := _ParseError{}

	err = json.Unmarshal(data, &varParseError)

	if err != nil {
		return err
	}

	*o = ParseError(varParseError)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "end")
		delete(additionalProperties, "message")
		delete(additionalProperties, "start")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableParseError struct {
	value *ParseError
	isSet bool
}

func (v NullableParseError) Get() *ParseError {
	return v.value
}

func (v *NullableParseError) Set(val *ParseError) {
	v.value = val
	v.isSet = true
}

func (v NullableParseError) IsSet() bool {
	return v.isSet
}

func (v *NullableParseError) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableParseError(val *ParseError) *NullableParseError {
	return &NullableParseError{value: val, isSet: true}
}

func (v NullableParseError) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableParseError) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}



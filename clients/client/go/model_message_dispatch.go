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
	"time"
	"fmt"
)

// checks if the MessageDispatch type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &MessageDispatch{}

// MessageDispatch MessageDispatch represents an attempt of sending a courier message It contains the status of the attempt (failed or successful) and the error if any occured
type MessageDispatch struct {
	// CreatedAt is a helper struct field for gobuffalo.pop.
	CreatedAt time.Time `json:"created_at"`
	Error map[string]interface{} `json:"error,omitempty"`
	// The ID of this message dispatch
	Id string `json:"id"`
	// The ID of the message being dispatched
	MessageId string `json:"message_id"`
	// The status of this dispatch Either \"failed\" or \"success\" failed CourierMessageDispatchStatusFailed success CourierMessageDispatchStatusSuccess
	Status string `json:"status"`
	// UpdatedAt is a helper struct field for gobuffalo.pop.
	UpdatedAt time.Time `json:"updated_at"`
	AdditionalProperties map[string]interface{}
}

type _MessageDispatch MessageDispatch

// NewMessageDispatch instantiates a new MessageDispatch object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewMessageDispatch(createdAt time.Time, id string, messageId string, status string, updatedAt time.Time) *MessageDispatch {
	this := MessageDispatch{}
	this.CreatedAt = createdAt
	this.Id = id
	this.MessageId = messageId
	this.Status = status
	this.UpdatedAt = updatedAt
	return &this
}

// NewMessageDispatchWithDefaults instantiates a new MessageDispatch object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewMessageDispatchWithDefaults() *MessageDispatch {
	this := MessageDispatch{}
	return &this
}

// GetCreatedAt returns the CreatedAt field value
func (o *MessageDispatch) GetCreatedAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.CreatedAt
}

// GetCreatedAtOk returns a tuple with the CreatedAt field value
// and a boolean to check if the value has been set.
func (o *MessageDispatch) GetCreatedAtOk() (*time.Time, bool) {
	if o == nil {
		return nil, false
	}
	return &o.CreatedAt, true
}

// SetCreatedAt sets field value
func (o *MessageDispatch) SetCreatedAt(v time.Time) {
	o.CreatedAt = v
}

// GetError returns the Error field value if set, zero value otherwise.
func (o *MessageDispatch) GetError() map[string]interface{} {
	if o == nil || IsNil(o.Error) {
		var ret map[string]interface{}
		return ret
	}
	return o.Error
}

// GetErrorOk returns a tuple with the Error field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *MessageDispatch) GetErrorOk() (map[string]interface{}, bool) {
	if o == nil || IsNil(o.Error) {
		return map[string]interface{}{}, false
	}
	return o.Error, true
}

// HasError returns a boolean if a field has been set.
func (o *MessageDispatch) HasError() bool {
	if o != nil && !IsNil(o.Error) {
		return true
	}

	return false
}

// SetError gets a reference to the given map[string]interface{} and assigns it to the Error field.
func (o *MessageDispatch) SetError(v map[string]interface{}) {
	o.Error = v
}

// GetId returns the Id field value
func (o *MessageDispatch) GetId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Id
}

// GetIdOk returns a tuple with the Id field value
// and a boolean to check if the value has been set.
func (o *MessageDispatch) GetIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Id, true
}

// SetId sets field value
func (o *MessageDispatch) SetId(v string) {
	o.Id = v
}

// GetMessageId returns the MessageId field value
func (o *MessageDispatch) GetMessageId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.MessageId
}

// GetMessageIdOk returns a tuple with the MessageId field value
// and a boolean to check if the value has been set.
func (o *MessageDispatch) GetMessageIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.MessageId, true
}

// SetMessageId sets field value
func (o *MessageDispatch) SetMessageId(v string) {
	o.MessageId = v
}

// GetStatus returns the Status field value
func (o *MessageDispatch) GetStatus() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Status
}

// GetStatusOk returns a tuple with the Status field value
// and a boolean to check if the value has been set.
func (o *MessageDispatch) GetStatusOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Status, true
}

// SetStatus sets field value
func (o *MessageDispatch) SetStatus(v string) {
	o.Status = v
}

// GetUpdatedAt returns the UpdatedAt field value
func (o *MessageDispatch) GetUpdatedAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.UpdatedAt
}

// GetUpdatedAtOk returns a tuple with the UpdatedAt field value
// and a boolean to check if the value has been set.
func (o *MessageDispatch) GetUpdatedAtOk() (*time.Time, bool) {
	if o == nil {
		return nil, false
	}
	return &o.UpdatedAt, true
}

// SetUpdatedAt sets field value
func (o *MessageDispatch) SetUpdatedAt(v time.Time) {
	o.UpdatedAt = v
}

func (o MessageDispatch) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o MessageDispatch) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["created_at"] = o.CreatedAt
	if !IsNil(o.Error) {
		toSerialize["error"] = o.Error
	}
	toSerialize["id"] = o.Id
	toSerialize["message_id"] = o.MessageId
	toSerialize["status"] = o.Status
	toSerialize["updated_at"] = o.UpdatedAt

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *MessageDispatch) UnmarshalJSON(bytes []byte) (err error) {
    // This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"created_at",
		"id",
		"message_id",
		"status",
		"updated_at",
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

	varMessageDispatch := _MessageDispatch{}

	err = json.Unmarshal(bytes, &varMessageDispatch)

	if err != nil {
		return err
	}

	*o = MessageDispatch(varMessageDispatch)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(bytes, &additionalProperties); err == nil {
		delete(additionalProperties, "created_at")
		delete(additionalProperties, "error")
		delete(additionalProperties, "id")
		delete(additionalProperties, "message_id")
		delete(additionalProperties, "status")
		delete(additionalProperties, "updated_at")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableMessageDispatch struct {
	value *MessageDispatch
	isSet bool
}

func (v NullableMessageDispatch) Get() *MessageDispatch {
	return v.value
}

func (v *NullableMessageDispatch) Set(val *MessageDispatch) {
	v.value = val
	v.isSet = true
}

func (v NullableMessageDispatch) IsSet() bool {
	return v.isSet
}

func (v *NullableMessageDispatch) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableMessageDispatch(val *MessageDispatch) *NullableMessageDispatch {
	return &NullableMessageDispatch{value: val, isSet: true}
}

func (v NullableMessageDispatch) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableMessageDispatch) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}



/*
Ory APIs

# Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 

API version: v1.16.2
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"time"
	"fmt"
)

// checks if the MemberInvite type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &MemberInvite{}

// MemberInvite struct for MemberInvite
type MemberInvite struct {
	// The Project's Revision Creation Date
	CreatedAt time.Time `json:"created_at"`
	// The invite's ID.
	Id string `json:"id"`
	// The invitee's email
	InviteeEmail string `json:"invitee_email"`
	InviteeId NullableString `json:"invitee_id,omitempty"`
	// The invite owner's email Usually the project's owner email
	OwnerEmail string `json:"owner_email"`
	// The invite owner's ID Usually the project's owner
	OwnerId string `json:"owner_id"`
	ProjectId NullableString `json:"project_id,omitempty"`
	Role NullableString `json:"role,omitempty"`
	// The invite's status Keeps track of the invites status such as pending, accepted, declined, expired pending PENDING accepted ACCEPTED declined DECLINED expired EXPIRED cancelled CANCELLED removed REMOVED
	Status string `json:"status"`
	// Last Time Project's Revision was Updated
	UpdatedAt time.Time `json:"updated_at"`
	WorkspaceId NullableString `json:"workspace_id,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _MemberInvite MemberInvite

// NewMemberInvite instantiates a new MemberInvite object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewMemberInvite(createdAt time.Time, id string, inviteeEmail string, ownerEmail string, ownerId string, status string, updatedAt time.Time) *MemberInvite {
	this := MemberInvite{}
	this.CreatedAt = createdAt
	this.Id = id
	this.InviteeEmail = inviteeEmail
	this.OwnerEmail = ownerEmail
	this.OwnerId = ownerId
	this.Status = status
	this.UpdatedAt = updatedAt
	return &this
}

// NewMemberInviteWithDefaults instantiates a new MemberInvite object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewMemberInviteWithDefaults() *MemberInvite {
	this := MemberInvite{}
	return &this
}

// GetCreatedAt returns the CreatedAt field value
func (o *MemberInvite) GetCreatedAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.CreatedAt
}

// GetCreatedAtOk returns a tuple with the CreatedAt field value
// and a boolean to check if the value has been set.
func (o *MemberInvite) GetCreatedAtOk() (*time.Time, bool) {
	if o == nil {
		return nil, false
	}
	return &o.CreatedAt, true
}

// SetCreatedAt sets field value
func (o *MemberInvite) SetCreatedAt(v time.Time) {
	o.CreatedAt = v
}

// GetId returns the Id field value
func (o *MemberInvite) GetId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Id
}

// GetIdOk returns a tuple with the Id field value
// and a boolean to check if the value has been set.
func (o *MemberInvite) GetIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Id, true
}

// SetId sets field value
func (o *MemberInvite) SetId(v string) {
	o.Id = v
}

// GetInviteeEmail returns the InviteeEmail field value
func (o *MemberInvite) GetInviteeEmail() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.InviteeEmail
}

// GetInviteeEmailOk returns a tuple with the InviteeEmail field value
// and a boolean to check if the value has been set.
func (o *MemberInvite) GetInviteeEmailOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.InviteeEmail, true
}

// SetInviteeEmail sets field value
func (o *MemberInvite) SetInviteeEmail(v string) {
	o.InviteeEmail = v
}

// GetInviteeId returns the InviteeId field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *MemberInvite) GetInviteeId() string {
	if o == nil || IsNil(o.InviteeId.Get()) {
		var ret string
		return ret
	}
	return *o.InviteeId.Get()
}

// GetInviteeIdOk returns a tuple with the InviteeId field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *MemberInvite) GetInviteeIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.InviteeId.Get(), o.InviteeId.IsSet()
}

// HasInviteeId returns a boolean if a field has been set.
func (o *MemberInvite) HasInviteeId() bool {
	if o != nil && o.InviteeId.IsSet() {
		return true
	}

	return false
}

// SetInviteeId gets a reference to the given NullableString and assigns it to the InviteeId field.
func (o *MemberInvite) SetInviteeId(v string) {
	o.InviteeId.Set(&v)
}
// SetInviteeIdNil sets the value for InviteeId to be an explicit nil
func (o *MemberInvite) SetInviteeIdNil() {
	o.InviteeId.Set(nil)
}

// UnsetInviteeId ensures that no value is present for InviteeId, not even an explicit nil
func (o *MemberInvite) UnsetInviteeId() {
	o.InviteeId.Unset()
}

// GetOwnerEmail returns the OwnerEmail field value
func (o *MemberInvite) GetOwnerEmail() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.OwnerEmail
}

// GetOwnerEmailOk returns a tuple with the OwnerEmail field value
// and a boolean to check if the value has been set.
func (o *MemberInvite) GetOwnerEmailOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.OwnerEmail, true
}

// SetOwnerEmail sets field value
func (o *MemberInvite) SetOwnerEmail(v string) {
	o.OwnerEmail = v
}

// GetOwnerId returns the OwnerId field value
func (o *MemberInvite) GetOwnerId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.OwnerId
}

// GetOwnerIdOk returns a tuple with the OwnerId field value
// and a boolean to check if the value has been set.
func (o *MemberInvite) GetOwnerIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.OwnerId, true
}

// SetOwnerId sets field value
func (o *MemberInvite) SetOwnerId(v string) {
	o.OwnerId = v
}

// GetProjectId returns the ProjectId field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *MemberInvite) GetProjectId() string {
	if o == nil || IsNil(o.ProjectId.Get()) {
		var ret string
		return ret
	}
	return *o.ProjectId.Get()
}

// GetProjectIdOk returns a tuple with the ProjectId field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *MemberInvite) GetProjectIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.ProjectId.Get(), o.ProjectId.IsSet()
}

// HasProjectId returns a boolean if a field has been set.
func (o *MemberInvite) HasProjectId() bool {
	if o != nil && o.ProjectId.IsSet() {
		return true
	}

	return false
}

// SetProjectId gets a reference to the given NullableString and assigns it to the ProjectId field.
func (o *MemberInvite) SetProjectId(v string) {
	o.ProjectId.Set(&v)
}
// SetProjectIdNil sets the value for ProjectId to be an explicit nil
func (o *MemberInvite) SetProjectIdNil() {
	o.ProjectId.Set(nil)
}

// UnsetProjectId ensures that no value is present for ProjectId, not even an explicit nil
func (o *MemberInvite) UnsetProjectId() {
	o.ProjectId.Unset()
}

// GetRole returns the Role field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *MemberInvite) GetRole() string {
	if o == nil || IsNil(o.Role.Get()) {
		var ret string
		return ret
	}
	return *o.Role.Get()
}

// GetRoleOk returns a tuple with the Role field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *MemberInvite) GetRoleOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.Role.Get(), o.Role.IsSet()
}

// HasRole returns a boolean if a field has been set.
func (o *MemberInvite) HasRole() bool {
	if o != nil && o.Role.IsSet() {
		return true
	}

	return false
}

// SetRole gets a reference to the given NullableString and assigns it to the Role field.
func (o *MemberInvite) SetRole(v string) {
	o.Role.Set(&v)
}
// SetRoleNil sets the value for Role to be an explicit nil
func (o *MemberInvite) SetRoleNil() {
	o.Role.Set(nil)
}

// UnsetRole ensures that no value is present for Role, not even an explicit nil
func (o *MemberInvite) UnsetRole() {
	o.Role.Unset()
}

// GetStatus returns the Status field value
func (o *MemberInvite) GetStatus() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Status
}

// GetStatusOk returns a tuple with the Status field value
// and a boolean to check if the value has been set.
func (o *MemberInvite) GetStatusOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Status, true
}

// SetStatus sets field value
func (o *MemberInvite) SetStatus(v string) {
	o.Status = v
}

// GetUpdatedAt returns the UpdatedAt field value
func (o *MemberInvite) GetUpdatedAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.UpdatedAt
}

// GetUpdatedAtOk returns a tuple with the UpdatedAt field value
// and a boolean to check if the value has been set.
func (o *MemberInvite) GetUpdatedAtOk() (*time.Time, bool) {
	if o == nil {
		return nil, false
	}
	return &o.UpdatedAt, true
}

// SetUpdatedAt sets field value
func (o *MemberInvite) SetUpdatedAt(v time.Time) {
	o.UpdatedAt = v
}

// GetWorkspaceId returns the WorkspaceId field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *MemberInvite) GetWorkspaceId() string {
	if o == nil || IsNil(o.WorkspaceId.Get()) {
		var ret string
		return ret
	}
	return *o.WorkspaceId.Get()
}

// GetWorkspaceIdOk returns a tuple with the WorkspaceId field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *MemberInvite) GetWorkspaceIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.WorkspaceId.Get(), o.WorkspaceId.IsSet()
}

// HasWorkspaceId returns a boolean if a field has been set.
func (o *MemberInvite) HasWorkspaceId() bool {
	if o != nil && o.WorkspaceId.IsSet() {
		return true
	}

	return false
}

// SetWorkspaceId gets a reference to the given NullableString and assigns it to the WorkspaceId field.
func (o *MemberInvite) SetWorkspaceId(v string) {
	o.WorkspaceId.Set(&v)
}
// SetWorkspaceIdNil sets the value for WorkspaceId to be an explicit nil
func (o *MemberInvite) SetWorkspaceIdNil() {
	o.WorkspaceId.Set(nil)
}

// UnsetWorkspaceId ensures that no value is present for WorkspaceId, not even an explicit nil
func (o *MemberInvite) UnsetWorkspaceId() {
	o.WorkspaceId.Unset()
}

func (o MemberInvite) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o MemberInvite) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["created_at"] = o.CreatedAt
	toSerialize["id"] = o.Id
	toSerialize["invitee_email"] = o.InviteeEmail
	if o.InviteeId.IsSet() {
		toSerialize["invitee_id"] = o.InviteeId.Get()
	}
	toSerialize["owner_email"] = o.OwnerEmail
	toSerialize["owner_id"] = o.OwnerId
	if o.ProjectId.IsSet() {
		toSerialize["project_id"] = o.ProjectId.Get()
	}
	if o.Role.IsSet() {
		toSerialize["role"] = o.Role.Get()
	}
	toSerialize["status"] = o.Status
	toSerialize["updated_at"] = o.UpdatedAt
	if o.WorkspaceId.IsSet() {
		toSerialize["workspace_id"] = o.WorkspaceId.Get()
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *MemberInvite) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"created_at",
		"id",
		"invitee_email",
		"owner_email",
		"owner_id",
		"status",
		"updated_at",
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

	varMemberInvite := _MemberInvite{}

	err = json.Unmarshal(data, &varMemberInvite)

	if err != nil {
		return err
	}

	*o = MemberInvite(varMemberInvite)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "created_at")
		delete(additionalProperties, "id")
		delete(additionalProperties, "invitee_email")
		delete(additionalProperties, "invitee_id")
		delete(additionalProperties, "owner_email")
		delete(additionalProperties, "owner_id")
		delete(additionalProperties, "project_id")
		delete(additionalProperties, "role")
		delete(additionalProperties, "status")
		delete(additionalProperties, "updated_at")
		delete(additionalProperties, "workspace_id")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableMemberInvite struct {
	value *MemberInvite
	isSet bool
}

func (v NullableMemberInvite) Get() *MemberInvite {
	return v.value
}

func (v *NullableMemberInvite) Set(val *MemberInvite) {
	v.value = val
	v.isSet = true
}

func (v NullableMemberInvite) IsSet() bool {
	return v.isSet
}

func (v *NullableMemberInvite) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableMemberInvite(val *MemberInvite) *NullableMemberInvite {
	return &NullableMemberInvite{value: val, isSet: true}
}

func (v NullableMemberInvite) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableMemberInvite) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}



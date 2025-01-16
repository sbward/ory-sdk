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
)

// checks if the OAuth2ConsentSession type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &OAuth2ConsentSession{}

// OAuth2ConsentSession A completed OAuth 2.0 Consent Session.
type OAuth2ConsentSession struct {
	ConsentRequest *OAuth2ConsentRequest `json:"consent_request,omitempty"`
	Context map[string]interface{} `json:"context,omitempty"`
	ExpiresAt *OAuth2ConsentSessionExpiresAt `json:"expires_at,omitempty"`
	GrantAccessTokenAudience []string `json:"grant_access_token_audience,omitempty"`
	GrantScope []string `json:"grant_scope,omitempty"`
	HandledAt *time.Time `json:"handled_at,omitempty"`
	// Remember Consent  Remember, if set to true, tells ORY Hydra to remember this consent authorization and reuse it if the same client asks the same user for the same, or a subset of, scope.
	Remember *bool `json:"remember,omitempty"`
	// Remember Consent For  RememberFor sets how long the consent authorization should be remembered for in seconds. If set to `0`, the authorization will be remembered indefinitely.
	RememberFor *int64 `json:"remember_for,omitempty"`
	Session *AcceptOAuth2ConsentRequestSession `json:"session,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _OAuth2ConsentSession OAuth2ConsentSession

// NewOAuth2ConsentSession instantiates a new OAuth2ConsentSession object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewOAuth2ConsentSession() *OAuth2ConsentSession {
	this := OAuth2ConsentSession{}
	return &this
}

// NewOAuth2ConsentSessionWithDefaults instantiates a new OAuth2ConsentSession object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewOAuth2ConsentSessionWithDefaults() *OAuth2ConsentSession {
	this := OAuth2ConsentSession{}
	return &this
}

// GetConsentRequest returns the ConsentRequest field value if set, zero value otherwise.
func (o *OAuth2ConsentSession) GetConsentRequest() OAuth2ConsentRequest {
	if o == nil || IsNil(o.ConsentRequest) {
		var ret OAuth2ConsentRequest
		return ret
	}
	return *o.ConsentRequest
}

// GetConsentRequestOk returns a tuple with the ConsentRequest field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSession) GetConsentRequestOk() (*OAuth2ConsentRequest, bool) {
	if o == nil || IsNil(o.ConsentRequest) {
		return nil, false
	}
	return o.ConsentRequest, true
}

// HasConsentRequest returns a boolean if a field has been set.
func (o *OAuth2ConsentSession) HasConsentRequest() bool {
	if o != nil && !IsNil(o.ConsentRequest) {
		return true
	}

	return false
}

// SetConsentRequest gets a reference to the given OAuth2ConsentRequest and assigns it to the ConsentRequest field.
func (o *OAuth2ConsentSession) SetConsentRequest(v OAuth2ConsentRequest) {
	o.ConsentRequest = &v
}

// GetContext returns the Context field value if set, zero value otherwise.
func (o *OAuth2ConsentSession) GetContext() map[string]interface{} {
	if o == nil || IsNil(o.Context) {
		var ret map[string]interface{}
		return ret
	}
	return o.Context
}

// GetContextOk returns a tuple with the Context field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSession) GetContextOk() (map[string]interface{}, bool) {
	if o == nil || IsNil(o.Context) {
		return map[string]interface{}{}, false
	}
	return o.Context, true
}

// HasContext returns a boolean if a field has been set.
func (o *OAuth2ConsentSession) HasContext() bool {
	if o != nil && !IsNil(o.Context) {
		return true
	}

	return false
}

// SetContext gets a reference to the given map[string]interface{} and assigns it to the Context field.
func (o *OAuth2ConsentSession) SetContext(v map[string]interface{}) {
	o.Context = v
}

// GetExpiresAt returns the ExpiresAt field value if set, zero value otherwise.
func (o *OAuth2ConsentSession) GetExpiresAt() OAuth2ConsentSessionExpiresAt {
	if o == nil || IsNil(o.ExpiresAt) {
		var ret OAuth2ConsentSessionExpiresAt
		return ret
	}
	return *o.ExpiresAt
}

// GetExpiresAtOk returns a tuple with the ExpiresAt field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSession) GetExpiresAtOk() (*OAuth2ConsentSessionExpiresAt, bool) {
	if o == nil || IsNil(o.ExpiresAt) {
		return nil, false
	}
	return o.ExpiresAt, true
}

// HasExpiresAt returns a boolean if a field has been set.
func (o *OAuth2ConsentSession) HasExpiresAt() bool {
	if o != nil && !IsNil(o.ExpiresAt) {
		return true
	}

	return false
}

// SetExpiresAt gets a reference to the given OAuth2ConsentSessionExpiresAt and assigns it to the ExpiresAt field.
func (o *OAuth2ConsentSession) SetExpiresAt(v OAuth2ConsentSessionExpiresAt) {
	o.ExpiresAt = &v
}

// GetGrantAccessTokenAudience returns the GrantAccessTokenAudience field value if set, zero value otherwise.
func (o *OAuth2ConsentSession) GetGrantAccessTokenAudience() []string {
	if o == nil || IsNil(o.GrantAccessTokenAudience) {
		var ret []string
		return ret
	}
	return o.GrantAccessTokenAudience
}

// GetGrantAccessTokenAudienceOk returns a tuple with the GrantAccessTokenAudience field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSession) GetGrantAccessTokenAudienceOk() ([]string, bool) {
	if o == nil || IsNil(o.GrantAccessTokenAudience) {
		return nil, false
	}
	return o.GrantAccessTokenAudience, true
}

// HasGrantAccessTokenAudience returns a boolean if a field has been set.
func (o *OAuth2ConsentSession) HasGrantAccessTokenAudience() bool {
	if o != nil && !IsNil(o.GrantAccessTokenAudience) {
		return true
	}

	return false
}

// SetGrantAccessTokenAudience gets a reference to the given []string and assigns it to the GrantAccessTokenAudience field.
func (o *OAuth2ConsentSession) SetGrantAccessTokenAudience(v []string) {
	o.GrantAccessTokenAudience = v
}

// GetGrantScope returns the GrantScope field value if set, zero value otherwise.
func (o *OAuth2ConsentSession) GetGrantScope() []string {
	if o == nil || IsNil(o.GrantScope) {
		var ret []string
		return ret
	}
	return o.GrantScope
}

// GetGrantScopeOk returns a tuple with the GrantScope field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSession) GetGrantScopeOk() ([]string, bool) {
	if o == nil || IsNil(o.GrantScope) {
		return nil, false
	}
	return o.GrantScope, true
}

// HasGrantScope returns a boolean if a field has been set.
func (o *OAuth2ConsentSession) HasGrantScope() bool {
	if o != nil && !IsNil(o.GrantScope) {
		return true
	}

	return false
}

// SetGrantScope gets a reference to the given []string and assigns it to the GrantScope field.
func (o *OAuth2ConsentSession) SetGrantScope(v []string) {
	o.GrantScope = v
}

// GetHandledAt returns the HandledAt field value if set, zero value otherwise.
func (o *OAuth2ConsentSession) GetHandledAt() time.Time {
	if o == nil || IsNil(o.HandledAt) {
		var ret time.Time
		return ret
	}
	return *o.HandledAt
}

// GetHandledAtOk returns a tuple with the HandledAt field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSession) GetHandledAtOk() (*time.Time, bool) {
	if o == nil || IsNil(o.HandledAt) {
		return nil, false
	}
	return o.HandledAt, true
}

// HasHandledAt returns a boolean if a field has been set.
func (o *OAuth2ConsentSession) HasHandledAt() bool {
	if o != nil && !IsNil(o.HandledAt) {
		return true
	}

	return false
}

// SetHandledAt gets a reference to the given time.Time and assigns it to the HandledAt field.
func (o *OAuth2ConsentSession) SetHandledAt(v time.Time) {
	o.HandledAt = &v
}

// GetRemember returns the Remember field value if set, zero value otherwise.
func (o *OAuth2ConsentSession) GetRemember() bool {
	if o == nil || IsNil(o.Remember) {
		var ret bool
		return ret
	}
	return *o.Remember
}

// GetRememberOk returns a tuple with the Remember field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSession) GetRememberOk() (*bool, bool) {
	if o == nil || IsNil(o.Remember) {
		return nil, false
	}
	return o.Remember, true
}

// HasRemember returns a boolean if a field has been set.
func (o *OAuth2ConsentSession) HasRemember() bool {
	if o != nil && !IsNil(o.Remember) {
		return true
	}

	return false
}

// SetRemember gets a reference to the given bool and assigns it to the Remember field.
func (o *OAuth2ConsentSession) SetRemember(v bool) {
	o.Remember = &v
}

// GetRememberFor returns the RememberFor field value if set, zero value otherwise.
func (o *OAuth2ConsentSession) GetRememberFor() int64 {
	if o == nil || IsNil(o.RememberFor) {
		var ret int64
		return ret
	}
	return *o.RememberFor
}

// GetRememberForOk returns a tuple with the RememberFor field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSession) GetRememberForOk() (*int64, bool) {
	if o == nil || IsNil(o.RememberFor) {
		return nil, false
	}
	return o.RememberFor, true
}

// HasRememberFor returns a boolean if a field has been set.
func (o *OAuth2ConsentSession) HasRememberFor() bool {
	if o != nil && !IsNil(o.RememberFor) {
		return true
	}

	return false
}

// SetRememberFor gets a reference to the given int64 and assigns it to the RememberFor field.
func (o *OAuth2ConsentSession) SetRememberFor(v int64) {
	o.RememberFor = &v
}

// GetSession returns the Session field value if set, zero value otherwise.
func (o *OAuth2ConsentSession) GetSession() AcceptOAuth2ConsentRequestSession {
	if o == nil || IsNil(o.Session) {
		var ret AcceptOAuth2ConsentRequestSession
		return ret
	}
	return *o.Session
}

// GetSessionOk returns a tuple with the Session field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSession) GetSessionOk() (*AcceptOAuth2ConsentRequestSession, bool) {
	if o == nil || IsNil(o.Session) {
		return nil, false
	}
	return o.Session, true
}

// HasSession returns a boolean if a field has been set.
func (o *OAuth2ConsentSession) HasSession() bool {
	if o != nil && !IsNil(o.Session) {
		return true
	}

	return false
}

// SetSession gets a reference to the given AcceptOAuth2ConsentRequestSession and assigns it to the Session field.
func (o *OAuth2ConsentSession) SetSession(v AcceptOAuth2ConsentRequestSession) {
	o.Session = &v
}

func (o OAuth2ConsentSession) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o OAuth2ConsentSession) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.ConsentRequest) {
		toSerialize["consent_request"] = o.ConsentRequest
	}
	if !IsNil(o.Context) {
		toSerialize["context"] = o.Context
	}
	if !IsNil(o.ExpiresAt) {
		toSerialize["expires_at"] = o.ExpiresAt
	}
	if !IsNil(o.GrantAccessTokenAudience) {
		toSerialize["grant_access_token_audience"] = o.GrantAccessTokenAudience
	}
	if !IsNil(o.GrantScope) {
		toSerialize["grant_scope"] = o.GrantScope
	}
	if !IsNil(o.HandledAt) {
		toSerialize["handled_at"] = o.HandledAt
	}
	if !IsNil(o.Remember) {
		toSerialize["remember"] = o.Remember
	}
	if !IsNil(o.RememberFor) {
		toSerialize["remember_for"] = o.RememberFor
	}
	if !IsNil(o.Session) {
		toSerialize["session"] = o.Session
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *OAuth2ConsentSession) UnmarshalJSON(data []byte) (err error) {
	varOAuth2ConsentSession := _OAuth2ConsentSession{}

	err = json.Unmarshal(data, &varOAuth2ConsentSession)

	if err != nil {
		return err
	}

	*o = OAuth2ConsentSession(varOAuth2ConsentSession)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "consent_request")
		delete(additionalProperties, "context")
		delete(additionalProperties, "expires_at")
		delete(additionalProperties, "grant_access_token_audience")
		delete(additionalProperties, "grant_scope")
		delete(additionalProperties, "handled_at")
		delete(additionalProperties, "remember")
		delete(additionalProperties, "remember_for")
		delete(additionalProperties, "session")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableOAuth2ConsentSession struct {
	value *OAuth2ConsentSession
	isSet bool
}

func (v NullableOAuth2ConsentSession) Get() *OAuth2ConsentSession {
	return v.value
}

func (v *NullableOAuth2ConsentSession) Set(val *OAuth2ConsentSession) {
	v.value = val
	v.isSet = true
}

func (v NullableOAuth2ConsentSession) IsSet() bool {
	return v.isSet
}

func (v *NullableOAuth2ConsentSession) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableOAuth2ConsentSession(val *OAuth2ConsentSession) *NullableOAuth2ConsentSession {
	return &NullableOAuth2ConsentSession{value: val, isSet: true}
}

func (v NullableOAuth2ConsentSession) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableOAuth2ConsentSession) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}



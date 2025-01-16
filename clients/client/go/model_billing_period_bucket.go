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
)

// checks if the BillingPeriodBucket type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &BillingPeriodBucket{}

// BillingPeriodBucket struct for BillingPeriodBucket
type BillingPeriodBucket struct {
	BaseInvoices []Invoice `json:"base_invoices,omitempty"`
	BillingPeriod *TimeInterval `json:"billing_period,omitempty"`
	UsageInvoice *Invoice `json:"usage_invoice,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _BillingPeriodBucket BillingPeriodBucket

// NewBillingPeriodBucket instantiates a new BillingPeriodBucket object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewBillingPeriodBucket() *BillingPeriodBucket {
	this := BillingPeriodBucket{}
	return &this
}

// NewBillingPeriodBucketWithDefaults instantiates a new BillingPeriodBucket object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewBillingPeriodBucketWithDefaults() *BillingPeriodBucket {
	this := BillingPeriodBucket{}
	return &this
}

// GetBaseInvoices returns the BaseInvoices field value if set, zero value otherwise.
func (o *BillingPeriodBucket) GetBaseInvoices() []Invoice {
	if o == nil || IsNil(o.BaseInvoices) {
		var ret []Invoice
		return ret
	}
	return o.BaseInvoices
}

// GetBaseInvoicesOk returns a tuple with the BaseInvoices field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *BillingPeriodBucket) GetBaseInvoicesOk() ([]Invoice, bool) {
	if o == nil || IsNil(o.BaseInvoices) {
		return nil, false
	}
	return o.BaseInvoices, true
}

// HasBaseInvoices returns a boolean if a field has been set.
func (o *BillingPeriodBucket) HasBaseInvoices() bool {
	if o != nil && !IsNil(o.BaseInvoices) {
		return true
	}

	return false
}

// SetBaseInvoices gets a reference to the given []Invoice and assigns it to the BaseInvoices field.
func (o *BillingPeriodBucket) SetBaseInvoices(v []Invoice) {
	o.BaseInvoices = v
}

// GetBillingPeriod returns the BillingPeriod field value if set, zero value otherwise.
func (o *BillingPeriodBucket) GetBillingPeriod() TimeInterval {
	if o == nil || IsNil(o.BillingPeriod) {
		var ret TimeInterval
		return ret
	}
	return *o.BillingPeriod
}

// GetBillingPeriodOk returns a tuple with the BillingPeriod field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *BillingPeriodBucket) GetBillingPeriodOk() (*TimeInterval, bool) {
	if o == nil || IsNil(o.BillingPeriod) {
		return nil, false
	}
	return o.BillingPeriod, true
}

// HasBillingPeriod returns a boolean if a field has been set.
func (o *BillingPeriodBucket) HasBillingPeriod() bool {
	if o != nil && !IsNil(o.BillingPeriod) {
		return true
	}

	return false
}

// SetBillingPeriod gets a reference to the given TimeInterval and assigns it to the BillingPeriod field.
func (o *BillingPeriodBucket) SetBillingPeriod(v TimeInterval) {
	o.BillingPeriod = &v
}

// GetUsageInvoice returns the UsageInvoice field value if set, zero value otherwise.
func (o *BillingPeriodBucket) GetUsageInvoice() Invoice {
	if o == nil || IsNil(o.UsageInvoice) {
		var ret Invoice
		return ret
	}
	return *o.UsageInvoice
}

// GetUsageInvoiceOk returns a tuple with the UsageInvoice field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *BillingPeriodBucket) GetUsageInvoiceOk() (*Invoice, bool) {
	if o == nil || IsNil(o.UsageInvoice) {
		return nil, false
	}
	return o.UsageInvoice, true
}

// HasUsageInvoice returns a boolean if a field has been set.
func (o *BillingPeriodBucket) HasUsageInvoice() bool {
	if o != nil && !IsNil(o.UsageInvoice) {
		return true
	}

	return false
}

// SetUsageInvoice gets a reference to the given Invoice and assigns it to the UsageInvoice field.
func (o *BillingPeriodBucket) SetUsageInvoice(v Invoice) {
	o.UsageInvoice = &v
}

func (o BillingPeriodBucket) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o BillingPeriodBucket) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.BaseInvoices) {
		toSerialize["base_invoices"] = o.BaseInvoices
	}
	if !IsNil(o.BillingPeriod) {
		toSerialize["billing_period"] = o.BillingPeriod
	}
	if !IsNil(o.UsageInvoice) {
		toSerialize["usage_invoice"] = o.UsageInvoice
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *BillingPeriodBucket) UnmarshalJSON(data []byte) (err error) {
	varBillingPeriodBucket := _BillingPeriodBucket{}

	err = json.Unmarshal(data, &varBillingPeriodBucket)

	if err != nil {
		return err
	}

	*o = BillingPeriodBucket(varBillingPeriodBucket)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "base_invoices")
		delete(additionalProperties, "billing_period")
		delete(additionalProperties, "usage_invoice")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableBillingPeriodBucket struct {
	value *BillingPeriodBucket
	isSet bool
}

func (v NullableBillingPeriodBucket) Get() *BillingPeriodBucket {
	return v.value
}

func (v *NullableBillingPeriodBucket) Set(val *BillingPeriodBucket) {
	v.value = val
	v.isSet = true
}

func (v NullableBillingPeriodBucket) IsSet() bool {
	return v.isSet
}

func (v *NullableBillingPeriodBucket) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableBillingPeriodBucket(val *BillingPeriodBucket) *NullableBillingPeriodBucket {
	return &NullableBillingPeriodBucket{value: val, isSet: true}
}

func (v NullableBillingPeriodBucket) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableBillingPeriodBucket) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}



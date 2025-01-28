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
	"time"
	"fmt"
)

// checks if the Subscription type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &Subscription{}

// Subscription struct for Subscription
type Subscription struct {
	CreatedAt time.Time `json:"created_at"`
	// The currency of the subscription. To change this, a new subscription must be created. usd USD eur Euro
	Currency string `json:"currency"`
	// The currently active interval of the subscription monthly Monthly yearly Yearly
	CurrentInterval string `json:"current_interval"`
	// The currently active plan of the subscription
	CurrentPlan string `json:"current_plan"`
	CurrentPlanDetails *PlanDetails `json:"current_plan_details,omitempty"`
	// The ID of the stripe customer
	CustomerId string `json:"customer_id"`
	// The ID of the subscription
	Id string `json:"id"`
	IntervalChangesTo NullableString `json:"interval_changes_to"`
	OngoingStripeCheckoutId NullableString `json:"ongoing_stripe_checkout_id,omitempty"`
	// Until when the subscription is payed
	PayedUntil time.Time `json:"payed_until"`
	PlanChangesAt *time.Time `json:"plan_changes_at,omitempty"`
	PlanChangesTo NullableString `json:"plan_changes_to"`
	// For `collection_method=charge_automatically` a subscription moves into `incomplete` if the initial payment attempt fails. A subscription in this status can only have metadata and default_source updated. Once the first invoice is paid, the subscription moves into an `active` status. If the first invoice is not paid within 23 hours, the subscription transitions to `incomplete_expired`. This is a terminal status, the open invoice will be voided and no further invoices will be generated.  A subscription that is currently in a trial period is `trialing` and moves to `active` when the trial period is over.  A subscription can only enter a `paused` status [when a trial ends without a payment method](https://stripe.com/billing/subscriptions/trials#create-free-trials-without-payment). A `paused` subscription doesn't generate invoices and can be resumed after your customer adds their payment method. The `paused` status is different from [pausing collection](https://stripe.com/billing/subscriptions/pause-payment), which still generates invoices and leaves the subscription's status unchanged.  If subscription `collection_method=charge_automatically`, it becomes `past_due` when payment is required but cannot be paid (due to failed payment or awaiting additional user actions). Once Stripe has exhausted all payment retry attempts, the subscription will become `canceled` or `unpaid` (depending on your subscriptions settings).  If subscription `collection_method=send_invoice` it becomes `past_due` when its invoice is not paid by the due date, and `canceled` or `unpaid` if it is still not paid by an additional deadline after that. Note that when a subscription has a status of `unpaid`, no subsequent invoices will be attempted (invoices will be created, but then immediately automatically closed). After receiving updated payment information from a customer, you may choose to reopen and pay their closed invoices.
	Status string `json:"status"`
	StripeCheckoutExpiresAt *time.Time `json:"stripe_checkout_expires_at,omitempty"`
	UpdatedAt time.Time `json:"updated_at"`
	AdditionalProperties map[string]interface{}
}

type _Subscription Subscription

// NewSubscription instantiates a new Subscription object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewSubscription(createdAt time.Time, currency string, currentInterval string, currentPlan string, customerId string, id string, intervalChangesTo NullableString, payedUntil time.Time, planChangesTo NullableString, status string, updatedAt time.Time) *Subscription {
	this := Subscription{}
	this.CreatedAt = createdAt
	this.Currency = currency
	this.CurrentInterval = currentInterval
	this.CurrentPlan = currentPlan
	this.CustomerId = customerId
	this.Id = id
	this.IntervalChangesTo = intervalChangesTo
	this.PayedUntil = payedUntil
	this.PlanChangesTo = planChangesTo
	this.Status = status
	this.UpdatedAt = updatedAt
	return &this
}

// NewSubscriptionWithDefaults instantiates a new Subscription object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewSubscriptionWithDefaults() *Subscription {
	this := Subscription{}
	return &this
}

// GetCreatedAt returns the CreatedAt field value
func (o *Subscription) GetCreatedAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.CreatedAt
}

// GetCreatedAtOk returns a tuple with the CreatedAt field value
// and a boolean to check if the value has been set.
func (o *Subscription) GetCreatedAtOk() (*time.Time, bool) {
	if o == nil {
		return nil, false
	}
	return &o.CreatedAt, true
}

// SetCreatedAt sets field value
func (o *Subscription) SetCreatedAt(v time.Time) {
	o.CreatedAt = v
}

// GetCurrency returns the Currency field value
func (o *Subscription) GetCurrency() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Currency
}

// GetCurrencyOk returns a tuple with the Currency field value
// and a boolean to check if the value has been set.
func (o *Subscription) GetCurrencyOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Currency, true
}

// SetCurrency sets field value
func (o *Subscription) SetCurrency(v string) {
	o.Currency = v
}

// GetCurrentInterval returns the CurrentInterval field value
func (o *Subscription) GetCurrentInterval() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.CurrentInterval
}

// GetCurrentIntervalOk returns a tuple with the CurrentInterval field value
// and a boolean to check if the value has been set.
func (o *Subscription) GetCurrentIntervalOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.CurrentInterval, true
}

// SetCurrentInterval sets field value
func (o *Subscription) SetCurrentInterval(v string) {
	o.CurrentInterval = v
}

// GetCurrentPlan returns the CurrentPlan field value
func (o *Subscription) GetCurrentPlan() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.CurrentPlan
}

// GetCurrentPlanOk returns a tuple with the CurrentPlan field value
// and a boolean to check if the value has been set.
func (o *Subscription) GetCurrentPlanOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.CurrentPlan, true
}

// SetCurrentPlan sets field value
func (o *Subscription) SetCurrentPlan(v string) {
	o.CurrentPlan = v
}

// GetCurrentPlanDetails returns the CurrentPlanDetails field value if set, zero value otherwise.
func (o *Subscription) GetCurrentPlanDetails() PlanDetails {
	if o == nil || IsNil(o.CurrentPlanDetails) {
		var ret PlanDetails
		return ret
	}
	return *o.CurrentPlanDetails
}

// GetCurrentPlanDetailsOk returns a tuple with the CurrentPlanDetails field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Subscription) GetCurrentPlanDetailsOk() (*PlanDetails, bool) {
	if o == nil || IsNil(o.CurrentPlanDetails) {
		return nil, false
	}
	return o.CurrentPlanDetails, true
}

// HasCurrentPlanDetails returns a boolean if a field has been set.
func (o *Subscription) HasCurrentPlanDetails() bool {
	if o != nil && !IsNil(o.CurrentPlanDetails) {
		return true
	}

	return false
}

// SetCurrentPlanDetails gets a reference to the given PlanDetails and assigns it to the CurrentPlanDetails field.
func (o *Subscription) SetCurrentPlanDetails(v PlanDetails) {
	o.CurrentPlanDetails = &v
}

// GetCustomerId returns the CustomerId field value
func (o *Subscription) GetCustomerId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.CustomerId
}

// GetCustomerIdOk returns a tuple with the CustomerId field value
// and a boolean to check if the value has been set.
func (o *Subscription) GetCustomerIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.CustomerId, true
}

// SetCustomerId sets field value
func (o *Subscription) SetCustomerId(v string) {
	o.CustomerId = v
}

// GetId returns the Id field value
func (o *Subscription) GetId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Id
}

// GetIdOk returns a tuple with the Id field value
// and a boolean to check if the value has been set.
func (o *Subscription) GetIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Id, true
}

// SetId sets field value
func (o *Subscription) SetId(v string) {
	o.Id = v
}

// GetIntervalChangesTo returns the IntervalChangesTo field value
// If the value is explicit nil, the zero value for string will be returned
func (o *Subscription) GetIntervalChangesTo() string {
	if o == nil || o.IntervalChangesTo.Get() == nil {
		var ret string
		return ret
	}

	return *o.IntervalChangesTo.Get()
}

// GetIntervalChangesToOk returns a tuple with the IntervalChangesTo field value
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *Subscription) GetIntervalChangesToOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.IntervalChangesTo.Get(), o.IntervalChangesTo.IsSet()
}

// SetIntervalChangesTo sets field value
func (o *Subscription) SetIntervalChangesTo(v string) {
	o.IntervalChangesTo.Set(&v)
}

// GetOngoingStripeCheckoutId returns the OngoingStripeCheckoutId field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *Subscription) GetOngoingStripeCheckoutId() string {
	if o == nil || IsNil(o.OngoingStripeCheckoutId.Get()) {
		var ret string
		return ret
	}
	return *o.OngoingStripeCheckoutId.Get()
}

// GetOngoingStripeCheckoutIdOk returns a tuple with the OngoingStripeCheckoutId field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *Subscription) GetOngoingStripeCheckoutIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.OngoingStripeCheckoutId.Get(), o.OngoingStripeCheckoutId.IsSet()
}

// HasOngoingStripeCheckoutId returns a boolean if a field has been set.
func (o *Subscription) HasOngoingStripeCheckoutId() bool {
	if o != nil && o.OngoingStripeCheckoutId.IsSet() {
		return true
	}

	return false
}

// SetOngoingStripeCheckoutId gets a reference to the given NullableString and assigns it to the OngoingStripeCheckoutId field.
func (o *Subscription) SetOngoingStripeCheckoutId(v string) {
	o.OngoingStripeCheckoutId.Set(&v)
}
// SetOngoingStripeCheckoutIdNil sets the value for OngoingStripeCheckoutId to be an explicit nil
func (o *Subscription) SetOngoingStripeCheckoutIdNil() {
	o.OngoingStripeCheckoutId.Set(nil)
}

// UnsetOngoingStripeCheckoutId ensures that no value is present for OngoingStripeCheckoutId, not even an explicit nil
func (o *Subscription) UnsetOngoingStripeCheckoutId() {
	o.OngoingStripeCheckoutId.Unset()
}

// GetPayedUntil returns the PayedUntil field value
func (o *Subscription) GetPayedUntil() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.PayedUntil
}

// GetPayedUntilOk returns a tuple with the PayedUntil field value
// and a boolean to check if the value has been set.
func (o *Subscription) GetPayedUntilOk() (*time.Time, bool) {
	if o == nil {
		return nil, false
	}
	return &o.PayedUntil, true
}

// SetPayedUntil sets field value
func (o *Subscription) SetPayedUntil(v time.Time) {
	o.PayedUntil = v
}

// GetPlanChangesAt returns the PlanChangesAt field value if set, zero value otherwise.
func (o *Subscription) GetPlanChangesAt() time.Time {
	if o == nil || IsNil(o.PlanChangesAt) {
		var ret time.Time
		return ret
	}
	return *o.PlanChangesAt
}

// GetPlanChangesAtOk returns a tuple with the PlanChangesAt field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Subscription) GetPlanChangesAtOk() (*time.Time, bool) {
	if o == nil || IsNil(o.PlanChangesAt) {
		return nil, false
	}
	return o.PlanChangesAt, true
}

// HasPlanChangesAt returns a boolean if a field has been set.
func (o *Subscription) HasPlanChangesAt() bool {
	if o != nil && !IsNil(o.PlanChangesAt) {
		return true
	}

	return false
}

// SetPlanChangesAt gets a reference to the given time.Time and assigns it to the PlanChangesAt field.
func (o *Subscription) SetPlanChangesAt(v time.Time) {
	o.PlanChangesAt = &v
}

// GetPlanChangesTo returns the PlanChangesTo field value
// If the value is explicit nil, the zero value for string will be returned
func (o *Subscription) GetPlanChangesTo() string {
	if o == nil || o.PlanChangesTo.Get() == nil {
		var ret string
		return ret
	}

	return *o.PlanChangesTo.Get()
}

// GetPlanChangesToOk returns a tuple with the PlanChangesTo field value
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *Subscription) GetPlanChangesToOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.PlanChangesTo.Get(), o.PlanChangesTo.IsSet()
}

// SetPlanChangesTo sets field value
func (o *Subscription) SetPlanChangesTo(v string) {
	o.PlanChangesTo.Set(&v)
}

// GetStatus returns the Status field value
func (o *Subscription) GetStatus() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Status
}

// GetStatusOk returns a tuple with the Status field value
// and a boolean to check if the value has been set.
func (o *Subscription) GetStatusOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Status, true
}

// SetStatus sets field value
func (o *Subscription) SetStatus(v string) {
	o.Status = v
}

// GetStripeCheckoutExpiresAt returns the StripeCheckoutExpiresAt field value if set, zero value otherwise.
func (o *Subscription) GetStripeCheckoutExpiresAt() time.Time {
	if o == nil || IsNil(o.StripeCheckoutExpiresAt) {
		var ret time.Time
		return ret
	}
	return *o.StripeCheckoutExpiresAt
}

// GetStripeCheckoutExpiresAtOk returns a tuple with the StripeCheckoutExpiresAt field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Subscription) GetStripeCheckoutExpiresAtOk() (*time.Time, bool) {
	if o == nil || IsNil(o.StripeCheckoutExpiresAt) {
		return nil, false
	}
	return o.StripeCheckoutExpiresAt, true
}

// HasStripeCheckoutExpiresAt returns a boolean if a field has been set.
func (o *Subscription) HasStripeCheckoutExpiresAt() bool {
	if o != nil && !IsNil(o.StripeCheckoutExpiresAt) {
		return true
	}

	return false
}

// SetStripeCheckoutExpiresAt gets a reference to the given time.Time and assigns it to the StripeCheckoutExpiresAt field.
func (o *Subscription) SetStripeCheckoutExpiresAt(v time.Time) {
	o.StripeCheckoutExpiresAt = &v
}

// GetUpdatedAt returns the UpdatedAt field value
func (o *Subscription) GetUpdatedAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.UpdatedAt
}

// GetUpdatedAtOk returns a tuple with the UpdatedAt field value
// and a boolean to check if the value has been set.
func (o *Subscription) GetUpdatedAtOk() (*time.Time, bool) {
	if o == nil {
		return nil, false
	}
	return &o.UpdatedAt, true
}

// SetUpdatedAt sets field value
func (o *Subscription) SetUpdatedAt(v time.Time) {
	o.UpdatedAt = v
}

func (o Subscription) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o Subscription) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["created_at"] = o.CreatedAt
	toSerialize["currency"] = o.Currency
	toSerialize["current_interval"] = o.CurrentInterval
	toSerialize["current_plan"] = o.CurrentPlan
	if !IsNil(o.CurrentPlanDetails) {
		toSerialize["current_plan_details"] = o.CurrentPlanDetails
	}
	toSerialize["customer_id"] = o.CustomerId
	toSerialize["id"] = o.Id
	toSerialize["interval_changes_to"] = o.IntervalChangesTo.Get()
	if o.OngoingStripeCheckoutId.IsSet() {
		toSerialize["ongoing_stripe_checkout_id"] = o.OngoingStripeCheckoutId.Get()
	}
	toSerialize["payed_until"] = o.PayedUntil
	if !IsNil(o.PlanChangesAt) {
		toSerialize["plan_changes_at"] = o.PlanChangesAt
	}
	toSerialize["plan_changes_to"] = o.PlanChangesTo.Get()
	toSerialize["status"] = o.Status
	if !IsNil(o.StripeCheckoutExpiresAt) {
		toSerialize["stripe_checkout_expires_at"] = o.StripeCheckoutExpiresAt
	}
	toSerialize["updated_at"] = o.UpdatedAt

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *Subscription) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"created_at",
		"currency",
		"current_interval",
		"current_plan",
		"customer_id",
		"id",
		"interval_changes_to",
		"payed_until",
		"plan_changes_to",
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

	varSubscription := _Subscription{}

	err = json.Unmarshal(data, &varSubscription)

	if err != nil {
		return err
	}

	*o = Subscription(varSubscription)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "created_at")
		delete(additionalProperties, "currency")
		delete(additionalProperties, "current_interval")
		delete(additionalProperties, "current_plan")
		delete(additionalProperties, "current_plan_details")
		delete(additionalProperties, "customer_id")
		delete(additionalProperties, "id")
		delete(additionalProperties, "interval_changes_to")
		delete(additionalProperties, "ongoing_stripe_checkout_id")
		delete(additionalProperties, "payed_until")
		delete(additionalProperties, "plan_changes_at")
		delete(additionalProperties, "plan_changes_to")
		delete(additionalProperties, "status")
		delete(additionalProperties, "stripe_checkout_expires_at")
		delete(additionalProperties, "updated_at")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableSubscription struct {
	value *Subscription
	isSet bool
}

func (v NullableSubscription) Get() *Subscription {
	return v.value
}

func (v *NullableSubscription) Set(val *Subscription) {
	v.value = val
	v.isSet = true
}

func (v NullableSubscription) IsSet() bool {
	return v.isSet
}

func (v *NullableSubscription) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSubscription(val *Subscription) *NullableSubscription {
	return &NullableSubscription{value: val, isSet: true}
}

func (v NullableSubscription) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSubscription) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}



/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.51
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// ClientSubscription
    /// </summary>
    [DataContract(Name = "subscription")]
    public partial class ClientSubscription : IEquatable<ClientSubscription>, IValidatableObject
    {
        /// <summary>
        /// The currently active plan of the subscription
        /// </summary>
        /// <value>The currently active plan of the subscription</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrentPlanEnum
        {
            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum Free for value: free
            /// </summary>
            [EnumMember(Value = "free")]
            Free = 2,

            /// <summary>
            /// Enum StartUpMonthly for value: start_up_monthly
            /// </summary>
            [EnumMember(Value = "start_up_monthly")]
            StartUpMonthly = 3,

            /// <summary>
            /// Enum StartUpYearly for value: start_up_yearly
            /// </summary>
            [EnumMember(Value = "start_up_yearly")]
            StartUpYearly = 4,

            /// <summary>
            /// Enum Custom for value: custom
            /// </summary>
            [EnumMember(Value = "custom")]
            Custom = 5

        }


        /// <summary>
        /// The currently active plan of the subscription
        /// </summary>
        /// <value>The currently active plan of the subscription</value>
        [DataMember(Name = "current_plan", IsRequired = true, EmitDefaultValue = false)]
        public CurrentPlanEnum CurrentPlan { get; set; }

        /// <summary>
        /// Returns false as CurrentPlan should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrentPlan()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSubscription()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubscription" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="ongoingStripeCheckoutId">ongoingStripeCheckoutId.</param>
        /// <param name="planChangesAt">planChangesAt.</param>
        /// <param name="planChangesTo">planChangesTo (required).</param>
        /// <param name="status">status (required).</param>
        public ClientSubscription(string id = default(string), string ongoingStripeCheckoutId = default(string), DateTime planChangesAt = default(DateTime), ClientNullPlan planChangesTo = default(ClientNullPlan), string status = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ClientSubscription and cannot be null");
            }
            this.Id = id;
            // to ensure "planChangesTo" is required (not null)
            if (planChangesTo == null) {
                throw new ArgumentNullException("planChangesTo is a required property for ClientSubscription and cannot be null");
            }
            this.PlanChangesTo = planChangesTo;
            // to ensure "status" is required (not null)
            if (status == null) {
                throw new ArgumentNullException("status is a required property for ClientSubscription and cannot be null");
            }
            this.Status = status;
            this.OngoingStripeCheckoutId = ongoingStripeCheckoutId;
            this.PlanChangesAt = planChangesAt;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// The ID of the stripe customer
        /// </summary>
        /// <value>The ID of the stripe customer</value>
        [DataMember(Name = "customer_id", IsRequired = true, EmitDefaultValue = false)]
        public string CustomerId { get; private set; }

        /// <summary>
        /// Returns false as CustomerId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomerId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets OngoingStripeCheckoutId
        /// </summary>
        [DataMember(Name = "ongoing_stripe_checkout_id", EmitDefaultValue = false)]
        public string OngoingStripeCheckoutId { get; set; }

        /// <summary>
        /// Until when the subscription is payed
        /// </summary>
        /// <value>Until when the subscription is payed</value>
        [DataMember(Name = "payed_until", IsRequired = true, EmitDefaultValue = false)]
        public DateTime PayedUntil { get; private set; }

        /// <summary>
        /// Returns false as PayedUntil should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePayedUntil()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PlanChangesAt
        /// </summary>
        [DataMember(Name = "plan_changes_at", EmitDefaultValue = false)]
        public DateTime PlanChangesAt { get; set; }

        /// <summary>
        /// Gets or Sets PlanChangesTo
        /// </summary>
        [DataMember(Name = "plan_changes_to", IsRequired = true, EmitDefaultValue = false)]
        public ClientNullPlan PlanChangesTo { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientSubscription {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CurrentPlan: ").Append(CurrentPlan).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OngoingStripeCheckoutId: ").Append(OngoingStripeCheckoutId).Append("\n");
            sb.Append("  PayedUntil: ").Append(PayedUntil).Append("\n");
            sb.Append("  PlanChangesAt: ").Append(PlanChangesAt).Append("\n");
            sb.Append("  PlanChangesTo: ").Append(PlanChangesTo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientSubscription);
        }

        /// <summary>
        /// Returns true if ClientSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSubscription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CurrentPlan == input.CurrentPlan ||
                    this.CurrentPlan.Equals(input.CurrentPlan)
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OngoingStripeCheckoutId == input.OngoingStripeCheckoutId ||
                    (this.OngoingStripeCheckoutId != null &&
                    this.OngoingStripeCheckoutId.Equals(input.OngoingStripeCheckoutId))
                ) && 
                (
                    this.PayedUntil == input.PayedUntil ||
                    (this.PayedUntil != null &&
                    this.PayedUntil.Equals(input.PayedUntil))
                ) && 
                (
                    this.PlanChangesAt == input.PlanChangesAt ||
                    (this.PlanChangesAt != null &&
                    this.PlanChangesAt.Equals(input.PlanChangesAt))
                ) && 
                (
                    this.PlanChangesTo == input.PlanChangesTo ||
                    (this.PlanChangesTo != null &&
                    this.PlanChangesTo.Equals(input.PlanChangesTo))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentPlan.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OngoingStripeCheckoutId != null)
                    hashCode = hashCode * 59 + this.OngoingStripeCheckoutId.GetHashCode();
                if (this.PayedUntil != null)
                    hashCode = hashCode * 59 + this.PayedUntil.GetHashCode();
                if (this.PlanChangesAt != null)
                    hashCode = hashCode * 59 + this.PlanChangesAt.GetHashCode();
                if (this.PlanChangesTo != null)
                    hashCode = hashCode * 59 + this.PlanChangesTo.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

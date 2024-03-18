/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.9.0
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
    /// Update Login flow using the code method
    /// </summary>
    [DataContract(Name = "updateLoginFlowWithCodeMethod")]
    public partial class ClientUpdateLoginFlowWithCodeMethod : IEquatable<ClientUpdateLoginFlowWithCodeMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateLoginFlowWithCodeMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientUpdateLoginFlowWithCodeMethod()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateLoginFlowWithCodeMethod" /> class.
        /// </summary>
        /// <param name="code">Code is the 6 digits code sent to the user.</param>
        /// <param name="csrfToken">CSRFToken is the anti-CSRF token (required).</param>
        /// <param name="identifier">Identifier is the code identifier The identifier requires that the user has already completed the registration or settings with code flow..</param>
        /// <param name="method">Method should be set to \&quot;code\&quot; when logging in using the code strategy. (required).</param>
        /// <param name="resend">Resend is set when the user wants to resend the code.</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks.</param>
        public ClientUpdateLoginFlowWithCodeMethod(string code = default(string), string csrfToken = default(string), string identifier = default(string), string method = default(string), string resend = default(string), Object transientPayload = default(Object))
        {
            // to ensure "csrfToken" is required (not null)
            if (csrfToken == null) {
                throw new ArgumentNullException("csrfToken is a required property for ClientUpdateLoginFlowWithCodeMethod and cannot be null");
            }
            this.CsrfToken = csrfToken;
            // to ensure "method" is required (not null)
            if (method == null) {
                throw new ArgumentNullException("method is a required property for ClientUpdateLoginFlowWithCodeMethod and cannot be null");
            }
            this.Method = method;
            this.Code = code;
            this.Identifier = identifier;
            this.Resend = resend;
            this.TransientPayload = transientPayload;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Code is the 6 digits code sent to the user
        /// </summary>
        /// <value>Code is the 6 digits code sent to the user</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// CSRFToken is the anti-CSRF token
        /// </summary>
        /// <value>CSRFToken is the anti-CSRF token</value>
        [DataMember(Name = "csrf_token", IsRequired = true, EmitDefaultValue = false)]
        public string CsrfToken { get; set; }

        /// <summary>
        /// Identifier is the code identifier The identifier requires that the user has already completed the registration or settings with code flow.
        /// </summary>
        /// <value>Identifier is the code identifier The identifier requires that the user has already completed the registration or settings with code flow.</value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Method should be set to \&quot;code\&quot; when logging in using the code strategy.
        /// </summary>
        /// <value>Method should be set to \&quot;code\&quot; when logging in using the code strategy.</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Resend is set when the user wants to resend the code
        /// </summary>
        /// <value>Resend is set when the user wants to resend the code</value>
        [DataMember(Name = "resend", EmitDefaultValue = false)]
        public string Resend { get; set; }

        /// <summary>
        /// Transient data to pass along to any webhooks
        /// </summary>
        /// <value>Transient data to pass along to any webhooks</value>
        [DataMember(Name = "transient_payload", EmitDefaultValue = false)]
        public Object TransientPayload { get; set; }

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
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientUpdateLoginFlowWithCodeMethod {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Resend: ").Append(Resend).Append("\n");
            sb.Append("  TransientPayload: ").Append(TransientPayload).Append("\n");
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
            return this.Equals(input as ClientUpdateLoginFlowWithCodeMethod);
        }

        /// <summary>
        /// Returns true if ClientUpdateLoginFlowWithCodeMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientUpdateLoginFlowWithCodeMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientUpdateLoginFlowWithCodeMethod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.CsrfToken == input.CsrfToken ||
                    (this.CsrfToken != null &&
                    this.CsrfToken.Equals(input.CsrfToken))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Resend == input.Resend ||
                    (this.Resend != null &&
                    this.Resend.Equals(input.Resend))
                ) && 
                (
                    this.TransientPayload == input.TransientPayload ||
                    (this.TransientPayload != null &&
                    this.TransientPayload.Equals(input.TransientPayload))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.CsrfToken != null)
                {
                    hashCode = (hashCode * 59) + this.CsrfToken.GetHashCode();
                }
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
                }
                if (this.Resend != null)
                {
                    hashCode = (hashCode * 59) + this.Resend.GetHashCode();
                }
                if (this.TransientPayload != null)
                {
                    hashCode = (hashCode * 59) + this.TransientPayload.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

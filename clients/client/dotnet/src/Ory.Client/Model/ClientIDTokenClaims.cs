/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.19
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
    /// IDTokenClaims represent the claims used in open id connect requests
    /// </summary>
    [DataContract(Name = "IDTokenClaims")]
    public partial class ClientIDTokenClaims : IEquatable<ClientIDTokenClaims>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIDTokenClaims" /> class.
        /// </summary>
        /// <param name="acr">acr.</param>
        /// <param name="amr">amr.</param>
        /// <param name="atHash">atHash.</param>
        /// <param name="aud">aud.</param>
        /// <param name="authTime">authTime.</param>
        /// <param name="cHash">cHash.</param>
        /// <param name="exp">exp.</param>
        /// <param name="ext">ext.</param>
        /// <param name="iat">iat.</param>
        /// <param name="iss">iss.</param>
        /// <param name="jti">jti.</param>
        /// <param name="nonce">nonce.</param>
        /// <param name="rat">rat.</param>
        /// <param name="sub">sub.</param>
        public ClientIDTokenClaims(string acr = default(string), List<string> amr = default(List<string>), string atHash = default(string), List<string> aud = default(List<string>), DateTime authTime = default(DateTime), string cHash = default(string), DateTime exp = default(DateTime), Dictionary<string, Object> ext = default(Dictionary<string, Object>), DateTime iat = default(DateTime), string iss = default(string), string jti = default(string), string nonce = default(string), DateTime rat = default(DateTime), string sub = default(string))
        {
            this.Acr = acr;
            this.Amr = amr;
            this.AtHash = atHash;
            this.Aud = aud;
            this.AuthTime = authTime;
            this.CHash = cHash;
            this.Exp = exp;
            this.Ext = ext;
            this.Iat = iat;
            this.Iss = iss;
            this.Jti = jti;
            this.Nonce = nonce;
            this.Rat = rat;
            this.Sub = sub;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Acr
        /// </summary>
        [DataMember(Name = "acr", EmitDefaultValue = false)]
        public string Acr { get; set; }

        /// <summary>
        /// Gets or Sets Amr
        /// </summary>
        [DataMember(Name = "amr", EmitDefaultValue = false)]
        public List<string> Amr { get; set; }

        /// <summary>
        /// Gets or Sets AtHash
        /// </summary>
        [DataMember(Name = "at_hash", EmitDefaultValue = false)]
        public string AtHash { get; set; }

        /// <summary>
        /// Gets or Sets Aud
        /// </summary>
        [DataMember(Name = "aud", EmitDefaultValue = false)]
        public List<string> Aud { get; set; }

        /// <summary>
        /// Gets or Sets AuthTime
        /// </summary>
        [DataMember(Name = "auth_time", EmitDefaultValue = false)]
        public DateTime AuthTime { get; set; }

        /// <summary>
        /// Gets or Sets CHash
        /// </summary>
        [DataMember(Name = "c_hash", EmitDefaultValue = false)]
        public string CHash { get; set; }

        /// <summary>
        /// Gets or Sets Exp
        /// </summary>
        [DataMember(Name = "exp", EmitDefaultValue = false)]
        public DateTime Exp { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name = "ext", EmitDefaultValue = false)]
        public Dictionary<string, Object> Ext { get; set; }

        /// <summary>
        /// Gets or Sets Iat
        /// </summary>
        [DataMember(Name = "iat", EmitDefaultValue = false)]
        public DateTime Iat { get; set; }

        /// <summary>
        /// Gets or Sets Iss
        /// </summary>
        [DataMember(Name = "iss", EmitDefaultValue = false)]
        public string Iss { get; set; }

        /// <summary>
        /// Gets or Sets Jti
        /// </summary>
        [DataMember(Name = "jti", EmitDefaultValue = false)]
        public string Jti { get; set; }

        /// <summary>
        /// Gets or Sets Nonce
        /// </summary>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public string Nonce { get; set; }

        /// <summary>
        /// Gets or Sets Rat
        /// </summary>
        [DataMember(Name = "rat", EmitDefaultValue = false)]
        public DateTime Rat { get; set; }

        /// <summary>
        /// Gets or Sets Sub
        /// </summary>
        [DataMember(Name = "sub", EmitDefaultValue = false)]
        public string Sub { get; set; }

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
            sb.Append("class ClientIDTokenClaims {\n");
            sb.Append("  Acr: ").Append(Acr).Append("\n");
            sb.Append("  Amr: ").Append(Amr).Append("\n");
            sb.Append("  AtHash: ").Append(AtHash).Append("\n");
            sb.Append("  Aud: ").Append(Aud).Append("\n");
            sb.Append("  AuthTime: ").Append(AuthTime).Append("\n");
            sb.Append("  CHash: ").Append(CHash).Append("\n");
            sb.Append("  Exp: ").Append(Exp).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  Iat: ").Append(Iat).Append("\n");
            sb.Append("  Iss: ").Append(Iss).Append("\n");
            sb.Append("  Jti: ").Append(Jti).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Rat: ").Append(Rat).Append("\n");
            sb.Append("  Sub: ").Append(Sub).Append("\n");
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
            return this.Equals(input as ClientIDTokenClaims);
        }

        /// <summary>
        /// Returns true if ClientIDTokenClaims instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientIDTokenClaims to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientIDTokenClaims input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Acr == input.Acr ||
                    (this.Acr != null &&
                    this.Acr.Equals(input.Acr))
                ) && 
                (
                    this.Amr == input.Amr ||
                    this.Amr != null &&
                    input.Amr != null &&
                    this.Amr.SequenceEqual(input.Amr)
                ) && 
                (
                    this.AtHash == input.AtHash ||
                    (this.AtHash != null &&
                    this.AtHash.Equals(input.AtHash))
                ) && 
                (
                    this.Aud == input.Aud ||
                    this.Aud != null &&
                    input.Aud != null &&
                    this.Aud.SequenceEqual(input.Aud)
                ) && 
                (
                    this.AuthTime == input.AuthTime ||
                    (this.AuthTime != null &&
                    this.AuthTime.Equals(input.AuthTime))
                ) && 
                (
                    this.CHash == input.CHash ||
                    (this.CHash != null &&
                    this.CHash.Equals(input.CHash))
                ) && 
                (
                    this.Exp == input.Exp ||
                    (this.Exp != null &&
                    this.Exp.Equals(input.Exp))
                ) && 
                (
                    this.Ext == input.Ext ||
                    this.Ext != null &&
                    input.Ext != null &&
                    this.Ext.SequenceEqual(input.Ext)
                ) && 
                (
                    this.Iat == input.Iat ||
                    (this.Iat != null &&
                    this.Iat.Equals(input.Iat))
                ) && 
                (
                    this.Iss == input.Iss ||
                    (this.Iss != null &&
                    this.Iss.Equals(input.Iss))
                ) && 
                (
                    this.Jti == input.Jti ||
                    (this.Jti != null &&
                    this.Jti.Equals(input.Jti))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.Rat == input.Rat ||
                    (this.Rat != null &&
                    this.Rat.Equals(input.Rat))
                ) && 
                (
                    this.Sub == input.Sub ||
                    (this.Sub != null &&
                    this.Sub.Equals(input.Sub))
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
                if (this.Acr != null)
                {
                    hashCode = (hashCode * 59) + this.Acr.GetHashCode();
                }
                if (this.Amr != null)
                {
                    hashCode = (hashCode * 59) + this.Amr.GetHashCode();
                }
                if (this.AtHash != null)
                {
                    hashCode = (hashCode * 59) + this.AtHash.GetHashCode();
                }
                if (this.Aud != null)
                {
                    hashCode = (hashCode * 59) + this.Aud.GetHashCode();
                }
                if (this.AuthTime != null)
                {
                    hashCode = (hashCode * 59) + this.AuthTime.GetHashCode();
                }
                if (this.CHash != null)
                {
                    hashCode = (hashCode * 59) + this.CHash.GetHashCode();
                }
                if (this.Exp != null)
                {
                    hashCode = (hashCode * 59) + this.Exp.GetHashCode();
                }
                if (this.Ext != null)
                {
                    hashCode = (hashCode * 59) + this.Ext.GetHashCode();
                }
                if (this.Iat != null)
                {
                    hashCode = (hashCode * 59) + this.Iat.GetHashCode();
                }
                if (this.Iss != null)
                {
                    hashCode = (hashCode * 59) + this.Iss.GetHashCode();
                }
                if (this.Jti != null)
                {
                    hashCode = (hashCode * 59) + this.Jti.GetHashCode();
                }
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }
                if (this.Rat != null)
                {
                    hashCode = (hashCode * 59) + this.Rat.GetHashCode();
                }
                if (this.Sub != null)
                {
                    hashCode = (hashCode * 59) + this.Sub.GetHashCode();
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

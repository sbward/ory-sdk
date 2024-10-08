/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.6
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
    /// ClientProjectServices
    /// </summary>
    [DataContract(Name = "projectServices")]
    public partial class ClientProjectServices : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProjectServices" /> class.
        /// </summary>
        /// <param name="identity">identity.</param>
        /// <param name="oauth2">oauth2.</param>
        /// <param name="permission">permission.</param>
        public ClientProjectServices(ClientProjectServiceIdentity identity = default(ClientProjectServiceIdentity), ClientProjectServiceOAuth2 oauth2 = default(ClientProjectServiceOAuth2), ClientProjectServicePermission permission = default(ClientProjectServicePermission))
        {
            this.Identity = identity;
            this.Oauth2 = oauth2;
            this.Permission = permission;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [DataMember(Name = "identity", EmitDefaultValue = false)]
        public ClientProjectServiceIdentity Identity { get; set; }

        /// <summary>
        /// Gets or Sets Oauth2
        /// </summary>
        [DataMember(Name = "oauth2", EmitDefaultValue = false)]
        public ClientProjectServiceOAuth2 Oauth2 { get; set; }

        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name = "permission", EmitDefaultValue = false)]
        public ClientProjectServicePermission Permission { get; set; }

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
            sb.Append("class ClientProjectServices {\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  Oauth2: ").Append(Oauth2).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

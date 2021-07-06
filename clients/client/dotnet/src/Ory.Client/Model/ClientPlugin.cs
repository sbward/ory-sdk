/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.10
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
    /// Plugin A plugin for the Engine API
    /// </summary>
    [DataContract(Name = "Plugin")]
    public partial class ClientPlugin : IEquatable<ClientPlugin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPlugin" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientPlugin()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPlugin" /> class.
        /// </summary>
        /// <param name="config">config (required).</param>
        /// <param name="enabled">True if the plugin is running. False if the plugin is not running, only installed. (required).</param>
        /// <param name="id">Id.</param>
        /// <param name="name">name (required).</param>
        /// <param name="pluginReference">plugin remote reference used to push/pull the plugin.</param>
        /// <param name="settings">settings (required).</param>
        public ClientPlugin(ClientPluginConfig config = default(ClientPluginConfig), bool enabled = default(bool), string id = default(string), string name = default(string), string pluginReference = default(string), ClientPluginSettings settings = default(ClientPluginSettings))
        {
            // to ensure "config" is required (not null)
            this.Config = config ?? throw new ArgumentNullException("config is a required property for ClientPlugin and cannot be null");
            this.Enabled = enabled;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for ClientPlugin and cannot be null");
            // to ensure "settings" is required (not null)
            this.Settings = settings ?? throw new ArgumentNullException("settings is a required property for ClientPlugin and cannot be null");
            this.Id = id;
            this.PluginReference = pluginReference;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "Config", IsRequired = true, EmitDefaultValue = false)]
        public ClientPluginConfig Config { get; set; }

        /// <summary>
        /// True if the plugin is running. False if the plugin is not running, only installed.
        /// </summary>
        /// <value>True if the plugin is running. False if the plugin is not running, only installed.</value>
        [DataMember(Name = "Enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        /// <value>name</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// plugin remote reference used to push/pull the plugin
        /// </summary>
        /// <value>plugin remote reference used to push/pull the plugin</value>
        [DataMember(Name = "PluginReference", EmitDefaultValue = false)]
        public string PluginReference { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "Settings", IsRequired = true, EmitDefaultValue = false)]
        public ClientPluginSettings Settings { get; set; }

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
            sb.Append("class ClientPlugin {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PluginReference: ").Append(PluginReference).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as ClientPlugin);
        }

        /// <summary>
        /// Returns true if ClientPlugin instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientPlugin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientPlugin input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PluginReference == input.PluginReference ||
                    (this.PluginReference != null &&
                    this.PluginReference.Equals(input.PluginReference))
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
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
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PluginReference != null)
                    hashCode = hashCode * 59 + this.PluginReference.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
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

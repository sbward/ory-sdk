/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.25
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.time.OffsetDateTime;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.jackson.nullable.JsonNullable;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;

import sh.ory.JSON;

/**
 * NormalizedProjectRevisionThirdPartyProvider
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2023-04-24T08:24:45.436303324Z[Etc/UTC]")
public class NormalizedProjectRevisionThirdPartyProvider {
  public static final String SERIALIZED_NAME_APPLE_PRIVATE_KEY = "apple_private_key";
  @SerializedName(SERIALIZED_NAME_APPLE_PRIVATE_KEY)
  private String applePrivateKey;

  public static final String SERIALIZED_NAME_APPLE_PRIVATE_KEY_ID = "apple_private_key_id";
  @SerializedName(SERIALIZED_NAME_APPLE_PRIVATE_KEY_ID)
  private String applePrivateKeyId;

  public static final String SERIALIZED_NAME_APPLE_TEAM_ID = "apple_team_id";
  @SerializedName(SERIALIZED_NAME_APPLE_TEAM_ID)
  private String appleTeamId;

  public static final String SERIALIZED_NAME_AUTH_URL = "auth_url";
  @SerializedName(SERIALIZED_NAME_AUTH_URL)
  private String authUrl;

  public static final String SERIALIZED_NAME_AZURE_TENANT = "azure_tenant";
  @SerializedName(SERIALIZED_NAME_AZURE_TENANT)
  private String azureTenant;

  public static final String SERIALIZED_NAME_CLIENT_ID = "client_id";
  @SerializedName(SERIALIZED_NAME_CLIENT_ID)
  private String clientId;

  public static final String SERIALIZED_NAME_CLIENT_SECRET = "client_secret";
  @SerializedName(SERIALIZED_NAME_CLIENT_SECRET)
  private String clientSecret;

  public static final String SERIALIZED_NAME_CREATED_AT = "created_at";
  @SerializedName(SERIALIZED_NAME_CREATED_AT)
  private OffsetDateTime createdAt;

  public static final String SERIALIZED_NAME_ID = "id";
  @SerializedName(SERIALIZED_NAME_ID)
  private String id;

  public static final String SERIALIZED_NAME_ISSUER_URL = "issuer_url";
  @SerializedName(SERIALIZED_NAME_ISSUER_URL)
  private String issuerUrl;

  public static final String SERIALIZED_NAME_LABEL = "label";
  @SerializedName(SERIALIZED_NAME_LABEL)
  private String label;

  public static final String SERIALIZED_NAME_MAPPER_URL = "mapper_url";
  @SerializedName(SERIALIZED_NAME_MAPPER_URL)
  private String mapperUrl;

  public static final String SERIALIZED_NAME_PROJECT_REVISION_ID = "project_revision_id";
  @SerializedName(SERIALIZED_NAME_PROJECT_REVISION_ID)
  private String projectRevisionId;

  public static final String SERIALIZED_NAME_PROVIDER = "provider";
  @SerializedName(SERIALIZED_NAME_PROVIDER)
  private String provider;

  public static final String SERIALIZED_NAME_PROVIDER_ID = "provider_id";
  @SerializedName(SERIALIZED_NAME_PROVIDER_ID)
  private String providerId;

  public static final String SERIALIZED_NAME_REQUESTED_CLAIMS = "requested_claims";
  @SerializedName(SERIALIZED_NAME_REQUESTED_CLAIMS)
  private Object requestedClaims;

  public static final String SERIALIZED_NAME_SCOPE = "scope";
  @SerializedName(SERIALIZED_NAME_SCOPE)
  private List<String> scope = null;

  public static final String SERIALIZED_NAME_SUBJECT_SOURCE = "subject_source";
  @SerializedName(SERIALIZED_NAME_SUBJECT_SOURCE)
  private String subjectSource;

  public static final String SERIALIZED_NAME_TOKEN_URL = "token_url";
  @SerializedName(SERIALIZED_NAME_TOKEN_URL)
  private String tokenUrl;

  public static final String SERIALIZED_NAME_UPDATED_AT = "updated_at";
  @SerializedName(SERIALIZED_NAME_UPDATED_AT)
  private OffsetDateTime updatedAt;

  public NormalizedProjectRevisionThirdPartyProvider() {
  }

  
  public NormalizedProjectRevisionThirdPartyProvider(
     OffsetDateTime createdAt, 
     OffsetDateTime updatedAt
  ) {
    this();
    this.createdAt = createdAt;
    this.updatedAt = updatedAt;
  }

  public NormalizedProjectRevisionThirdPartyProvider applePrivateKey(String applePrivateKey) {
    
    this.applePrivateKey = applePrivateKey;
    return this;
  }

   /**
   * Get applePrivateKey
   * @return applePrivateKey
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getApplePrivateKey() {
    return applePrivateKey;
  }


  public void setApplePrivateKey(String applePrivateKey) {
    this.applePrivateKey = applePrivateKey;
  }


  public NormalizedProjectRevisionThirdPartyProvider applePrivateKeyId(String applePrivateKeyId) {
    
    this.applePrivateKeyId = applePrivateKeyId;
    return this;
  }

   /**
   * Apple Private Key Identifier  Sign In with Apple Private Key Identifier needed for generating a JWT token for client secret
   * @return applePrivateKeyId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "UX56C66723", value = "Apple Private Key Identifier  Sign In with Apple Private Key Identifier needed for generating a JWT token for client secret")

  public String getApplePrivateKeyId() {
    return applePrivateKeyId;
  }


  public void setApplePrivateKeyId(String applePrivateKeyId) {
    this.applePrivateKeyId = applePrivateKeyId;
  }


  public NormalizedProjectRevisionThirdPartyProvider appleTeamId(String appleTeamId) {
    
    this.appleTeamId = appleTeamId;
    return this;
  }

   /**
   * Apple Developer Team ID  Apple Developer Team ID needed for generating a JWT token for client secret
   * @return appleTeamId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "KP76DQS54M", value = "Apple Developer Team ID  Apple Developer Team ID needed for generating a JWT token for client secret")

  public String getAppleTeamId() {
    return appleTeamId;
  }


  public void setAppleTeamId(String appleTeamId) {
    this.appleTeamId = appleTeamId;
  }


  public NormalizedProjectRevisionThirdPartyProvider authUrl(String authUrl) {
    
    this.authUrl = authUrl;
    return this;
  }

   /**
   * AuthURL is the authorize url, typically something like: https://example.org/oauth2/auth Should only be used when the OAuth2 / OpenID Connect server is not supporting OpenID Connect Discovery and when &#x60;provider&#x60; is set to &#x60;generic&#x60;.
   * @return authUrl
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "https://www.googleapis.com/oauth2/v2/auth", value = "AuthURL is the authorize url, typically something like: https://example.org/oauth2/auth Should only be used when the OAuth2 / OpenID Connect server is not supporting OpenID Connect Discovery and when `provider` is set to `generic`.")

  public String getAuthUrl() {
    return authUrl;
  }


  public void setAuthUrl(String authUrl) {
    this.authUrl = authUrl;
  }


  public NormalizedProjectRevisionThirdPartyProvider azureTenant(String azureTenant) {
    
    this.azureTenant = azureTenant;
    return this;
  }

   /**
   * Tenant is the Azure AD Tenant to use for authentication, and must be set when &#x60;provider&#x60; is set to &#x60;microsoft&#x60;.  Can be either &#x60;common&#x60;, &#x60;organizations&#x60;, &#x60;consumers&#x60; for a multitenant application or a specific tenant like &#x60;8eaef023-2b34-4da1-9baa-8bc8c9d6a490&#x60; or &#x60;contoso.onmicrosoft.com&#x60;.
   * @return azureTenant
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "contoso.onmicrosoft.com", value = "Tenant is the Azure AD Tenant to use for authentication, and must be set when `provider` is set to `microsoft`.  Can be either `common`, `organizations`, `consumers` for a multitenant application or a specific tenant like `8eaef023-2b34-4da1-9baa-8bc8c9d6a490` or `contoso.onmicrosoft.com`.")

  public String getAzureTenant() {
    return azureTenant;
  }


  public void setAzureTenant(String azureTenant) {
    this.azureTenant = azureTenant;
  }


  public NormalizedProjectRevisionThirdPartyProvider clientId(String clientId) {
    
    this.clientId = clientId;
    return this;
  }

   /**
   * ClientID is the application&#39;s Client ID.
   * @return clientId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "ClientID is the application's Client ID.")

  public String getClientId() {
    return clientId;
  }


  public void setClientId(String clientId) {
    this.clientId = clientId;
  }


  public NormalizedProjectRevisionThirdPartyProvider clientSecret(String clientSecret) {
    
    this.clientSecret = clientSecret;
    return this;
  }

   /**
   * Get clientSecret
   * @return clientSecret
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getClientSecret() {
    return clientSecret;
  }


  public void setClientSecret(String clientSecret) {
    this.clientSecret = clientSecret;
  }


   /**
   * The Project&#39;s Revision Creation Date
   * @return createdAt
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "The Project's Revision Creation Date")

  public OffsetDateTime getCreatedAt() {
    return createdAt;
  }




  public NormalizedProjectRevisionThirdPartyProvider id(String id) {
    
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getId() {
    return id;
  }


  public void setId(String id) {
    this.id = id;
  }


  public NormalizedProjectRevisionThirdPartyProvider issuerUrl(String issuerUrl) {
    
    this.issuerUrl = issuerUrl;
    return this;
  }

   /**
   * IssuerURL is the OpenID Connect Server URL. You can leave this empty if &#x60;provider&#x60; is not set to &#x60;generic&#x60;. If set, neither &#x60;auth_url&#x60; nor &#x60;token_url&#x60; are required.
   * @return issuerUrl
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "https://accounts.google.com", value = "IssuerURL is the OpenID Connect Server URL. You can leave this empty if `provider` is not set to `generic`. If set, neither `auth_url` nor `token_url` are required.")

  public String getIssuerUrl() {
    return issuerUrl;
  }


  public void setIssuerUrl(String issuerUrl) {
    this.issuerUrl = issuerUrl;
  }


  public NormalizedProjectRevisionThirdPartyProvider label(String label) {
    
    this.label = label;
    return this;
  }

   /**
   * Label represents an optional label which can be used in the UI generation.
   * @return label
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Label represents an optional label which can be used in the UI generation.")

  public String getLabel() {
    return label;
  }


  public void setLabel(String label) {
    this.label = label;
  }


  public NormalizedProjectRevisionThirdPartyProvider mapperUrl(String mapperUrl) {
    
    this.mapperUrl = mapperUrl;
    return this;
  }

   /**
   * Mapper specifies the JSONNet code snippet which uses the OpenID Connect Provider&#39;s data (e.g. GitHub or Google profile information) to hydrate the identity&#39;s data.  It can be either a URL (file://, http(s)://, base64://) or an inline JSONNet code snippet.
   * @return mapperUrl
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Mapper specifies the JSONNet code snippet which uses the OpenID Connect Provider's data (e.g. GitHub or Google profile information) to hydrate the identity's data.  It can be either a URL (file://, http(s)://, base64://) or an inline JSONNet code snippet.")

  public String getMapperUrl() {
    return mapperUrl;
  }


  public void setMapperUrl(String mapperUrl) {
    this.mapperUrl = mapperUrl;
  }


  public NormalizedProjectRevisionThirdPartyProvider projectRevisionId(String projectRevisionId) {
    
    this.projectRevisionId = projectRevisionId;
    return this;
  }

   /**
   * The Revision&#39;s ID this schema belongs to
   * @return projectRevisionId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "The Revision's ID this schema belongs to")

  public String getProjectRevisionId() {
    return projectRevisionId;
  }


  public void setProjectRevisionId(String projectRevisionId) {
    this.projectRevisionId = projectRevisionId;
  }


  public NormalizedProjectRevisionThirdPartyProvider provider(String provider) {
    
    this.provider = provider;
    return this;
  }

   /**
   * Provider is either \&quot;generic\&quot; for a generic OAuth 2.0 / OpenID Connect Provider or one of: generic google github gitlab microsoft discord slack facebook vk yandex apple
   * @return provider
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "google", value = "Provider is either \"generic\" for a generic OAuth 2.0 / OpenID Connect Provider or one of: generic google github gitlab microsoft discord slack facebook vk yandex apple")

  public String getProvider() {
    return provider;
  }


  public void setProvider(String provider) {
    this.provider = provider;
  }


  public NormalizedProjectRevisionThirdPartyProvider providerId(String providerId) {
    
    this.providerId = providerId;
    return this;
  }

   /**
   * ID is the provider&#39;s ID
   * @return providerId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "ID is the provider's ID")

  public String getProviderId() {
    return providerId;
  }


  public void setProviderId(String providerId) {
    this.providerId = providerId;
  }


  public NormalizedProjectRevisionThirdPartyProvider requestedClaims(Object requestedClaims) {
    
    this.requestedClaims = requestedClaims;
    return this;
  }

   /**
   * Get requestedClaims
   * @return requestedClaims
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Object getRequestedClaims() {
    return requestedClaims;
  }


  public void setRequestedClaims(Object requestedClaims) {
    this.requestedClaims = requestedClaims;
  }


  public NormalizedProjectRevisionThirdPartyProvider scope(List<String> scope) {
    
    this.scope = scope;
    return this;
  }

  public NormalizedProjectRevisionThirdPartyProvider addScopeItem(String scopeItem) {
    if (this.scope == null) {
      this.scope = new ArrayList<>();
    }
    this.scope.add(scopeItem);
    return this;
  }

   /**
   * Get scope
   * @return scope
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<String> getScope() {
    return scope;
  }


  public void setScope(List<String> scope) {
    this.scope = scope;
  }


  public NormalizedProjectRevisionThirdPartyProvider subjectSource(String subjectSource) {
    
    this.subjectSource = subjectSource;
    return this;
  }

   /**
   * Get subjectSource
   * @return subjectSource
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getSubjectSource() {
    return subjectSource;
  }


  public void setSubjectSource(String subjectSource) {
    this.subjectSource = subjectSource;
  }


  public NormalizedProjectRevisionThirdPartyProvider tokenUrl(String tokenUrl) {
    
    this.tokenUrl = tokenUrl;
    return this;
  }

   /**
   * TokenURL is the token url, typically something like: https://example.org/oauth2/token  Should only be used when the OAuth2 / OpenID Connect server is not supporting OpenID Connect Discovery and when &#x60;provider&#x60; is set to &#x60;generic&#x60;.
   * @return tokenUrl
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "https://www.googleapis.com/oauth2/v4/token", value = "TokenURL is the token url, typically something like: https://example.org/oauth2/token  Should only be used when the OAuth2 / OpenID Connect server is not supporting OpenID Connect Discovery and when `provider` is set to `generic`.")

  public String getTokenUrl() {
    return tokenUrl;
  }


  public void setTokenUrl(String tokenUrl) {
    this.tokenUrl = tokenUrl;
  }


   /**
   * Last Time Project&#39;s Revision was Updated
   * @return updatedAt
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Last Time Project's Revision was Updated")

  public OffsetDateTime getUpdatedAt() {
    return updatedAt;
  }





  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    NormalizedProjectRevisionThirdPartyProvider normalizedProjectRevisionThirdPartyProvider = (NormalizedProjectRevisionThirdPartyProvider) o;
    return Objects.equals(this.applePrivateKey, normalizedProjectRevisionThirdPartyProvider.applePrivateKey) &&
        Objects.equals(this.applePrivateKeyId, normalizedProjectRevisionThirdPartyProvider.applePrivateKeyId) &&
        Objects.equals(this.appleTeamId, normalizedProjectRevisionThirdPartyProvider.appleTeamId) &&
        Objects.equals(this.authUrl, normalizedProjectRevisionThirdPartyProvider.authUrl) &&
        Objects.equals(this.azureTenant, normalizedProjectRevisionThirdPartyProvider.azureTenant) &&
        Objects.equals(this.clientId, normalizedProjectRevisionThirdPartyProvider.clientId) &&
        Objects.equals(this.clientSecret, normalizedProjectRevisionThirdPartyProvider.clientSecret) &&
        Objects.equals(this.createdAt, normalizedProjectRevisionThirdPartyProvider.createdAt) &&
        Objects.equals(this.id, normalizedProjectRevisionThirdPartyProvider.id) &&
        Objects.equals(this.issuerUrl, normalizedProjectRevisionThirdPartyProvider.issuerUrl) &&
        Objects.equals(this.label, normalizedProjectRevisionThirdPartyProvider.label) &&
        Objects.equals(this.mapperUrl, normalizedProjectRevisionThirdPartyProvider.mapperUrl) &&
        Objects.equals(this.projectRevisionId, normalizedProjectRevisionThirdPartyProvider.projectRevisionId) &&
        Objects.equals(this.provider, normalizedProjectRevisionThirdPartyProvider.provider) &&
        Objects.equals(this.providerId, normalizedProjectRevisionThirdPartyProvider.providerId) &&
        Objects.equals(this.requestedClaims, normalizedProjectRevisionThirdPartyProvider.requestedClaims) &&
        Objects.equals(this.scope, normalizedProjectRevisionThirdPartyProvider.scope) &&
        Objects.equals(this.subjectSource, normalizedProjectRevisionThirdPartyProvider.subjectSource) &&
        Objects.equals(this.tokenUrl, normalizedProjectRevisionThirdPartyProvider.tokenUrl) &&
        Objects.equals(this.updatedAt, normalizedProjectRevisionThirdPartyProvider.updatedAt);
  }

  private static <T> boolean equalsNullable(JsonNullable<T> a, JsonNullable<T> b) {
    return a == b || (a != null && b != null && a.isPresent() && b.isPresent() && Objects.deepEquals(a.get(), b.get()));
  }

  @Override
  public int hashCode() {
    return Objects.hash(applePrivateKey, applePrivateKeyId, appleTeamId, authUrl, azureTenant, clientId, clientSecret, createdAt, id, issuerUrl, label, mapperUrl, projectRevisionId, provider, providerId, requestedClaims, scope, subjectSource, tokenUrl, updatedAt);
  }

  private static <T> int hashCodeNullable(JsonNullable<T> a) {
    if (a == null) {
      return 1;
    }
    return a.isPresent() ? Arrays.deepHashCode(new Object[]{a.get()}) : 31;
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class NormalizedProjectRevisionThirdPartyProvider {\n");
    sb.append("    applePrivateKey: ").append(toIndentedString(applePrivateKey)).append("\n");
    sb.append("    applePrivateKeyId: ").append(toIndentedString(applePrivateKeyId)).append("\n");
    sb.append("    appleTeamId: ").append(toIndentedString(appleTeamId)).append("\n");
    sb.append("    authUrl: ").append(toIndentedString(authUrl)).append("\n");
    sb.append("    azureTenant: ").append(toIndentedString(azureTenant)).append("\n");
    sb.append("    clientId: ").append(toIndentedString(clientId)).append("\n");
    sb.append("    clientSecret: ").append(toIndentedString(clientSecret)).append("\n");
    sb.append("    createdAt: ").append(toIndentedString(createdAt)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    issuerUrl: ").append(toIndentedString(issuerUrl)).append("\n");
    sb.append("    label: ").append(toIndentedString(label)).append("\n");
    sb.append("    mapperUrl: ").append(toIndentedString(mapperUrl)).append("\n");
    sb.append("    projectRevisionId: ").append(toIndentedString(projectRevisionId)).append("\n");
    sb.append("    provider: ").append(toIndentedString(provider)).append("\n");
    sb.append("    providerId: ").append(toIndentedString(providerId)).append("\n");
    sb.append("    requestedClaims: ").append(toIndentedString(requestedClaims)).append("\n");
    sb.append("    scope: ").append(toIndentedString(scope)).append("\n");
    sb.append("    subjectSource: ").append(toIndentedString(subjectSource)).append("\n");
    sb.append("    tokenUrl: ").append(toIndentedString(tokenUrl)).append("\n");
    sb.append("    updatedAt: ").append(toIndentedString(updatedAt)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("apple_private_key");
    openapiFields.add("apple_private_key_id");
    openapiFields.add("apple_team_id");
    openapiFields.add("auth_url");
    openapiFields.add("azure_tenant");
    openapiFields.add("client_id");
    openapiFields.add("client_secret");
    openapiFields.add("created_at");
    openapiFields.add("id");
    openapiFields.add("issuer_url");
    openapiFields.add("label");
    openapiFields.add("mapper_url");
    openapiFields.add("project_revision_id");
    openapiFields.add("provider");
    openapiFields.add("provider_id");
    openapiFields.add("requested_claims");
    openapiFields.add("scope");
    openapiFields.add("subject_source");
    openapiFields.add("token_url");
    openapiFields.add("updated_at");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to NormalizedProjectRevisionThirdPartyProvider
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!NormalizedProjectRevisionThirdPartyProvider.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in NormalizedProjectRevisionThirdPartyProvider is not found in the empty JSON string", NormalizedProjectRevisionThirdPartyProvider.openapiRequiredFields.toString()));
        }
      }

      Set<Entry<String, JsonElement>> entries = jsonObj.entrySet();
      // check to see if the JSON string contains additional fields
      for (Entry<String, JsonElement> entry : entries) {
        if (!NormalizedProjectRevisionThirdPartyProvider.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `NormalizedProjectRevisionThirdPartyProvider` properties. JSON: %s", entry.getKey(), jsonObj.toString()));
        }
      }
      if ((jsonObj.get("apple_private_key") != null && !jsonObj.get("apple_private_key").isJsonNull()) && !jsonObj.get("apple_private_key").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `apple_private_key` to be a primitive type in the JSON string but got `%s`", jsonObj.get("apple_private_key").toString()));
      }
      if ((jsonObj.get("apple_private_key_id") != null && !jsonObj.get("apple_private_key_id").isJsonNull()) && !jsonObj.get("apple_private_key_id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `apple_private_key_id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("apple_private_key_id").toString()));
      }
      if ((jsonObj.get("apple_team_id") != null && !jsonObj.get("apple_team_id").isJsonNull()) && !jsonObj.get("apple_team_id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `apple_team_id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("apple_team_id").toString()));
      }
      if ((jsonObj.get("auth_url") != null && !jsonObj.get("auth_url").isJsonNull()) && !jsonObj.get("auth_url").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `auth_url` to be a primitive type in the JSON string but got `%s`", jsonObj.get("auth_url").toString()));
      }
      if ((jsonObj.get("azure_tenant") != null && !jsonObj.get("azure_tenant").isJsonNull()) && !jsonObj.get("azure_tenant").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `azure_tenant` to be a primitive type in the JSON string but got `%s`", jsonObj.get("azure_tenant").toString()));
      }
      if ((jsonObj.get("client_id") != null && !jsonObj.get("client_id").isJsonNull()) && !jsonObj.get("client_id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `client_id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("client_id").toString()));
      }
      if ((jsonObj.get("client_secret") != null && !jsonObj.get("client_secret").isJsonNull()) && !jsonObj.get("client_secret").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `client_secret` to be a primitive type in the JSON string but got `%s`", jsonObj.get("client_secret").toString()));
      }
      if ((jsonObj.get("id") != null && !jsonObj.get("id").isJsonNull()) && !jsonObj.get("id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("id").toString()));
      }
      if ((jsonObj.get("issuer_url") != null && !jsonObj.get("issuer_url").isJsonNull()) && !jsonObj.get("issuer_url").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `issuer_url` to be a primitive type in the JSON string but got `%s`", jsonObj.get("issuer_url").toString()));
      }
      if ((jsonObj.get("label") != null && !jsonObj.get("label").isJsonNull()) && !jsonObj.get("label").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `label` to be a primitive type in the JSON string but got `%s`", jsonObj.get("label").toString()));
      }
      if ((jsonObj.get("mapper_url") != null && !jsonObj.get("mapper_url").isJsonNull()) && !jsonObj.get("mapper_url").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `mapper_url` to be a primitive type in the JSON string but got `%s`", jsonObj.get("mapper_url").toString()));
      }
      if ((jsonObj.get("project_revision_id") != null && !jsonObj.get("project_revision_id").isJsonNull()) && !jsonObj.get("project_revision_id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `project_revision_id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("project_revision_id").toString()));
      }
      if ((jsonObj.get("provider") != null && !jsonObj.get("provider").isJsonNull()) && !jsonObj.get("provider").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `provider` to be a primitive type in the JSON string but got `%s`", jsonObj.get("provider").toString()));
      }
      if ((jsonObj.get("provider_id") != null && !jsonObj.get("provider_id").isJsonNull()) && !jsonObj.get("provider_id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `provider_id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("provider_id").toString()));
      }
      // ensure the optional json data is an array if present
      if (jsonObj.get("scope") != null && !jsonObj.get("scope").isJsonArray()) {
        throw new IllegalArgumentException(String.format("Expected the field `scope` to be an array in the JSON string but got `%s`", jsonObj.get("scope").toString()));
      }
      if ((jsonObj.get("subject_source") != null && !jsonObj.get("subject_source").isJsonNull()) && !jsonObj.get("subject_source").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `subject_source` to be a primitive type in the JSON string but got `%s`", jsonObj.get("subject_source").toString()));
      }
      if ((jsonObj.get("token_url") != null && !jsonObj.get("token_url").isJsonNull()) && !jsonObj.get("token_url").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `token_url` to be a primitive type in the JSON string but got `%s`", jsonObj.get("token_url").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!NormalizedProjectRevisionThirdPartyProvider.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'NormalizedProjectRevisionThirdPartyProvider' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<NormalizedProjectRevisionThirdPartyProvider> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(NormalizedProjectRevisionThirdPartyProvider.class));

       return (TypeAdapter<T>) new TypeAdapter<NormalizedProjectRevisionThirdPartyProvider>() {
           @Override
           public void write(JsonWriter out, NormalizedProjectRevisionThirdPartyProvider value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public NormalizedProjectRevisionThirdPartyProvider read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             return thisAdapter.fromJsonTree(jsonObj);
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of NormalizedProjectRevisionThirdPartyProvider given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of NormalizedProjectRevisionThirdPartyProvider
  * @throws IOException if the JSON string is invalid with respect to NormalizedProjectRevisionThirdPartyProvider
  */
  public static NormalizedProjectRevisionThirdPartyProvider fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, NormalizedProjectRevisionThirdPartyProvider.class);
  }

 /**
  * Convert an instance of NormalizedProjectRevisionThirdPartyProvider to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}


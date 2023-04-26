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
 * OAuth2ConsentSessionExpiresAt
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2023-04-24T08:24:45.436303324Z[Etc/UTC]")
public class OAuth2ConsentSessionExpiresAt {
  public static final String SERIALIZED_NAME_ACCESS_TOKEN = "access_token";
  @SerializedName(SERIALIZED_NAME_ACCESS_TOKEN)
  private OffsetDateTime accessToken;

  public static final String SERIALIZED_NAME_AUTHORIZE_CODE = "authorize_code";
  @SerializedName(SERIALIZED_NAME_AUTHORIZE_CODE)
  private OffsetDateTime authorizeCode;

  public static final String SERIALIZED_NAME_ID_TOKEN = "id_token";
  @SerializedName(SERIALIZED_NAME_ID_TOKEN)
  private OffsetDateTime idToken;

  public static final String SERIALIZED_NAME_PAR_CONTEXT = "par_context";
  @SerializedName(SERIALIZED_NAME_PAR_CONTEXT)
  private OffsetDateTime parContext;

  public static final String SERIALIZED_NAME_REFRESH_TOKEN = "refresh_token";
  @SerializedName(SERIALIZED_NAME_REFRESH_TOKEN)
  private OffsetDateTime refreshToken;

  public OAuth2ConsentSessionExpiresAt() {
  }

  public OAuth2ConsentSessionExpiresAt accessToken(OffsetDateTime accessToken) {
    
    this.accessToken = accessToken;
    return this;
  }

   /**
   * Get accessToken
   * @return accessToken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public OffsetDateTime getAccessToken() {
    return accessToken;
  }


  public void setAccessToken(OffsetDateTime accessToken) {
    this.accessToken = accessToken;
  }


  public OAuth2ConsentSessionExpiresAt authorizeCode(OffsetDateTime authorizeCode) {
    
    this.authorizeCode = authorizeCode;
    return this;
  }

   /**
   * Get authorizeCode
   * @return authorizeCode
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public OffsetDateTime getAuthorizeCode() {
    return authorizeCode;
  }


  public void setAuthorizeCode(OffsetDateTime authorizeCode) {
    this.authorizeCode = authorizeCode;
  }


  public OAuth2ConsentSessionExpiresAt idToken(OffsetDateTime idToken) {
    
    this.idToken = idToken;
    return this;
  }

   /**
   * Get idToken
   * @return idToken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public OffsetDateTime getIdToken() {
    return idToken;
  }


  public void setIdToken(OffsetDateTime idToken) {
    this.idToken = idToken;
  }


  public OAuth2ConsentSessionExpiresAt parContext(OffsetDateTime parContext) {
    
    this.parContext = parContext;
    return this;
  }

   /**
   * Get parContext
   * @return parContext
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public OffsetDateTime getParContext() {
    return parContext;
  }


  public void setParContext(OffsetDateTime parContext) {
    this.parContext = parContext;
  }


  public OAuth2ConsentSessionExpiresAt refreshToken(OffsetDateTime refreshToken) {
    
    this.refreshToken = refreshToken;
    return this;
  }

   /**
   * Get refreshToken
   * @return refreshToken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public OffsetDateTime getRefreshToken() {
    return refreshToken;
  }


  public void setRefreshToken(OffsetDateTime refreshToken) {
    this.refreshToken = refreshToken;
  }



  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    OAuth2ConsentSessionExpiresAt oAuth2ConsentSessionExpiresAt = (OAuth2ConsentSessionExpiresAt) o;
    return Objects.equals(this.accessToken, oAuth2ConsentSessionExpiresAt.accessToken) &&
        Objects.equals(this.authorizeCode, oAuth2ConsentSessionExpiresAt.authorizeCode) &&
        Objects.equals(this.idToken, oAuth2ConsentSessionExpiresAt.idToken) &&
        Objects.equals(this.parContext, oAuth2ConsentSessionExpiresAt.parContext) &&
        Objects.equals(this.refreshToken, oAuth2ConsentSessionExpiresAt.refreshToken);
  }

  @Override
  public int hashCode() {
    return Objects.hash(accessToken, authorizeCode, idToken, parContext, refreshToken);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class OAuth2ConsentSessionExpiresAt {\n");
    sb.append("    accessToken: ").append(toIndentedString(accessToken)).append("\n");
    sb.append("    authorizeCode: ").append(toIndentedString(authorizeCode)).append("\n");
    sb.append("    idToken: ").append(toIndentedString(idToken)).append("\n");
    sb.append("    parContext: ").append(toIndentedString(parContext)).append("\n");
    sb.append("    refreshToken: ").append(toIndentedString(refreshToken)).append("\n");
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
    openapiFields.add("access_token");
    openapiFields.add("authorize_code");
    openapiFields.add("id_token");
    openapiFields.add("par_context");
    openapiFields.add("refresh_token");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to OAuth2ConsentSessionExpiresAt
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!OAuth2ConsentSessionExpiresAt.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in OAuth2ConsentSessionExpiresAt is not found in the empty JSON string", OAuth2ConsentSessionExpiresAt.openapiRequiredFields.toString()));
        }
      }

      Set<Entry<String, JsonElement>> entries = jsonObj.entrySet();
      // check to see if the JSON string contains additional fields
      for (Entry<String, JsonElement> entry : entries) {
        if (!OAuth2ConsentSessionExpiresAt.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `OAuth2ConsentSessionExpiresAt` properties. JSON: %s", entry.getKey(), jsonObj.toString()));
        }
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!OAuth2ConsentSessionExpiresAt.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'OAuth2ConsentSessionExpiresAt' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<OAuth2ConsentSessionExpiresAt> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(OAuth2ConsentSessionExpiresAt.class));

       return (TypeAdapter<T>) new TypeAdapter<OAuth2ConsentSessionExpiresAt>() {
           @Override
           public void write(JsonWriter out, OAuth2ConsentSessionExpiresAt value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public OAuth2ConsentSessionExpiresAt read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             return thisAdapter.fromJsonTree(jsonObj);
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of OAuth2ConsentSessionExpiresAt given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of OAuth2ConsentSessionExpiresAt
  * @throws IOException if the JSON string is invalid with respect to OAuth2ConsentSessionExpiresAt
  */
  public static OAuth2ConsentSessionExpiresAt fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, OAuth2ConsentSessionExpiresAt.class);
  }

 /**
  * Convert an instance of OAuth2ConsentSessionExpiresAt to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}


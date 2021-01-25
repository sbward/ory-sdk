/*
 * ORY Oathkeeper
 * ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.
 *
 * The version of the OpenAPI document: v0.0.0
 * Contact: hi@ory.am
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.oathkeeper.model;

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
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * SwaggerNotReadyStatus swagger not ready status
 */
@ApiModel(description = "SwaggerNotReadyStatus swagger not ready status")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-01-25T16:37:54.560934+01:00[Europe/Berlin]")
public class SwaggerNotReadyStatus {
  public static final String SERIALIZED_NAME_ERRORS = "errors";
  @SerializedName(SERIALIZED_NAME_ERRORS)
  private Map<String, String> errors = null;


  public SwaggerNotReadyStatus errors(Map<String, String> errors) {
    
    this.errors = errors;
    return this;
  }

  public SwaggerNotReadyStatus putErrorsItem(String key, String errorsItem) {
    if (this.errors == null) {
      this.errors = new HashMap<String, String>();
    }
    this.errors.put(key, errorsItem);
    return this;
  }

   /**
   * Errors contains a list of errors that caused the not ready status.
   * @return errors
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Errors contains a list of errors that caused the not ready status.")

  public Map<String, String> getErrors() {
    return errors;
  }


  public void setErrors(Map<String, String> errors) {
    this.errors = errors;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SwaggerNotReadyStatus swaggerNotReadyStatus = (SwaggerNotReadyStatus) o;
    return Objects.equals(this.errors, swaggerNotReadyStatus.errors);
  }

  @Override
  public int hashCode() {
    return Objects.hash(errors);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SwaggerNotReadyStatus {\n");
    sb.append("    errors: ").append(toIndentedString(errors)).append("\n");
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

}

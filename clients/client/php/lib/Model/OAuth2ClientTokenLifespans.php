<?php
/**
 * OAuth2ClientTokenLifespans
 *
 * PHP version 7.4
 *
 * @category Class
 * @package  Ory\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.
 *
 * The version of the OpenAPI document: v1.15.6
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 * Generator version: 7.7.0
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace Ory\Client\Model;

use \ArrayAccess;
use \Ory\Client\ObjectSerializer;

/**
 * OAuth2ClientTokenLifespans Class Doc Comment
 *
 * @category Class
 * @description Lifespans of different token types issued for this OAuth 2.0 Client.
 * @package  Ory\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<string, mixed>
 */
class OAuth2ClientTokenLifespans implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'oAuth2ClientTokenLifespans';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'authorizationCodeGrantAccessTokenLifespan' => 'string',
        'authorizationCodeGrantIdTokenLifespan' => 'string',
        'authorizationCodeGrantRefreshTokenLifespan' => 'string',
        'clientCredentialsGrantAccessTokenLifespan' => 'string',
        'implicitGrantAccessTokenLifespan' => 'string',
        'implicitGrantIdTokenLifespan' => 'string',
        'jwtBearerGrantAccessTokenLifespan' => 'string',
        'refreshTokenGrantAccessTokenLifespan' => 'string',
        'refreshTokenGrantIdTokenLifespan' => 'string',
        'refreshTokenGrantRefreshTokenLifespan' => 'string'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      * @phpstan-var array<string, string|null>
      * @psalm-var array<string, string|null>
      */
    protected static $openAPIFormats = [
        'authorizationCodeGrantAccessTokenLifespan' => null,
        'authorizationCodeGrantIdTokenLifespan' => null,
        'authorizationCodeGrantRefreshTokenLifespan' => null,
        'clientCredentialsGrantAccessTokenLifespan' => null,
        'implicitGrantAccessTokenLifespan' => null,
        'implicitGrantIdTokenLifespan' => null,
        'jwtBearerGrantAccessTokenLifespan' => null,
        'refreshTokenGrantAccessTokenLifespan' => null,
        'refreshTokenGrantIdTokenLifespan' => null,
        'refreshTokenGrantRefreshTokenLifespan' => null
    ];

    /**
      * Array of nullable properties. Used for (de)serialization
      *
      * @var boolean[]
      */
    protected static array $openAPINullables = [
        'authorizationCodeGrantAccessTokenLifespan' => true,
        'authorizationCodeGrantIdTokenLifespan' => true,
        'authorizationCodeGrantRefreshTokenLifespan' => true,
        'clientCredentialsGrantAccessTokenLifespan' => true,
        'implicitGrantAccessTokenLifespan' => true,
        'implicitGrantIdTokenLifespan' => true,
        'jwtBearerGrantAccessTokenLifespan' => true,
        'refreshTokenGrantAccessTokenLifespan' => true,
        'refreshTokenGrantIdTokenLifespan' => true,
        'refreshTokenGrantRefreshTokenLifespan' => true
    ];

    /**
      * If a nullable field gets set to null, insert it here
      *
      * @var boolean[]
      */
    protected array $openAPINullablesSetToNull = [];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of nullable properties
     *
     * @return array
     */
    protected static function openAPINullables(): array
    {
        return self::$openAPINullables;
    }

    /**
     * Array of nullable field names deliberately set to null
     *
     * @return boolean[]
     */
    private function getOpenAPINullablesSetToNull(): array
    {
        return $this->openAPINullablesSetToNull;
    }

    /**
     * Setter - Array of nullable field names deliberately set to null
     *
     * @param boolean[] $openAPINullablesSetToNull
     */
    private function setOpenAPINullablesSetToNull(array $openAPINullablesSetToNull): void
    {
        $this->openAPINullablesSetToNull = $openAPINullablesSetToNull;
    }

    /**
     * Checks if a property is nullable
     *
     * @param string $property
     * @return bool
     */
    public static function isNullable(string $property): bool
    {
        return self::openAPINullables()[$property] ?? false;
    }

    /**
     * Checks if a nullable property is set to null.
     *
     * @param string $property
     * @return bool
     */
    public function isNullableSetToNull(string $property): bool
    {
        return in_array($property, $this->getOpenAPINullablesSetToNull(), true);
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'authorizationCodeGrantAccessTokenLifespan' => 'authorization_code_grant_access_token_lifespan',
        'authorizationCodeGrantIdTokenLifespan' => 'authorization_code_grant_id_token_lifespan',
        'authorizationCodeGrantRefreshTokenLifespan' => 'authorization_code_grant_refresh_token_lifespan',
        'clientCredentialsGrantAccessTokenLifespan' => 'client_credentials_grant_access_token_lifespan',
        'implicitGrantAccessTokenLifespan' => 'implicit_grant_access_token_lifespan',
        'implicitGrantIdTokenLifespan' => 'implicit_grant_id_token_lifespan',
        'jwtBearerGrantAccessTokenLifespan' => 'jwt_bearer_grant_access_token_lifespan',
        'refreshTokenGrantAccessTokenLifespan' => 'refresh_token_grant_access_token_lifespan',
        'refreshTokenGrantIdTokenLifespan' => 'refresh_token_grant_id_token_lifespan',
        'refreshTokenGrantRefreshTokenLifespan' => 'refresh_token_grant_refresh_token_lifespan'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'authorizationCodeGrantAccessTokenLifespan' => 'setAuthorizationCodeGrantAccessTokenLifespan',
        'authorizationCodeGrantIdTokenLifespan' => 'setAuthorizationCodeGrantIdTokenLifespan',
        'authorizationCodeGrantRefreshTokenLifespan' => 'setAuthorizationCodeGrantRefreshTokenLifespan',
        'clientCredentialsGrantAccessTokenLifespan' => 'setClientCredentialsGrantAccessTokenLifespan',
        'implicitGrantAccessTokenLifespan' => 'setImplicitGrantAccessTokenLifespan',
        'implicitGrantIdTokenLifespan' => 'setImplicitGrantIdTokenLifespan',
        'jwtBearerGrantAccessTokenLifespan' => 'setJwtBearerGrantAccessTokenLifespan',
        'refreshTokenGrantAccessTokenLifespan' => 'setRefreshTokenGrantAccessTokenLifespan',
        'refreshTokenGrantIdTokenLifespan' => 'setRefreshTokenGrantIdTokenLifespan',
        'refreshTokenGrantRefreshTokenLifespan' => 'setRefreshTokenGrantRefreshTokenLifespan'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'authorizationCodeGrantAccessTokenLifespan' => 'getAuthorizationCodeGrantAccessTokenLifespan',
        'authorizationCodeGrantIdTokenLifespan' => 'getAuthorizationCodeGrantIdTokenLifespan',
        'authorizationCodeGrantRefreshTokenLifespan' => 'getAuthorizationCodeGrantRefreshTokenLifespan',
        'clientCredentialsGrantAccessTokenLifespan' => 'getClientCredentialsGrantAccessTokenLifespan',
        'implicitGrantAccessTokenLifespan' => 'getImplicitGrantAccessTokenLifespan',
        'implicitGrantIdTokenLifespan' => 'getImplicitGrantIdTokenLifespan',
        'jwtBearerGrantAccessTokenLifespan' => 'getJwtBearerGrantAccessTokenLifespan',
        'refreshTokenGrantAccessTokenLifespan' => 'getRefreshTokenGrantAccessTokenLifespan',
        'refreshTokenGrantIdTokenLifespan' => 'getRefreshTokenGrantIdTokenLifespan',
        'refreshTokenGrantRefreshTokenLifespan' => 'getRefreshTokenGrantRefreshTokenLifespan'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$openAPIModelName;
    }


    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->setIfExists('authorizationCodeGrantAccessTokenLifespan', $data ?? [], null);
        $this->setIfExists('authorizationCodeGrantIdTokenLifespan', $data ?? [], null);
        $this->setIfExists('authorizationCodeGrantRefreshTokenLifespan', $data ?? [], null);
        $this->setIfExists('clientCredentialsGrantAccessTokenLifespan', $data ?? [], null);
        $this->setIfExists('implicitGrantAccessTokenLifespan', $data ?? [], null);
        $this->setIfExists('implicitGrantIdTokenLifespan', $data ?? [], null);
        $this->setIfExists('jwtBearerGrantAccessTokenLifespan', $data ?? [], null);
        $this->setIfExists('refreshTokenGrantAccessTokenLifespan', $data ?? [], null);
        $this->setIfExists('refreshTokenGrantIdTokenLifespan', $data ?? [], null);
        $this->setIfExists('refreshTokenGrantRefreshTokenLifespan', $data ?? [], null);
    }

    /**
    * Sets $this->container[$variableName] to the given data or to the given default Value; if $variableName
    * is nullable and its value is set to null in the $fields array, then mark it as "set to null" in the
    * $this->openAPINullablesSetToNull array
    *
    * @param string $variableName
    * @param array  $fields
    * @param mixed  $defaultValue
    */
    private function setIfExists(string $variableName, array $fields, $defaultValue): void
    {
        if (self::isNullable($variableName) && array_key_exists($variableName, $fields) && is_null($fields[$variableName])) {
            $this->openAPINullablesSetToNull[] = $variableName;
        }

        $this->container[$variableName] = $fields[$variableName] ?? $defaultValue;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if (!is_null($this->container['authorizationCodeGrantAccessTokenLifespan']) && !preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", $this->container['authorizationCodeGrantAccessTokenLifespan'])) {
            $invalidProperties[] = "invalid value for 'authorizationCodeGrantAccessTokenLifespan', must be conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.";
        }

        if (!is_null($this->container['authorizationCodeGrantIdTokenLifespan']) && !preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", $this->container['authorizationCodeGrantIdTokenLifespan'])) {
            $invalidProperties[] = "invalid value for 'authorizationCodeGrantIdTokenLifespan', must be conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.";
        }

        if (!is_null($this->container['authorizationCodeGrantRefreshTokenLifespan']) && !preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", $this->container['authorizationCodeGrantRefreshTokenLifespan'])) {
            $invalidProperties[] = "invalid value for 'authorizationCodeGrantRefreshTokenLifespan', must be conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.";
        }

        if (!is_null($this->container['clientCredentialsGrantAccessTokenLifespan']) && !preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", $this->container['clientCredentialsGrantAccessTokenLifespan'])) {
            $invalidProperties[] = "invalid value for 'clientCredentialsGrantAccessTokenLifespan', must be conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.";
        }

        if (!is_null($this->container['implicitGrantAccessTokenLifespan']) && !preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", $this->container['implicitGrantAccessTokenLifespan'])) {
            $invalidProperties[] = "invalid value for 'implicitGrantAccessTokenLifespan', must be conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.";
        }

        if (!is_null($this->container['implicitGrantIdTokenLifespan']) && !preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", $this->container['implicitGrantIdTokenLifespan'])) {
            $invalidProperties[] = "invalid value for 'implicitGrantIdTokenLifespan', must be conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.";
        }

        if (!is_null($this->container['jwtBearerGrantAccessTokenLifespan']) && !preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", $this->container['jwtBearerGrantAccessTokenLifespan'])) {
            $invalidProperties[] = "invalid value for 'jwtBearerGrantAccessTokenLifespan', must be conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.";
        }

        if (!is_null($this->container['refreshTokenGrantAccessTokenLifespan']) && !preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", $this->container['refreshTokenGrantAccessTokenLifespan'])) {
            $invalidProperties[] = "invalid value for 'refreshTokenGrantAccessTokenLifespan', must be conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.";
        }

        if (!is_null($this->container['refreshTokenGrantIdTokenLifespan']) && !preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", $this->container['refreshTokenGrantIdTokenLifespan'])) {
            $invalidProperties[] = "invalid value for 'refreshTokenGrantIdTokenLifespan', must be conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.";
        }

        if (!is_null($this->container['refreshTokenGrantRefreshTokenLifespan']) && !preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", $this->container['refreshTokenGrantRefreshTokenLifespan'])) {
            $invalidProperties[] = "invalid value for 'refreshTokenGrantRefreshTokenLifespan', must be conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.";
        }

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets authorizationCodeGrantAccessTokenLifespan
     *
     * @return string|null
     */
    public function getAuthorizationCodeGrantAccessTokenLifespan()
    {
        return $this->container['authorizationCodeGrantAccessTokenLifespan'];
    }

    /**
     * Sets authorizationCodeGrantAccessTokenLifespan
     *
     * @param string|null $authorizationCodeGrantAccessTokenLifespan authorizationCodeGrantAccessTokenLifespan
     *
     * @return self
     */
    public function setAuthorizationCodeGrantAccessTokenLifespan($authorizationCodeGrantAccessTokenLifespan)
    {
        if (is_null($authorizationCodeGrantAccessTokenLifespan)) {
            array_push($this->openAPINullablesSetToNull, 'authorizationCodeGrantAccessTokenLifespan');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('authorizationCodeGrantAccessTokenLifespan', $nullablesSetToNull);
            if ($index !== FALSE) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }

        if (!is_null($authorizationCodeGrantAccessTokenLifespan) && (!preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", ObjectSerializer::toString($authorizationCodeGrantAccessTokenLifespan)))) {
            throw new \InvalidArgumentException("invalid value for \$authorizationCodeGrantAccessTokenLifespan when calling OAuth2ClientTokenLifespans., must conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.");
        }

        $this->container['authorizationCodeGrantAccessTokenLifespan'] = $authorizationCodeGrantAccessTokenLifespan;

        return $this;
    }

    /**
     * Gets authorizationCodeGrantIdTokenLifespan
     *
     * @return string|null
     */
    public function getAuthorizationCodeGrantIdTokenLifespan()
    {
        return $this->container['authorizationCodeGrantIdTokenLifespan'];
    }

    /**
     * Sets authorizationCodeGrantIdTokenLifespan
     *
     * @param string|null $authorizationCodeGrantIdTokenLifespan authorizationCodeGrantIdTokenLifespan
     *
     * @return self
     */
    public function setAuthorizationCodeGrantIdTokenLifespan($authorizationCodeGrantIdTokenLifespan)
    {
        if (is_null($authorizationCodeGrantIdTokenLifespan)) {
            array_push($this->openAPINullablesSetToNull, 'authorizationCodeGrantIdTokenLifespan');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('authorizationCodeGrantIdTokenLifespan', $nullablesSetToNull);
            if ($index !== FALSE) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }

        if (!is_null($authorizationCodeGrantIdTokenLifespan) && (!preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", ObjectSerializer::toString($authorizationCodeGrantIdTokenLifespan)))) {
            throw new \InvalidArgumentException("invalid value for \$authorizationCodeGrantIdTokenLifespan when calling OAuth2ClientTokenLifespans., must conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.");
        }

        $this->container['authorizationCodeGrantIdTokenLifespan'] = $authorizationCodeGrantIdTokenLifespan;

        return $this;
    }

    /**
     * Gets authorizationCodeGrantRefreshTokenLifespan
     *
     * @return string|null
     */
    public function getAuthorizationCodeGrantRefreshTokenLifespan()
    {
        return $this->container['authorizationCodeGrantRefreshTokenLifespan'];
    }

    /**
     * Sets authorizationCodeGrantRefreshTokenLifespan
     *
     * @param string|null $authorizationCodeGrantRefreshTokenLifespan authorizationCodeGrantRefreshTokenLifespan
     *
     * @return self
     */
    public function setAuthorizationCodeGrantRefreshTokenLifespan($authorizationCodeGrantRefreshTokenLifespan)
    {
        if (is_null($authorizationCodeGrantRefreshTokenLifespan)) {
            array_push($this->openAPINullablesSetToNull, 'authorizationCodeGrantRefreshTokenLifespan');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('authorizationCodeGrantRefreshTokenLifespan', $nullablesSetToNull);
            if ($index !== FALSE) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }

        if (!is_null($authorizationCodeGrantRefreshTokenLifespan) && (!preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", ObjectSerializer::toString($authorizationCodeGrantRefreshTokenLifespan)))) {
            throw new \InvalidArgumentException("invalid value for \$authorizationCodeGrantRefreshTokenLifespan when calling OAuth2ClientTokenLifespans., must conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.");
        }

        $this->container['authorizationCodeGrantRefreshTokenLifespan'] = $authorizationCodeGrantRefreshTokenLifespan;

        return $this;
    }

    /**
     * Gets clientCredentialsGrantAccessTokenLifespan
     *
     * @return string|null
     */
    public function getClientCredentialsGrantAccessTokenLifespan()
    {
        return $this->container['clientCredentialsGrantAccessTokenLifespan'];
    }

    /**
     * Sets clientCredentialsGrantAccessTokenLifespan
     *
     * @param string|null $clientCredentialsGrantAccessTokenLifespan clientCredentialsGrantAccessTokenLifespan
     *
     * @return self
     */
    public function setClientCredentialsGrantAccessTokenLifespan($clientCredentialsGrantAccessTokenLifespan)
    {
        if (is_null($clientCredentialsGrantAccessTokenLifespan)) {
            array_push($this->openAPINullablesSetToNull, 'clientCredentialsGrantAccessTokenLifespan');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('clientCredentialsGrantAccessTokenLifespan', $nullablesSetToNull);
            if ($index !== FALSE) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }

        if (!is_null($clientCredentialsGrantAccessTokenLifespan) && (!preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", ObjectSerializer::toString($clientCredentialsGrantAccessTokenLifespan)))) {
            throw new \InvalidArgumentException("invalid value for \$clientCredentialsGrantAccessTokenLifespan when calling OAuth2ClientTokenLifespans., must conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.");
        }

        $this->container['clientCredentialsGrantAccessTokenLifespan'] = $clientCredentialsGrantAccessTokenLifespan;

        return $this;
    }

    /**
     * Gets implicitGrantAccessTokenLifespan
     *
     * @return string|null
     */
    public function getImplicitGrantAccessTokenLifespan()
    {
        return $this->container['implicitGrantAccessTokenLifespan'];
    }

    /**
     * Sets implicitGrantAccessTokenLifespan
     *
     * @param string|null $implicitGrantAccessTokenLifespan implicitGrantAccessTokenLifespan
     *
     * @return self
     */
    public function setImplicitGrantAccessTokenLifespan($implicitGrantAccessTokenLifespan)
    {
        if (is_null($implicitGrantAccessTokenLifespan)) {
            array_push($this->openAPINullablesSetToNull, 'implicitGrantAccessTokenLifespan');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('implicitGrantAccessTokenLifespan', $nullablesSetToNull);
            if ($index !== FALSE) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }

        if (!is_null($implicitGrantAccessTokenLifespan) && (!preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", ObjectSerializer::toString($implicitGrantAccessTokenLifespan)))) {
            throw new \InvalidArgumentException("invalid value for \$implicitGrantAccessTokenLifespan when calling OAuth2ClientTokenLifespans., must conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.");
        }

        $this->container['implicitGrantAccessTokenLifespan'] = $implicitGrantAccessTokenLifespan;

        return $this;
    }

    /**
     * Gets implicitGrantIdTokenLifespan
     *
     * @return string|null
     */
    public function getImplicitGrantIdTokenLifespan()
    {
        return $this->container['implicitGrantIdTokenLifespan'];
    }

    /**
     * Sets implicitGrantIdTokenLifespan
     *
     * @param string|null $implicitGrantIdTokenLifespan implicitGrantIdTokenLifespan
     *
     * @return self
     */
    public function setImplicitGrantIdTokenLifespan($implicitGrantIdTokenLifespan)
    {
        if (is_null($implicitGrantIdTokenLifespan)) {
            array_push($this->openAPINullablesSetToNull, 'implicitGrantIdTokenLifespan');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('implicitGrantIdTokenLifespan', $nullablesSetToNull);
            if ($index !== FALSE) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }

        if (!is_null($implicitGrantIdTokenLifespan) && (!preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", ObjectSerializer::toString($implicitGrantIdTokenLifespan)))) {
            throw new \InvalidArgumentException("invalid value for \$implicitGrantIdTokenLifespan when calling OAuth2ClientTokenLifespans., must conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.");
        }

        $this->container['implicitGrantIdTokenLifespan'] = $implicitGrantIdTokenLifespan;

        return $this;
    }

    /**
     * Gets jwtBearerGrantAccessTokenLifespan
     *
     * @return string|null
     */
    public function getJwtBearerGrantAccessTokenLifespan()
    {
        return $this->container['jwtBearerGrantAccessTokenLifespan'];
    }

    /**
     * Sets jwtBearerGrantAccessTokenLifespan
     *
     * @param string|null $jwtBearerGrantAccessTokenLifespan jwtBearerGrantAccessTokenLifespan
     *
     * @return self
     */
    public function setJwtBearerGrantAccessTokenLifespan($jwtBearerGrantAccessTokenLifespan)
    {
        if (is_null($jwtBearerGrantAccessTokenLifespan)) {
            array_push($this->openAPINullablesSetToNull, 'jwtBearerGrantAccessTokenLifespan');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('jwtBearerGrantAccessTokenLifespan', $nullablesSetToNull);
            if ($index !== FALSE) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }

        if (!is_null($jwtBearerGrantAccessTokenLifespan) && (!preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", ObjectSerializer::toString($jwtBearerGrantAccessTokenLifespan)))) {
            throw new \InvalidArgumentException("invalid value for \$jwtBearerGrantAccessTokenLifespan when calling OAuth2ClientTokenLifespans., must conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.");
        }

        $this->container['jwtBearerGrantAccessTokenLifespan'] = $jwtBearerGrantAccessTokenLifespan;

        return $this;
    }

    /**
     * Gets refreshTokenGrantAccessTokenLifespan
     *
     * @return string|null
     */
    public function getRefreshTokenGrantAccessTokenLifespan()
    {
        return $this->container['refreshTokenGrantAccessTokenLifespan'];
    }

    /**
     * Sets refreshTokenGrantAccessTokenLifespan
     *
     * @param string|null $refreshTokenGrantAccessTokenLifespan refreshTokenGrantAccessTokenLifespan
     *
     * @return self
     */
    public function setRefreshTokenGrantAccessTokenLifespan($refreshTokenGrantAccessTokenLifespan)
    {
        if (is_null($refreshTokenGrantAccessTokenLifespan)) {
            array_push($this->openAPINullablesSetToNull, 'refreshTokenGrantAccessTokenLifespan');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('refreshTokenGrantAccessTokenLifespan', $nullablesSetToNull);
            if ($index !== FALSE) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }

        if (!is_null($refreshTokenGrantAccessTokenLifespan) && (!preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", ObjectSerializer::toString($refreshTokenGrantAccessTokenLifespan)))) {
            throw new \InvalidArgumentException("invalid value for \$refreshTokenGrantAccessTokenLifespan when calling OAuth2ClientTokenLifespans., must conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.");
        }

        $this->container['refreshTokenGrantAccessTokenLifespan'] = $refreshTokenGrantAccessTokenLifespan;

        return $this;
    }

    /**
     * Gets refreshTokenGrantIdTokenLifespan
     *
     * @return string|null
     */
    public function getRefreshTokenGrantIdTokenLifespan()
    {
        return $this->container['refreshTokenGrantIdTokenLifespan'];
    }

    /**
     * Sets refreshTokenGrantIdTokenLifespan
     *
     * @param string|null $refreshTokenGrantIdTokenLifespan refreshTokenGrantIdTokenLifespan
     *
     * @return self
     */
    public function setRefreshTokenGrantIdTokenLifespan($refreshTokenGrantIdTokenLifespan)
    {
        if (is_null($refreshTokenGrantIdTokenLifespan)) {
            array_push($this->openAPINullablesSetToNull, 'refreshTokenGrantIdTokenLifespan');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('refreshTokenGrantIdTokenLifespan', $nullablesSetToNull);
            if ($index !== FALSE) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }

        if (!is_null($refreshTokenGrantIdTokenLifespan) && (!preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", ObjectSerializer::toString($refreshTokenGrantIdTokenLifespan)))) {
            throw new \InvalidArgumentException("invalid value for \$refreshTokenGrantIdTokenLifespan when calling OAuth2ClientTokenLifespans., must conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.");
        }

        $this->container['refreshTokenGrantIdTokenLifespan'] = $refreshTokenGrantIdTokenLifespan;

        return $this;
    }

    /**
     * Gets refreshTokenGrantRefreshTokenLifespan
     *
     * @return string|null
     */
    public function getRefreshTokenGrantRefreshTokenLifespan()
    {
        return $this->container['refreshTokenGrantRefreshTokenLifespan'];
    }

    /**
     * Sets refreshTokenGrantRefreshTokenLifespan
     *
     * @param string|null $refreshTokenGrantRefreshTokenLifespan refreshTokenGrantRefreshTokenLifespan
     *
     * @return self
     */
    public function setRefreshTokenGrantRefreshTokenLifespan($refreshTokenGrantRefreshTokenLifespan)
    {
        if (is_null($refreshTokenGrantRefreshTokenLifespan)) {
            array_push($this->openAPINullablesSetToNull, 'refreshTokenGrantRefreshTokenLifespan');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('refreshTokenGrantRefreshTokenLifespan', $nullablesSetToNull);
            if ($index !== FALSE) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }

        if (!is_null($refreshTokenGrantRefreshTokenLifespan) && (!preg_match("/^[0-9]+(ns|us|ms|s|m|h)$/", ObjectSerializer::toString($refreshTokenGrantRefreshTokenLifespan)))) {
            throw new \InvalidArgumentException("invalid value for \$refreshTokenGrantRefreshTokenLifespan when calling OAuth2ClientTokenLifespans., must conform to the pattern /^[0-9]+(ns|us|ms|s|m|h)$/.");
        }

        $this->container['refreshTokenGrantRefreshTokenLifespan'] = $refreshTokenGrantRefreshTokenLifespan;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset): bool
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed|null
     */
    #[\ReturnTypeWillChange]
    public function offsetGet($offset)
    {
        return $this->container[$offset] ?? null;
    }

    /**
     * Sets value based on offset.
     *
     * @param int|null $offset Offset
     * @param mixed    $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value): void
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset): void
    {
        unset($this->container[$offset]);
    }

    /**
     * Serializes the object to a value that can be serialized natively by json_encode().
     * @link https://www.php.net/manual/en/jsonserializable.jsonserialize.php
     *
     * @return mixed Returns data which can be serialized by json_encode(), which is a value
     * of any type other than a resource.
     */
    #[\ReturnTypeWillChange]
    public function jsonSerialize()
    {
       return ObjectSerializer::sanitizeForSerialization($this);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_PRETTY_PRINT
        );
    }

    /**
     * Gets a header-safe presentation of the object
     *
     * @return string
     */
    public function toHeaderValue()
    {
        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}



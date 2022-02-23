<?php
/**
 * OAuth2Client
 *
 * PHP version 7.3
 *
 * @category Class
 * @package  Ory\Hydra\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * Ory Oathkeeper API
 *
 * Documentation for all of Ory Oathkeeper's APIs.
 *
 * The version of the OpenAPI document: v1.11.6
 * Contact: hi@ory.sh
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 5.4.0
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace Ory\Hydra\Client\Model;

use \ArrayAccess;
use \Ory\Hydra\Client\ObjectSerializer;

/**
 * OAuth2Client Class Doc Comment
 *
 * @category Class
 * @package  Ory\Hydra\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<TKey, TValue>
 * @template TKey int|null
 * @template TValue mixed|null
 */
class OAuth2Client implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'oAuth2Client';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'allowedCorsOrigins' => 'string[]',
        'audience' => 'string[]',
        'backchannelLogoutSessionRequired' => 'bool',
        'backchannelLogoutUri' => 'string',
        'clientId' => 'string',
        'clientName' => 'string',
        'clientSecret' => 'string',
        'clientSecretExpiresAt' => 'int',
        'clientUri' => 'string',
        'contacts' => 'string[]',
        'createdAt' => '\DateTime',
        'frontchannelLogoutSessionRequired' => 'bool',
        'frontchannelLogoutUri' => 'string',
        'grantTypes' => 'string[]',
        'jwks' => 'object',
        'jwksUri' => 'string',
        'logoUri' => 'string',
        'metadata' => 'object',
        'owner' => 'string',
        'policyUri' => 'string',
        'postLogoutRedirectUris' => 'string[]',
        'redirectUris' => 'string[]',
        'registrationAccessToken' => 'string',
        'registrationClientUri' => 'string',
        'requestObjectSigningAlg' => 'string',
        'requestUris' => 'string[]',
        'responseTypes' => 'string[]',
        'scope' => 'string',
        'sectorIdentifierUri' => 'string',
        'subjectType' => 'string',
        'tokenEndpointAuthMethod' => 'string',
        'tokenEndpointAuthSigningAlg' => 'string',
        'tosUri' => 'string',
        'updatedAt' => '\DateTime',
        'userinfoSignedResponseAlg' => 'string'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      * @phpstan-var array<string, string|null>
      * @psalm-var array<string, string|null>
      */
    protected static $openAPIFormats = [
        'allowedCorsOrigins' => null,
        'audience' => null,
        'backchannelLogoutSessionRequired' => null,
        'backchannelLogoutUri' => null,
        'clientId' => null,
        'clientName' => null,
        'clientSecret' => null,
        'clientSecretExpiresAt' => 'int64',
        'clientUri' => null,
        'contacts' => null,
        'createdAt' => 'date-time',
        'frontchannelLogoutSessionRequired' => null,
        'frontchannelLogoutUri' => null,
        'grantTypes' => null,
        'jwks' => null,
        'jwksUri' => null,
        'logoUri' => null,
        'metadata' => null,
        'owner' => null,
        'policyUri' => null,
        'postLogoutRedirectUris' => null,
        'redirectUris' => null,
        'registrationAccessToken' => null,
        'registrationClientUri' => null,
        'requestObjectSigningAlg' => null,
        'requestUris' => null,
        'responseTypes' => null,
        'scope' => null,
        'sectorIdentifierUri' => null,
        'subjectType' => null,
        'tokenEndpointAuthMethod' => null,
        'tokenEndpointAuthSigningAlg' => null,
        'tosUri' => null,
        'updatedAt' => 'date-time',
        'userinfoSignedResponseAlg' => null
    ];

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
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'allowedCorsOrigins' => 'allowed_cors_origins',
        'audience' => 'audience',
        'backchannelLogoutSessionRequired' => 'backchannel_logout_session_required',
        'backchannelLogoutUri' => 'backchannel_logout_uri',
        'clientId' => 'client_id',
        'clientName' => 'client_name',
        'clientSecret' => 'client_secret',
        'clientSecretExpiresAt' => 'client_secret_expires_at',
        'clientUri' => 'client_uri',
        'contacts' => 'contacts',
        'createdAt' => 'created_at',
        'frontchannelLogoutSessionRequired' => 'frontchannel_logout_session_required',
        'frontchannelLogoutUri' => 'frontchannel_logout_uri',
        'grantTypes' => 'grant_types',
        'jwks' => 'jwks',
        'jwksUri' => 'jwks_uri',
        'logoUri' => 'logo_uri',
        'metadata' => 'metadata',
        'owner' => 'owner',
        'policyUri' => 'policy_uri',
        'postLogoutRedirectUris' => 'post_logout_redirect_uris',
        'redirectUris' => 'redirect_uris',
        'registrationAccessToken' => 'registration_access_token',
        'registrationClientUri' => 'registration_client_uri',
        'requestObjectSigningAlg' => 'request_object_signing_alg',
        'requestUris' => 'request_uris',
        'responseTypes' => 'response_types',
        'scope' => 'scope',
        'sectorIdentifierUri' => 'sector_identifier_uri',
        'subjectType' => 'subject_type',
        'tokenEndpointAuthMethod' => 'token_endpoint_auth_method',
        'tokenEndpointAuthSigningAlg' => 'token_endpoint_auth_signing_alg',
        'tosUri' => 'tos_uri',
        'updatedAt' => 'updated_at',
        'userinfoSignedResponseAlg' => 'userinfo_signed_response_alg'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'allowedCorsOrigins' => 'setAllowedCorsOrigins',
        'audience' => 'setAudience',
        'backchannelLogoutSessionRequired' => 'setBackchannelLogoutSessionRequired',
        'backchannelLogoutUri' => 'setBackchannelLogoutUri',
        'clientId' => 'setClientId',
        'clientName' => 'setClientName',
        'clientSecret' => 'setClientSecret',
        'clientSecretExpiresAt' => 'setClientSecretExpiresAt',
        'clientUri' => 'setClientUri',
        'contacts' => 'setContacts',
        'createdAt' => 'setCreatedAt',
        'frontchannelLogoutSessionRequired' => 'setFrontchannelLogoutSessionRequired',
        'frontchannelLogoutUri' => 'setFrontchannelLogoutUri',
        'grantTypes' => 'setGrantTypes',
        'jwks' => 'setJwks',
        'jwksUri' => 'setJwksUri',
        'logoUri' => 'setLogoUri',
        'metadata' => 'setMetadata',
        'owner' => 'setOwner',
        'policyUri' => 'setPolicyUri',
        'postLogoutRedirectUris' => 'setPostLogoutRedirectUris',
        'redirectUris' => 'setRedirectUris',
        'registrationAccessToken' => 'setRegistrationAccessToken',
        'registrationClientUri' => 'setRegistrationClientUri',
        'requestObjectSigningAlg' => 'setRequestObjectSigningAlg',
        'requestUris' => 'setRequestUris',
        'responseTypes' => 'setResponseTypes',
        'scope' => 'setScope',
        'sectorIdentifierUri' => 'setSectorIdentifierUri',
        'subjectType' => 'setSubjectType',
        'tokenEndpointAuthMethod' => 'setTokenEndpointAuthMethod',
        'tokenEndpointAuthSigningAlg' => 'setTokenEndpointAuthSigningAlg',
        'tosUri' => 'setTosUri',
        'updatedAt' => 'setUpdatedAt',
        'userinfoSignedResponseAlg' => 'setUserinfoSignedResponseAlg'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'allowedCorsOrigins' => 'getAllowedCorsOrigins',
        'audience' => 'getAudience',
        'backchannelLogoutSessionRequired' => 'getBackchannelLogoutSessionRequired',
        'backchannelLogoutUri' => 'getBackchannelLogoutUri',
        'clientId' => 'getClientId',
        'clientName' => 'getClientName',
        'clientSecret' => 'getClientSecret',
        'clientSecretExpiresAt' => 'getClientSecretExpiresAt',
        'clientUri' => 'getClientUri',
        'contacts' => 'getContacts',
        'createdAt' => 'getCreatedAt',
        'frontchannelLogoutSessionRequired' => 'getFrontchannelLogoutSessionRequired',
        'frontchannelLogoutUri' => 'getFrontchannelLogoutUri',
        'grantTypes' => 'getGrantTypes',
        'jwks' => 'getJwks',
        'jwksUri' => 'getJwksUri',
        'logoUri' => 'getLogoUri',
        'metadata' => 'getMetadata',
        'owner' => 'getOwner',
        'policyUri' => 'getPolicyUri',
        'postLogoutRedirectUris' => 'getPostLogoutRedirectUris',
        'redirectUris' => 'getRedirectUris',
        'registrationAccessToken' => 'getRegistrationAccessToken',
        'registrationClientUri' => 'getRegistrationClientUri',
        'requestObjectSigningAlg' => 'getRequestObjectSigningAlg',
        'requestUris' => 'getRequestUris',
        'responseTypes' => 'getResponseTypes',
        'scope' => 'getScope',
        'sectorIdentifierUri' => 'getSectorIdentifierUri',
        'subjectType' => 'getSubjectType',
        'tokenEndpointAuthMethod' => 'getTokenEndpointAuthMethod',
        'tokenEndpointAuthSigningAlg' => 'getTokenEndpointAuthSigningAlg',
        'tosUri' => 'getTosUri',
        'updatedAt' => 'getUpdatedAt',
        'userinfoSignedResponseAlg' => 'getUserinfoSignedResponseAlg'
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
        $this->container['allowedCorsOrigins'] = $data['allowedCorsOrigins'] ?? null;
        $this->container['audience'] = $data['audience'] ?? null;
        $this->container['backchannelLogoutSessionRequired'] = $data['backchannelLogoutSessionRequired'] ?? null;
        $this->container['backchannelLogoutUri'] = $data['backchannelLogoutUri'] ?? null;
        $this->container['clientId'] = $data['clientId'] ?? null;
        $this->container['clientName'] = $data['clientName'] ?? null;
        $this->container['clientSecret'] = $data['clientSecret'] ?? null;
        $this->container['clientSecretExpiresAt'] = $data['clientSecretExpiresAt'] ?? null;
        $this->container['clientUri'] = $data['clientUri'] ?? null;
        $this->container['contacts'] = $data['contacts'] ?? null;
        $this->container['createdAt'] = $data['createdAt'] ?? null;
        $this->container['frontchannelLogoutSessionRequired'] = $data['frontchannelLogoutSessionRequired'] ?? null;
        $this->container['frontchannelLogoutUri'] = $data['frontchannelLogoutUri'] ?? null;
        $this->container['grantTypes'] = $data['grantTypes'] ?? null;
        $this->container['jwks'] = $data['jwks'] ?? null;
        $this->container['jwksUri'] = $data['jwksUri'] ?? null;
        $this->container['logoUri'] = $data['logoUri'] ?? null;
        $this->container['metadata'] = $data['metadata'] ?? null;
        $this->container['owner'] = $data['owner'] ?? null;
        $this->container['policyUri'] = $data['policyUri'] ?? null;
        $this->container['postLogoutRedirectUris'] = $data['postLogoutRedirectUris'] ?? null;
        $this->container['redirectUris'] = $data['redirectUris'] ?? null;
        $this->container['registrationAccessToken'] = $data['registrationAccessToken'] ?? null;
        $this->container['registrationClientUri'] = $data['registrationClientUri'] ?? null;
        $this->container['requestObjectSigningAlg'] = $data['requestObjectSigningAlg'] ?? null;
        $this->container['requestUris'] = $data['requestUris'] ?? null;
        $this->container['responseTypes'] = $data['responseTypes'] ?? null;
        $this->container['scope'] = $data['scope'] ?? null;
        $this->container['sectorIdentifierUri'] = $data['sectorIdentifierUri'] ?? null;
        $this->container['subjectType'] = $data['subjectType'] ?? null;
        $this->container['tokenEndpointAuthMethod'] = $data['tokenEndpointAuthMethod'] ?? null;
        $this->container['tokenEndpointAuthSigningAlg'] = $data['tokenEndpointAuthSigningAlg'] ?? null;
        $this->container['tosUri'] = $data['tosUri'] ?? null;
        $this->container['updatedAt'] = $data['updatedAt'] ?? null;
        $this->container['userinfoSignedResponseAlg'] = $data['userinfoSignedResponseAlg'] ?? null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if (!is_null($this->container['scope']) && !preg_match("/([a-zA-Z0-9\\.\\*]+\\s?)+/", $this->container['scope'])) {
            $invalidProperties[] = "invalid value for 'scope', must be conform to the pattern /([a-zA-Z0-9\\.\\*]+\\s?)+/.";
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
     * Gets allowedCorsOrigins
     *
     * @return string[]|null
     */
    public function getAllowedCorsOrigins()
    {
        return $this->container['allowedCorsOrigins'];
    }

    /**
     * Sets allowedCorsOrigins
     *
     * @param string[]|null $allowedCorsOrigins allowedCorsOrigins
     *
     * @return self
     */
    public function setAllowedCorsOrigins($allowedCorsOrigins)
    {
        $this->container['allowedCorsOrigins'] = $allowedCorsOrigins;

        return $this;
    }

    /**
     * Gets audience
     *
     * @return string[]|null
     */
    public function getAudience()
    {
        return $this->container['audience'];
    }

    /**
     * Sets audience
     *
     * @param string[]|null $audience audience
     *
     * @return self
     */
    public function setAudience($audience)
    {
        $this->container['audience'] = $audience;

        return $this;
    }

    /**
     * Gets backchannelLogoutSessionRequired
     *
     * @return bool|null
     */
    public function getBackchannelLogoutSessionRequired()
    {
        return $this->container['backchannelLogoutSessionRequired'];
    }

    /**
     * Sets backchannelLogoutSessionRequired
     *
     * @param bool|null $backchannelLogoutSessionRequired Boolean value specifying whether the RP requires that a sid (session ID) Claim be included in the Logout Token to identify the RP session with the OP when the backchannel_logout_uri is used. If omitted, the default value is false.
     *
     * @return self
     */
    public function setBackchannelLogoutSessionRequired($backchannelLogoutSessionRequired)
    {
        $this->container['backchannelLogoutSessionRequired'] = $backchannelLogoutSessionRequired;

        return $this;
    }

    /**
     * Gets backchannelLogoutUri
     *
     * @return string|null
     */
    public function getBackchannelLogoutUri()
    {
        return $this->container['backchannelLogoutUri'];
    }

    /**
     * Sets backchannelLogoutUri
     *
     * @param string|null $backchannelLogoutUri RP URL that will cause the RP to log itself out when sent a Logout Token by the OP.
     *
     * @return self
     */
    public function setBackchannelLogoutUri($backchannelLogoutUri)
    {
        $this->container['backchannelLogoutUri'] = $backchannelLogoutUri;

        return $this;
    }

    /**
     * Gets clientId
     *
     * @return string|null
     */
    public function getClientId()
    {
        return $this->container['clientId'];
    }

    /**
     * Sets clientId
     *
     * @param string|null $clientId ID  is the id for this client.
     *
     * @return self
     */
    public function setClientId($clientId)
    {
        $this->container['clientId'] = $clientId;

        return $this;
    }

    /**
     * Gets clientName
     *
     * @return string|null
     */
    public function getClientName()
    {
        return $this->container['clientName'];
    }

    /**
     * Sets clientName
     *
     * @param string|null $clientName Name is the human-readable string name of the client to be presented to the end-user during authorization.
     *
     * @return self
     */
    public function setClientName($clientName)
    {
        $this->container['clientName'] = $clientName;

        return $this;
    }

    /**
     * Gets clientSecret
     *
     * @return string|null
     */
    public function getClientSecret()
    {
        return $this->container['clientSecret'];
    }

    /**
     * Sets clientSecret
     *
     * @param string|null $clientSecret Secret is the client's secret. The secret will be included in the create request as cleartext, and then never again. The secret is stored using BCrypt so it is impossible to recover it. Tell your users that they need to write the secret down as it will not be made available again.
     *
     * @return self
     */
    public function setClientSecret($clientSecret)
    {
        $this->container['clientSecret'] = $clientSecret;

        return $this;
    }

    /**
     * Gets clientSecretExpiresAt
     *
     * @return int|null
     */
    public function getClientSecretExpiresAt()
    {
        return $this->container['clientSecretExpiresAt'];
    }

    /**
     * Sets clientSecretExpiresAt
     *
     * @param int|null $clientSecretExpiresAt SecretExpiresAt is an integer holding the time at which the client secret will expire or 0 if it will not expire. The time is represented as the number of seconds from 1970-01-01T00:00:00Z as measured in UTC until the date/time of expiration.  This feature is currently not supported and it's value will always be set to 0.
     *
     * @return self
     */
    public function setClientSecretExpiresAt($clientSecretExpiresAt)
    {
        $this->container['clientSecretExpiresAt'] = $clientSecretExpiresAt;

        return $this;
    }

    /**
     * Gets clientUri
     *
     * @return string|null
     */
    public function getClientUri()
    {
        return $this->container['clientUri'];
    }

    /**
     * Sets clientUri
     *
     * @param string|null $clientUri ClientURI is an URL string of a web page providing information about the client. If present, the server SHOULD display this URL to the end-user in a clickable fashion.
     *
     * @return self
     */
    public function setClientUri($clientUri)
    {
        $this->container['clientUri'] = $clientUri;

        return $this;
    }

    /**
     * Gets contacts
     *
     * @return string[]|null
     */
    public function getContacts()
    {
        return $this->container['contacts'];
    }

    /**
     * Sets contacts
     *
     * @param string[]|null $contacts contacts
     *
     * @return self
     */
    public function setContacts($contacts)
    {
        $this->container['contacts'] = $contacts;

        return $this;
    }

    /**
     * Gets createdAt
     *
     * @return \DateTime|null
     */
    public function getCreatedAt()
    {
        return $this->container['createdAt'];
    }

    /**
     * Sets createdAt
     *
     * @param \DateTime|null $createdAt CreatedAt returns the timestamp of the client's creation.
     *
     * @return self
     */
    public function setCreatedAt($createdAt)
    {
        $this->container['createdAt'] = $createdAt;

        return $this;
    }

    /**
     * Gets frontchannelLogoutSessionRequired
     *
     * @return bool|null
     */
    public function getFrontchannelLogoutSessionRequired()
    {
        return $this->container['frontchannelLogoutSessionRequired'];
    }

    /**
     * Sets frontchannelLogoutSessionRequired
     *
     * @param bool|null $frontchannelLogoutSessionRequired Boolean value specifying whether the RP requires that iss (issuer) and sid (session ID) query parameters be included to identify the RP session with the OP when the frontchannel_logout_uri is used. If omitted, the default value is false.
     *
     * @return self
     */
    public function setFrontchannelLogoutSessionRequired($frontchannelLogoutSessionRequired)
    {
        $this->container['frontchannelLogoutSessionRequired'] = $frontchannelLogoutSessionRequired;

        return $this;
    }

    /**
     * Gets frontchannelLogoutUri
     *
     * @return string|null
     */
    public function getFrontchannelLogoutUri()
    {
        return $this->container['frontchannelLogoutUri'];
    }

    /**
     * Sets frontchannelLogoutUri
     *
     * @param string|null $frontchannelLogoutUri RP URL that will cause the RP to log itself out when rendered in an iframe by the OP. An iss (issuer) query parameter and a sid (session ID) query parameter MAY be included by the OP to enable the RP to validate the request and to determine which of the potentially multiple sessions is to be logged out; if either is included, both MUST be.
     *
     * @return self
     */
    public function setFrontchannelLogoutUri($frontchannelLogoutUri)
    {
        $this->container['frontchannelLogoutUri'] = $frontchannelLogoutUri;

        return $this;
    }

    /**
     * Gets grantTypes
     *
     * @return string[]|null
     */
    public function getGrantTypes()
    {
        return $this->container['grantTypes'];
    }

    /**
     * Sets grantTypes
     *
     * @param string[]|null $grantTypes grantTypes
     *
     * @return self
     */
    public function setGrantTypes($grantTypes)
    {
        $this->container['grantTypes'] = $grantTypes;

        return $this;
    }

    /**
     * Gets jwks
     *
     * @return object|null
     */
    public function getJwks()
    {
        return $this->container['jwks'];
    }

    /**
     * Sets jwks
     *
     * @param object|null $jwks jwks
     *
     * @return self
     */
    public function setJwks($jwks)
    {
        $this->container['jwks'] = $jwks;

        return $this;
    }

    /**
     * Gets jwksUri
     *
     * @return string|null
     */
    public function getJwksUri()
    {
        return $this->container['jwksUri'];
    }

    /**
     * Sets jwksUri
     *
     * @param string|null $jwksUri URL for the Client's JSON Web Key Set [JWK] document. If the Client signs requests to the Server, it contains the signing key(s) the Server uses to validate signatures from the Client. The JWK Set MAY also contain the Client's encryption keys(s), which are used by the Server to encrypt responses to the Client. When both signing and encryption keys are made available, a use (Key Use) parameter value is REQUIRED for all keys in the referenced JWK Set to indicate each key's intended usage. Although some algorithms allow the same key to be used for both signatures and encryption, doing so is NOT RECOMMENDED, as it is less secure. The JWK x5c parameter MAY be used to provide X.509 representations of keys provided. When used, the bare key values MUST still be present and MUST match those in the certificate.
     *
     * @return self
     */
    public function setJwksUri($jwksUri)
    {
        $this->container['jwksUri'] = $jwksUri;

        return $this;
    }

    /**
     * Gets logoUri
     *
     * @return string|null
     */
    public function getLogoUri()
    {
        return $this->container['logoUri'];
    }

    /**
     * Sets logoUri
     *
     * @param string|null $logoUri LogoURI is an URL string that references a logo for the client.
     *
     * @return self
     */
    public function setLogoUri($logoUri)
    {
        $this->container['logoUri'] = $logoUri;

        return $this;
    }

    /**
     * Gets metadata
     *
     * @return object|null
     */
    public function getMetadata()
    {
        return $this->container['metadata'];
    }

    /**
     * Sets metadata
     *
     * @param object|null $metadata metadata
     *
     * @return self
     */
    public function setMetadata($metadata)
    {
        $this->container['metadata'] = $metadata;

        return $this;
    }

    /**
     * Gets owner
     *
     * @return string|null
     */
    public function getOwner()
    {
        return $this->container['owner'];
    }

    /**
     * Sets owner
     *
     * @param string|null $owner Owner is a string identifying the owner of the OAuth 2.0 Client.
     *
     * @return self
     */
    public function setOwner($owner)
    {
        $this->container['owner'] = $owner;

        return $this;
    }

    /**
     * Gets policyUri
     *
     * @return string|null
     */
    public function getPolicyUri()
    {
        return $this->container['policyUri'];
    }

    /**
     * Sets policyUri
     *
     * @param string|null $policyUri PolicyURI is a URL string that points to a human-readable privacy policy document that describes how the deployment organization collects, uses, retains, and discloses personal data.
     *
     * @return self
     */
    public function setPolicyUri($policyUri)
    {
        $this->container['policyUri'] = $policyUri;

        return $this;
    }

    /**
     * Gets postLogoutRedirectUris
     *
     * @return string[]|null
     */
    public function getPostLogoutRedirectUris()
    {
        return $this->container['postLogoutRedirectUris'];
    }

    /**
     * Sets postLogoutRedirectUris
     *
     * @param string[]|null $postLogoutRedirectUris postLogoutRedirectUris
     *
     * @return self
     */
    public function setPostLogoutRedirectUris($postLogoutRedirectUris)
    {
        $this->container['postLogoutRedirectUris'] = $postLogoutRedirectUris;

        return $this;
    }

    /**
     * Gets redirectUris
     *
     * @return string[]|null
     */
    public function getRedirectUris()
    {
        return $this->container['redirectUris'];
    }

    /**
     * Sets redirectUris
     *
     * @param string[]|null $redirectUris redirectUris
     *
     * @return self
     */
    public function setRedirectUris($redirectUris)
    {
        $this->container['redirectUris'] = $redirectUris;

        return $this;
    }

    /**
     * Gets registrationAccessToken
     *
     * @return string|null
     */
    public function getRegistrationAccessToken()
    {
        return $this->container['registrationAccessToken'];
    }

    /**
     * Sets registrationAccessToken
     *
     * @param string|null $registrationAccessToken RegistrationAccessToken can be used to update, get, or delete the OAuth2 Client.
     *
     * @return self
     */
    public function setRegistrationAccessToken($registrationAccessToken)
    {
        $this->container['registrationAccessToken'] = $registrationAccessToken;

        return $this;
    }

    /**
     * Gets registrationClientUri
     *
     * @return string|null
     */
    public function getRegistrationClientUri()
    {
        return $this->container['registrationClientUri'];
    }

    /**
     * Sets registrationClientUri
     *
     * @param string|null $registrationClientUri RegistrationClientURI is the URL used to update, get, or delete the OAuth2 Client.
     *
     * @return self
     */
    public function setRegistrationClientUri($registrationClientUri)
    {
        $this->container['registrationClientUri'] = $registrationClientUri;

        return $this;
    }

    /**
     * Gets requestObjectSigningAlg
     *
     * @return string|null
     */
    public function getRequestObjectSigningAlg()
    {
        return $this->container['requestObjectSigningAlg'];
    }

    /**
     * Sets requestObjectSigningAlg
     *
     * @param string|null $requestObjectSigningAlg JWS [JWS] alg algorithm [JWA] that MUST be used for signing Request Objects sent to the OP. All Request Objects from this Client MUST be rejected, if not signed with this algorithm.
     *
     * @return self
     */
    public function setRequestObjectSigningAlg($requestObjectSigningAlg)
    {
        $this->container['requestObjectSigningAlg'] = $requestObjectSigningAlg;

        return $this;
    }

    /**
     * Gets requestUris
     *
     * @return string[]|null
     */
    public function getRequestUris()
    {
        return $this->container['requestUris'];
    }

    /**
     * Sets requestUris
     *
     * @param string[]|null $requestUris requestUris
     *
     * @return self
     */
    public function setRequestUris($requestUris)
    {
        $this->container['requestUris'] = $requestUris;

        return $this;
    }

    /**
     * Gets responseTypes
     *
     * @return string[]|null
     */
    public function getResponseTypes()
    {
        return $this->container['responseTypes'];
    }

    /**
     * Sets responseTypes
     *
     * @param string[]|null $responseTypes responseTypes
     *
     * @return self
     */
    public function setResponseTypes($responseTypes)
    {
        $this->container['responseTypes'] = $responseTypes;

        return $this;
    }

    /**
     * Gets scope
     *
     * @return string|null
     */
    public function getScope()
    {
        return $this->container['scope'];
    }

    /**
     * Sets scope
     *
     * @param string|null $scope Scope is a string containing a space-separated list of scope values (as described in Section 3.3 of OAuth 2.0 [RFC6749]) that the client can use when requesting access tokens.
     *
     * @return self
     */
    public function setScope($scope)
    {

        if (!is_null($scope) && (!preg_match("/([a-zA-Z0-9\\.\\*]+\\s?)+/", $scope))) {
            throw new \InvalidArgumentException("invalid value for $scope when calling OAuth2Client., must conform to the pattern /([a-zA-Z0-9\\.\\*]+\\s?)+/.");
        }

        $this->container['scope'] = $scope;

        return $this;
    }

    /**
     * Gets sectorIdentifierUri
     *
     * @return string|null
     */
    public function getSectorIdentifierUri()
    {
        return $this->container['sectorIdentifierUri'];
    }

    /**
     * Sets sectorIdentifierUri
     *
     * @param string|null $sectorIdentifierUri URL using the https scheme to be used in calculating Pseudonymous Identifiers by the OP. The URL references a file with a single JSON array of redirect_uri values.
     *
     * @return self
     */
    public function setSectorIdentifierUri($sectorIdentifierUri)
    {
        $this->container['sectorIdentifierUri'] = $sectorIdentifierUri;

        return $this;
    }

    /**
     * Gets subjectType
     *
     * @return string|null
     */
    public function getSubjectType()
    {
        return $this->container['subjectType'];
    }

    /**
     * Sets subjectType
     *
     * @param string|null $subjectType SubjectType requested for responses to this Client. The subject_types_supported Discovery parameter contains a list of the supported subject_type values for this server. Valid types include `pairwise` and `public`.
     *
     * @return self
     */
    public function setSubjectType($subjectType)
    {
        $this->container['subjectType'] = $subjectType;

        return $this;
    }

    /**
     * Gets tokenEndpointAuthMethod
     *
     * @return string|null
     */
    public function getTokenEndpointAuthMethod()
    {
        return $this->container['tokenEndpointAuthMethod'];
    }

    /**
     * Sets tokenEndpointAuthMethod
     *
     * @param string|null $tokenEndpointAuthMethod Requested Client Authentication method for the Token Endpoint. The options are client_secret_post, client_secret_basic, private_key_jwt, and none.
     *
     * @return self
     */
    public function setTokenEndpointAuthMethod($tokenEndpointAuthMethod)
    {
        $this->container['tokenEndpointAuthMethod'] = $tokenEndpointAuthMethod;

        return $this;
    }

    /**
     * Gets tokenEndpointAuthSigningAlg
     *
     * @return string|null
     */
    public function getTokenEndpointAuthSigningAlg()
    {
        return $this->container['tokenEndpointAuthSigningAlg'];
    }

    /**
     * Sets tokenEndpointAuthSigningAlg
     *
     * @param string|null $tokenEndpointAuthSigningAlg Requested Client Authentication signing algorithm for the Token Endpoint.
     *
     * @return self
     */
    public function setTokenEndpointAuthSigningAlg($tokenEndpointAuthSigningAlg)
    {
        $this->container['tokenEndpointAuthSigningAlg'] = $tokenEndpointAuthSigningAlg;

        return $this;
    }

    /**
     * Gets tosUri
     *
     * @return string|null
     */
    public function getTosUri()
    {
        return $this->container['tosUri'];
    }

    /**
     * Sets tosUri
     *
     * @param string|null $tosUri TermsOfServiceURI is a URL string that points to a human-readable terms of service document for the client that describes a contractual relationship between the end-user and the client that the end-user accepts when authorizing the client.
     *
     * @return self
     */
    public function setTosUri($tosUri)
    {
        $this->container['tosUri'] = $tosUri;

        return $this;
    }

    /**
     * Gets updatedAt
     *
     * @return \DateTime|null
     */
    public function getUpdatedAt()
    {
        return $this->container['updatedAt'];
    }

    /**
     * Sets updatedAt
     *
     * @param \DateTime|null $updatedAt UpdatedAt returns the timestamp of the last update.
     *
     * @return self
     */
    public function setUpdatedAt($updatedAt)
    {
        $this->container['updatedAt'] = $updatedAt;

        return $this;
    }

    /**
     * Gets userinfoSignedResponseAlg
     *
     * @return string|null
     */
    public function getUserinfoSignedResponseAlg()
    {
        return $this->container['userinfoSignedResponseAlg'];
    }

    /**
     * Sets userinfoSignedResponseAlg
     *
     * @param string|null $userinfoSignedResponseAlg JWS alg algorithm [JWA] REQUIRED for signing UserInfo Responses. If this is specified, the response will be JWT [JWT] serialized, and signed using JWS. The default, if omitted, is for the UserInfo Response to return the Claims as a UTF-8 encoded JSON object using the application/json content-type.
     *
     * @return self
     */
    public function setUserinfoSignedResponseAlg($userinfoSignedResponseAlg)
    {
        $this->container['userinfoSignedResponseAlg'] = $userinfoSignedResponseAlg;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
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
    public function offsetSet($offset, $value)
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
    public function offsetUnset($offset)
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



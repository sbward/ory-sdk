/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.6
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface AcceptOAuth2LoginRequest
 */
export interface AcceptOAuth2LoginRequest {
    /**
     * ACR sets the Authentication AuthorizationContext Class Reference value for this authentication session. You can use it
     * to express that, for example, a user authenticated using two factor authentication.
     * @type {string}
     * @memberof AcceptOAuth2LoginRequest
     */
    acr?: string;
    /**
     * 
     * @type {Array<string>}
     * @memberof AcceptOAuth2LoginRequest
     */
    amr?: Array<string>;
    /**
     * 
     * @type {object}
     * @memberof AcceptOAuth2LoginRequest
     */
    context?: object;
    /**
     * Extend OAuth2 authentication session lifespan
     * 
     * If set to `true`, the OAuth2 authentication cookie lifespan is extended. This is for example useful if you want the user to be able to use `prompt=none` continuously.
     * 
     * This value can only be set to `true` if the user has an authentication, which is the case if the `skip` value is `true`.
     * @type {boolean}
     * @memberof AcceptOAuth2LoginRequest
     */
    extend_session_lifespan?: boolean;
    /**
     * ForceSubjectIdentifier forces the "pairwise" user ID of the end-user that authenticated. The "pairwise" user ID refers to the
     * (Pairwise Identifier Algorithm)[http://openid.net/specs/openid-connect-core-1_0.html#PairwiseAlg] of the OpenID
     * Connect specification. It allows you to set an obfuscated subject ("user") identifier that is unique to the client.
     * 
     * Please note that this changes the user ID on endpoint /userinfo and sub claim of the ID Token. It does not change the
     * sub claim in the OAuth 2.0 Introspection.
     * 
     * Per default, ORY Hydra handles this value with its own algorithm. In case you want to set this yourself
     * you can use this field. Please note that setting this field has no effect if `pairwise` is not configured in
     * ORY Hydra or the OAuth 2.0 Client does not expect a pairwise identifier (set via `subject_type` key in the client's
     * configuration).
     * 
     * Please also be aware that ORY Hydra is unable to properly compute this value during authentication. This implies
     * that you have to compute this value on every authentication process (probably depending on the client ID or some
     * other unique value).
     * 
     * If you fail to compute the proper value, then authentication processes which have id_token_hint set might fail.
     * @type {string}
     * @memberof AcceptOAuth2LoginRequest
     */
    force_subject_identifier?: string;
    /**
     * IdentityProviderSessionID is the session ID of the end-user that authenticated.
     * If specified, we will use this value to propagate the logout.
     * @type {string}
     * @memberof AcceptOAuth2LoginRequest
     */
    identity_provider_session_id?: string;
    /**
     * Remember, if set to true, tells ORY Hydra to remember this user by telling the user agent (browser) to store
     * a cookie with authentication data. If the same user performs another OAuth 2.0 Authorization Request, he/she
     * will not be asked to log in again.
     * @type {boolean}
     * @memberof AcceptOAuth2LoginRequest
     */
    remember?: boolean;
    /**
     * RememberFor sets how long the authentication should be remembered for in seconds. If set to `0`, the
     * authorization will be remembered for the duration of the browser session (using a session cookie).
     * @type {number}
     * @memberof AcceptOAuth2LoginRequest
     */
    remember_for?: number;
    /**
     * Subject is the user ID of the end-user that authenticated.
     * @type {string}
     * @memberof AcceptOAuth2LoginRequest
     */
    subject: string;
}

/**
 * Check if a given object implements the AcceptOAuth2LoginRequest interface.
 */
export function instanceOfAcceptOAuth2LoginRequest(value: object): value is AcceptOAuth2LoginRequest {
    if (!('subject' in value) || value['subject'] === undefined) return false;
    return true;
}

export function AcceptOAuth2LoginRequestFromJSON(json: any): AcceptOAuth2LoginRequest {
    return AcceptOAuth2LoginRequestFromJSONTyped(json, false);
}

export function AcceptOAuth2LoginRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): AcceptOAuth2LoginRequest {
    if (json == null) {
        return json;
    }
    return {
        
        'acr': json['acr'] == null ? undefined : json['acr'],
        'amr': json['amr'] == null ? undefined : json['amr'],
        'context': json['context'] == null ? undefined : json['context'],
        'extend_session_lifespan': json['extend_session_lifespan'] == null ? undefined : json['extend_session_lifespan'],
        'force_subject_identifier': json['force_subject_identifier'] == null ? undefined : json['force_subject_identifier'],
        'identity_provider_session_id': json['identity_provider_session_id'] == null ? undefined : json['identity_provider_session_id'],
        'remember': json['remember'] == null ? undefined : json['remember'],
        'remember_for': json['remember_for'] == null ? undefined : json['remember_for'],
        'subject': json['subject'],
    };
}

export function AcceptOAuth2LoginRequestToJSON(value?: AcceptOAuth2LoginRequest | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'acr': value['acr'],
        'amr': value['amr'],
        'context': value['context'],
        'extend_session_lifespan': value['extend_session_lifespan'],
        'force_subject_identifier': value['force_subject_identifier'],
        'identity_provider_session_id': value['identity_provider_session_id'],
        'remember': value['remember'],
        'remember_for': value['remember_for'],
        'subject': value['subject'],
    };
}


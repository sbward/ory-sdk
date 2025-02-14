/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.7
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
 * @interface RejectOAuth2Request
 */
export interface RejectOAuth2Request {
    /**
     * The error should follow the OAuth2 error format (e.g. `invalid_request`, `login_required`).
     * 
     * Defaults to `request_denied`.
     * @type {string}
     * @memberof RejectOAuth2Request
     */
    error?: string;
    /**
     * Debug contains information to help resolve the problem as a developer. Usually not exposed
     * to the public but only in the server logs.
     * @type {string}
     * @memberof RejectOAuth2Request
     */
    error_debug?: string;
    /**
     * Description of the error in a human readable format.
     * @type {string}
     * @memberof RejectOAuth2Request
     */
    error_description?: string;
    /**
     * Hint to help resolve the error.
     * @type {string}
     * @memberof RejectOAuth2Request
     */
    error_hint?: string;
    /**
     * Represents the HTTP status code of the error (e.g. 401 or 403)
     * 
     * Defaults to 400
     * @type {number}
     * @memberof RejectOAuth2Request
     */
    status_code?: number;
}

/**
 * Check if a given object implements the RejectOAuth2Request interface.
 */
export function instanceOfRejectOAuth2Request(value: object): value is RejectOAuth2Request {
    return true;
}

export function RejectOAuth2RequestFromJSON(json: any): RejectOAuth2Request {
    return RejectOAuth2RequestFromJSONTyped(json, false);
}

export function RejectOAuth2RequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): RejectOAuth2Request {
    if (json == null) {
        return json;
    }
    return {
        
        'error': json['error'] == null ? undefined : json['error'],
        'error_debug': json['error_debug'] == null ? undefined : json['error_debug'],
        'error_description': json['error_description'] == null ? undefined : json['error_description'],
        'error_hint': json['error_hint'] == null ? undefined : json['error_hint'],
        'status_code': json['status_code'] == null ? undefined : json['status_code'],
    };
}

export function RejectOAuth2RequestToJSON(value?: RejectOAuth2Request | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'error': value['error'],
        'error_debug': value['error_debug'],
        'error_description': value['error_description'],
        'error_hint': value['error_hint'],
        'status_code': value['status_code'],
    };
}


/* tslint:disable */
/* eslint-disable */
/**
 * Ory Hydra API
 * Documentation for all of Ory Hydra\'s APIs. 
 *
 * The version of the OpenAPI document: v2.4.0-alpha.1
 * Contact: hi@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface IsReady200Response
 */
export interface IsReady200Response {
    /**
     * Always "ok".
     * @type {string}
     * @memberof IsReady200Response
     */
    status?: string;
}

/**
 * Check if a given object implements the IsReady200Response interface.
 */
export function instanceOfIsReady200Response(value: object): value is IsReady200Response {
    return true;
}

export function IsReady200ResponseFromJSON(json: any): IsReady200Response {
    return IsReady200ResponseFromJSONTyped(json, false);
}

export function IsReady200ResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): IsReady200Response {
    if (json == null) {
        return json;
    }
    return {
        
        'status': json['status'] == null ? undefined : json['status'],
    };
}

export function IsReady200ResponseToJSON(value?: IsReady200Response | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'status': value['status'],
    };
}


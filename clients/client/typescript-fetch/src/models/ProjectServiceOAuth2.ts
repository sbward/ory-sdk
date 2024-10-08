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
 * @interface ProjectServiceOAuth2
 */
export interface ProjectServiceOAuth2 {
    /**
     * 
     * @type {object}
     * @memberof ProjectServiceOAuth2
     */
    config: object;
}

/**
 * Check if a given object implements the ProjectServiceOAuth2 interface.
 */
export function instanceOfProjectServiceOAuth2(value: object): value is ProjectServiceOAuth2 {
    if (!('config' in value) || value['config'] === undefined) return false;
    return true;
}

export function ProjectServiceOAuth2FromJSON(json: any): ProjectServiceOAuth2 {
    return ProjectServiceOAuth2FromJSONTyped(json, false);
}

export function ProjectServiceOAuth2FromJSONTyped(json: any, ignoreDiscriminator: boolean): ProjectServiceOAuth2 {
    if (json == null) {
        return json;
    }
    return {
        
        'config': json['config'],
    };
}

export function ProjectServiceOAuth2ToJSON(value?: ProjectServiceOAuth2 | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'config': value['config'],
    };
}


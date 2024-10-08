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
 * @interface InternalIsOwnerForProjectBySlugResponse
 */
export interface InternalIsOwnerForProjectBySlugResponse {
    /**
     * ProjectID is the project's ID.
     * @type {string}
     * @memberof InternalIsOwnerForProjectBySlugResponse
     */
    project_id: string;
}

/**
 * Check if a given object implements the InternalIsOwnerForProjectBySlugResponse interface.
 */
export function instanceOfInternalIsOwnerForProjectBySlugResponse(value: object): value is InternalIsOwnerForProjectBySlugResponse {
    if (!('project_id' in value) || value['project_id'] === undefined) return false;
    return true;
}

export function InternalIsOwnerForProjectBySlugResponseFromJSON(json: any): InternalIsOwnerForProjectBySlugResponse {
    return InternalIsOwnerForProjectBySlugResponseFromJSONTyped(json, false);
}

export function InternalIsOwnerForProjectBySlugResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): InternalIsOwnerForProjectBySlugResponse {
    if (json == null) {
        return json;
    }
    return {
        
        'project_id': json['project_id'],
    };
}

export function InternalIsOwnerForProjectBySlugResponseToJSON(value?: InternalIsOwnerForProjectBySlugResponse | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'project_id': value['project_id'],
    };
}


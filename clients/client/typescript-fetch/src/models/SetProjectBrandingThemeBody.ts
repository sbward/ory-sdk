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
import type { ProjectBrandingColors } from './ProjectBrandingColors';
import {
    ProjectBrandingColorsFromJSON,
    ProjectBrandingColorsFromJSONTyped,
    ProjectBrandingColorsToJSON,
} from './ProjectBrandingColors';

/**
 * 
 * @export
 * @interface SetProjectBrandingThemeBody
 */
export interface SetProjectBrandingThemeBody {
    /**
     * Favicon Type
     * @type {string}
     * @memberof SetProjectBrandingThemeBody
     */
    favicon_type?: string;
    /**
     * Favicon URL
     * @type {string}
     * @memberof SetProjectBrandingThemeBody
     */
    favicon_url?: string;
    /**
     * Logo type
     * @type {string}
     * @memberof SetProjectBrandingThemeBody
     */
    logo_type?: string;
    /**
     * Logo URL
     * @type {string}
     * @memberof SetProjectBrandingThemeBody
     */
    logo_url?: string;
    /**
     * Branding name
     * @type {string}
     * @memberof SetProjectBrandingThemeBody
     */
    name?: string;
    /**
     * 
     * @type {ProjectBrandingColors}
     * @memberof SetProjectBrandingThemeBody
     */
    theme?: ProjectBrandingColors;
}

/**
 * Check if a given object implements the SetProjectBrandingThemeBody interface.
 */
export function instanceOfSetProjectBrandingThemeBody(value: object): value is SetProjectBrandingThemeBody {
    return true;
}

export function SetProjectBrandingThemeBodyFromJSON(json: any): SetProjectBrandingThemeBody {
    return SetProjectBrandingThemeBodyFromJSONTyped(json, false);
}

export function SetProjectBrandingThemeBodyFromJSONTyped(json: any, ignoreDiscriminator: boolean): SetProjectBrandingThemeBody {
    if (json == null) {
        return json;
    }
    return {
        
        'favicon_type': json['favicon_type'] == null ? undefined : json['favicon_type'],
        'favicon_url': json['favicon_url'] == null ? undefined : json['favicon_url'],
        'logo_type': json['logo_type'] == null ? undefined : json['logo_type'],
        'logo_url': json['logo_url'] == null ? undefined : json['logo_url'],
        'name': json['name'] == null ? undefined : json['name'],
        'theme': json['theme'] == null ? undefined : ProjectBrandingColorsFromJSON(json['theme']),
    };
}

export function SetProjectBrandingThemeBodyToJSON(value?: SetProjectBrandingThemeBody | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'favicon_type': value['favicon_type'],
        'favicon_url': value['favicon_url'],
        'logo_type': value['logo_type'],
        'logo_url': value['logo_url'],
        'name': value['name'],
        'theme': ProjectBrandingColorsToJSON(value['theme']),
    };
}


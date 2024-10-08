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
import type { Money } from './Money';
import {
    MoneyFromJSON,
    MoneyFromJSONTyped,
    MoneyToJSON,
} from './Money';

/**
 * 
 * @export
 * @interface GenericUsage
 */
export interface GenericUsage {
    /**
     * 
     * @type {Money}
     * @memberof GenericUsage
     */
    additional_price: Money;
    /**
     * IncludedUsage is the number of included items.
     * @type {number}
     * @memberof GenericUsage
     */
    included_usage: number;
}

/**
 * Check if a given object implements the GenericUsage interface.
 */
export function instanceOfGenericUsage(value: object): value is GenericUsage {
    if (!('additional_price' in value) || value['additional_price'] === undefined) return false;
    if (!('included_usage' in value) || value['included_usage'] === undefined) return false;
    return true;
}

export function GenericUsageFromJSON(json: any): GenericUsage {
    return GenericUsageFromJSONTyped(json, false);
}

export function GenericUsageFromJSONTyped(json: any, ignoreDiscriminator: boolean): GenericUsage {
    if (json == null) {
        return json;
    }
    return {
        
        'additional_price': MoneyFromJSON(json['additional_price']),
        'included_usage': json['included_usage'],
    };
}

export function GenericUsageToJSON(value?: GenericUsage | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'additional_price': MoneyToJSON(value['additional_price']),
        'included_usage': value['included_usage'],
    };
}


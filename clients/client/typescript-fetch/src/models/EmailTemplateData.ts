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
import type { EmailTemplateDataBody } from './EmailTemplateDataBody';
import {
    EmailTemplateDataBodyFromJSON,
    EmailTemplateDataBodyFromJSONTyped,
    EmailTemplateDataBodyToJSON,
} from './EmailTemplateDataBody';

/**
 * Contains the data of the email template, including the subject and body in HTML and plaintext variants
 * @export
 * @interface EmailTemplateData
 */
export interface EmailTemplateData {
    /**
     * 
     * @type {EmailTemplateDataBody}
     * @memberof EmailTemplateData
     */
    body: EmailTemplateDataBody;
    /**
     * 
     * @type {string}
     * @memberof EmailTemplateData
     */
    subject: string;
}

/**
 * Check if a given object implements the EmailTemplateData interface.
 */
export function instanceOfEmailTemplateData(value: object): value is EmailTemplateData {
    if (!('body' in value) || value['body'] === undefined) return false;
    if (!('subject' in value) || value['subject'] === undefined) return false;
    return true;
}

export function EmailTemplateDataFromJSON(json: any): EmailTemplateData {
    return EmailTemplateDataFromJSONTyped(json, false);
}

export function EmailTemplateDataFromJSONTyped(json: any, ignoreDiscriminator: boolean): EmailTemplateData {
    if (json == null) {
        return json;
    }
    return {
        
        'body': EmailTemplateDataBodyFromJSON(json['body']),
        'subject': json['subject'],
    };
}

export function EmailTemplateDataToJSON(value?: EmailTemplateData | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'body': EmailTemplateDataBodyToJSON(value['body']),
        'subject': value['subject'],
    };
}


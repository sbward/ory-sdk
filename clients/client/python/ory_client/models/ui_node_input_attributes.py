# coding: utf-8

"""
    Ory APIs

    # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 

    The version of the OpenAPI document: v1.16.7
    Contact: support@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


from __future__ import annotations
import pprint
import re  # noqa: F401
import json

from pydantic import BaseModel, ConfigDict, Field, StrictBool, StrictInt, StrictStr, field_validator
from typing import Any, ClassVar, Dict, List, Optional
from ory_client.models.ui_text import UiText
from typing import Optional, Set
from typing_extensions import Self

class UiNodeInputAttributes(BaseModel):
    """
    InputAttributes represents the attributes of an input node
    """ # noqa: E501
    autocomplete: Optional[StrictStr] = Field(default=None, description="The autocomplete attribute for the input. email InputAttributeAutocompleteEmail tel InputAttributeAutocompleteTel url InputAttributeAutocompleteUrl current-password InputAttributeAutocompleteCurrentPassword new-password InputAttributeAutocompleteNewPassword one-time-code InputAttributeAutocompleteOneTimeCode")
    disabled: StrictBool = Field(description="Sets the input's disabled field to true or false.")
    label: Optional[UiText] = None
    maxlength: Optional[StrictInt] = Field(default=None, description="MaxLength may contain the input's maximum length.")
    name: StrictStr = Field(description="The input's element name.")
    node_type: StrictStr = Field(description="NodeType represents this node's types. It is a mirror of `node.type` and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \"input\". text Text input Input img Image a Anchor script Script")
    onclick: Optional[StrictStr] = Field(default=None, description="OnClick may contain javascript which should be executed on click. This is primarily used for WebAuthn.  Deprecated: Using OnClick requires the use of eval() which is a security risk. Use OnClickTrigger instead.")
    onclick_trigger: Optional[StrictStr] = Field(default=None, description="OnClickTrigger may contain a WebAuthn trigger which should be executed on click.  The trigger maps to a JavaScript function provided by Ory, which triggers actions such as PassKey registration or login. oryWebAuthnRegistration WebAuthnTriggersWebAuthnRegistration oryWebAuthnLogin WebAuthnTriggersWebAuthnLogin oryPasskeyLogin WebAuthnTriggersPasskeyLogin oryPasskeyLoginAutocompleteInit WebAuthnTriggersPasskeyLoginAutocompleteInit oryPasskeyRegistration WebAuthnTriggersPasskeyRegistration oryPasskeySettingsRegistration WebAuthnTriggersPasskeySettingsRegistration", alias="onclickTrigger")
    onload: Optional[StrictStr] = Field(default=None, description="OnLoad may contain javascript which should be executed on load. This is primarily used for WebAuthn.  Deprecated: Using OnLoad requires the use of eval() which is a security risk. Use OnLoadTrigger instead.")
    onload_trigger: Optional[StrictStr] = Field(default=None, description="OnLoadTrigger may contain a WebAuthn trigger which should be executed on load.  The trigger maps to a JavaScript function provided by Ory, which triggers actions such as PassKey registration or login. oryWebAuthnRegistration WebAuthnTriggersWebAuthnRegistration oryWebAuthnLogin WebAuthnTriggersWebAuthnLogin oryPasskeyLogin WebAuthnTriggersPasskeyLogin oryPasskeyLoginAutocompleteInit WebAuthnTriggersPasskeyLoginAutocompleteInit oryPasskeyRegistration WebAuthnTriggersPasskeyRegistration oryPasskeySettingsRegistration WebAuthnTriggersPasskeySettingsRegistration", alias="onloadTrigger")
    pattern: Optional[StrictStr] = Field(default=None, description="The input's pattern.")
    required: Optional[StrictBool] = Field(default=None, description="Mark this input field as required.")
    type: StrictStr = Field(description="The input's element type. text InputAttributeTypeText password InputAttributeTypePassword number InputAttributeTypeNumber checkbox InputAttributeTypeCheckbox hidden InputAttributeTypeHidden email InputAttributeTypeEmail tel InputAttributeTypeTel submit InputAttributeTypeSubmit button InputAttributeTypeButton datetime-local InputAttributeTypeDateTimeLocal date InputAttributeTypeDate url InputAttributeTypeURI")
    value: Optional[Any] = Field(default=None, description="The input's value.")
    additional_properties: Dict[str, Any] = {}
    __properties: ClassVar[List[str]] = ["autocomplete", "disabled", "label", "maxlength", "name", "node_type", "onclick", "onclickTrigger", "onload", "onloadTrigger", "pattern", "required", "type", "value"]

    @field_validator('autocomplete')
    def autocomplete_validate_enum(cls, value):
        """Validates the enum"""
        if value is None:
            return value

        if value not in set(['email', 'tel', 'url', 'current-password', 'new-password', 'one-time-code']):
            raise ValueError("must be one of enum values ('email', 'tel', 'url', 'current-password', 'new-password', 'one-time-code')")
        return value

    @field_validator('node_type')
    def node_type_validate_enum(cls, value):
        """Validates the enum"""
        if value not in set(['text', 'input', 'img', 'a', 'script']):
            raise ValueError("must be one of enum values ('text', 'input', 'img', 'a', 'script')")
        return value

    @field_validator('onclick_trigger')
    def onclick_trigger_validate_enum(cls, value):
        """Validates the enum"""
        if value is None:
            return value

        if value not in set(['oryWebAuthnRegistration', 'oryWebAuthnLogin', 'oryPasskeyLogin', 'oryPasskeyLoginAutocompleteInit', 'oryPasskeyRegistration', 'oryPasskeySettingsRegistration']):
            raise ValueError("must be one of enum values ('oryWebAuthnRegistration', 'oryWebAuthnLogin', 'oryPasskeyLogin', 'oryPasskeyLoginAutocompleteInit', 'oryPasskeyRegistration', 'oryPasskeySettingsRegistration')")
        return value

    @field_validator('onload_trigger')
    def onload_trigger_validate_enum(cls, value):
        """Validates the enum"""
        if value is None:
            return value

        if value not in set(['oryWebAuthnRegistration', 'oryWebAuthnLogin', 'oryPasskeyLogin', 'oryPasskeyLoginAutocompleteInit', 'oryPasskeyRegistration', 'oryPasskeySettingsRegistration']):
            raise ValueError("must be one of enum values ('oryWebAuthnRegistration', 'oryWebAuthnLogin', 'oryPasskeyLogin', 'oryPasskeyLoginAutocompleteInit', 'oryPasskeyRegistration', 'oryPasskeySettingsRegistration')")
        return value

    @field_validator('type')
    def type_validate_enum(cls, value):
        """Validates the enum"""
        if value not in set(['text', 'password', 'number', 'checkbox', 'hidden', 'email', 'tel', 'submit', 'button', 'datetime-local', 'date', 'url']):
            raise ValueError("must be one of enum values ('text', 'password', 'number', 'checkbox', 'hidden', 'email', 'tel', 'submit', 'button', 'datetime-local', 'date', 'url')")
        return value

    model_config = ConfigDict(
        populate_by_name=True,
        validate_assignment=True,
        protected_namespaces=(),
    )


    def to_str(self) -> str:
        """Returns the string representation of the model using alias"""
        return pprint.pformat(self.model_dump(by_alias=True))

    def to_json(self) -> str:
        """Returns the JSON representation of the model using alias"""
        # TODO: pydantic v2: use .model_dump_json(by_alias=True, exclude_unset=True) instead
        return json.dumps(self.to_dict())

    @classmethod
    def from_json(cls, json_str: str) -> Optional[Self]:
        """Create an instance of UiNodeInputAttributes from a JSON string"""
        return cls.from_dict(json.loads(json_str))

    def to_dict(self) -> Dict[str, Any]:
        """Return the dictionary representation of the model using alias.

        This has the following differences from calling pydantic's
        `self.model_dump(by_alias=True)`:

        * `None` is only added to the output dict for nullable fields that
          were set at model initialization. Other fields with value `None`
          are ignored.
        * Fields in `self.additional_properties` are added to the output dict.
        """
        excluded_fields: Set[str] = set([
            "additional_properties",
        ])

        _dict = self.model_dump(
            by_alias=True,
            exclude=excluded_fields,
            exclude_none=True,
        )
        # override the default output from pydantic by calling `to_dict()` of label
        if self.label:
            _dict['label'] = self.label.to_dict()
        # puts key-value pairs in additional_properties in the top level
        if self.additional_properties is not None:
            for _key, _value in self.additional_properties.items():
                _dict[_key] = _value

        # set to None if value (nullable) is None
        # and model_fields_set contains the field
        if self.value is None and "value" in self.model_fields_set:
            _dict['value'] = None

        return _dict

    @classmethod
    def from_dict(cls, obj: Optional[Dict[str, Any]]) -> Optional[Self]:
        """Create an instance of UiNodeInputAttributes from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "autocomplete": obj.get("autocomplete"),
            "disabled": obj.get("disabled"),
            "label": UiText.from_dict(obj["label"]) if obj.get("label") is not None else None,
            "maxlength": obj.get("maxlength"),
            "name": obj.get("name"),
            "node_type": obj.get("node_type"),
            "onclick": obj.get("onclick"),
            "onclickTrigger": obj.get("onclickTrigger"),
            "onload": obj.get("onload"),
            "onloadTrigger": obj.get("onloadTrigger"),
            "pattern": obj.get("pattern"),
            "required": obj.get("required"),
            "type": obj.get("type"),
            "value": obj.get("value")
        })
        # store additional fields in additional_properties
        for _key in obj.keys():
            if _key not in cls.__properties:
                _obj.additional_properties[_key] = obj.get(_key)

        return _obj



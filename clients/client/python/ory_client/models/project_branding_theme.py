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

from datetime import datetime
from pydantic import BaseModel, ConfigDict, Field, StrictStr
from typing import Any, ClassVar, Dict, List, Optional
from ory_client.models.account_experience_theme_variables import AccountExperienceThemeVariables
from typing import Optional, Set
from typing_extensions import Self

class ProjectBrandingTheme(BaseModel):
    """
    ProjectBrandingTheme
    """ # noqa: E501
    accent_default_color: Optional[StrictStr] = Field(default=None, description="AccentDefaultColor is a hex color code used by the Ory Account Experience theme.")
    accent_disabled_color: Optional[StrictStr] = Field(default=None, description="AccentDisabledColor is a hex color code used by the Ory Account Experience theme.")
    accent_emphasis_color: Optional[StrictStr] = Field(default=None, description="AccentEmphasisColor is a hex color code used by the Ory Account Experience theme.")
    accent_muted_color: Optional[StrictStr] = Field(default=None, description="AccentMutedColor is a hex color code used by the Ory Account Experience theme.")
    accent_subtle_color: Optional[StrictStr] = Field(default=None, description="AccentSubtleColor is a hex color code used by the Ory Account Experience theme.")
    account_experience_variables: Optional[List[AccountExperienceThemeVariables]] = Field(default=None, description="The Account Experience Theme Variables.")
    account_experience_variables_stylesheet: Optional[StrictStr] = Field(default=None, description="AccountExperienceVariableStylesheet holds a reference to the current stylesheet that can be used in the AX")
    background_canvas_color: Optional[StrictStr] = Field(default=None, description="BackgroundCanvasColor is a hex color code used by the Ory Account Experience theme.")
    background_subtle_color: Optional[StrictStr] = Field(default=None, description="BackgroundSubtleColor is a hex color code used by the Ory Account Experience theme.")
    background_surface_color: Optional[StrictStr] = Field(default=None, description="BackgroundSurfaceColor is a hex color code used by the Ory Account Experience theme.")
    border_default_color: Optional[StrictStr] = Field(default=None, description="BorderDefaultColor is a hex color code used by the Ory Account Experience theme.")
    created_at: datetime = Field(description="The Customization Creation Date.")
    error_default_color: Optional[StrictStr] = Field(default=None, description="ErrorDefaultColor is a hex color code used by the Ory Account Experience theme.")
    error_emphasis_color: Optional[StrictStr] = Field(default=None, description="ErrorEmphasisColor is a hex color code used by the Ory Account Experience theme.")
    error_muted_color: Optional[StrictStr] = Field(default=None, description="ErrorMutedColor is a hex color code used by the Ory Account Experience theme.")
    error_subtle_color: Optional[StrictStr] = Field(default=None, description="ErrorSubtleColor is a hex color code used by the Ory Account Experience theme.")
    favicon_type: Optional[StrictStr] = Field(default=None, description="Favicon Type The Favicon mime type.")
    favicon_url: Optional[StrictStr] = Field(default=None, description="Favicon URL Favicon can be an https:// or base64:// URL. If the URL is not allowed, the favicon will be stored inside the Ory Network storage bucket.")
    foreground_default_color: Optional[StrictStr] = Field(default=None, description="ForegroundDefaultColor is a hex color code used by the Ory Account Experience theme.")
    foreground_disabled_color: Optional[StrictStr] = Field(default=None, description="ForegroundDisabledColor is a hex color code used by the Ory Account Experience theme.")
    foreground_muted_color: Optional[StrictStr] = Field(default=None, description="ForegroundMutedColor is a hex color code used by the Ory Account Experience theme.")
    foreground_on_accent_color: Optional[StrictStr] = Field(default=None, description="ForegroundOnAccentColor is a hex color code used by the Ory Account Experience theme.")
    foreground_on_dark_color: Optional[StrictStr] = Field(default=None, description="ForegroundOnDarkColor is a hex color code used by the Ory Account Experience theme.")
    foreground_on_disabled_color: Optional[StrictStr] = Field(default=None, description="ForegroundOnDisabledColor is a hex color code used by the Ory Account Experience theme.")
    foreground_subtle_color: Optional[StrictStr] = Field(default=None, description="ForegroundSubtleColor is a hex color code used by the Ory Account Experience theme.")
    id: StrictStr = Field(description="The customization theme ID.")
    input_background_color: Optional[StrictStr] = Field(default=None, description="InputBackgroundColor is a hex color code used by the Ory Account Experience theme.")
    input_disabled_color: Optional[StrictStr] = Field(default=None, description="InputDisabledColor is a hex color code used by the Ory Account Experience theme.")
    input_placeholder_color: Optional[StrictStr] = Field(default=None, description="InputPlaceholderColor is a hex color code used by the Ory Account Experience theme.")
    input_text_color: Optional[StrictStr] = Field(default=None, description="InputTextColor is a hex color code used by the Ory Account Experience theme.")
    logo_type: Optional[StrictStr] = Field(default=None, description="Logo Type The Logo mime type.")
    logo_url: Optional[StrictStr] = Field(default=None, description="Logo URL Logo can be an https:// or base64:// URL. If the URL is not allowed, the logo will be stored inside the Ory Network storage bucket.")
    name: StrictStr = Field(description="The customization theme name.")
    primary_color: Optional[StrictStr] = Field(default=None, description="Primary color is an hsla color value used to derive the other colors from for the Ory Account Experience theme.")
    project_branding_id: StrictStr = Field(description="The ProjectBranding ID this customization is associated with.")
    secondary_color: Optional[StrictStr] = Field(default=None, description="Secondary color is a hsla color code used to derive the other colors from for the Ory Account Experience theme.")
    success_emphasis_color: Optional[StrictStr] = Field(default=None, description="SuccessEmphasisColor is a hex color code used by the Ory Account Experience theme.")
    text_default_color: Optional[StrictStr] = Field(default=None, description="TextDefaultColor is a hex color code used by the Ory Account Experience theme.")
    text_disabled_color: Optional[StrictStr] = Field(default=None, description="TextDisabledColor is a hex color code used by the Ory Account Experience theme.")
    updated_at: datetime = Field(description="Last Time Branding was Updated.")
    additional_properties: Dict[str, Any] = {}
    __properties: ClassVar[List[str]] = ["accent_default_color", "accent_disabled_color", "accent_emphasis_color", "accent_muted_color", "accent_subtle_color", "account_experience_variables", "account_experience_variables_stylesheet", "background_canvas_color", "background_subtle_color", "background_surface_color", "border_default_color", "created_at", "error_default_color", "error_emphasis_color", "error_muted_color", "error_subtle_color", "favicon_type", "favicon_url", "foreground_default_color", "foreground_disabled_color", "foreground_muted_color", "foreground_on_accent_color", "foreground_on_dark_color", "foreground_on_disabled_color", "foreground_subtle_color", "id", "input_background_color", "input_disabled_color", "input_placeholder_color", "input_text_color", "logo_type", "logo_url", "name", "primary_color", "project_branding_id", "secondary_color", "success_emphasis_color", "text_default_color", "text_disabled_color", "updated_at"]

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
        """Create an instance of ProjectBrandingTheme from a JSON string"""
        return cls.from_dict(json.loads(json_str))

    def to_dict(self) -> Dict[str, Any]:
        """Return the dictionary representation of the model using alias.

        This has the following differences from calling pydantic's
        `self.model_dump(by_alias=True)`:

        * `None` is only added to the output dict for nullable fields that
          were set at model initialization. Other fields with value `None`
          are ignored.
        * OpenAPI `readOnly` fields are excluded.
        * OpenAPI `readOnly` fields are excluded.
        * OpenAPI `readOnly` fields are excluded.
        * Fields in `self.additional_properties` are added to the output dict.
        """
        excluded_fields: Set[str] = set([
            "created_at",
            "id",
            "updated_at",
            "additional_properties",
        ])

        _dict = self.model_dump(
            by_alias=True,
            exclude=excluded_fields,
            exclude_none=True,
        )
        # override the default output from pydantic by calling `to_dict()` of each item in account_experience_variables (list)
        _items = []
        if self.account_experience_variables:
            for _item in self.account_experience_variables:
                if _item:
                    _items.append(_item.to_dict())
            _dict['account_experience_variables'] = _items
        # puts key-value pairs in additional_properties in the top level
        if self.additional_properties is not None:
            for _key, _value in self.additional_properties.items():
                _dict[_key] = _value

        return _dict

    @classmethod
    def from_dict(cls, obj: Optional[Dict[str, Any]]) -> Optional[Self]:
        """Create an instance of ProjectBrandingTheme from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "accent_default_color": obj.get("accent_default_color"),
            "accent_disabled_color": obj.get("accent_disabled_color"),
            "accent_emphasis_color": obj.get("accent_emphasis_color"),
            "accent_muted_color": obj.get("accent_muted_color"),
            "accent_subtle_color": obj.get("accent_subtle_color"),
            "account_experience_variables": [AccountExperienceThemeVariables.from_dict(_item) for _item in obj["account_experience_variables"]] if obj.get("account_experience_variables") is not None else None,
            "account_experience_variables_stylesheet": obj.get("account_experience_variables_stylesheet"),
            "background_canvas_color": obj.get("background_canvas_color"),
            "background_subtle_color": obj.get("background_subtle_color"),
            "background_surface_color": obj.get("background_surface_color"),
            "border_default_color": obj.get("border_default_color"),
            "created_at": obj.get("created_at"),
            "error_default_color": obj.get("error_default_color"),
            "error_emphasis_color": obj.get("error_emphasis_color"),
            "error_muted_color": obj.get("error_muted_color"),
            "error_subtle_color": obj.get("error_subtle_color"),
            "favicon_type": obj.get("favicon_type"),
            "favicon_url": obj.get("favicon_url"),
            "foreground_default_color": obj.get("foreground_default_color"),
            "foreground_disabled_color": obj.get("foreground_disabled_color"),
            "foreground_muted_color": obj.get("foreground_muted_color"),
            "foreground_on_accent_color": obj.get("foreground_on_accent_color"),
            "foreground_on_dark_color": obj.get("foreground_on_dark_color"),
            "foreground_on_disabled_color": obj.get("foreground_on_disabled_color"),
            "foreground_subtle_color": obj.get("foreground_subtle_color"),
            "id": obj.get("id"),
            "input_background_color": obj.get("input_background_color"),
            "input_disabled_color": obj.get("input_disabled_color"),
            "input_placeholder_color": obj.get("input_placeholder_color"),
            "input_text_color": obj.get("input_text_color"),
            "logo_type": obj.get("logo_type"),
            "logo_url": obj.get("logo_url"),
            "name": obj.get("name"),
            "primary_color": obj.get("primary_color"),
            "project_branding_id": obj.get("project_branding_id"),
            "secondary_color": obj.get("secondary_color"),
            "success_emphasis_color": obj.get("success_emphasis_color"),
            "text_default_color": obj.get("text_default_color"),
            "text_disabled_color": obj.get("text_disabled_color"),
            "updated_at": obj.get("updated_at")
        })
        # store additional fields in additional_properties
        for _key in obj.keys():
            if _key not in cls.__properties:
                _obj.additional_properties[_key] = obj.get(_key)

        return _obj



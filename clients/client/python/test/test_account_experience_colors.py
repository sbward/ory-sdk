# coding: utf-8

"""
    Ory APIs

    # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 

    The version of the OpenAPI document: v1.16.7
    Contact: support@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from ory_client.models.account_experience_colors import AccountExperienceColors

class TestAccountExperienceColors(unittest.TestCase):
    """AccountExperienceColors unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> AccountExperienceColors:
        """Test AccountExperienceColors
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `AccountExperienceColors`
        """
        model = AccountExperienceColors()
        if include_optional:
            return AccountExperienceColors(
                button_identifier_background_default = '',
                button_identifier_background_hover = '',
                button_identifier_border_border_default = '',
                button_identifier_border_border_hover = '',
                button_identifier_foreground_default = '',
                button_identifier_foreground_hover = '',
                button_link_brand_brand = '',
                button_link_brand_brand_hover = '',
                button_link_default_primary = '',
                button_link_default_primary_hover = '',
                button_link_default_secondary = '',
                button_link_default_secondary_hover = '',
                button_link_disabled_disabled = '',
                button_primary_background_default = '',
                button_primary_background_disabled = '',
                button_primary_background_hover = '',
                button_primary_border_default = '',
                button_primary_border_disabled = '',
                button_primary_border_hover = '',
                button_primary_foreground_default = '',
                button_primary_foreground_disabled = '',
                button_primary_foreground_hover = '',
                button_secondary_background_default = '',
                button_secondary_background_disabled = '',
                button_secondary_background_hover = '',
                button_secondary_border_default = '',
                button_secondary_border_disabled = '',
                button_secondary_border_hover = '',
                button_secondary_foreground_default = '',
                button_secondary_foreground_disabled = '',
                button_secondary_foreground_hover = '',
                button_social_background_default = '',
                button_social_background_disabled = '',
                button_social_background_generic_provider = '',
                button_social_background_hover = '',
                button_social_border_default = '',
                button_social_border_disabled = '',
                button_social_border_generic_provider = '',
                button_social_border_hover = '',
                button_social_foreground_default = '',
                button_social_foreground_disabled = '',
                button_social_foreground_generic_provider = '',
                button_social_foreground_hover = '',
                checkbox_background_checked = '',
                checkbox_background_default = '',
                checkbox_border_checkbox_border_checked = '',
                checkbox_border_checkbox_border_default = '',
                checkbox_foreground_checked = '',
                checkbox_foreground_default = '',
                form_background_default = '',
                form_border_default = '',
                input_background_default = '',
                input_background_disabled = '',
                input_background_hover = '',
                input_border_default = '',
                input_border_disabled = '',
                input_border_focus = '',
                input_border_hover = '',
                input_foreground_disabled = '',
                input_foreground_primary = '',
                input_foreground_secondary = '',
                input_foreground_tertiary = '',
                interface_background_brand_primary = '',
                interface_background_brand_primary_hover = '',
                interface_background_brand_secondary = '',
                interface_background_brand_secondary_hover = '',
                interface_background_default_inverted = '',
                interface_background_default_inverted_hover = '',
                interface_background_default_none = '',
                interface_background_default_primary = '',
                interface_background_default_primary_hover = '',
                interface_background_default_secondary = '',
                interface_background_default_secondary_hover = '',
                interface_background_default_tertiary = '',
                interface_background_default_tertiary_hover = '',
                interface_background_disabled_disabled = '',
                interface_background_validation_danger = '',
                interface_background_validation_success = '',
                interface_background_validation_warning = '',
                interface_border_brand_brand = '',
                interface_border_default_inverted = '',
                interface_border_default_none = '',
                interface_border_default_primary = '',
                interface_border_disabled_disabled = '',
                interface_border_validation_danger = '',
                interface_border_validation_success = '',
                interface_border_validation_warning = '',
                interface_foreground_brand_on_primary = '',
                interface_foreground_brand_on_secondary = '',
                interface_foreground_brand_primary = '',
                interface_foreground_brand_secondary = '',
                interface_foreground_default_inverted = '',
                interface_foreground_default_primary = '',
                interface_foreground_default_secondary = '',
                interface_foreground_default_tertiary = '',
                interface_foreground_disabled_disabled = '',
                interface_foreground_disabled_on_disabled = '',
                interface_foreground_validation_danger = '',
                interface_foreground_validation_success = '',
                interface_foreground_validation_warning = '',
                ory_background_default = '',
                ory_border_default = '',
                ory_foreground_default = '',
                radio_background_checked = '',
                radio_background_default = '',
                radio_border_checked = '',
                radio_border_default = '',
                radio_foreground_checked = '',
                radio_foreground_default = '',
                toggle_background_checked = '',
                toggle_background_default = '',
                toggle_border_checked = '',
                toggle_border_default = '',
                toggle_foreground_checked = '',
                toggle_foreground_default = ''
            )
        else:
            return AccountExperienceColors(
        )
        """

    def testAccountExperienceColors(self):
        """Test AccountExperienceColors"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()

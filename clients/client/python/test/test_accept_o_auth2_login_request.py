# coding: utf-8

"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

    The version of the OpenAPI document: v1.15.6
    Contact: support@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from ory_client.models.accept_o_auth2_login_request import AcceptOAuth2LoginRequest

class TestAcceptOAuth2LoginRequest(unittest.TestCase):
    """AcceptOAuth2LoginRequest unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> AcceptOAuth2LoginRequest:
        """Test AcceptOAuth2LoginRequest
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `AcceptOAuth2LoginRequest`
        """
        model = AcceptOAuth2LoginRequest()
        if include_optional:
            return AcceptOAuth2LoginRequest(
                acr = '',
                amr = [
                    ''
                    ],
                context = ory_client.models.json_raw_message_represents_a_json/raw_message_that_works_well_with_json,_sql,_and_swagger/.JSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger.(),
                extend_session_lifespan = True,
                force_subject_identifier = '',
                identity_provider_session_id = '',
                remember = True,
                remember_for = 56,
                subject = ''
            )
        else:
            return AcceptOAuth2LoginRequest(
                subject = '',
        )
        """

    def testAcceptOAuth2LoginRequest(self):
        """Test AcceptOAuth2LoginRequest"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()

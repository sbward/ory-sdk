# coding: utf-8

"""
    Ory Hydra API

    Documentation for all of Ory Hydra's APIs. 

    The version of the OpenAPI document: v2.4.0-alpha.1
    Contact: hi@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from ory_hydra_client.models.o_auth2_consent_session_expires_at import OAuth2ConsentSessionExpiresAt

class TestOAuth2ConsentSessionExpiresAt(unittest.TestCase):
    """OAuth2ConsentSessionExpiresAt unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> OAuth2ConsentSessionExpiresAt:
        """Test OAuth2ConsentSessionExpiresAt
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `OAuth2ConsentSessionExpiresAt`
        """
        model = OAuth2ConsentSessionExpiresAt()
        if include_optional:
            return OAuth2ConsentSessionExpiresAt(
                access_token = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'),
                authorize_code = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'),
                id_token = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'),
                par_context = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'),
                refresh_token = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f')
            )
        else:
            return OAuth2ConsentSessionExpiresAt(
        )
        """

    def testOAuth2ConsentSessionExpiresAt(self):
        """Test OAuth2ConsentSessionExpiresAt"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()

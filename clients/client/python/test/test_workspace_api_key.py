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

from ory_client.models.workspace_api_key import WorkspaceApiKey

class TestWorkspaceApiKey(unittest.TestCase):
    """WorkspaceApiKey unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> WorkspaceApiKey:
        """Test WorkspaceApiKey
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `WorkspaceApiKey`
        """
        model = WorkspaceApiKey()
        if include_optional:
            return WorkspaceApiKey(
                created_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'),
                id = '',
                name = '',
                owner_id = '',
                updated_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'),
                value = '',
                workspace_id = ''
            )
        else:
            return WorkspaceApiKey(
                id = '',
                name = '',
                owner_id = '',
        )
        """

    def testWorkspaceApiKey(self):
        """Test WorkspaceApiKey"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()

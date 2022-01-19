=begin
#Ory APIs

#Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

The version of the OpenAPI document: v0.0.1-alpha.51
Contact: support@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.2.1

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OryClient::IdentityCredentialsType
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OryClient::IdentityCredentialsType do
  let(:instance) { OryClient::IdentityCredentialsType.new }

  describe 'test an instance of IdentityCredentialsType' do
    it 'should create an instance of IdentityCredentialsType' do
      expect(instance).to be_instance_of(OryClient::IdentityCredentialsType)
    end
  end
end

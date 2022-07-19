=begin
#Ory APIs

#Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

The version of the OpenAPI document: v0.1.0-alpha.4
Contact: support@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.4.0

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OryClient::SubmitSelfServiceLoginFlowWithLookupSecretMethodBody
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OryClient::SubmitSelfServiceLoginFlowWithLookupSecretMethodBody do
  let(:instance) { OryClient::SubmitSelfServiceLoginFlowWithLookupSecretMethodBody.new }

  describe 'test an instance of SubmitSelfServiceLoginFlowWithLookupSecretMethodBody' do
    it 'should create an instance of SubmitSelfServiceLoginFlowWithLookupSecretMethodBody' do
      expect(instance).to be_instance_of(OryClient::SubmitSelfServiceLoginFlowWithLookupSecretMethodBody)
    end
  end
  describe 'test attribute "csrf_token"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "lookup_secret"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "method"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end

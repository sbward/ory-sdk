/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.2
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Ory.Client.Model;
using Ory.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Ory.Client.Test.Model
{
    /// <summary>
    ///  Class for testing ClientOAuth2ClientTokenLifespans
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientOAuth2ClientTokenLifespansTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientOAuth2ClientTokenLifespans
        //private ClientOAuth2ClientTokenLifespans instance;

        public ClientOAuth2ClientTokenLifespansTests()
        {
            // TODO uncomment below to create an instance of ClientOAuth2ClientTokenLifespans
            //instance = new ClientOAuth2ClientTokenLifespans();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientOAuth2ClientTokenLifespans
        /// </summary>
        [Fact]
        public void ClientOAuth2ClientTokenLifespansInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientOAuth2ClientTokenLifespans
            //Assert.IsType<ClientOAuth2ClientTokenLifespans>(instance);
        }

        /// <summary>
        /// Test the property 'AuthorizationCodeGrantAccessTokenLifespan'
        /// </summary>
        [Fact]
        public void AuthorizationCodeGrantAccessTokenLifespanTest()
        {
            // TODO unit test for the property 'AuthorizationCodeGrantAccessTokenLifespan'
        }

        /// <summary>
        /// Test the property 'AuthorizationCodeGrantIdTokenLifespan'
        /// </summary>
        [Fact]
        public void AuthorizationCodeGrantIdTokenLifespanTest()
        {
            // TODO unit test for the property 'AuthorizationCodeGrantIdTokenLifespan'
        }

        /// <summary>
        /// Test the property 'AuthorizationCodeGrantRefreshTokenLifespan'
        /// </summary>
        [Fact]
        public void AuthorizationCodeGrantRefreshTokenLifespanTest()
        {
            // TODO unit test for the property 'AuthorizationCodeGrantRefreshTokenLifespan'
        }

        /// <summary>
        /// Test the property 'ClientCredentialsGrantAccessTokenLifespan'
        /// </summary>
        [Fact]
        public void ClientCredentialsGrantAccessTokenLifespanTest()
        {
            // TODO unit test for the property 'ClientCredentialsGrantAccessTokenLifespan'
        }

        /// <summary>
        /// Test the property 'ImplicitGrantAccessTokenLifespan'
        /// </summary>
        [Fact]
        public void ImplicitGrantAccessTokenLifespanTest()
        {
            // TODO unit test for the property 'ImplicitGrantAccessTokenLifespan'
        }

        /// <summary>
        /// Test the property 'ImplicitGrantIdTokenLifespan'
        /// </summary>
        [Fact]
        public void ImplicitGrantIdTokenLifespanTest()
        {
            // TODO unit test for the property 'ImplicitGrantIdTokenLifespan'
        }

        /// <summary>
        /// Test the property 'JwtBearerGrantAccessTokenLifespan'
        /// </summary>
        [Fact]
        public void JwtBearerGrantAccessTokenLifespanTest()
        {
            // TODO unit test for the property 'JwtBearerGrantAccessTokenLifespan'
        }

        /// <summary>
        /// Test the property 'RefreshTokenGrantAccessTokenLifespan'
        /// </summary>
        [Fact]
        public void RefreshTokenGrantAccessTokenLifespanTest()
        {
            // TODO unit test for the property 'RefreshTokenGrantAccessTokenLifespan'
        }

        /// <summary>
        /// Test the property 'RefreshTokenGrantIdTokenLifespan'
        /// </summary>
        [Fact]
        public void RefreshTokenGrantIdTokenLifespanTest()
        {
            // TODO unit test for the property 'RefreshTokenGrantIdTokenLifespan'
        }

        /// <summary>
        /// Test the property 'RefreshTokenGrantRefreshTokenLifespan'
        /// </summary>
        [Fact]
        public void RefreshTokenGrantRefreshTokenLifespanTest()
        {
            // TODO unit test for the property 'RefreshTokenGrantRefreshTokenLifespan'
        }
    }
}

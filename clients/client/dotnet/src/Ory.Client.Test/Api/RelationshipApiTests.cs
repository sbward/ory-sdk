/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.7
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Ory.Client.Client;
using Ory.Client.Api;
// uncomment below to import models
//using Ory.Client.Model;

namespace Ory.Client.Test.Api
{
    /// <summary>
    ///  Class for testing RelationshipApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RelationshipApiTests : IDisposable
    {
        private RelationshipApi instance;

        public RelationshipApiTests()
        {
            instance = new RelationshipApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RelationshipApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RelationshipApi
            //Assert.IsType<RelationshipApi>(instance);
        }

        /// <summary>
        /// Test CheckOplSyntax
        /// </summary>
        [Fact]
        public void CheckOplSyntaxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? body = null;
            //var response = instance.CheckOplSyntax(body);
            //Assert.IsType<ClientCheckOplSyntaxResult>(response);
        }

        /// <summary>
        /// Test CreateRelationship
        /// </summary>
        [Fact]
        public void CreateRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientCreateRelationshipBody? clientCreateRelationshipBody = null;
            //var response = instance.CreateRelationship(clientCreateRelationshipBody);
            //Assert.IsType<ClientRelationship>(response);
        }

        /// <summary>
        /// Test DeleteRelationships
        /// </summary>
        [Fact]
        public void DeleteRelationshipsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? varNamespace = null;
            //string? varObject = null;
            //string? relation = null;
            //string? subjectId = null;
            //string? subjectSetNamespace = null;
            //string? subjectSetObject = null;
            //string? subjectSetRelation = null;
            //instance.DeleteRelationships(varNamespace, varObject, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation);
        }

        /// <summary>
        /// Test GetRelationships
        /// </summary>
        [Fact]
        public void GetRelationshipsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? pageToken = null;
            //long? pageSize = null;
            //string? varNamespace = null;
            //string? varObject = null;
            //string? relation = null;
            //string? subjectId = null;
            //string? subjectSetNamespace = null;
            //string? subjectSetObject = null;
            //string? subjectSetRelation = null;
            //var response = instance.GetRelationships(pageToken, pageSize, varNamespace, varObject, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation);
            //Assert.IsType<ClientRelationships>(response);
        }

        /// <summary>
        /// Test ListRelationshipNamespaces
        /// </summary>
        [Fact]
        public void ListRelationshipNamespacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListRelationshipNamespaces();
            //Assert.IsType<ClientRelationshipNamespaces>(response);
        }

        /// <summary>
        /// Test PatchRelationships
        /// </summary>
        [Fact]
        public void PatchRelationshipsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<ClientRelationshipPatch>? clientRelationshipPatch = null;
            //instance.PatchRelationships(clientRelationshipPatch);
        }
    }
}

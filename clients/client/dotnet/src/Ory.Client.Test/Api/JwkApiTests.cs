/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.6
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
    ///  Class for testing JwkApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class JwkApiTests : IDisposable
    {
        private JwkApi instance;

        public JwkApiTests()
        {
            instance = new JwkApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of JwkApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' JwkApi
            //Assert.IsType<JwkApi>(instance);
        }

        /// <summary>
        /// Test CreateJsonWebKeySet
        /// </summary>
        [Fact]
        public void CreateJsonWebKeySetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string set = null;
            //ClientCreateJsonWebKeySet clientCreateJsonWebKeySet = null;
            //var response = instance.CreateJsonWebKeySet(set, clientCreateJsonWebKeySet);
            //Assert.IsType<ClientJsonWebKeySet>(response);
        }

        /// <summary>
        /// Test DeleteJsonWebKey
        /// </summary>
        [Fact]
        public void DeleteJsonWebKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string set = null;
            //string kid = null;
            //instance.DeleteJsonWebKey(set, kid);
        }

        /// <summary>
        /// Test DeleteJsonWebKeySet
        /// </summary>
        [Fact]
        public void DeleteJsonWebKeySetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string set = null;
            //instance.DeleteJsonWebKeySet(set);
        }

        /// <summary>
        /// Test GetJsonWebKey
        /// </summary>
        [Fact]
        public void GetJsonWebKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string set = null;
            //string kid = null;
            //var response = instance.GetJsonWebKey(set, kid);
            //Assert.IsType<ClientJsonWebKeySet>(response);
        }

        /// <summary>
        /// Test GetJsonWebKeySet
        /// </summary>
        [Fact]
        public void GetJsonWebKeySetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string set = null;
            //var response = instance.GetJsonWebKeySet(set);
            //Assert.IsType<ClientJsonWebKeySet>(response);
        }

        /// <summary>
        /// Test SetJsonWebKey
        /// </summary>
        [Fact]
        public void SetJsonWebKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string set = null;
            //string kid = null;
            //ClientJsonWebKey? clientJsonWebKey = null;
            //var response = instance.SetJsonWebKey(set, kid, clientJsonWebKey);
            //Assert.IsType<ClientJsonWebKey>(response);
        }

        /// <summary>
        /// Test SetJsonWebKeySet
        /// </summary>
        [Fact]
        public void SetJsonWebKeySetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string set = null;
            //ClientJsonWebKeySet? clientJsonWebKeySet = null;
            //var response = instance.SetJsonWebKeySet(set, clientJsonWebKeySet);
            //Assert.IsType<ClientJsonWebKeySet>(response);
        }
    }
}

/*
 * ITPM admin panel API
 *
 * Admin panel for Telegram chat bot, which will help to improve user interactions with the chats.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing WorldsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WorldsApiTests
    {
        private WorldsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorldsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WorldsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' WorldsApi
            //Assert.IsInstanceOf(typeof(WorldsApi), instance);
        }

        
        /// <summary>
        /// Test WorldsList
        /// </summary>
        [Test]
        public void WorldsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.WorldsList();
            //Assert.IsInstanceOf(typeof(List<World>), response, "response is List<World>");
        }
        
        /// <summary>
        /// Test WorldsRetrieve
        /// </summary>
        [Test]
        public void WorldsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.WorldsRetrieve(id);
            //Assert.IsInstanceOf(typeof(World), response, "response is World");
        }
        
    }

}

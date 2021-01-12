/*
 * Created by Ranorex
 * User: Kuba
 * Date: 1/12/2021
 * Time: 10:40 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;


using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace DesktopAppTest
{
    /// <summary>
    /// Description of UserCodeModule2.
    /// </summary>
    [TestModule("901230BE-9415-4C55-AAF9-54242706D71C", ModuleType.UserCode, 1)]
    public class UserCodeModule2 : ITestModule
    {
    	
        private const string Resource = "https://www.googleapis.com/books/v1/users/115553044779075985261/bookshelves";
        RestClient client;
        RestRequest request;
        
        public void Setup()
        {
            client = new RestClient();
            request = new RestRequest(Resource, Method.GET);

        }

        public void Test1()
        {
            var queryResult = client.Execute(request);
            var res = JsonConvert.DeserializeObject<dynamic>(queryResult.Content);

            Assert.AreEqual(200, (int) queryResult.StatusCode);
            Report.Log(ReportLevel.Info, "Query return code: "+queryResult.StatusCode);

            Assert.AreEqual("APITEST_BOOKSHELF", (string) res["items"][0]["title"]);
            Report.Log(ReportLevel.Info, "Returned bookshelf is: "+(string)res["items"][0]["title"]);
        }
        
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule2()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            
            Setup();
            Test1();
        }
    }
}

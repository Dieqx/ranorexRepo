/*
 * Created by Ranorex
 * User: Kuba
 * Date: 1/12/2021
 * Time: 8:34 AM
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
using HttpClientMethod;


using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace DesktopAppTest
{
    /// <summary>
    /// Description of APITEst.
    /// </summary>
    /// 
//        public class Tests
//    {
//        private const string Resource = "https://www.googleapis.com/books/v1/users/115553044779075985261/bookshelves";
//        RestClient client;
//        RestRequest request;
//        [SetUp] 
//        public void Setup()
//        {
//            client = new RestClient();
//            //string oauthUid = "14501915180-4hpu37us1n1a32mlftqvl0v9cbgdlrr2.apps.googleusercontent.com";
//            //string secret = "00VqGx6bBRkRvdeJgQDgNxeu";
//            //client.Authenticator = new HttpBasicAuthenticator(oauthUid, secret);
//            request = new RestRequest(Resource, Method.GET);
//
//        }
//
//        [Test]
//        public void Test1()
//        {
//            var queryResult = client.Execute(request);
//            var res = JsonConvert.DeserializeObject<dynamic>(queryResult.Content);
//
//            Assert.AreEqual(200, (int) queryResult.StatusCode);
//            Assert.AreEqual("APITEST_BOOKSHELF", (string) res["items"][0]["title"]);
//        }
//    }

        
    [TestModule("61013C95-A48A-4DFE-8688-BF87342843B7", ModuleType.UserCode, 1)]
    public class APITest
    {
		public static string restTestURL = "https://www.googleapis.com/books/v1/users/115553044779075985261/bookshelves";

		//HttpClientMethod.HttpClientMethod RestService = new HttpClientMethod.HttpClientMethod();
		object dupa = HttpClientMethod.HttpClientMethod.GetAsync(restTestURL, "", "application/json");

    	//object res = HttpClientMethod.GetAsync(restTestURL, "asdasdas");
    	
    }
}

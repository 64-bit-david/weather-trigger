using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace Reddit_News_Weather_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWithParam()
        {

            var logger = UnitTestFactory.CreateLogger();
            Assert.IsNotNull(logger);
            //var response = Reddit_News_Weather.FetchWeatherData.Run(UnitTestFactory.GetHttpRequest("location", "glasgow"), logger);
            //Assert.IsNotNull(response);

            //Console.WriteLine(response);

            //var parsedResponse = (OkObjectResult)response.Result;
            //var jsonResponse = (JsonResult)response.Result;


            //var responseObject = parsedResponse.Value;

            //Assert.IsNotNull(parsedResponse);





        }
    }
}
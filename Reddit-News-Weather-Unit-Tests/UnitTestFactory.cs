using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json.Linq;
using Moq;

namespace Reddit_News_Weather_Unit_Tests
{

    // create a http request object that we can pass to our azure http trigger function tests
    internal class UnitTestFactory
    {

        public static Dictionary<string, StringValues> GetQueryStringCollection(string key, string value)
        {
            var qsCollection = new Dictionary<string, StringValues>
            {
                {key, value }
            };

            return qsCollection;
        }
      
        
        public static HttpRequest GetHttpRequest(string qsName, string qsValue)
        {
            var context = new DefaultHttpContext();
            HttpRequest request = context.Request;

            request.Query = new QueryCollection(GetQueryStringCollection(qsName, qsValue));
            return request;
        }

        public static ILogger<T> CreateLogger<T>()
        {
            var logger = new Mock<ILogger<T>>();
            return logger.Object;
        }

    }

}


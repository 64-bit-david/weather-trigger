using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;

namespace Reddit_News_Weather
{
    public static class FetchWeatherData
    {
        [FunctionName("FetchWeatherData")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            HttpClient client = new HttpClient();
            log.LogInformation("C# HTTP trigger function processed a request.");

            string weatherAPIKey = System.Environment.GetEnvironmentVariable("WEATHER_API_KEY");
            if (string.IsNullOrEmpty(weatherAPIKey))
            {
                log.LogInformation("Weather API Key is missing.");
                return new JsonResult(new { error = "Weather API Key is missing." });
            }

            string locationQ = req.Query["location"];
            string location = string.IsNullOrEmpty(locationQ) ? "London" : locationQ;



            var weatherUrl = $"http://api.weatherapi.com/v1/current.json?key={weatherAPIKey}&q={location}&aqi=no";
            log.LogInformation($"Weather URL: {weatherUrl}");
            log.LogInformation($"Weather API Key: {weatherAPIKey}");


            try
            {
                HttpResponseMessage res = await client.GetAsync(weatherUrl);
                string resContent = await res.Content.ReadAsStringAsync();

                //using resContent here will double serialise, //!
                // return new JsonResult(new { weatherData = res });

                return new OkObjectResult(resContent);

            }
            catch (HttpRequestException ex)
            {
                log.LogInformation($"Getting Weather data failed with exception: ${ex}");
                return new JsonResult(new { error = ex.Message });
            }
            finally
            {
                client.Dispose();
            }


        }

    }
}

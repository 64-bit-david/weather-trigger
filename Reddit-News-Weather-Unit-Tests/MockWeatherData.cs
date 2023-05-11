using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Reddit_News_Weather_Unit_Tests
{
    internal class MockWeatherData
    {
        public static string GetMockWeatherDataWithQuery(string location)
        {
            string mockResponse = @"{
            ""location"": {
                ""name"": """ + location + @""",
                ""region"": ""Scotland"",
                ""country"": ""United Kingdom"",
                ""lat"": 55.87,
                ""lon"": -4.25,
                ""timezone_id"": ""Europe/London"",
                ""localtime"": ""2022-06-02 16:07"",
                ""localtime_epoch"": 1654254420,
                ""utc_offset"": ""1.0""
            },
            ""current"": {
                ""last_updated"": ""2022-06-02 16:00"",
                ""temp_c"": 13.0,
                ""temp_f"": 55.4,
                ""is_day"": 1,
                ""condition"": {
                    ""text"": ""Partly cloudy"",
                    ""icon"": ""//cdn.weatherapi.com/weather/64x64/day/116.png"",
                    ""code"": 1003
                },
                ""wind_mph"": 6.9,
                ""wind_kph"": 11.2,
                ""wind_degree"": 160,
                ""wind_dir"": ""SSE"",
                ""pressure_mb"": 1013.0,
                ""pressure_in"": 30.4,
                ""precip_mm"": 0.0,
                ""precip_in"": 0.0,
                ""humidity"": 82,
                ""cloud"": 75,
                ""feelslike_c"": 11.5,
                ""feelslike_f"": 52.7,
                ""vis_km"": 10.0,
                ""vis_miles"": 6.0
            }
        }";

            return mockResponse;
        }


        public static string GetMockWeatherDataWithoutQuery()
        {
            string mockResponse = @"{
                              ""location"": {
                                ""name"": ""London"",
                                ""region"": ""City of London, Greater London"",
                                ""country"": ""United Kingdom"",
                                ""lat"": 51.52,
                                ""lon"": -0.11,
                                ""tz_id"": ""Europe/London"",
                                ""localtime_epoch"": 1683243632,
                                ""localtime"": ""2023-05-05 0:40""
                              },
                              ""current"": {
                                ""last_updated_epoch"": 1683243000,
                                ""last_updated"": ""2023-05-05 00:30"",
                                ""temp_c"": 14.0,
                                ""temp_f"": 57.2,
                                ""is_day"": 0,
                                ""condition"": {
                                  ""text"": ""Overcast"",
                                  ""icon"": ""//cdn.weatherapi.com/weather/64x64/night/122.png"",
                                  ""code"": 1009
                                },
                                ""wind_mph"": 10.5,
                                ""wind_kph"": 16.9,
                                ""wind_degree"": 210,
                                ""wind_dir"": ""SSW"",
                                ""pressure_mb"": 1013.0,
                                ""pressure_in"": 29.91,
                                ""precip_mm"": 0.3,
                                ""precip_in"": 0.01,
                                ""humidity"": 82,
                                ""cloud"": 100,
                                ""feelslike_c"": 13.1,
                                ""feelslike_f"": 55.6,
                                ""vis_km"": 10.0,
                                ""vis_miles"": 6.0,
                                ""uv"": 1.0,
                                ""gust_mph"": 11.9,
                                ""gust_kph"": 19.1
                              }
                            }";

            return mockResponse;
        }
    }
}


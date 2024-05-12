using System;
using System.Net.Http;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace productsapi.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public HomeController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        [HttpGet("getcity")]
        public async Task<IActionResult> getcity(string name)
        {
            try
            {
                string apiUrl = $"http://api.openweathermap.org/geo/1.0/direct?q="+name+"&limit=5&appid=bda91775e1b79fa49200af6936604bdd";

                var client = _clientFactory.CreateClient();

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();



                    var main = JsonObject.Parse(responseBody);
                    return Ok(main);
                }
                else
                {
                    return StatusCode((int)response.StatusCode, "Failed to retrieve city data.");
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        [HttpGet("getfivedayforecast")]
        public async Task<IActionResult> GetFiveDayForecastAsync(double lat, double lon)
        {
            try
            {
                string apiUrl = $"http://api.openweathermap.org/data/2.5/forecast?lat="+lat+"&lon="+lon+ "&appid=bda91775e1b79fa49200af6936604bdd&units=metric";

                var client = _clientFactory.CreateClient();

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                 

                    var main = JsonObject.Parse(responseBody);
                    return Ok(main);
                }
                else
                {
                    return StatusCode((int)response.StatusCode, "Failed to retrieve forecast data.");
                }
            }
            catch (Exception ex)
            {
        
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }


    }
}

using BelfastWF_bkend.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Web.Http;

namespace BelfastWF_bkend.Controllers
{
    public class WeatherController : ApiController
    {
        private string api_uri = "https://www.metaweather.com/api/location/";
        // GET: api/Weather
        [Authorize]
        public async System.Threading.Tasks.Task<IHttpActionResult> GetAsync(string location)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(api_uri+location); //Create the full uri with the location of the city

                var response = await client.GetAsync(uri);
                if (!response.IsSuccessStatusCode) //Check if the request was good
                {
                    return BadRequest();
                }

                //Parse to JSON
                string textResult = await response.Content.ReadAsStringAsync();
                WeatherLocation forecast = JsonConvert.DeserializeObject<WeatherLocation>(textResult);

                return Ok(forecast);
            }
        }
    }
}

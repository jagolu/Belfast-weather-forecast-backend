using BelfastWF_bkend.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Web.Http;

namespace BelfastWF_bkend.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        [Authorize]
        public async System.Threading.Tasks.Task<IHttpActionResult> GetAsync(string location)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri("https://www.metaweather.com/api/location/"+location);

                var response = await client.GetAsync(uri);
                if (!response.IsSuccessStatusCode)
                {
                    return BadRequest();
                }

                string textResult = await response.Content.ReadAsStringAsync();

                WeatherLocation forecast = JsonConvert.DeserializeObject<WeatherLocation>(textResult);
                return Ok(forecast);
            }
        }
    }
}

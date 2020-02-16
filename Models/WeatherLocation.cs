using System.Collections.Generic;

namespace BelfastWF_bkend.Models
{
    public class WeatherLocation
    {
        public List<Consolidated_weather_item> consolidated_weather { get; set; }
    }
}
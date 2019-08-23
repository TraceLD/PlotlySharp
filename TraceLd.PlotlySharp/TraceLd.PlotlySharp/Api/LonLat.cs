using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class LonLat
    {
        [JsonProperty("lon")]
        public double? Lon { get; set; }
        [JsonProperty("lat")]
        public double? Lat { get; set; }
    }
}
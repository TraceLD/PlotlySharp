using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class MapBox
    {
        [JsonProperty("domain")]
        public Domain Domain { get; set; }
        [JsonProperty("accesstoken")]
        public string AccessToken { get; set; }
        [JsonProperty("style")]
        public string Style { get; set; }
        [JsonProperty("center")]
        public LonLat Center { get; set; }
        [JsonProperty("zoom")]
        public double Zoom { get; set; }
        [JsonProperty("bearing")]
        public double Bearing { get; set; }
        [JsonProperty("pitch")]
        public double Pitch { get; set; }
        [JsonProperty("layers")]
        public Layers Layers { get; set; }
    }
}
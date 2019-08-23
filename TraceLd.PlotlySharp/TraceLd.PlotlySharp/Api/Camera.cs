using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Camera
    {
        [JsonProperty("up")]
        public Vector Up { get; set; }
        [JsonProperty("center")]
        public Vector Center { get; set; }
        [JsonProperty("up")]
        public Vector Eye { get; set; }
    }
}
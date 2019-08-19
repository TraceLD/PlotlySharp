using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes
{
    public class Camera
    {
        [JsonProperty("up")]
        public PlotlyVector Up { get; set; }
        [JsonProperty("center")]
        public PlotlyVector Center { get; set; }
        [JsonProperty("up")]
        public PlotlyVector Eye { get; set; }
    }
}
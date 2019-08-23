using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Vector
    {
        [JsonProperty("x")]
        public double? X { get; set; }
        [JsonProperty("y")]
        public double? Y { get; set; }
        [JsonProperty("z")]
        public double? Z { get; set; }
    }
}
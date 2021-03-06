using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Pad
    {
        [JsonProperty("t")]
        public double? T { get; set; }
        [JsonProperty("b")]
        public double? B { get; set; }
        [JsonProperty("l")]
        public double? L { get; set; }
    }
}
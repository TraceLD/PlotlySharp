using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Pad
    {
        [JsonProperty("t")]
        public int T { get; set; }
        [JsonProperty("b")]
        public int B { get; set; }
        [JsonProperty("l")]
        public int L { get; set; }
    }
}
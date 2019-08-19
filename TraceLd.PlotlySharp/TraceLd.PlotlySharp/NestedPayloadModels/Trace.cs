using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Trace
    {
        [JsonProperty("x")]
        public List<int> X { get; set; }
        [JsonProperty("y")]
        public List<int> Y { get; set; }
        [JsonProperty("text")]
        public List<int> Text { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
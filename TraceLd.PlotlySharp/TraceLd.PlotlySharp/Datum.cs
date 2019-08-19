using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp
{
    public class Datum
    {
        [JsonProperty("x")]
        public List<int> X { get; set; }
        [JsonProperty("y")]
        public List<int> Y { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
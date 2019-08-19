using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Domain
    {
        [JsonProperty("x")]
        public List<double> X { get; set; }
        [JsonProperty("y")]
        public List<double> Y { get; set; }
    }
}
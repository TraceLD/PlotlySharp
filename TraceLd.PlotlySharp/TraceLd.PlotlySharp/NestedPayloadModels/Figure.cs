using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Figure
    {
        [JsonProperty("data")]
        public List<Trace> Data { get; set; }
        [JsonProperty("layout")]
        public Layout Layout { get; set; }
    }
}
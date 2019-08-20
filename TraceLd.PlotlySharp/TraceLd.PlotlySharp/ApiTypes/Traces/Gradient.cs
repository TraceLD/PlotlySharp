using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes.Traces
{
    public class Gradient
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("color")]
        public List<string> Color { get; set; }
    }
}
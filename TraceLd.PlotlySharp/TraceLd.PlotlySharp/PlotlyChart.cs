using System.Collections.Generic;
using Newtonsoft.Json;
using TraceLd.PlotlySharp.NestedPayloadModels;

namespace TraceLd.PlotlySharp
{
    public class PlotlyChart
    {
        [JsonProperty("figure")]
        public Figure Figure { get; set; }
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("format")]
        public string Format { get; set; }
        [JsonProperty("scale")]
        public int Scale { get; set; }
        [JsonProperty("encoded")]
        public string Encoded { get; } = "false";
    }
}
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
        public List<string> Text { get; set; }
        [JsonProperty("textposition")]
        public string TextPostion { get; set; }
        [JsonProperty("textfont")]
        public PlotlyFont TextFont { get; set; }
        [JsonProperty("textinfo")]
        public string TextInfo { get; set; }
        [JsonProperty("hoverinfo")]
        public string HoverInfo { get; set; }
        [JsonProperty("domain")]
        public Domain Domain { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("mode")]
        public string Mode { get; set; }
        [JsonProperty("line")]
        public Line Line { get; set; }
        [JsonProperty("values")]
        public List<double> Values { get; set; }
        [JsonProperty("labels")]
        public List<string> Labels { get; set; }
    }
}
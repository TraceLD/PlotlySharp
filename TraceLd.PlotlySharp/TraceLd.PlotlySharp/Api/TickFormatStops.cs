using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class TickFormatStops
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("dtickrange")]
        public List<double> DTickRange { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("templateitemname")]
        public string TemplateItemName { get; set; }
    }
}
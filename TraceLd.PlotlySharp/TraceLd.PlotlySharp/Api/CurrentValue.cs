using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class CurrentValue
    {
        [JsonProperty("visible")]
        public bool Visible { get; set; } = true;
        [JsonProperty("xanchor")]
        public string XAnchor { get; set; }
        [JsonProperty("offset")]
        public double Offset { get; set; }
        [JsonProperty("prefix")]
        public string Prefix { get; set; }
        [JsonProperty("suffix")]
        public string Suffix { get; set; }
        [JsonProperty("font")]
        public Font Font { get; set; }
    }
}
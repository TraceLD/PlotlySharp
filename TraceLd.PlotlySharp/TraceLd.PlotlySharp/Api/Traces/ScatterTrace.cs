using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api.Traces
{
    public class ScatterTrace : Trace
    {
        [JsonProperty("type")]
        public new string Type { get; } = "scatter";
        
        [JsonProperty("stackgroup")]
        public double? StackGroup { get; set; }
        
        [JsonProperty("groupnorm")]
        public double? GroupNorm { get; set; }
        
        [JsonProperty("stackgaps")]
        public double? StackGaps { get; set; }
        
        [JsonProperty("hoveron")]
        public string HoverOn { get; set; }
        
        [JsonProperty("mode")]
        public string Mode { get; set; }
        
        [JsonProperty("line")]
        public Line Line { get; set; }
        
        [JsonProperty("connectgaps")]
        public bool ConnectGaps { get; set; }
        
        [JsonProperty("fill")]
        public bool Fill { get; set; } = true;
        
        [JsonProperty("fillcolor")]
        public bool FillColor { get; set; } = true;
    }
}
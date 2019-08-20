using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes.Traces
{
    public class BarTrace : Trace
    {
        [JsonProperty("type")]
        public new string Type { get; } = "bar";
        
        [JsonProperty("insidetextanchor")]
        public string InsideTextAnchor { get; set; }
        
        [JsonProperty("insidetextfont")]
        public PlotlyFont InsideTextFont { get; set; }
        
        [JsonProperty("outsidetextfont")]
        public PlotlyFont OutsideTextFont { get; set; }
        
        [JsonProperty("constraintext")]
        public string ConstrainText { get; set; }
        
        [JsonProperty("base")]
        public List<double> Base { get; set; }
        
        [JsonProperty("offset")]
        public List<double> Offset { get; set; }
        
        [JsonProperty("width")]
        public List<double> Width { get; set; }
        
        [JsonProperty("offsetgroup")]
        public string OffsetGroup { get; set; }
        
        [JsonProperty("alignmentgroup")]
        public string AlignmentGroup { get; set; }
    }
}
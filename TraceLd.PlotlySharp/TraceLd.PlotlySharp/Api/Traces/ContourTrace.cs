using System;
using System.Collections;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api.Traces
{
    public class ContourTrace : Trace
    {
        private double? _nContours;
        
        [JsonProperty("type")]
        public new string Type { get; } = "contour";
        
        [JsonProperty("z")]
        public ArrayList Z { get; set; }
        
        [JsonProperty("transpose")]
        public bool Transpose { get; set; }
        
        [JsonProperty("xtype")]
        public string XType { get; set; }
        
        [JsonProperty("ytype")]
        public string YType { get; set; }
        
        [JsonProperty("zhoverformat")]
        public string ZHoverFormat { get; set; }

        [JsonProperty("connectgaps")]
        public bool ConnectGaps { get; set; }
        
        [JsonProperty("fillcolor")]
        public string FillColor { get; set; }
        
        [JsonProperty("autocontour")]
        public bool AutoContour { get; set; } = true;
        
        [JsonProperty("ncontours")]
        public double? NContours
        {
            get => _nContours;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"NContours must be greater than or equal to 1");
                }

                _nContours = value;
            }
        }
        
        [JsonProperty("contours")]
        public Contours Contours { get; set; }
        
        [JsonProperty("line")]
        public Line Line { get; set; }
        
        [JsonProperty("zauto")]
        public bool ZAuto { get; set; } = true;
        
        [JsonProperty("zmin")]
        public double? ZMin { get; set; }
        
        [JsonProperty("zmax")]
        public double? ZMax { get; set; }
        
        [JsonProperty("zmid")]
        public double? ZMid { get; set; }
        
        [JsonProperty("reversescale")]
        public bool ReverseScale { get; set; }
        
        [JsonProperty("showscale")]
        public bool ShowScale { get; set; } = true;
    }
}
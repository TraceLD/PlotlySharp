using System;
using System.Collections;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes.Traces
{
    public class HeatmapTrace : Trace
    {
        private double? _xGap;
        private double? _yGap;
        
        [JsonProperty("type")]
        public new string Type { get; } = "heatmap";
        
        [JsonProperty("z")]
        public ArrayList Z { get; set; }
        
        [JsonProperty("transpose")]
        public bool Transpose { get; set; }
        
        [JsonProperty("xtype")]
        public string XType { get; set; }
        
        [JsonProperty("ytype")]
        public string YType { get; set; }
        
        [JsonProperty("zsmooth")]
        public string ZSmooth { get; set; }
        
        [JsonProperty("connectgaps")]
        public bool ConnectGaps { get; set; }
        
        [JsonProperty("xgap")]
        public double? XGap
        {
            get => _xGap;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"XGap must be greater than or equal to 0");
                }

                _xGap = value;
            }
        }
        
        [JsonProperty("ygap")]
        public double? YGap
        {
            get => _yGap;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"YGap must be greater than or equal to 0");
                }

                _yGap = value;
            }
        }
        
        [JsonProperty("zhoverformat")]
        public string ZHoverFormat { get; set; }

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
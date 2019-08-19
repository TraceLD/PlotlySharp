using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Legend
    {
        private double? _borderWidth;
        private double? _traceGroupGap;
        private double? _x;
        private double? _y;
        
        [JsonProperty("bgcolor")]
        public string BgColor { get; set; }
        [JsonProperty("bordercolor")]
        public string BorderColor { get; set; }
        
        [JsonProperty("borderwidth")]
        public double? BorderWidth
        {
            get => _borderWidth;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"BorderWidth must be greater than or equal to 0");
                }

                _borderWidth = value;
            }
        }
        
        [JsonProperty("font")]
        public PlotlyFont Font { get; set; }
        [JsonProperty("orientation")]
        public string Orientation { get; set; }
        [JsonProperty("traceorder")]
        public string TraceOrder { get; set; }
        
        [JsonProperty("tracegroupgap")]
        public double? TraceGroupGap
        {
            get => _traceGroupGap;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"TraceGroupGap must be greater than or equal to 0");
                }

                _traceGroupGap = value;
            }
        }
        
        [JsonProperty("itmesizing")]
        public string ItemSizing { get; set; }
        [JsonProperty("itemclick")]
        public string ItemClick { get; set; }
        [JsonProperty("itemdoubleclick")]
        public string ItemdoubleClick { get; set; }
        
        [JsonProperty("x")]
        public double? X
        {
            get => _x;
            set
            {
                if (value < -2 || value > 3)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"X must be between or equal to -2 and 3");
                }

                _x = value;
            }
        }
        
        [JsonProperty("xanchor")]
        public string XAnchor { get; set; }
        
        [JsonProperty("y")]
        public double? Y
        {
            get => _y;
            set
            {
                if (value < -2 || value > 3)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Y must be between or equal to -2 and 3");
                }

                _y = value;
            }
        }
        
        [JsonProperty("yanchor")]
        public string YAnchor { get; set; }
        [JsonProperty("uirevision")]
        public string UiRevision { get; set; }
        [JsonProperty("valign")]
        public string VAlign { get; set; }
    }
}
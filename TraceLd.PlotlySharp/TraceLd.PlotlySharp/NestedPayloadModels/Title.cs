using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Title
    {
        private double? _x;
        private double? _y;

        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("font")]
        public PlotlyFont Font { get; set; }
        [JsonProperty("xref")]
        public string XRef { get; set; }
        [JsonProperty("yref")]
        public string YRef { get; set; }
        
        [JsonProperty("x")]
        public double? X
        {
            get => _x;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"X must be between or equal to 0 and 1");
                }

                _x = value;
            }
        }
        
        [JsonProperty("y")]
        public double? Y
        {
            get => _y;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException("Y must be between or equal to 0 and 1");
                }

                _y = value;
            }
        }
        
        [JsonProperty("xanchor")]
        public string XAnchor { get; set; }
        [JsonProperty("yanchor")]
        public string YAnchor { get; set; }
        [JsonProperty("pad")]
        public Pad Pad { get; set; }
        
    }
}
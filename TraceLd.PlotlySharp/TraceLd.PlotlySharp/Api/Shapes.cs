using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Shapes
    {
        private double? _opacity;
        
        [JsonProperty("visible")]
        public bool Visible { get; set; } = true;
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("xref")]
        public string XRef { get; set; }
        [JsonProperty("xsizemode")]
        public string XSizeMode { get; set; }
        [JsonProperty("xanchor")]
        public double? XAnchor { get; set; }
        [JsonProperty("x0")]
        public double? X0 { get; set; }
        [JsonProperty("x1")]
        public double? X1 { get; set; }
        [JsonProperty("yref")]
        public string YRef { get; set; }
        [JsonProperty("ysizemode")]
        public string YSizeMode { get; set; }
        [JsonProperty("yanchor")]
        public double? YAnchor { get; set; }
        [JsonProperty("y0")]
        public double? Y0 { get; set; }
        [JsonProperty("y1")]
        public double? Y1 { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        
        [JsonProperty("opacity")]
        public double? Opacity
        {
            get => _opacity;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Opacity must be between or equal to 0 and 1");
                }

                _opacity = value;
            }
        }
        
        [JsonProperty("line")]
        public Line Line { get; set; }
        [JsonProperty("fillcolor")]
        public string FillColor { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("templateitemname")]
        public string TemplateItemName { get; set; }
    }
}
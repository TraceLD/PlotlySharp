using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Images
    {
        private double? _opacity;

        [JsonProperty("visible")]
        public bool Visible { get; set; } = true;
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("layer")]
        public string Layer { get; set; }
        [JsonProperty("sizex")]
        public double? SizeX { get; set; }
        [JsonProperty("sizey")]
        public double? SizeY { get; set; }
        [JsonProperty("sizing")]
        public string Sizing { get; set; }
        
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
        
        [JsonProperty("x")]
        public double? X { get; set; }
        [JsonProperty("y")]
        public double? Y { get; set; }
        [JsonProperty("xanchor")]
        public string XAnchor { get; set; }
        [JsonProperty("yanchor")]
        public string YAnchor { get; set; }
        [JsonProperty("xref")]
        public string XRef { get; set; }
        [JsonProperty("yref")]
        public string YRef { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("templateitemname")]
        public string TemplateItemName { get; set; }
    }
}
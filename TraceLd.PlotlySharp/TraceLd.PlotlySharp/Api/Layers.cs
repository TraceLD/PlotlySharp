using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Layers
    {
        private double? _opacity;
        private double? _minZoom;
        private double? _maxZoom;
        
        [JsonProperty("visible")]
        public bool Visible { get; set; } = true;
        [JsonProperty("sourcetype")]
        public string SourceType { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("sourcelayer")]
        public string SourceLayer { get; set; }
        [JsonProperty("sourceattribution")]
        public string SourceAttribution { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }
        [JsonProperty("below")]
        public string Below { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
        
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
        
        [JsonProperty("minzoom")]
        public double? MinZoom
        {
            get => _minZoom;
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"MinZoom must be between or equal to 0 and 24");
                }

                _minZoom = value;
            }
        }
        
        [JsonProperty("maxzoom")]
        public double? MaxZoom
        {
            get => _maxZoom;
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"MaxZoom must be between or equal to 0 and 24");
                }

                _maxZoom = value;
            }
        }
        
        [JsonProperty("circle")]
        public Circle Circle { get; set; }
        [JsonProperty("line")]
        public Line Line { get; set; }
        [JsonProperty("fill")]
        public Fill Fill { get; set; }
        [JsonProperty("symbol")]
        public Symbol Symbol { get; set; }
        [JsonProperty("uirevision")]
        public string UiRevision { get; set; }
    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Marker
    {
        private double? _opacity;
        private double? _size;
        private double? _maxDisplayed;
        private double? _sizeMin;
        
        [JsonProperty("symbol")]
        public List<string> Symbol { get; set; }
        
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
        
        [JsonProperty("size")]
        public double? Size
        {
            get => _size;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Size must be greater than or equal to 0");
                }

                _size = value;
            }
        }
        
        [JsonProperty("maxdisplayed")]
        public double? MaxDisplayed
        {
            get => _maxDisplayed;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"MaxDisplayed must be greater than or equal to 0");
                }

                _maxDisplayed = value;
            }
        }
        
        [JsonProperty("sizeref")]
        public double SizeRef { get; set; }
        
        [JsonProperty("sizemin")]
        public double? SizeMin
        {
            get => _sizeMin;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"SizeMin must be greater than or equal to 0");
                }

                _sizeMin = value;
            }
        }
        
        [JsonProperty("sizemode")]
        public double? SizeMode { get; set; }
        
        [JsonProperty("line")]
        public Line Line { get; set; }
        
        [JsonProperty("gradient")]
        public Gradient Gradient { get; set; }
        
        [JsonProperty("color")]
        public List<string> Color { get; set; }
        
        [JsonProperty("cauto")]
        public bool CAuto { get; set; } = true;
        
        [JsonProperty("cmin")]
        public double? CMin { get; set; }
        
        [JsonProperty("cmax")]
        public double? CMax { get; set; }
        
        [JsonProperty("cmid")]
        public double? CMid { get; set; }
        
        [JsonProperty("reversescale")]
        public bool ReverseColorScale { get; set; }
        
        [JsonProperty("showscale")]
        public bool ShowScale { get; set; }
        
        [JsonProperty("colorbar")]
        public BarDto ColorBar { get; set; }
    }
}
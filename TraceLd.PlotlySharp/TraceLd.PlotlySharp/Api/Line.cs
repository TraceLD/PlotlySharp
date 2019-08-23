using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Line
    {
        private double? _width;
        
        [JsonProperty("width")]
        public double? Width
        {
            get => _width;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Width must be greater than or equal to 0");
                }

                _width = value;
            }
        }
        
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("cauto")]
        public bool CAuto { get; set; } = true;
        
        [JsonProperty("cmin")]
        public double? CMin { get; set; }
        
        [JsonProperty("cmax")]
        public double? CMax { get; set; }
        
        [JsonProperty("cmid")]
        public double? CMid { get; set; }
        
        [JsonProperty("colorscale")]
        public List<string> ColorScale { get; set; }
        
        [JsonProperty("autocolorscale")]
        public bool AutoColorScale { get; set; } = true;
        
        [JsonProperty("reversescale")]
        public bool ReverseScale { get; set; }
    }
}
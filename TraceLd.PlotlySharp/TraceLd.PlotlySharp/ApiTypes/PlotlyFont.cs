using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes
{
    public class PlotlyFont
    {
        private double? _size;
        
        [JsonProperty("family")]
        public string Family { get; set; }
        
        [JsonProperty("size")]
        public double? Size
        {
            get => _size;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Size must be greater than or equal to 1");
                }

                _size = value;
            }
        }
        
        [JsonProperty("color")]
        public string Color { get; set; }
    }
}
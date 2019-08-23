using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Projection
    {
        private double? _scale;
        
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("rotation")]
        public Rotation Rotation { get; set; }
        
        [JsonProperty("scale")]
        public double? Scale
        {
            get => _scale;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Scale must be greater than or equal to 0");
                }

                _scale = value;
            }
        }
    }
}
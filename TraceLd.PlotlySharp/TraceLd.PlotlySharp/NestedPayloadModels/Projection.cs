using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Projection
    {
        private int _scale;
        
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("rotation")]
        public Rotation Rotation { get; set; }
        
        [JsonProperty("scale")]
        public int Scale
        {
            get => _scale;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Scale must be greater than or equal to 0");
                }

                _scale = value;
            }
        }
    }
}
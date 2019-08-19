using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp
{
    public class PlotlyFont
    {
        private int _size;
        
        [JsonProperty("family")]
        public string Family { get; set; }
        
        [JsonProperty("size")]
        public int Size
        {
            get => _size;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Size must be greater than or equal to 1");
                }

                _size = value;
            }
        }
        
        [JsonProperty("color")]
        public string Color { get; set; }
    }
}
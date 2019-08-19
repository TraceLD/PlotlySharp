using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes
{
    public class HoverLabel
    {
        private int? _nameLength;
        
        [JsonProperty("bgcolor")]
        public string BgColor { get; set; }
        [JsonProperty("bordercolor")]
        public string BorderColor { get; set; }
        [JsonProperty("font")]
        public PlotlyFont Font { get; set; }
        [JsonProperty("align")]
        public string Align { get; set; }
        
        [JsonProperty("namelength")]
        public int? NameLength
        {
            get => _nameLength;
            set
            {
                if (value < -1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"NameLength must be greater than or equal to -1");
                }

                _nameLength = value;
            }
        }
    }
}
using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Ternary
    {
        private double _sum;
        
        [JsonProperty("domain")]
        public Domain Domain { get; set; }
        [JsonProperty("bgcolor")]
        public string BgColor { get; set; }
        
        [JsonProperty("sum")]
        public double Sum
        {
            get => _sum;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Sum must be greater than or equal to 0");
                }

                _sum = value;
            }
        }
        
        [JsonProperty("aaxis")]
        public Axis AAxis { get; set; }
        [JsonProperty("baxis")]
        public Axis BAxis { get; set; }
        [JsonProperty("caxis")]
        public Axis CAxis { get; set; }
        [JsonProperty("uirevision")]
        public string UiRevision { get; set; }
    }
}
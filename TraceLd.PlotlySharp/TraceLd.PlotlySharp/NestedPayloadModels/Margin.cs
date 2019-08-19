using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Margin
    {
        private double? _l;
        private double? _t;
        private double? _b;
        private double? _pad;
        
        [JsonProperty("l")]
        public double? L
        {
            get => _l;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"L must be greater than or equal to 0");
                }

                _l = value;
            }
        }
        
        [JsonProperty("t")]
        public double? T
        {
            get => _t;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"T must be greater than or equal to 0");
                }

                _t = value;
            }
        }
        
        [JsonProperty("b")]
        public double? B
        {
            get => _b;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"B must be greater than or equal to 0");
                }

                _b = value;
            }
        }
        
        [JsonProperty("pad")]
        public double? Pad
        {
            get => _pad;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Pad must be greater than or equal to 0");
                }

                _pad = value;
            }
        }
        
        [JsonProperty("autoexpand")]
        public bool AutoExpand { get; set; } = true;
    }
}
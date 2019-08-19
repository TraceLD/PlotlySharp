using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Margin
    {
        private int _l;
        private int _t;
        private int _b;
        private int _pad;
        
        [JsonProperty("l")]
        public int L
        {
            get => _l;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("L must be greater than or equal to 0");
                }

                _l = value;
            }
        }
        
        [JsonProperty("t")]
        public int T
        {
            get => _t;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("T must be greater than or equal to 0");
                }

                _t = value;
            }
        }
        
        [JsonProperty("b")]
        public int B
        {
            get => _b;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("B must be greater than or equal to 0");
                }

                _b = value;
            }
        }
        
        [JsonProperty("pad")]
        public int Pad
        {
            get => _pad;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Pad must be greater than or equal to 0");
                }

                _pad = value;
            }
        }
        
        [JsonProperty("autoexpand")]
        public bool AutoExpand { get; set; } = true;
    }
}
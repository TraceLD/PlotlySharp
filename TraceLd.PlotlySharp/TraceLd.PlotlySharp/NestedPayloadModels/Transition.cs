using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Transition
    {
        private int? _duration;
        
        [JsonProperty("duration")]
        public int? Duration
        {
            get => _duration;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Duration must be greater than or equal to 0");
                }

                _duration = value;
            }
        }
        
        [JsonProperty("easing")]
        public string Easing { get; set; }
        [JsonProperty("ordering")]
        public string Ordering { get; set; }
    }
}
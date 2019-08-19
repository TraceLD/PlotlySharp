using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes
{
    public class Polar
    {
        private double? _hole;
        
        [JsonProperty("domain")]
        public Domain Domain { get; set; }
        [JsonProperty("sector")]
        public List<double> Sector { get; set; }
        
        [JsonProperty("hole")]
        public double? Hole
        {
            get => _hole;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Hole must be between or equal to 0 and 1");
                }

                _hole = value;
            }
        }
        
        [JsonProperty("bgcolor")]
        public string BgColor { get; set; }
        [JsonProperty("radialaxis")]
        public Axis RadialAxis { get; set; }
        [JsonProperty("angularaxis")]
        public Axis AngularAxis { get; set; }
        [JsonProperty("gridshape")]
        public string GridShape { get; set; }
        [JsonProperty("uirevision")]
        public string UiRevision { get; set; }
    }
}
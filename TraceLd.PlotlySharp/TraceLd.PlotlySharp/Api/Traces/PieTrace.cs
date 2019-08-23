using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api.Traces
{
    public class PieTrace : Trace
    {
        private double? _hole;
        
        [JsonProperty("type")]
        public new string Type { get; } = "pie";
        
        [JsonProperty("labels")]
        public ArrayList Labels { get; set; }
        
        [JsonProperty("label0")]
        public double? Label0 { get; set; }
        
        [JsonProperty("dlabel")]
        public double? DLabel { get; set; }
        
        [JsonProperty("scalegroup")]
        public string ScaleGroup { get; set; }
        
        [JsonProperty("insidetextfont")]
        public Font InsideTextFont { get; set; }
        
        [JsonProperty("outsidetextfont")]
        public Font OutsideTextFont { get; set; }
        
        [JsonProperty("domain")]
        public Domain Domain { get; set; }
        
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
        
        [JsonProperty("sort")]
        public bool Sort { get; set; } = true;
        
        [JsonProperty("direction")]
        public string Direction { get; set; }
        
        [JsonProperty("rotation")]
        public double? Rotation { get; set; }
        
        [JsonProperty("pull")]
        public List<double> Pull { get; set; }
    }
}
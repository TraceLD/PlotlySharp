using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Contours
    {
        private double? _size;
        
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("start")]
        public double? Start { get; set; }
        
        [JsonProperty("end")]
        public double? End { get; set; }
        
        [JsonProperty("size")]
        public double? Size
        {
            get => _size;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"NContours must be greater than or equal to 0");
                }

                _size = value;
            }
        }
        
        [JsonProperty("coloring")]
        public string Coloring { get; set; }
        
        [JsonProperty("showlines")]
        public bool ShowLines { get; set; } = true;
        
        [JsonProperty("showlabels")]
        public bool ShowLabels { get; set; }
        
        [JsonProperty("labelfont")]
        public Font LabelFont { get; set; }
        
        [JsonProperty("labelformat")]
        public string LabelFormat { get; set; }
        
        [JsonProperty("operation")]
        public string Operation { get; set; }
        
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
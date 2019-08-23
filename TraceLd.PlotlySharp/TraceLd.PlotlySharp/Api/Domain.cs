using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Domain
    {
        private double? _column;
        private double? _row;
        
        [JsonProperty("x")]
        public List<double> X { get; set; }
        [JsonProperty("y")]
        public List<double> Y { get; set; }
        
        [JsonProperty("column")]
        public double? Column
        {
            get => _column;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Column must be greater than or equal to 0");
                }

                _column = value;
            }
        }
        
        [JsonProperty("row")]
        public double? Row
        {
            get => _row;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Row must be greater than or equal to 0");
                }

                _row = value;
            }
        }
    }
}
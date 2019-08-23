using System;
using System.Collections;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Error
    {
        private double? _value;
        private double? _valueMinus;
        private double? _traceRef;
        private double? _traceRefMinus;
        private double? _thickness;
        private double? _width;
        
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("visible")]
        public bool Visible { get; set; }
        
        [JsonProperty("symmetric")]
        public bool Symmetric { get; set; }
        
        [JsonProperty("array")]
        public ArrayList Array { get; set; }
        
        [JsonProperty("arrayminus")]
        public ArrayList ArrayMinus { get; set; }
        
        [JsonProperty("value")]
        public double? Value
        {
            get => _value;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Value must be greater than or equal to 0");
                }

                _value = value;
            }
        }
        
        [JsonProperty("valueminus")]
        public double? ValueMinus
        {
            get => _valueMinus;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"ValueMinus must be greater than or equal to 0");
                }

                _valueMinus = value;
            }
        }
        
        [JsonProperty("traceref")]
        public double? TraceRef
        {
            get => _traceRef;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"TraceRef must be greater than or equal to 0");
                }

                _traceRef = value;
            }
        }
        
        [JsonProperty("tracerefminus")]
        public double? TraceRefMinus
        {
            get => _traceRefMinus;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"TraceRefMinus must be greater than or equal to 0");
                }

                _traceRefMinus = value;
            }
        }
        
        [JsonProperty("thickness")]
        public double? Thickness
        {
            get => _thickness;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Thickness must be greater than or equal to 0");
                }

                _thickness = value;
            }
        }
        
        [JsonProperty("width")]
        public double? Width
        {
            get => _width;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Width must be greater than or equal to 0");
                }

                _width = value;
            }
        }
        
        [JsonProperty("color")]
        public string Color { get; set; }
    }
}
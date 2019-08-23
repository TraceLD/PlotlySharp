using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Grid
    {
        private int? _rows;
        private int? _columns;
        private double? _xGap;
        private double? _yGap;
        
        [JsonProperty("rows")]
        public int? Rows
        {
            get => _rows;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Rows must be greater than or equal to 1");
                }

                _rows = value;
            }
        }
        
        [JsonProperty("roworder")]
        public string RowOrder { get; set; }
        
        [JsonProperty("columns")]
        public int? Columns
        {
            get => _columns;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Columns must be greater than or equal to 1");
                }

                _columns = value;
            }
        }
        
        [JsonProperty("xaxes")]
        public List<Axis> XAxes { get; set; }
        [JsonProperty("yaxes")]
        public List<Axis> YAxes { get; set; }
        [JsonProperty("pattern")]
        public string Pattern { get; set; }
        
        [JsonProperty("xgap")]
        public double? XGap
        {
            get => _xGap;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"XGap must be between or equal to 0 and 1");
                }

                _xGap = value;
            }
        }
        
        [JsonProperty("ygap")]
        public double? YGap
        {
            get => _yGap;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"YGap must be between or equal to 0 and 1");
                }

                _yGap = value;
            }
        }
        
        [JsonProperty("domain")]
        public Domain Domain { get; set; }
        [JsonProperty("xside")]
        public string XSide { get; set; }
        [JsonProperty("yside")]
        public string YSide { get; set; }
    }
}
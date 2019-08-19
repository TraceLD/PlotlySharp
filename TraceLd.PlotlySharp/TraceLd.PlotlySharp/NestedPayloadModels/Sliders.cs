using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Sliders
    {
        private double? _active;
        private double? _len;
        private double? _x;
        private double? _y;
        private double? _borderWidth;
        private double? _tickLen;
        private double? _tickWidth;
        private double? _minorTickLen;
        
        [JsonProperty("visible")]
        public bool Visible { get; set; } = true;
        
        [JsonProperty("active")]
        public double? Active
        {
            get => _active;
            set
            {
                if (value < -1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Active must be greater than or equal to 0");
                }

                _active = value;
            }
        }
        
        [JsonProperty("steps")]
        public Steps Steps { get; set; }
        [JsonProperty("lenmode")]
        public string LenMode { get; set; }
        [JsonProperty("len")]
        public double? Len
        {
            get => _len;
            set
            {
                if (value < -1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Len must be greater than or equal to 0");
                }

                _len = value;
            }
        }
        
        [JsonProperty("x")]
        public double? X
        {
            get => _x;
            set
            {
                if (value < -2 || value > 3)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "X Must be between or equal to -2 and 3");
                }

                _x = value;
            }
        }
        
        [JsonProperty("pad")]
        public Pad Pad { get; set; }
        [JsonProperty("xanchor")]
        public string XAnchor { get; set; }
        
        [JsonProperty("y")]
        public double? Y
        {
            get => _y;
            set
            {
                if (value < -2 || value > 3)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Y Must be between or equal to -2 and 3");
                }

                _y = value;
            }
        }
        
        [JsonProperty("yanchor")]
        public string YAnchor { get; set; }
        [JsonProperty("transition")]
        public Transition Transition { get; set; }
        [JsonProperty("currentvalue")]
        public CurrentValue CurrentValue { get; set; }
        [JsonProperty("font")]
        public PlotlyFont Font { get; set; }
        [JsonProperty("activebgcolor")]
        public string ActiveBgColor { get; set; }
        [JsonProperty("bgcolor")]
        public string BgColor { get; set; }
        [JsonProperty("bordercolor")]
        public string BorderColor { get; set; }
        
        [JsonProperty("borderwidth")]
        public double? BorderWidth
        {
            get => _borderWidth;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"GridWidth must be greater than or equal to 0");
                }

                _borderWidth = value;
            }
        }
        
        [JsonProperty("ticklen")]
        public double? TickLen
        {
            get => _tickLen;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"TickLen must be greater than or equal to 0");
                }

                _tickLen = value;
            }
        }
        
        [JsonProperty("tickwidth")]
        public double? TickWidth
        {
            get => _tickWidth;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"TickWidth must be greater than or equal to 0");
                }

                _tickWidth = value;
            }
        }
        
        [JsonProperty("minorticklen")]
        public double? MinorTickLen
        {
            get => _minorTickLen;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"GridWidth must be greater than or equal to 0");
                }

                _minorTickLen = value;
            }
        }
        
        [JsonProperty("tickcolor")]
        public string TickColor { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("templateitemname")]
        public string TemplateItemName { get; set; }
    }
}
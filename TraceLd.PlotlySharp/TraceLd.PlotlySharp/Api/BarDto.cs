using System;
using System.Collections;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class BarDto
    {
        private double? _thickness;
        private double? _len;
        private double? _x;
        private double? _xPad;
        private double? _y;
        private double? _yPad;
        private double? _outlineWidth;
        private double? _borderWidth;
        private double? _nTicks;
        private double? _tickWidth;
        private double? _tickLen;
        
        [JsonProperty("thicknessmode")]
        public string ThicknessMode { get; set; }
        
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
        
        [JsonProperty("lenmode")]
        public string LenMode { get; set; }
        
        [JsonProperty("len")]
        public double? Len
        {
            get => _len;
            set
            {
                if (value < 0)
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
                    throw new ArgumentOutOfRangeException(nameof(value),"X must be between or equal to -2 and 3");
                }

                _x = value;
            }
        }
        
        [JsonProperty("xanchor")]
        public string XAnchor { get; set; }
        
        [JsonProperty("xpad")]
        public double? XPad
        {
            get => _xPad;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"XPad must be greater than or equal to 0");
                }

                _xPad = value;
            }
        }
        
        [JsonProperty("y")]
        public double? Y
        {
            get => _y;
            set
            {
                if (value < -2 || value > 3)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Y must be between or equal to -2 and 3");
                }

                _y = value;
            }
        }
        
        [JsonProperty("yanchor")]
        public string YAnchor { get; set; }
        
        [JsonProperty("ypad")]
        public double? YPad
        {
            get => _yPad;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"YPad must be greater than or equal to 0");
                }

                _yPad = value;
            }
        }
        
        [JsonProperty("outlinecolor")]
        public string OutlineColor { get; set; }
        
        [JsonProperty("outlinewidth")]
        public double? OutlineWidth
        {
            get => _outlineWidth;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"OutlineWidth must be greater than or equal to 0");
                }

                _outlineWidth = value;
            }
        }
        
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
                    throw new ArgumentOutOfRangeException(nameof(value),"BorderWidth must be greater than or equal to 0");
                }

                _borderWidth = value;
            }
        }
        
        [JsonProperty("bgcolor")]
        public string BgColor { get; set; }
        
        [JsonProperty("tickmode")]
        public string TickMode { get; set; }
        
        [JsonProperty("nticks")]
        public double? NTicks
        {
            get => _nTicks;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"NTicks must be greater than or equal to 0");
                }

                _nTicks = value;
            }
        }
        
        [JsonProperty("ntick")]
        public double? NTick { get; set; }
        
        [JsonProperty("dtick")]
        public double? DTick { get; set; }
        
        [JsonProperty("tickvals")]
        public ArrayList TickVals { get; set; }
        
        [JsonProperty("ticktext")]
        public ArrayList TickText { get; set; }
        
        [JsonProperty("ticks")]
        public string Ticks { get; set; }
        
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
        
        [JsonProperty("tickcolor")]
        public string TickColor { get; set; }

        [JsonProperty("showticklabels")]
        public bool ShowTickLabels { get; set; } = true;
        
        [JsonProperty("tickfont")]
        public Font TickFont { get; set; }
        
        [JsonProperty("tickangle")]
        public double? TickAngle { get; set; }
        
        [JsonProperty("tickformat")]
        public string TickFormat { get; set; }
        
        [JsonProperty("tickformatstops")]
        public TickFormatStops TickFormatStops { get; set; }
        
        [JsonProperty("tickprefix")]
        public Font TickPrefix { get; set; }
        
        [JsonProperty("showtickprefix")]
        public string ShowTickPrefix { get; set; }
        
        [JsonProperty("ticksuffix")]
        public string TickSuffix { get; set; }
        
        [JsonProperty("showticksuffix")]
        public string ShowTickSuffix { get; set; }
        
        [JsonProperty("exponentformat")]
        public string ExponentFormat { get; set; }
        
        [JsonProperty("showexponent")]
        public string ShowExponent { get; set; }
        
        [JsonProperty("title")]
        public Title Title { get; set; }
    }
}
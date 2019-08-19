using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Axis
    {
        private double? _scaleRatio;
        private double? _nTicks;
        private double? _tickLen;
        private double? _tickWidth;
        private double? _lineWidth;
        private double? _gridWidth;
        private double? _position;
        
        [JsonProperty("visible")]
        public bool Visible { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
        [JsonProperty("title")]
        public Title Title { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("autorange")]
        public bool AutoRange { get; set; }
        [JsonProperty("rangemode")]
        public string RangeMode { get; set; }
        [JsonProperty("range")]
        public List<double> Range { get; set; }
        [JsonProperty("fixedrange")]
        public bool FixedRange { get; set; }
        [JsonProperty("scaleanchor")]
        public string ScaleAnchor { get; set; }

        [JsonProperty("scaleratio")]
        public double? ScaleRatio
        {
            get => _scaleRatio;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"ScaleRatio must be greater than or equal to 0");
                }

                _scaleRatio = value;
            }
        }
        
        [JsonProperty("constrain")]
        public string Constrain { get; set; }
        [JsonProperty("constrainttoward")]
        public string ConstraintToWard { get; set; }
        [JsonProperty("matches")]
        public string Matches { get; set; }
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
        
        [JsonProperty("tick0")]
        public string Tick0 { get; set; }
        [JsonProperty("dtick")]
        public string DTick { get; set; }
        [JsonProperty("tickvals")]
        public List<double> TickVals { get; set; }
        [JsonProperty("ticktext")]
        public List<string> TickText { get; set; }
        [JsonProperty("ticks")]
        public string Ticks { get; set; }
        [JsonProperty("tickson")]
        public string TicksOn { get; set; }
        [JsonProperty("mirror")]
        public string Mirror { get; set; }
        
        [JsonProperty("ticklen")]
        public double? Ticklen
        {
            get => _tickLen;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Ticklen must be greater than or equal to 0");
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
        public bool ShowTickLabels { get; set; }
        [JsonProperty("automargin")]
        public bool AutoMargin { get; set; }
        [JsonProperty("showspikes")]
        public bool ShowSpikes { get; set; }
        [JsonProperty("spikecolor")]
        public string SpikeColor { get; set; }
        [JsonProperty("spikethickness")]
        public double? SpikeThickness { get; set; }
        [JsonProperty("spikedash")]
        public string SpikeDash { get; set; }
        [JsonProperty("spikemode")]
        public string SpikeMode { get; set; }
        [JsonProperty("spikesnap")]
        public string SpikeSnap { get; set; }
        [JsonProperty("tickfont")]
        public PlotlyFont TickFont { get; set; }
        [JsonProperty("tickangle")]
        public double? TickAngle { get; set; }
        [JsonProperty("tickprefix")]
        public string TickPrefix { get; set; }
        [JsonProperty("showtickprefix")]
        public string ShowTickPrefix { get; set; }
        [JsonProperty("ticksuffix")]
        public string TickSuffix { get; set; }
        [JsonProperty("showticksuffix")]
        public string ShowTickSuffix { get; set; }
        [JsonProperty("showexponent")]
        public string ShowExponent { get; set; }
        [JsonProperty("exponentformat")]
        public string ExponentFormat { get; set; }
        [JsonProperty("separatethousands")]
        public bool SeparateThousands { get; set; }
        [JsonProperty("tickformat")]
        public string TickFormat { get; set; }
        [JsonProperty("tickformatstops")]
        public TickFormatStops TickFormatStops { get; set; }
        [JsonProperty("hoverformat")]
        public string HoverFormat { get; set; }
        [JsonProperty("showline")]
        public bool ShowLine { get; set; }
        [JsonProperty("linecolor")]
        public string LineColor { get; set; }
        
        [JsonProperty("linewidth")]
        public double? LineWidth
        {
            get => _lineWidth;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"LineWidth must be greater than or equal to 0");
                }

                _lineWidth = value;
            }
        }
        
        [JsonProperty("showgrid")]
        public bool ShowGrid { get; set; }
        [JsonProperty("gridcolor")]
        public string GridColor { get; set; }
        
        [JsonProperty("gridwidth")]
        public double? GridWidth
        {
            get => _gridWidth;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"GridWidth must be greater than or equal to 0");
                }

                _gridWidth = value;
            }
        }
        
        [JsonProperty("zeroline")]
        public bool ZeroLine { get; set; }
        [JsonProperty("zerolinecolor")]
        public string ZeroLineColor { get; set; }
        [JsonProperty("showdividers")]
        public bool ShowDividers { get; set; }
        [JsonProperty("dividercolor")]
        public string DividerColor { get; set; }
        [JsonProperty("dividerwidth")]
        public double? DividerWidth { get; set; }
        [JsonProperty("anchor")]
        public string Anchor { get; set; }
        [JsonProperty("side")]
        public string Side { get; set; }
        [JsonProperty("overlaying")]
        public string Overlaying { get; set; }
        [JsonProperty("layer")]
        public string Layer { get; set; }
        [JsonProperty("domain")]
        public Domain Domain { get; set; }
        
        [JsonProperty("position")]
        public double? Position
        {
            get => _position;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Position must be between or equal to 0 and 1");
                }

                _position = value;
            }
        }
        
        [JsonProperty("categoryorder")]
        public string CategoryOrder { get; set; }
        [JsonProperty("categoryarray")]
        public List<dynamic> CategoryArray { get; set; }
        [JsonProperty("uirevision")]
        public string UiRevision { get; set; }
        [JsonProperty("calendar")]
        public string Calendar { get; set; }
    }
}
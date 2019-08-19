using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Annotations
    {
        private double _width;
        private double _height;
        private double _opacity;
        private double _borderPad;
        private double _borderWidth;
        private int _arrowHead;
        private int _startArrowHead;
        private double _arrowSize;
        private double _startArrowSize;
        private double _arrowWidth;
        private double _standOff;
        private double _startStandOff;
        
        [JsonProperty("visible")]
        public bool Visible { get; set; } = true;
        [JsonProperty("x")]
        public double X { get; set; }
        [JsonProperty("y")]
        public double Y { get; set; }
        [JsonProperty("z")]
        public double Z { get; set; }
        [JsonProperty("ax")]
        public double Ax { get; set; }
        [JsonProperty("ay")]
        public double Ay { get; set; }
        [JsonProperty("xanchor")]
        public string XAnchor { get; set; }
        [JsonProperty("xshift")]
        public double XShift { get; set; }
        [JsonProperty("yanchor")]
        public string YAnchor { get; set; }
        [JsonProperty("yshift")]
        public double YShift { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("textangle")]
        public double TextAngle { get; set; }
        [JsonProperty("font")]
        public PlotlyFont Font { get; set; }
        
        [JsonProperty("width")]
        public double Width
        {
            get => _width;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Width must be greater than or equal to 0");
                }

                _width = value;
            }
        }
        
        [JsonProperty("height")]
        public double Height
        {
            get => _height;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Height must be greater than or equal to 1");
                }

                _height = value;
            }
        }
        
        [JsonProperty("opacity")]
        public double Opacity
        {
            get => _opacity;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Opacity must be greater than or equal to 1");
                }

                _opacity = value;
            }
        }
        
        [JsonProperty("align")]
        public string Align { get; set; }
        [JsonProperty("valign")]
        public string VAlign { get; set; }
        [JsonProperty("bgcolor")]
        public string BgColor { get; set; }
        [JsonProperty("bordercolor")]
        public string BorderColor { get; set; }
        
        [JsonProperty("borderpad")]
        public double BorderPad
        {
            get => _borderPad;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"BorderPad must be greater than or equal to 0");
                }

                _borderPad = value;
            }
        }
        
        [JsonProperty("borderwidth")]
        public double BorderWidth
        {
            get => _borderWidth;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"BorderPad must be greater than or equal to 0");
                }

                _borderWidth = value;
            }
        }
        
        [JsonProperty("showarrow")]
        public bool ShowArrow { get; set; } = true;
        [JsonProperty("arrowcolor")]
        public string ArrowColor { get; set; }
        
        [JsonProperty("arrowhead")]
        public int ArrowHead
        {
            get => _arrowHead;
            set
            {
                if (value < 0 || value > 8)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"ArrowHead must be between or equal to 0 and 8");
                }

                _arrowHead = value;
            }
        }
        
        [JsonProperty("startarrowhead")]
        public int StartArrowHead
        {
            get => _startArrowHead;
            set
            {
                if (value < 0 || value > 8)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"StartArrowHead must be between or equal to 0 and 8");
                }

                _startArrowHead = value;
            }
        }
        
        [JsonProperty("arrowside")]
        public string ArrowSide { get; set; }
        
        [JsonProperty("arrowsize")]
        public double ArrowSize 
        {
            get => _arrowSize;
            set
            {
                if (value < 0.3)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"ArrowSize must be greater than or equal to 0.3");
                }

                _arrowSize = value;
            }
        }
        
        [JsonProperty("startarrowsize")]
        public double StartArrowSize 
        {
            get => _startArrowSize;
            set
            {
                if (value < 0.3)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"StartArrowSize must be greater than or equal to 0.3");
                }

                _startArrowSize = value;
            }
        }
        
        [JsonProperty("arrowwidth")]
        public double ArrowWidth 
        {
            get => _arrowWidth;
            set
            {
                if (value < 0.1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"StartArrowSize must be greater than or equal to 0.1");
                }

                _arrowWidth = value;
            }
        }
        
        [JsonProperty("standoff")]
        public double StandOff 
        {
            get => _standOff;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"StandOff must be greater than or equal to 0");
                }

                _standOff = value;
            }
        }
        
        [JsonProperty("startstandoff")]
        public double StartStandOff 
        {
            get => _startStandOff;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"StartStandOff must be greater than or equal to 0");
                }

                _startStandOff = value;
            }
        }
        
        [JsonProperty("hovertext")]
        public string HoverText { get; set; }
        [JsonProperty("hoverlabel")]
        public HoverLabel HoverLabel { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("templateitemname")]
        public string TemplateItemName { get; set; }
    }
}
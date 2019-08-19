using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Layout
    {
        private int _width;
        private int _height;
        private int _hoverDistance;
        private int _spikeDistance;
        
        [JsonProperty("font")]
        public PlotlyFont Font { get; set; }
        [JsonProperty("title")]
        public Title Title { get; set; }
        
        [JsonProperty("width")]
        public int Width
        {
            get => _width;
            set
            {
                if (value < 10)
                {
                    throw new ArgumentOutOfRangeException("Width must be greater than or equal to 10");
                }

                _width = value;
            }
        }
        
        [JsonProperty("width")]
        public int Height
        {
            get => _height;
            set
            {
                if (value < 10)
                {
                    throw new ArgumentOutOfRangeException("Height must be greater than or equal to 10");
                }

                _height = value;
            }
        }
        
        [JsonProperty("margin")]
        public Margin Margin { get; set; }
        [JsonProperty("paper_bgcolor")]
        public string PaperBgColor { get; set; }
        [JsonProperty("plot_bgcolor")]
        public string PlotBgColor { get; set; }
        [JsonProperty("separators")]
        public string Separators { get; set; }
        [JsonProperty("showlegend")]
        public bool ShowLegend { get; set; }
        [JsonProperty("colorway")]
        public string Colorway { get; set; }
        [JsonProperty("datarevision")]
        public string DataRevision { get; set; }
        [JsonProperty("uirevision")]
        public string UiRevision { get; set; }
        [JsonProperty("editrevision")]
        public string EditRevision { get; set; }
        [JsonProperty("selectionrevision")]
        public string SelectionRevision { get; set; }
        [JsonProperty("template")]
        public string Template { get; set; }
        [JsonProperty("modebar")]
        public ModeBar ModeBar { get; set; }
        [JsonProperty("meta")]
        public string Meta { get; set; }
        [JsonProperty("transition")]
        public Transition Transition { get; set; }
        [JsonProperty("clickmode")]
        public string ClickMode { get; set; }
        [JsonProperty("dragmode")]
        public string DragMode { get; set; }
        [JsonProperty("hovermode")]
        public string HoverMode { get; set; }
        
        [JsonProperty("hoverdistance")]
        public int HoverDistance
        {
            get => _hoverDistance;
            set
            {
                if (value < -1)
                {
                    throw new ArgumentOutOfRangeException("HoverDistance must be greater than or equal to -1");
                }

                _hoverDistance = value;
            }
        }
        
        [JsonProperty("spikedistance")]
        public int SpikeDistance
        {
            get => _spikeDistance;
            set
            {
                if (value < -1)
                {
                    throw new ArgumentOutOfRangeException("SpikeDistance must be greater than or equal to -1");
                }

                _spikeDistance = value;
            }
        }
        
        [JsonProperty("hoverlabel")]
        public HoverLabel HoverLabel { get; set; }
        [JsonProperty("selectdirection")]
        public string SelectDirection { get; set; }
        [JsonProperty("grid")]
        public Grid Grid { get; set; }
        [JsonProperty("calendar")]
        public string Calendar { get; set; }
        [JsonProperty("xaxis")]
        public Axis XAxis { get; set; }
        [JsonProperty("yaxis")]
        public Axis YAxis { get; set; }
        [JsonProperty("ternary")]
        public Ternary Ternary { get; set; }
        [JsonProperty("scene")]
        public Scene Scene { get; set; }
        [JsonProperty("geo")]
        public Geo Geo { get; set; }
        [JsonProperty("mapbox")]
        public MapBox MapBox { get; set; }
        [JsonProperty("polar")]
        public Polar Polar { get; set; }
        [JsonProperty("radialaxis")]
        public Axis RadialAxis { get; set; }
        [JsonProperty("angularaxis")]
        public Axis AngularAxis { get; set; }
        [JsonProperty("direction")]
        public string Direction { get; set; }
        [JsonProperty("orientation")]
        public double Orientation { get; set; }
        [JsonProperty("legend")]
        public Legend Legend { get; set; }
        [JsonProperty("annotations")]
        public Annotations Annotations { get; set; }
        [JsonProperty("shapes")]
        public Shapes Shapes { get; set; }
    }

    public class Shapes
    {
        
    }

    public class Legend
    {
        private double _borderWidth;
        private double _traceGroupGap;
        private double _x;
        private double _y;
        
        [JsonProperty("bgcolor")]
        public string BgColor { get; set; }
        [JsonProperty("bordercolor")]
        public string BorderColor { get; set; }
        
        [JsonProperty("borderwidth")]
        public double BorderWidth
        {
            get => _borderWidth;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("BorderWidth must be greater than or equal to 0");
                }

                _borderWidth = value;
            }
        }
        
        [JsonProperty("font")]
        public PlotlyFont Font { get; set; }
        [JsonProperty("orientation")]
        public string Orientation { get; set; }
        [JsonProperty("traceorder")]
        public string TraceOrder { get; set; }
        
        [JsonProperty("tracegroupgap")]
        public double TraceGroupGap
        {
            get => _traceGroupGap;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("TraceGroupGap must be greater than or equal to 0");
                }

                _traceGroupGap = value;
            }
        }
        
        [JsonProperty("itmesizing")]
        public string ItemSizing { get; set; }
        [JsonProperty("itemclick")]
        public string ItemClick { get; set; }
        [JsonProperty("itemdoubleclick")]
        public string ItemDoubleClick { get; set; }
        
        [JsonProperty("x")]
        public double X
        {
            get => _x;
            set
            {
                if (value < -2 || value > 3)
                {
                    throw new ArgumentOutOfRangeException("X must be between or equal to -2 and 3");
                }

                _x = value;
            }
        }
        
        [JsonProperty("xanchor")]
        public string XAnchor { get; set; }
        
        [JsonProperty("y")]
        public double Y
        {
            get => _y;
            set
            {
                if (value < -2 || value > 3)
                {
                    throw new ArgumentOutOfRangeException("Y must be between or equal to -2 and 3");
                }

                _y = value;
            }
        }
        
        [JsonProperty("yanchor")]
        public string YAnchor { get; set; }
        [JsonProperty("uirevision")]
        public string UiRevision { get; set; }
        [JsonProperty("valign")]
        public string VAlign { get; set; }
    }

    public class Polar
    {
        private double _hole;
        
        [JsonProperty("domain")]
        public Domain Domain { get; set; }
        [JsonProperty("sector")]
        public List<double> Sector { get; set; }
        
        [JsonProperty("hole")]
        public double Hole
        {
            get => _hole;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException("Hole must be between or equal to 0 and 1");
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
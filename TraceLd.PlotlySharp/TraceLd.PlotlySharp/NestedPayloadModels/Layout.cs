using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Layout
    {
        private double? _width;
        private double? _height;
        private int? _hoverDistance;
        private int? _spikeDistance;
        private double? _boxGap;
        private double? _boxGroupGap;
        private double? _barGap;
        private double? _barGroupGap;
        private double? _violinGap;
        private double? _violinGroupGap;
        private double? _waterfallGap;
        private double? _waterfallGroupGap;
        
        [JsonProperty("font")]
        public PlotlyFont Font { get; set; }
        [JsonProperty("title")]
        public Title Title { get; set; }
        
        [JsonProperty("width")]
        public double? Width
        {
            get => _width;
            set
            {
                if (value < 10)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Width must be greater than or equal to 10");
                }

                _width = value;
            }
        }
        
        [JsonProperty("height")]
        public double? Height
        {
            get => _height;
            set
            {
                if (value < 10)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Height must be greater than or equal to 10");
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
        public List<string> Colorway { get; set; }
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
        public int? HoverDistance
        {
            get => _hoverDistance;
            set
            {
                if (value < -1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"HoverDistance must be greater than or equal to -1");
                }

                _hoverDistance = value;
            }
        }
        
        [JsonProperty("spikedistance")]
        public int? SpikeDistance
        {
            get => _spikeDistance;
            set
            {
                if (value < -1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"SpikeDistance must be greater than or equal to -1");
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
        public double? Orientation { get; set; }
        [JsonProperty("legend")]
        public Legend Legend { get; set; }
        [JsonProperty("annotations")]
        public Annotations Annotations { get; set; }
        [JsonProperty("shapes")]
        public Shapes Shapes { get; set; }
        [JsonProperty("images")]
        public Images Images { get; set; }
        [JsonProperty("updatemenus")]
        public Menus UpdateMenus { get; set; }
        [JsonProperty("sliders")]
        public Sliders Sliders { get; set; }
        [JsonProperty("boxmode")]
        public string BoxMode { get; set; }
        
        [JsonProperty("boxgap")]
        public double? BoxGap
        {
            get => _boxGap;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"BoxGap must be between or equal to 0 and 1");
                }

                _boxGap = value;
            }
        }
        
        [JsonProperty("boxgroupgap")]
        public double? BoxGroupGap
        {
            get => _boxGroupGap;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"BoxGroupGap must be between or equal to 0 and 1");
                }

                _boxGroupGap = value;
            }
        }
        
        [JsonProperty("barmode")]
        public string BarMode { get; set; }
        [JsonProperty("barnorm")]
        public string BarNorm { get; set; }
        
        [JsonProperty("bargap")]
        public double? BarGap
        {
            get => _barGap;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"BarGap must be between or equal to 0 and 1");
                }

                _barGap = value;
            }
        }
        
        [JsonProperty("bargroupgap")]
        public double? BarGroupGap
        {
            get => _barGroupGap;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"BarGroupGap must be between or equal to 0 and 1");
                }

                _barGroupGap = value;
            }
        }
        
        [JsonProperty("violinmode")]
        public string ViolinMode { get; set; }
        
        [JsonProperty("violingap")]
        public double? ViolinGap
        {
            get => _violinGap;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"ViolinGap must be between or equal to 0 and 1");
                }

                _violinGap = value;
            }
        }
        
        [JsonProperty("violingroupgap")]
        public double? ViolinGroupGap
        {
            get => _violinGroupGap;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"ViolinGroupGap must be between or equal to 0 and 1");
                }

                _violinGroupGap = value;
            }
        }
        
        [JsonProperty("waterfallmode")]
        public string WaterfallMode { get; set; }
        
        [JsonProperty("waterfallgap")]
        public double? WaterfallGap
        {
            get => _waterfallGap;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"WaterfallGap must be between or equal to 0 and 1");
                }

                _waterfallGap = value;
            }
        }
        
        [JsonProperty("waterfallgroupgap")]
        public double? WaterfallGroupGap
        {
            get => _waterfallGroupGap;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"WaterfallGroupGap must be between or equal to 0 and 1");
                }

                _waterfallGroupGap = value;
            }
        }
        
        [JsonProperty("hiddenlabels")]
        public List<dynamic> HiddenLabels { get; set; }
        [JsonProperty("piecolorway")]
        public List<string> PieColorway { get; set; }
        [JsonProperty("extendpiecolors")]
        public bool ExtendPieColors { get; set; } = true;
        [JsonProperty("sunburstcolorway")]
        public List<string> SunBurstColorway { get; set; }
        [JsonProperty("extendburstcolors")]
        public bool ExtendBurstColors { get; set; } = true;
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api.Traces
{
    public class Trace
    {
        private double? _opacity;
        
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("visible")]
        public bool Visible { get; set; } = true;
        
        [JsonProperty("showlegend")]
        public bool ShowLegend { get; set; } = true;
        
        [JsonProperty("legendgroup")]
        public string LegendGroup { get; set; }
        
        [JsonProperty("opacity")]
        public double? Opacity
        {
            get => _opacity;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Opacity must be between or equal to 0 and 1");
                }

                _opacity = value;
            }
        }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("meta")]
        public string Meta { get; set; }
        
        [JsonProperty("selectedpoints")]
        public string SelectedPoints { get; set; }
        
        [JsonProperty("hoverinfo")]
        public string HoverInfo { get; set; }
        
        [JsonProperty("hoverlabel")]
        public HoverLabel HoverLabel { get; set; }
        
        [JsonProperty("uirevision")]
        public string UiRevision { get; set; }
        
        [JsonProperty("x")]
        public ArrayList X { get; set; }
        
        [JsonProperty("x0")]
        public ArrayList X0 { get; set; }
        
        [JsonProperty("dx")]
        public double? Dx { get; set; }
        
        [JsonProperty("y")]
        public ArrayList Y { get; set; }
        
        [JsonProperty("y0")]
        public ArrayList Y0 { get; set; }
        
        [JsonProperty("dy")]
        public double? Dy { get; set; }
        
        [JsonProperty("text")]
        public string Text { get; set; }
        
        [JsonProperty("hovertext")]
        public string HoverText { get; set; }
        
        [JsonProperty("hovertemplate")]
        public string HoverTemplate { get; set; }
        
        [JsonProperty("textposition")]
        public string TextPosition { get; set; }
        
        [JsonProperty("textangle")]
        public string TextAngle { get; set; }
        
        [JsonProperty("textfont")]
        public Font TextFont { get; set; }
        
        [JsonProperty("orientation")]
        public double? Orientation { get; set; }
        
        [JsonProperty("marker")]
        public Marker Marker { get; set; }
        
        [JsonProperty("selected")]
        public Selection Selected { get; set; }
        
        [JsonProperty("unselected")]
        public Selection Unselected { get; set; }
        
        [JsonProperty("xcalendar")]
        public Selection XCalendar { get; set; }
        
        [JsonProperty("ycalendar")]
        public Selection YCalendar { get; set; }
        
        [JsonProperty("cliponaxis")]
        public bool ClipOnAxis { get; set; } = true;
        
        [JsonProperty("ids")]
        public ArrayList Ids { get; set; }
        
        [JsonProperty("customdata")]
        public ArrayList CustomData { get; set; }
        
        [JsonProperty("values")]
        public ArrayList Values { get; set; }
        
        [JsonProperty("error_x")]
        public Error ErrorX { get; set; }
        
        [JsonProperty("error_y")]
        public Error ErrorY { get; set; }
        
        [JsonProperty("colorbar")]
        public BarDto ColorBar { get; set; }
    }
}
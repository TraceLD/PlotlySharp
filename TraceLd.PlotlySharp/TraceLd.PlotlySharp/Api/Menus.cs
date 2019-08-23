using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Menus
    {
        private double? _active;
        private double? _x;
        private double? _y;
        private double? _borderWidth;
        
        [JsonProperty("visible")]
        public bool Visible { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("direction")]
        public string Direction { get; set; }
        
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
        
        [JsonProperty("showactive")]
        public bool ShowActive { get; set; } = true;
        [JsonProperty("buttons")]
        public Buttons Buttons { get; set; }
        
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
                    throw new ArgumentOutOfRangeException(nameof(value), "Y must be between or equal to -2 and 3");
                }

                _y = value;
            }
        }
        
        [JsonProperty("yanchor")]
        public string YAnchor { get; set; }
        [JsonProperty("pad")]
        public Pad Pad { get; set; }
        [JsonProperty("font")]
        public Font Font { get; set; }
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
                    throw new ArgumentOutOfRangeException(nameof(value), "BorderWidth must be greater than or equal to 0");
                }

                _borderWidth = value;
            }
        }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("templateitemname")]
        public string TemplateItemName { get; set; }
    }
}
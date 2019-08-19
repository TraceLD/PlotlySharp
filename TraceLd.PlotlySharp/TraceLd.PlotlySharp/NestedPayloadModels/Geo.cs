using System;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Geo
    {
        private double? _coastLineWidth;
        private double? _riverWidth;
        private double? _countryWidth;
        private double? _subunitWidth;
        private double? _frameWidth;
        
        [JsonProperty("domain")]
        public Domain Domain { get; set; }
        [JsonProperty("resolution")]
        public string Resolution { get; set; }
        [JsonProperty("scope")]
        public string Scope { get; set; }
        [JsonProperty("projection")]
        public Projection Projection { get; set; }
        [JsonProperty("center")]
        public LonLat Center { get; set; }
        [JsonProperty("showcoastlines")]
        public bool ShowCoastLines { get; set; } = true;
        [JsonProperty("coastlinecolor")]
        public string CoastLineColor { get; set; }
        
        [JsonProperty("coastlinewidth")]
        public double? CoastLineWidth
        {
            get => _coastLineWidth;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"CoastLineWidth must be greater than or equal to 0");
                }

                _coastLineWidth = value;
            }
        }
        
        [JsonProperty("showland")]
        public bool ShowLand { get; set; } = true;
        [JsonProperty("landcolor")]
        public string LandColor { get; set; }
        
        [JsonProperty("showocean")]
        public bool ShowOcean { get; set; } = true;
        [JsonProperty("oceancolor")]
        public string OceanColor { get; set; }
        
        [JsonProperty("showlakes")]
        public bool ShowLakes { get; set; } = true;
        [JsonProperty("lakecolor")]
        public string LakeColor { get; set; }
        
        [JsonProperty("showrivers")]
        public bool ShowRivers { get; set; } = true;
        [JsonProperty("rivercolor")]
        public string RiverColor { get; set; }
        
        [JsonProperty("riverwidth")]
        public double? RiverWidth
        {
            get => _riverWidth;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"RiverWidth must be greater than or equal to 0");
                }

                _riverWidth = value;
            }
        }
        
        [JsonProperty("showcountries")]
        public bool ShowCountries { get; set; } = true;
        [JsonProperty("countrycolor")]
        public string CountryColor { get; set; }
        
        [JsonProperty("countrywidth")]
        public double? CountryWidth
        {
            get => _countryWidth;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"CountryWidth must be greater than or equal to 0");
                }

                _countryWidth = value;
            }
        }
        
        [JsonProperty("showsubunits")]
        public bool ShowSubunits { get; set; } = true;
        [JsonProperty("subunitcolor")]
        public string SubunitColor { get; set; }
        
        [JsonProperty("subunitwidth")]
        public double? SubunitWidth
        {
            get => _subunitWidth;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"SubunitWidth must be greater than or equal to 0");
                }

                _subunitWidth = value;
            }
        }
        
        [JsonProperty("showframe")]
        public bool ShowFrame { get; set; }
        [JsonProperty("framecolor")]
        public string FrameColor { get; set; }
        
        [JsonProperty("framewidth")]
        public double? FrameWidth
        {
            get => _frameWidth;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"FrameWidth must be greater than or equal to 0");
                }

                _frameWidth = value;
            }
        }
        
        [JsonProperty("bgcolor")]
        public string BgColor { get; set; }
        [JsonProperty("lonaxis")]
        public Axis IonAxis { get; set; }
        [JsonProperty("lataxis")]
        public Axis LatAxis { get; set; }
        [JsonProperty("uirevision")]
        public string UiRevision { get; set; }
    }
}
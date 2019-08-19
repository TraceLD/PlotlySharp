using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes
{
    public class ModeBar
    {
        [JsonProperty("orientation")]
        public string Orientation { get; set; }
        [JsonProperty("bgcolor")]
        public string BgColor { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
        [JsonProperty("activecolor")]
        public string ActiveColor { get; set; }
        [JsonProperty("uirevision")]
        public string UiRevision { get; set; }
    }
}
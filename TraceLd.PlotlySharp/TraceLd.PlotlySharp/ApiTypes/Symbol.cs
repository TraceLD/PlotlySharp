using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes
{
    public class Symbol
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("iconsize")]
        public double IconSize { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("placement")]
        public string Placement { get; set; }
        [JsonProperty("textfont")]
        public PlotlyFont TextFont { get; set; }
        [JsonProperty("textposition")]
        public string TextPosition { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("templateitemname")]
        public string TemplateItemName { get; set; }
    }
}
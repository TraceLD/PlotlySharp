using Newtonsoft.Json;

namespace TraceLd.PlotlySharp
{
    public class PlotPayload
    {
        [JsonProperty("figure")]
        public Figure Figure { get; set; }
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("format")]
        public string Format { get; set; }
        [JsonProperty("encoded")]
        public string Encoded { get; } = "false";
    }
}
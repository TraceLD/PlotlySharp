using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes.Traces
{
    public class Selection
    {
        [JsonProperty("marker")]
        public Marker Marker { get; set; }
        
        [JsonProperty("textfont")]
        public PlotlyFont TextFont { get; set; }
    }
}
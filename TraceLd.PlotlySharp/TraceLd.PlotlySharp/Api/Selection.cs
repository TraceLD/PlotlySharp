using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Selection
    {
        [JsonProperty("marker")]
        public Marker Marker { get; set; }
        
        [JsonProperty("textfont")]
        public Font TextFont { get; set; }
    }
}
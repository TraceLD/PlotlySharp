using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes
{
    public class Line
    {
        [JsonProperty("width")]
        public double? Width { get; set; }
    }
}
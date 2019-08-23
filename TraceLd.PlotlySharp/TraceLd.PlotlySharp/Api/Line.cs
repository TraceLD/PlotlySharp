using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Line
    {
        [JsonProperty("width")]
        public double? Width { get; set; }
    }
}
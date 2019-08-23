using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Circle
    {
        [JsonProperty("radius")]
        public double? Radius { get; set; }
    }
}
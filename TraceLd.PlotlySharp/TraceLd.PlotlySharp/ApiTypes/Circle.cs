using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes
{
    public class Circle
    {
        [JsonProperty("radius")]
        public double? Radius { get; set; }
    }
}
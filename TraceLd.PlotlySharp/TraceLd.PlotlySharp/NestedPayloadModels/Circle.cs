using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Circle
    {
        [JsonProperty("radius")]
        public double Radius { get; set; }
    }
}
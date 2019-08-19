using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.NestedPayloadModels
{
    public class Rotation : LonLat
    {
        [JsonProperty("roll")]
        public double Roll { get; set; }
    }
}
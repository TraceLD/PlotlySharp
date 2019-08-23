using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Rotation : LonLat
    {
        [JsonProperty("roll")]
        public double? Roll { get; set; }
    }
}
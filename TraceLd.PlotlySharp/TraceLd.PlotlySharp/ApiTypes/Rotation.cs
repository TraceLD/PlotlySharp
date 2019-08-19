using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes
{
    public class Rotation : LonLat
    {
        [JsonProperty("roll")]
        public double? Roll { get; set; }
    }
}
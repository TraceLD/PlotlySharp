using System.Collections;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Figure
    {
        [JsonProperty("data")]
        public ArrayList Data { get; set; }
        [JsonProperty("layout")]
        public Layout Layout { get; set; }
    }
}
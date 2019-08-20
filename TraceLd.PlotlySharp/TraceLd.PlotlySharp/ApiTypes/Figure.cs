using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes
{
    public class Figure
    {
        [JsonProperty("data")]
        public ArrayList Data { get; set; }
        [JsonProperty("layout")]
        public Layout Layout { get; set; }
    }
}
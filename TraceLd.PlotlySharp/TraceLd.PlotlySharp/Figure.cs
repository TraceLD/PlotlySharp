using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp
{
    public class Figure
    {
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
        [JsonProperty("layout")]
        public Layout Layout { get; set; }
    }

    public class Layout
    {
        [JsonProperty("width")]
        public int Width { get; set; }
    }
}
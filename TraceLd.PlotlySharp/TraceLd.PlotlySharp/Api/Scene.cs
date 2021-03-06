using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.Api
{
    public class Scene
    {
        [JsonProperty("bgcolor")]
        public string BgColor { get; set; }
        [JsonProperty("camera")]
        public Camera Camera { get; set; }
        [JsonProperty("domain")]
        public Domain Domain { get; set; }
        [JsonProperty("aspectmode")]
        public string AspectMode { get; set; }
        [JsonProperty("aspectratio")]
        public Vector AspectRatio { get; set; }
        [JsonProperty("xaxis")]
        public Axis XAxis { get; set; }
        [JsonProperty("yaxis")]
        public Axis YAxis { get; set; }
        [JsonProperty("zaxis")]
        public Axis ZAxis { get; set; }
        [JsonProperty("dragmode")]
        public string DragMode { get; set; }
        [JsonProperty("hovermode")]
        public string HoverMode { get; set; }
        [JsonProperty("uirevision")]
        public string UiRevision { get; set; }
        [JsonProperty("annotations")]
        public List<Annotation> Annotations { get; set; }
    }
}
using Newtonsoft.Json;

namespace TraceLd.PlotlySharp.ApiTypes
{
    public class Steps
    {
        [JsonProperty("visible")]
        public bool Visible { get; set; } = true;
        [JsonProperty("method")]
        public string Method { get; set; }
        [JsonProperty("args")]
        public string[] Args { get; set; }
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("execute")]
        public bool Execute { get; set; } = true;
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("templateitemname")]
        public string TemplateItemName { get; set; }
    }
}
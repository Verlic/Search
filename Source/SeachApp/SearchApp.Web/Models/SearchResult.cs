namespace SearchApp.Web.Models
{
    using Newtonsoft.Json;

    public class SearchResult
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }
}
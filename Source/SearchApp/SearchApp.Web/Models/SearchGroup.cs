namespace SearchApp.Web.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class SearchGroup
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("results")]
        public List<SearchResult> Results { get; set; } 
    }
}
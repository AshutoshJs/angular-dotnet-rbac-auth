using System.Text.Json.Serialization;

namespace JwtRoledBasedAuth.CommonHeper.PaginationAndFilter
{
    public class PageParameters
    {
        [JsonPropertyName("pageNumber")]
        public int PageNumber { get; set; } = 1;
        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; } = 20;

        [JsonPropertyName("filter")]
        public string FilterParam { get; set; }

        public string Data { get; set; }
    }
}

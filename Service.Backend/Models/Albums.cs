using Newtonsoft.Json;

namespace Service.Backend.Models
{
    public class Album
    {
        [JsonProperty("userId")] public int UserId { get; set; }

        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("title")] public string Title { get; set; }
    }

    public class AlbumId
    {
        [JsonProperty("id")] public int Id { get; set; }
    }
}
using Newtonsoft.Json;

namespace Service.Backend.API.Models
{
    public class AlbumPhoto
    {
        [JsonProperty("albumId")] public int AlbumId { get; set; }
        [JsonProperty("userId")] public int UserId { get; set; }
        [JsonProperty("id")] public int Id { get; set; }
    }
}
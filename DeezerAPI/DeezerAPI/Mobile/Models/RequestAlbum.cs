using Newtonsoft.Json;

namespace DeezerAPI.Mobile.Models
{
    public class RequestAlbum
    {
        [JsonProperty("alb_id")]
        public string AlbumID { get; set; }
    }
}

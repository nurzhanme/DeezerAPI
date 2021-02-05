using Newtonsoft.Json;

namespace DeezerAPI.Mobile.Models
{
    public class RequestPlaylist
    {
        [JsonProperty("playlist_id")]
        public string PlaylistID { get; set; }
    }
}

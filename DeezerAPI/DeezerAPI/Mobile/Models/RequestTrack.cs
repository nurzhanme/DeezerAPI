using Newtonsoft.Json;

namespace DeezerAPI.Mobile.Models
{
    public class RequestTrack
    {
        [JsonProperty("sng_id")]
        public string TrackID { get; set; }
    }
}

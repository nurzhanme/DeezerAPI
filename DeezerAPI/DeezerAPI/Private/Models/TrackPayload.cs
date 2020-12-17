using Newtonsoft.Json;

namespace DeezerAPI.Private
{
    internal class TrackPayload
    {
        [JsonProperty("sng_id")]
        public string SongID { get; set; }
    }
}

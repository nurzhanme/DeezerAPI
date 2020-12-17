using Newtonsoft.Json;

namespace DeezerAPI.Private
{
    internal class AlbumPayload
    {
        [JsonProperty("alb_id")]
        public string AlbumID { get; set; }

        [JsonProperty("header")]
        public bool Headers = true;

        [JsonProperty("lang")]
        public string Lang = "en";

        [JsonProperty("tab")]
        public int Tab = 0;
    }
}

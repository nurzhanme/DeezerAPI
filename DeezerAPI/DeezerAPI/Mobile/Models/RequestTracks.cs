using Newtonsoft.Json;
using System.Collections.Generic;

namespace DeezerAPI.Mobile.Models
{
    public class RequestTracks
    {
        [JsonProperty("sng_ids")]
        public List<string> TrackIDs { get; set; }
    }
}

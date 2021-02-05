using Newtonsoft.Json;
using System.Collections.Generic;

namespace DeezerAPI.Mobile.Models
{
    public partial class Lyrics
    {
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Error { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public Results Results { get; set; }
    }

    public partial class Results
    {
        [JsonProperty("LYRICS_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? LyricsId { get; set; }

        [JsonProperty("LYRICS_SYNC_JSON", NullValueHandling = NullValueHandling.Ignore)]
        public List<LyricsSyncJson> LyricsSyncJson { get; set; }

        [JsonProperty("LYRICS_TEXT", NullValueHandling = NullValueHandling.Ignore)]
        public string LyricsText { get; set; }

        [JsonProperty("LYRICS_COPYRIGHTS", NullValueHandling = NullValueHandling.Ignore)]
        public string LyricsCopyrights { get; set; }

        [JsonProperty("LYRICS_WRITERS", NullValueHandling = NullValueHandling.Ignore)]
        public string LyricsWriters { get; set; }
    }

    public partial class LyricsSyncJson
    {
        [JsonProperty("lrc_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string LrcTimestamp { get; set; }

        [JsonProperty("milliseconds", NullValueHandling = NullValueHandling.Ignore)]
        public long? Milliseconds { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public string Line { get; set; }
    }
}

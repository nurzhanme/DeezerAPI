using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DeezerAPI.Mobile.Models.Playlist
{
    public partial class Playlist
    {
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Error { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public Results Results { get; set; }
    }

    public partial class Results
    {
        [JsonProperty("PLAYLIST_ID", NullValueHandling = NullValueHandling.Ignore)]
        public string PlaylistId { get; set; }

        [JsonProperty("DESCRIPTION", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("PARENT_USERNAME", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentUsername { get; set; }

        [JsonProperty("PARENT_USER_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentUserPicture { get; set; }

        [JsonProperty("PARENT_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParentUserId { get; set; }

        [JsonProperty("PICTURE_TYPE", NullValueHandling = NullValueHandling.Ignore)]
        public string PictureType { get; set; }

        [JsonProperty("PLAYLIST_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
        public string PlaylistPicture { get; set; }

        [JsonProperty("TITLE", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("TYPE", NullValueHandling = NullValueHandling.Ignore)]
        public long? Type { get; set; }

        [JsonProperty("STATUS", NullValueHandling = NullValueHandling.Ignore)]
        public long? Status { get; set; }

        [JsonProperty("USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? UserId { get; set; }

        [JsonProperty("DATE_ADD", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateAdd { get; set; }

        [JsonProperty("DATE_MOD", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateMod { get; set; }

        [JsonProperty("DATE_CREATE", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateCreate { get; set; }

        [JsonProperty("NB_SONG", NullValueHandling = NullValueHandling.Ignore)]
        public long? NbSong { get; set; }

        [JsonProperty("NB_FAN", NullValueHandling = NullValueHandling.Ignore)]
        public long? NbFan { get; set; }

        [JsonProperty("CHECKSUM", NullValueHandling = NullValueHandling.Ignore)]
        public string Checksum { get; set; }

        [JsonProperty("HAS_ARTIST_LINKED", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasArtistLinked { get; set; }

        [JsonProperty("IS_SPONSORED", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSponsored { get; set; }

        [JsonProperty("IS_EDITO", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEdito { get; set; }

        [JsonProperty("__TYPE__", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultsType { get; set; }
    }
}

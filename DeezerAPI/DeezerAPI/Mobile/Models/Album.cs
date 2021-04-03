using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DeezerAPI.Mobile.Models.Album
{
    public partial class Album
    {
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Error { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public Results Results { get; set; }
    }

    public partial class Results
    {
        [JsonProperty("ALB_CONTRIBUTORS", NullValueHandling = NullValueHandling.Ignore)]
        public AlbContributors AlbContributors { get; set; }

        [JsonProperty("ALB_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? AlbId { get; set; }

        [JsonProperty("ALB_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
        public string AlbPicture { get; set; }

        [JsonProperty("EXPLICIT_ALBUM_CONTENT", NullValueHandling = NullValueHandling.Ignore)]
        public ExplicitAlbumContent ExplicitAlbumContent { get; set; }

        [JsonProperty("ALB_TITLE", NullValueHandling = NullValueHandling.Ignore)]
        public string AlbTitle { get; set; }

        [JsonProperty("ARTISTS", NullValueHandling = NullValueHandling.Ignore)]
        public List<Artist> Artists { get; set; }

        [JsonProperty("ART_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ArtId { get; set; }

        [JsonProperty("ART_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtName { get; set; }

        [JsonProperty("ARTIST_IS_DUMMY", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ArtistIsDummy { get; set; }

        [JsonProperty("DIGITAL_RELEASE_DATE", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DigitalReleaseDate { get; set; }

        [JsonProperty("EXPLICIT_LYRICS", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExplicitLyrics { get; set; }

        [JsonProperty("NB_FAN", NullValueHandling = NullValueHandling.Ignore)]
        public long? NbFan { get; set; }

        [JsonProperty("NUMBER_DISK", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumberDisk { get; set; }

        [JsonProperty("NUMBER_TRACK", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumberTrack { get; set; }

        [JsonProperty("PHYSICAL_RELEASE_DATE", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PhysicalReleaseDate { get; set; }

        [JsonProperty("PRODUCER_LINE", NullValueHandling = NullValueHandling.Ignore)]
        public string ProducerLine { get; set; }

        [JsonProperty("PROVIDER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProviderId { get; set; }

        [JsonProperty("RANK", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rank { get; set; }

        [JsonProperty("RANK_ART", NullValueHandling = NullValueHandling.Ignore)]
        public long? RankArt { get; set; }

        [JsonProperty("STATUS", NullValueHandling = NullValueHandling.Ignore)]
        public long? Status { get; set; }

        [JsonProperty("TYPE", NullValueHandling = NullValueHandling.Ignore)]
        public long? Type { get; set; }

        [JsonProperty("UPC", NullValueHandling = NullValueHandling.Ignore)]
        public string Upc { get; set; }

    }

    public partial class AlbContributors
    {
        [JsonProperty("main_artist", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MainArtist { get; set; }
    }

    public partial class Artist
    {
        [JsonProperty("ART_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ArtId { get; set; }

        [JsonProperty("ROLE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? RoleId { get; set; }

        [JsonProperty("ARTISTS_ALBUMS_ORDER", NullValueHandling = NullValueHandling.Ignore)]
        public long? ArtistsAlbumsOrder { get; set; }

        [JsonProperty("ART_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtName { get; set; }

        [JsonProperty("ART_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtPicture { get; set; }

        [JsonProperty("RANK", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rank { get; set; }

    }

    public partial class ExplicitAlbumContent
    {
        [JsonProperty("EXPLICIT_LYRICS_STATUS", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExplicitLyricsStatus { get; set; }

        [JsonProperty("EXPLICIT_COVER_STATUS", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExplicitCoverStatus { get; set; }
    }
}

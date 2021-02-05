using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DeezerAPI.Mobile.Models.Track
{
    public partial class Track
    {
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Error { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public Results Results { get; set; }
    }

    public partial class Tracks
    {
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Error { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public Data Results { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Results> Results { get; set; }
    }

    public partial class Results
    {
        [JsonProperty("ALB_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? AlbId { get; set; }

        [JsonProperty("ALB_TITLE", NullValueHandling = NullValueHandling.Ignore)]
        public string AlbTitle { get; set; }

        [JsonProperty("ALB_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
        public string AlbPicture { get; set; }

        [JsonProperty("ARTISTS", NullValueHandling = NullValueHandling.Ignore)]
        public List<Artist> Artists { get; set; }

        [JsonProperty("ART_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ArtId { get; set; }

        [JsonProperty("ART_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtName { get; set; }

        [JsonProperty("ARTIST_IS_DUMMY", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ArtistIsDummy { get; set; }

        [JsonProperty("ART_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtPicture { get; set; }

        [JsonProperty("DATE_START", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateStart { get; set; }

        [JsonProperty("DISK_NUMBER", NullValueHandling = NullValueHandling.Ignore)]
        public long? DiskNumber { get; set; }

        [JsonProperty("DURATION", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        [JsonProperty("EXPLICIT_TRACK_CONTENT", NullValueHandling = NullValueHandling.Ignore)]
        public ExplicitTrackContent ExplicitTrackContent { get; set; }

        [JsonProperty("ISRC", NullValueHandling = NullValueHandling.Ignore)]
        public string Isrc { get; set; }

        [JsonProperty("LYRICS_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? LyricsId { get; set; }

        [JsonProperty("RANK", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rank { get; set; }

        [JsonProperty("SMARTRADIO", NullValueHandling = NullValueHandling.Ignore)]
        public long? Smartradio { get; set; }

        [JsonProperty("SNG_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? SngId { get; set; }

        [JsonProperty("SNG_TITLE", NullValueHandling = NullValueHandling.Ignore)]
        public string SngTitle { get; set; }

        [JsonProperty("SNG_CONTRIBUTORS", NullValueHandling = NullValueHandling.Ignore)]
        public SngContributors SngContributors { get; set; }

        [JsonProperty("STATUS", NullValueHandling = NullValueHandling.Ignore)]
        public long? Status { get; set; }

        [JsonProperty("S_MOD", NullValueHandling = NullValueHandling.Ignore)]
        public long? SMod { get; set; }

        [JsonProperty("S_PREMIUM", NullValueHandling = NullValueHandling.Ignore)]
        public long? SPremium { get; set; }

        [JsonProperty("TRACK_NUMBER", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrackNumber { get; set; }

        [JsonProperty("URL_REWRITING", NullValueHandling = NullValueHandling.Ignore)]
        public string UrlRewriting { get; set; }

        [JsonProperty("VERSION", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("MD5_ORIGIN", NullValueHandling = NullValueHandling.Ignore)]
        public string Md5Origin { get; set; }

        [JsonProperty("FILESIZE_AAC_64", NullValueHandling = NullValueHandling.Ignore)]
        public long? FilesizeAac64 { get; set; }

        [JsonProperty("FILESIZE_MP3_64", NullValueHandling = NullValueHandling.Ignore)]
        public long? FilesizeMp364 { get; set; }

        [JsonProperty("FILESIZE_MP3_128", NullValueHandling = NullValueHandling.Ignore)]
        public long? FilesizeMp3128 { get; set; }

        [JsonProperty("FILESIZE_MP3_256", NullValueHandling = NullValueHandling.Ignore)]
        public long? FilesizeMp3256 { get; set; }

        [JsonProperty("FILESIZE_MP3_320", NullValueHandling = NullValueHandling.Ignore)]
        public long? FilesizeMp3320 { get; set; }

        [JsonProperty("FILESIZE_MP4_RA1", NullValueHandling = NullValueHandling.Ignore)]
        public long? FilesizeMp4Ra1 { get; set; }

        [JsonProperty("FILESIZE_MP4_RA2", NullValueHandling = NullValueHandling.Ignore)]
        public long? FilesizeMp4Ra2 { get; set; }

        [JsonProperty("FILESIZE_MP4_RA3", NullValueHandling = NullValueHandling.Ignore)]
        public long? FilesizeMp4Ra3 { get; set; }

        [JsonProperty("FILESIZE_FLAC", NullValueHandling = NullValueHandling.Ignore)]
        public long? FilesizeFlac { get; set; }

        [JsonProperty("FILESIZE", NullValueHandling = NullValueHandling.Ignore)]
        public long? Filesize { get; set; }

        [JsonProperty("GAIN", NullValueHandling = NullValueHandling.Ignore)]
        public float? Gain { get; set; }

        [JsonProperty("MEDIA_VERSION", NullValueHandling = NullValueHandling.Ignore)]
        public long? MediaVersion { get; set; }

        [JsonProperty("TRACK_TOKEN", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackToken { get; set; }

        [JsonProperty("TRACK_TOKEN_EXPIRE", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrackTokenExpire { get; set; }

        [JsonProperty("MEDIA", NullValueHandling = NullValueHandling.Ignore)]
        public List<Media> Media { get; set; }

        [JsonProperty("RIGHTS", NullValueHandling = NullValueHandling.Ignore)]
        public Rights Rights { get; set; }

        [JsonProperty("PROVIDER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProviderId { get; set; }

        [JsonProperty("__TYPE__", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class Artist
    {
        [JsonProperty("ART_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ArtId { get; set; }

        [JsonProperty("ROLE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? RoleId { get; set; }

        [JsonProperty("ARTISTS_SONGS_ORDER", NullValueHandling = NullValueHandling.Ignore)]
        public long? ArtistsSongsOrder { get; set; }

        [JsonProperty("ART_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtName { get; set; }

        [JsonProperty("ARTIST_IS_DUMMY", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ArtistIsDummy { get; set; }

        [JsonProperty("ART_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtPicture { get; set; }

        [JsonProperty("RANK", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rank { get; set; }

        [JsonProperty("LOCALES", NullValueHandling = NullValueHandling.Ignore)]
        public Locales Locales { get; set; }

        [JsonProperty("SMARTRADIO", NullValueHandling = NullValueHandling.Ignore)]
        public long? Smartradio { get; set; }

        [JsonProperty("__TYPE__", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class Locales
    {
        [JsonProperty("lang_ja-jpan", NullValueHandling = NullValueHandling.Ignore)]
        public Lang LangJaJpan { get; set; }

        [JsonProperty("lang_ja-hrkt", NullValueHandling = NullValueHandling.Ignore)]
        public Lang LangJaHrkt { get; set; }

        [JsonProperty("lang_zh-hant", NullValueHandling = NullValueHandling.Ignore)]
        public Lang LangZhHant { get; set; }
    }

    public partial class Lang
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public partial class ExplicitTrackContent
    {
        [JsonProperty("EXPLICIT_LYRICS_STATUS", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExplicitLyricsStatus { get; set; }

        [JsonProperty("EXPLICIT_COVER_STATUS", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExplicitCoverStatus { get; set; }
    }

    public partial class Media
    {
        [JsonProperty("TYPE", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("HREF", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Href { get; set; }
    }

    public partial class Rights
    {
        [JsonProperty("STREAM_ADS_AVAILABLE", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StreamAdsAvailable { get; set; }

        [JsonProperty("STREAM_ADS", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StreamAds { get; set; }

        [JsonProperty("STREAM_SUB_AVAILABLE", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StreamSubAvailable { get; set; }

        [JsonProperty("STREAM_SUB", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StreamSub { get; set; }
    }

    public partial class SngContributors
    {
        [JsonProperty("main_artist", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MainArtist { get; set; }

        [JsonProperty("composer", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Composer { get; set; }
    }
}

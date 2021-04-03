using DeezerAPI.Mobile.Models;
using DeezerAPI.Mobile.Models.Album;
using DeezerAPI.Mobile.Models.Lyrics;
using DeezerAPI.Models;
using DeezerAPI.Private;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Playlist = DeezerAPI.Mobile.Models.Playlist.Playlist;

namespace DeezerAPI.Mobile
{
    public class Client : IUnauthenticatedMobileAPI, IAuthenticatedMobileAPI
    {
        private WebClient webClient;
        private string SID;
        private string ARL = string.Empty;

        public Client()
        {
            webClient = new WebClient();
            webClient.Headers.Add("User-Agent", MobileConstants.UserAgent);
            if (this.GetType() == typeof(IAuthenticatedMobileAPI))
            {
                throw new Exception("Authenticated Deezer API must provide ARL Cookie");
            }
        }

        public Client(string arl)
        {
            webClient = new WebClient();
            webClient.Headers.Add("User-Agent", MobileConstants.UserAgent);
            ARL = arl;
        }

        public string GetSID()
        {
            return SID;
        }

        public async Task GenerateSID()
        {
            WebClient webClient = new WebClient();

            // To Generating a Authenticated SID to get the Track MD5
            if (!string.IsNullOrWhiteSpace(ARL))
            {
                webClient.Headers.Add("cookie", "arl=" + ARL);
            }

            string json = await webClient.UploadStringTaskAsync(PrivateConstants.PrivateAPI + "?" + PrivateConstants.method + Methods.UserData + "&"
                                                                  + PrivateConstants.api_version + "&"
                                                                  + PrivateConstants.api_input + "&" + PrivateConstants.api_token + string.Empty + "&"
                                                                  + PrivateConstants.cid + Private.Client.GenCid(), string.Empty);
            webClient.Dispose();
            var data = JsonConvert.DeserializeObject<dynamic>(json);

            // Get Values
            string sid = data.results.SESSION_ID;

            SID = sid;
        }

        public async Task<string> Request(string method, string payload)
        {
            string json = await webClient.UploadStringTaskAsync(MobileConstants.MobileAPI + "?" + MobileConstants.Method + method + "&"
                                                                  + MobileConstants.Input + "&"
                                                                  + MobileConstants.Output + "&" + MobileConstants.APIKey + "&" + MobileConstants.Sid + GetSID(), payload);
            return json;
        }

        public async Task<Metadata> GetTrack(string SongID)
        {
            var res = await Request(Methods.GetTrack, JsonConvert.SerializeObject(new RequestTrack() { TrackID = SongID }));

            Metadata track = new Metadata();

            var data = JsonConvert.DeserializeObject<dynamic>(res);

            track.MD5 = data.results.MD5_ORIGIN;
            track.MediaVersion = data.results.MEDIA_VERSION;
            track.Quality = (int)Quality.FLAC;
            track.id = data.results.SNG_ID;
            track.title = data.results.SNG_TITLE;
            track.artist = data.results.ART_NAME;
            track.duration = data.results.DURATION;
            track.genre = new string[0];
            track.albumart = data.results.ALB_PICTURE;
            track.year = data.results.PHYSICAL_RELEASE_DATE;
            track.album = data.results.ALB_TITLE;
            track.date = data.results.PHYSICAL_RELEASE_DATE;
            track.isrc = data.results.ISRC;

            return track;
        }

        public async Task<List<Metadata>> GetTracks(List<string> SongIDs)
        {
            var res = await Request(Methods.GetTracks, JsonConvert.SerializeObject(new RequestTracks() { TrackIDs = SongIDs }));
            var data = JsonConvert.DeserializeObject<dynamic>(res);
            List<Metadata> mdata = new List<Metadata>();

            foreach(var track in data.results.data)
            {
                Metadata mtrack = new Metadata();
                mtrack.MD5 = track.MD5_ORIGIN;
                mtrack.MediaVersion = track.MEDIA_VERSION;
                mtrack.Quality = (int)Quality.FLAC;
                mtrack.id = track.SNG_ID;
                mtrack.title = track.SNG_TITLE;
                mtrack.artist = track.ART_NAME;
                mtrack.duration = track.DURATION;
                mtrack.genre = new string[0];
                mtrack.albumart = track.ALB_PICTURE;
                mtrack.year = track.PHYSICAL_RELEASE_DATE;
                mtrack.album = track.ALB_TITLE;
                mtrack.date = track.PHYSICAL_RELEASE_DATE;
                mtrack.isrc = track.ISRC;
                mdata.Add(mtrack);
            }

            return mdata;
        }

        public async Task<Lyrics> GetTrackLyrics(string SongID)
        {
            var res = await Request(Methods.GetLyrics, JsonConvert.SerializeObject(new RequestTrack() { TrackID = SongID }));
            return JsonConvert.DeserializeObject<Lyrics>(res);
        }

        public async Task<Album> GetAlbum(string AlbumID)
        {
            var res = await Request(Methods.GetAlbum, JsonConvert.SerializeObject(new RequestAlbum() { AlbumID = AlbumID }));
            return JsonConvert.DeserializeObject<Album>(res);
        }

        public async Task<Playlist> GetPlaylist(string PlaylistID)
        {
            var res = await Request(Methods.GetPlaylist, JsonConvert.SerializeObject(new RequestPlaylist() { PlaylistID = PlaylistID }));
            return JsonConvert.DeserializeObject<Playlist>(res);
        }
    }
}

using DeezerAPI.Mobile.Models;
using DeezerAPI.Mobile.Models.Album;
using DeezerAPI.Mobile.Models.Track;
using DeezerAPI.Private;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Playlist = DeezerAPI.Mobile.Models.Playlist.Playlist;

namespace DeezerAPI.Mobile
{
    public class Client
    {
        private WebClient webClient;
        private string SID;
        private string ARL = string.Empty;

        public Client()
        {
            webClient = new WebClient();
            webClient.Headers.Add("User-Agent", MobileConstants.UserAgent);
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

        public async Task<Track> GetTrack(string SongID)
        {
            var res = await Request(Methods.GetTrack, JsonConvert.SerializeObject(new RequestTrack() { TrackID = SongID }));
            return JsonConvert.DeserializeObject<Track>(res);
        }

        public async Task<Tracks> GetTracks(List<string> SongIDs)
        {
            var res = await Request(Methods.GetTracks, JsonConvert.SerializeObject(new RequestTracks() { TrackIDs = SongIDs }));
            return JsonConvert.DeserializeObject<Tracks>(res);
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

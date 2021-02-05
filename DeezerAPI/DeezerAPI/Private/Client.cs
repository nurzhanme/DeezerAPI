using DeezerAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace DeezerAPI.Private
{
    public class NotInitializedException : Exception
    {
        public NotInitializedException()
        {
        }

        public NotInitializedException(string message)
            : base(message)
        {
        }

        public NotInitializedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    internal class Client
    {
        /// <summary>
        /// Deezer Auth Cookie to lease an API Key
        /// </summary>
        private string arlCookie;

        /// <summary>
        /// Deezer API Key
        /// </summary>
        private string APIKey;

        /// <summary>
        /// Deezer API CSRF Cookie
        /// </summary>
        private string CSRF;

        /// <summary>
        /// Deezer UserID
        /// </summary>
        private string userID;

        internal Client(string arlCookie)
        {
            this.arlCookie = arlCookie;
        }

        /// <summary>
        /// Generate Request CID for a Deezer API Request
        /// </summary>
        /// <returns></returns>
        public static int GenCid()
        {
            Random rnd = new Random();
            return rnd.Next(100000000, 999999999);
        }

        /// <summary>
        /// Prepare WebClient for Deezer Requests
        /// </summary>
        /// <returns></returns>
        private WebClient SetupWebClient()
        {
            WebClient webClient = new WebClient();
            // Prepare WebClient for Requests
            webClient.Headers.Add("User-Agent", PrivateConstants.UserAgent);
            webClient.Headers.Add("cache-control", "no-cache");
            webClient.Headers.Add("accept-language", "en-US,en;q=0.9");
            webClient.Headers.Add("accept-charset", "utf-8,ISO-8859-1;q=0.8,*;q=0.7");
            webClient.Headers.Add("accept", "*/*");
            webClient.Headers.Add("accept-encoding", "deflate");
            webClient.Headers.Add("cookie", "arl=" + arlCookie);
            return webClient;
        }

        /// <summary>
        /// Initializes the Deezer API
        /// </summary>
        /// <returns></returns>
        public async Task InitializeAPIAsync()
        {
            WebClient webClient = SetupWebClient();
            string json = await webClient.UploadStringTaskAsync(PrivateConstants.PrivateAPI + "?" + PrivateConstants.method + Methods.UserData + "&"
                                                                  + PrivateConstants.api_version + "&"
                                                                  + PrivateConstants.api_input + "&" + PrivateConstants.api_token + string.Empty + "&"
                                                                  + PrivateConstants.cid + GenCid(), string.Empty);
            webClient.Dispose();
            var data = JsonConvert.DeserializeObject<dynamic>(json);

            // Get Values
            string userId = data.results.USER.USER_ID;
            string apiKey = data.results.checkForm;
            string sid = data.results.SESSION_ID;

            userID = userId;
            APIKey = apiKey;
            CSRF = sid;
        }

        /// <summary>
        /// Deezer API Request
        /// </summary>
        /// <param name="request">Request Method</param>
        /// <param name="payload">Encoded HTTP POST Payload</param>
        /// <returns></returns>
        private async Task<string> DeezerAPIRequestAsync(string request, string payload = null)
        {
            WebClient webClient = SetupWebClient();
            webClient.Headers.Add("cookie", ";sid=" + CSRF);

            string json = await webClient.UploadStringTaskAsync(PrivateConstants.PrivateAPI + "?" + PrivateConstants.method + request + "&"
                                                                  + PrivateConstants.api_version + "&"
                                                                  + PrivateConstants.api_input + "&" + PrivateConstants.api_token + APIKey ?? string.Empty + "&"
                                                                  + PrivateConstants.cid + GenCid(), payload ?? string.Empty);
            webClient.Dispose();
            return json;
        }

        /*
         * 
         * 
         *  Deezer API Methods 
         * 
         * 
        */

        /// <summary>
        /// Get all Deezer Playlists
        /// </summary>
        /// <returns>Playlists as JSON String</returns>
        public async Task<string> getPlaylists()
        {
            if (APIKey == null)
            {
                throw new NotInitializedException("Deezer API not Initialized");
            }

            // Create JSON Body Playload
            ListPlaylists playlists = new ListPlaylists()
            {
                nb = 40,
                tab = "playlists",
                user_id = userID
            };

            string json = JsonConvert.SerializeObject(playlists, Formatting.None);

            return await DeezerAPIRequestAsync(Methods.Playlists, json);
        }

        /// <summary>
        /// Get all Songs from Deezer Playlist
        /// </summary>
        /// <param name="id">Deezer Playlist ID</param>
        /// <returns>Playlists as JSON String</returns>
        public async Task<string> getPlaylist(string id)
        {
            if (APIKey == null)
            {
                throw new NotInitializedException("Deezer API not Initialized");
            }

            // Create JSON Body Playload
            Playlist playlist = new Playlist()
            {
                header = true,
                lang = "de",
                nb = 40,
                playlist_id = id,
                start = 0,
                tab = 0,
                tags = true
            };

            string json = JsonConvert.SerializeObject(playlist, Formatting.None);

            return await DeezerAPIRequestAsync(Methods.Playlist, json);
        }

        /// <summary>
        /// Get Track Infos from Deezer
        /// </summary>
        public async Task<Metadata> GetTrackInfos(string SNG_ID)
        {
            if (APIKey == null)
            {
                throw new NotInitializedException("Deezer API not Initialized");
            }

            var Track = new Metadata();
            var json = await DeezerAPIRequestAsync(Methods.GetTrack, JsonConvert.SerializeObject(new TrackPayload() { SongID = SNG_ID }));
            var data = JsonConvert.DeserializeObject<dynamic>(json);

            Track.MD5 = data.results.DATA.MD5_ORIGIN;
            Track.MediaVersion = data.results.DATA.MEDIA_VERSION;
            Track.Quality = (int)Quality.FLAC;
            Track.id = data.results.DATA.SNG_ID;
            Track.title = data.results.DATA.SNG_TITLE;
            Track.artist = data.results.DATA.ART_NAME;
            Track.duration = data.results.DATA.DURATION;
            Track.genre = new string[0];
            Track.albumart = data.results.DATA.ALB_PICTURE;
            Track.year = data.results.DATA.PHYSICAL_RELEASE_DATE;
            Track.album = data.results.DATA.ALB_TITLE;
            Track.date = data.results.DATA.PHYSICAL_RELEASE_DATE;
            Track.isrc = data.results.DATA.ISRC;

            Track.artists = new string[data.results.DATA.ARTISTS.Count];
            for (int i = 0; i < data.results.DATA.ARTISTS.Count; i++)
            {
                Track.artists[i] = data.results.DATA.ARTISTS[i].ART_NAME;
            }
            return Track;
        }

        /// <summary>
        /// Get Track Infos from Deezer Album
        /// </summary>
        public async Task<List<Metadata>> GetAlbumInfos(string ALB_ID)
        {
            if (APIKey == null)
            {
                throw new NotInitializedException("Deezer API not Initialized");
            }

            var Tracks = new List<Metadata>();
            var json = await DeezerAPIRequestAsync(Methods.GetAlbum, JsonConvert.SerializeObject(new AlbumPayload() { AlbumID = ALB_ID }));
            var data = JsonConvert.DeserializeObject<dynamic>(json);

            foreach (var dTrack in data.results.SONGS.data)
            {
                Metadata Track = new Metadata();
                Track.MD5 = dTrack.MD5_ORIGIN;
                Track.MediaVersion = dTrack.MEDIA_VERSION;
                Track.Quality = (int)Quality.FLAC;
                Track.id = dTrack.SNG_ID;
                Track.title = dTrack.SNG_TITLE;
                Track.artist = dTrack.ART_NAME;
                Track.duration = dTrack.DURATION;
                Track.genre = new string[0];
                Track.albumart = dTrack.ALB_PICTURE;
                Track.year = data.results.DATA.DIGITAL_RELEASE_DATE;
                Track.year = Track.year.Split('-')[0];
                Track.album = dTrack.ALB_TITLE;
                Track.date = data.results.DATA.DIGITAL_RELEASE_DATE;
                Track.isrc = dTrack.ISRC;

                Track.artists = new string[dTrack.ARTISTS.Count];
                for (int i = 0; i < dTrack.ARTISTS.Count; i++)
                {
                    Track.artists[i] = dTrack.ARTISTS[i].ART_NAME;
                }
                Tracks.Add(Track);
            }
            return Tracks;
        }
    }
}

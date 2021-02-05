using DeezerAPI.Mobile;
using DeezerAPI.Mobile.Models.Album;
using DeezerAPI.Mobile.Models.Lyrics;
using DeezerAPI.Mobile.Models.Playlist;
using DeezerAPI.Mobile.Models.Track;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeezerAPI
{
    /// <summary>
    /// Mobile Deezer API
    /// </summary>
    public interface IUnauthenticatedMobileAPI
    {
        /// <summary>
        /// Generate Unauthenticated Deezer SID
        /// </summary>
        /// <returns></returns>
        public async Task GenerateSID() { }

        /// <summary>
        /// Get Track by ID
        /// </summary>
        /// <param name="SongID">Deezer Track ID</param>
        /// <returns></returns>
        public async Task<Track> GetTrack(string SongID) { return new Track() { }; }

        /// <summary>
        /// Get Tracks by IDs
        /// </summary>
        /// <param name="SongIDs">List of Track IDs</param>
        /// <returns></returns>
        public async Task<Tracks> GetTracks(List<string> SongIDs) { return new Tracks() { }; }

        /// <summary>
        /// Get Track Lyrics by ID
        /// </summary>
        /// <param name="SongID">Track ID</param>
        /// <returns></returns>
        public async Task<Lyrics> GetTrackLyrics(string SongID) { return new Lyrics() { }; }

        /// <summary>
        /// Get Album by ID
        /// </summary>
        /// <param name="AlbumID">Album ID</param>
        /// <returns></returns>
        public async Task<Album> GetAlbum(string AlbumID) { return new Album() { }; }

        /// <summary>
        /// Get Playlist by ID
        /// </summary>
        /// <param name="PlaylistID">Playlist ID</param>
        /// <returns></returns>
        public async Task<Playlist> GetPlaylist(string PlaylistID) { return new Playlist() { }; }
    }

    /// <summary>
    /// Mobile Deezer API
    /// </summary>
    public interface IAuthenticatedMobileAPI
    {

        /// <summary>
        /// Get Track by ID
        /// </summary>
        /// <param name="SongID">Deezer Track ID</param>
        /// <returns></returns>
        public async Task<Track> GetTrack(string SongID) { return new Track() { }; }

        /// <summary>
        /// Get Tracks by IDs
        /// </summary>
        /// <param name="SongIDs">List of Track IDs</param>
        /// <returns></returns>
        public async Task<Tracks> GetTracks(List<string> SongIDs) { return new Tracks() { }; }

        /// <summary>
        /// Get Track Lyrics by ID
        /// </summary>
        /// <param name="SongID">Track ID</param>
        /// <returns></returns>
        public async Task<Lyrics> GetTrackLyrics(string SongID) { return new Lyrics() { }; }

        /// <summary>
        /// Get Album by ID
        /// </summary>
        /// <param name="AlbumID">Album ID</param>
        /// <returns></returns>
        public async Task<Album> GetAlbum(string AlbumID) { return new Album() { }; }

        /// <summary>
        /// Get Playlist by ID
        /// </summary>
        /// <param name="PlaylistID">Playlist ID</param>
        /// <returns></returns>
        public async Task<Playlist> GetPlaylist(string PlaylistID) { return new Playlist() { }; }
    }
}

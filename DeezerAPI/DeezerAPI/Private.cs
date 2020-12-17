using DeezerAPI.Models;
using DeezerAPI.Private;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeezerAPI
{
    /// <summary>
    /// Private Deezer API
    /// </summary>
    public class PrivateAPI
    {
        Client deezer;
        public PrivateAPI(string arlCookie)
        {
            deezer = new Client(arlCookie);
        }

        /// <summary>
        /// Initialize Deezer API
        /// </summary>
        /// <returns></returns>
        public async Task InitializeAPI()
        {
            await deezer.InitializeAPIAsync();
        }

        /// <summary>
        /// Get Album Infos
        /// </summary>
        /// <param name="ALB_ID">Album ID</param>
        /// <returns></returns>
        public async Task<List<Metadata>> GetAlbumInfos(string ALB_ID)
        {
            return await deezer.GetAlbumInfos(ALB_ID);
        }

        /// <summary>
        /// Get Track Infos
        /// </summary>
        /// <param name="SNG_ID">Track ID</param>
        /// <returns></returns>
        public async Task<Metadata> GetTrackInfos(string SNG_ID)
        {
            return await deezer.GetTrackInfos(SNG_ID);
        }
    }
}
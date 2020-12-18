using DeezerAPI.Public;
using System.Threading.Tasks;

namespace DeezerAPI
{
    /// <summary>
    /// Public Deezer API
    /// </summary>
    public class PublicAPI
    {
        Client deezer;

        public PublicAPI()
        {
            deezer = new Client();
        }

        /// <summary>
        /// Query Public Deezer API
        /// </summary>
        /// <param name="query">Query Object</param>
        /// <returns></returns>
        public async Task<string> Search(Query query)
        {
            return await deezer.Search(query);
        }
    }
}

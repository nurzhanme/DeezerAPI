using System;
using System.Net;
using System.Threading.Tasks;

namespace DeezerAPI.Public
{
    internal class Client
    {
        /// <summary>
        /// Execute Deezer Public API Search
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public async Task<string> Search(Query query)
        {
            WebClient web = new WebClient();
            string url = PublicConstants.PublicAPI + query.type
                + new Uri(Options.Track + "\"" + query.track + "\"" + "&" + Options.Artist + "\"" + query.artist + "\"" + "&" + query.order + "&" + query.strict).AbsoluteUri;
            return await web.DownloadStringTaskAsync(url);
        }
    }
}

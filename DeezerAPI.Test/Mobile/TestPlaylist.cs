using DeezerAPI.Mobile.Models.Playlist;
using System.Threading.Tasks;
using Xunit;

namespace DeezerAPI.Test.Mobile
{
    public class TestPlaylist
    {
        DeezerAPI.Mobile.Client client = new DeezerAPI.Mobile.Client();
        public TestPlaylist()
        {
            client.GenerateSID().GetAwaiter().GetResult();
        }

        [Theory]
        [InlineData("5915155024")]
        public async Task PlaylistNotEmpty(string id)
        {
            var res = await client.GetPlaylist(id);
            Assert.NotNull(res);
        }
        [Theory]
        [InlineData("5915154904")]
        [InlineData("5915155364")]
        [InlineData("5915155104")]
        public async Task TestPlaylistType(string id)
        {
            var res = await client.GetPlaylist(id);
            Assert.IsType<Playlist>(res);
        }
    }
}

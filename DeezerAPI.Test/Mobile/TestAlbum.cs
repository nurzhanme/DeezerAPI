using DeezerAPI.Mobile.Models.Album;
using System.Threading.Tasks;
using Xunit;

namespace DeezerAPI.Test.Mobile
{
    public class TestAlbum
    {
        DeezerAPI.Mobile.Client client = new DeezerAPI.Mobile.Client();
        public TestAlbum()
        {
            client.GenerateSID().GetAwaiter().GetResult();
        }

        [Theory]
        [InlineData("72470012")]
        public async Task AlbumNotEmpty(string id)
        {
            var res = await client.GetAlbum(id);
            Assert.NotNull(res);
        }
        [Theory]
        [InlineData("6762898")]
        [InlineData("14713838")]
        [InlineData("183905862")]
        public async Task TestAlbumType(string id)
        {
            var res = await client.GetAlbum(id);
            Assert.IsType<Album>(res);
        }
    }
}

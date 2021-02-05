using DeezerAPI.Mobile.Models.Track;
using System.Threading.Tasks;
using Xunit;

namespace DeezerAPI.Test.Mobile
{
    public class TestTrack
    {
        DeezerAPI.Mobile.Client client = new DeezerAPI.Mobile.Client();
        public TestTrack()
        {
            client.GenerateSID().GetAwaiter().GetResult();
        }

        [Theory]
        [InlineData("551111062")]
        public async Task TrackNotEmpty(string id)
        {
            var res = await client.GetTrack(id);
            Assert.NotNull(res);
        }
        [Theory]
        [InlineData("551111062")]
        [InlineData("69002438")]
        [InlineData("86157497")]
        public async Task TestTrackType(string id)
        {
            var res = await client.GetTrack(id);
            Assert.IsType<Track>(res);
        }
    }
}

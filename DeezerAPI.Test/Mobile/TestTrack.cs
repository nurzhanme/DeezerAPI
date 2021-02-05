using DeezerAPI.Mobile.Models.Track;
using System.Collections.Generic;
using System.Linq;
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

        [Theory]
        [InlineData("551111062", "69002438", "86157497")]
        public async Task TracksNotEmpty(params string[] id)
        {
            var res = await client.GetTracks(id.ToList());
            Assert.NotNull(res);
        }

        [Theory]
        [InlineData("551111062", "69002438", "86157497")]
        public async Task TestTracksType(params string[] id)
        {
            var res = await client.GetTracks(id.ToList());
            Assert.IsType<Tracks>(res);
        }

    }
}

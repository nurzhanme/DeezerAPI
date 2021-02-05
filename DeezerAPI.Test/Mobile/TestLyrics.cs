using DeezerAPI.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DeezerAPI.Test.Mobile
{
    public class TestLyrics
    {
        DeezerAPI.Mobile.Client client = new DeezerAPI.Mobile.Client();
        public TestLyrics()
        {
            client.GenerateSID().GetAwaiter().GetResult();
        }

        [Theory]
        [InlineData("551111062")]
        public async Task TrackNotEmpty(string id)
        {
            var res = await client.GetTrackLyrics(id);
            Assert.NotNull(res);
        }
        [Theory]
        [InlineData("551111062")]
        [InlineData("69002438")]
        [InlineData("86157497")]
        public async Task TestTrackLyricsType(string id)
        {
            var res = await client.GetTrackLyrics(id);
            Assert.IsType<Lyrics>(res);
        }
    }
}

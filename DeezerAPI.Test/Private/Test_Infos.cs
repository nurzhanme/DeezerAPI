using DeezerAPI.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace DeezerAPI.Test.Private
{
    public class Test_Infos
    {
        PrivateAPI deezer;
        public Test_Infos()
        {
            string cred = System.IO.File.ReadAllText(@"..\..\..\creds.txt");
            deezer = new PrivateAPI(cred);
            deezer.InitializeAPI().GetAwaiter().GetResult();
        }

        [Theory]
        [InlineData("14242682")]
        [InlineData("8690169")]
        public void Test_AlbumInfos(string id)
        {
            var data = deezer.GetAlbumInfos(id).GetAwaiter().GetResult();

            Assert.IsType<List<Metadata>>(data);
            Assert.NotEmpty(data);

            foreach(Metadata Track in data)
            {
                Assert.True(!string.IsNullOrEmpty(Track.album));
                Assert.True(!string.IsNullOrEmpty(Track.albumart));
                Assert.True(!string.IsNullOrEmpty(Track.artist));
                Assert.NotEmpty(Track.artists);
                Assert.True(!string.IsNullOrEmpty(Track.date));
                Assert.True(Track.duration != 0);
                Assert.True(!string.IsNullOrEmpty(Track.id));
                Assert.True(!string.IsNullOrEmpty(Track.isrc));
                Assert.True(!string.IsNullOrEmpty(Track.MD5));
                Assert.True(!string.IsNullOrEmpty(Track.MediaVersion));
                Assert.True(Track.Quality != 0);
                Assert.True(!string.IsNullOrEmpty(Track.title));
                Assert.True(!string.IsNullOrEmpty(Track.year));
                Assert.IsType<Uri>(Track.GenerateImageUrl());
            }
        }
    }
}

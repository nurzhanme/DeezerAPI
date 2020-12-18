using DeezerAPI.Public;
using Xunit;
using Type = DeezerAPI.Public.Type;

namespace DeezerAPI.Test.Public
{
    public class Test_Track
    {
        [Fact]
        public void Test_Track_Info()
        {
            PublicAPI deezer = new PublicAPI();
            var data = deezer.Search(new Query("Two Door Cinema Club", "What You Know", Type.Track)).GetAwaiter().GetResult();
            Assert.NotNull(data);
        }
    }
}

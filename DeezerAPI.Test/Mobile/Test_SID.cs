using Xunit;

namespace DeezerAPI.Test.Mobile
{
    public class Test_SID
    {
        [Fact]
        public void GetSID()
        {
            DeezerAPI.Mobile.Client client = new DeezerAPI.Mobile.Client();
            client.GenerateSID().GetAwaiter().GetResult();
            Assert.IsType<string>(client.GetSID());
        }
    }
}

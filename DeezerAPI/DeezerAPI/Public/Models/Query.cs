namespace DeezerAPI.Public
{
    public partial class Query
    {
        public string artist;
        public string track;
        public string? duration;
        public string type;
        public string strict = Strict.off;
        public string order = Order.Ranking;
    }
}

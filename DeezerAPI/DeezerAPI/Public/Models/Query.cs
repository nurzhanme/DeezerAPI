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

        public Query()
        {

        }

        public Query(string artist, string track, string type, string duration = null, string strict = Strict.off, string order = Order.Ranking)
        {
            this.artist = artist;
            this.track = track;
            this.duration = duration;
            this.type = type;
            this.strict = strict;
            this.order = order;
        }
    }
}

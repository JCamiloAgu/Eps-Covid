namespace CitasEps.Models
{
    class OfficialQuote
    {
        private readonly Official official;
        private readonly Quote quote;
        private readonly Media media;

        public OfficialQuote(Quote quote, Official official, Media media)
        {
            this.quote = quote;
            this.official = official;
            this.media = media;
        }

        public Quote GetQuote() => quote;

        public Official GetOfficial() => official;

        public Media GetMedia() => media;
    }
}

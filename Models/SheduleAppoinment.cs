using System;

namespace CitasEps.Models
{
    public class SheduleAppoinment
    {

        private readonly Official official;
        private readonly DateTime dateTime;
        private readonly int? quoteId;

        public SheduleAppoinment(Official official, DateTime dateTime, int? quoteId)
        {
            this.official = official;
            this.dateTime = dateTime;
            this.quoteId = quoteId;
        }

        public Official GetOfficial() => official;
        public DateTime GetDateTime() => dateTime;

        public int? GetQuoteId() => quoteId;

    }
}

using System;

namespace CitasEps.Models
{

    public class SheduleAppoinment
    {

        private Official official;
        private DateTime dateTime;
        private int? quoteId;

        public SheduleAppoinment(Official official, DateTime dateTime, int? quoteId)
        {
            this.official = official;
            this.dateTime = dateTime;
            this.quoteId = quoteId;
        }

        public Official getOfficial()
        {
            return official;
        }

        public DateTime getDateTime()
        {
            return dateTime;
        }

        public int? getQuoteId()
        {
            return quoteId;
        }

        public int shortWithNumberDay()
        {
            return Convert.ToInt32(dateTime.ToString("dd"));
        }
    }
}

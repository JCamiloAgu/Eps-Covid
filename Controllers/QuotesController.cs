using CitasEps.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;


namespace CitasEps.Controllers
{
    class QuotesController : Controller
    {
        public QuotesController() : base("quotes") { }

        public List<Quote> GetAll()
        {
            MySqlDataReader reader = GetAllFromEntity();
            List<Quote> data = FormatQueryResult(reader);
            Close();
            return data;
        }

        public Quote GetById(string value)
        {
            MySqlDataReader reader = GetFromEntity("id", value);
            List<Quote> data = FormatQueryResult(reader);
            Close();
            return data.Count > 0 ? data[0] : null;
        }

        public List<Quote> GetAllByOfficialId(string officialId)
        {
            MySqlDataReader reader = GetFromEntity("id_officials", officialId, 999);
            List<Quote> data = FormatQueryResult(reader);
            Close();
            return data;
        }

        public List<OfficialQuote> GetAllByUser(int idUser)
        {
            string query =
                string
                .Format(
                    "SELECT q.id, q.date_time, q.id_users, q.id_officials, q.id_media, o.name, o.last_name, m.name " +
                    "FROM quotes AS q INNER JOIN officials AS o ON o.id = q.id_officials " +
                    "INNER JOIN media AS m ON m.id = q.id_media WHERE id_users = '{0}';",
                    idUser);

            MySqlDataReader reader = QueryBySqlGet(query);

            List<OfficialQuote> data = FormatOfficialQuoteQueryResult(reader);
            
            Close();
            return data;
        }

        private List<OfficialQuote> FormatOfficialQuoteQueryResult(MySqlDataReader reader)
        {
            List<OfficialQuote> data = new List<OfficialQuote>();

            while (reader.Read())
            {
                int id = int.Parse(reader.GetString(0));
                DateTime date_time = DateTime.Parse(reader.GetString(1));
                int id_users = int.Parse(reader.GetString(2));
                int id_officials = int.Parse(reader.GetString(3));
                int id_media = int.Parse(reader.GetString(4));
                string name = reader.GetString(5).ToString();
                string last_name = reader.GetString(6).ToString();
                string nameMedia = reader.GetString(7).ToString();
                Quote quote = new Quote(id, id_users, id_officials, id_media, date_time);
                Official official = new Official(0, "", name, last_name, "", "", "", true);
                Media media = new Media(id_media, nameMedia);
                data.Add(new OfficialQuote(quote, official, media));
            }
            return data;
        }

        public int CreateQuote(Quote quote)
        {
            string[] attributes = { "id_users:int", "id_officials:int", "id_media:int", "date_time:date" };
            int id = CreateEntity(quote, attributes);
            Close();

            return id;
        }

        public bool UpdateQuoute(Quote quote)
        {
            string[] attributes = { "id_media:int" };
            bool isOk = UpdateEntity(quote, "id", quote.GetAttribute("id").ToString(), attributes);
            Close();
            return isOk;
        }

        public bool DeleteQuote(string scheduleId)
        {
            bool isOk = DeleteEntity("id", scheduleId);
            Close();
            return isOk;
        }

        private List<Quote> FormatQueryResult(MySqlDataReader readerData)
        {
            List<Quote> usersList = new List<Quote>();
            while (readerData.Read())
            {
                int id = int.Parse(readerData.GetString(0));
                DateTime date_time = DateTime.Parse(readerData.GetString(1));
                int id_users = int.Parse(readerData.GetString(2));
                int id_officials = int.Parse(readerData.GetString(3));
                int id_media = int.Parse(readerData.GetString(4));
                usersList.Add(new Quote(id, id_users, id_officials, id_media, date_time));
            }
            return usersList;
        }
    }
}

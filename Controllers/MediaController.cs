using CitasEps.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace CitasEps.Controllers
{
    class MediaController : Controller
    {
        public MediaController() : base("media") { }

        public List<Media> GetAll()
        {
            MySqlDataReader reader = GetAllFromEntity();
            List<Media> data = FormatQueryResult(reader);
            Close();
            return data;
        }

        public List<Media> GetAllByUser(string idUser)
        {
            string query =
                string.Format(
                    "SELECT m.id, m.name FROM users AS u INNER JOIN users_media AS um ON um.id_users = u.id INNER JOIN media AS m ON m.id = um.id_media WHERE u.id = '{0}';",
                    idUser);

            MySqlDataReader reader = QueryBySqlGet(query);
            List<Media> data = FormatQueryResult(reader);
            Close();
            return data;
        }

        private List<Media> FormatQueryResult(MySqlDataReader readerData)
        {
            List<Media> mediaList = new List<Media>();
            while (readerData.Read())
            {
                int id = int.Parse(readerData.GetString(0));
                string name = readerData.GetString(1);
                mediaList.Add(new Media(id, name));
            }
            return mediaList;
        }
    }
}

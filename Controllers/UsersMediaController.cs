using CitasEps.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CitasEps.Controllers
{
    class UsersMediaController : Controller
    {
        public UsersMediaController() : base("users_media") { }

        public List<UsersMedia> GetAll()
        {
            MySqlDataReader reader = GetAllFromEntity();
            List<UsersMedia> data = FormatQueryResult(reader);
            Close();
            return data;
        }

        public UsersMedia GetByAttribute(string attribute, string value)
        {
            MySqlDataReader reader = GetFromEntity(attribute, value);
            List<UsersMedia> data = FormatQueryResult(reader);
            Close();
            return data.Count > 0 ? data[0] : null;
        }

        public int CreateUsersMedia(UsersMedia userMedia)
        {
            string[] attributes = { "id_users:int", "id_media:int" };
            int id = CreateEntity(userMedia, attributes);
            Close();
            return id;
        }

        private List<UsersMedia> FormatQueryResult(MySqlDataReader readerData)
        {
            List<UsersMedia> usersMediaList = new List<UsersMedia>();
            while (readerData.Read())
            {
                int id_users = int.Parse(readerData.GetString(0));
                int id_media = int.Parse(readerData.GetString(1));
                usersMediaList.Add(new UsersMedia(id_users, id_media));
            }
            return usersMediaList;
        }
    }
}

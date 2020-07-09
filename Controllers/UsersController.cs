using CitasEps.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CitasEps.Controllers
{
    class UsersController : Controller
    {
        public UsersController() : base("users") { }

        public List<User> GetAll()
        {
            MySqlDataReader reader = GetAllFromEntity();
            List<User> data = FormatQueryResult(reader);
            Close();
            return data;
        }

        public User GetByAttribute(string attribute, string value)
        {
            MySqlDataReader reader = GetFromEntity(attribute, value);
            List<User> data = FormatQueryResult(reader);
            Close();
            return data.Count > 0 ? data[0] : null;
        }

        public int CreateUser(User user)
        {
            string[] attributes = { "phone:string", "address:string", "email:string", "password:string", "id_affiliates:int" };
            string password = user.GetAttribute("password").ToString();
            user.SetPassword(MD5Hash.Hash.Content(password));
            int id = CreateEntity(user, attributes);
            Close();
            return id;
        }

        public bool UpdateUser(User user)
        {
            string[] attributes = { "phone:string", "address:string", "email:string" };
            bool isOk = UpdateEntity(user, "id", user.GetAttribute("id").ToString(), attributes);
            Close();
            return isOk;
        }


        public bool ChangePassword(User user, int idUser)
        {
            string[] attributes = { "password:string" };
            string password = user.GetAttribute("password").ToString();
            user.SetPassword(MD5Hash.Hash.Content(password));
            bool result = UpdateEntity(user, "id", idUser.ToString(), attributes);
            Close();
            return result;
        }
        private List<User> FormatQueryResult(MySqlDataReader readerData)
        {
            List<User> usersList = new List<User>();
            while (readerData.Read())
            {
                int id = int.Parse(readerData.GetString(0));
                string phone = readerData.GetString(1);
                string address = readerData.GetString(2);
                string email = readerData.GetString(3);
                string password = readerData.GetString(4);
                int id_affiliates = int.Parse(readerData.GetString(5));
                usersList.Add(new User(id, id_affiliates, phone, address, email, password));
            }
            return usersList;
        }
    }
}

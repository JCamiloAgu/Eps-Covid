using CitasEps.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;



namespace CitasEps.Controllers {
	class UsersMediaController : Controller {
		public UsersMediaController(): base("users_media"){}

		// Listar
		public List<User_Media> GetAll() {
			MySqlDataReader reader = GetAllFromEntity();
			List<User_Media> data = UsersMediaListGenerate(reader);
			Close();
			return data;
		}		

		// Obtener por atributo
		public User_Media Get(string attribute, string value) {
			MySqlDataReader reader = GetFromEntity(attribute, value);
			List<User_Media> data = UsersMediaListGenerate(reader);
			Close();
			return data.Count > 0 ? data[0] : null;
		}

		// Crear un nuevo usuario
		public int Create(User_Media userMedia) {
			string[] attributes = { "id_users:int", "id_media:int"};
			int id = CreateEntity(userMedia, attributes);
			Close();
			return id;

			/**EJEMPLOS DE LAS OTRAS CONSULTAS;
			*   bool tmp = UpdateEntity(user, "id", "5", attributes);
			*   bool tmp = DeleteEntity("id", "5");
			*   return tmp;
			**/

		}

		// Formatear listado
		public List<User_Media> UsersMediaListGenerate(MySqlDataReader readerData) {
			List<User_Media> usersMediaList = new List<User_Media>();
			while (readerData.Read()) {
				int id_users = int.Parse(readerData.GetString(0));
				int id_media = int.Parse(readerData.GetString(1));
				usersMediaList.Add(new User_Media(id_users, id_media));
			}
			return usersMediaList;
		}
	}
}

using MySql.Data.MySqlClient;
using System.Collections.Generic;
using CitasEps.Models;
using CitasEps.Services;

namespace CitasEps.Controllers {
	class UsersController : Controller {

		public UsersController() : base("users") { }

		// Listar
		public List<User> GetAll() {
			MySqlDataReader reader = GetAllFromEntity();
			List<User> data = UserListGenerate(reader);
			Close();
			return data;
		}

		// Obtener por atributo
		public User Get(string attribute, string value) {
			MySqlDataReader reader = GetFromEntity(attribute, value);
			List<User> data = UserListGenerate(reader);
			Close();
			return data.Count > 0 ? data[0] : null;
		}

		// Crear un nuevo usuario
		public int Create(User user) {
			string[] attributes = { "phone:string", "address:string", "email:string", "password:string", "id_affiliates:int" };
			string password = user.GetAttribute("password").ToString();
			user.SetPassword(MD5Hash.Hash.Content(password));
			int id = CreateEntity(user, attributes);
			Close();
			return id;


			/**EJEMPLOS DE LAS OTRAS CONSULTAS;
      *   bool tmp = UpdateEntity(user, "id", "5", attributes);
      *   bool tmp = DeleteEntity("id", "5");
      *   return tmp;
      **/

		}

		public bool Update(User user) {
			string[] attributes = { "phone:string", "address:string", "email:string"};
			bool isOk = UpdateEntity(user, "id", user.GetAttribute("id").ToString(), attributes);
			Close();
			return isOk;
		}


		//Cambio de contraseña
		public bool NewPassword(User user, int idUser){
			string[] attributes = {"password:string"};
			string password = user.GetAttribute("password").ToString();
			user.SetPassword(MD5Hash.Hash.Content(password));
			bool result = UpdateEntity(user, "id", idUser.ToString(), attributes);
			Close();
			return result;
		}

		// Formatear listado
		public List<User> UserListGenerate(MySqlDataReader readerData) {
			List<User> usersList = new List<User>();
			while (readerData.Read()) {
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

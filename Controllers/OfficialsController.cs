using CitasEps.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CitasEps.Controllers {
	class OfficialsController : Controller {
		public OfficialsController() : base("officials") { }

		public List<Official> GetAll() {
			MySqlDataReader reader = GetAllFromEntity();
			List<Official> data = OfficialListGenerate(reader);
			Close();
			return data;
		}

		public List<Official> GetAllDoctors() {
			string query = "SELECT * FROM officials WHERE rol = 'medico';";
			MySqlDataReader reader = QueryBySqlGet(query);
			List<Official> data = OfficialListGenerate(reader);
			Close();
			return data;
		}

		

		public Official GetOfficialById(string value) {
			MySqlDataReader reader = GetFromEntity("id", value);
			List<Official> data = OfficialListGenerate(reader);
			Close();
			return data.Count > 0 ? data[0] : null;
		}

		public int CreateOfficial(Official official) {
			string[] attributes =
					 { "id:int", "identification:string", "name:string", "last_name:string", "email:string", "password:string", "rol:string", "status:bool" };

			string pwd = official.GetAttribute("password")?.ToString();
			official.SetPassword(MD5Hash.Hash.Content(pwd));

			int id = CreateEntity(official, attributes);
			Close();

			return id;
		}


		// Obtener por atributo
		public Official Get(string attribute, string value) {
			MySqlDataReader reader = GetFromEntity(attribute, value);
			List<Official> data = OfficialListGenerate(reader);
			Close();
			return data.Count > 0 ? data[0] : null;
		}

		public bool UpdateOfficial(Official official) {
			List<string> attributes = new List<String> { "id:int", "identification:string", "name:string", "last_name:string", "email:string", "rol:string", "status:bool" };

			string id = (official.GetAttribute("id").ToString());
			string pwd = official.GetAttribute("password")?.ToString();

			if (pwd != null) {
				attributes.Add("password:string");
				official.SetPassword(MD5Hash.Hash.Content(pwd));
			}

			bool isSuccessful = UpdateEntity(official, "id", id, attributes.ToArray());
			Close();
			return isSuccessful;
		}

		public bool DeleteOfficial(string officialId) {
			bool isOk = DeleteEntity("id", officialId);
			Close();

			return isOk;
		}

		public List<Official> OfficialListGenerate(MySqlDataReader readerData) {
			List<Official> officialsList = new List<Official>();
			while (readerData.Read()) {
				Console.WriteLine(readerData);

				int id = readerData.GetInt32(0);
				string name = readerData.GetString(1);
				string lastName = readerData.GetString(2);
				string identification = readerData.GetString(3);
				int status = readerData.GetInt32(4);
				string rol = readerData.GetString(5);
				string email = readerData.GetString(6);
				string password = readerData.GetString(7);

				officialsList.
								Add(new Official(id, identification, name, lastName, email, password, rol, (status == 1)));
			}
			return officialsList;
		}
	}
}

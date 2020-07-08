using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasEps.Models;
using MySql.Data.MySqlClient;


namespace CitasEps.Controllers {
	class MediaController: Controller {

		// Usar la herencia para ahorrar el codigo de consulta
		public MediaController(): base("media"){}

		// Listar
		public List<Media> GetAll(){
			MySqlDataReader reader = GetAllFromEntity();
			List<Media> data = MediaListGenerate(reader);
			Close();
			return data;			
		}

		// Listar Join
		public List<Media> GetAllByUser(string idUser) {			
			string query = string.Format("SELECT m.id, m.name FROM users AS u INNER JOIN users_media AS um ON um.id_users = u.id INNER JOIN media AS m ON m.id = um.id_media WHERE u.id = '{0}';", idUser);
			MySqlDataReader reader = QueryBySqlGet(query);
			List<Media> data = MediaListGenerate(reader);
			Close();
			return data;
		}

		// Formatear listado
		public List<Media> MediaListGenerate(MySqlDataReader readerData) {
			List<Media>  mediaList = new List<Media>();
			while (readerData.Read()) {
				int id = int.Parse(readerData.GetString(0));
				string name = readerData.GetString(1);
				mediaList.Add(new Media(id, name));
			}
			return mediaList;
		}
	}
}

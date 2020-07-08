using System.Collections.Generic;
using System.Windows.Forms;
using CitasEps.Models;
using MySql.Data.MySqlClient;

namespace CitasEps.Controllers {
	class EmailConfirCodeController: Controller {


		public EmailConfirCodeController() : base("email_confirm_code") { }

		// Listar
		public List<Email_Confirm_Code> GetAll() {
			MySqlDataReader reader = GetAllFromEntity();
			List<Email_Confirm_Code> data = EmailConfirmCodeListGenerate(reader);
			Close();
			return data;
		}

		// Obtener por atributo
		public Email_Confirm_Code Get(string attribute, string value) {
			MySqlDataReader reader = GetFromEntity(attribute, value);
			List<Email_Confirm_Code> data = EmailConfirmCodeListGenerate(reader);
			Close();
			return data.Count > 0 ? data[0] : null;
		}

		// Crear un nuevo codigo
		public int Create(Email_Confirm_Code emailConfirmCode) {
			string[] attributes = { "code:string", "id_users:int" };
			int id = CreateEntity(emailConfirmCode, attributes);
			Close();
			return id;
		}

		// Confirmar el codigo de email
		public bool Confirm(int idUser, string codeConfirm) {
			string query =  string.Format("UPDATE email_confirm_code SET status = 1 WHERE id_users = '{0}' AND code = '{1}';", idUser, codeConfirm);
			int result = QueryBySqlSet(query);
			Close();
			return result > 0 ? true : false;
		}

		// Editar un codigo
		public bool Update(int idUser,  Email_Confirm_Code emailConfirmCode) {
			string[] attributes = { "code:string", "status:bool" };
			bool result = UpdateEntity(emailConfirmCode, "id_users", idUser.ToString(), attributes);
			Close();
			return result;
		}

		// Formatear listado
		public List<Email_Confirm_Code> EmailConfirmCodeListGenerate(MySqlDataReader readerData) {
			List<Email_Confirm_Code> emailConfirmCodeList = new List<Email_Confirm_Code>();
			while (readerData.Read()) {
				int id = int.Parse(readerData.GetString(0).ToString());
				string code = readerData.GetString(1);
				bool status = readerData.GetString(2).ToString() == "1" ? true : false;
				int id_users = int.Parse(readerData.GetString(3).ToString());
				emailConfirmCodeList.Add(new Email_Confirm_Code(id, id_users, code, status));
			}
			return emailConfirmCodeList;
		}
	}
}

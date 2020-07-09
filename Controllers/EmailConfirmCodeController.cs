using CitasEps.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CitasEps.Controllers
{
    class EmailConfirmCodeController : Controller
    {

        public EmailConfirmCodeController() : base("email_confirm_code") { }

        public int Create(EmailConfirmCode emailConfirmCode)
        {
            string[] attributes = { "code:string", "id_users:int" };
            int id = CreateEntity(emailConfirmCode, attributes);
            Close();
            return id;
        }

        public bool ConfirmEmailCode(int idUser, string codeConfirm)
        {
            string query = string.Format("UPDATE email_confirm_code SET status = 1 WHERE id_users = '{0}' AND code = '{1}';", idUser, codeConfirm);
            int result = QueryBySqlSet(query);
            Close();
            return result > 0;
        }

        public bool Update(int idUser, EmailConfirmCode emailConfirmCode)
        {
            string[] attributes = { "code:string", "status:bool" };
            bool result = UpdateEntity(emailConfirmCode, "id_users", idUser.ToString(), attributes);
            Close();
            return result;
        }

    }
}

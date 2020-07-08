using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasEps.Models {
	class Email_Confirm_Code: IModel {

		private readonly int id;
		private readonly int id_users;
		private readonly string code;
		private readonly bool status;

		public Email_Confirm_Code(int id, int id_users, string code, bool status) {
			this.id = id;
			this.id_users = id_users;
			this.code = code;
			this.status = status;
		}

		public object GetAll() {
			return this;
		}

		public object GetAttribute(string attribute) {
			object attributeReturn = null;
			switch (attribute) {
				case "id":
				attributeReturn = id;
				break;
				case "id_users":
				attributeReturn = id_users;
				break;
				case "code":
				attributeReturn = code;
				break;
				case "status":
				attributeReturn = status;
				break;
			}
			return attributeReturn;
		}
	}
}

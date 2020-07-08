using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasEps.Models {
	class User: IModel {
		private readonly int id;
		private readonly int id_affiliates;
		private readonly string phone;
		private readonly string address;
		private readonly string email;
		private string password;

		public User(int id, int id_affiliates, string phone, string address, string email, string password ) {
			this.id = id;
			this.id_affiliates = id_affiliates;
			this.phone = phone;
			this.address = address;
			this.email = email;
			this.password = password;			
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
				case "id_affiliates":
				attributeReturn = id_affiliates;
				break;
				case "phone":
				attributeReturn = phone;
				break;
				case "address":
				attributeReturn = address;
				break;
				case "email":
				attributeReturn = email;
				break;
				case "password":
				attributeReturn = password;
				break;
			}
			return attributeReturn;
		}


		public void SetPassword(string password){
			this.password = password;
		}
	}
}

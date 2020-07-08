using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasEps.Models {
	class User_Media:IModel {
		private readonly int id_users;
		private readonly int id_media;

		public User_Media(int id_users, int id_media) {
			this.id_users = id_users;
			this.id_media = id_media;
		}

		public object GetAll() {
			return this;
		}

		public object GetAttribute(string attribute) {
			object attributeReturn = null;
			switch (attribute) {
				case "id_media":
				attributeReturn = id_media;
				break;
				case "id_users":
				attributeReturn = id_users;
				break;
			}
			return attributeReturn;
		}
	}
}

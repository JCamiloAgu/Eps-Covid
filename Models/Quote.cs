using System;

namespace CitasEps.Models {
	class Quote : IModel {
		private readonly int id;
		private readonly int id_users;
		private readonly int id_officials;
		private readonly int id_media;
		private readonly DateTime date_time;

		public Quote(int id, int id_users, int id_officials, int id_media, DateTime date_time) {
			this.id = id;
			this.id_users = id_users;
			this.id_officials = id_officials;
			this.date_time = date_time;
			this.id_media = id_media;
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
				case "id_officials":
				attributeReturn = id_officials;
				break;
				case "id_media":
				attributeReturn = id_media;
				break;
				case "date_time":
				attributeReturn = date_time;
				break;
			}
			return attributeReturn;
		}
	}
}

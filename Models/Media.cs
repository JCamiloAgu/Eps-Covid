using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasEps.Models {
	class Media : IModel {
		private readonly int id;
		private readonly string name;

		public Media(int id, string name) {
			this.id = id;
			this.name = name;
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
				case "name":
				attributeReturn = name;
				break;
			}
			return attributeReturn;
		}
	}
}

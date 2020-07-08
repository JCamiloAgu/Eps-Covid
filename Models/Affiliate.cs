using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasEps.Models {
	class Affiliate : IModel {
		private readonly int id;
		private readonly string name;
		private readonly string last_name;
		private readonly string identification;
		private readonly bool status;

		public Affiliate(int id, string name, string last_name, string identification, bool status){
			this.id = id;
			this.name = name;
			this.last_name = last_name;
			this.identification = identification;
			this.status = status;
		}

		public object GetAll(){
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
				case "last_name":
					attributeReturn = last_name;
					break;
				case "identification":
					attributeReturn = identification;
					break;
				case "status":
					attributeReturn = status;
					break;
			}
			return attributeReturn;
		}
	}
}

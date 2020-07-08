using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasEps.Models {
	interface IModel {
		public object GetAll();
		public object GetAttribute(string attribute);
	}
}

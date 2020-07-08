using CitasEps.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CitasEps.Controllers {
	class AffiliatesController : Controller {

		public AffiliatesController() : base("affiliates") { }

		public List<Affiliate> GetAll() {
			MySqlDataReader reader = GetAllFromEntity();
			List<Affiliate> data = AffiliateListGenerate(reader);
			Close();
			return data;
		}

		public Affiliate Get(string attribute, string value) {
			MySqlDataReader reader = GetFromEntity(attribute, value);
			List<Affiliate> data = AffiliateListGenerate(reader);
			Close();
			return data.Count > 0 ? data[0] : null;
		}

		public int CreateAffiliate(Affiliate affiliate) {
			string[] attributes = { "name:string", "last_name:string", "identification:string", "status:boolean" };

			int id = CreateEntity(affiliate, attributes);
			Close();

			return id;
		}

		public bool UpdateAffiliate(Affiliate affiliate) {
			string[] attributes = { "name:string", "last_name:string", "identification:string", "status:bool" };

			bool isOk = UpdateEntity(affiliate, "id", affiliate.GetAttribute("id").ToString(), attributes);
			Close();

			return isOk;
		}

		public bool DeleteAffiliate(string affiliateId) {
			bool isOk = DeleteEntity("id", affiliateId);
			Close();

			return isOk;
		}

		// Formatear consulta
		public List<Affiliate> AffiliateListGenerate(MySqlDataReader readerData) {
			List<Affiliate> affiliateList = new List<Affiliate>();
			while (readerData.Read()) {
				int id = int.Parse(readerData.GetString(0));
				string name = readerData.GetString(1);
				string last_name = readerData.GetString(2);
				string identification = readerData.GetString(3);
				bool status = readerData.GetString(4) == "1";
				affiliateList.Add(new Affiliate(id, name, last_name, identification, status));
			}
			return affiliateList;
		}
	}
}


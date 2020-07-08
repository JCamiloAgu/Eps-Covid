using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasEps.Models {
	class OfficialQuote {
		private Official official;
		private Quote quote;
		private Media media;

		public OfficialQuote(Quote quote, Official official, Media media) {
			this.quote = quote;
			this.official = official;
			this.media = media;
		}

		public Quote GetQuote(){
			return quote;
		}

		public Official GetOfficial() {
			return official;
		}

		public Media GetMedia() {
			return media;
		}
	}
}

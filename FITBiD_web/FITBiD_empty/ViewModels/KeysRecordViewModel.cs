using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.ViewModels {
	public class KeysRecordViewModel {
		public class KeyRecordInfo{

			public int Id { get; set; }
			public string NazivUcionice { get; set; }
			public string NastavnoOsoblje { get; set; }
			public string BarKodKljuca { get; set; }
			public DateTime DatumPreuzimanja { get; set; }
			public DateTime? DatumVracanja { get; set;}

		}
		public List<KeyRecordInfo> listaEvidencijaKljuceva { get; set; }
	}
}
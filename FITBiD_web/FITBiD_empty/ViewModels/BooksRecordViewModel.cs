using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.ViewModels {
	public class BooksRecordViewModel {

		public class BooksRecordInfo {
			public int Id { get; set; }
			public string NazivKnjige { get; set; }
			public string Autor { get; set; }
			public DateTime DatumIzdavanja { get; set; }
			public DateTime? DatumVracanja { get; set; }
			public string Student { get; set; }
			public bool Vracena { get; set; }
		}

		public List<BooksRecordInfo> listaEvidencijaKnjigaZaIznajmljivanje { get; set; }
	}
}
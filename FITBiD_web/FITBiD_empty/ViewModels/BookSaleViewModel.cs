using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.ViewModels {
	public class BookSaleViewModel {
		public class BooksSaleInfo {
			public int Id { get; set; }
			public DateTime DatumEvidencije { get; set; }
			public string NazivKnjge { get; set; }
			public string Radnik { get; set; }
            public double Cijena { get; set; }
		}
		public List<BooksSaleInfo> listaEvidencijaKnjigaZaProdaju { get; set; }

	}
}
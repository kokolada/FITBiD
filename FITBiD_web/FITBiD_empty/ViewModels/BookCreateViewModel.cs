using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FITBiD_empty.Models;
using System.Web.Mvc;

namespace FITBiD_empty.ViewModels {
	public class BookCreateViewModel {

			public string Naziv { get; set; }
			public DateTime GodinaObjavljivanja { get; set; }
			public string Autor { get; set; }
			public string BarCode { get; set; }
			public string OznakaStalaze { get; set; }
			public bool ZaProdaju { get; set; }
			public float Cijena { get; set; }

			public int KategorijaId { get; set; }
			public List<KategorijaKnjige> ListaKategorija { get; set; }

	}
}
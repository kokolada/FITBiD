using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class KategorijaKnjige
	{
		public int Id { get; set; }
		public string Naziv { get; set; }

		public List<KnjigaKategorija> KnjigaKategorijas { get; set; }
	}
}
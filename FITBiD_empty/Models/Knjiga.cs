using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class Knjiga
	{
		public int Id { get; set; }
		public string Naziv { get; set; }
		public DateTime GodinaObjavljivanja { get; set; }
		public string Autor { get; set; }
		public string Barcode { get; set; }
		public string OznakaStalaze { get; set; }
		public bool ZaProdaju { get; set; }
		public double Cijena { get; set; }

		public List<KnjigaKategorija> KnjigaKategorijas { get; set; }
	}
}
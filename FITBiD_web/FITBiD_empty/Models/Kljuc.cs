using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class Kljuc
	{
		public int Id { get; set; }
		public string Barcode { get; set; }

		public Ucionica Ucionica { get; set; }
		public int UcionicaId { get; set; }
	}
}
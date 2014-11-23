using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class EvidencijaKljuceva
	{
		public int Id { get; set; }
		public DateTime DatumPreuzimanja { get; set; }
		public DateTime DatumVracanja { get; set; }

		public NastavnoOsoblje NastavnoOsoblje { get; set; }
		public int NastavnoOsobljeId { get; set; }

		public Kljuc Kljuc { get; set; }
		public int KljucId { get; set; }

		public Radnik Radnik { get; set; }
		public int RadnikId { get; set; }
	}
}
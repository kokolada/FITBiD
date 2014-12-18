using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class EvidencijaIzvjestaja
	{
		public int Id { get; set; }
		public DateTime DatumEvidencije { get; set; }

		public Menadzment Menadzment { get; set; }
		public int MenadzmentId { get; set; }

		public Izvjestaj Izvjestaj { get; set; }
		public int IzvjestajId { get; set; }
	}
}
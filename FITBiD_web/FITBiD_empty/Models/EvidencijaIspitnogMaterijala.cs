using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class EvidencijaIspitnogMaterijala
	{
		public int Id { get; set; }
		public DateTime DatumIzdavanjaMaterijala { get; set; }

		public IspitniMaterijal IspitniMaterijal { get; set; }
		public int IspitniMaterijalId { get; set; }

		public Radnik Radnik { get; set; }
		public int RadnikId { get; set; }
	}
}
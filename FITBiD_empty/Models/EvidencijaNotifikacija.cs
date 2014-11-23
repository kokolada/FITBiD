using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class EvidencijaNotifikacija
	{
		public int Id { get; set; }
		public DateTime DatumNotifikacije { get; set; }

		public Notifikacija Notifikacija { get; set; }
		public int NotifikacijaId { get; set; }

		public Radnik Radnik { get; set; }
		public int RadnikId { get; set; }

		public PredlozakMaila PredlozakMaila { get; set; }
		public int PredlozakMailaId { get; set; }
	}
}
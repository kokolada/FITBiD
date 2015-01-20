using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class EvidencijaKnjigaZaProdaju
	{
		public int Id { get; set; }
		[Column(TypeName = "DateTime2")]
		public DateTime DatumEvidencije { get; set; }

		public Knjiga Knjiga { get; set; }
		public int KnjigaId { get; set; }

		public Radnik Radnik { get; set; }
		public int RadnikId { get; set; }
	}
}
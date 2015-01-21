using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class EvidencijaKnjigaZaIznajmljivanje
	{
		public int Id { get; set; }
		[Column(TypeName = "DateTime2")]
		public DateTime DatumIzdavanja { get; set; }
		[Column(TypeName = "DateTime2")]
		public DateTime DatumVracanja { get; set; }

		public Knjiga Knjiga { get; set; }
		public int KnjigaId { get; set; }

		public Radnik Radnik { get; set; }
		public int RadnikId { get; set; }

		public Student Student { get; set; }
		public int StudentId { get; set; }

		public bool Vracena { get; set; }
	}
}
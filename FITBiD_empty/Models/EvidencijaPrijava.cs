using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class EvidencijaPrijava
	{
		public int Id { get; set; }
		public int Kolicina { get; set; }

		public Student Student { get; set; }
		public int StudentId { get; set; }

		public Radnik Radnik { get; set; }
		public int RadnikId { get; set; }
	}
}
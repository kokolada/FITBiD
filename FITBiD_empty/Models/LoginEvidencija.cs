using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class LoginEvidencija
	{
		public int Id { get; set; }
		public DateTime DatumLogina { get; set; }

		public Radnik Radnik { get; set; }
		public int RadnikId { get; set; }

		public Student Student { get; set; }
		public int StudentId { get; set; }

		public Menadzment Menadzment { get; set; }
		public int MenadzmentId { get; set; }
	}
}
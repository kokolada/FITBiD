using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class Komentar
	{
		public int Id { get; set; }
		public string Sadrzaj { get; set; }

		public Student Student { get; set; }
		public int StudentId { get; set; }

		public Objava Objava { get; set; }
		public int ObjavaId { get; set; }
	}
}
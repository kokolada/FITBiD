using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string BrojIndeksa { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string Email { get; set; }
		public string Kontakt { get; set; }
		public string Password { get; set; }

		public List<Komentar> Komentars { get; set; }
	}
}
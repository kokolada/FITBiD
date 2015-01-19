using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.ViewModels
{
	public class Korisnik
	{
		public int Id { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string username { get; set; }
		public string password { get; set; }
		public string rola { get; set; }
	}
}
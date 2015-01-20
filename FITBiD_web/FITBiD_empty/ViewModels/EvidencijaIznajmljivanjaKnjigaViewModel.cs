using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.ViewModels
{
	public class EvidencijaIznajmljivanjaKnjigaViewModel
	{
		public List<Knjiga> Knjige { get; set; }
		public List<Student> Studenti { get; set; }
	}
}
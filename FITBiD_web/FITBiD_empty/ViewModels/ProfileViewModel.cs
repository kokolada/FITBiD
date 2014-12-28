using System;
using System.Collections.Generic;
using System.Linq;
using FITBiD_empty.Models;

namespace FITBiD_empty.ViewModels
{
	public class ProfileViewModel
	{
		public string  brojIndeksa { get; set; }
		public string ime { get; set; }
		public string prezime { get; set; }
		public string email { get; set; }
		public string kontakt { get; set; }
		public string password { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class Rezervacija
	{
		public int Id { get; set; }
		public DateTime DatumRezervacije { get; set; }
		public bool RezervacijaPotvrdjena { get; set; }

		public Knjiga Knjiga { get; set; }
		public int KnjigaId { get; set; }

		public Student Student { get; set; }
		public int StudentId { get; set; }
	}
}
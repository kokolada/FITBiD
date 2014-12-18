using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.Models
{
	public class KnjigaKategorija
	{
		public Knjiga Knjiga { get; set; }
		public int KnjigaId { get; set; }

		public KategorijaKnjige KategorijaKnjige { get; set; }
		public int KategorijaKnjigeId { get; set; }

		public List<Knjiga> Knjigas { get; set; }
		public List<KategorijaKnjige> KategorijaKnjiges { get; set; }
	}
}
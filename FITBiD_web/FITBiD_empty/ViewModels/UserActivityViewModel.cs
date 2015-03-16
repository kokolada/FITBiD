using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FITBiD_empty.Models;

namespace FITBiD_empty.ViewModels {
	public class UserActivityViewModel {


		public Student praceniStudent { get; set; }
		public List<Student> listaStudenata { get; set; }
		public List<Rezervacija> rezervisaneKnjige { get; set; }
		public List<Objava> objave { get; set; }
		public List<KategorijaObjave> kategorijaObjave { get; set; }
		public List<EvidencijaKnjigaZaIznajmljivanje> iznajmljeneKnjige { get; set; }
		public List<EvidencijaPrijava> prijave { get; set; }

	

	}
}
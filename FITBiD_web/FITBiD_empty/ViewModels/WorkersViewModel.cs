using System;
using System.Collections.Generic;
using System.Linq;
using FITBiD_empty.Models;
using System.Web.Mvc;

namespace FITBiD_empty.ViewModels {

	public class WorkersViewModel {
		//Evidencija ključeva
		//Evidencija ispitnog materijala
		//Evidencija narudzbe ispitnog materijala
		//Evidencija knjiga za prodaju
		//Evidencija knjiga za izdavanje
		//Evidencija notifikacija

		//public List<SelectListItem> Kljucevi { get; set; }
		//public List<EvidencijaIspitnogMaterijala> IspitniMaterijal { get; set; }
		//public List<EvidencijaNarudzbeIspitnogMaterijala> NarudzbeIspitnogMaterijala { get; set; }
		//public List<EvidencijaKnjigaZaProdaju> KnjigeZaProdaju { get; set; }
		//public List<EvidencijaKnjigaZaIznajmljivanje> KnjigeZaIznajmljivanje { get; set; }
		//public List<SelectListItem> Notifikacije { get; set; }
		public class EvidencijaKljucevaInfo {

			public string NazivUcionice { get; set; }
			public string NastavnoOsoblje { get; set; }
			public string BarKodKljuca { get; set; }

		}
		public List<EvidencijaKljucevaInfo> eki { get; set; }
	}
}
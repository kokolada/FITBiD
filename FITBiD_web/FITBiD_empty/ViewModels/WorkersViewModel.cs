using System;
using System.Collections.Generic;
using System.Linq;
using FITBiD_empty.Models;
using System.Web.Mvc;

namespace FITBiD_empty.ViewModels {

	public class WorkersViewModel {

		public class EvidencijaKljucevaInfo {
			public int Id { get; set; }
			public string NazivUcionice { get; set; }
			public string NastavnoOsoblje { get; set; }
			public string BarKodKljuca { get; set; }
			public DateTime DatumPreuzimanja { get; set; }
			public DateTime? DatumVracanja { get; set;}
		}

		public class EvidencijaKnjigaZaIznajmljivanjeInfo {
			public int Id { get; set; }
			public string NazivKnjige { get; set; }
			public string Autor { get; set; }
			public DateTime DatumIzdavanja { get; set; }
			public DateTime DatumVracanja { get; set; }
			public string Student { get; set; }
			public bool Vracena { get; set; }
		}

		public class EvidencijaKnjigaZaProdajuInfo {
			public DateTime DatumEvidencije { get; set; }
			public string NazivKnjge { get; set; }
			public string Autor { get; set; }
            public double Cijena { get; set; }
		}

		public class EvidencijaNarudzbeIspitnogMaterijalaInfo {
			public string NazivMaterijala { get; set; }
			public int Kolicina { get; set; }
			public DateTime DatumNarudzbe { get; set; }
		}

        public class RezervacijeKnjigaInfo
        {
            public int Id { get; set; }
            public int knjigaId { get; set; }
            public int studentId { get; set; }
            public string BrojIndexa { get; set; }
            public string Naziv { get; set; }
            public bool Status { get; set; }
            public DateTime DatumRezervacije { get; set; }
        }

		public List<EvidencijaKljucevaInfo> listaEvidencijaKljuceva { get; set; }
		public List<EvidencijaKnjigaZaIznajmljivanjeInfo> listaEvidencijaKnjigaZaIznajmljivanje { get; set; }
		public List<EvidencijaKnjigaZaProdajuInfo> listaEvidencijaKnjigaZaProdaju { get; set; }
		public List<EvidencijaNarudzbeIspitnogMaterijalaInfo> listaEvidencijaMaterijala { get; set; }
        public List<RezervacijeKnjigaInfo> listaRezervisanihKnjiga { get; set; }

	}
}
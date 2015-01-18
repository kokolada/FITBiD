using System;
using System.Collections.Generic;
using System.Linq;
using FITBiD_empty.Models;
using System.Web.Mvc;

namespace FITBiD_empty.ViewModels {

	public class WorkersViewModel {

		public class EvidencijaKljucevaInfo {

			public string NazivUcionice { get; set; }
			public string NastavnoOsoblje { get; set; }
			public string BarKodKljuca { get; set; }
			public DateTime DatumPreuzimanja { get; set; }
			public DateTime? DatumVracanja { get; set;}

		}
		public List<EvidencijaKljucevaInfo> eki { get; set; }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.ViewModels {
	public class EntryRecordViewModel {

		public class EvidencijaInfo {
			public int Id { get; set; }
			public int studentId { get; set; }
			public string studentIme { get; set; }
			public string studentPrezime { get; set; }
			public int kolicina { get; set; }
			public int radnikId { get; set; }
			public string radnikIme { get; set; }
			public string radnikPrezime { get; set; }
			public string brojIndeksa { get; set; }
		}

		public List<EvidencijaInfo> listaEvidencija { get; set; }

	}
}
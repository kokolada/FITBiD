using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.ViewModels {
	public class KeysRecordCreateViewModel {
		public DateTime DatumPreuzimanja { get; set; }
		public List<Kljuc> ListaKljuceva { get; set; }
		public List<NastavnoOsoblje> ListaOsoblja { get; set; }
	}
}
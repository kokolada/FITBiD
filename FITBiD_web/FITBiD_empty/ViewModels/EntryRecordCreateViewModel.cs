using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FITBiD_empty.Models;
using System.Web.Mvc;

namespace FITBiD_empty.ViewModels {
	public class EntryRecordCreateViewModel {

		public int kolicina { get; set; }
		public int studentId { get; set; }
		public string brojIndeksa { get; set; }
		public int radnikId { get; set; }

		public List<Student> listaStudenata { get; set;}
	}
}
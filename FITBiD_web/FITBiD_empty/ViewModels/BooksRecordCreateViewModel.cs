using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FITBiD_empty.ViewModels {
	public class BooksRecordCreateViewModel {
		public DateTime DatumVracanja { get; set; }
		public List<Knjiga> Knjige { get; set; }
		public List<Student> Studenti { get; set; }
	}
}
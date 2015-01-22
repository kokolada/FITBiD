using System;
using System.Collections.Generic;
using System.Linq;
using FITBiD_empty.Models;
using System.Web.Mvc;

namespace FITBiD_empty.ViewModels
{
	public class BooksReservationCreateViewModel
	{
        
			public int Id { get; set; }
            public DateTime DatumRezervacije { get; set; }
            public bool RezervacijaPotvrdjena { get; set; }

			public int KnjigaId { get; set; }
            public List<SelectListItem> ListaKnjiga { get; set; }

            public int StudentId { get; set; }
            public List<SelectListItem> ListaStudenata { get; set; }
        

    }
}
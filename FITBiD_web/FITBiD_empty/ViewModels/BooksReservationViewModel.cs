using System;
using System.Collections.Generic;
using System.Linq;
using FITBiD_empty.Models;

namespace FITBiD_empty.ViewModels
{
	public class BooksReservationViewModel
	{
        public class RezervacijaInfo
        {
			public int Id { get; set; }
            public DateTime DatumRezervacije { get; set; }
            public bool RezervacijaPotvrdjena { get; set; }


            public string NazivKnjige { get; set; }
            public string StudentIme { get; set; }
        }

        public List<RezervacijaInfo> rezervacije { get; set; }


    }
}
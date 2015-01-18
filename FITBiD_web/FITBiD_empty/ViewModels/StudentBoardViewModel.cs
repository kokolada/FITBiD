using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.ViewModels
{
    public class StudentBoardViewModel
    {
        public int Id { get; set; }
        public string BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Kontakt { get; set; }

        public int KnjigaReservedId { get; set; }
        public List<SelectListItem> ListaRezervisanihKnjiga { get; set; }

        public int KnjigaIznajmljenaId { get; set; }
        public List<SelectListItem> ListaIznajmljenihKnjiga { get; set; }

        public int KnjigaKupljenihId { get; set; }
        public List<SelectListItem> ListaKupljenihKnjiga { get; set; }

        public int ObjavaId { get; set; }
        public List<SelectListItem> ListaObjava { get; set; }

        public int NotifikacijaId { get; set; }
        public List<SelectListItem> ListaNotifikacije { get; set; }



        


    }
}
using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.ViewModels
{
    public class StudentBoardViewModel
    {

        public List<Rezervacija> rezervisaneKnjige { get; set; }

        public List<EvidencijaKnjigaZaIznajmljivanje> iznajmljeneKnjige { get; set; }

        public List<Objava> objave { get; set; }  


    }
}
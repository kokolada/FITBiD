using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FITBiD_empty.Models;

namespace FITBiD_empty.ViewModels
{
    public class PitanjeOdogovorViewModel
    {
        public Objava objava { get; set; }
        public List<Komentar> Komentari { get; set; }
    }
}
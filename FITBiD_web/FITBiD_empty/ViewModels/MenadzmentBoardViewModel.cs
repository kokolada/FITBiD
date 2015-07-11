using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.ViewModels
{
	public class MenadzmentBoardViewModel
    {
        
        public List<Student> aktivniStudenti { get; set; }
		public List<Radnik> aktivniRadnici { get; set;}
		public List<LoginEvidencija> evidencijaLogina { get; set;}

		//public List<EvidencijaKnjigaZaIznajmljivanje> iznajmljeneKnjige { get; set; }
		//[StringLength(100,MinimumLength=1,ErrorMessage="Poruka mora biti najmanje 1 karaketer")]
		//public List<Objava> objave { get; set; }

		//public List<KategorijaObjave> kategorijeObjave { get; set; }


    }
}
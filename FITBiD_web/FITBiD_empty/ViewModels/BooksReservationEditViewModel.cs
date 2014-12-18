using System;
using System.Collections.Generic;
using System.Linq;
using FITBiD_empty.Models;
using System.Web.Mvc;

namespace FITBiD_empty.ViewModels
{
	public class BooksReservationEditViewModel
	{

		public int Id { get; set; }
		public int KnjigaId { get; set; }

		public List<SelectListItem> ListaKnjiga { get; set; }
    }
}
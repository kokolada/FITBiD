﻿using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
    public class BookRecordController : Controller
    {
        MojContext ctx = new MojContext();
        // GET: BookRecord
        public ActionResult Index()
        {
            List<EvidencijaKnjigaZaIznajmljivanje> Model = ctx.EvidencijaKnjigaZaIznajmljivanje.ToList();
            return View(Model);
        }

        // GET: BookRecord/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookRecord/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookRecord/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookRecord/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookRecord/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookRecord/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookRecord/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

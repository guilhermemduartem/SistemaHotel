﻿using Guilherme.Hotel.Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Guilherme.Hotel.Project.Controllers {

    public class PessoasController : Controller {

        // GET: Pessoas
        public ActionResult Index() { 

            var pessoa = new List<Pessoas>();
            return View(pessoa);
        }

        // GET: Pessoas/Details/5
        public ActionResult Details(int id) {

            return View();
        }

        // GET: Pessoas/Create
        public ActionResult Create() {

            return View();
        }

        // POST: Pessoas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection) {
            try {

                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }

        // GET: Pessoas/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: Pessoas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection) {
            try {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }

        // GET: Pessoas/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: Pessoas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) {
            try {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }
    }
}

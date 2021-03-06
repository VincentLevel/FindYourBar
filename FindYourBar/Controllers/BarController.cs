﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FindYourBar.Data;

namespace FindYourBar.Controllers
{
    public class BarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BarController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Bar
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bar/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Bar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bar/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Bar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bar/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
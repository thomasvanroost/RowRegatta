using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RowRegattaTracker.Models;

namespace RowRegatta.Models
{
    public class EventController : Controller
    {
        private RowRegattaTrackerDbContext db = new RowRegattaTrackerDbContext();

        //
        // GET: /Event/

        public ActionResult Index()
        {
            return View(db.Events.ToList());
        }

        //
        // GET: /Event/Details/5

        public ActionResult Details(int id = 0)
        {
            Event events = db.Events.Find(id);
            if (events == null)
            {
                return HttpNotFound();
            }
            return View(events);
        }

        //
        // GET: /Event/Create
        [Authorize(Roles="Admin")]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Event/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Event events)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(events);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(events);
        }

        //
        // GET: /Event/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id = 0)
        {
            Event events = db.Events.Find(id);
            if (events == null)
            {
                return HttpNotFound();
            }
            return View(events);
        }

        //
        // POST: /Event/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Event events)
        {
            if (ModelState.IsValid)
            {
                db.Entry(events).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(events);
        }

        //
        // GET: /Event/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id = 0)
        {
            Event events = db.Events.Find(id);
            if (events == null)
            {
                return HttpNotFound();
            }
            return View(events);
        }

        //
        // POST: /Event/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event events = db.Events.Find(id);
            db.Events.Remove(events);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
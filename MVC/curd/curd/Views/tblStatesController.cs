using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using curd.Controllers;

namespace curd.Views
{
    public class tblStatesController : Controller
    {
        private Model1 db = new Model1();

        // GET: tblStates
        public ActionResult Index()
        {
            return View(db.tblStates.ToList());
        }

        // GET: tblStates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblState tblState = db.tblStates.Find(id);
            if (tblState == null)
            {
                return HttpNotFound();
            }
            return View(tblState);
        }

        // GET: tblStates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblStates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "stateid,statename")] tblState tblState)
        {
            if (ModelState.IsValid)
            {
                db.tblStates.Add(tblState);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblState);
        }

        // GET: tblStates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblState tblState = db.tblStates.Find(id);
            if (tblState == null)
            {
                return HttpNotFound();
            }
            return View(tblState);
        }

        // POST: tblStates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "stateid,statename")] tblState tblState)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblState).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblState);
        }

        // GET: tblStates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblState tblState = db.tblStates.Find(id);
            if (tblState == null)
            {
                return HttpNotFound();
            }
            return View(tblState);
        }

        // POST: tblStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblState tblState = db.tblStates.Find(id);
            db.tblStates.Remove(tblState);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

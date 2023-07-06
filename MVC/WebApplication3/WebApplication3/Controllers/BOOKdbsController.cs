using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class BOOKdbsController : Controller
    {
        private LibraryDBEntities db = new LibraryDBEntities();

        // GET: BOOKdbs
        public ActionResult Index()
        {
            return View(db.BOOKdbs.ToList());
        }

        // GET: BOOKdbs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOOKdb bOOKdb = db.BOOKdbs.Find(id);
            if (bOOKdb == null)
            {
                return HttpNotFound();
            }
            return View(bOOKdb);
        }

        // GET: BOOKdbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BOOKdbs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price")] BOOKdb bOOKdb)
        {
            if (ModelState.IsValid)
            {
                db.BOOKdbs.Add(bOOKdb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bOOKdb);
        }

        // GET: BOOKdbs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOOKdb bOOKdb = db.BOOKdbs.Find(id);
            if (bOOKdb == null)
            {
                return HttpNotFound();
            }
            return View(bOOKdb);
        }

        // POST: BOOKdbs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price")] BOOKdb bOOKdb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bOOKdb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bOOKdb);
        }

        // GET: BOOKdbs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOOKdb bOOKdb = db.BOOKdbs.Find(id);
            if (bOOKdb == null)
            {
                return HttpNotFound();
            }
            return View(bOOKdb);
        }

        // POST: BOOKdbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BOOKdb bOOKdb = db.BOOKdbs.Find(id);
            db.BOOKdbs.Remove(bOOKdb);
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

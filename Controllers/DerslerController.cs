using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class DerslerController : Controller
    {
        private DeneEntities db = new DeneEntities();

        // GET: Dersler
        public ActionResult Index()
        {
            return View(db.Derslers.ToList());
        }

        // GET: Dersler/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dersler dersler = db.Derslers.Find(id);
            if (dersler == null)
            {
                return HttpNotFound();
            }
            return View(dersler);
        }

        // GET: Dersler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dersler/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DersID,DersAd,DersAkts,DersSaat")] Dersler dersler)
        {
            if (ModelState.IsValid)
            {
                db.Derslers.Add(dersler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dersler);
        }

        // GET: Dersler/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dersler dersler = db.Derslers.Find(id);
            if (dersler == null)
            {
                return HttpNotFound();
            }
            return View(dersler);
        }

        // POST: Dersler/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DersID,DersAd,DersAkts,DersSaat")] Dersler dersler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dersler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dersler);
        }

        // GET: Dersler/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dersler dersler = db.Derslers.Find(id);
            if (dersler == null)
            {
                return HttpNotFound();
            }
            return View(dersler);
        }

        // POST: Dersler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dersler dersler = db.Derslers.Find(id);
            db.Derslers.Remove(dersler);
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

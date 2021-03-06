﻿using PersonelMVC.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PersonelMVC.Models.ViewModels;

namespace PersonelMVC.Controllers
{
    public class PersonelController : Controller
    {
        PersonelDbEntities db = new PersonelDbEntities();


        // GET: Personel
        public ActionResult Index()
        {
            var model = db.Personel.Include(x => x.Departman).ToList();
            return View(model);

        }

        public ActionResult Yeni()
        {
            var model = new PersonelFormViewModel()
            {
                departmanlar = db.Departman.ToList()
            };
            return View("PersonelForm");

        }
        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(Personel personel)
        {
            if (personel.Id==0)

            {
                db.Personel.Add(personel);
            }
            else
            {
                db.Entry(personel).State = System.Data.Entity.EntityState.Modified;


            }
            return RedirectToAction("Index");

        }

        public ActionResult Guncelle(int id)

        {
            var model = new PersonelFormViewModel()
            {
                departmanlar =db.Departman.ToList(),
                Personel=db.Personel.Find(id)
            };
            return View("PersonelForm", model);
        }

        public ActionResult Sil(int id)
        {
            var silinecekPersonel = db.Personel.Find(id);
            if (silinecekPersonel==null)
            {
                return HttpNotFound();
            }
            db.Personel.Remove(silinecekPersonel);
            db.SaveChanges();

            return RedirectToAction("Index");
        }







    }
}
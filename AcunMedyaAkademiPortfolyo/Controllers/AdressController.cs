using AcunMedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class AdressController : Controller
    {
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();
        public ActionResult Index()
        {
            var values = db.Adress.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAdress()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAdress(Adress p)
        {
            db.Adress.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAdress(int id)
        {
            var value = db.Adress.Find(id);
            db.Adress.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAdress(int id)
        {
            var value = db.Adress.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAdress(Adress p)
        {
            var value = db.Adress.Find(p.AdressId);
            value.Adres = p.Adres;
            value.Phone = p.Phone;
            value.Email = p.Email;
            value.Website = p.Website;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
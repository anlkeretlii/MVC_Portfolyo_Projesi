using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class ServiceController : Controller
    {
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();
        // GET: Service
        public ActionResult Index()
        {
            var values = db.Service.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateService(Service p)
        {
            db.Service.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteService(int id)
        {
            var value = db.Service.Find(id);
            db.Service.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = db.Service.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateService(Service p)
        {
            var value = db.Service.Find(p.ServiceId);
            value.Title = p.Title;
            value.Description = p.Description;
            value.IconUrl = p.IconUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
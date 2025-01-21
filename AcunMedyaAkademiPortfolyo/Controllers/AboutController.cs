using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class AboutController : Controller
    {
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();

        // GET: About
        public ActionResult Index()
        {
            var values = db.About.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAbout() { 
        return View();
       
        }
        [HttpPost]
        public ActionResult CreateAbout(About p) {
            db.About.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");        
        }
        public ActionResult DeleteAbout(int id)
        {
            var value = db.About.Find(id);
            db.About.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = db.About.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            var value = db.About.Find(p.AboutId);
            value.Description = p.Description;
            value.Title = p.Title;
            value.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
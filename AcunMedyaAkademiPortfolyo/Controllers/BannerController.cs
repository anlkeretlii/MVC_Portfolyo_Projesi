using AcunMedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo;


namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class BannerController : Controller
    {
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();
        public ActionResult Index()
        {
            var values = db.Banner.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateBanner()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateBanner(Banner p)
        {
            db.Banner.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBanner(int id)
        {
            var value = db.Banner.Find(id);
            db.Banner.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateBanner(int id)
        {
            var value = db.Banner.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateBanner(Banner p)
        {
            var value = db.Banner.Find(p.BannerId);
            value.Title = p.Title;
            value.Description = p.Description;
            value.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
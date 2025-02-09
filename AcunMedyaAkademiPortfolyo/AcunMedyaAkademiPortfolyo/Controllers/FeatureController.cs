using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class FeatureController : Controller
    {
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();
        // GET: Feature
        public ActionResult Index()
        {
            var values = db.Feature.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateFeature(Feature p)
        {
            db.Feature.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteFeature(int id)
        {
            var value = db.Feature.Find(id);
            db.Feature.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var value = db.Feature.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateFeature(Feature p)
        {
            var value = db.Feature.Find(p.FeatureId);
            value.FeatureTitle = p.FeatureTitle;
            value.FeatureSubtitle = p.FeatureSubtitle;
            value.FeatureImageUrl = p.FeatureImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
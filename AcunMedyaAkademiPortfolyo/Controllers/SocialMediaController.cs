using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();
        public ActionResult Index()
        {
            var values = db.SocialMedia.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia(SocialMedia p)
        {
            db.SocialMedia.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var value = db.SocialMedia.Find(id);
            db.SocialMedia.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = db.SocialMedia.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia p)
        {
            var value = db.SocialMedia.Find(p.SocialMediaId);
            value.SocialMediaUrl = p.SocialMediaUrl;
            value.SocialMediaImageUrl = p.SocialMediaImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
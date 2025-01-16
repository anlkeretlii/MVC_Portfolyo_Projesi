using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class ProfileController : Controller
    {
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();
        // GET: Profile
        public ActionResult Index()
        {
            var values = db.Profile.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProfile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProfile(Profile p)
        {
            db.Profile.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProfile(int id)
        {
            var value = db.Profile.Find(id);
            db.Profile.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProfile(int id)
        {
            var value = db.Profile.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProfile(Profile p)
        {
            var value = db.Profile.Find(p.ProfileId);
            value.Name = p.Name;
            value.Birthday = p.Birthday;
            value.Adress = p.Adress;
            value.Email = p.Email;
            value.Telephone = p.Telephone;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
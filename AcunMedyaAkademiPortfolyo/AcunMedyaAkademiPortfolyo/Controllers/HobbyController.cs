using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class HobbyController : Controller
    {
        // GET: Hobby
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();
        public ActionResult Index()
        {
            var values = db.Hobby.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateHobby()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateHobby(Hobby p)
        {
            db.Hobby.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteHobby(int id)
        {
            var value = db.Hobby.Find(id);
            db.Hobby.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateHobby(int id)
        {
            var value = db.Hobby.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateHobby(Hobby p)
        {
            var value = db.Hobby.Find(p.HobbyId);
            value.IconUrl = p.IconUrl;
            value.Title = p.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
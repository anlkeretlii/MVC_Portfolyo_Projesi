using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;


namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class SkillController : Controller
    {
        DbProductAcunMedyaEntities db= new DbProductAcunMedyaEntities();
        // GET: Skill
        public ActionResult Skilllist()
        {
            var values = db.Skill.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSkill(Skill p)
        {
            db.Skill.Add(p);
            db.SaveChanges();
            return RedirectToAction("Skilllist");
        }
        public ActionResult DeleteSkill(int id)
        {
            var value = db.Skill.Find(id);
            db.Skill.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Skilllist");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.Skill.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(Skill p)
        {
            var value = db.Skill.Find(p.SkillId);
            value.Title = p.Title;
            value.Value = p.Value;
            value.LastWeekValue = p.LastWeekValue;
            value.LastMonthValue = p.LastMonthValue;
            db.SaveChanges();
            return RedirectToAction("Skilllist");
        }
    }
}
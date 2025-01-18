using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar() { 
        return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            var values = db.Feature.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.About.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProfile()
        {
            var values = db.Profile.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.Skill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialHobby()
        {
            var values = db.Hobby.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProjects()
        {
            var values = db.tblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonials()
        {
            var values = db.Testimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            var skillcount = db.Skill.ToList().Count();
            var testimonialcount = db.Testimonial.ToList().Count();
            var projectcount = db.tblProject.ToList().Count();
            var servicecount = db.Service.ToList().Count();
            ViewBag.SkillCount = skillcount;
            ViewBag.TestimonialCount = testimonialcount;
            ViewBag.ProjectCount = projectcount;
            ViewBag.ServiceCount = servicecount;
            return PartialView();
        }
    }
}
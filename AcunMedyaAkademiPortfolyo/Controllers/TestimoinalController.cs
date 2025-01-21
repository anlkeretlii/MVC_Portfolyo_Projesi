using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;


namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class TestimoinalController : Controller
    {
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();   

        // GET: Testimoinal
        public ActionResult Index()

        {
            var values = db.Testimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(Testimonial p)
        {
            db.Testimonial.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.Testimonial.Find(id);
            db.Testimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value =db.Testimonial.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial p)
        {
           var value = db.Testimonial.Find(p.TestimonialId);
            value.TestimonialDescription = p.TestimonialDescription;
            value.TestimonialImageUrl = p.TestimonialImageUrl;
            value.TestimonialTitle = p.TestimonialTitle;
            value.TestimonialName = p.TestimonialName;
            value.Status = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
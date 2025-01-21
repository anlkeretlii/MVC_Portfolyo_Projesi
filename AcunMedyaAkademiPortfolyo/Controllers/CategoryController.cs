using AcunMedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo;
using AcunMedyaAkademiPortfolyo.Models;


namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class CategoryController : Controller
    {
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();
        // GET: Category
        public ActionResult Index()
        {
            var values = db.Category.ToList();
            return View(values);
        }
        public ActionResult SendMessage() //daha önce eklemişim ama neden olduğuınu çözemedim
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Category p)
        {
            db.Category.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var value = db.Category.Find(id);
            db.Category.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = db.Category.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category p)
        {
            var value = db.Category.Find(p.CategoryId);
            value.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
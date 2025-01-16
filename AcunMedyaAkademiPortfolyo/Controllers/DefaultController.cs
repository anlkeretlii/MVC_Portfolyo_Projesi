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
    }
}
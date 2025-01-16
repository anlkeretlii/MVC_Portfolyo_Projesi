using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Controllers;
using AcunMedyaAkademiPortfolyo.Models;



namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class StatisticController : Controller
    {
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();
        // GET: Statistic
        public ActionResult Index()
        {
            ViewBag.categoryCount= db.Category.Count();
            ViewBag.projectCount= db.tblProject.Count();
            ViewBag.skillCount= db.Skill.Count();
            ViewBag.skillAvgValue = db.Skill.Average(X => X.Value);
            ViewBag.lastSkillTitleName = db.Getlastskilltitle1().FirstOrDefault();
            ViewBag.mvcCategoryProjectCount = db.tblProject.Where(x => x.ProjectCategory == 4).Count();

            return View();
        }
    }
}
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

            
            ViewBag.GetLastSkillTitle = db.Skill.OrderByDescending(s => s.SkillId).Select(s => s.Title).FirstOrDefault();
            ViewBag.mvcCategoryProjectCount = db.tblProject.Count(p => p.ProjectName == "Flutter");
            ViewBag.hobbyCount = db.Hobby.Count();
            ViewBag.serviceCount = db.Service.Count();

            ViewBag.highestSkillScore = db.Skill.Max(s => s.Value);
            ViewBag.lowestSkillScore = db.Skill.Min(s => s.Value);
            ViewBag.ProjectName = db.tblProject.OrderByDescending(p => p.ProjectId).Select(p => p.ProjectName).FirstOrDefault();

            return View();
        }
    }
}
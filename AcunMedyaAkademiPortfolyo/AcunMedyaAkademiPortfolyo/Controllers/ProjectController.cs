using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();
        public ActionResult Index()
        {
            var values = db.tblProject.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(tblProject p)
        {
            db.tblProject.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProject(int id)
        {
            var value = db.tblProject.Find(id);
            db.tblProject.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value = db.tblProject.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProject(tblProject p)
        {
            var value = db.tblProject.Find(p.ProjectId);
            value.ProjectName = p.ProjectName;
            value.ProjectImageUrl = p.ProjectImageUrl;
            value.ProjectCategory = p.ProjectCategory;
            value.ProjectGitLink = p.ProjectGitLink;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
using AcunMedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class ContactController : Controller
    {
        DbProductAcunMedyaEntities db = new DbProductAcunMedyaEntities();
        // GET: Contact
        public ActionResult Index()
        {
            var values = db.Contact.ToList();
            return View(values);
        }
        public ActionResult SendMessage()
        {
            return View();
        }
        public ActionResult MesssageList()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateContact(Contact p)
        {
            db.Contact.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteContacts(int id)
        {
            var value = db.Contact.Find(id);
            db.Contact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var value = db.Contact.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateContact(Contact p)
        {
            var value = db.Contact.Find(p.ContactId);
            value.Name = p.Name;
            value.Email = p.Email;
            value.Subject = p.Subject;
            value.Description = p.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
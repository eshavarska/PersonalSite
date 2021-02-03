using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalSite.Models;

namespace PersonalSite.Controllers
{
    public class HomeController : Controller
    {
        private PersonalSiteContext _db = new PersonalSiteContext();

        public ActionResult Index()
        {
            var mostRecentEntries = (from entry in _db.Entries orderby entry.DateAdded descending select entry).Take(20);
            ViewBag.Entries = mostRecentEntries.ToList();
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Downloads()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(PersonalSiteEntry entry)
        {
            entry.DateAdded = DateTime.Now;
            _db.Entries.Add(entry);
            _db.SaveChanges();

            return new RedirectResult(Url.Action("Index") + "#reviews");
        }

    }
}
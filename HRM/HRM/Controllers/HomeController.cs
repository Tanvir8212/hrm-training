using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRM.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            ViewBag.Departments = db.Departments.ToList();
            ViewBag.Divisions = db.Divisions.ToList();
            ViewBag.Designations = db.Designations.ToList();
            ViewBag.Employees = db.Employees.ToList();
            ViewBag.Sections = db.Sections.ToList();
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
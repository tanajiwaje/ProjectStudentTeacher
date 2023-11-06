using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectStudentTeacher.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Topic()
        {
            return View();
        }

        public ActionResult Content()
        {
            return View();
        }

        public ActionResult Courses()
        {
            return View();
        }

        public ActionResult Student()
        {

            return View();
        }

        public ActionResult Trainer()
        {
            return View();
        }

        public ActionResult BatchDetails()
        {
            return View();
        }
    }
}
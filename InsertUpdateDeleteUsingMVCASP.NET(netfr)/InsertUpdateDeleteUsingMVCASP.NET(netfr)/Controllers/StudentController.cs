using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using InsertUpdateDeleteUsingMVCASP.NET_netfr_.Models;
namespace InsertUpdateDeleteUsingMVCASP.NET_netfr_.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext db = new StudentContext();
        // GET: Student
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }


    }
}
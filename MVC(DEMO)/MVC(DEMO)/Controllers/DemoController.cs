using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DEMO_.Models;
namespace MVC_DEMO_.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            //ViewBag.age = 20;
            //ViewBag.fullname = "Kevin";
            //ViewBag.status = true;
            //ViewBag.price = 4.5;
            //ViewBag.birthday =DateTime.Now;
            //return View();
            product p = new product()
            {
                Id = "p01",
                Photo = "Me.jpg",
                Name = "Name1",
                
                Price = 5.5,
                Quantity = 4
            };
            ViewBag.p = p;

            return View();
        }
    }
}
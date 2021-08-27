using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baithuchanh2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Getinfo()
        {
            return View();
        }
       [HttpPost]
       public ActionResult Getinfo(string ten,string tuoi,string lop)
        {
            ViewBag.Ten = ten;
            ViewBag.Tuoi = tuoi;
            ViewBag.Lop = lop;
            return View();
        }    
    }
}
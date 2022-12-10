using CodeFApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new OfficeContext())
            {

                var alldepartment = db.Department.ToList();
                
            }
            return View();
        }

        public ActionResult About()
        {
            using (var db = new OfficeContext())
            {
                db.Department.Add(new Department() { DeptName = ".Net" });
                db.Department.Add(new Department() { DeptName = "Java" });
                db.Department.Add(new Department() { DeptName = "PHP" });
                db.Department.Add(new Department() { DeptName = "Azure" });
                db.SaveChanges();
            }
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
using StudentRegFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRegFilter.Controllers
{
    public class HomeController : Controller
    {
        SchoolRegEntities db = new SchoolRegEntities();
        public ActionResult Index()
        {
            return View(db.STUDENTS.ToList());
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
        [HttpPost]
        public JsonResult GetSearchingData(string SearchBy, string SearchValue)
        {
            List<STUDENT> studList = new List<STUDENT>();
            if (SearchBy == "ID")
            {
                try
                {
                    int Id = Convert.ToInt32(SearchValue);
                    studList = db.STUDENTS.Where(s => s.StudentID == Id || SearchValue == null).ToList();
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} Is not A ID ", SearchValue);
                }
                return Json(studList, JsonRequestBehavior.AllowGet);
            }
            else
            {
                studList = db.STUDENTS.Where(s => s.Name.Contains(SearchValue) || SearchValue == null).ToList();
                return Json(studList,JsonRequestBehavior.AllowGet);
            }
        }
    }
}
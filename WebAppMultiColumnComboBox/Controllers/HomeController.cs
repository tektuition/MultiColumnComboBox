using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMultiColumnComboBox.Models;

namespace WebAppMultiColumnComboBox.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeDBEntities objEmployeeDbEntities;
        public HomeController()
        {
            objEmployeeDbEntities = new EmployeeDBEntities();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllEmployees()
        {
            return Json(objEmployeeDbEntities.Employees.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}
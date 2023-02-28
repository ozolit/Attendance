using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Attendance.Areas.Admin.Controllers
{
    public class AdmindashboardController : Controller
    {
        // GET: Admin/AdminDashboard
        public ActionResult Index()
        {
            ViewBag.title = "Index";
            return View();
        }
    }
}
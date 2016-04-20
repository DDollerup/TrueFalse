using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrueFalse.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TrueFalseSubmit(bool test)
        {
            TempData["Test"] = test.ToString();
            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using code_test.Models;

namespace code_test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (AppModel model = new AppModel())
            {
                var ss = (from c in model.CATEGORIES
                          select new { c.CID, c.CATEGORY }).ToList();
                Console.Write(ss.Count);
            }
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}
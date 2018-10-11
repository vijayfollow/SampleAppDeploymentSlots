using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Deployment slots";
            List<long> numCollection = new List<long>();

            for (long i = 0; i < 100000; i++)
            {
                numCollection.Add(i);
            }

            return View();
        }
    }
}

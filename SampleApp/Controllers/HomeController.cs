﻿using System;
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

            for (long i = 0; i < 100000; i++)
            {
                
            }

            return View();
        }
    }
}

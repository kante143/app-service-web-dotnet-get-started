﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_get_started.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page is Modified.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "please don't do this.";

            return View();
        }
    }
}

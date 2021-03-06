﻿using ApprovalTests.Asp.Mvc.Utilities;
using ApprovalUtilities.Asp.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caldera.Controllers
{
    public class HomeController : ControllerWithExplicitViews
    {
        public ActionResult Index()
        {
            return View();
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
    }
}
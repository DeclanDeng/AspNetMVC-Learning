﻿using ControllersAndActions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from the DerivedController Index method";
            return View("MyView");
        }

        public ActionResult ProduceOutput()
        {
            //if (Server.MachineName == "TINY")
            //{
            //    //Response.Redirect("/Basic/Index");
            //    return new CustomRedirectResult { Url = "/Basic/Index" };
            //}
            //else
            //{
            //    Response.Write("Controller: Derived, Action: ProduceOutput");
            //    return null;
            //}
            //return new RedirectResult("/Basic/Index");
            return Redirect("/Basic/Index");
        }
    }
}

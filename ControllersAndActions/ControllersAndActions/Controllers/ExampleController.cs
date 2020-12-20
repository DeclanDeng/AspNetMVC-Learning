using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            if (TempData["Message"] != null && TempData["Date"] != null)
            {
                ViewBag.Message = TempData["Message"];
                ViewBag.Date = TempData["Date"];
            }
            else
            {
                ViewBag.Message = "Hello";
                ViewBag.Date = DateTime.Now;
            }

            return View("Index");
        }

        public RedirectToRouteResult Redirect()
        {
            //return Redirect("/Example/Index");
            return RedirectToRoute(new
            {
                controller = "Example",
                action = "Index",
                ID = "MyID"
            });
        }

        public RedirectToRouteResult RedirectToRoute()
        {
            TempData["Message"] = "Hello";
            TempData["Date"] = DateTime.Now;
            //return RedirectToAction("Index", "Basic");
            return RedirectToAction("Index");
        }

        public HttpStatusCodeResult StatusCode()
        {
            //return HttpNotFound();
            //return new HttpUnauthorizedResult();
            return new HttpStatusCodeResult(404, "URL cannot be serviced");
        }
    }
}

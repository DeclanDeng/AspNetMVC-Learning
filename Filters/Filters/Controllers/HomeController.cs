using Filters.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        [CustomAuth(true)]
        //[Authorize(Users = "adam, steve, jacqui", Roles = "admin")]
        public string Index()
        {
            return "This is the Index action on the Home controller";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationDemoMVC.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult IndexPartial()
        {
            return PartialView();
        }
    }
}
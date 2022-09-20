using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

           var ctx = new MedicineStoreModels();
            var lst1 = ctx.NHANVIENs.ToList();
            //var list = ConsoleApp2.DBHelper.GetEmployees();
            return View(lst1);
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
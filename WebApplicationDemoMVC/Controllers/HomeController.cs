using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationDemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ///var list = new List<Models.Student>();

            var list = new List<WebApplicationDemoMVC.Models.Student>();
            try
            {
                //var model = new WebApplicationDemoMVC.Models.StudentModel();

                //list = model.Students.ToList();

                var list1 = new EntitiFrameWorkMigration.StudentModels();
                var data = list1.student.ToList();
                if (data != null && data.Count > 0)
                {
                    foreach (var item in data)
                    {
                        list.Add(new Models.Student { Id = item.Id, Name = item.Name });
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return View(list);
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
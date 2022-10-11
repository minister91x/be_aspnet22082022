using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationDemoMVC.Models;

namespace WebApplicationDemoMVC.Controllers
{

    public class HomeController : Controller
    {
        [Log]
        public ActionResult Index()
        {
            ///var list = new List<Models.Student>();

            var list = new List<WebApplicationDemoMVC.Models.Student>();
            //try
            //{
            //var model = new WebApplicationDemoMVC.Models.StudentModel();
            //list = model.Students.ToList();

            //var context = new EntitiFrameWorkMigration.DAOImpl.StudentDAOImpl();
            //var data = context.GetAllStudents();
            //if (data != null && data.Count > 0)
            //{
            //    foreach (var item in data)
            //    {
            //        list.Add(new Models.Student { Id = item.Id, Name = item.Name });
            //    }
            //}

            // Response.Redirect("https://www.google.com/?hl=vi");

            //return RedirectToAction("MyAction", "Home", new { name = "quan", id = 2022 });

            //throw new Exception("This is unhandled exception");

            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}
            return View(list);
        }

        public ActionResult HeaderPartial()
        {
            return PartialView("~/Views/Home/Partial/HeaderPartial.cshtml");
        }


        public ActionResult DemoPartial(string ViewNameInput, string ViewNameInput2)
        {
            var model = new DemoPartialModels();
            model.VariableName = ViewNameInput;

            return PartialView("~/Views/Home/Partial/DemoPartial.cshtml", model);
        }

        public JsonResult SaveData(string UserName)
        {
            var model = new ReturnData();
            if (string.IsNullOrEmpty(UserName))
            {
                model.ReturnCode = -1;
                model.ReturnMessenger = "Thêm thất bại!";
                return Json(model, JsonRequestBehavior.AllowGet);
            }

            model.ReturnCode = 1;
            model.ReturnMessenger = "Thêm thành công!";
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult MyAction(string name, int id)
        {
            ViewBag.Name = name;
            ViewBag.ID = id;
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
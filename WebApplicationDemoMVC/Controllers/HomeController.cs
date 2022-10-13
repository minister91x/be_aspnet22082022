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
            try
            {
                var model = new WebApplicationDemoMVC.Models.StudentModel();
                list = model.Students.ToList();

                var context = new EntitiFrameWorkMigration.DAOImpl.StudentDAOImpl();
                var data = context.GetAllStudents();
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

        public ActionResult HeaderPartial()
        {
            return PartialView("~/Views/Home/Partial/HeaderPartial.cshtml");
        }


        public ActionResult CustomUseLayOut()
        {
            return View();
        }

        public ActionResult CustomUseLayOut2()
        {
            return View();
        }

        public ActionResult StudentInsertUpdate(int? id)
        {
            var model = new WebApplicationDemoMVC.Models.Student();
            var id_input = Convert.ToInt32(id);
            if (id_input > 0)
            {
                // update

                var context = new EntitiFrameWorkMigration.DAOImpl.StudentDAOImpl();
                var data = context.GetAllStudents();
               var st= data.FindAll(s => s.Id == id_input).ToList().FirstOrDefault();
                if (st != null && st.Id > 0)
                {
                    model.Id = st.Id;
                    model.Name = st.Name;
                }
            }
            else
            {
                // insert
            }
            return View(model);
        }


        public ActionResult DemoPartial(string ViewNameInput, string ViewNameInput2)
        {
            var model = new DemoPartialModels();
            model.VariableName = ViewNameInput;

            return PartialView("~/Views/Home/Partial/DemoPartial.cshtml", model);
        }

        public JsonResult SaveData(int id ,string UserName)
        {
            var model = new ReturnData();
            if (string.IsNullOrEmpty(UserName))
            {
                model.ReturnCode = -1;
                model.ReturnMessenger = "UserName không được trống!";
                return Json(model, JsonRequestBehavior.AllowGet);
            }

            if (id > 0)
            {
                // gọi database để cập nhật lại dữ liệu
            }
            else
            {
                // gọi vào database để thêm mới 
            }

            model.ReturnCode = 1;
            model.ReturnMessenger = "Thêm thành công!";
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete(int id)
        {
            var model = new ReturnData();
            model.ReturnCode = 1;
            model.ReturnMessenger = "Xóa thành công!";
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
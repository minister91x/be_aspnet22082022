using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationDemoMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [OutputCache(Duration = 100)]
        public ActionResult Index(int? a, long? b)
        {
            //return View();

            // return View();

            //return Json(new { stuatus = 1, description = " Trả về Json Thành công!" }, JsonRequestBehavior.AllowGet);

            return View();
           // return PartialView();
            // var abc = GetById2(10);
        }

        public ActionResult Edit(string name, int id)
        {
            return RedirectToAction("MyAction", "Home", new { name = name, id = id });
        }

        public ActionResult Delete(int id)
        {
            if (id < 0)
            {
                return RedirectToAction("Index", "Home");
            }
            var context = new EntitiFrameWorkMigration.DAOImpl.StudentDAOImpl();

            var rs = context.Student_Delete(id);

            return RedirectToAction("Index", "Home");

        }

        [ActionName("find")] //   Chỉ định tên thay thế của phương thức hành động
        public ActionResult GetByID(int id)
        {
            //return View();

            // return View();

            return Json(new { stuatus = id, description = "Lay du lieu cua id=" + id }, JsonRequestBehavior.AllowGet);

            // return View();

        }

        [NonAction] // Chỉ định cho phương thức này không phải là phương thức hành động
        public ActionResult GetById2(int id)
        {
            //return View();

            // return View();

            return Json(new { stuatus = id, description = "Lay du lieu cua id=" + id }, JsonRequestBehavior.AllowGet);

            // return View();

        }


        public ActionResult StudentInsertUpdate(int? id)
        {
            //return View();

            // return View();
            var StudentId = id != null ? Convert.ToInt32(id) : 0;

            return Json(new { StudentId = StudentId, description = " Trả về Json Thành công!" }, JsonRequestBehavior.AllowGet);

            // return View();

        }

        [HttpPost]
        public JsonResult GetAllStudents()
        {
            int? a = null;

          return Json(new { stuatus = 1, description = " Trả về Json Thành công!" }, JsonRequestBehavior.AllowGet);

           /// return View();
        }
    }
}
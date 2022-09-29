using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationPresent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list= new List<Data.DAO.Student>(); // model
            try
            {
                var studentContext = new EntitiFrameWorkMigration.DAOImpl.StudentDAOImpl();
                // set data vào model
                list = studentContext.GetAllStudents();
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
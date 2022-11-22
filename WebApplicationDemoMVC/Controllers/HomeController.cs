using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
            //if (Session["SessionLogin"] == null || (string)Session["SessionLogin"] == "")
            //{
            //    return RedirectToAction("Login", "Account");
            //}

            var list = new List<WebApplicationDemoMVC.Models.Student>();
            try
            {
                var model = new WebApplicationDemoMVC.Models.StudentModel();
                list = model.Students.ToList();

                var context = new EntitiFrameWorkMigration.DAOImpl.StudentRepository();
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

        public ActionResult PoupEdit(int id)
        {
            var model = new WebApplicationDemoMVC.Models.Student();
            var id_input = Convert.ToInt32(id);
            if (id_input > 0)
            {
                // var context = new EntitiFrameWorkMigration.DAOImpl.StudentDAOImpl();
                var context = new EntitiFrameWorkMigration.UnitWork.UnitWork(new EntitiFrameWorkMigration.StudentModels());

                var data = context.studentRepo.GetAllStudents();

                var cus = new EntitiFrameWorkMigration.DAO.Customer
                {
                    Id = 1,
                    Name = ""
                };

                var orderr = new EntitiFrameWorkMigration.DAO.Order
                {
                    Id = 1,
                    MaDH = "DH_001",
                    TotalAmount = 10000
                };


                context.orderRepo.Add(orderr);
                context.CusRepo.Add(cus);
                context.Save();


                var st = data.FindAll(s => s.Id == id).ToList().FirstOrDefault();
                if (st != null && st.Id > 0)
                {
                    model.Id = st.Id;
                    model.Name = st.Name;
                }

            }
            return PartialView("~/Views/Home/Partial/PoupEdit.cshtml", model);
        }

        public ActionResult CustomUseLayOut()
        {
            return View();
        }

        public ActionResult CustomUseLayOut2()
        {
            return View();
        }

        public ActionResult StudentInsertUpdate(string product_type, string name, int? id)
        {


            var model = new WebApplicationDemoMVC.Models.Student();
            var id_input = Convert.ToInt32(id);
            if (id_input > 0)
            {
                // update

                var context = new EntitiFrameWorkMigration.DAOImpl.StudentRepository();
                var data = context.GetAllStudents();
                var st = data.FindAll(s => s.Id == id_input).ToList().FirstOrDefault();
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

        [HttpPost]
        public ActionResult StudentInsertUpdate(UserNameModelInput input)
        {
            var model = new WebApplicationDemoMVC.Models.Student();
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View(model);
        }

        public JsonResult SaveData(UserNameModelInput input)
        {
            if (!ModelState.IsValid)
            {
                return Json(input);
            }

            var model = new ReturnData();
            if (input == null)
            {
                model.ReturnCode = -100;
                model.ReturnMessenger = "Dữ liệu đầu vào không được trống!";
                return Json(model, JsonRequestBehavior.AllowGet);
            }

            if (string.IsNullOrEmpty(input.Name))
            {
                model.ReturnCode = -1;
                model.ReturnMessenger = "UserName không được trống!";
                return Json(model, JsonRequestBehavior.AllowGet);
            }

            if (input.Id > 0)
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

        public JsonResult ReadExcelData()
        {
            var list = new List<Student>();
            try
            {
                HttpPostedFileBase excelFile = Request.Files["UploadedFile"];

                var package = new ExcelPackage(excelFile.InputStream);

                ExcelWorksheet ws = package.Workbook.Worksheets[1];
                for (int rw = 2; rw < ws.Dimension.End.Row; rw++)
                {
                    var firstName = ws.Cells[rw, 1].Value;
                    var lastName = ws.Cells[rw, 2].Value;
                    list.Add(new Student { Name = firstName + " " + lastName });
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public void ExportExcel_EPPLUS()
        {

            var list = new List<Student>();
            //Bước 1 lấy dữ từ một nguồn nào nào đó : SQL ,WebAPI ,file ,từ file Json ...vv
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Student { Id = i, Name = "Tên số :" + i });
            }

            //Bước 2 : dùng thư viện EPPLUS
            ExcelPackage ep = new ExcelPackage();
            ExcelWorksheet Sheet = ep.Workbook.Worksheets.Add("Report");

            Sheet.Cells["A1"].Value = "Mã học sinh";
            Sheet.Cells["B1"].Value = "Tên học sinh";
            int row = 2;// dòng bắt đầu ghi dữ liệu
            foreach (var item in list)
            {
                Sheet.Cells[string.Format("A{0}", row)].Value = item.Id;
                Sheet.Cells[string.Format("B{0}", row)].Value = item.Name;

                row++;
            }
            Sheet.Cells["A:AZ"].AutoFitColumns();
            Response.Clear();
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.AddHeader("content-disposition", "attachment; filename=" + "Report.xlsx");
            Response.BinaryWrite(ep.GetAsByteArray());
            Response.End();

        }

        public static Stream UpdateDataIntoExcelTemplate(List<Student> cList, FileInfo path)
        {
            Stream stream = new MemoryStream();
            if (path.Exists)
            {
                using (ExcelPackage p = new ExcelPackage(path))
                {
                    ExcelWorksheet wsEstimate = p.Workbook.Worksheets["Sheet1"];
                    //wsEstimate.Cells["B5:E8"].LoadFromCollection(cList);
                    for (int i = 0; i < cList.Count; i++)
                    {
                        var item = cList[i];
                        wsEstimate.Cells[string.Format("A{0}", i)].Value = item.Id;
                        wsEstimate.Cells[string.Format("B{0}", i)].Value = item.Name;
                    }

                    p.SaveAs(stream);
                    stream.Position = 0;
                }
            }
            return stream;
        }


        public ActionResult DownloadXlsxReport()
        {
            var list = new List<Student>();
            //Bước 1 lấy dữ từ một nguồn nào nào đó : SQL ,WebAPI ,file ,từ file Json ...vv
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Student { Id = i, Name = "Tên số :" + i });
            }
            var ContentRootPath = System.Configuration.ConfigurationManager.AppSettings["ContentRootPath"].ToString();
            string timestamp = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToUpper().Replace(':', '_').Replace('.', '_').Replace(' ', '_').Trim();
            var templateFileInfo = new FileInfo(Path.Combine(ContentRootPath, "Template", "StudentTemplate.xlsx"));
            var stream = UpdateDataIntoExcelTemplate(list, templateFileInfo);
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "CertificationsReport-" + timestamp + ".xlsx");
        }

    }
}
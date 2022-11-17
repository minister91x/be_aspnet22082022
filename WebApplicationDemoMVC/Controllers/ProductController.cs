using ClassLibrary1123;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplicationDemoMVC.Models;

namespace WebApplicationDemoMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductInsertUpdate(int? id)
        {
            var list = new List<Category>();
            var model = new Product();
            try
            {
                var dbContext = new EntitiFrameWorkMigration.DAOImpl.CategoryRepository();
                var dbContextProduct = new EntitiFrameWorkMigration.DAOImpl.ProductRepository();
                var lst = dbContext.Category_GetList();
                if (lst != null && lst.Count > 0)
                {
                    foreach (var item in lst)
                    {
                        list.Add(new Category { CatId = item.CatId, CatName = item.CatName, ParentId = item.ParentId });
                    }
                }

                if (id != null)
                {
                    var product = dbContextProduct.GetProductById(Convert.ToInt32(id));
                    if (product != null && product.ProductId > 0)
                    {
                        model.ProductId = product.ProductId;
                        model.ProductName = product.ProductName;
                        model.FullDescription = product.ProductName;
                    }
                }

            }
            catch (Exception exx)
            {

                throw;
            }
            ViewBag.ListCategory = list;

            return View(model);
        }

        [HttpPost, ValidateInput(false)]
        public JsonResult ProductAdd(int ProductId, string ProductName, int CatID, string ProductImage
            , string FullDescription, string Shordecription, int statusUpload)
        {
            var returnData = new ReturnData();
            try
            {
                var ProductImageInsert = string.Empty;
                var image = ProductImage;
                if (image.Split('_').Length > 0)
                {
                    for (int i = 0; i < image.Split('_').Length; i++)
                    {
                        var image_base64 = image.Split('_')[i];
                        ProductImageInsert += SaveImagePath(image_base64, ClassLibrary1123.ConfigCommon.ConvertToVietNammese(ProductName)) + ",";
                    }


                }
                var product = new EntitiFrameWorkMigration.DAO.Product();
                
                var category_db = new EntitiFrameWorkMigration.DAO.Category();
                category_db.CatId = CatID;

                product.ProductId = ProductId;
                product.ProductName = ProductName;
                product.category = category_db;
                product.ProductImage = ProductImageInsert;
                product.FullDescription = FullDescription;
                product.ShortDescription = Shordecription;

                var result = new EntitiFrameWorkMigration.DAOImpl.ProductRepository().Product_Insert(product);
                if (result <= 0)
                {
                    returnData.ReturnCode = -1;// thất bại 
                    returnData.ReturnMessenger = "Thêm sản phẩm thất bại";
                    return Json(returnData, JsonRequestBehavior.AllowGet);
                }

                returnData.ReturnCode =1;// 
                returnData.ReturnMessenger = "Thêm sản phẩm thành công";
                return Json(returnData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                throw;
            }

            return Json(returnData, JsonRequestBehavior.AllowGet);
        }


        private string SaveImagePath(string imageName, string alias)
        {
            string imgNamesReturn = string.Empty;
            try
            {
                string fullPath = System.Configuration.ConfigurationManager.AppSettings["Image_Path"];
                //Xử lý image base64 ->object image
                byte[] imageByte = Convert.FromBase64String(imageName);
                MemoryStream ms = new MemoryStream(imageByte, 0, imageByte.Length);
                ms.Write(imageByte, 0, imageByte.Length);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms, true);
                //Đầu vào base64 luôn phải convert sang định dạng png
                var filename = string.Format("{0}_{1}", alias + DateTime.Now.Ticks, ".png");
                string filePath = string.Format("{0}{1}", (fullPath + "\\"), filename);
                img.Save(filePath);

                return filename;
            }
            catch (Exception ex)
            {
                return string.Empty;

            }

            return imgNamesReturn;
        }
        public string UploadImage(string ProductName, string imageBase64)
        {
            var imageNameReturn = string.Empty;
            var jss = new JavaScriptSerializer();
            try
            {

                if (string.IsNullOrEmpty(ProductName) || string.IsNullOrEmpty(imageBase64))
                {
                    return string.Empty;
                }

                var requestDataPost = new
                {
                    ProductName = ClassLibrary1123.ConfigCommon.ConvertToVietNammese(ProductName),
                    ProductPreviewImage = imageBase64
                };

                var requestDataString = jss.Serialize(requestDataPost);
                var requestBuilder = new ParamBuilder();

                requestBuilder.AddParam("partnerCode", "iorders");
                requestBuilder.AddParam("functionName", "uploadImage_Product");
                requestBuilder.AddParam("requestData", requestDataString);
                var mediaServiceUrl = ConfigurationManager.AppSettings["MEDIA.URL.POST"];

                var serviceResponse = WebPost.SendPost(requestBuilder.GetParamString(), mediaServiceUrl);
                var objectServiceResponse = jss.Deserialize<ResponseData>(serviceResponse);


                imageNameReturn = objectServiceResponse.Extend;
            }
            catch (Exception ex)
            {

            }

            return imageNameReturn;
        }

    }
}
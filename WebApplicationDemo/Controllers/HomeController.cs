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
            var context = new EntitiFrameWorkMigration.DAOImpl.ProductRepository();
            var model = new List<WebApplicationDemo.Models.ProductModelViews>();
            try
            {
                var lst = context.Product_GetAll();
                if (lst.Count > 0)
                {
                    foreach (var item in lst)
                    {
                        model.Add(new Models.ProductModelViews
                        {
                            ProductId = item.ProductId,
                            ProductName = item.ProductName,
                            ShortDescription = item.ShortDescription,
                            FullDescription = item.FullDescription,
                            ProductImage = item.ProductImage
                        });
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return View(model);

        }


        public ActionResult ProductDetail(int ProductId)
        {
            var model = new Models.ProductModelViews();
            try
            {
                var context = new EntitiFrameWorkMigration.DAOImpl.ProductRepository();
                var productdetail = context.GetProductById(ProductId);
                if (productdetail.ProductId > 0)
                {
                    model.ProductId = productdetail.ProductId;
                    model.ProductName = productdetail.ProductName;
                    model.ShortDescription = productdetail.ShortDescription;
                    model.FullDescription = productdetail.FullDescription;
                    model.ProductImage = productdetail.ProductImage;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return View(model);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationDemoMVC.Models;

namespace WebApplicationDemoMVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckOut()
        {
            try
            {
                ViewBag.ProductActive = "active";
                var cookie = Request.Cookies["ShoppingCart"] != null ? Request.Cookies["ShoppingCart"].Value : string.Empty;
                if (cookie != null && !string.IsNullOrEmpty(cookie))
                {
                    var store = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ShoppingCart>>(HttpUtility.UrlDecode(cookie));
                    ViewBag.StoreCart = store;
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    var total_price = String.Format(info, "{0:C}", store.Sum(x => x.CustomPrice * x.Quality));
                    ViewBag.TotalPrice = total_price;
                }

                return View();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home", new { });
            }
        }
    }
}
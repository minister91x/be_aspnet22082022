using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
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
                var store = new List<ShoppingCart>();
                var cookie = Request.Cookies["ShoppingCart"] != null ? Request.Cookies["ShoppingCart"].Value : string.Empty;
                if (cookie != null && !string.IsNullOrEmpty(cookie))
                {
                    store = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ShoppingCart>>(HttpUtility.UrlDecode(cookie));
                    ViewBag.StoreCart = store;
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    var total_price = String.Format(info, "{0:C}", store.Sum(x => x.CustomPrice * x.Quality));
                    ViewBag.TotalPrice = total_price;
                }

                return View(store);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home", new { });
            }
        }
    }
}
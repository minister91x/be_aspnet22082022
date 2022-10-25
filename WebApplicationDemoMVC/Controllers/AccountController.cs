﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationDemoMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            // gọi vào database check xem tài khoản này ko 
            Session["SessionLogin"] = "quannt";
            var pass_encrypt = ClassLibrary1123.Security.sHA256_EnCrypt("quannt", "BI_MAT_!@#");
            return View();
        }

        public ActionResult LogOut()
        {
            Session.Remove("SessionLogin");
            Session.RemoveAll();
            Session.Abandon();
           
            return RedirectToAction("Login", "Account");
        }


    }
}
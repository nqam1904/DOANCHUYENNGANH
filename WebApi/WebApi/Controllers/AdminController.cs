﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["login"] is null) return View("Login");
            int idRole = ((USER)Session["login"]).IDROLE;
            if (idRole != 1)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginAdmin data)
        {
            if (String.IsNullOrEmpty(data.USERNAME) || String.IsNullOrEmpty(data.PASSWORD))
            {
                ViewBag.Error = "Vui lòng nhập tài khoản hoặc mật khẩu";
                return View("Login");
            }
            using (DOANCHUYENNGANHEntities db = new DOANCHUYENNGANHEntities())
            {
                var userDB = db.USERs.Where(x => x.USERNAME.Equals(data.USERNAME.ToLower().Trim()) && x.PASSWORD.Equals(data.PASSWORD)).FirstOrDefault();
                if (userDB is null)
                {
                    ViewBag.Error = "Tài khoản hoặc mật khẩu không chính xác";
                    return View("Login");
                }

                Session["login"] = userDB;
                return RedirectToAction("Index");
            }

        }
        public ActionResult Category() 
        {
            if (Session["login"] is null) return RedirectToAction("Login");
            return View();
        }
        public ActionResult User()
        {
            if (Session["login"] is null) return RedirectToAction("Login");
            return View();
        }

        public ActionResult Position()
        {
            if (Session["login"] is null) return RedirectToAction("Login","Admin");
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login","Admin");
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;
using FryGuys.Models;

namespace FryGuys.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Join()
        {

            return View();
        }

        public ActionResult Order()
        {

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult RegisterConfirm(User user)
        {
            //if (user.FirstName == null)
            //{
            //    user.FirstName = "user";
            //}
            ViewBag.Message = "Hello, " + user.FirstName + "!\n Welcome to the Fryer's Club!";

            return View(user);
        }

        public ActionResult UserInfo(User user)
        {
            return View(user);
        }
    }
}
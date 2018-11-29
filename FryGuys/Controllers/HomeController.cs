using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

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

        public ActionResult RegisterConfirm(string errorString, string firstName, string password, string passwordConfirm)
        {
            bool noError = true;
            ViewBag.ErrorMessage = errorString;

            if (firstName == null)
            {
                firstName = "user";
            }
            ViewBag.Message = "Hello, " + firstName + "!\n Welcome to the Fryer's Club!";

            if (password != null && passwordConfirm != null)
            {
                if (password != passwordConfirm)
                {
                    ViewBag.ErrorMessage += "Please make sure your password is correct before continuing.\n";
                    noError = false;
                }
            }

            if (!noError)
            {
                return View("Register");
            }

            return View();
        }
    }
}
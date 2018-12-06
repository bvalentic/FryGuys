using System;
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
            ViewBag.Message = "Hello, " + user.FirstName + "!\n Welcome to the Fryer's Club!";

            return View(user);
        }

        public ActionResult UserInfo(User user)
        {
            return View(user);
        }

        public ActionResult SaveUser(User user)
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();

            if (user != null)
            {
                DB.Users.Add(user);
                DB.SaveChanges();
            }
            return RedirectToAction("RegisterConfirm", user);
        }

        public ActionResult ViewUsers(User user)
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();
            ViewBag.UserList = DB.Users.ToList();

            return View();
        }

        public ActionResult SaveOrder(Fry fry)
        {
            FryGuysDBEntities1 DB = new FryGuysDBEntities1();

            if (fry != null)
            {
                DB.Fries.Add(fry);
                DB.SaveChanges();
            }

            return RedirectToAction("OrderConfirm", fry);
        }

        public ActionResult OrderConfirm(Fry fry)
        {


            return View();
        }
    }
}
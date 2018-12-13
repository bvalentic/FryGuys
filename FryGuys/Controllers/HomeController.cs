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

        public ActionResult RegisterConfirm(User user)
        {
            ViewBag.Message = "Hello, " + user.FirstName + "!\n Welcome to the Fryer's Club!";

            return View(user);
        }

        public ActionResult SaveOrder(Fry fry)
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();

            if (ModelState.IsValid)
            {
                DB.Fries.Add(fry);
                DB.SaveChanges();
                return RedirectToAction("OrderConfirm", fry);
            }

            return RedirectToAction("Order");

            
        }

        public ActionResult OrderConfirm(Fry fry)
        {
            return View(fry);
        }
    }
}
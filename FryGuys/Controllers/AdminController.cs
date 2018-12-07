using FryGuys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FryGuys.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Main()
        {
            return View();
        }

        public ActionResult ViewUsers()
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();
            ViewBag.UserList = DB.Users.ToList();

            return View();
        }

        public ActionResult ViewOrders(Fry fry)
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();
            ViewBag.OrderList = DB.Fries.ToList();

            return View();
        }
    }
}
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

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult SaveNewUser(User user)
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();
            ViewBag.UserList = DB.Users.ToList();
            
            if (user != null)
            {
                foreach (User u in ViewBag.UserList)
                {
                    if ((user.FirstName == u.FirstName) && (user.LastName == u.LastName))
                    {
                        TempData["msg"] = "<script>alert('User already in database.');</script>";
                        return RedirectToAction("ViewUsers");
                    }
                    if (user.Username == u.Username)
                    {
                        TempData["msg"] = "<script>alert('Username already in database.');</script>";
                        return RedirectToAction("ViewUsers");
                    }
                    else
                    {
                        DB.Users.Add(user);
                        DB.SaveChanges();
                    }
                }                
            }
            return RedirectToAction("ViewUsers");
        }

        public ActionResult SaveExistingUser(User updatedUser)
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();
            User oldUser = DB.Users.Find(updatedUser.UserID);

            oldUser.FirstName = updatedUser.FirstName;
            oldUser.LastName = updatedUser.LastName;
            oldUser.Age = updatedUser.Age;
            oldUser.Birthday = updatedUser.Birthday;
            oldUser.Phone = updatedUser.Phone;
            oldUser.Gender = updatedUser.Gender;
            oldUser.Username = updatedUser.Username;
            oldUser.Email = updatedUser.Email;
            oldUser.GetEmail = updatedUser.GetEmail;
            oldUser.Password = updatedUser.Password;

            DB.Entry(oldUser).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
            return RedirectToAction("ViewUsers");
        }

        public ActionResult EditUser(int userID)
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();
            User edit = DB.Users.Find(userID);

            return View(edit);
        }

        public ActionResult DeleteUser(int userID)
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();
            User deletedUser = DB.Users.Find(userID);

            DB.Users.Remove(deletedUser);
            DB.SaveChanges();

            return RedirectToAction("ViewUsers");
        }

        public ActionResult ViewOrders(Fry fry)
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();
            ViewBag.OrderList = DB.Fries.ToList();

            return View();
        }

        public ActionResult AddOrder()
        {
            return View();
        }

        public ActionResult SaveNewOrder(Fry order)
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();

            if (order != null)
            {
                DB.Fries.Add(order);
                DB.SaveChanges();
            }
            return RedirectToAction("ViewOrders");
        }

        public ActionResult SaveExistingOrder(Fry updatedOrder)
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();
            Fry oldOrder = DB.Fries.Find(updatedOrder.FryID);

            oldOrder.Potato = updatedOrder.Potato;
            oldOrder.Cut = updatedOrder.Cut;
            oldOrder.Cook = updatedOrder.Cook;
            oldOrder.Season = updatedOrder.Season;
            oldOrder.Sauce = updatedOrder.Sauce;
            oldOrder.Topping = updatedOrder.Topping;

            DB.Entry(oldOrder).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
            return RedirectToAction("ViewOrders");
        }

        public ActionResult EditOrder(int fryID)
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();
            Fry edit = DB.Fries.Find(fryID);

            return View(edit);
        }

        public ActionResult DeleteOrder(int fryID)
        {
            FryGuysDBEntities DB = new FryGuysDBEntities();
            Fry deletedOrder = DB.Fries.Find(fryID);

            DB.Fries.Remove(deletedOrder);
            DB.SaveChanges();

            return RedirectToAction("ViewOrders");
        }
    }
}
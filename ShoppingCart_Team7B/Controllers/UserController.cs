using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCart_Team7B.Models;
using ShoppingCart_Team7B.Database;

namespace ShoppingCart_Team7B.Controllers
{
    public class UserController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string username, string password)
        {
            if (HttpContext.Request.HttpMethod == "POST")
            {
                var db = new ShoppingCartDbContext();
                User user = db.User.Where(x => x.Username == username).FirstOrDefault();
                if (user == null) return RedirectToAction("Login");
                if (user.Username == username && user.Password == password)
                {
                    Session session = new Session(user);
                    Response.Cookies["ShoppingCart_Team7B"]["sessionId"] = session.SessionId;
                    db.Session.Add(session);
                    db.SaveChanges();
                    ViewData["username"] = user.Username;
                    ViewData["password"] = user.Password;
                    return RedirectToAction("ListProducts", "Product");
                }
                else
                {
                    return RedirectToAction("Login");
                }
            }
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCart_Team7B.Models;

namespace ShoppingCart_Team7B.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                string message = user.LoginProcess(user.Username, user.Password);
                if (message.Equals("1"))
                {
                    Response.Cookies.Add(new HttpCookie("User1", user.Username));
                    return RedirectToAction("ListProducts", "Product");
                }
                else
                    ViewBag.ErrorMessage = message;
            }
            return View(user);
        }
    }
}
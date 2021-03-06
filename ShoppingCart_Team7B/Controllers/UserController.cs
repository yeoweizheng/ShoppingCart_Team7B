﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCart_Team7B.Models;
using ShoppingCart_Team7B.Database;
using System.Security.Cryptography;
using System.Text;

namespace ShoppingCart_Team7B.Controllers
{
    public class UserController : Controller
    {
        // GET: Login
        public ActionResult Login(string username, string password)
        {
            if (HttpContext.Request.HttpMethod == "POST")
            {
                var db = new ShoppingCartDbContext();
                User user = db.User.Where(x => x.Username == username).FirstOrDefault();
                if (user == null) return RedirectToAction("Login");
                var sha1 = new SHA1CryptoServiceProvider();
                string passwordHash = Convert.ToBase64String(sha1.ComputeHash(Encoding.UTF8.GetBytes(password)));
                if (user.Username == username && user.Password == passwordHash)
                {
                    Session session = new Session(user);
                    Response.Cookies["ShoppingCart_Team7B"]["sessionId"] = session.SessionId;
                    db.Session.Add(session);
                    db.SaveChanges();
                    return RedirectToAction("ListProducts", "Product");
                }
                else
                {
                    return RedirectToAction("Login");
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            HttpCookie cookie = Request.Cookies["ShoppingCart_Team7B"];
            if (GetUserFromCookie(cookie) != null)
            {
                var db = new ShoppingCartDbContext();
                string sessionId = cookie["sessionId"].ToString();
                Session session = db.Session.Where(x => x.SessionId == sessionId).FirstOrDefault();
                db.Session.Remove(session);
                db.SaveChanges();
            }
            return RedirectToAction("Login");
        }
        public ActionResult CreateAccount(string name, string username, string password)
        {
            if(HttpContext.Request.HttpMethod == "POST")
            {
                var db = new ShoppingCartDbContext();
                User user = new User(name, username, password);
                db.User.Add(user);
                Session session = new Session(user);
                Response.Cookies["ShoppingCart_Team7B"]["sessionId"] = session.SessionId;
                db.Session.Add(session);
                db.SaveChanges();
                return RedirectToAction("ListProducts", "Product");
            }
            return View();
        }
        public ActionResult IsNewUser(string username)
        {
            var db = new ShoppingCartDbContext();
            User user = db.User.Where(x => x.Username == username).FirstOrDefault();
            if(user == null)
            {
                return Json(true);
            }
            return Json(false);
        }
        [NonAction]
        public static User GetUserFromCookie(HttpCookie cookie)
        {
            var db = new ShoppingCartDbContext();
            if (cookie == null) return null;
            if (cookie["sessionId"] == null) return null;
            string sessionId = cookie["sessionId"].ToString();
            Session session = db.Session.Where(x => x.SessionId == sessionId).FirstOrDefault();
            if (session == null) return null;
            return session.User;
        }
    }
}
using System.Collections.Generic;
using SincoAF.Models.Dao;
using SincoAF.Interfaces;
using SincoAF.Models;
using System;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace SincoAF.Controllers {
    public class UserController : Controller {

        UserDao UserDao =  new UserDao();

        public ActionResult Index() {
            return View();
        }

        // POST: User/CreateUser
        [HttpPost]
        public ActionResult CreateUser(FormCollection form) {
            int roleid = int.Parse(Request.Form["roleid"]);
            UserEntity User = new UserEntity(Request.Form["name"], new DateTime(), roleid, Request.Form["name"], Request.Form["email"]);
            UserDao.Create(User);
            return View();
        }

        [HttpPost]
        public bool Delete(int id) {
            return UserDao.Delete(id);
        }

        [HttpGet]
        public ActionResult Select(string _Name) {
            return Json("data", new JavaScriptSerializer().Serialize(UserDao.Select(_Name)));
        }

        [HttpPost]
        public bool Update(FormCollection form) {
            int roleid = int.Parse(Request.Form["roleid"]);
            UserEntity User = new UserEntity(Request.Form["name"], new DateTime(), roleid, Request.Form["name"], Request.Form["email"]);
            return UserDao.Update(User);
        }

    }
}
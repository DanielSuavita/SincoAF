using System.Collections.Generic;
using SincoAF.Models.Dao;
using SincoAF.Interfaces;
using SincoAF.Models;
using System;
using System.Web.Mvc;


namespace SincoAF.Controllers {
    public class UserController : Controller {

        UserDao UserDao =  new UserDao();

        // POST: User/CreateUser
        [HttpPost]
        public ActionResult CreateUser(FormCollection form) {
            int roleid = int.Parse(Request.Form["roleid"]);
            UserEntity User = new UserEntity(Request.Form["name"], new DateTime(), roleid, Request.Form["name"], Request.Form["email"]);
            UserDao.Create(User);
            return View();
        }

        public bool Delete(int id) {
            return UserDao.Delete(id);
        }

        public List<object> Select(string name) {
            return UserDao.Select(name);
        }

        public bool Update(UserEntity User) {
            return UserDao.Update(User);
        }

    }
}
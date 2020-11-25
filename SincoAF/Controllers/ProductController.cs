using System.Collections.Generic;
using SincoAF.Interfaces;
using SincoAF.Models.Entitites;
using SincoAF.Models.Dao;
using System;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace SincoAF.Controllers {
    public class ProductController : Controller {

        ProductDao ProductDao = new ProductDao();

        [HttpPost]
        public bool Create(FormCollection form) {
            ProductEntity Product = new ProductEntity(int.Parse(Request.Form["code"]), Request.Form["name"], new DateTime(), int.Parse(Request.Form["quantity"]), int.Parse(Request.Form["price"]), int.Parse(Request.Form["stateid"]));
            return ProductDao.Create(Product);
        }

        [HttpPost]
        public bool Delete(int id) {
            return ProductDao.Delete(id);
        }

        [HttpGet]
        public ActionResult Select(string Product, int Code) {
            return Json("data", new JavaScriptSerializer().Serialize(ProductDao.Select(Product, Code)));
        }

        [HttpGet]
        public ActionResult SelectByOrder(string Concept, int id) {
            return Json("data", new JavaScriptSerializer().Serialize(ProductDao.SelectByOrder(Concept, id)));
        }

        [HttpPost]
        public bool Update(FormCollection form) {
            ProductEntity Product = new ProductEntity(int.Parse(Request.Form["code"]), Request.Form["name"], new DateTime(), int.Parse(Request.Form["quantity"]), int.Parse(Request.Form["price"]), int.Parse(Request.Form["stateid"]));
            return ProductDao.Update(Product);
        }
    }
}
using System.Collections.Generic;
using SincoAF.Interfaces;
using SincoAF.Models.Entitites;
using SincoAF.Models.Dao;
using System;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace SincoAF.Controllers {
    public class OrderController : Controller {

        OrderDao OrderDao = new OrderDao();

        [HttpPost]
        public bool Create(FormCollection form) {
            OrderEntity Order = new OrderEntity(int.Parse(Request.Form["userid"]), new DateTime(), Request.Form["concept"], int.Parse(Request.Form["stateid"]), new DateTime());
            return OrderDao.Create(Order);
        }

        [HttpPost]
        public bool CreateProductsOrder(int OrderId, int ProductIdr) {
            return OrderDao.CreateProductsOrder(OrderId, ProductIdr);
        }

        [HttpPost]
        public bool Delete(int id) {
            return OrderDao.Delete(id);
        }

        [HttpPost]
        public bool DeleteProductsOrder(int id) {
            return OrderDao.DeleteProductsOrder(id);
        }

        [HttpGet]
        public ActionResult Select(string Concept, int Code) {
            return Json("data", new JavaScriptSerializer().Serialize(OrderDao.Select(Concept, Code)));
        }

        [HttpGet]
        public ActionResult SelectByUser(string name) {
            return Json("data", new JavaScriptSerializer().Serialize(OrderDao.SelectByUser(name)));
        }

        [HttpPost]
        public bool Update(OrderEntity Order) {
            return OrderDao.Update(Order);
        }
    }
}
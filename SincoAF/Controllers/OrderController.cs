using System.Collections.Generic;
using SincoAF.Interfaces;
using SincoAF.Models.Entitites;
using SincoAF.Models.Dao;
using System;

namespace SincoAF.Controllers {
    public class OrderController : OrderRepository {

        OrderDao OrderDao = new OrderDao();

        public bool Create(OrderEntity Order) {
            return OrderDao.Create(Order);
        }

        public bool CreateProductsOrder(OrderEntity Order) {
            return OrderDao.CreateProductsOrder(Order);
        }

        public bool Delete(OrderEntity Order) {
            return OrderDao.Create(Order);
        }

        public bool DeleteProductsOrder(OrderEntity Order) {
            return OrderDao.DeleteProductsOrder(Order);
        }

        public List<object> Select(string Concept, int Code) {
            return OrderDao.Select(Concept, Code);
        }

        public List<object> SelectByUser(string name) {
            return OrderDao.SelectByUser(name);
        }

        public bool Update(OrderEntity Order) {
            return OrderDao.Create(Order);
        }
    }
}
using System.Collections.Generic;
using SincoAF.Interfaces;
using SincoAF.Models.Entitites;
using SincoAF.Models.Dao;

namespace SincoAF.Controllers {
    public class OrderController : OrderRepository {

        OrderDao OrderDao = new OrderDao();

        public bool Create(OrderEntity Order) {
            return OrderDao.Create(Order);
        }

        public bool Delete(OrderEntity Order) {
            return OrderDao.Create(Order);
        }

        public List<OrderEntity> Select() {
            return OrderDao.Select();
        }

        public bool Update(OrderEntity Order) {
            return OrderDao.Create(Order);
        }
    }
}
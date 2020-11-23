using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SincoAF.Interfaces;
using SincoAF.Models.Entitites;
using SincoAF.Utils;

namespace SincoAF.Models.Dao {
    public class OrderDao : OrderRepository {

        private DatabaseConnection Connection;
        public List<OrderEntity> OrderList;

        public OrderDao() {
            Connection = new DatabaseConnection();
        }

        public bool Create(OrderEntity Order) {
            try {
                Connection.Save("");
                return true;
            } catch {
                return false;
            }
        }

        public bool Delete(OrderEntity Order) {
            try {
                Connection.Save("");
                return true;
            } catch {
                return false;
            }
        }

        public List<OrderEntity> Select() {
            try {
                Connection.Select("");
                return OrderList;

            } catch {
                return null;
            }
        }

        public bool Update(OrderEntity Order) {
            try {
                Connection.Save("");
                return true;
            } catch {
                return false;
            }
        }
    }
}
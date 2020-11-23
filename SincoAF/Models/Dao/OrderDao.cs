using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using SincoAF.Interfaces;
using SincoAF.Models.Entitites;
using SincoAF.Utils;

namespace SincoAF.Models.Dao {
    public class OrderDao : OrderRepository {

        private DatabaseConnection Connection;
        public List<OrderEntity> OrderList;
        public ArrayList OrderData;


        public OrderDao() {
            Connection = new DatabaseConnection();
        }

        public bool Create(OrderEntity Order) {
            string[] OrderParams = { "@USERID", "@CREATEDAT", "@CONCEPT", "@STATEID" };
            try {
                OrderData.Add(Order.UserId);
                OrderData.Add(Order.CreatedAt);
                OrderData.Add(Order.Concept);
                OrderData.Add(Order.StateId);
                Connection.Save("CREATEORDER", OrderParams, OrderData);
                return true;
            } catch {
                return false;
            }
        }

        public bool Delete(OrderEntity Order) {
            string[] OrderParams = { "@USERID", "@CREATEDAT", "@CONCEPT", "@STATEID" };
            try {
                OrderData.Add("");
                Connection.Save("", OrderParams, OrderData);
                return true;
            } catch {
                return false;
            }
        }

        public List<OrderEntity> Select() {
            string[] OrderParams = { "@NAME" };
            try {
                OrderData.Add("");
                Connection.Select("", OrderParams, OrderData);
                return OrderList;

            } catch {
                return null;
            }
        }

        public bool Update(OrderEntity Order) {
            string[] OrderParams = { "@USERID", "@CREATEDAT", "@CONCEPT", "@STATEID" };
            try {
                OrderData.Add("");
                Connection.Save("", OrderParams, OrderData);
                return true;
            } catch {
                return false;
            }
        }
    }
}
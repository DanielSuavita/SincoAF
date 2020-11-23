using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using SincoAF.Interfaces;
using SincoAF.Models.Entitites;
using SincoAF.Utils;
using System.Data.SqlClient;

namespace SincoAF.Models.Dao {
    public class OrderDao : OrderRepository {

        private DatabaseConnection Connection;
        public List<object> OrderList;
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
                return Connection.Save("CREATEORDER", OrderParams, OrderData);
            } catch {
                return false;
            }
        }


        public bool CreateProductsOrder(int OrderId, int ProductId) {
            string[] OrderParams = { "@ORDERID", "@PRODUCTID" };
            try {
                OrderData.Add(OrderId);
                OrderData.Add(ProductId);
                return Connection.Save("CREATEPRODUCTSORDER", OrderParams, OrderData);
            } catch {
                return false;
            }
        }


        public bool Delete(int id) {
            string[] OrderParams = { "@ID" };
            try {
                OrderData.Add(id);
                return Connection.Save("DELETEORDER", OrderParams, OrderData);
            } catch {
                return false;
            }
        }


        public bool DeleteProductsOrder(int id) {
            string[] OrderParams = { "@ID" };
            try {
                OrderData.Add(id);
                return Connection.Save("DELETEPRODUCTSORDER", OrderParams, OrderData);
            } catch {
                return false;
            }
        }


        public List<object> Select(string Concept, int Code) {
            string[] OrderParams = { "@CONCEPT", "@CODE" };
            try {
                OrderData.Add(Concept);
                OrderData.Add(Code);
                SqlDataReader reader = Connection.Select("SELECTORDERBYCONCEPTORPRODUCT", OrderParams, OrderData);
                while (reader.Read()) {
                    OrderList.Add(new
                    {
                        concept = reader["CONCEPT"],
                        createdAt = reader["CREATEDAT"],
                        completedDate = reader["COMPLETEDDATE"],
                    });
                }
                return OrderList;

            } catch {
                return null;
            }
        }


        public List<object> SelectByUser(string name) {
            string[] OrderParams = { "@NAME" };
            try {
                OrderData.Add(name);
                SqlDataReader reader = Connection.Select("SELECTORDERSBYUSERSORCONCEPT", OrderParams, OrderData);
                while (reader.Read()) {
                    OrderList.Add(new
                    {
                        createdAt = reader["CREATEDAT"],
                        concept = reader["CONCEPT"],
                        orderState = reader["ORDERSTATE"],
                        completedDate = reader["COMPLETEDDATE"]
                    });
                }
                return OrderList;

            } catch {
                return null;
            }
        }


        public bool Update(OrderEntity Order) {
            string[] OrderParams = { "@ID", "@CONCEPT",  "@STATEID", "@COMPLETEDDATE"};
            try {
                OrderData.Add(Order.id);
                OrderData.Add(Order.Concept);
                OrderData.Add(Order.StateId);
                OrderData.Add(Order.CompletedAt);
                return Connection.Save("UPDATEORDER", OrderParams, OrderData);
            } catch {
                return false;
            }
        }


    }
}
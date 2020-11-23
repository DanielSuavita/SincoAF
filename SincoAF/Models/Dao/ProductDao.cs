using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using SincoAF.Utils;
using SincoAF.Interfaces;
using SincoAF.Models.Entitites;
using System.Data.SqlClient;

namespace SincoAF.Models.Dao {
    public class ProductDao : ProductRepository {

        private DatabaseConnection Connection;
        public List<object> ProductList;
        public ArrayList ProductData;


        public ProductDao() {
            Connection = new DatabaseConnection();
            ProductData = new ArrayList();
        }


        public bool Create(ProductEntity Product) {
            string[] ProductParams = { "@CODE", "@NAME", "@CREATEDAT", "@QUANTITY", "@PRICE", "@STATEID" };
            try {
                ProductData.Add(Product.Code);
                ProductData.Add(Product.Name);
                ProductData.Add(Product.CreatedAt);
                ProductData.Add(Product.Quantity);
                ProductData.Add(Product.StateId);
                return Connection.Save("CREATEPRODUCT", ProductParams, ProductData);
            } catch {
                return false;
            }
        }


        public bool Delete(int id) {
            string[] ProductParams = { "@ID" };
            try {
                ProductData.Add(id);
                return Connection.Save("DELETEPRODUCT", ProductParams, ProductData);
            } catch {
                return false;
            }
        }


        public List<object> SelectByOrder(string Concept, int id) {
            string[] OrderParams = { "@CONCEPT", "@ID" };
            try {
                ProductData.Add(Concept);
                ProductData.Add(id);
                SqlDataReader reader = Connection.Select("SELECTPRODUCSORDERTBYORDER", OrderParams, ProductData);

                while (reader.Read()) {
                    ProductList.Add(new
                    {
                        id = reader["ID"],
                        code = reader["CODE"],
                        name = reader["NAME"],
                        quantity = reader["QUANTITY"],
                        price = reader["PRICE"]
                    });
                }
                return ProductList;

            } catch {
                return null;
            }
        }

        public List<object> Select(string Product, int Code) {
            string[] OrderParams = { "@PRODUCT", "@CODE" };
            try {
                ProductData.Add(Product);
                ProductData.Add(Code);
                SqlDataReader reader = Connection.Select("SELECTPRODUCTBYCODEORNAME", OrderParams, ProductData);
                while (reader.Read()) {
                    ProductList.Add(new
                    {
                        code = reader["CODE"],
                        name = reader["NAME"],
                        quantity = reader["QUANTITY"],
                        price = reader["PRICE"],
                        createdAt = reader["CREATEDAT"],
                    });
                }
                return ProductList;

            } catch {
                return null;
            }
        }

        public bool Update(ProductEntity Product) {
            string[] ProductParams = { "@ID", "@NAME", "@QUANTITY", "@PRICE", "@STATEID" };
            try {
                ProductData.Add(Product.id);
                ProductData.Add(Product.Name);
                ProductData.Add(Product.Quantity);
                ProductData.Add(Product.Price);
                ProductData.Add(Product.StateId);
                return Connection.Save("UPDATEPRODUCT", ProductParams, ProductData);
            } catch {
                return false;
            }
        }


    }
}
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using SincoAF.Utils;
using SincoAF.Interfaces;
using SincoAF.Models.Entitites;

namespace SincoAF.Models.Dao {
    public class ProductDao : ProductRepository {

        private DatabaseConnection Connection;
        public List<ProductEntity> ProductList;
        public ArrayList ProductData;

        public ProductDao() {
            Connection = new DatabaseConnection();
            ProductData = new ArrayList();
        }

        public bool Create(ProductEntity Product) {
            string[] ProductParams = { "@NAME" };
            try {
                ProductData.Add("");
                Connection.Save("", ProductParams, ProductData);
                return true;
            } catch {
                return false;
            }
        }

        public bool Delete(ProductEntity Product) {
            string[] ProductParams = { "@NAME" };
            try {
                ProductData.Add("");
                Connection.Save("", ProductParams, ProductData);
                return true;
            } catch {
                return false;
            }
        }

        public List<ProductEntity> Select() {
            string[] ProductParams = { "@NAME" };
            try {
                ProductData.Add("");
                Connection.Select("", ProductParams, ProductData);
                return ProductList;

            } catch {
                return null;
            }
        }

        public bool Update(ProductEntity Product) {
            string[] ProductParams = { "@NAME" };
            try {
                ProductData.Add("");
                Connection.Save("", ProductParams, ProductData);
                return true;
            } catch {
                return false;
            }
        }
    }
}
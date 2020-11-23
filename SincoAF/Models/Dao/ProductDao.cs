using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SincoAF.Utils;
using SincoAF.Interfaces;
using SincoAF.Models.Entitites;

namespace SincoAF.Models.Dao {
    public class ProductDao : ProductRepository {

        private DatabaseConnection Connection;
        public List<ProductEntity> ProductList;

        public ProductDao() {
            Connection = new DatabaseConnection();
        }

        public bool Create(ProductEntity Product) {
            try {
                Connection.Save("");
                return true;
            } catch {
                return false;
            }
        }

        public bool Delete(ProductEntity Product) {
            try {
                Connection.Save("");
                return true;
            } catch {
                return false;
            }
        }

        public List<ProductEntity> Select() {
            try {
                Connection.Select("");
                return ProductList;

            } catch {
                return null;
            }
        }

        public bool Update(ProductEntity Product) {
            try {
                Connection.Save("");
                return true;
            } catch {
                return false;
            }
        }
    }
}
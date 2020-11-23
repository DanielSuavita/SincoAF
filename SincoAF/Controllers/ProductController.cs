using System.Collections.Generic;
using SincoAF.Interfaces;
using SincoAF.Models.Entitites;
using SincoAF.Models.Dao;
using System;

namespace SincoAF.Controllers {
    public class ProductController : ProductRepository {

        ProductDao ProductDao = new ProductDao();

        public bool Create(ProductEntity Product) {
            return ProductDao.Create(Product);
        }

        public bool Delete(ProductEntity Product) {
            return ProductDao.Create(Product);
        }

        public List<object> Select(string Product, int Code) {
            return ProductDao.Select(Product, Code);
        }

        public List<object> SelectByOrder(string Concept, int id) {
            return ProductDao.Select(Concept, id);
        }

        public bool Update(ProductEntity Product) {
            return ProductDao.Create(Product);
        }
    }
}
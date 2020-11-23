using System.Collections.Generic;
using SincoAF.Interfaces;
using SincoAF.Models.Entitites;
using SincoAF.Models.Dao;

namespace SincoAF.Controllers {
    public class ProductController : ProductRepository {

        ProductDao ProductDao = new ProductDao();

        public bool Create(ProductEntity Product) {
            return ProductDao.Create(Product);
        }

        public bool Delete(ProductEntity Product) {
            return ProductDao.Create(Product);
        }

        public List<ProductEntity> Select() {
            return ProductDao.Select();
        }

        public bool Update(ProductEntity Product) {
            return ProductDao.Create(Product);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;
using SincoAF.Models.Entitites;
using SincoAF.Models.Dao;

namespace SincoAF.Services {
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ProductService : IProductService {

        ProductDao ProductDao;
        ProductEntity ProductEntity;

        public ProductService() {
            ProductDao = new ProductDao();
        }

        public void CreateProduct(int _Code, string _Name, int _Quantity, int _Price, int _StateId) {
            ProductEntity = new ProductEntity(_Code, _Name, new DateTime(), _Quantity, _Price, _StateId);
            ProductDao.Create(ProductEntity);
        }

        public void DeleteProduct(int id) {
            ProductEntity.id = 2;
            ProductDao.Create(ProductEntity);
        }

        public void SelectProduct() {
            ProductEntity.id = 2;
            ProductDao.Create(ProductEntity);
        }

        public void UpdateProduct(string _Name, int _Quantity, int _Price, int _StateId) {
            ProductEntity = new ProductEntity(0, _Name, new DateTime(), _Quantity, _Price, _StateId);
            ProductDao.Update(ProductEntity);
        }
    }
}

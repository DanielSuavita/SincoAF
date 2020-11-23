using System;
using System.ServiceModel.Activation;
using SincoAF.Models.Entitites;
using SincoAF.Models.Dao;
using System.Web.Script.Serialization;

namespace SincoAF.Services {
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ProductService : IProductService {

        ProductDao ProductDao;
        ProductEntity ProductEntity;


        public ProductService() {
            ProductDao = new ProductDao();
        }


        public Boolean CreateProduct(int _Code, string _Name, int _Quantity, int _Price, int _StateId) {
            ProductEntity = new ProductEntity(_Code, _Name, new DateTime(), _Quantity, _Price, _StateId);
            return ProductDao.Create(ProductEntity);
        }


        public Boolean DeleteProduct(int _Id) {
            return ProductDao.Delete(_Id);
        }


        public string SelectProduct(string _Product, int _Code) {
            return new JavaScriptSerializer().Serialize(ProductDao.Select(_Product, _Code));
        }


        public string SelectByOrder(string _Concept, int _Id) {
            return new JavaScriptSerializer().Serialize(ProductDao.SelectByOrder(_Concept, _Id));
        }


        public Boolean UpdateProduct(string _Name, int _Quantity, int _Price, int _StateId) {
            ProductEntity = new ProductEntity(0, _Name, new DateTime(), _Quantity, _Price, _StateId);
            return ProductDao.Update(ProductEntity);
        }


    }
}

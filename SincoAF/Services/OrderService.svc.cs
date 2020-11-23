using System;
using System.ServiceModel.Activation;
using SincoAF.Models.Entitites;
using SincoAF.Models.Dao;
using System.Web.Script.Serialization;

namespace SincoAF.Services {
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class OrderService : IOrderService {

        OrderDao OrderDao;
        OrderEntity OrderEntity;


        public OrderService() {
            OrderDao = new OrderDao();
        }


        public Boolean CreateOrder(int _UserId, string _Concept, int _StateId) {
            OrderEntity = new OrderEntity(_UserId, new DateTime(), _Concept, _StateId, new DateTime());
            return OrderDao.Create(OrderEntity);
        }


        public Boolean CreateProductsOrder(int _OrderId, int _ProductId) {
            return OrderDao.CreateProductsOrder(_OrderId, _ProductId);
        }


        public Boolean DeleteOrder(int _Id) {
            return OrderDao.Delete(_Id);
        }


        public Boolean DeleteProductsOrder(int _Id) {
            return OrderDao.DeleteProductsOrder(_Id);
        }


        public string SelectByUser(string _Name) {
            return new JavaScriptSerializer().Serialize(OrderDao.SelectByUser(_Name));
        }


        public string SelectOrder(string _Concept, int _Code) {
            return new JavaScriptSerializer().Serialize(OrderDao.Select(_Concept, _Code));
        }


        public Boolean UpdateOrder(string _Concept, int _StateId) {
            OrderEntity = new OrderEntity( _Concept, _StateId, new DateTime());
            return OrderDao.Create(OrderEntity);
        }


    }
}

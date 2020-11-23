using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using SincoAF.Models.Entitites;
using SincoAF.Models.Dao;

namespace SincoAF.Services {
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class OrderService : IOrderService {

        OrderDao OrderDao;
        OrderEntity OrderEntity;

        public OrderService() {
            OrderDao = new OrderDao();
        }

        public void CreateOrder(int _UserId, string _Concept, int _StateId) {
            OrderEntity = new OrderEntity(_UserId, new DateTime(), _Concept, _StateId, new DateTime());
            OrderDao.Create(OrderEntity);
        }

        public void DeleteOrder(int id) {
            OrderEntity.id = 2;
            OrderDao.Create(OrderEntity);
        }

        public void SelectOrder() {
            OrderEntity.id = 2;
            OrderDao.Create(OrderEntity);
        }

        public void UpdateOrder(string _Concept, int _StateId) {
            OrderEntity = new OrderEntity( _Concept, _StateId, new DateTime());
            OrderDao.Create(OrderEntity);
        }
    }
}

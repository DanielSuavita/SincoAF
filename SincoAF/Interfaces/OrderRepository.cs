using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincoAF.Models.Entitites;

namespace SincoAF.Interfaces {
    interface OrderRepository {

        Boolean Create(OrderEntity Order);
        Boolean CreateProductsOrder(int OrderId, int ProductId);
        Boolean Update(OrderEntity Order);
        Boolean Delete(int id);
        Boolean DeleteProductsOrder(int id);
        List<object> Select(string Concept, int Code);
        List<object> SelectByUser(string name);

    }
}

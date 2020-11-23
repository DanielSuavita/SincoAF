using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincoAF.Models.Entitites;

namespace SincoAF.Interfaces {
    interface OrderRepository {

        Boolean Create(OrderEntity Order);
        Boolean Update(OrderEntity Order);
        Boolean Delete(OrderEntity Order);
        List<OrderEntity> Select();
    }
}

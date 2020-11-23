using System;
using System.Collections.Generic;
using SincoAF.Models.Entitites;

namespace SincoAF.Interfaces {
    interface ProductRepository {

        Boolean Create(ProductEntity Product);
        Boolean Update(ProductEntity Product);
        Boolean Delete(ProductEntity Product);
        List<ProductEntity> Select();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SincoAF.Models.Entitites {
    public class ProductEntity {

        public int id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int StateId { get; set; }

        public ProductEntity() { }

        public ProductEntity(int _Code, string _Name, DateTime _CreatedAt, int _Quantity, int _Price, int _StateId) {
            Code = _Code;
            Name = _Name;
            CreatedAt = _CreatedAt;
            Quantity = _Quantity;
            Price = _Price;
            StateId = _StateId;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SincoAF.Models.Entitites {
    public class ProductEntity {

        private int id              { get; set; }
        private int Code            { get; set; }
        private string Name         { get; set; }
        private DateTime CreatedAt  { get; set; }
        private int Quantity        { get; set; }
        private int Price           { get; set; }
        private int StateId         { get; set; }

        public ProductEntity() {

        }
    }
}
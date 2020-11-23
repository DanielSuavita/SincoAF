using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SincoAF.Models.Entitites {
    public class OrderEntity {

        private int id              { get; set; }
        private int UserId          { get; set; }
        private DateTime CreatedAt  { get; set; }
        private string Concept      { get; set; }
        private int StateId         { get; set; }
        private DateTime CompletedAt{ get; set; }

        public OrderEntity() { }


    }
}
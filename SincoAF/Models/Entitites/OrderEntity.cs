using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SincoAF.Models.Entitites {
    public class OrderEntity {

        public int id              { get; set; }
        public int UserId          { get; set; }
        public DateTime CreatedAt  { get; set; }
        public string Concept      { get; set; }
        public int StateId         { get; set; }
        public DateTime CompletedAt{ get; set; }

        public OrderEntity() { }

        public OrderEntity(int _UserId, DateTime _CreatedAt, string _Concept, int _StateId, DateTime _CompletedAt) {
            UserId      = _UserId;
            CreatedAt   = _CreatedAt;
            Concept     = _Concept;
            StateId     = _StateId;
            CompletedAt = _CompletedAt;
        }

        public OrderEntity(string _Concept, int _StateId, DateTime _CompletedAt) {
            Concept = _Concept;
            StateId = _StateId;
            CompletedAt = _CompletedAt;
        }

    }
}
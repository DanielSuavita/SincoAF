using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SincoAF.Services {
    [ServiceContract]
    public interface IOrderService {


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "CreateOrder?userid={_UserId}&concept={_Concept}&stateid={_StateId}")]
        void CreateOrder(int _UserId, string _Concept, int _StateId);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "UpdateOrder?concept={_Concept}&stateid={_StateId}")]
        void UpdateOrder(string _Concept, int _StateId);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "DeleteOrder?id={id}", ResponseFormat = WebMessageFormat.Json)]
        void DeleteOrder(int id);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "SelectOrder")]
        void SelectOrder();
    }
}

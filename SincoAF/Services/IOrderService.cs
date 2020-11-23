using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using SincoAF.Models.Entitites;

namespace SincoAF.Services {
    [ServiceContract]
    public interface IOrderService {


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "CreateOrder?userid={_UserId}&concept={_Concept}&stateid={_StateId}")]
        Boolean CreateOrder(int _UserId, string _Concept, int _StateId);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "CreateProductsOrder?orderid={_OrderId}&productid={_ProductId}")]
        Boolean CreateProductsOrder(int _OrderId, int _ProductId);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "UpdateOrder?concept={_Concept}&stateid={_StateId}")]
        Boolean UpdateOrder(string _Concept, int _StateId);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "DeleteOrder?id={_Id}")]
        Boolean DeleteOrder(int _Id);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "DeleteProductsOrder?id={_Id}")]
        Boolean DeleteProductsOrder(int _Id);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "SelectOrder?concept={_Concept}&code={_Code}", ResponseFormat = WebMessageFormat.Json)]
        string SelectOrder(string _Concept, int _Code);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "SelectByUser?name={_Name}", ResponseFormat = WebMessageFormat.Json)]
        string SelectByUser(string _Name);

    }
}

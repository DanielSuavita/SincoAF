using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SincoAF.Services {
    [ServiceContract]
    public interface IProductService {


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "CreateProduct?code={_Code}&name={_Name}&quantity={_Quantity}&price={_Price}&stateid={_StateId}")]
        Boolean CreateProduct(int _Code, string _Name, int _Quantity, int _Price, int _StateId);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "UpdateProduct?name={_Name}&quantity={_Quantity}&price={_Price}&stateid={_StateId}")]
        Boolean UpdateProduct(string _Name, int _Quantity, int _Price, int _StateId);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "DeleteProduct?id={_Id}")]
        Boolean DeleteProduct(int _Id);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "SelectProduct?product={_Product}&code={_Code}", ResponseFormat = WebMessageFormat.Json)]
        string SelectProduct(string _Product, int _Code);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "SelectByOrder?concept={_Concept}&id={_Id}", ResponseFormat = WebMessageFormat.Json)]
        string SelectByOrder(string _Concept, int _Id);


    }
}

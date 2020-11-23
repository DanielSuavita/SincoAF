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
        void CreateProduct(int _Code, string _Name, int _Quantity, int _Price, int _StateId);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "UpdateProduct?name={_Name}&quantity={_Quantity}&price={_Price}&stateid={_StateId}")]
        void UpdateProduct(string _Name, int _Quantity, int _Price, int _StateId);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "DeleteProduct?id={id}", ResponseFormat = WebMessageFormat.Json)]
        void DeleteProduct(int id);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "SelectProduct")]
        void SelectProduct();
    }
}

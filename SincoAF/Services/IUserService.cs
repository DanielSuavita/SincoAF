using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace SincoAF.Services {
    [ServiceContract]
    public interface IUserService {


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "CreateUser?name={_Name}&roleid={_Roleid}&username={_Username}&email={_Email}")]
        void CreateUser(string _Name, int _Roleid, string _Username, string _Email);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "UpdateUser?name={_Name}&roleid={_Roleid}&username={_Username}&email={_Email}")]
        void UpdateUser(string _Name, int _Roleid, string _Username, string _Email);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "DeleteUser?id={_Id}")]
        void DeleteUser(int _Id);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "SelectUser?name={_Name}", ResponseFormat = WebMessageFormat.Json)]
        void SelectUser(string _Name);


    }
}

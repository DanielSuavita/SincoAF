using System;
using System.ServiceModel;
using System.ServiceModel.Web;


namespace SincoAF.Services {
    [ServiceContract]
    public interface IUserService {


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "CreateUser?name={_Name}&roleid={_Roleid}&username={_Username}&email={_Email}")]
        Boolean CreateUser(string _Name, int _Roleid, string _Username, string _Email);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "UpdateUser?name={_Name}&roleid={_Roleid}&username={_Username}&email={_Email}")]
        Boolean UpdateUser(string _Name, int _Roleid, string _Username, string _Email);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "DeleteUser?id={_Id}")]
        Boolean DeleteUser(int _Id);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "SelectUser?name={_Name}", ResponseFormat = WebMessageFormat.Json)]
        string SelectUser(string _Name);


    }
}

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
        [WebInvoke(Method = "POST", UriTemplate = "CreateUser?name={_name}&roleid={_roleid}&username={_username}&email={_email}")]
        void CreateUser(string _name, int _roleid, string _username, string _email);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "UpdateUser?name={_name}&roleid={_roleid}&username={_username}&email={_email}")]
        void UpdateUser(string _name, int _roleid, string _username, string _email);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "DeleteUser?id={id}", ResponseFormat = WebMessageFormat.Json)]
        void DeleteUser(int id);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "SelectUser")]
        void SelectUser();

    }
}

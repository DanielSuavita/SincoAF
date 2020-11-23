using System;
using SincoAF.Models;
using SincoAF.Models.Dao;
using System.ServiceModel.Activation;
using System.Web.Script.Serialization;

namespace SincoAF.Services {
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class UserService : IUserService {

        UserDao UserDao;
        UserEntity UserEntity;


        public UserService() {
            UserDao = new UserDao();
        }


        public Boolean CreateUser(string _Name, int _Roleid, string _Username, string _Email) {

            UserEntity = new UserEntity(_Name, new DateTime(), _Roleid, _Username, _Email);
            return UserDao.Create(UserEntity);
        }


        public Boolean DeleteUser(int id) {
            return UserDao.Delete(id);
        }


        public string SelectUser(string _Name) {
            return new JavaScriptSerializer().Serialize(UserDao.Select(_Name));
        }


        public Boolean UpdateUser(string _Name, int _Roleid, string _Username, string _Email) {
            UserEntity = new UserEntity(_Name, new DateTime(), _Roleid, _Username, _Email);
            return UserDao.Update(UserEntity);
        }


    }
}

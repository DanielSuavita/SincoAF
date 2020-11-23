using System;
using SincoAF.Models;
using SincoAF.Models.Dao;
using System.ServiceModel.Activation;

namespace SincoAF.Services {
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class UserService : IUserService {

        UserDao UserDao;
        UserEntity UserEntity;


        public UserService() {
            UserDao = new UserDao();
        }


        public void CreateUser(string _Name, int _Roleid, string _Username, string _Email) {

            UserEntity = new UserEntity(_Name, new DateTime(), _Roleid, _Username, _Email);
            UserDao.Create(UserEntity);
        }


        public void DeleteUser(int id) {

            UserDao.Delete(UserEntity);
        }


        public void SelectUser(string name) {
            UserDao.Select(name);
        }


        public void UpdateUser(string _Name, int _Roleid, string _Username, string _Email) {

            UserEntity = new UserEntity(_Name, new DateTime(), _Roleid, _Username, _Email);
            UserDao.Update(UserEntity);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SincoAF.Controllers;
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


        public void CreateUser(string _name, int _roleid, string _username, string _email) {

            UserEntity = new UserEntity(_name, new DateTime(), _roleid, _username, _email);
            UserDao.Create(UserEntity);
        }


        public void DeleteUser(int id) {

            UserDao.Delete(UserEntity);
        }


        public void SelectUser() {

            UserDao.Select();
        }


        public void UpdateUser(string _name, int _roleid, string _username, string _email) {

            UserEntity = new UserEntity(_name, new DateTime(), _roleid, _username, _email);
            UserDao.Update(UserEntity);
        }

    }
}

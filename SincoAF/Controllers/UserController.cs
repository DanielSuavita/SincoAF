using System.Collections.Generic;
using SincoAF.Models.Dao;
using SincoAF.Interfaces;
using SincoAF.Models;

namespace SincoAF.Controllers {
    public class UserController : UserRepository {

        UserDao UserDao =  new UserDao();

        public bool Create(UserEntity User) {
            return UserDao.Create(User);
        }

        public bool Delete(UserEntity User) {
            return UserDao.Delete(User);
        }

        public List<UserEntity> Select() {
            return UserDao.Select();
        }

        public bool Update(UserEntity User) {
            return UserDao.Update(User);
        }

    }
}
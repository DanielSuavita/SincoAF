using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SincoAF.Utils;

namespace SincoAF.Models.Dao {
    public class UserDao : Interfaces.UserRepository {

        private DatabaseConnection Connection;
        public List<UserEntity> UsersList;

        public UserDao() {
            Connection = new DatabaseConnection();
        }

        public bool Create(UserEntity User) {
            try {
                Connection.Save("");
                return true;
            }catch {
                return false;
            }
        }

        public bool Delete(UserEntity User) {
            try {
                Connection.Save("");
                return true;
            }catch {
                return false;
            }

        }

        public List<UserEntity> Select() {
            try {
                Connection.Select("");
                return UsersList;

            }catch {
                return null;
            }

        }

        public bool Update(UserEntity User) {
            try {
                Connection.Save("");
                return true;
            }catch {
                return false;
            }
        }
    }
}
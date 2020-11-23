using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using SincoAF.Utils;

namespace SincoAF.Models.Dao {
    public class UserDao : Interfaces.UserRepository {

        private DatabaseConnection Connection;
        public List<UserEntity> UsersList;
        public ArrayList UserData;

        public UserDao() {
            Connection = new DatabaseConnection();
            UserData =  new ArrayList();
        }

        public bool Create(UserEntity User) {
            string[] UserParams = { "@NAME" };
            try {
                UserData.Add("");
                Connection.Save("", UserParams, UserData);
                return true;
            }catch {
                return false;
            }
        }

        public bool Delete(UserEntity User) {
            string[] UserParams = { "@NAME" };
            try {
                UserData.Add("");
                Connection.Save("", UserParams, UserData);
                return true;
            }catch {
                return false;
            }

        }

        public List<UserEntity> Select() {
            string[] UserParams = { "@NAME" };
            try {
                UserData.Add("");
                Connection.Select("", UserParams, UserData);
                return UsersList;

            }catch {
                return null;
            }

        }

        public bool Update(UserEntity User) {
            string[] UserParams = { "@NAME" };
            try {
                UserData.Add("");
                Connection.Save("", UserParams, UserData);
                return true;
            }catch {
                return false;
            }
        }
    }
}
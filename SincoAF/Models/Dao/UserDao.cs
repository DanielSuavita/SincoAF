using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using SincoAF.Utils;
using System.Data.SqlClient;

namespace SincoAF.Models.Dao {
    public class UserDao : Interfaces.UserRepository {

        private DatabaseConnection Connection;
        public List<object> UsersList;
        public ArrayList UserData;


        public UserDao() {
            Connection = new DatabaseConnection();
            UserData = new ArrayList();
        }


        public bool Create(UserEntity User) {
            string[] UserParams = { "@NAME", "@USERNAME", "@EMAIL", "@CREATEDAT", "@ROLEID" };
            try {
                UserData.Add(User.Name);
                UserData.Add(User.UserName);
                UserData.Add(User.Email);
                UserData.Add(User.CreatedAt);
                UserData.Add(User.RoleId);
                return Connection.Save("CREATEUSER", UserParams, UserData);
            } catch {
                return false;
            }
        }


        public bool Delete(UserEntity User) {
            string[] UserParams = { "@ID" };
            try {
                UserData.Add(User.id);
                Connection.Save("DELETEUSER", UserParams, UserData);
                return true;
            } catch {
                return false;
            }
        }


        public List<object> Select(string name) {
            string[] UserParams = { "@NAME" };
            try {
                UserData.Add(name);
                SqlDataReader reader = Connection.Select("SELECTUSERBYCREDENTIALS", UserParams, UserData);
                while (reader.Read()) {
                    UsersList.Add(new
                    {
                        id = reader["ID"],
                        role = reader["ROLE"],
                        name = reader["NAME"],
                        username = reader["USERNAME"],
                        email = reader["EMAIL"]
                    });
                }
                return UsersList;

            } catch {
                return null;
            }
        }


        public bool Update(UserEntity User) {
            string[] UserParams = { "@ID", "@NAME", "@USERNAME", "@EMAIL", "@ROLEID"};
            try {
                UserData.Add(User.id);
                UserData.Add(User.Name);
                UserData.Add(User.UserName);
                UserData.Add(User.Email);
                UserData.Add(User.RoleId);
                Connection.Save("UPDATEUSER", UserParams, UserData);
                return true;
            } catch {
                return false;
            }
        }


    }
}
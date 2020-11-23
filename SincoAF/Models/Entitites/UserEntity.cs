using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SincoAF.Models
{
    public class UserEntity 
    {
        public int id              { get; set; }
        public string Name         { get; set; }
        public DateTime CreatedAt  { get; set; }
        public int RoleId          { get; set; }
        public string UserName     { get; set; }
        public string Email        { get; set; }

        public UserEntity(){ }

        public UserEntity(string _name, DateTime _createdat, int _roleid ,string _username, string _email) {
            Name = _name;
            CreatedAt = _createdat;
            RoleId = _roleid;
            UserName = _username;
            Email = _email;
        }

    }
}
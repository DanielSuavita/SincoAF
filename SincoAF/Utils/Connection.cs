using System;
using System.Collections.Generic;
using System.Security;

namespace SincoAF.Utils {
    public class Connection {

        protected string user { get; set; }
        protected string ConnectionString { get; set; }
        protected SecureString password { get; set; }

        protected Connection() {
            this.user = "";
            this.ConnectionString = "";
            this.password = new SecureString();
        }

    }
}
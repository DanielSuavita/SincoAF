using System.Data.SqlClient;

namespace SincoAF.Utils {
    public class DatabaseConnection : Connection {

        private SqlConnection SqlConn;
        private SqlDataReader Reader;

        public DatabaseConnection() {
            SqlConn = this.Connect();
            SqlConn.Open();
        }

        public SqlConnection Connect() {
            return new SqlConnection(base.ConnectionString, new SqlCredential(base.user, base.password));
        }

        public bool Save(string SqlStatement) {
            try {
                SqlCommand command = new SqlCommand(SqlStatement, SqlConn);
                if (command.ExecuteNonQuery() > 0) {
                    return true;
                }
            }catch (SqlException e) {
                return false;
            }
            return false;
        }

        public SqlDataReader Select(string SqlStatement) {
            try {
                SqlCommand command = new SqlCommand(SqlStatement, SqlConn);
                Reader = command.ExecuteReader();
                return Reader;
            }catch (SqlException e) {
                return null;
            }
        }

    }
}
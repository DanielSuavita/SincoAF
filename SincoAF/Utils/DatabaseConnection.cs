using System.Data.SqlClient;
using System.Data;
using System.Collections;


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

        public SqlCommand addParams(SqlCommand command, string[] SqlParams, ArrayList DataList) {
            for(int i = 0; i>=SqlParams.Length; i++) {
                command.Parameters.AddWithValue(SqlParams[i], DataList[i]);
            }
            return command;
        }

        public bool Save(string SqlStatement, string[] SqlParams, ArrayList DataList) {
            try {
                SqlCommand command = new SqlCommand(SqlStatement, SqlConn);
                command.CommandType = CommandType.StoredProcedure;
                command = this.addParams(command, SqlParams, DataList);

                if (command.ExecuteNonQuery() > 0) {
                    return true;
                }
            }catch (SqlException e) {
                return false;
            }
            return false;
        }

        public SqlDataReader Select(string SqlStatement, string[] SqlParams, ArrayList DataList) {
            try {
                SqlCommand command = new SqlCommand(SqlStatement, SqlConn);
                command.CommandType = CommandType.StoredProcedure;
                command = this.addParams(command, SqlParams, DataList);
                Reader = command.ExecuteReader();
                return Reader;
            }catch (SqlException e) {
                return null;
            }
        }

    }
}
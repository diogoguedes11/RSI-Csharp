using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer
{
    class DbConnection
    {
        const string constr = "Data Source=localhost;Initial Catalog=master;User Id=sa;Password=P@ssw0rd1";
        SqlConnection conn;

        public string ConnectionStatus()
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                return "true";
            }
            catch { return "false"; }
            finally { if (conn != null) conn.Close(); }
        }
    }
}

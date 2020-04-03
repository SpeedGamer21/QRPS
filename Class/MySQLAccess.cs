using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace QRPS
{
    class MySQLAccess
    {
        readonly string ConnectionString;
        public MySQLAccess(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public DataTable Get(string qry,Dictionary<string,object> parameters = null)
        {
            try
            {
                var dt = new DataTable();
                using (var con = new MySqlConnection(ConnectionString))
                using (var da = new MySqlDataAdapter(qry, con))
                {
                    da.Fill(dt);
                }
                return dt;
            }
            catch
            {
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomerInfo
{
    class ConnectionController
    {
        private string _connectionString = Properties.Settings.Default.ConnectionString;

        public SqlConnection connect()
        {
            SqlConnection con = new SqlConnection(_connectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Oops! Couldn\'t Connect Database!", "Alert", MessageBoxButtons.OK);
            }
            return con;
        }
    }
}

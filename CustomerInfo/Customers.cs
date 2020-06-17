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
    class Customers
    {
        private SqlConnection con;
        ConnectionController connection;

        public Customers()
        {
            connection = new ConnectionController();
            con = connection.connect();
        }

        public DataTable fetch()
        {
            SqlCommand allSalesCmd = new SqlCommand("PfetchCustomers", con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(allSalesCmd);
            DataTable data_table = new DataTable();
            sqlDa.Fill(data_table);
            return data_table;
        }
    }
}

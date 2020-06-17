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
    class Cities
    {
        private SqlConnection con;
        ConnectionController connection;

        public Cities()
        {
            connection = new ConnectionController();
            con = connection.connect();
        }

        public DataSet fetch()
        {
            DataSet data_set = new DataSet();
            SqlCommand cmd = new SqlCommand("PfetchCities", con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            sqlDa.Fill(data_set, "citiesTable");
            return data_set;
        }
    }
}

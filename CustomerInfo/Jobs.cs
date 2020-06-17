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
    class Jobs
    {
        private SqlConnection con;
        ConnectionController connection;

        public Jobs()
        {
            connection = new ConnectionController();
            con = connection.connect();
        }

        public DataSet fetch()
        {
            DataSet data_set = new DataSet();
            SqlCommand cmd = new SqlCommand("PfetchJobs", con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            sqlDa.Fill(data_set, "jobsTable");
            return data_set;
        }
    }
}

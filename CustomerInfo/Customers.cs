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

        public Boolean create(string customerName,
            string customerFamilyName,
            int customerJob,
            int customerSalary,
            int customerCity)
        {
            SqlCommand cmd = new SqlCommand("PcreateCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerName", customerName);
            cmd.Parameters.AddWithValue("@CustomerFamilyName", customerFamilyName);
            cmd.Parameters.AddWithValue("@CustomerJob", customerJob);
            cmd.Parameters.AddWithValue("@CustomerSalary", customerSalary);
            cmd.Parameters.AddWithValue("@CustomerCity", customerCity);

            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataSet data_set = new DataSet();
            sqlDa.Fill(data_set);

            return true;
        }

        public Boolean update(
            int customerId,
            string customerName,
            string customerFamilyName,
            int customerJob,
            int customerSalary,
            int customerCity)
        {
            SqlCommand cmd = new SqlCommand("PupdateCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerId", customerId);
            cmd.Parameters.AddWithValue("@CustomerName", customerName);
            cmd.Parameters.AddWithValue("@CustomerFamilyName", customerFamilyName);
            cmd.Parameters.AddWithValue("@CustomerJob", customerJob);
            cmd.Parameters.AddWithValue("@CustomerSalary", customerSalary);
            cmd.Parameters.AddWithValue("@CustomerCity", customerCity);


            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataSet cmd_data_set = new DataSet();
            sqlDa.Fill(cmd_data_set);

            return true;
        }

        public Boolean delete(int customerId)
        {
            SqlCommand cmd = new SqlCommand("PdeleteCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerId", customerId);


            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataSet cmd_data_set = new DataSet();
            sqlDa.Fill(cmd_data_set);

            return true;
        }

        public int fetchByJobs(int customerJobId)
        {
            SqlCommand cmd = new SqlCommand("PfetchCustomersByjob", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerJobId", customerJobId);

            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable data_table = new DataTable();
            sqlDa.Fill(data_table);

            return Convert.ToInt32(data_table.Rows.Count.ToString());
        }

        public int fetchByCity(int customerJobId)
        {
            SqlCommand cmd = new SqlCommand("PfetchCustomersByCity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerCityId", customerJobId);

            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable data_table = new DataTable();
            sqlDa.Fill(data_table);

            return Convert.ToInt32(data_table.Rows.Count.ToString());
        }
    }
}
